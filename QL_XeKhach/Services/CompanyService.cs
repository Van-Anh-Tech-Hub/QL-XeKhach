using MongoDB.Bson;
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

        public async Task DeleteCompany(string id)
        {
            await _companies.DeleteOneAsync(c => c.Id == id);
        }
        public async Task<Bus> GetBusByIdAsync(string busId)
        {
            var filter = Builders<BusCompany>.Filter.ElemMatch(bc => bc.Buses, b => b.Id == busId);

            var busCompany = await _companies
                .Find(filter)
                .FirstOrDefaultAsync();

            return busCompany?.Buses.FirstOrDefault(b => b.Id == busId);
        }
        public async Task<BusCompany> GetBusCompanyByBusIdAsync(string busId)
        {
            var filter = Builders<BusCompany>.Filter.ElemMatch(
                bc => bc.Buses, bus => bus.Id == busId);

            return await _companies.Find(filter).FirstOrDefaultAsync();
        }
        public async Task<BusCompany> GetBusCompanyByDriverIdAsync(string driverId)
        {
            var filter = Builders<BusCompany>.Filter.ElemMatch(
                bc => bc.Drivers, driver => driver.Id == driverId);

            // Tìm BusCompany đầu tiên khớp với filter
            return await _companies.Find(filter).FirstOrDefaultAsync();
        }
        public async Task<Bus> GetBusFromCompany(
            string companyId,
            Expression<Func<Bus, bool>> filter = null)
        {
            var company = await GetCompany(c => c.Id == companyId);
            var query = company?.Buses.AsQueryable();

            if (filter != null)
            {
                return query?.FirstOrDefault(filter);
            }

            return query?.FirstOrDefault();
        }

        public async Task<List<Bus>> GetBusesFromCompany(
            string companyId,
            Expression<Func<Bus, bool>> filter = null)
        {
            var company = await GetCompany(c => c.Id == companyId);
            var query = company?.Buses.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query?.ToList() ?? new List<Bus>();
        }
        public async Task AddBusToCompany(string companyId, Bus bus)
        {
            if (string.IsNullOrEmpty(bus.Id))
            {
                bus.Id = ObjectId.GenerateNewId().ToString();
            }

            var filter = Builders<BusCompany>.Filter.Eq(c => c.Id, companyId);
            var update = Builders<BusCompany>.Update.Push(c => c.Buses, bus);
            await _companies.UpdateOneAsync(filter, update);
        }


        public async Task RemoveBusFromCompany(string companyId, string busId)
        {
            var filter = Builders<BusCompany>.Filter.Eq(c => c.Id, companyId);
            var update = Builders<BusCompany>.Update.PullFilter(c => c.Buses, b => b.Id == busId);
            await _companies.UpdateOneAsync(filter, update);
        }

        public async Task UpdateBusInCompany(string companyId, string busId, Bus updatedBus)
        {
            var filter = Builders<BusCompany>.Filter.And(
                Builders<BusCompany>.Filter.Eq(c => c.Id, companyId),
                Builders<BusCompany>.Filter.ElemMatch(c => c.Buses, b => b.Id == busId)
            );

            var update = Builders<BusCompany>.Update
                .Set("Buses.$.Model", updatedBus.Model)
                .Set("Buses.$.SeatCount", updatedBus.SeatCount)
                .Set("Buses.$.LicensePlate", updatedBus.LicensePlate)
                .Set("Buses.$.UpdatedAt", DateTime.UtcNow);

            await _companies.UpdateOneAsync(filter, update);
        }

        public async Task<Driver> GetDriverFromCompany(
            string companyId,
            Expression<Func<Driver, bool>> filter = null)
        {
            var company = await GetCompany(c => c.Id == companyId);
            var query = company?.Drivers.AsQueryable();

            if (filter != null)
            {
                return query?.FirstOrDefault(filter);
            }

            return query?.FirstOrDefault();
        }

        public async Task<List<Driver>> GetDriversFromCompany(
            string companyId,
            Expression<Func<Driver, bool>> filter = null)
        {
            var company = await GetCompany(c => c.Id == companyId);
            var query = company?.Drivers.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query?.ToList() ?? new List<Driver>();
        }

        public async Task AddDriverToCompany(string companyId, Driver driver)
        {
            if (string.IsNullOrEmpty(driver.Id))
            {
                driver.Id = ObjectId.GenerateNewId().ToString();
            }
            var filter = Builders<BusCompany>.Filter.Eq(c => c.Id, companyId);
            var update = Builders<BusCompany>.Update.Push(c => c.Drivers, driver);
            await _companies.UpdateOneAsync(filter, update);
        }

        public async Task RemoveDriverFromCompany(string companyId, string driverId)
        {
            var filter = Builders<BusCompany>.Filter.Eq(c => c.Id, companyId);
            var update = Builders<BusCompany>.Update.PullFilter(c => c.Drivers, d => d.Id == driverId);
            await _companies.UpdateOneAsync(filter, update);
        }

        public async Task UpdateDriverInCompany(string companyId, string driverId, Driver updatedDriver)
        {
            var filter = Builders<BusCompany>.Filter.And(
                Builders<BusCompany>.Filter.Eq(c => c.Id, companyId),
                Builders<BusCompany>.Filter.ElemMatch(c => c.Drivers, d => d.Id == driverId)
            );

            var update = Builders<BusCompany>.Update
                .Set("Drivers.$.Name", updatedDriver.Name)
                .Set("Drivers.$.Position", updatedDriver.Position)
                .Set("Drivers.$.PhoneNumber", updatedDriver.PhoneNumber)
                .Set("Drivers.$.Email", updatedDriver.Email)
                .Set("Drivers.$.YearsOfExperience", updatedDriver.YearsOfExperience)
                .Set("Drivers.$.UpdatedAt", DateTime.UtcNow);

            await _companies.UpdateOneAsync(filter, update);
        }


    }
}
