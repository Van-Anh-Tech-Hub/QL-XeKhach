using MongoDB.Driver;
using MongoDB.Driver.Linq;
using QL_XeKhach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QL_XeKhach.Services
{
    public class ProvinceService
    {
        private readonly IMongoCollection<Province> _provinces;
        private readonly MongoDbContext _dbContext;

        public ProvinceService()
        {
            _dbContext = new MongoDbContext();
            _provinces = _dbContext.Provinces;
        }

        public async Task<List<Province>> GetProvinces(
            Expression<Func<Province, bool>> filter = null,
            Func<IMongoQueryable<Province>, IOrderedQueryable<Province>> orderBy = null)
        {
            var query = _provinces.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = (IMongoQueryable<Province>)orderBy(query);
            }

            return await query.ToListAsync();
        }

        public async Task<Province> GetProvince(
            Expression<Func<Province, bool>> filter = null)
        {
            var query = _provinces.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.FirstOrDefaultAsync();
        }

    }
}
