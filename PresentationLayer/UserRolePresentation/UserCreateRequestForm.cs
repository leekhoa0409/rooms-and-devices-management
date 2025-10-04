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

namespace PresentationLayer.UserRolePresentation
{
    public partial class UserCreateRequestForm : Form
    {   
        private RoomBLL roomBLL;
        private DeviceBLL deviceBLL;
        public UserCreateRequestForm()
        {
            InitializeComponent();
            roomBLL = new RoomBLL();
            deviceBLL = new DeviceBLL();
        }

        private void UserCreateRequestForm_Load(object sender, EventArgs e)
        {
            LoadRoomAndDevice();
        }

        private void LoadRoomAndDevice()
        {
            DataTable dt = roomBLL.GetAllRoomAndDevice();
            dgvPhong.DataSource = dt;
        }

        private void btnXemLai_Click(object sender, EventArgs e)
        {
            ReviewAllRequestsForm f = new ReviewAllRequestsForm();
            f.ShowDialog();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            CreateWarrantyRequest f = new CreateWarrantyRequest();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                LoadRoomAndDevice();
            }
        }
    }
}
