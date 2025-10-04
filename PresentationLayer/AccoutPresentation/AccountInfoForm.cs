using BussinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.AccoutPresentation
{
    public partial class AccountInfoForm : Form
    {
        private UserBLL userBLL;
        public AccountInfoForm()
        {
            InitializeComponent();
            userBLL = new UserBLL();
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
        private void LoadInfo()
        {
            DataTable dt = userBLL.GetAccountInfo(Session.currentUser);
            if (dt != null && dt.Rows.Count > 0)
            {
                txtTenTK.Text = dt.Rows[0]["TenTK"].ToString();
                txtPassword.Text = dt.Rows[0]["MatKhau"].ToString();
                txtRole.Text = dt.Rows[0]["VaiTro"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản!","Thông báo", 
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
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
        private void BtnHover_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
                btn.ForeColor = System.Drawing.Color.White;
            }
        }

        private void BtnHover_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = System.Drawing.Color.White;
                btn.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            }
        }
    }
}
