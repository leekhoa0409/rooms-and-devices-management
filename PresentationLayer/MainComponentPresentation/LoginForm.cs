using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer;
using DataAccessLayer;
using PresentationLayer.AccoutPresentation;
namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        private UserBLL userBLL;
        public LoginForm()        
        {
            InitializeComponent();
            userBLL = new UserBLL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenTK = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();
            DBHelper.strConnect = userBLL.CreateConnectionString(tenTK, matKhau);

            DataTable dtUser = userBLL.LoginCheck(tenTK, matKhau);
            if (dtUser == null || dtUser.Rows.Count == 0)
            {
                return;
            }

            DataRow row = dtUser.Rows[0];
            string appRole = row["VaiTro"].ToString().Trim();
            string appUser = row["TenTK"].ToString().Trim();

            Session.currentRole = appRole;
            Session.currentUser = appUser;
            // --- Chuyển sang MainForm
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMK.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void llbTaoTK_Click(object sender, EventArgs e)
        {
            CreateAccountForm f = new CreateAccountForm("login");
            f.ShowDialog();
        }
        private void llbTaoTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
