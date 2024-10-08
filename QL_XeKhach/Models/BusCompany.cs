using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace QL_XeKhach.Models
{
    public class BusCompany
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string CompanyName { get; set; }
        public string HeadquartersAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<Bus> Buses { get; set; }
        public List<Driver> Drivers { get; set; }

        // Thêm các trường CreatedAt và UpdatedAt
        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public BusCompany()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public BusCompany(string companyName, string headquartersAddress, string phoneNumber, string email)
            : this()
        {
            CompanyName = companyName;
            HeadquartersAddress = headquartersAddress;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public BusCompany(string companyName, string headquartersAddress, string phoneNumber, string email, List<Bus> buses, List<Driver> drivers)
            : this(companyName, headquartersAddress, phoneNumber, email)
        {
            Buses = buses;
            Drivers = drivers;
        }

        public void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
