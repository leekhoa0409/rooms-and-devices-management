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
        private string option;
        public CreateWarrantyRequest(string option = null)
        {
            InitializeComponent();
            warrantyBLL = new WarrantyBLL();
            this.option = option;
        }

        private void CreateWarrantyRequest_Load(object sender, EventArgs e)
        {
            if (option == "room")
            {
                cboThietBi.Enabled = false;
                cboThietBi.Visible = false;
                lbTB.Visible = false;
            }
            else if (option == "device")
            {
                cboPhong.Enabled = false;
                cboPhong.Visible = false;
                lbPhong.Visible = false;
            }
            txtTaiKhoan.Text = Session.currentUser;
            cboTrangThai.SelectedIndex = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenTK = txtTaiKhoan.Text;
            string noiDung = txtNoiDung.Text;
            DateTime ngayYC = dtpNgayYC.Value;

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

        private void cboPhong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboPhong.SelectedIndex >= 0)
            {
                cboThietBi.SelectedIndex = -1;
            }
        }

        private void cboThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboThietBi.SelectedIndex >= 0)
            {
                cboPhong.SelectedIndex = -1;
            }
        }
    }
}
