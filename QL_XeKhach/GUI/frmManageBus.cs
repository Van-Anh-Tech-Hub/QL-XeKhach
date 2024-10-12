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

        private void FrmManageBus_Load(object sender, EventArgs e)
        {
            LoadDgvBus();
        }
        private async void LoadDgvBus()
        {
            if (UserSession.LoggedInUser.BusCompanyId != null)
            {
                BusCompany company = await companyService.GetCompany(u => u.Id == UserSession.LoggedInUser.BusCompanyId);
                dgv_Bus.DataSource = company.Buses;
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
