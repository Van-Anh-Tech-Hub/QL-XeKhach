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
        private static InvoiceService invoiceService = new InvoiceService();

        private List<Trip> _trips;
        private Trip selectedTrip;
        //private List<Invoice> _invoice;
        private Invoice selectedInvoice;
        private string selectedTripId;
        private string idInvoiceSelected;

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
            LoadInvoices();
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
                dgvTrips.Columns["SeatCount"].Width = 50;
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
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadTrips();
        }
        private void cboDiemden_SelectedIndexChanged(object sender, EventArgs e)
        {
            //await LoadTrips();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAllField();
            LoadInvoices();
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
                return;
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
        public async void LoadSeats(string selectedTrip)
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

                string id = dataTable.Rows[e.RowIndex]["Id"].ToString();
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
                selectedTripId = id;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            CreateInvoice();
        }
        private async void CreateInvoice()
        {
            if (string.IsNullOrEmpty(selectedTripId))
            {
                MessageBox.Show("Please select a trip first.");
                return;
            }

            var invoiceService = new InvoiceService();
            var tickets = new List<Ticket>();

            // Create a new ticket with the selected TripId, SeatNumber, and Price
            var ticket = new Ticket(selectedTripId, txtSoGhe.Text, decimal.Parse(txtPrice.Text));
            tickets.Add(ticket);

            var newInvoice = new Invoice(txtCustomerName.Text, txtCustomerPhoneNumber.Text, tickets, txtCustomerEmail.Text);
            await invoiceService.CreateInvoice(newInvoice);

            // Mark the seat as booked in the Trips collection (assuming you have a method for this)
            //await MarkSeatAsBooked(selectedTripId, txtSoGhe.Text);

            MessageBox.Show("Invoice created successfully!");

        }
        private async void LoadInvoices()
        {
            var invoiceService = new InvoiceService();
            var invoices = await invoiceService.GetInvoices(orderBy: query => query.OrderByDescending(i => i.UpdatedAt));
            LoadDgvInvoices(invoices);
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            // Get the phone number entered by the user
            var phoneNumber = txtCustomerPhoneNumber.Text.Trim();

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                // Call GetInvoices with a filter for CustomerPhoneNumber
                var invoices = await invoiceService.GetInvoices(i => i.CustomerPhoneNumber == phoneNumber);

                if (invoices != null && invoices.Any())
                {
                    // Load the invoices into the DataGridView
                    LoadDgvInvoices(invoices);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn với số điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại để tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadDgvInvoices(List<Invoice> invoices)
        {
            if (invoices != null && invoices.Any())
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("InvoiceCode");
                dataTable.Columns.Add("CustomerName");
                dataTable.Columns.Add("CustomerPhoneNumber");
                dataTable.Columns.Add("CustomerEmail");
                dataTable.Columns.Add("TotalAmount");
                dataTable.Columns.Add("CreatedAt");
                dataTable.Columns.Add("UpdatedAt");

                // Thêm dữ liệu vào DataTable
                foreach (var invoice in invoices)
                {
                    dataTable.Rows.Add(
                        invoice?.Id,
                        invoice?.InvoiceCode,
                        invoice?.CustomerName,
                        invoice?.CustomerPhoneNumber,
                        invoice?.CustomerEmail,
                        invoice?.TotalAmount,
                        invoice?.CreatedAt,
                        invoice?.UpdatedAt
                    );
                }

                dgvInvoices.DataSource = dataTable;

                // Định dạng các cột trong DataGridView
                dgvInvoices.Columns["Id"].Visible = false;
                dgvInvoices.Columns["InvoiceCode"].HeaderText = "Mã hóa đơn";
                dgvInvoices.Columns["InvoiceCode"].Width = 120;
                dgvInvoices.Columns["CustomerName"].HeaderText = "Tên khách hàng";
                dgvInvoices.Columns["CustomerName"].Width = 150;
                dgvInvoices.Columns["CustomerPhoneNumber"].HeaderText = "Số điện thoại";
                dgvInvoices.Columns["CustomerEmail"].HeaderText = "Email";
                dgvInvoices.Columns["CustomerEmail"].Width = 150;
                dgvInvoices.Columns["TotalAmount"].HeaderText = "Tổng tiền";
                dgvInvoices.Columns["TotalAmount"].DefaultCellStyle.Format = "N0"; // Định dạng số tiền
                dgvInvoices.Columns["CreatedAt"].HeaderText = "Ngày tạo";
                dgvInvoices.Columns["UpdatedAt"].HeaderText = "Ngày cập nhật";
                dgvInvoices.Columns["UpdatedAt"].Width = 120;
                dgvInvoices.Columns["CreatedAt"].Width = 120;
            }
            else
            {
                dgvInvoices.DataSource = null;
                dgvInvoices.Rows.Clear();
            }
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Đảm bảo dòng đang chọn được highlight
                dgvInvoices.ClearSelection();
                dgvInvoices.Rows[e.RowIndex].Selected = true;

                // Lấy DataTable từ DataGridView
                DataTable dataTable = (DataTable)dgvInvoices.DataSource;

                // Lấy các giá trị từ hàng được chọn
                idInvoiceSelected = dataTable.Rows[e.RowIndex]["Id"].ToString();
                string invoiceCode = dataTable.Rows[e.RowIndex]["InvoiceCode"].ToString();
                string customerName = dataTable.Rows[e.RowIndex]["CustomerName"].ToString();
                string customerPhoneNumber = dataTable.Rows[e.RowIndex]["CustomerPhoneNumber"].ToString();
                string customerEmail = dataTable.Rows[e.RowIndex]["CustomerEmail"].ToString();
                string createdAt = dataTable.Rows[e.RowIndex]["CreatedAt"].ToString();
                string updatedAt = dataTable.Rows[e.RowIndex]["UpdatedAt"].ToString();

                // Hiển thị các giá trị trên các control tương ứng
                txtInvoiceCode.Text = invoiceCode;
                txtCustomerName.Text = customerName;
                txtCustomerPhoneNumber.Text = customerPhoneNumber;
                txtCustomerEmail.Text = customerEmail;
                dtpCreatedAt.Text = createdAt;
                dtpUpdatedAt.Text = updatedAt;

            }
        }

        private void btnCapNhatHoaDon_Click(object sender, EventArgs e)
        {
            UpdateInvoice(idInvoiceSelected);
        }
        private async void UpdateInvoice(string invoiceId)
        {
            var invoiceService = new InvoiceService();
            var invoice = await invoiceService.GetInvoice(i => i.Id == invoiceId);

            if (invoice != null)
            {
                // Update customer information
                invoice.CustomerName = txtCustomerName.Text;
                invoice.CustomerPhoneNumber = txtCustomerPhoneNumber.Text;
                invoice.CustomerEmail = txtCustomerEmail.Text;

                // Logic to handle adding or updating tickets
                var seatNumber = txtSoGhe.Text;
                var ticketPrice = decimal.Parse(txtPrice.Text);
                var existingTicket = invoice.Tickets.FirstOrDefault(t => t.SeatNumber == seatNumber);

                if (existingTicket != null)
                {
                    // Case: Update existing ticket
                    existingTicket.Price = ticketPrice;  // Update price
                }
                else
                {
                    // Case: Add a new ticket
                    var newTicket = new Ticket(selectedTripId, seatNumber, ticketPrice);
                    invoice.AddTicket(newTicket);  // Use the AddTicket method to add new ticket and update timestamps
                }

                // No need to manually calculate the total price, as it's done in the `TotalAmount` property.
                //lblTotalPrice.Text = invoice.TotalAmount.ToString();  // Update the label showing the total price

                // Update the invoice in the database
                await invoiceService.UpdateInvoice(invoiceId, invoice);

                MessageBox.Show("Cập nhật hoá đơn thành công!");
                LoadInvoices();
            }
            else
            {
                MessageBox.Show("Không tìm thấy hoá đơn!");
            }
        }

    }
}
