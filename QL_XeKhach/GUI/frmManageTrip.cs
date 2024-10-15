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
    public partial class frmManageTrip : Form
    {
        private static TripService tripService = new TripService();
        public frmManageTrip()
        {
            InitializeComponent();
            this.Load += FrmManageTrip_Load;
        }

        private async void FrmManageTrip_Load(object sender, EventArgs e)
        {
            List<Trip> trips = await tripService.GetTrips(t => t.BusCompanyId == UserSession.LoggedInUser.BusCompanyId, null, true);
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

    }
}
