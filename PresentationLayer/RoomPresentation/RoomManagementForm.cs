using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer;

namespace PresentationLayer
{
    public partial class RoomManagementForm : Form
    {
        private RoomBLL roomBLL;
        private bool isInitializng = true;
        public RoomManagementForm()
        {
            InitializeComponent();
            roomBLL = new RoomBLL();
        }

        private void RoomManagementForm_Load(object sender, EventArgs e)
        {
            LoadRoom();
            cboLoaiPhong.SelectedIndex = 0;
            cboTinhTrang.SelectedIndex = 0;
            isInitializng = false;
        }

        private void LoadRoom()
        {
            DataTable dt = roomBLL.GetAllRoom();
            dgvPhong.DataSource = dt;
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            RoomInsertUpdateForm f = new RoomInsertUpdateForm("Add");
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadRoom(); // Refresh lại DataGridView
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow != null)
            {
                string maPhong = dgvPhong.CurrentRow.Cells["MaPhong"].Value.ToString();
                RoomInsertUpdateForm f = new RoomInsertUpdateForm("Edit", maPhong);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadRoom();
                }
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {

            if (dgvPhong.CurrentRow != null)
            {
                string maPhong = dgvPhong.CurrentRow.Cells["MaPhong"].Value.ToString();
                string error = "";
                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa phòng {maPhong} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    bool deleted = roomBLL.DeleteRoom(maPhong, ref error);
                    if (deleted)
                    {
                        MessageBox.Show("Xóa phòng thành công!");
                        LoadRoom();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại: " + error);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimPhong.Text.ToString();
            DataTable dt = roomBLL.FindRoom(keyword);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvPhong.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng nào!");
                LoadRoom();
            }
        }
        private void FilterRooms()
        {
            string loaiPhong;
            string tinhTrang;
            object loaiPhongObject = cboLoaiPhong.SelectedItem;
            if (loaiPhongObject != null)
            {
                loaiPhong = loaiPhongObject.ToString();
            }
            else
            {
                return;
            }
            object tinhTrangObject = cboTinhTrang.SelectedItem;
            if (tinhTrangObject != null)
            {
                tinhTrang = tinhTrangObject.ToString();
            }
            else
            {
                return;
            }
            DataTable dt = roomBLL.FilterRoom(loaiPhong, tinhTrang);
            dgvPhong.DataSource = dt;
        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializng)
            {
                return ;
            }
            FilterRooms();  
        }

        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializng)
            {
                return;
            }
            FilterRooms();
        }
    }
}
