using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XeKhach.Models
{
    public class Ticket
    {
        public string TicketCode { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string TripId { get; set; }  // Id của chuyến xe
        public string SeatNumber { get; set; }  // Số ghế đã đặt
        public decimal Price { get; set; }  // Giá vé
        public DateTime PurchaseDate { get; set; }  // Ngày mua vé

        public Ticket(string tripId, string seatNumber, decimal price)
        {
            TicketCode = Helper.GenerateRandomCode(12);
            TripId = tripId;
            SeatNumber = seatNumber;
            Price = price;
            PurchaseDate = DateTime.UtcNow;
        }
    }
}
