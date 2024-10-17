using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using QL_XeKhach.Models;
using QL_XeKhach.Services;

namespace QL_XeKhach.GUI
{
    public partial class frmManageBusCompanies : Form
    {
        private readonly CompanyService _companyService;
        public frmManageBusCompanies()
        {
            InitializeComponent();
            this.Load += FrmManageBusCompanies_Load;
            _companyService = new CompanyService();
        }

        private void FrmManageBusCompanies_Load(object sender, EventArgs e)
        {
            loadDataBusCompanies();
            txtNameCom.Focus();
        }

        //Function load dữ liệu cho bảng
        private async void loadDataBusCompanies()
        {
            var busCompanyService = new CompanyService(/* truyền MongoDB database context */);

            List<BusCompany> companies = await busCompanyService.GetCompanies();

            if (companies != null && companies.Count > 0)
            {
                dgvCombus.DataSource = companies;
                txtName.Text = $"Xin chào, {UserSession.LoggedInUser.Fullname}";
            }
            else
            {
                MessageBox.Show("Không tìm thấy công ty.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                BusCompany com = new BusCompany
                {
                    CompanyName = txtNameCom.Text,
                    PhoneNumber = txtPhoneNum.Text,
                    Email = txtEmail.Text,
                    HeadquartersAddress = txtAddress.Text
                };
                // Kiểm tra
                if (!await ValidateCompanyInput(com))
                {
                    return; // Nếu không hợp lệ, thoát khỏi hàm
                }
                // Gọi phương thức thông qua đối tượng _companyService
                await _companyService.CreateCompany(com);
                loadDataBusCompanies();
                MessageBox.Show("Công ty đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Clean()
        {
            txtNameCom.Text = "";
            txtAddress.Text = "";
            txtPhoneNum.Text = "";
            txtEmail.Text = "";
            txtNameCom.Focus();
        }
        string selectedCompanyId;
        private void dgvCombus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nếu e.RowIndex >= 0, có nghĩa là người dùng đã chọn một dòng
            {
                // Lấy thông tin ID của công ty từ cột chứa ID (thay "Id" bằng tên cột thực tế)
                var selectedRow = dgvCombus.Rows[e.RowIndex];
                selectedCompanyId = selectedRow.Cells["Id"].Value.ToString(); // Lưu ID công ty đã chọn

                // Có thể cập nhật các ô khác trên form nếu cần, ví dụ: hiển thị thông tin công ty trong các ô nhập liệu
                txtNameCom.Text = selectedRow.Cells["CompanyName"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["HeadquartersAddress"].Value.ToString();
                txtPhoneNum.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
               
            }
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có công ty nào được chọn không
                if (dgvCombus.SelectedRows.Count > 0) // Kiểm tra nếu có ít nhất một dòng được chọn
                {
                    // Xác nhận trước khi xóa
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các công ty đã chọn không?",
                                                         "Xác nhận xóa",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Tạo danh sách ID của các công ty sẽ xóa
                        List<string> companyIdsToDelete = new List<string>();

                        foreach (DataGridViewRow row in dgvCombus.SelectedRows)
                        {
                            var companyId = row.Cells["Id"].Value.ToString(); // Lấy ID công ty từ cột "Id"
                            companyIdsToDelete.Add(companyId);
                        }

                        // Gọi phương thức xóa cho từng công ty
                        await _companyService.DeleteCompany(companyIdsToDelete); // Gọi phương thức xóa với danh sách
                        MessageBox.Show("Công ty đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataBusCompanies(); // Tải lại dữ liệu
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một công ty để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có công ty nào được chọn không
                if (!string.IsNullOrEmpty(selectedCompanyId)) // Biến này cần phải được thiết lập khi người dùng chọn một dòng
                {
                    // Tạo một đối tượng BusCompany mới với thông tin đã cập nhật
                    BusCompany updatedCompany = new BusCompany
                    {
                        Id = selectedCompanyId, // Giả sử bạn đã lưu ID của công ty đã chọn
                        CompanyName = txtNameCom.Text,
                        PhoneNumber = txtPhoneNum.Text,
                        Email = txtEmail.Text,
                        HeadquartersAddress = txtAddress.Text
                    };
                    // Gọi phương thức cập nhật trong service
                    await _companyService.UpdateCompany(selectedCompanyId, updatedCompany);
                    MessageBox.Show("Thông tin công ty đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu
                    loadDataBusCompanies();
                    Clean();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một công ty để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> ValidateCompanyInput(BusCompany company)
        {
            // Kiểm tra xem tên công ty có trống không
            if (string.IsNullOrWhiteSpace(company.CompanyName))
            {
                MessageBox.Show("Tên công ty không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(company.HeadquartersAddress))
            {
                MessageBox.Show("Địa chỉ trụ sở không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(company.PhoneNumber))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra email
            if (string.IsNullOrWhiteSpace(company.Email))
            {
                MessageBox.Show("Email không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Kiểm tra định dạng email
            try
            {
                var addr = new System.Net.Mail.MailAddress(company.Email);
                if (addr.Address != company.Email)
                {
                    MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra số điện thoại (bạn có thể tùy chỉnh điều kiện này theo nhu cầu)
            if (!System.Text.RegularExpressions.Regex.IsMatch(company.PhoneNumber, @"^\d{10,11}$"))
            {
                MessageBox.Show("Số điện thoại phải chứa từ 10 đến 11 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var existingCompaniesName = await _companyService.GetCompanies(c => c.CompanyName == company.CompanyName);
            if (existingCompaniesName.Count > 0)
            {
                MessageBox.Show("Tên công ty này đã tồn tại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Kiểm tra trùng lặp email (bạn có thể cần một phương thức để kiểm tra điều này từ cơ sở dữ liệu)
            var existingCompaniesEmail = await _companyService.GetCompanies(c => c.Email == company.Email);
            if (existingCompaniesEmail.Count > 0)
            {
                MessageBox.Show("Email đã tồn tại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private async Task SearchCompanies(string searchTerm)
        {
            var busCompanyService = new CompanyService();

            if (UserSession.LoggedInUser.BusCompanyId != null)
            {
                List<BusCompany> companies;

                // Nếu có từ khóa tìm kiếm, lọc danh sách công ty
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    companies = await busCompanyService.GetCompanies(c => c.CompanyName.Contains(searchTerm));
                }
                else
                {
                    // Nếu không có từ khóa, lấy tất cả công ty
                    companies = await busCompanyService.GetCompanies();
                }

                if (companies != null && companies.Count > 0)
                {
                    dgvCombus.DataSource = companies;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy công ty.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            await SearchCompanies(searchTerm); // Gọi hàm tìm kiếm
        }

        private async void btnShowAll_Click(object sender, EventArgs e)
        {
            loadDataBusCompanies();
            txtSearch.Text = "";
        }
    }
}
