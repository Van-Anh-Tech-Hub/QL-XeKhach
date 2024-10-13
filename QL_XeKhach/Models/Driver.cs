using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace QL_XeKhach.Models
{
    public class Driver
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int YearsOfExperience { get; set; }

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public Driver()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Driver(string name, string position, string phoneNumber, string email, int yearsOfExperience)
        {
            Name = name;
            Position = position;
            PhoneNumber = phoneNumber;
            Email = email;
            YearsOfExperience = yearsOfExperience;
        }

        public void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
