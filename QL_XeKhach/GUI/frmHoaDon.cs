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
    public partial class frmHoaDon : Form
    {
        private static InvoiceService invoiceService = new InvoiceService();
        private static CompanyService companyService = new CompanyService();
        private static ProvinceService provinceService = new ProvinceService();
        private static TripService tripService = new TripService();

        private List<Invoice> _invoice;
        private Invoice selectedInvoice;
        public frmHoaDon()
        {
            InitializeComponent();
            this.Load += FrmHoaDon_Load;
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadInvoices();

            LoadCboDestination();
            LoadCboDepartureLocation();
        }
        private async void LoadInvoices()
        {
            var invoiceService = new InvoiceService();
            var invoices = await invoiceService.GetInvoices(orderBy: query => query.OrderByDescending(i => i.UpdatedAt));
            LoadDgvInvoices(invoices);
        }

        private async void LoadDgvInvoices(List<Invoice> invoices)
        {
            if (UserSession.LoggedInUser.BusCompanyId != null)
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
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void LoadTickets(List<Ticket> tickets)
        {
            if (tickets != null && tickets.Any())
            {
                DataTable ticketTable = new DataTable();
                ticketTable.Columns.Add("TicketCode");
                ticketTable.Columns.Add("TripId");
                ticketTable.Columns.Add("SeatNumber");
                ticketTable.Columns.Add("Price");
                ticketTable.Columns.Add("PurchaseDate");

                // Thêm dữ liệu vào DataTable
                foreach (var ticket in tickets)
                {
                    ticketTable.Rows.Add(
                        ticket.TicketCode,
                        ticket.TripId,
                        ticket.SeatNumber,
                        ticket.Price,
                        ticket.PurchaseDate
                    );
                }

                // Gán DataTable cho dgvTickets
                dgvTickets.DataSource = ticketTable;

                // Định dạng DataGridView dgvTickets
                dgvTickets.Columns["TicketCode"].Visible =false;
                dgvTickets.Columns["TripId"].Visible = false;
                dgvTickets.Columns["SeatNumber"].HeaderText = "Số ghế";
                dgvTickets.Columns["Price"].HeaderText = "Giá vé";
                dgvTickets.Columns["Price"].DefaultCellStyle.Format = "N0"; // Định dạng số tiền
                dgvTickets.Columns["PurchaseDate"].HeaderText = "Ngày mua";
                dgvTickets.Columns["PurchaseDate"].Width = 120;
            }
            else
            {
                // Xóa dữ liệu nếu không có vé
                dgvTickets.DataSource = null;
                dgvTickets.Rows.Clear();
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
        private async void LoadCboDestination()
        {
            List<Province> provinces = await provinceService.GetProvinces();
            cboDestination.DataSource = provinces;
            cboDestination.DisplayMember = "Name";
            cboDestination.ValueMember = "Id";
            cboDestination.SelectedIndex = -1;

            
        }

        private async void dgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                // Lấy mã Id của hóa đơn từ hàng đang được chọn
                string selectedInvoiceId = dgvInvoices.SelectedRows[0].Cells["Id"].Value.ToString();

                // Tạo dịch vụ để lấy thông tin hóa đơn
                var invoiceService = new InvoiceService();
                var selectedInvoice = await invoiceService.GetInvoice(i => i.Id == selectedInvoiceId);

                // Nếu hóa đơn tồn tại, gọi hàm LoadTickets để hiển thị vé
                if (selectedInvoice != null)
                {
                    LoadTickets(selectedInvoice.Tickets);
                }
                else
                {
                    // Xóa dữ liệu trong dgvTickets nếu không có vé nào
                    LoadTickets(null);
                }
            }
        }

        private async void CreateInvoice()
        {
            var invoiceService = new InvoiceService();
            var tickets = new List<Ticket>();

            var newInvoice = new Invoice(txtCustomerName.Text, txtCustomerPhoneNumber.Text, tickets, txtCustomerEmail.Text);
            await invoiceService.CreateInvoice(newInvoice);

            MessageBox.Show("Invoice created successfully!");
            LoadInvoices();
        }
        private async void UpdateInvoice(string invoiceId)
        {
            var invoiceService = new InvoiceService();
            var invoice = await invoiceService.GetInvoice(i => i.Id == invoiceId);

            if (invoice != null)
            {
                invoice.CustomerName = txtCustomerName.Text;
                invoice.CustomerPhoneNumber = txtCustomerPhoneNumber.Text;
                invoice.CustomerEmail = txtCustomerEmail.Text;

                // Thay đổi vé (có thể thêm logic cập nhật vé ở đây)
                invoice.Tickets.Clear();

                await invoiceService.UpdateInvoice(invoiceId, invoice);

                MessageBox.Show("Invoice updated successfully!");
                LoadInvoices();
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

        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Đảm bảo dòng được chọn
                dgvTickets.ClearSelection();
                dgvTickets.Rows[e.RowIndex].Selected = true;

                // Lấy DataTable từ DataGridView
                DataTable dataTable = (DataTable)dgvTickets.DataSource;

                // Lấy các giá trị từ hàng được chọn
                //string id = dataTable.Rows[e.RowIndex]["Id"].ToString();
                string ticketCode = dataTable.Rows[e.RowIndex]["TicketCode"].ToString();
                string tripId = dataTable.Rows[e.RowIndex]["TripId"].ToString();
                string seatNumber = dataTable.Rows[e.RowIndex]["SeatNumber"].ToString();
                string price = dataTable.Rows[e.RowIndex]["Price"].ToString();
                string purchaseDate = dataTable.Rows[e.RowIndex]["PurchaseDate"].ToString();

                // Hiển thị các giá trị lên các control tương ứng
                txtTicketCode.Text = ticketCode;
                txtTripId.Text = tripId;
                txtSeatNumber.Text = seatNumber;
                txtPrice.Text = price;
                dtpPurchaseDate.Text = purchaseDate;
                LoadDepartureAndDestination(tripId);
            }
        }
        private async void LoadDepartureAndDestination(string tripId)
        {
            // Truy vấn bảng Trips để lấy thông tin điểm khởi hành và điểm đến
            var trip = await tripService.GetTrip(t => t.Id == tripId, true);

            if (trip != null)
            {
                // Lấy DepartureLocationId và DestinationId từ Trip
                string departureLocationId = trip.DepartureLocationId.ToString();
                string destinationId = trip.DestinationId.ToString();

                // Truy vấn bảng Province để lấy tên của điểm khởi hành và điểm đến
                var departureLocation = await provinceService.GetProvince(p => p.Id == departureLocationId);
                var destination = await provinceService.GetProvince(p => p.Id == destinationId);

                // Gán tên của các tỉnh thành vào ComboBox
                if (departureLocation != null)
                {
                    //cboDepartureLocation.SelectedItem = departureLocation.Name;
                    cboDepartureLocation.SelectedValue = departureLocation.Id;
                }

                if (destination != null)
                {
                    //cboDestination.SelectedItem = destination.Name;
                    cboDestination.SelectedValue = destination.Id;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin chuyến đi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
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

        private void btnResetAction_Click(object sender, EventArgs e)
        {
            txtCustomerEmail.Text = string.Empty;
            txtCustomerPhoneNumber.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtInvoiceCode.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtSeatNumber.Text = string.Empty;
            txtTicketCode.Text = string.Empty;
            txtTripId.Text = string.Empty;
            cboDepartureLocation.SelectedIndex = -1;
            cboDestination.SelectedIndex = -1;
            dtpCreatedAt.Text = string.Empty;
            dtpPurchaseDate.Text = string.Empty;
            dtpUpdatedAt.Text = string.Empty;
            LoadInvoices();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CreateInvoice();
        }
    }
}
