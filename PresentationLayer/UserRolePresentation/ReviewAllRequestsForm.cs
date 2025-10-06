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
        }
        private void LoadAllRequest()
        {
            DataTable dt = warrantyBLL.GetRequestByUser(Session.currentUser);
            dgvXemLai.DataSource = dt;
        }

        private void dgvXemLai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvXemLai.Rows[e.RowIndex];
                string trangThai = row.Cells["TrangThai"].Value?.ToString().Trim();

                if (trangThai != "Đang xử lý")
                {
                    btnHuy.Enabled = false;
                }
                else
                {
                    btnHuy.Enabled = true;
                }
            }
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
