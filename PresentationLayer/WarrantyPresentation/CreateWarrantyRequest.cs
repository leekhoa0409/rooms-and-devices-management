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
            cboTinhTrang.SelectedIndex = 0;
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

        }

        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tinhTrang = cboTinhTrang.Text.ToString();
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
            cboPhong.DataSource = null;
            cboThietBi.DataSource = null;
            cboPhong.DataSource = dtPhong;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.SelectedIndex = -1;

            cboThietBi.DataSource = dtThietBi;
            cboThietBi.DisplayMember = "TenTB";
            cboThietBi.ValueMember = "MaTB";
            cboThietBi.SelectedIndex = -1;
        }

        private void cboThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboThietBi.SelectedValue == null || cboThietBi.SelectedValue is DataRowView) return;
            string maTB = cboThietBi.SelectedValue.ToString();
            DeviceBLL deviceBLL = new DeviceBLL();
            DataTable dt = deviceBLL.GetRoomByDeviceId(maTB);
            if (dt != null || dt.Rows.Count > 0)
            {
                cboPhong.DataSource= dt;
                cboPhong.ValueMember = "MaPhong";
                cboPhong.DisplayMember = "TenPhong";
            }
            else
            {
                cboPhong.DataSource = null;
            }
            cboPhong.SelectedIndex = -1;
        }
    }
}
