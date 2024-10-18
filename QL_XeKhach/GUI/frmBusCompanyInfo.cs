using QL_XeKhach.Models;
using QL_XeKhach.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_XeKhach.GUI
{
    public partial class frmBusCompanyInfo : Form
    {
        private static CompanyService companyService = new CompanyService();

        public frmBusCompanyInfo()
        {
            InitializeComponent();
            this.Load += FrmBusCompanyInfo_Load;
        }

        private async void FrmBusCompanyInfo_Load(object sender, EventArgs e)
        {
            BusCompany company = await companyService.GetCompany(u => u.Id == UserSession.LoggedInUser.BusCompanyId);
            LoadBusCompanyInfo(company);
            LoadDgvXe(company.Buses);
            LoadDgvNhanVien(company.Drivers);

        }
        private void LoadBusCompanyInfo(BusCompany bc)
        {
            lbCompanyName.Text = bc.CompanyName;
            lbHeadquartersAddress.Text = bc.HeadquartersAddress;
            lbPhoneNumber.Text = bc.PhoneNumber;
            label8.Text = bc.Email;
        }
        private void LoadDgvXe(List<Bus> buses)
        {
            if (buses != null && buses.Any())
            {
                lbTongSoXe.Text = buses.Count.ToString();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Model");
                dataTable.Columns.Add("LicensePlate");
                dataTable.Columns.Add("SeatCount");
                dataTable.Columns.Add("created_at");
                dataTable.Columns.Add("updated_at");


                // Thêm dữ liệu vào DataTable
                foreach (var bus in buses)
                {
                    dataTable.Rows.Add(bus.Model,bus.LicensePlate,bus.SeatCount,bus.CreatedAt,bus.UpdatedAt);
                }

                dgvXe.DataSource = dataTable;

                // Đặt lại tiêu đề cột
                dgvXe.Columns["Model"].HeaderText = "Kiểu xe";
                dgvXe.Columns["LicensePlate"].HeaderText = "Biển số xe";
                dgvXe.Columns["SeatCount"].HeaderText = "Số chỗ";
                dgvXe.Columns["created_at"].HeaderText = "Ngày thêm";
                dgvXe.Columns["updated_at"].HeaderText = "Ngày cập nhật";
            }
            else
            {
                dgvXe.DataSource = null;
                dgvXe.Rows.Clear();
            }
        }
        private void LoadDgvNhanVien(List<Driver> drivers)
        {
            if (drivers != null && drivers.Any())
            {
            lbTongNhanVien.Text = drivers.Count.ToString();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Position");
                dataTable.Columns.Add("PhoneNumber");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("YearsOfExperience");
                dataTable.Columns.Add("created_at");
                dataTable.Columns.Add("updated_at");

                foreach (var driver in drivers)
                {
                    dataTable.Rows.Add(driver.Name,driver.Position,driver.PhoneNumber,driver.Email,driver.YearsOfExperience,driver.CreatedAt,driver.UpdatedAt);
                }

                dgvNhanVien.DataSource = dataTable;


                // Đặt lại tiêu đề cột
                dgvNhanVien.Columns["Name"].HeaderText = "Họ và tên";
                dgvNhanVien.Columns["Position"].HeaderText = "Vị trí";
                dgvNhanVien.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
                dgvNhanVien.Columns["YearsOfExperience"].HeaderText = "Năm kinh nghiệm";
                dgvNhanVien.Columns["created_at"].HeaderText = "Ngày thêm";
                dgvNhanVien.Columns["updated_at"].HeaderText = "Ngày cập nhật";

            }
            else
            {
                dgvNhanVien.DataSource = null;
                dgvNhanVien.Rows.Clear();
            }
        }
    }
}
