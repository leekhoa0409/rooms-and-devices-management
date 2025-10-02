using BussinessLogicLayer;
using PresentationLayer.MainComponentPresentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentationLayer
{
    public partial class DashboardForm : Form
    {
        private MainForm mainForm;
        private AnalysisBLL analysisBLL = new AnalysisBLL();
        public DashboardForm(MainForm mainForm = null)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashBoard();
        }
        public void LoadDashBoard()
        {
            LoadChartPhong();
            LoadChartThietBi();
        }
        private void LoadChartPhong()
        {
            DataTable dt = analysisBLL.ThongKePhong();

            chartPhong.Series.Clear();
            chartPhong.ChartAreas[0].Area3DStyle.Enable3D = true;

            Series s = new Series("Số phòng");
            s.ChartType = SeriesChartType.Pie;
            s.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            s["PieLabelStyle"] = "Outside";       
            s.BorderColor = Color.White;           
            s.BorderWidth = 2;
            s.IsValueShownAsLabel = true;      
            s.LabelForeColor = Color.Black;
            s.ToolTip = "#VALX: #VALY phòng (#PERCENT{P0})";

            foreach (DataRow row in dt.Rows)
            {
                string loaiPhong = row["LoaiPhong"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                s.Points.AddXY(loaiPhong, soLuong);
            }

            chartPhong.Series.Add(s);

            // Legend
            chartPhong.Legends.Clear();
            Legend legend = new Legend("Legend1");
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;
            chartPhong.Legends.Add(legend);
        }


        public void LoadChartThietBi()
        {
            DataTable dt = analysisBLL.ThongKeThietBi();
            chartThietBi.Series.Clear();
            chartThietBi.ChartAreas[0].AxisX.Title = "Tình trạng thiết bị";
            chartThietBi.ChartAreas[0].AxisY.Title = "Số lượng";

            // Grid trục X
            chartThietBi.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartThietBi.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            // Grid trục Y
            chartThietBi.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartThietBi.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            Series s = new Series("Thiết bị");
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true; // Hiển thị số lượng trên cột
            s.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            s.LabelForeColor = Color.DarkBlue;

            // Gradient màu cho cột
            s.Color = Color.SkyBlue;
            s.BackSecondaryColor = Color.Blue;
            s.BackGradientStyle = GradientStyle.VerticalCenter;

            // Tooltip khi hover
            s.ToolTip = "#VALX: #VALY thiết bị";

            foreach (DataRow row in dt.Rows)
            {
                s.Points.AddXY(row["TinhTrang"], row["SoLuong"]);
            }

            chartThietBi.Series.Add(s);

            // Thêm legend để hiển thị tên series
            chartThietBi.Legends.Clear();
            Legend legend = new Legend("Legend1");
            legend.Docking = Docking.Bottom;
            chartThietBi.Legends.Add(legend);
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.LoadForm(new DashboardFormPage2(mainForm));
            }
        }
        private void btnPage_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btn.ForeColor = System.Drawing.Color.White;
        }

        private void btnPage_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = System.Drawing.Color.White;
            btn.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
        }
    }
}
