using BussinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class CreateWarrantyRequest : Form
    {   
        private WarrantyBLL warrantyBLL;
        public CreateWarrantyRequest()
        {
            InitializeComponent();
            warrantyBLL = new WarrantyBLL();
        }

        private void CreateWarrantyRequest_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = Session.currentUser;
            cboTinhTrang.SelectedIndex = 3;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenTK = txtTaiKhoan.Text;
            string noiDung = null;
            if (!string.IsNullOrEmpty(txtNoiDung.Text)) noiDung = txtNoiDung.Text;

            DateTime ngayYC = dtpNgayYC.Value;

            string maPhongStr = null;
            object maPhongValue = cboPhong.SelectedValue;
            if (maPhongValue != null && maPhongValue != DBNull.Value)
            {
                maPhongStr = maPhongValue.ToString();
            }

            string maTBStr = null;
            if (cboThietBi.SelectedValue != null && cboThietBi.SelectedValue != DBNull.Value)
            {
                maTBStr = cboThietBi.SelectedValue.ToString();
            }

            string error = "";
            bool created = warrantyBLL.CreateRequest(tenTK, ngayYC, noiDung, maPhongStr, maTBStr, ref error);
            if (created)
            {
                MessageBox.Show("Tạo mới yêu cầu thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi tạo mới yêu cầu: " + error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhong.SelectedValue == null || cboPhong.SelectedValue is DataRowView) return;

            string maPhong = cboPhong.SelectedValue.ToString();
            string tinhTrang = cboTinhTrang.SelectedItem.ToString();
            if (tinhTrang == "Tất cả") tinhTrang = null;
            RoomBLL roomBLL = new RoomBLL();
            DataTable dt = roomBLL.GetDevicesByRoomId(maPhong, tinhTrang);

            if (dt != null && dt.Rows.Count > 0)
            {
                cboThietBi.DataSource = dt;
                cboThietBi.DisplayMember = "TenTB";
                cboThietBi.ValueMember = "MaTB";
            }
            else
            {
                cboThietBi.DataSource = null;
            }
            cboThietBi.SelectedIndex = -1;
        }

        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinhTrang = cboTinhTrang.Text;
            if (tinhTrang == null) return;

            RoomBLL roomBLL = new RoomBLL();
            DeviceBLL deviceBLL = new DeviceBLL();
            DataTable dtPhong;
            DataTable dtThietBi;
            if (tinhTrang == "Tất cả")
            {
                dtPhong = roomBLL.GetAllRoom();
                dtThietBi = deviceBLL.GetAllDevices();
            }
            else
            {
                dtPhong = roomBLL.FilterRoomByStatus(tinhTrang);
                dtThietBi = deviceBLL.FilterDeviceByStatus(tinhTrang);
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
    }
}
