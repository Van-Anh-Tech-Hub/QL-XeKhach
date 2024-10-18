using MongoDB.Driver;
using QL_XeKhach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_XeKhach.Services
{
    // Service thêm dữ liệu mẫu
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

            Console.WriteLine("Data seeding completed for multiple companies.");
        }
    }

}
