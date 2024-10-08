using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XeKhach.Models
{
    public class Invoice
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        // Mã hóa đơn (để nhận diện)
        public string InvoiceCode { get; set; }

        // Thông tin khách hàng
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }

        // Danh sách vé đã mua
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

        // Tổng giá trị hóa đơn
        public decimal TotalAmount
        {
            get
            {
                return Tickets != null ? CalculateTotalAmount() : 0;
            }
        }

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public Invoice()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Invoice(string customerName, string customerPhoneNumber, string customerEmail = null) : this()
        {
            InvoiceCode = Helper.GenerateRandomCode(10);
            CustomerName = customerName;
            CustomerPhoneNumber = customerPhoneNumber;
            CustomerEmail = customerEmail;
        }

        public Invoice(string customerName, string customerPhoneNumber, List<Ticket> tickets, string customerEmail = null) : this(customerName, customerPhoneNumber, customerEmail)
        {
            Tickets = tickets;
        }


        // Thêm vé vào hóa đơn
        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
            Update();
        }

        // Tính tổng giá trị hóa đơn
        private decimal CalculateTotalAmount()
        {
            decimal total = 0;
            foreach (var ticket in Tickets)
            {
                total += ticket.Price;
            }
            return total;
        }

        public void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
