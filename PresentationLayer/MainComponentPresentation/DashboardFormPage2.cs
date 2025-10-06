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
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentationLayer.MainComponentPresentation
{
    internal partial class DashboardFormPage2 : Form
    {
        private MainForm mainForm;
        private AnalysisBLL analysisBLL;
        private bool loading = true;
        public DashboardFormPage2(MainForm mainForm = null)
        {
            analysisBLL = new AnalysisBLL();
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void DashboardFormPage2_Load(object sender, EventArgs e)
        {
            DataTable dtNam = analysisBLL.GetAllYear();
            if (dtNam == null || dtNam.Rows.Count == 0)
            {
                cboNam.DataSource = null;
                chartBaoTri.Series.Clear();
                chartChiPhiBaoTri.Series.Clear();
                lblThongBao.Text = "Chưa có dữ liệu thống kê";
                tblChart.Visible = false;
                cboNam.Visible = false;
                lbLoc.Visible = false;
            }
            else
            {
                lblThongBao.Text = "Thống kê số lượng bảo trì và chi phí";
                cboNam.DataSource = dtNam;
                cboNam.DisplayMember = "NamBT";
                cboNam.ValueMember = "NamBT";

                if (cboNam.SelectedValue != DBNull.Value && cboNam.SelectedValue != null)
                {
                    LoadChartSoLuongBaoTri(int.Parse(cboNam.SelectedValue.ToString()));
                    LoadChartChiPhiBaoTriPhongTheoNam(int.Parse(cboNam.SelectedValue.ToString()));
                }
            }
            loading = false;
        }



        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading == false)
            {
                LoadChartSoLuongBaoTri(int.Parse(cboNam.SelectedValue.ToString()));
                LoadChartChiPhiBaoTriPhongTheoNam(int.Parse(cboNam.SelectedValue.ToString()));
            }
        }
        public bool LoadChartSoLuongBaoTri(int nam)
        {
            DataTable dt = analysisBLL.ThongKeBaoTriTheoNam(nam); // BLL thay đổi để nhận tham số năm
            if (dt == null || dt.Rows.Count == 0) return false;
            chartBaoTri.Series.Clear();

            chartBaoTri.ChartAreas[0].AxisX.Title = "Tháng";
            chartBaoTri.ChartAreas[0].AxisY.Title = "Số lượng bảo trì";
            chartBaoTri.ChartAreas[0].AxisX.Interval = 1;

            chartBaoTri.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartBaoTri.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chartBaoTri.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartBaoTri.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            Series s = new Series("Bảo trì theo tháng");
            s.ChartType = SeriesChartType.Line;
            s.Color = Color.OrangeRed;
            s.BorderWidth = 3;
            s.MarkerStyle = MarkerStyle.Circle;
            s.MarkerSize = 8;
            s.MarkerColor = Color.DarkBlue;
            s.IsValueShownAsLabel = true;
            s.LabelForeColor = Color.Black;
            s.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            s.ToolTip = "#VALX: #VALY lần bảo trì";

            foreach (DataRow row in dt.Rows)
            {
                string thang = "Tháng " + row["Thang"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                s.Points.AddXY(thang, soLuong);
            }

            chartBaoTri.Series.Add(s);

            chartBaoTri.Legends.Clear();
            Legend legend = new Legend("Legend1");
            legend.Docking = Docking.Top;
            chartBaoTri.Legends.Add(legend);
            return true;
        }

        private void btnPage1_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.LoadForm(new DashboardForm(mainForm));
            }
        }
        public bool LoadChartChiPhiBaoTriPhongTheoNam(int nam)
        {
            DataTable dt = analysisBLL.ThongKeChiPhiBaoTriPhongTheoThangNam(nam);
            if (dt == null || dt.Rows.Count == 0) return false;
            chartChiPhiBaoTri.Series.Clear();

            // Cấu hình chart
            chartChiPhiBaoTri.ChartAreas[0].AxisX.Title = "Tháng";
            chartChiPhiBaoTri.ChartAreas[0].AxisY.Title = "Chi phí bảo trì (VNĐ)";
            chartChiPhiBaoTri.ChartAreas[0].AxisX.Interval = 1;
            chartChiPhiBaoTri.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartChiPhiBaoTri.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chartChiPhiBaoTri.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartChiPhiBaoTri.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            // Lấy danh sách phòng duy nhất
            var phongList = dt.AsEnumerable()
                              .Select(r => r["TenPhong"].ToString())
                              .Distinct()
                              .ToList();

            Random rnd = new Random();

            foreach (string tenPhong in phongList)
            {
                Series s = new Series(tenPhong);
                s.ChartType = SeriesChartType.Column; // đổi sang Column
                s.BorderWidth = 1;
                s.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                s.Color = Color.FromArgb(180, rnd.Next(80, 200), rnd.Next(80, 200), rnd.Next(80, 200));

                // Thêm dữ liệu 12 tháng
                for (int thang = 1; thang <= 12; thang++)
                {
                    var row = dt.AsEnumerable()
                                .FirstOrDefault(r => r["TenPhong"].ToString() == tenPhong &&
                                                     Convert.ToInt32(r["Thang"]) == thang);

                    decimal tongChiPhi = row != null ? Convert.ToDecimal(row["TongChiPhi"]) : 0;

                    int pointIndex = s.Points.AddXY(thang, tongChiPhi);

                    // Chỉ hiện nhãn nếu chi phí > 0
                    if (tongChiPhi > 0)
                        s.Points[pointIndex].Label = tongChiPhi.ToString("N0");
                }

                chartChiPhiBaoTri.Series.Add(s);
            }

            // Legend
            chartChiPhiBaoTri.Legends.Clear();
            Legend legend = new Legend("Legend1");
            legend.Docking = Docking.Top;
            legend.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            chartChiPhiBaoTri.Legends.Add(legend);
            return true;
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {

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
