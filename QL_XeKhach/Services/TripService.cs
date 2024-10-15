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
            await _trips.InsertOneAsync(trip);
        }

        // Cập nhật thông tin chuyến xe
        public async Task UpdateTrip(string id, Trip updatedTrip)
        {
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
    }
}
