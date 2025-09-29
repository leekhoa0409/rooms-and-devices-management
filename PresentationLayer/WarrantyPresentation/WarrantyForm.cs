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
using static System.Net.WebRequestMethods;

namespace PresentationLayer
{
    public partial class WarrantyForm : Form
    {
        private RoomBLL roomBLL;
        private DeviceBLL deviceBLL;
        private WarrantyBLL warrantyBLL;
        public WarrantyForm()
        {
            InitializeComponent();
            warrantyBLL = new WarrantyBLL();
            roomBLL = new RoomBLL();
            deviceBLL = new DeviceBLL();
        }

        private void WarrantyForm_Load(object sender, EventArgs e)
        {
            DataTable dtPhong = roomBLL.GetAllRoom();
            cboPhong.DataSource = dtPhong;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.SelectedIndex = -1;

            DataTable dtThietBi = deviceBLL.GetAllDevices();
            cboThietBi.DataSource = dtThietBi;
            cboThietBi.DisplayMember = "TenTB";
            cboThietBi.ValueMember = "MaTB";
            cboThietBi.SelectedIndex = -1;
            cboLocTrangThai.SelectedIndex = 0;
        }
        private void LoadRoomWarranty()
        {
            DataTable dtPhong = warrantyBLL.GetRoomWarrantyInfo();
            dgvBaoTriPhong.DataSource = dtPhong;
        }
        private void LoadDeviceWarranty()
        {
            DataTable dtThietBi= warrantyBLL.GetDeviceWarrantyInfo();
            dgvBaoTriThietBi.DataSource = dtThietBi;
        }

        private void LoadRequestWarranty()
        {
            DataTable dt = warrantyBLL.GetRequestWarrantyInfo();
            dgvYeuCauBaoTri.DataSource = dt;
        }

        private void dgvBaoTriPhong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBaoTriPhong.Rows[e.RowIndex];

