﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XeKhach.Models
{
    public class Trip
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        // Mã chuyến xe (để nhận diện)
        public string TripCode { get; set; }

        // Điểm khởi hành và điểm đến
        [BsonRepresentation(BsonType.ObjectId)]
        public string DepartureLocationId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string DestinationId { get; set; }

        // Thời gian khởi hành và dự kiến kết thúc
        public DateTime DepartureTime { get; set; }
        public DateTime EstimatedArrivalTime { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string BusCompanyId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string DriverId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string BusId { get; set; }

        // Giá chuyến xe
        public decimal Price { get; set; }

        // Danh sách ghế ngồi và trạng thái đặt chỗ
        public List<Seat> Seats { get; set; } = new List<Seat>();

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [BsonIgnore]
        public BusCompany BusCompany { get; set; }

        [BsonIgnore]
        public Driver Driver { get; set; }
        [BsonIgnore]
        public Bus Bus { get; set; }
        [BsonIgnore]
        public Province DepartureLocation { get; set; }
        [BsonIgnore]
        public Province Destination { get; set; }

        public Trip()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Trip(string departureLocationId, string destinationId, DateTime departureTime, DateTime estimatedArrivalTime, string driverId, string busId, decimal price) : this()
        {
            TripCode = Helper.GenerateRandomCode(10);
            DepartureLocationId = departureLocationId;
            DestinationId = destinationId;
            DepartureTime = departureTime;
            EstimatedArrivalTime = estimatedArrivalTime;
            DriverId = driverId;
            BusId = busId;
            Price = price;
        }

        public void CreateSeats(int seatCount)
        {
            for (int i = 1; i <= seatCount; i++)
            {
                string seatNumber = $"S{i}";
                if (!IsSeatNumberUnique(seatNumber))
                {
                    throw new ArgumentException($"Ghế {seatNumber} đã tồn tại.");
                }
                Seats.Add(new Seat(seatNumber));
            }
        }

        // Phương thức kiểm tra tính duy nhất của SeatNumber
        public bool IsSeatNumberUnique(string seatNumber)
        {
            return Seats.All(seat => seat.SeatNumber != seatNumber);
        }

        // Phương thức thêm ghế, đảm bảo tính duy nhất
        public void AddSeat(string seatNumber)
        {
            if (!IsSeatNumberUnique(seatNumber))
            {
                throw new ArgumentException($"Ghế {seatNumber} đã tồn tại.");
            }
            Seats.Add(new Seat(seatNumber));
            Update();
        }

        public void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }

}
