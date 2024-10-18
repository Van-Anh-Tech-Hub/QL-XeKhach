using QL_XeKhach.Models;
using QL_XeKhach.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QL_XeKhach.GUI
{
    public partial class frmManageTrip : Form
    {
        private static TripService tripService = new TripService();
        private static CompanyService companyService = new CompanyService();
        private static ProvinceService provinceService = new ProvinceService();

        private List<Trip> _trips;
        private Trip selectedTrip;
        public frmManageTrip()
        {
            InitializeComponent();
            this.Load += FrmManageTrip_Load;

        }

        private void FrmManageTrip_Load(object sender, EventArgs e)
        {
            GetTrips();

            LoadCboBus();
            LoadCboDriver();
            LoadCboDepartureLocation();
            LoadCboDestination();
        }
        private async void GetTrips()
        {
            List<Trip> trips = await tripService.GetTrips(t => t.BusCompanyId == UserSession.LoggedInUser.BusCompanyId, null, true);
            _trips = trips;
            LoadDgvTrip(trips);
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

                    dgv_Trip.DataSource = dataTable;

                    dgv_Trip.Columns["Id"].Visible = false;
                    dgv_Trip.Columns["TripCode"].HeaderText = "Mã chuyến xe";
                    dgv_Trip.Columns["TripCode"].Width = 120;
                    dgv_Trip.Columns["DepartureLocationId"].Visible = false;
                    dgv_Trip.Columns["DestinationId"].Visible = false;
                    dgv_Trip.Columns["DepartureTime"].HeaderText = "Thời gian khởi hành dự kiến";
                    dgv_Trip.Columns["EstimatedArrivalTime"].HeaderText = "Thời gian đến dự kiến";
                    dgv_Trip.Columns["DriverId"].Visible = false;
                    dgv_Trip.Columns["BusId"].Visible = false;
                    dgv_Trip.Columns["Price"].HeaderText = "Giá";
                    dgv_Trip.Columns["DriverName"].HeaderText = "Tên tài xế";
                    dgv_Trip.Columns["BusModel"].HeaderText = "Kiểu xe";
                    dgv_Trip.Columns["LicensePlate"].HeaderText = "Biển số";
                    dgv_Trip.Columns["SeatCount"].HeaderText = "Số chỗ";
                    dgv_Trip.Columns["DepartureLocation"].HeaderText = "Điểm khởi hành";
                    dgv_Trip.Columns["Destination"].HeaderText = "Điểm kết thúc";
                    dgv_Trip.Columns["created_at"].HeaderText = "Ngày tạo";
                    dgv_Trip.Columns["updated_at"].HeaderText = "Ngày cập nhật";
                }
                else
                {
                    dgv_Trip.DataSource = null;
                    dgv_Trip.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private async void LoadCboBus()
        {
            BusCompany busCompany = await companyService.GetCompany(c => c.Id == UserSession.LoggedInUser.BusCompanyId);
            cboBus.DataSource = busCompany.Buses;
            cboBus.DisplayMember = "LicensePlate";
            cboBus.ValueMember = "Id";
            cboBus.SelectedIndex = -1;
        }
        private async void LoadCboDriver()
        {
            BusCompany busCompany = await companyService.GetCompany(c => c.Id == UserSession.LoggedInUser.BusCompanyId);
            cboDriver.DataSource = busCompany.Drivers;
            cboDriver.DisplayMember = "Name";
            cboDriver.ValueMember = "Id";
            cboDriver.SelectedIndex = -1;
        }
        private async void LoadCboDepartureLocation()
        {
            List<Province> provinces = await provinceService.GetProvinces();
            cboDepartureLocation.DataSource = provinces;
            cboDepartureLocation.DisplayMember = "Name";
            cboDepartureLocation.ValueMember = "Id";
            cboDepartureLocation.SelectedIndex = -1;

            cboDepartureLocation_Search.DataSource = provinces;
            cboDepartureLocation_Search.DisplayMember = "Name";
            cboDepartureLocation_Search.ValueMember = "Id";
            cboDepartureLocation_Search.SelectedIndex = -1;
        }
        private async void LoadCboDestination()
        {
            List<Province> provinces = await provinceService.GetProvinces();
            cboDestination.DataSource = provinces;
            cboDestination.DisplayMember = "Name";
            cboDestination.ValueMember = "Id";
            cboDestination.SelectedIndex = -1;

            cboDestination_Search.DataSource = provinces;
            cboDestination_Search.DisplayMember = "Name";
            cboDestination_Search.ValueMember = "Id";
            cboDestination_Search.SelectedIndex = -1;
        }

        private void btnBusDetail_Click(object sender, EventArgs e)
        {
            var selectedBus = cboBus.SelectedItem as Bus;
            if (selectedBus != null)
            {
                ShowBusDetails(selectedBus);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn xe từ danh sách.", "No Bus Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowBusDetails(Bus bus)
        {
            frmBusDetail frm = new frmBusDetail(bus.Model, bus.SeatCount, bus.LicensePlate);
            frm.ShowDialog();
        }

        private void btnDriverDetail_Click(object sender, EventArgs e)
        {
            var selectedDriver = cboDriver.SelectedItem as Driver;
            if (selectedDriver != null)
            {
                ShowDriverDetails(selectedDriver);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài xế từ danh sách.", "No Bus Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ShowDriverDetails(Driver driver)
        {
            frmDriverDetail frm = new frmDriverDetail(driver.Name, driver.Position, driver.PhoneNumber, driver.Email, driver.YearsOfExperience);
            frm.ShowDialog();
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

        private void dgv_Trip_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Trip.SelectedRows.Count > 0)
            {
                var row = dgv_Trip.SelectedRows[0];
                string selectedTripId = row.Cells["Id"].Value.ToString();

                selectedTrip = _trips.FirstOrDefault(t => t.Id == selectedTripId);
            }
        }

        private void dgv_Trip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Trip.ClearSelection();
                dgv_Trip.Rows[e.RowIndex].Selected = true;


                DataTable dataTable = (DataTable)dgv_Trip.DataSource;

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
                cboBus.Text = licensePlate;
                cboDriver.Text = driverName;
                cboDepartureLocation.SelectedValue = departureLocationId;
                cboDestination.SelectedValue = destinationId;
                txtPrice.Text = price;
                cboSeatCount.SelectedItem = seatCount;
                dtpDepartureTime.Text = departureTime;
                dtpEstimatedArrivalTime.Text = estimatedArrivalTime;
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTripCode.Text) || cboBus.SelectedItem == null || cboDriver.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin chuyến xe.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Trip newTrip = new Trip
                {
                    BusCompanyId = UserSession.LoggedInUser.BusCompanyId,
                    DepartureLocationId = cboDepartureLocation.SelectedValue.ToString(),
                    DestinationId = cboDestination.SelectedValue.ToString(),
                    DepartureTime = DateTime.Parse(dtpDepartureTime.Text),
                    EstimatedArrivalTime = DateTime.Parse(dtpEstimatedArrivalTime.Text),
                    DriverId = ((Driver)cboDriver.SelectedItem).Id,
                    BusId = ((Bus)cboBus.SelectedItem).Id,
                    Price = decimal.Parse(txtPrice.Text),
                };
                newTrip.CreateSeats(((Bus)cboBus.SelectedItem).SeatCount);

                await tripService.CreateTrip(newTrip);

                MessageBox.Show("Thêm chuyến xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetTrips();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                selectedTrip.TripCode = txtTripCode.Text;
                selectedTrip.DriverId = cboDriver.SelectedValue.ToString();
                selectedTrip.DepartureLocationId = cboBus.SelectedValue.ToString();
                selectedTrip.DepartureLocationId = cboDepartureLocation.SelectedValue.ToString();
                selectedTrip.DestinationId = cboDestination.SelectedValue.ToString();
                selectedTrip.Price = decimal.Parse(txtPrice.Text);

                await tripService.UpdateTrip(selectedTrip.Id, selectedTrip);

                MessageBox.Show("Sửa chuyến xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetTrips();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTrip == null)
                {
                    MessageBox.Show("Vui lòng chọn chuyến xe để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận xóa
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chuyến xe này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // Gọi dịch vụ để xóa chuyến xe
                    await tripService.DeleteTrip(selectedTrip.Id);

                    // Thông báo thành công
                    MessageBox.Show("Xóa chuyến xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại danh sách chuyến xe
                    GetTrips();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnResetAction_Click(object sender, EventArgs e)
        {
            txtTripCode.Text = string.Empty;
            cboBus.SelectedIndex = -1;
            cboDriver.SelectedIndex = -1;
            cboDepartureLocation.SelectedIndex = -1;
            cboDestination.SelectedIndex = -1;
            txtPrice.Text = string.Empty;
            cboSeatCount.SelectedIndex = -1;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string tripCode = txtTripCodeSearch.Text.Trim();
                string departureLocationId = cboDepartureLocation_Search.SelectedValue?.ToString();
                string destinationId = cboDestination_Search.SelectedValue?.ToString();

                List<Trip> trips = await tripService.GetTrips(t =>
                    (string.IsNullOrEmpty(tripCode) || t.TripCode.Contains(tripCode)) &&
                    (string.IsNullOrEmpty(departureLocationId) || t.DepartureLocationId == departureLocationId) &&
                    (string.IsNullOrEmpty(destinationId) || t.DestinationId == destinationId), null, true);

                LoadDgvTrip(trips);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTripCodeSearch.Text = string.Empty;
            cboDepartureLocation_Search.SelectedIndex = -1;
            cboDestination_Search.SelectedIndex = -1;
            GetTrips();
        }
    }
}
