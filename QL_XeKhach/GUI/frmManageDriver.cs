using MongoDB.Bson;
using QL_XeKhach.Models;
using QL_XeKhach.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_XeKhach.GUI
{
    public partial class frmManageDriver : Form
    {
        private static CompanyService companyService = new CompanyService();

        public frmManageDriver()
        {
            InitializeComponent();
            this.Load += FrmManageDriver_Load;
        }

        private async void FrmManageDriver_Load(object sender, EventArgs e)
        {
            BusCompany company = await companyService.GetCompany(u => u.Id == UserSession.LoggedInUser.BusCompanyId);
            LoadDgvDriver(company.Drivers);
        }
        private void LoadDgvDriver(List<Driver> drivers)
        {
            if (UserSession.LoggedInUser.BusCompanyId != null)
            {
                if (drivers != null && drivers.Any())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("Name");
                    dataTable.Columns.Add("Position");
                    dataTable.Columns.Add("PhoneNumber");
                    dataTable.Columns.Add("Email");
                    dataTable.Columns.Add("YearsOfExperience");
                    dataTable.Columns.Add("created_at");
                    dataTable.Columns.Add("updated_at");


                    // Thêm dữ liệu vào DataTable
                    foreach (var driver in drivers)
                    {
                        dataTable.Rows.Add(driver.Id, driver.Name, driver.Position, driver.PhoneNumber, driver.Email, driver.YearsOfExperience, driver.CreatedAt, driver.UpdatedAt);
                    }

                    dgv_Driver.DataSource = dataTable;

                    // Đặt lại tiêu đề cột
                    dgv_Driver.Columns["Id"].Width = 150;
                    dgv_Driver.Columns["Name"].HeaderText = "Họ và tên";
                    dgv_Driver.Columns["Name"].Width = 150;
                    dgv_Driver.Columns["Position"].HeaderText = "Vị trí";
                    dgv_Driver.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
                    dgv_Driver.Columns["YearsOfExperience"].HeaderText = "Năm kinh nghiệm";
                    dgv_Driver.Columns["created_at"].HeaderText = "Ngày thêm";
                    dgv_Driver.Columns["updated_at"].HeaderText = "Ngày cập nhật";
                }
                else
                {
                    dgv_Driver.DataSource = null;
                    dgv_Driver.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private async void ReloadDgvDriver()
        {
            BusCompany company = await companyService.GetCompany(u => u.Id == UserSession.LoggedInUser.BusCompanyId);
            LoadDgvDriver(company.Drivers);
        }

        private void dgv_Driver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Driver.ClearSelection();
                dgv_Driver.Rows[e.RowIndex].Selected = true;

                DataTable dataTable = (DataTable)dgv_Driver.DataSource;

                string id = dataTable.Rows[e.RowIndex]["Id"].ToString();
                string name = dataTable.Rows[e.RowIndex]["Name"].ToString();
                string position = dataTable.Rows[e.RowIndex]["Position"].ToString();
                string phoneNumber = dataTable.Rows[e.RowIndex]["PhoneNumber"].ToString();
                string email = dataTable.Rows[e.RowIndex]["Email"].ToString();
                string yoe = dataTable.Rows[e.RowIndex]["YearsOfExperience"].ToString();
                string createdAt = dataTable.Rows[e.RowIndex]["created_at"].ToString();
                string updatedAt = dataTable.Rows[e.RowIndex]["updated_at"].ToString();


                txtId.Text = id;
                txtName.Text = name;
                txtPosition.Text = position;
                txtPhoneNumber.Text = phoneNumber;
                txtEmail.Text = email;
                txtYOE.Text = yoe;
                txtCreatedAt.Text = createdAt;
                txtUpdatedAt.Text = updatedAt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId_Search.Text = string.Empty;
            txtName_Search.Text = string.Empty;
            txtPhoneNumber_Search.Text = string.Empty;
            txtEmail_Search.Text = string.Empty;
            txtYOE_Search.Text = string.Empty;
            ReloadDgvDriver();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtId_Search.Text.Trim();
            string name = txtName_Search.Text.Trim();
            string phoneNumber = txtPhoneNumber_Search.Text.Trim();
            string email = txtEmail_Search.Text.Trim();
            string yoe = txtYOE_Search.Text.Trim();

            Expression<Func<Driver, bool>> filter = driver =>
                (string.IsNullOrEmpty(id) || driver.Id == id) &&
                (string.IsNullOrEmpty(name) || driver.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(phoneNumber) || driver.PhoneNumber.Contains(phoneNumber)) &&
                (string.IsNullOrEmpty(email) || driver.Email.Contains(email)) &&
                (string.IsNullOrEmpty(yoe) || driver.YearsOfExperience == int.Parse(yoe));

            List<Driver> drivers = await companyService.GetDriversFromCompany(UserSession.LoggedInUser.BusCompanyId, filter);
            LoadDgvDriver(drivers);
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            int yearsOfExperience = int.Parse(txtYOE.Text.Trim());

            Driver newDriver = new Driver
            {
                Name = name,
                Position = position,
                PhoneNumber = phoneNumber,
                Email = email,
                YearsOfExperience = yearsOfExperience,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await companyService.AddDriverToCompany(UserSession.LoggedInUser.BusCompanyId, newDriver);

            MessageBox.Show("Thêm tài xế thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadDgvDriver();
        }


        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn tài xế để cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = txtId.Text.Trim();
            string name = txtName.Text.Trim();
            string position = txtPosition.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            int yearsOfExperience = int.Parse(txtYOE.Text.Trim());

            Driver updatedDriver = new Driver
            {
                Id = id,
                Name = name,
                Position = position,
                PhoneNumber = phoneNumber,
                Email = email,
                YearsOfExperience = yearsOfExperience,
                UpdatedAt = DateTime.UtcNow
            };

            await companyService.UpdateDriverInCompany(UserSession.LoggedInUser.BusCompanyId, id, updatedDriver);

            MessageBox.Show("Cập nhật tài xế thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadDgvDriver(); 
        }


        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn tài xế để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Bạn có chắc muốn xóa tài xế này?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                await companyService.RemoveDriverFromCompany(UserSession.LoggedInUser.BusCompanyId, txtId.Text.Trim());

                MessageBox.Show("Xóa tài xế thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadDgvDriver();
            }
        }
        private void btnResetAction_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPosition.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtYOE.Text = string.Empty;
            txtCreatedAt.Text = string.Empty;
            txtUpdatedAt.Text = string.Empty;
        }

    }
}
