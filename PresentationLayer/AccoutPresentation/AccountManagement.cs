using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer.AccoutPresentation
{
    public partial class AccountManagement : Form
    {
        private UserBLL userBLL;
        public AccountManagement()
        {
            InitializeComponent();
            this.userBLL = new UserBLL();
        }
        private void AccountManagement_Load(object sender, EventArgs e)
        {
            LoadAccoutsInfo();
        }
        private void LoadAccoutsInfo()
        {
            DataTable dt = userBLL.GetAllAccountsInfo();
            dgvTaiKhoan.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CreateAccountForm f = new CreateAccountForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadAccoutsInfo();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text;
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa tài khoản \"{tenTK}\" không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string error = "";
                bool deleted = userBLL.DeleteAccount(tenTK, ref error);
                if (deleted)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    LoadAccoutsInfo();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa tài khoản: " + error);
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string vaiTro = cboRole.SelectedItem.ToString();
            string tenTK = txtTenTK.Text;
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn sửa thông tin tài khoản \"{tenTK}\" không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                string error = "";
                bool updated = userBLL.UpdateRoleAccount(tenTK, vaiTro, ref error);
                if (updated)
                {
                    MessageBox.Show("Cập nhật vai trò của tài khoản thành công!");
                    LoadAccoutsInfo();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin tài khoản: " + error);
                }
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

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                cboRole.Text = row.Cells["VaiTro"].Value.ToString();
                txtTenTK.Text = row.Cells["TenTK"].Value.ToString();
            }
        }
    }
}
