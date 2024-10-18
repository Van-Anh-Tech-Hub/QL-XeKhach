using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace QL_XeKhach.Models
{
    public class Bus
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string Id { get; set; }

        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public Bus()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Bus(string licensePlate, string model, int seatCount) : this()
        {
            LicensePlate = licensePlate;
            Model = model;
            SeatCount = seatCount;
        }

        public void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
