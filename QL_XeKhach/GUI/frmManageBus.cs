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
using QL_XeKhach.Models;
using QL_XeKhach.Services;

namespace QL_XeKhach.GUI
{
    public partial class frmManageBus : Form
    {
        private static CompanyService companyService = new CompanyService();
        public frmManageBus()
        {
            InitializeComponent();
            this.Load += FrmManageBus_Load;
        }

        private async void FrmManageBus_Load(object sender, EventArgs e)
        {
            BusCompany company = await companyService.GetCompany(u => u.Id == UserSession.LoggedInUser.BusCompanyId);
            LoadDgvBus(company.Buses);
        }
        private void LoadDgvBus(List<Bus> buses)
        {
            if (UserSession.LoggedInUser.BusCompanyId != null)
            {
                if (buses != null && buses.Any())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("Model");
                    dataTable.Columns.Add("LicensePlate");
                    dataTable.Columns.Add("SeatCount");
                    dataTable.Columns.Add("created_at");
                    dataTable.Columns.Add("updated_at");


                    // Thêm dữ liệu vào DataTable
                    foreach (var bus in buses)
                    {
                        dataTable.Rows.Add(bus.Id, bus.Model, bus.LicensePlate, bus.SeatCount, bus.CreatedAt, bus.UpdatedAt);
                    }

                    dgv_Bus.DataSource = dataTable;

                    // Đặt lại tiêu đề cột
                    dgv_Bus.Columns["Id"].Width = 150;
                    dgv_Bus.Columns["Model"].HeaderText = "Kiểu xe";
                    dgv_Bus.Columns["Model"].Width = 150;
                    dgv_Bus.Columns["LicensePlate"].HeaderText = "Biển số xe";
                    dgv_Bus.Columns["SeatCount"].HeaderText = "Số chỗ";
                    dgv_Bus.Columns["created_at"].HeaderText = "Ngày thêm";
                    dgv_Bus.Columns["updated_at"].HeaderText = "Ngày cập nhật";
                }
                else
                {
                    dgv_Bus.DataSource = null;
                    dgv_Bus.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private async void ReloadDgvBus()
        {
            BusCompany company = await companyService.GetCompany(u => u.Id == UserSession.LoggedInUser.BusCompanyId);
            LoadDgvBus(company.Buses);
        }
        private void dgv_Bus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Bus.ClearSelection();
                dgv_Bus.Rows[e.RowIndex].Selected = true;

                DataTable dataTable = (DataTable)dgv_Bus.DataSource;

                string id = dataTable.Rows[e.RowIndex]["Id"].ToString();
                string model = dataTable.Rows[e.RowIndex]["Model"].ToString();
                string licensePlate = dataTable.Rows[e.RowIndex]["LicensePlate"].ToString();
                string seatCount = dataTable.Rows[e.RowIndex]["SeatCount"].ToString();
                string createdAt = dataTable.Rows[e.RowIndex]["created_at"].ToString();
                string updatedAt = dataTable.Rows[e.RowIndex]["updated_at"].ToString();


                txtId.Text = id;
                txtModel.Text = model;
                txtLicensePlate.Text = licensePlate;
                cboSeatCount.SelectedItem = seatCount;
                txtCreatedAt.Text = createdAt;
                txtUpdatedAt.Text = updatedAt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId_Search.Text = string.Empty;
            txtModel_Search.Text = string.Empty;
            txtLicensePlate_Search.Text = string.Empty;
            cboSeatCount_Search.SelectedIndex = -1;
            ReloadDgvBus();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtId_Search.Text.Trim();
            string model = txtModel_Search.Text.Trim();
            string licensePlate = txtLicensePlate_Search.Text.Trim();

            int? seatCount = null;
            if (cboSeatCount_Search.SelectedIndex >= 0)
            {
                if (int.TryParse(cboSeatCount_Search.SelectedItem.ToString(), out int parsedSeatCount))
                {
                    seatCount = parsedSeatCount;
                }
            }
            Expression<Func<Bus, bool>> filter = bus =>
                (string.IsNullOrEmpty(id) || bus.Id == id) &&
                (string.IsNullOrEmpty(model) || bus.Model.IndexOf(model, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(licensePlate) || bus.LicensePlate.Contains(licensePlate)) &&
                (!seatCount.HasValue || bus.SeatCount == seatCount.Value);

            List<Bus> buses = await companyService.GetBusesFromCompany(UserSession.LoggedInUser.BusCompanyId,filter);
            LoadDgvBus(buses);
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string licensePlate = txtLicensePlate.Text.Trim();
            string model = txtModel.Text.Trim();
            int seatCount = int.Parse(cboSeatCount.SelectedItem.ToString());

            Bus existingBus = await companyService.GetBusFromCompany(UserSession.LoggedInUser.BusCompanyId, b => b.LicensePlate == licensePlate);

            if (existingBus != null)
            {
                MessageBox.Show("Xe với biển số này đã tồn tại!", "Trùng Biển Số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bus newBus = new Bus
            {
                LicensePlate = licensePlate,
                Model = model,
                SeatCount = seatCount
            };

            await companyService.AddBusToCompany(UserSession.LoggedInUser.BusCompanyId, newBus);

            MessageBox.Show("Thêm xe thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadDgvBus();
        }


        private async void btnXoa_Click(object sender, EventArgs e)
        {
            string busId = txtId.Text.Trim();

            if (string.IsNullOrEmpty(busId))
            {
                MessageBox.Show("Vui lòng chọn xe để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa xe này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                await companyService.RemoveBusFromCompany(UserSession.LoggedInUser.BusCompanyId, busId);
                MessageBox.Show("Xóa xe thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadDgvBus();
            }
        }


        private async void btnSua_Click(object sender, EventArgs e)
        {
            string busId = txtId.Text.Trim();
            string licensePlate = txtLicensePlate.Text.Trim();
            string model = txtModel.Text.Trim();
            int seatCount = int.Parse(cboSeatCount.SelectedItem.ToString());

            if (string.IsNullOrEmpty(licensePlate))
            {
                MessageBox.Show("Vui lòng chọn xe để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc muốn sửa xe này không?", "Xác Nhận Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                Bus existingBus = await companyService.GetBusFromCompany(UserSession.LoggedInUser.BusCompanyId, b => b.LicensePlate == licensePlate);

                if (existingBus != null)
                {
                    MessageBox.Show("Xe với biển số này đã tồn tại!", "Trùng Biển Số", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Bus updatedBus = new Bus
                {
                    LicensePlate = licensePlate,
                    Model = model,
                    SeatCount = seatCount
                };

                await companyService.UpdateBusInCompany(UserSession.LoggedInUser.BusCompanyId, busId, updatedBus);
                MessageBox.Show("Sửa xe thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadDgvBus();
            }
        }

        private void ResetAllField()
        {
            txtId.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtLicensePlate.Text = string.Empty;
            cboSeatCount.SelectedItem = -1;
            txtCreatedAt.Text = string.Empty;
            txtUpdatedAt.Text = string.Empty;
        }
        private void btnResetAction_Click(object sender, EventArgs e)
        {
            ResetAllField();
        }
    }
}
