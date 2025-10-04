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

namespace PresentationLayer
{
    public partial class DeviceAndRoomForm : Form
    {
        DeviceBLL deviceBLL;
        public DeviceAndRoomForm()
        {
            InitializeComponent();
            deviceBLL = new DeviceBLL();
        }

        private void DeviceAndRoomForm_Load(object sender, EventArgs e)
        {
            LoadRoomAndDevice();
            RoomBLL roomBLL = new RoomBLL();
            DataTable dtPhong = roomBLL.GetAllRoom();
            cboPhong.DataSource = dtPhong;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
            DataTable dtThietBi = deviceBLL.GetAllDevices();
            cboThietBi.DataSource = dtThietBi;
            cboThietBi.DisplayMember = "TenTB";
            cboThietBi.ValueMember = "MaTB";

        }
        private void LoadRoomAndDevice()
        {
            DataTable dt = deviceBLL.GetRoomAndDevice();
            dgvPhongThietBi.DataSource = dt;
            if (dgvPhongThietBi == null && dgvPhongThietBi.Rows.Count == 0)
            {
                btnSuaThietBi.Enabled = false;
                btnXoaThietBi.Enabled = false;
                btnThemThietBi.Enabled = false;
            }
        }

        private void dgvPhongThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhongThietBi.Rows[e.RowIndex];
                cboPhong.SelectedValue = row.Cells["MaPhong"].Value.ToString();
                cboThietBi.SelectedValue = row.Cells["MaTB"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }

        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            if (cboPhong.SelectedValue == null || cboThietBi.SelectedValue == null)
            {
                return;
            }
            string maPhong = cboPhong.SelectedValue.ToString();
            string maTB = cboThietBi.SelectedValue.ToString();
            string tenPhong = cboPhong.Text.ToString();
            string tenThietBi = cboThietBi.Text.ToString();
            string soLuongValue = txtSoLuong.Text;
            int soLuong;
            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng!");
                return;
            }
            if (string.IsNullOrEmpty(maTB))
            {
                MessageBox.Show("Vui lòng chọn thiết bị");
                return;
            }
            if (!string.IsNullOrEmpty(soLuongValue))
            {
                soLuong = int.Parse(txtSoLuong.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng trước khi thêm!");
                return;
            }
            string error = "";

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc chắn muốn thêm thiết bị {tenThietBi} vào phòng {tenPhong} với số lượng {soLuong}?",
                "Xác nhận thêm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                bool inserted = deviceBLL.InsertDeviceIntoRoom(maPhong, maTB, soLuong, ref error);
                if (inserted)
                {
                    MessageBox.Show("Thêm thiết bị vào phòng thành công!");
                    LoadRoomAndDevice();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm mới: " + error);
                }
            }
        }
        private void btnXoaThietBi_Click(object sender, EventArgs e)
        {
            if (cboPhong.SelectedValue == null || cboThietBi.SelectedValue == null)
            {
                return;
            }
            string maPhong = cboPhong.SelectedValue.ToString();
            string maTB = cboThietBi.SelectedValue.ToString();
            string tenPhong = cboPhong.Text.ToString();
            string tenThietBi = cboThietBi.Text.ToString();
            string error = "";
            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng!");
                return;
            }
            if (string.IsNullOrEmpty(maTB))
            {
                MessageBox.Show("Vui lòng chọn thiết bị");
                return;
            }
            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa thiết bị {tenThietBi} khỏi phòng {tenPhong}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                bool deleted = deviceBLL.DeleteDeviceInRoom(maPhong, maTB, ref error);
                if (deleted)
                {
                    MessageBox.Show("Xóa thiết bị khỏi phòng thành công!");
                    LoadRoomAndDevice();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa: " + error);
                }
            }
        }

        private void btnSuaThietBi_Click(object sender, EventArgs e)
        {
            if (cboPhong.SelectedValue == null || cboThietBi.SelectedValue == null)
            {
                return;
            }
            string maPhong = cboPhong.SelectedValue.ToString();
            string maTB = cboThietBi.SelectedValue.ToString();
            string tenPhong = cboPhong.Text.ToString();
            string tenThietBi = cboThietBi.Text.ToString();
            string soLuongValue = txtSoLuong.Text;
            int soLuong;
            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng!");
                return;
            }
            if (string.IsNullOrEmpty(maTB))
            {
                MessageBox.Show("Vui lòng chọn thiết bị");
                return;
            }
            if (!string.IsNullOrEmpty(soLuongValue))
            {
                soLuong = int.Parse(txtSoLuong.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng trước khi cập nhật!");
                return;
            }
            string error = "";

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc chắn muốn cập nhật thiết bị {tenThietBi} trong phòng {tenPhong} thành số lượng {soLuong}?",
                "Xác nhận sửa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                bool updated = deviceBLL.UpdateDeviceInRoom(maPhong, maTB, soLuong, ref error);
                if (updated)
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadRoomAndDevice();
                }
                else
                {
                    MessageBox.Show("Lỗi khi sửa: " + error);
                }
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
