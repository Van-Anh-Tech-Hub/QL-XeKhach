using MongoDB.Driver;
using MongoDB.Driver.Linq;
using QL_XeKhach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace QL_XeKhach.Services
{
    public class TripService
    {
        private readonly IMongoCollection<Trip> _trips;
        private readonly MongoDbContext _dbContext;
        private readonly IMongoCollection<Invoice> _invoices;

        public TripService()
        {
            _dbContext = new MongoDbContext();
            _trips = _dbContext.Trips;
        }

        // Lấy tất cả các chuyến xe với filter và orderBy
        public async Task<List<Trip>> GetTrips(
            Expression<Func<Trip, bool>> filter = null,
            Func<IMongoQueryable<Trip>, IOrderedQueryable<Trip>> orderBy = null)
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

            return await query.ToListAsync();
        }

        public async Task<Trip> GetTrip(Expression<Func<Trip, bool>> filter = null)
        {
            var query = _trips.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.FirstOrDefaultAsync();
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
