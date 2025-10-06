using BussinessLogicLayer;
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

namespace PresentationLayer
{
    public partial class DeviceManagementForm : Form
    {
        private DeviceBLL deviceBLL;
        public DeviceManagementForm()
        {
            InitializeComponent();
            deviceBLL = new DeviceBLL();
        }

        private void DeviceManagementForm_Load(object sender, EventArgs e)
        {
            LoadDevices();
            cboTinhTrang.SelectedIndex = 0;
        }

        private void LoadDevices()
        {
            DataTable dt = deviceBLL.GetAllDevices();
            dgvThietBi.DataSource = dt;
            lbThietBi.Text = deviceBLL.GetCountDevices().ToString();
        }
        private void FilterDevices()
        {
            string tinhTrang = cboTinhTrang.SelectedItem.ToString();
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
                return;
            }
            DataTable dt = deviceBLL.FilterDevice(fromDate, toDate, tinhTrang);
            dgvThietBi.DataSource = dt;
        }


        private void btnLocNgay_Click(object sender, EventArgs e)
        {
            FilterDevices();
        }

        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinhTrang = cboTinhTrang.SelectedItem.ToString();
            if (tinhTrang == null || tinhTrang == "Tất cả")
            {
                LoadDevices();
            }
            else
            {
                DataTable dt = deviceBLL.FilterDeviceByStatus(tinhTrang);
                dgvThietBi.DataSource = dt;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimThietBi.Text.ToString();
            DataTable dt = deviceBLL.FindDevice(keyword);
            dgvThietBi.DataSource = dt;
        }

        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            DeviceInsertUpdateForm f = new DeviceInsertUpdateForm("add");
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadDevices();
            }
        }

        private void btnSuaThietBi_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow != null)
            {
                string maThietBi = dgvThietBi.CurrentRow.Cells["MaTB"].Value.ToString();
                DeviceInsertUpdateForm f = new DeviceInsertUpdateForm("edit", maThietBi);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadDevices();
                }
            }
        }
        private void btnXoaThietBi_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow != null)
            {
                string maThietBi = dgvThietBi.CurrentRow.Cells["MaTB"].Value.ToString();
                string tenThietBi = dgvThietBi.CurrentRow.Cells["TenTB"].Value.ToString();
                string error = "";
                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa {tenThietBi} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    bool deleted = deviceBLL.DeleteDevice(maThietBi, ref error);
                    if (deleted)
                    {
                        MessageBox.Show("Xóa thiết bị thành công!");
                        LoadDevices();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại: " + error);
                    }
                }
            }
        }

        private void btnQLTB_Click(object sender, EventArgs e)
        {
            DeviceAndRoomForm f = new DeviceAndRoomForm();
            f.Show();
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
