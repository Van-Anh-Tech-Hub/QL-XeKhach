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
    public partial class frmBusDetail : Form
    {
        public frmBusDetail()
        {
            InitializeComponent();
        }
        public frmBusDetail(string model, int seatCount, string licensePlate)
        {
            InitializeComponent();
            lbModel.Text = model;
            lbSeatCount.Text = seatCount.ToString();
            lbLicensePlate.Text = licensePlate;
        }
    }
}
