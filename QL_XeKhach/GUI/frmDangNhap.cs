using QL_XeKhach.GUI;
using QL_XeKhach.Models;
using QL_XeKhach.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_XeKhach
{
    public partial class frmDangNhap : Form
    {
        private static UserService userService = new UserService();
        public frmDangNhap()
        {
            InitializeComponent();

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void txt_Username_Click(object sender, EventArgs e)
        {
            txt_Email.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
            txt_Password.BackColor = SystemColors.Control;
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txt_Email.BackColor = SystemColors.Control;
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {

                User loggedInUser = new User
                {
                    Fullname = "Vũ Văn Anh",
                    Email = "admin@gmail.com",
                    Password = Helper.HashPassword("Admin@123"),
                    Role = E_Role.COMPANY_EMPLOYEE,
                    BusCompanyId= "6704d9ebc37d91d036f2d528"
                };


                //User loggedInUser = await userService.GetUser(u=>u.Email==txt_Email.Text);
                //bool isVerify = Helper.VerifyPassword(txt_Password.Text, loggedInUser.Password);

                //if (!isVerify || loggedInUser == null)
                //{
                //    MessageBox.Show("Email hoặc mật khẩu không đúng!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txt_Password.Text = string.Empty;
                //    return;
                //}


                UserSession.LoggedInUser = loggedInUser;

                // Chuyển sang frmMain
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Helper.LogError(ex);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txt_Email.Focus();
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn chặn hiển thị ký tự Enter trong TextBox
                btn_Login_Click(sender, e);
            }
        }
    }
}
