using BussinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DeviceInsertUpdateForm : Form
    {
        private string mode;
        private string maThietBi;
        private DeviceBLL deviceBLL;
        public DeviceInsertUpdateForm(string mode, string maThietBi = "")
        {
            InitializeComponent();
            deviceBLL = new DeviceBLL();
            this.mode = mode;
            this.maThietBi = maThietBi;
        }

        private void DeviceInsertUpdateForm_Load(object sender, EventArgs e)
        {
            if (maThietBi != "")
            {
                DataTable dt = deviceBLL.GetDeviceById(maThietBi);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtTenThietBi.Text = dt.Rows[0]["TenTB"].ToString();
                    cboLoaiTB.Text = dt.Rows[0]["LoaiTB"].ToString();
                    if (dt.Rows[0]["NgayMua"] != DBNull.Value)
                    {
                        dtpNgayMua.Value = Convert.ToDateTime(dt.Rows[0]["NgayMua"]);
                    }
                    else
                    {
                        dtpNgayMua.Value = DateTime.Now;
                    }
                    cboTinhTrang.Text = dt.Rows[0]["TinhTrang"].ToString();
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenThietBi = txtTenThietBi.Text.ToString();
            string loaiThietBi = cboLoaiTB.Text.ToString();
            DateTime ngayMua = dtpNgayMua.Value.Date;
            string tinhTrang = cboTinhTrang.Text.ToString();
            string error = "";
            bool result = false;
            if (string.IsNullOrEmpty(tenThietBi))
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị!");
                return;
            }
            if (string.IsNullOrEmpty(loaiThietBi))
            {
                MessageBox.Show("Vui lòng chọn loại thiết bị!");
                return;
            }
            if (string.IsNullOrEmpty(tinhTrang))
            {
                MessageBox.Show("Vui lòng chọn tình trạng của thiết bị!");
                return;
            }
            if (mode == "add")
            {
                result = deviceBLL.InsertDevice(tenThietBi, loaiThietBi, ngayMua, tinhTrang, ref error);
            }
            else
            {
                result = deviceBLL.UpdateDevice(maThietBi, tenThietBi, loaiThietBi, ngayMua, tinhTrang, ref error);
            }

            if (result)
            {
                MessageBox.Show("Lưu thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
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
        private void BtnHover_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = System.Drawing.Color.FromArgb(41, 128, 185); // xanh
                btn.ForeColor = System.Drawing.Color.White; // chữ trắng
            }
        }

        private void BtnHover_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = System.Drawing.Color.White; // nền trắng
                btn.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185); // chữ xanh
            }
        }
    }
}
