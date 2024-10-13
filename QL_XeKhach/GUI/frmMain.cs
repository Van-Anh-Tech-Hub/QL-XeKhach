using QL_XeKhach.Models;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RenderMainMenu();
        }

        private void RenderMainMenu()
        {
            MainMenu mainMenu = new MainMenu();

            if (UserSession.LoggedInUser.Role == E_Role.ADMIN)
            {
                MenuItem manageBuses = new MenuItem("Quản lý nhà xe");
                mainMenu.MenuItems.Add(manageBuses);
            }
            else if (UserSession.LoggedInUser.Role ==E_Role.TICKET_SALLER)
            {
                MenuItem buyTicket = new MenuItem("Mua vé");
                mainMenu.MenuItems.Add(buyTicket);
            }
            else if (UserSession.LoggedInUser.Role == E_Role.COMPANY_EMPLOYEE)
            {
                MenuItem manageTrip = new MenuItem("Quản lý chuyến xe");
                MenuItem manageBus = new MenuItem("Quản lý xe");
                MenuItem manageEmployee = new MenuItem("Nhân viên");
                MenuItem busCompanyInfo = new MenuItem("Thông tin công ty");


                manageTrip.Click += new EventHandler(ManageTrip_Click);
                manageBus.Click += new EventHandler(ManageBus_Click);
                manageEmployee.Click += new EventHandler(ManageEmployee_Click);
                busCompanyInfo.Click += new EventHandler(BusCompanyInfo_Click);


                mainMenu.MenuItems.Add(manageTrip);
                mainMenu.MenuItems.Add(manageBus);
                mainMenu.MenuItems.Add(manageEmployee);
                mainMenu.MenuItems.Add(busCompanyInfo);

            }

            this.Menu = mainMenu;
        }

        private void BusCompanyInfo_Click(object sender, EventArgs e)
        {
            frmBusCompanyInfo frm = new frmBusCompanyInfo();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void ManageTrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Quản lý chuyến xe");
        }

        private void ManageBus_Click(object sender, EventArgs e)
        {
            frmManageBus frmBus = new frmManageBus();
            frmBus.MdiParent = this;
            frmBus.WindowState = FormWindowState.Maximized;
            frmBus.FormBorderStyle = FormBorderStyle.None;
            frmBus.Dock = DockStyle.Fill;
            frmBus.Show(); 
        }

        private void ManageEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Nhân viên");
        }
    }
}

