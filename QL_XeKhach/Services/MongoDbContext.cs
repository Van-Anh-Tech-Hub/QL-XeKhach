using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver;
using QL_XeKhach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static MongoDB.Driver.WriteConcern;

namespace QL_XeKhach.Services
{
    public class MongoDbContext
    {
        private IMongoDatabase _database;

        public MongoDbContext()
        {
            string connectionString = "mongodb://localhost:27017/";
            string dbName = "ql_xekhach";
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(dbName);
        }
        public MongoDbContext(string connectionString, string dbName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(dbName);
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
        public IMongoCollection<BusCompany> BusCompanies => _database.GetCollection<BusCompany>("BusCompanies");
        public IMongoCollection<Trip> Trips => _database.GetCollection<Trip>("Trips");
        public IMongoCollection<Invoice> Invoices => _database.GetCollection<Invoice>("Invoices");
        public IMongoCollection<Province> Provinces => _database.GetCollection<Province>("Provinces");

    }
}
