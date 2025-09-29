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

namespace PresentationLayer.UserRolePresentation
{
    public partial class ReviewAllRequestsForm : Form
    {
        private WarrantyBLL warrantyBLL;
        private RoomBLL roomBLL;
        private DeviceBLL deviceBLL;
        public ReviewAllRequestsForm()
        {
            InitializeComponent();
            warrantyBLL = new WarrantyBLL();
            roomBLL = new RoomBLL();
            deviceBLL = new DeviceBLL();
        }

        private void ReviewAllRequestsForm_Load(object sender, EventArgs e)
        {
            LoadAllRequest();
            //DataTable dtPhong = roomBLL.GetAllRoom();
            //cboPhong.DataSource = dtPhong;
            //cboPhong.DisplayMember = "TenPhong";
            //cboPhong.ValueMember = "MaPhong";
            //cboPhong.SelectedIndex = -1;

            //DataTable dtRoom = deviceBLL.GetAllDevices();
            //cboThietBi.DataSource = dtRoom;
            //cboThietBi.DisplayMember = "TenTB";
            //cboThietBi.ValueMember = "MaTB";
            //cboThietBi.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
        }
        private void LoadAllRequest()
        {
            DataTable dt = warrantyBLL.GetRequestByUser(Session.currentUser);
            dgvXemLai.DataSource = dt;
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhong.SelectedIndex >= 0)
            {
                cboThietBi.Enabled = false;
            }
            else
            {
                cboThietBi.Enabled = true;
            }
        }

        private void cboThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboThietBi.SelectedIndex >= 0)
            {
                cboPhong.Enabled = false;
            }
            else
            {
                cboPhong.Enabled = true;
            }
        }

        private void btnSuaYeuCau_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvXemLai.CurrentRow;

            string maYC = row.Cells["MaYC"].Value.ToString();
            DateTime ngayYC = Convert.ToDateTime(row.Cells["NgayYC"].Value);
            string noiDung = txtNoiDung.Text;
            string maPhong = null;
            if (cboPhong.SelectedValue != DBNull.Value && cboPhong.SelectedValue != null)
            {
                maPhong = cboPhong.SelectedValue.ToString();
            }

            string maTB = null;
            if (cboThietBi.SelectedValue != DBNull.Value && cboThietBi.SelectedValue != null)
            {
                maTB = cboThietBi.SelectedValue.ToString();
            }

            string trangThai = row.Cells["TrangThai"].Value.ToString();

            string error = "";
            bool updated = warrantyBLL.UpdateRequestWarrantyInfo(maYC, ngayYC, noiDung, trangThai, maPhong, maTB, ref error);
            if (updated)
            {
                MessageBox.Show("Cập nhật thông tin yêu cầu bảo trì thành công!");
                LoadAllRequest();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật thông tin " + error);
            }
        }


        private void dgvXemLai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvXemLai.Rows[e.RowIndex];
                txtNoiDung.Text = row.Cells["NoiDung"].Value?.ToString();
                cboPhong.SelectedValue = row.Cells["MaPhong"].Value;
                cboThietBi.SelectedValue = row.Cells["MaTB"].Value;
                if (row.Cells["TrangThai"].Value.ToString() == "Đã hoàn thành")
                {
                    btnSuaYeuCau.Enabled = false;
                    btnHuy.Enabled = false;
                }
                else
                {
                    btnSuaYeuCau.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThai = cboTrangThai.Text;
            if (trangThai == null) return;

            RoomBLL roomBLL = new RoomBLL();
            DeviceBLL deviceBLL = new DeviceBLL();
            DataTable dtPhong;
            DataTable dtThietBi;
            if (trangThai == "Tất cả")
            {
                dtPhong = roomBLL.GetAllRoom();
                dtThietBi = deviceBLL.GetAllDevices();
            }
            else
            {
                dtPhong = roomBLL.FilterRoomByStatus(trangThai);
                dtThietBi = deviceBLL.FilterDeviceByStatus(trangThai);
            }

            cboPhong.DataSource = dtPhong;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.SelectedIndex = -1;

            cboThietBi.DataSource = dtThietBi;
            cboThietBi.DisplayMember = "TenTB";
            cboThietBi.ValueMember = "MaTB";
            cboThietBi.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvXemLai.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("Vui lòng chọn yêu cầu cần hủy!");
                return;
            }

            string maYC = row.Cells["MaYC"].Value.ToString();

            // Hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy yêu cầu này không?",
                "Xác nhận hủy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                string error = "";
                bool canceled = warrantyBLL.DenyRequest(maYC, ref error);
                if (canceled)
                {
                    MessageBox.Show("Hủy yêu cầu thành công!");
                    LoadAllRequest();
                }
                else
                {
                    MessageBox.Show("Lỗi khi hủy yêu cầu: " + error);
                }
            }
        }
    }
}
