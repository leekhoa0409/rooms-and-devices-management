using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BussinessLogicLayer;
using DataAccessLayer;
using PresentationLayer.AccoutPresentation;
using PresentationLayer.MainComponentPresentation;
using PresentationLayer.UserRolePresentation;
namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        private AnalysisBLL analysisBLL = new AnalysisBLL();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Session.currentRole == "UserRole")
            {
                // Ẩn các nút chỉ dành cho admin
                btnDB.Visible = false;
                btnPhong.Visible = false;
                btnThietBi.Visible = false;
                btnTK.Visible = false;
                btnBT.Visible = false;
                // Chỉ hiện nút tạo yêu cầu bảo trì
                btnTYCBT.Visible = true;
            }
            else if (Session.currentRole == "AdminRole")
            {
                LoadForm(new DashboardForm(this));
                btnDB.Visible = true;
                btnPhong.Visible = true;
                btnThietBi.Visible = true;
                btnBT.Visible = true;
                btnTK.Visible = true;
                btnTYCBT.Visible = false;
            }
        }
        public void LoadForm(Form form)
        {
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            Session.Clear();
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            LoadForm(new DashboardForm(this));
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomManagementForm());
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            LoadForm(new DeviceManagementForm());
        }

        private void btnBT_Click(object sender, EventArgs e)
        {
            LoadForm(new WarrantyForm());
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            LoadForm(new AccountManagement());
        }

        private void btnTYCBT_Click(object sender, EventArgs e)
        {
            LoadForm(new UserCreateRequestForm());
        }
    }
}
