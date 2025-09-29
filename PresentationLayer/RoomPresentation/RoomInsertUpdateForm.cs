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
    public partial class RoomInsertUpdateForm : Form
    {
        private string mode;
        private string maPhong;
        private RoomBLL roomBLL;
        public RoomInsertUpdateForm(string mode, string maPhong = "")
        {
            InitializeComponent();
            this.mode = mode;
            this.maPhong = maPhong;
            roomBLL = new RoomBLL();
        }

        private void RoomInsertUpdate_Load(object sender, EventArgs e)
        {
            if (maPhong != "")
            {
                DataTable dt = roomBLL.GetRoomById(maPhong);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtTenPhong.Text = dt.Rows[0]["TenPhong"].ToString();
                    cboLoaiPhong.Text = dt.Rows[0]["LoaiPhong"].ToString();
                    txtSucChua.Text = dt.Rows[0]["SucChua"].ToString();
                    cboTinhTrang.Text = dt.Rows[0]["TinhTrang"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string error = "";
            bool result = false;
            if (mode == "add")
            {
                result = roomBLL.InsertRoom(
                    txtTenPhong.Text, cboLoaiPhong.Text,
                    int.Parse(txtSucChua.Text), cboTinhTrang.Text,
                    ref error
                );
            }
            else if (mode == "edit")
            {
                result = roomBLL.UpdateRoom(
                    maPhong, txtTenPhong.Text, cboLoaiPhong.Text,
                    int.Parse(txtSucChua.Text), cboTinhTrang.Text,
                    ref error
                );
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string error = "";
            bool result = false;

            if (mode == "Add")
            {
                result = roomBLL.InsertRoom(
                    txtTenPhong.Text, cboLoaiPhong.Text,
                    int.Parse(txtSucChua.Text), cboTinhTrang.Text,
                    ref error
                );
            }
            else if (mode == "Edit")
            {
                result = roomBLL.UpdateRoom(
                    maPhong, txtTenPhong.Text, cboLoaiPhong.Text,
                    int.Parse(txtSucChua.Text), cboTinhTrang.Text,
                    ref error
                );
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
    }
}
