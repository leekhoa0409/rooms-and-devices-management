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
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                return;
            }

            // --- Lấy user hiện tại trong DB
            string currentDbUser = userBLL.GetCurrentDBUser();

            // --- Lấy role thật trong DB
            DataTable dtRole = userBLL.GetCurrentRole();
            string dbRole = "";
            if (dtRole != null && dtRole.Rows.Count > 0)
            {
                dbRole = dtRole.Rows[0]["DbRole"].ToString();
            }

            // --- Lấy role trong ứng dụng (bảng Users)
            DataRow row = dtUser.Rows[0];
            string appRole = row["VaiTro"].ToString();
            string appUser = row["TenTK"].ToString();

            // --- Thông báo
            MessageBox.Show(
                $"Đăng nhập thành công!\n" +
                $"AppUser: {appUser} (AppRole: {appRole})\n" +
                $"DBUser: {currentDbUser} (DbRole: {dbRole})"
            );

            // --- Lưu vào Session
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
    }
}
