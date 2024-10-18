using MongoDB.Driver;
using MongoDB.Driver.Linq;
using QL_XeKhach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace QL_XeKhach.Services
{
    public class TripService
    {
        private readonly IMongoCollection<Trip> _trips;
        private readonly MongoDbContext _dbContext;
        private readonly CompanyService _companyService;
        private readonly ProvinceService _provinceService;
        private readonly IMongoCollection<Invoice> _invoices;

        public TripService()
        {
            _dbContext = new MongoDbContext();
            _trips = _dbContext.Trips;
            _companyService = new CompanyService();
            _provinceService = new ProvinceService();
        }

        public async Task<List<Trip>> GetTrips(
            Expression<Func<Trip, bool>> filter = null,
            Func<IMongoQueryable<Trip>, IOrderedQueryable<Trip>> orderBy = null,
            bool includeReferences = false)
        {
            var query = _trips.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = (IMongoQueryable<Trip>)orderBy(query);
            }

            var tripList = await query.ToListAsync();

            if (includeReferences)
            {
                foreach (var trip in tripList)
                {
                    await LoadTripReferences(trip);
                }
            }

            return tripList;
        }

        public async Task<Trip> GetTrip(Expression<Func<Trip, bool>> filter = null, bool includeReferences = false)
        {
            var query = _trips.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            var trip = await query.FirstOrDefaultAsync();

            if (includeReferences && trip != null)
            {
                await LoadTripReferences(trip);
            }

            return trip;
        }

        private async Task LoadTripReferences(Trip trip)
        {
            trip.BusCompany = await _companyService.GetCompany(c => c.Id == trip.BusCompanyId);
            trip.Driver = await _companyService.GetDriverFromCompany(trip.BusCompanyId, t => t.Id == trip.DriverId);
            trip.Bus = await _companyService.GetBusFromCompany(trip.BusCompanyId, t => t.Id == trip.BusId);
            trip.DepartureLocation = await _provinceService.GetProvince(p => p.Id == trip.DepartureLocationId);
            trip.Destination = await _provinceService.GetProvince(p => p.Id == trip.DestinationId);
        }


        // Thêm một chuyến xe mới
        public async Task CreateTrip(Trip trip)
        {
            // Kiểm tra xem có xe hoặc tài xế nào đã hoạt động trong khoảng thời gian này không
            if (await IsTimeSlotOccupied(trip.BusId, trip.DriverId, trip.DepartureTime, trip.EstimatedArrivalTime))
            {
                throw new InvalidOperationException("Có xe hoặc tài xế đang hoạt động trong khoảng thời gian này.");
            }

            // Thêm chuyến xe mới nếu không trùng lặp
            await _trips.InsertOneAsync(trip);
        }


        // Cập nhật thông tin chuyến xe
        public async Task UpdateTrip(string id, Trip updatedTrip)
        {
            // Lấy thông tin chuyến xe hiện tại
            var currentTrip = await GetTrip(t => t.Id == id);

            if (currentTrip == null)
            {
                throw new InvalidOperationException("Chuyến đi không tồn tại.");
            }

            // Kiểm tra xem có trùng lặp về thời gian hoạt động của xe và tài xế hay không
            if (await IsTimeSlotOccupied(updatedTrip.BusId, updatedTrip.DriverId, updatedTrip.DepartureTime, updatedTrip.EstimatedArrivalTime, id))
            {
                throw new InvalidOperationException("Có xe hoặc tài xế đang hoạt động trong khoảng thời gian này.");
            }

            // Kiểm tra nếu BusId thay đổi
            if (currentTrip.BusId != updatedTrip.BusId)
            {
                // Lấy số lượng ghế của xe buýt mới
                int newSeatCount = await GetSeatCountByBusId(updatedTrip.BusId);

                // Nếu số ghế mới ít hơn số ghế hiện tại, cắt bớt ghế
                if (newSeatCount < updatedTrip.Seats.Count)
                {
                    updatedTrip.Seats = updatedTrip.Seats.Take(newSeatCount).ToList();
                }
                // Nếu số ghế mới nhiều hơn, thêm ghế mới vào
                else if (newSeatCount > updatedTrip.Seats.Count)
                {
                    for (int i = updatedTrip.Seats.Count + 1; i <= newSeatCount; i++)
                    {
                        string seatNumber = $"S{i}";
                        if (!updatedTrip.IsSeatNumberUnique(seatNumber))
                        {
                            throw new ArgumentException($"Ghế {seatNumber} đã tồn tại.");
                        }
                        updatedTrip.Seats.Add(new Seat(seatNumber));
                    }
                }
            }

            // Cập nhật chuyến đi với số ghế mới
            await _trips.ReplaceOneAsync(t => t.Id == id, updatedTrip);
        }

        // Xóa một chuyến xe
        public async Task DeleteTrip(string id)
        {
            await _trips.DeleteOneAsync(t => t.Id == id);
        }

        // Thêm ghế vào chuyến xe
        public async Task AddSeatToTrip(string tripId, Seat seat)
        {
            var filter = Builders<Trip>.Filter.Eq(t => t.Id, tripId);
            var update = Builders<Trip>.Update.Push(t => t.Seats, seat);
            await _trips.UpdateOneAsync(filter, update);
        }

        // Lấy ghế theo số ghế
        public async Task<Seat> GetSeatFromTrip(string tripId, string seatNumber)
        {
            var trip = await GetTrip(t => t.Id == tripId);
            return trip?.Seats.FirstOrDefault(s => s.SeatNumber == seatNumber);
        }
        private async Task<bool> IsTimeSlotOccupied(string busId, string driverId, DateTime departureTime, DateTime estimatedArrivalTime, string tripId = null)
        {
            // Tìm tất cả các chuyến xe trùng lặp về tài xế hoặc xe buýt và không trùng với tripId hiện tại (nếu sửa)
            var conflictingTrips = await _trips.Find(t =>
                (t.BusId == busId || t.DriverId == driverId) &&
                (t.DepartureTime < estimatedArrivalTime && t.EstimatedArrivalTime > departureTime) &&
                (tripId == null || t.Id != tripId)  // Bỏ qua tripId hiện tại nếu đang sửa
            ).ToListAsync();

            // Nếu tồn tại chuyến xe trùng lặp thì trả về true
            return conflictingTrips.Any();
        }
        public async Task<int> GetSeatCountByBusId(string busId)
        {
            var bus = await _companyService.GetBusFromCompany(null, b => b.Id == busId);
            return bus?.SeatCount ?? 0;
        }

        public async Task<decimal> GetTotalRevenue()
        {
            var invoices = await _invoices.Find(_ => true).ToListAsync();
            decimal totalRevenue = 0;

            foreach (var invoice in invoices)
            {
                totalRevenue += invoice.Tickets.Sum(ticket => ticket.Price);
            }

            return totalRevenue;
        }
    }
}
