using MongoDB.Bson;
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
    public partial class frmBanVe : Form
    {
        private static TripService tripService = new TripService();
        private static CompanyService companyService = new CompanyService();
        private static ProvinceService provinceService = new ProvinceService();

        private List<Trip> _trips;
        private Trip selectedTrip;

        public frmBanVe()
        {
            InitializeComponent();
            provinceService = new ProvinceService();
            this.Load += FrmBanVe_Load;
            
        }
        
        public void loadCbTrangThai()
        {
            cboTrangThai.Items.Clear();

            // Add the status options directly
            cboTrangThai.Items.Add("Trống");   // Available
            cboTrangThai.Items.Add("Đã đặt");  // Booked
            //cboTrangThai.ValueMember= "Id";
            cboTrangThai.SelectedIndex = -1;
        }
        public async Task load_CbDepartureLocation()
        {
            try
            {
                List<Province> provinces = await provinceService.GetProvinces();
                cboDiemden.DataSource = provinces;
                cboDiemden.DisplayMember = "Name"; // Hiển thị tên tỉnh trong ComboBox
                cboDiemden.ValueMember = "Id";
                cboDiemden.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur (e.g., database issues)
                MessageBox.Show($"Error loading provinces: {ex.Message}");
            }
        }
        private async void LoadCboDepartureLocation()
        {
            List<Province> provinces = await provinceService.GetProvinces();
            cboDepartureLocation.DataSource = provinces;
            cboDepartureLocation.DisplayMember = "Name";
            cboDepartureLocation.ValueMember = "Id";
            cboDepartureLocation.SelectedIndex = -1;
        }
        private async void FrmBanVe_Load(object sender, EventArgs e) // Sự kiện khi form được tải
        {
            await load_CbDepartureLocation();
            LoadCboDepartureLocation();
            
            loadCbTrangThai();
        }
        public async Task LoadTrips()
        {
            if (cboDiemden.SelectedValue != null)
            {

                var selectedProvinceId = cboDiemden.SelectedValue.ToString();

                List<Trip> trips = await tripService.GetTrips(t => t.BusCompanyId == UserSession.LoggedInUser.BusCompanyId && t.DestinationId==selectedProvinceId , null, true);
                if (trips == null || trips.Count == 0)
                {
                    MessageBox.Show("No trips found for the selected destination.");
                    return;
                }
                _trips = trips;
                LoadDgvTrip(trips);
                
            }
        }

        private void LoadDgvTrip(List<Trip> trips)
        {
            if (UserSession.LoggedInUser.BusCompanyId != null)
            {
                if (trips != null && trips.Any())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("TripCode");
                    dataTable.Columns.Add("DepartureLocationId");
                    dataTable.Columns.Add("DestinationId");
                    dataTable.Columns.Add("DepartureTime");
                    dataTable.Columns.Add("EstimatedArrivalTime");
                    dataTable.Columns.Add("DriverId");
                    dataTable.Columns.Add("BusId");
                    dataTable.Columns.Add("Price");
                    dataTable.Columns.Add("DriverName");
                    dataTable.Columns.Add("BusModel");
                    dataTable.Columns.Add("LicensePlate");
                    dataTable.Columns.Add("SeatCount");
                    dataTable.Columns.Add("DepartureLocation");
                    dataTable.Columns.Add("Destination");
                    dataTable.Columns.Add("created_at");
                    dataTable.Columns.Add("updated_at");


                    // Thêm dữ liệu vào DataTable
                    foreach (var trip in trips)
                    {
                        dataTable.Rows.Add(
                            trip?.Id,
                            trip?.TripCode,
                            trip?.DepartureLocationId,
                            trip?.DestinationId,
                            trip?.DepartureTime,
                            trip?.EstimatedArrivalTime,
                            trip?.DriverId,
                            trip?.BusId,
                            trip?.Price,
                            trip?.Driver?.Name,
                            trip?.Bus?.Model,
                            trip?.Bus?.LicensePlate,
                            trip?.Bus?.SeatCount,
                            trip?.DepartureLocation?.Name,
                            trip?.Destination?.Name,
                            trip?.CreatedAt,
                            trip?.UpdatedAt
                        );
                    }

                    dgvTrips.DataSource = dataTable;

                    dgvTrips.Columns["Id"].Visible = false;
                    dgvTrips.Columns["TripCode"].HeaderText = "Mã chuyến xe";
                    dgvTrips.Columns["TripCode"].Width = 120;
                    dgvTrips.Columns["DepartureLocationId"].Visible = false;
                    dgvTrips.Columns["DestinationId"].Visible = false;
                    dgvTrips.Columns["DepartureTime"].HeaderText = "Thời gian khởi hành dự kiến";
                    dgvTrips.Columns["EstimatedArrivalTime"].HeaderText = "Thời gian đến dự kiến";
                    dgvTrips.Columns["DriverId"].Visible = false;
                    dgvTrips.Columns["BusId"].Visible = false;
                    dgvTrips.Columns["Price"].HeaderText = "Giá";
                    dgvTrips.Columns["DriverName"].HeaderText = "Tên tài xế";
                    dgvTrips.Columns["BusModel"].HeaderText = "Kiểu xe";
                    dgvTrips.Columns["LicensePlate"].HeaderText = "Biển số";
                    dgvTrips.Columns["SeatCount"].HeaderText = "Số chỗ";
                    dgvTrips.Columns["DepartureLocation"].HeaderText = "Điểm khởi hành";
                    dgvTrips.Columns["Destination"].HeaderText = "Điểm kết thúc";
                    dgvTrips.Columns["created_at"].HeaderText = "Ngày tạo";
                    dgvTrips.Columns["updated_at"].HeaderText = "Ngày cập nhật";
                }
                else
                {
                    dgvTrips.DataSource = null;
                    dgvTrips.Rows.Clear();
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
            await LoadTrips();
        }
        private async void cboDiemden_SelectedIndexChanged(object sender, EventArgs e)
        {
            //await LoadTrips();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAllField();
        }
        private void ResetAllField()
        {
            txtTripCode.Text = string.Empty;
            txtXe.Text = string.Empty;
            txtTaiXe.Text = string.Empty;
            cboDepartureLocation.SelectedIndex = -1;
            cboDiemden.SelectedIndex = -1;
            txtPrice.Text = string.Empty;
            txtSeatCount.Text = string.Empty;
            txt_tgDen.Text = string.Empty;
            txt_tgKhoiHanh.Text = string.Empty; 
            txtSoGhe.Text = string.Empty;
            cboTrangThai.SelectedIndex = -1;
        }

        private void btnSeatCountDetail_Click(object sender, EventArgs e)
        {
            if (selectedTrip == null)
            {
                MessageBox.Show("Không tìm thấy chuyến xe tương ứng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowSeatDetails(selectedTrip.Seats);
        }
        private void ShowSeatDetails(List<Seat> seats)
        {
            frmSeatDetail frm = new frmSeatDetail(seats);
            frm.ShowDialog();
        }

        private void dgvTrips_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTrips.SelectedRows.Count > 0)
            {
                var row = dgvTrips.SelectedRows[0];
                string selectedTripId = row.Cells["Id"].Value.ToString();

                selectedTrip = _trips.FirstOrDefault(t => t.Id == selectedTripId);
                if (selectedTrip != null)
                {
                    LoadSeats(selectedTripId);
                }
            }
        }
        public async Task LoadSeats(string selectedTrip)
        {
            try
            {
                var trip = await tripService.GetTrip(t => t.Id == selectedTrip, includeReferences: false);

                if (trip == null)
                {
                    MessageBox.Show("Không tìm thấy chuyến xe.");
                    return;
                }

                // Tạo DataTable để lưu thông tin ghế
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("SeatNumber");
                dataTable.Columns.Add("IsBooked", typeof(bool)); // Đảm bảo kiểu dữ liệu là boolean
                

                // Thêm thông tin ghế vào DataTable
                foreach (var seat in trip.Seats)
                {
                    dataTable.Rows.Add(seat.Id.ToString(), seat.SeatNumber, seat.IsBooked);
                }

                // Gán DataTable cho DataGridView
                dgvSeats.DataSource = dataTable;
                dgvSeats.Columns["Id"].Visible = false;
                dgvSeats.Columns["SeatNumber"].HeaderText = "Số ghế";
                dgvSeats.Columns["IsBooked"].HeaderText = "Đã đặt";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading seats: {ex.Message}");
            }
        }

        private void dgvTrips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvTrips.ClearSelection();
                dgvTrips.Rows[e.RowIndex].Selected = true;


                DataTable dataTable = (DataTable)dgvTrips.DataSource;

                string tripCode = dataTable.Rows[e.RowIndex]["TripCode"].ToString();
                string licensePlate = dataTable.Rows[e.RowIndex]["LicensePlate"].ToString();
                string driverName = dataTable.Rows[e.RowIndex]["DriverName"].ToString();
                string departureLocationId = dataTable.Rows[e.RowIndex]["DepartureLocationId"].ToString();
                string destinationId = dataTable.Rows[e.RowIndex]["DestinationId"].ToString();
                string price = dataTable.Rows[e.RowIndex]["Price"].ToString();
                string seatCount = dataTable.Rows[e.RowIndex]["SeatCount"].ToString();
                string departureTime = dataTable.Rows[e.RowIndex]["DepartureTime"].ToString();
                string estimatedArrivalTime = dataTable.Rows[e.RowIndex]["EstimatedArrivalTime"].ToString();


                txtTripCode.Text = tripCode;
                txtXe.Text = licensePlate;
                txtTaiXe.Text = driverName;
                cboDepartureLocation.SelectedValue = departureLocationId;
                cboDiemden.SelectedValue = destinationId;
                txtPrice.Text = price;
                txtSeatCount.Text = seatCount;
                txt_tgKhoiHanh.Text = departureTime;
                txt_tgDen.Text = estimatedArrivalTime;
            }
        }
      
        private void dgvSeats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvSeats.ClearSelection();
                dgvSeats.Rows[e.RowIndex].Selected = true;

                // Get the SeatNumber from the selected row
                string seatId = dgvSeats.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string SeatNumber = dgvSeats.Rows[e.RowIndex].Cells["SeatNumber"].Value.ToString();
                bool IsBooked = (bool)dgvSeats.Rows[e.RowIndex].Cells["IsBooked"].Value;

                // Cập nhật TextBox với giá trị SeatNumber
                txtSoGhe.Text = SeatNumber;

                // Cập nhật ComboBox dựa trên trạng thái đặt chỗ
                if (IsBooked)
                {
                    cboTrangThai.SelectedItem = "Đã đặt";
                }
                else
                {
                    cboTrangThai.SelectedItem = "Trống";
                }

            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTrip == null)
                {
                    MessageBox.Show("Vui lòng chọn chuyến xe để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string seatId = dgvSeats.SelectedRows[0].Cells["Id"].Value.ToString();
                bool isBooked = cboTrangThai.SelectedItem != null && cboTrangThai.SelectedItem.ToString() == "Đã đặt";


                var seatToUpdate = selectedTrip.Seats.FirstOrDefault(s => s.Id.ToString() == seatId);
                if (seatToUpdate != null)
                {
                    seatToUpdate.IsBooked = isBooked; // Cập nhật trạng thái
                }

                await tripService.UpdateTrip(selectedTrip.Id, selectedTrip);
                MessageBox.Show("Cập nhật trạng thái ghế thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại thông tin ghế
                LoadSeats(selectedTrip.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
