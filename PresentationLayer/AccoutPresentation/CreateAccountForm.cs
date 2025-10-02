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

namespace PresentationLayer.AccoutPresentation
{
    public partial class CreateAccountForm : Form
    {
        private UserBLL userBLL;
        private string from;
        public CreateAccountForm(string from = null)
        {
            InitializeComponent();
            userBLL = new UserBLL();
            this.from = from;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTK.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản trước khi tạo!");
                return;
            }
            else if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu trước khi tạo!");
                return;
            }
            else if (string.IsNullOrEmpty(cboVaiTro.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng thêm vai trò cho tài khoản trước khi tạo!");
                return;
            }
            string tenTK = txtTenTK.Text;
            string matKhau = txtMatKhau.Text;
            string vaiTro = cboVaiTro.SelectedItem.ToString();
            string error = "";
            bool created = userBLL.CreateAccount(tenTK, matKhau, vaiTro, ref error);
            if (created)
            {
                MessageBox.Show("Tạo tài khoản mới thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi khi tạo tài khoản: " + error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn hủy thao tác không?",
                "Xác nhận hủy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {
            if (from == "login")
            {
                cboVaiTro.Enabled = false;
                cboVaiTro.Visible = false;
                lbVaiTro.Visible = false;
                lbVaiTro.Enabled = false;

                lbNhapLaiMK.Enabled = true;
                lbNhapLaiMK.Visible = true;
                txtNhapLaiMK.Enabled = true;
                txtNhapLaiMK.Visible = true;
 
            }
            cboVaiTro.SelectedIndex = 2;
        }
    }
}