                txtMaBaoTri.Text = row.Cells["MaBT"].Value?.ToString();
                txtMaPhong.Text = row.Cells["MaPhong"].Value?.ToString();
                txtTenPhong.Text = row.Cells["TenPhong"].Value?.ToString();
                if (row.Cells["ChiPhi"].Value != DBNull.Value && row.Cells["ChiPhi"].Value != null)
                {
                    txtChiPhi.Text = row.Cells["ChiPhi"].Value.ToString();
                }
                else
                {
                    txtChiPhi.Text = string.Empty;
                }
                if (row.Cells["NgayBT"].Value != DBNull.Value && row.Cells["NgayBT"].Value != null)
                {
                    dtpNgayBaoTri.Value = Convert.ToDateTime(row.Cells["NgayBT"].Value);
                    dtpNgayBaoTri.Format = DateTimePickerFormat.Short;
                    dtpNgayBaoTri.CustomFormat = null;
                }
                else
                {
                    dtpNgayBaoTri.Format = DateTimePickerFormat.Custom;
                    dtpNgayBaoTri.CustomFormat = " ";
                }
                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
                txtDonViThucHien.Text = row.Cells["DonViThucHien"].Value?.ToString();
            }
        }

        private void btnSuaTTBTP_Click(object sender, EventArgs e)
        {
            string maBaoTri = txtMaBaoTri.Text;
            DateTime? ngayBaoTri = null;
            if (dtpNgayBaoTri.CustomFormat != " ")
            {
                ngayBaoTri = dtpNgayBaoTri.Value;
            }

            int? chiPhi = null;
            try
            {
                if (!string.IsNullOrWhiteSpace(txtChiPhi.Text))
                {
                    chiPhi = int.Parse(txtChiPhi.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message);
                return;
            }

            string donViThucHien = txtDonViThucHien.Text;
            string trangThai = cboTrangThai.Text;
            string error = "";

            bool updated = warrantyBLL.UpdateWarrantyInfo(maBaoTri, ngayBaoTri, chiPhi, donViThucHien, trangThai, ref error);
            if (updated)
            {
                MessageBox.Show("Cập nhật thông tin bảo trì thành công!");
                LoadRoomWarranty();
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin bảo trì: " + error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabQuanLyYeuCau)
            {
                LoadRequestWarranty();
                dtpNgayYC.Format = DateTimePickerFormat.Custom;
                dtpNgayYC.CustomFormat = " ";
            }
            else if (tabControl1.SelectedTab == tabPhong)
            {
                LoadRoomWarranty();
                dtpNgayBaoTri.Format = DateTimePickerFormat.Custom;
                dtpNgayBaoTri.CustomFormat = " ";
            }
            else if (tabControl1.SelectedTab == tabThietBi)
            {
                LoadDeviceWarranty();
                dtpNgayBaoTriTB.Format = DateTimePickerFormat.Custom;
                dtpNgayBaoTriTB.CustomFormat = " ";
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            CreateWarrantyRequest f = new CreateWarrantyRequest();
            DialogResult result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadRequestWarranty();
            }
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

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            string maYC = dgvYeuCauBaoTri.CurrentRow.Cells["MaYC"].Value.ToString();
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn từ chối yêu cầu bảo trì [{maYC}] không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                string error = "";
                bool denied = warrantyBLL.DenyRequest(maYC, ref error);
                if (denied)
                {
                    MessageBox.Show("Đã từ chối yêu cầu bảo trì!");
                    LoadRequestWarranty();
                }
                else
                {
                    MessageBox.Show("Lỗi từ chối phê duyệt: " + error);
                }
            }
        }

        private void dgvYeuCauBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvYeuCauBaoTri.Rows[e.RowIndex];

                txtTaiKhoan.Text = row.Cells["TenTK"].Value?.ToString();
                dtpNgayYC.Format = DateTimePickerFormat.Short;
                dtpNgayYC.CustomFormat = null;
                dtpNgayYC.Value = Convert.ToDateTime(row.Cells["NgayYC"].Value);
                txtNoiDung.Text = row.Cells["NoiDung"].Value?.ToString();
                cboChonTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
                cboPhong.SelectedValue = row.Cells["MaPhong"].Value?.ToString();
                cboThietBi.SelectedValue = row.Cells["MaTB"].Value?.ToString();
                string trangThai = row.Cells["TrangThai"].Value?.ToString();
                
                if (trangThai != "Đang xử lý")
                {
                    btnPheDuyet.Enabled = false;
                    btnTuChoi.Enabled = false;
                }
                else
                {
                    btnPheDuyet.Enabled = true;
                    btnTuChoi.Enabled = true;
                }
            }
        }
        private void btnPheDuyet_Click(object sender, EventArgs e)
        {
            if (dgvYeuCauBaoTri.CurrentRow == null) return;

            string maYC = dgvYeuCauBaoTri.CurrentRow.Cells["MaYC"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn phê duyệt yêu cầu bảo trì [{maYC}] không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                string error = "";
                bool accepted = warrantyBLL.AcceptRequest(maYC, ref error);
                if (accepted)
                {
                    MessageBox.Show("Phê duyệt yêu cầu thành công!");
                    LoadRequestWarranty();
                }
                else
                {
                    MessageBox.Show("Lỗi phê duyệt: " + error);
                }
            }
        }


        private void btnSuaYeuCau_Click(object sender, EventArgs e)
        {
            string error = "";
            string maYC = dgvYeuCauBaoTri.CurrentRow.Cells["MaYC"].Value?.ToString();
            DateTime? ngayYC = null;
            if (dtpNgayYC.CustomFormat != " ")
            {
                ngayYC = dtpNgayYC.Value;
            }
            string noiDung = txtNoiDung.Text;
            string trangThai = cboChonTrangThai.Text;

            // Lấy mã phòng (có thể null)
            string maPhongStr = null;
            object maPhongValue = cboPhong.SelectedValue;
            if (maPhongValue != null && maPhongValue != DBNull.Value)
            {
                maPhongStr = maPhongValue.ToString();
            }

            // Lấy mã thiết bị (có thể null)
            string maTBStr = null;
            if (cboThietBi.SelectedValue != null && cboThietBi.SelectedValue != DBNull.Value)
            {
                maTBStr = cboThietBi.SelectedValue.ToString();
            }

            bool updated = warrantyBLL.UpdateRequestWarrantyInfo(maYC, ngayYC, noiDung, trangThai, maPhongStr, maTBStr, ref error);

            if (updated)
            {
                MessageBox.Show("Sửa thông tin yêu cầu bảo trì thành công!");
                LoadRequestWarranty();
            }
            else
            {
                MessageBox.Show("Lỗi sửa thông tin: " + error);
            }
        }

        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cboLocTrangThai.SelectedItem?.ToString();
            DataTable dt;
            if (selectedStatus == null || selectedStatus == "Tất cả")
            {
                dt = warrantyBLL.GetRequestWarrantyInfo();
            }
            else
            {
                dt = warrantyBLL.FilterRequestsByStatus(selectedStatus);
            }
            dgvYeuCauBaoTri.DataSource = dt;
        }
        private void dgvBaoTriThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBaoTriThietBi.Rows[e.RowIndex];

                txtMaBTTB.Text = row.Cells["MaBT"].Value?.ToString();
                txtMaPhongTB.Text = row.Cells["MaPhong"].Value?.ToString();
                txtTenPhongTB.Text = row.Cells["TenPhong"].Value?.ToString();
                txtMaTB.Text = row.Cells["MaTB"].Value?.ToString();
                txtTenTB.Text = row.Cells["TenTB"].Value?.ToString();
                cboTrangThaiTB.Text = row.Cells["TrangThai"].Value?.ToString();

                if (row.Cells["ChiPhi"].Value != DBNull.Value && row.Cells["ChiPhi"].Value != null)
                    txtChiPhiTB.Text = row.Cells["ChiPhi"].Value.ToString();
                else
                    txtChiPhiTB.Text = string.Empty;

                if (row.Cells["NgayBT"].Value != DBNull.Value && row.Cells["NgayBT"].Value != null)
                {
                    dtpNgayBaoTriTB.Value = Convert.ToDateTime(row.Cells["NgayBT"].Value);
                    dtpNgayBaoTriTB.Format = DateTimePickerFormat.Short;
                    dtpNgayBaoTriTB.CustomFormat = null;
                }
                else
                {
                    dtpNgayBaoTriTB.Format = DateTimePickerFormat.Custom;
                    dtpNgayBaoTriTB.CustomFormat = " ";
                }
                if (row.Cells["DonViThucHien"].Value != DBNull.Value && row.Cells["DonViThucHien"].Value != null)
                    txtDVTHTB.Text = row.Cells["DonViThucHien"].Value.ToString();
                else
                    txtDVTHTB.Text = string.Empty;
            }
        }

        private void dtpNgayBaoTriTB_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayBaoTriTB.Format = DateTimePickerFormat.Short;
            dtpNgayBaoTriTB.CustomFormat = null;
        }

        private void dtpNgayYC_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayYC.Format = DateTimePickerFormat.Short;
            dtpNgayYC.CustomFormat = null;
        }

        private void dtpNgayBaoTri_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayBaoTri.Format = DateTimePickerFormat.Short;
            dtpNgayBaoTri.CustomFormat = null;
        }

        private void btnSuaTTBTTB_Click(object sender, EventArgs e)
        {
            string maBT = txtMaBTTB.Text;
            string maPhong = txtMaPhongTB.Text;
            string tenPhong = txtTenPhongTB.Text;
            string maTB = txtMaTB.Text;
            string tenTB = txtTenTB.Text;
            int? chiPhi = null;
            try
            {
                if (!string.IsNullOrWhiteSpace(txtChiPhiTB.Text))
                {
                    chiPhi = int.Parse(txtChiPhiTB.Text);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message);
                return;
            }
            DateTime? ngayBT = null;
            if (dtpNgayBaoTriTB.CustomFormat != " ")
            {
                ngayBT = dtpNgayBaoTriTB.Value;
            }
            string dvth = txtDVTHTB.Text;
            string trangthai = cboTrangThaiTB.Text;
            string error = "";
            bool updated = warrantyBLL.UpdateWarrantyInfo(maBT, ngayBT, chiPhi, dvth, trangthai, ref error);
            if (updated)
            {
                MessageBox.Show("Cập nhật thông tin bảo trì thành công!");
                LoadDeviceWarranty();
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin bảo trì: " + error);
            }
        }

        private void btnXoaTTBTTB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoNamTB.Text))
            {
                MessageBox.Show("Vui lòng nhập số năm trước đó muốn xóa!");
                return;
            }
            else
            {
                try
                {
                    int soNam = warrantyBLL.DeleteDeviceWarrantyByYears(txtSoNamTB.Text);
                    MessageBox.Show("Đã xóa thành công " + soNam + " bảng ghi!");
                    LoadDeviceWarranty();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!" + ex);
                }
            }
        }

        private void bntXoaTTBTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoNamP.Text))
            {
                MessageBox.Show("Vui lòng nhập số năm trước đó muốn xóa!");
                return;
            }
            else
            {
                try
                {
                    int soNam = warrantyBLL.DeleteRoomWarrantyByYears(txtSoNamP.Text);
                    MessageBox.Show("Đã xóa thành công " + soNam + " bảng ghi!");
                    LoadRoomWarranty();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!" + ex);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadRequestWarranty();
            dtpNgayYC.Format = DateTimePickerFormat.Custom;
            dtpNgayYC.CustomFormat = " ";
            txtNoiDung.Text = null;
            cboChonTrangThai.Text = null;
            cboPhong.SelectedIndex = -1;
            cboThietBi.SelectedIndex = -1;
            cboChonTrangThai.SelectedIndex = -1;
            cboLocTrangThai.SelectedIndex = -1;
        }

        private void btnCLearP_Click(object sender, EventArgs e)
        {
            LoadRoomWarranty();
            txtMaPhong.Text = null;
            txtMaBaoTri.Text = null;
            txtTenPhong.Text = null;
            txtChiPhi.Text = null;
            dtpNgayBaoTri.Format = DateTimePickerFormat.Custom;
            dtpNgayBaoTri.CustomFormat = " ";
            cboTrangThai.SelectedIndex = -1;
            txtDonViThucHien.Text = null;
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            LoadDeviceWarranty();
            txtMaBTTB.Text = null;
            txtMaPhongTB.Text = null;
            txtTenPhongTB.Text = null;
            txtMaTB.Text = null;
            txtTenTB.Text = null;
            txtChiPhiTB.Text = null;
            dtpNgayBaoTriTB.Format = DateTimePickerFormat.Custom;
            dtpNgayBaoTri.CustomFormat = " ";
            cboTrangThaiTB.SelectedIndex = -1;
            txtDVTHTB.Text = null; 
        }
    }
}
