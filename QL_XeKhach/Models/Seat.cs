using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XeKhach.Models
{
    public class Seat
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string SeatNumber { get; set; } 
        public bool IsBooked { get; set; }

        public Seat(string seatNumber, bool isBooked = false)
        {
            SeatNumber = seatNumber;
            IsBooked = isBooked;
        }
    }
}
