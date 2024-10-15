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
using QL_XeKhach.Models; 
using QL_XeKhach.Services;
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_XeKhach.GUI
{
    public partial class frmStatistics : Form
    {
        private readonly CompanyService _companyService = new CompanyService();
        private readonly TripService _tripService = new TripService();
        public frmStatistics()
        {
            InitializeComponent();
            this.Load += FrmStatistics_Load;
        }

        private async void FrmStatistics_Load(object sender, EventArgs e)
        {
            await LoadBusCompanyData();
            //await loadTicketBook();
        }
        private async Task LoadBusCompanyData()
        {
            try
            {
                var companies = await _companyService.GetCompanies();
                chartBusCompanies.Series.Clear();
                var series = new Series("Số lượng xe");
                series.ChartType = SeriesChartType.Column; 
                List<Color> colors = new List<Color>{Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Yellow, Color.Pink, Color.Brown, Color.Cyan, Color.Magenta};

                int colorIndex = 0;

                foreach (var company in companies)
                {
                    int busCount = company.Buses?.Count ?? 0; // Lấy số lượng xe, nếu không có thì là 0
                    var point = series.Points.AddXY(company.CompanyName, busCount); // Thêm dữ liệu (Tên công ty và số lượng xe)

                    // Thiết lập màu cho từng cột
                    series.Points[series.Points.Count - 1].Color = colors[colorIndex];

                    // Tăng chỉ số màu và quay lại đầu danh sách nếu vượt quá số màu có sẵn
                    colorIndex = (colorIndex + 1) % colors.Count;
                }

                // Thêm series vào biểu đồ
                chartBusCompanies.Series.Add(series);

                // Thiết lập thuộc tính của biểu đồ
                chartBusCompanies.ChartAreas[0].AxisX.Title = "Tên nhà xe";
                chartBusCompanies.ChartAreas[0].AxisY.Title = "Số lượng xe";
                chartBusCompanies.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả các tên công ty trên trục X

                // Điều chỉnh để tên công ty nằm ngang
                chartBusCompanies.ChartAreas[0].AxisX.LabelStyle.Angle = 0; // Giữ nhãn nằm ngang
                chartBusCompanies.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false; // Không so le các nhãn
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task loadTicketBook()
        {
            
        }
    }
}
