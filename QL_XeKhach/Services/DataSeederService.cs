using MongoDB.Driver;
using QL_XeKhach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XeKhach.Services
{
    public class DataSeederService
    {
        private readonly TripService _tripService;
        private readonly InvoiceService _invoiceService;
        private readonly CompanyService _companyService;
        private readonly UserService _userService;

        public DataSeederService()
        {
            _tripService = new TripService();
            _invoiceService = new InvoiceService();
            _companyService = new CompanyService();
            _userService = new UserService();
        }
        public async Task SeedData()
        {
            // Tạo user cho mỗi hóa đơn
            var user = new User
            {
                Fullname = "Vũ Văn Anh",
                Email = "admin@gmail.com",
                Password = Helper.HashPassword("Admin@123"),
                PhoneNumber = $"098765431",
                Role = E_Role.ADMIN,
            };
            await _userService.CreateUser(user);
            // Tạo danh sách công ty
            var companies = new List<BusCompany>
            {
                new BusCompany
                {
            CompanyName = "Công ty Vận Tải B",
            HeadquartersAddress = "Số 2, Đường XYZ, Hà Nội",
            PhoneNumber = "0123456788",
            Email = "contact@vantaitb.com",
            Buses = Enumerable.Range(1, 10).Select(i =>
                new Bus { LicensePlate = $"30A-1234{i}", Model = "Hyundai Universe", SeatCount = 45 }).ToList(),
            Drivers = Enumerable.Range(1, 20).Select(i =>
                new Driver($"Nguyễn Văn {i}", "Lái xe", $"09876543{i}", $"nguyenvan{i}@xekhach.com", i % 10)).ToList()
                },
        new BusCompany
        {
            CompanyName = "Công ty Vận Tải C",
            HeadquartersAddress = "Số 3, Đường DEF, Hải Phòng",
            PhoneNumber = "0123456787",
            Email = "contact@vantaitc.com",
            Buses = Enumerable.Range(1, 10).Select(i =>
                new Bus { LicensePlate = $"29B-5678{i}", Model = "Ford Transit", SeatCount = 16 }).ToList(),
            Drivers = Enumerable.Range(1, 20).Select(i =>
                new Driver($"Trần Văn {i}", "Lái xe", $"09888888{i}", $"tranvan{i}@xekhach.com", i % 5)).ToList()
        }
    };

            // Lưu công ty vào database
            foreach (var company in companies)
            {
                await _companyService.CreateCompany(company);

                // Tạo 10 chuyến đi cho mỗi công ty
                for (int i = 0; i < 10; i++)
                {
                    var trip = new Trip(
                        departureLocation: "Hà Nội",
                        destination: "Hải Phòng",
                        departureTime: DateTime.Now.AddDays(i),
                        estimatedArrivalTime: DateTime.Now.AddDays(i).AddHours(2),
                        driverId: company.Drivers[i].Id,
                        busId: company.Buses[i % company.Buses.Count].Id,
                        price: 150000m + (i * 5000),
                        seatCount: company.Buses[i % company.Buses.Count].SeatCount
                    );
                    await _tripService.CreateTrip(trip);

                    // Tạo 2 hóa đơn cho mỗi chuyến đi
                    var ticket1 = new Ticket(trip.Id, $"S{i + 1}", trip.Price);
                    var ticket2 = new Ticket(trip.Id, $"S{i + 2}", trip.Price);

                    var invoice = new Invoice(
                        customerName: $"Nguyễn Khách {i}",
                        customerPhoneNumber: $"09888888{i}",
                        tickets: new List<Ticket> { ticket1, ticket2 },
                        customerEmail: $"khachhang{i}@example.com"
                    );
                    await _invoiceService.CreateInvoice(invoice);
                }
            }

            Console.WriteLine("Data seeding completed for multiple companies.");
        }
    }

}
