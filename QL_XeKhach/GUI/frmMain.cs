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
                MenuItem manageVehicles = new MenuItem("Quản lý xe");
                mainMenu.MenuItems.Add(manageBuses);
                mainMenu.MenuItems.Add(manageVehicles);
            }
            else if (UserSession.LoggedInUser.Role ==E_Role.TICKET_SALLER)
            {
                MenuItem buyTicket = new MenuItem("Mua vé");
                mainMenu.MenuItems.Add(buyTicket);
            }

            this.Menu = mainMenu;
        }
    }
}

