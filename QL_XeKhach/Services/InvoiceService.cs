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
    public class InvoiceService
    {
        private readonly IMongoCollection<Invoice> _invoices;
        private readonly MongoDbContext _dbContext;

        public InvoiceService()
        {
            _dbContext = new MongoDbContext();
            _invoices = _dbContext.Invoices; // Assume Invoices is defined in your MongoDbContext
        }

        // Lấy tất cả hóa đơn với filter và orderBy
        public async Task<List<Invoice>> GetInvoices(
            Expression<Func<Invoice, bool>> filter = null,
            Func<IMongoQueryable<Invoice>, IOrderedQueryable<Invoice>> orderBy = null)
        {
            var query = _invoices.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = (IMongoQueryable<Invoice>)orderBy(query);
            }

            return await query.ToListAsync();
        }

        // Lấy một hóa đơn theo tùy chọn filter
        public async Task<Invoice> GetInvoice(Expression<Func<Invoice, bool>> filter = null)
        {
            var query = _invoices.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task CreateInvoice(Invoice invoice)
        {
            await _invoices.InsertOneAsync(invoice);
        }
        public async Task UpdateInvoice(string id, Invoice updatedInvoice)
        {
            await _invoices.ReplaceOneAsync(i => i.Id == id, updatedInvoice);
        }

        // Xóa hóa đơn
        public async Task DeleteInvoice(string id)
        {
            await _invoices.DeleteOneAsync(i => i.Id == id);
        }
    }
}
