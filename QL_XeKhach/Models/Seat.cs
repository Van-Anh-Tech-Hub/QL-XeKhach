using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XeKhach.Models
{
    public class Seat
    {
        public string SeatNumber { get; set; } 
        public bool IsBooked { get; set; }

        public Seat(string seatNumber, bool isBooked = false)
        {
            SeatNumber = seatNumber;
            IsBooked = isBooked;
        }
    }
}
