using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XeKhach.Models
{
    public enum E_Role
    {
        ADMIN,
        TICKET_SALLER,    // Nhân viên bán vé
        COMPANY_EMPLOYEE  // Nhân viên của BusCompany
    }
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        [BsonRepresentation(BsonType.String)]
        public E_Role Role { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string BusCompanyId { get; set; }

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public User()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public User(string fullname,string email, string password, string phoneNumber, E_Role role, string busCompanyId = null) : this()
        {
            Fullname = fullname;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Role = role;
            BusCompanyId = busCompanyId;
        }

        public void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
