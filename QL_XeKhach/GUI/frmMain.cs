﻿using QL_XeKhach.Models;
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
            this.FormClosed += FrmMain_FormClosed;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDangNhap loginForm = new frmDangNhap();
            loginForm.Show();
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
                MenuItem manageBusCompanies = new MenuItem("Quản lý nhà xe");
                MenuItem manageStatistics = new MenuItem("Thống kê");

                manageBusCompanies.Click += new EventHandler(ManageBusCompanies_Click);
                manageStatistics.Click += new EventHandler(ManageStatistics_Click);

                mainMenu.MenuItems.Add(manageBusCompanies);
                //mainMenu.MenuItems.Add(manageStatistics);
            }
            else if (UserSession.LoggedInUser.Role ==E_Role.TICKET_SALLER)
            {
                MenuItem buyTicket = new MenuItem("Mua vé");
                buyTicket.Click += new EventHandler(BuyTicket_Click);
                mainMenu.MenuItems.Add(buyTicket);

                MenuItem invoice = new MenuItem("Hoá đơn mua vé");
                invoice.Click += new EventHandler(Invoice_Click);
                mainMenu.MenuItems.Add(invoice);
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

        private void Invoice_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmHoaDon frm = new frmHoaDon();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void BuyTicket_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmBanVe frm = new frmBanVe();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void BusCompanyInfo_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmBusCompanyInfo frm = new frmBusCompanyInfo();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void ManageStatistics_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmStatistics frmSta = new frmStatistics();
            frmSta.MdiParent = this;
            frmSta.WindowState = FormWindowState.Maximized;
            frmSta.FormBorderStyle = FormBorderStyle.None;
            frmSta.Dock = DockStyle.Fill;
            frmSta.Show();

        }

        private void ManageBusCompanies_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmManageBusCompanies frmComBus = new frmManageBusCompanies();
            frmComBus.MdiParent = this;
            frmComBus.WindowState = FormWindowState.Maximized;
            frmComBus.FormBorderStyle = FormBorderStyle.None;
            frmComBus.Dock = DockStyle.Fill;
            frmComBus.Show(); 
        }

        private void ManageTrip_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmManageTrip frmTrip = new frmManageTrip();
            frmTrip.MdiParent = this;
            frmTrip.WindowState = FormWindowState.Maximized;
            frmTrip.FormBorderStyle = FormBorderStyle.None;
            frmTrip.Dock = DockStyle.Fill;
            frmTrip.Show();
        }

        private void ManageBus_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmManageBus frmBus = new frmManageBus();
            frmBus.MdiParent = this;
            frmBus.WindowState = FormWindowState.Maximized;
            frmBus.FormBorderStyle = FormBorderStyle.None;
            frmBus.Dock = DockStyle.Fill;
            frmBus.Show(); 
        }

        private void ManageEmployee_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmManageDriver frmDriver = new frmManageDriver();
            frmDriver.MdiParent = this;
            frmDriver.WindowState = FormWindowState.Maximized;
            frmDriver.FormBorderStyle = FormBorderStyle.None;
            frmDriver.Dock = DockStyle.Fill;
            frmDriver.Show();
        }
        private void CloseAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

    }

}

