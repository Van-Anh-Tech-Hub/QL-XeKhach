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
    public class CompanyService
    {
        private readonly IMongoCollection<BusCompany> _companies;
        private readonly MongoDbContext _dbContext;

        public CompanyService()
        {
            _dbContext = new MongoDbContext();
            _companies = _dbContext.BusCompanies;
        }

        public CompanyService(MongoDbContext dbContext)
        {
            _companies = dbContext.BusCompanies;
        }

        public async Task<List<BusCompany>> GetCompanies(
            Expression<Func<BusCompany, bool>> filter = null,
            Func<IMongoQueryable<BusCompany>, IOrderedQueryable<BusCompany>> orderBy = null)
        {
            var query = _companies.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = (IMongoQueryable<BusCompany>)orderBy(query); 
            }

            return await query.ToListAsync();
        }

        public async Task<BusCompany> GetCompany(
            Expression<Func<BusCompany, bool>> filter = null)
        {
            var query = _companies.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task CreateCompany(BusCompany company)
        {
            await _companies.InsertOneAsync(company);
        }

        public async Task UpdateCompany(string id, BusCompany updatedCompany)
        {
            await _companies.ReplaceOneAsync(c => c.Id == id, updatedCompany);
        }

        public async Task DeleteCompany(List<string> id)
        {
            var filter = Builders<BusCompany>.Filter.In(c => c.Id, id);
            await _companies.DeleteManyAsync(filter);
        }

        public async Task AddBusToCompany(string companyId, Bus bus)
        {
            var filter = Builders<BusCompany>.Filter.Eq(c => c.Id, companyId);
            var update = Builders<BusCompany>.Update.Push(c => c.Buses, bus);
            await _companies.UpdateOneAsync(filter, update);
        }

        public async Task RemoveBusFromCompany(string companyId, string licensePlate)
        {
            var filter = Builders<BusCompany>.Filter.Eq(c => c.Id, companyId);
            var update = Builders<BusCompany>.Update.PullFilter(c => c.Buses, b => b.LicensePlate == licensePlate);
            await _companies.UpdateOneAsync(filter, update);
        }

        public async Task UpdateBusInCompany(string companyId, string licensePlate, Bus updatedBus)
        {
            var filter = Builders<BusCompany>.Filter.And(
                Builders<BusCompany>.Filter.Eq(c => c.Id, companyId),
                Builders<BusCompany>.Filter.ElemMatch(c => c.Buses, b => b.LicensePlate == licensePlate)
            );

            var update = Builders<BusCompany>.Update
                .Set(c => c.Buses[-1].Model, updatedBus.Model)
                .Set(c => c.Buses[-1].SeatCount, updatedBus.SeatCount);

            await _companies.UpdateOneAsync(filter, update);
        }

        public async Task<Bus> GetBusFromCompany(string companyId, string licensePlate)
        {
            var company = await GetCompany(c=>c.Id==companyId);
            return company?.Buses.FirstOrDefault(b => b.LicensePlate == licensePlate);
        }

        public async Task AddEmployeeToCompany(string companyId, Driver driver)
        {
            var filter = Builders<BusCompany>.Filter.Eq(c => c.Id, companyId);
            var update = Builders<BusCompany>.Update.Push(c => c.Drivers, driver);
            await _companies.UpdateOneAsync(filter, update);
        }

        public async Task RemoveEmployeeFromCompany(string companyId, string employeeName)
        {
            var filter = Builders<BusCompany>.Filter.Eq(c => c.Id, companyId);
            var update = Builders<BusCompany>.Update.PullFilter(c => c.Drivers, e => e.Name == employeeName);
            await _companies.UpdateOneAsync(filter, update);
        }
    }
}
