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
    public partial class frmDriverDetail : Form
    {
        public frmDriverDetail()
        {
            InitializeComponent();
        }
        public frmDriverDetail(string name, string position, string phoneNumber, string email, int yoe)
        {
            InitializeComponent();
            lbName.Text = name;
            lbPosition.Text = position;
            lbEmail.Text = email;
            lbPhoneNumber.Text = phoneNumber;
            lbYOE.Text = yoe.ToString();
        }
    }
}
