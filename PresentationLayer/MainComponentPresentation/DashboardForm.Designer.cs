namespace PresentationLayer
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        //    System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        //    System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
        //    System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        //    System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        //    System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
        //    this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        //    this.chartThietBi = new System.Windows.Forms.DataVisualization.Charting.Chart();
        //    this.chartPhong = new System.Windows.Forms.DataVisualization.Charting.Chart();
        //    this.btnPage1 = new System.Windows.Forms.Button();
        //    this.btnPage2 = new System.Windows.Forms.Button();
        //    this.tableLayoutPanel1.SuspendLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.chartThietBi)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.chartPhong)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // tableLayoutPanel1
        //    // 
        //    this.tableLayoutPanel1.ColumnCount = 2;
        //    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        //    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        //    this.tableLayoutPanel1.Controls.Add(this.chartThietBi, 1, 0);
        //    this.tableLayoutPanel1.Controls.Add(this.chartPhong, 0, 0);
        //    this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        //    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        //    this.tableLayoutPanel1.RowCount = 1;
        //    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        //    this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 520);
        //    this.tableLayoutPanel1.TabIndex = 4;
        //    // 
        //    // chartThietBi
        //    // 
        //    chartArea5.Name = "ChartArea1";
        //    this.chartThietBi.ChartAreas.Add(chartArea5);
        //    legend5.Name = "Legend1";
        //    this.chartThietBi.Legends.Add(legend5);
        //    this.chartThietBi.Location = new System.Drawing.Point(548, 3);
        //    this.chartThietBi.Name = "chartThietBi";
        //    this.chartThietBi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
        //    series5.ChartArea = "ChartArea1";
        //    series5.Legend = "Legend1";
        //    series5.Name = "Series1";
        //    this.chartThietBi.Series.Add(series5);
        //    this.chartThietBi.Size = new System.Drawing.Size(540, 514);
        //    this.chartThietBi.TabIndex = 1;
        //    this.chartThietBi.Text = "chart2";
        //    // 
        //    // chartPhong
        //    // 
        //    chartArea6.Name = "ChartArea1";
        //    this.chartPhong.ChartAreas.Add(chartArea6);
        //    legend6.Name = "Legend1";
        //    this.chartPhong.Legends.Add(legend6);
        //    this.chartPhong.Location = new System.Drawing.Point(3, 3);
        //    this.chartPhong.Name = "chartPhong";
        //    series6.ChartArea = "ChartArea1";
        //    series6.Legend = "Legend1";
        //    series6.Name = "Series1";
        //    this.chartPhong.Series.Add(series6);
        //    this.chartPhong.Size = new System.Drawing.Size(539, 514);
        //    this.chartPhong.TabIndex = 0;
        //    this.chartPhong.Text = "chart1";
        //    // 
        //    // btnPage1
        //    // 
        //    this.btnPage1.Location = new System.Drawing.Point(519, 646);
        //    this.btnPage1.Name = "btnPage1";
        //    this.btnPage1.Size = new System.Drawing.Size(23, 23);
        //    this.btnPage1.TabIndex = 5;
        //    this.btnPage1.Text = "1";
        //    this.btnPage1.UseVisualStyleBackColor = true;
        //    // 
        //    // btnPage2
        //    // 
        //    this.btnPage2.Location = new System.Drawing.Point(548, 646);
        //    this.btnPage2.Name = "btnPage2";
        //    this.btnPage2.Size = new System.Drawing.Size(23, 23);
        //    this.btnPage2.TabIndex = 6;
        //    this.btnPage2.Text = "2";
        //    this.btnPage2.UseVisualStyleBackColor = true;
        //    this.btnPage2.Click += new System.EventHandler(this.btnPage2_Click);
        //    // 
        //    // DashboardForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(1091, 681);
        //    this.Controls.Add(this.btnPage2);
        //    this.Controls.Add(this.btnPage1);
        //    this.Controls.Add(this.tableLayoutPanel1);
        //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    this.Name = "DashboardForm";
        //    this.Text = "DashboardForm";
        //    this.Load += new System.EventHandler(this.DashboardForm_Load);
        //    this.tableLayoutPanel1.ResumeLayout(false);
        //    ((System.ComponentModel.ISupportInitialize)(this.chartThietBi)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.chartPhong)).EndInit();
        //    this.ResumeLayout(false);

        //}
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.tblChart = new System.Windows.Forms.TableLayoutPanel();
            this.chartPhong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartThietBi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Black;
            this.lblThongBao.Location = new System.Drawing.Point(12, 9);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(91, 45);
            this.lblThongBao.TabIndex = 7;
            this.lblThongBao.Text = "Title";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPage2
            // 
            this.btnPage2.BackColor = System.Drawing.Color.White;
            this.btnPage2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPage2.FlatAppearance.BorderSize = 2;
            this.btnPage2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnPage2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPage2.Location = new System.Drawing.Point(549, 620);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(35, 35);
            this.btnPage2.TabIndex = 6;
            this.btnPage2.Text = "2";
            this.btnPage2.UseVisualStyleBackColor = false;
            this.btnPage2.Click += new System.EventHandler(this.btnPage2_Click);
            this.btnPage2.MouseEnter += new System.EventHandler(this.btnPage_MouseEnter);
            this.btnPage2.MouseLeave += new System.EventHandler(this.btnPage_MouseLeave);
            // 
            // btnPage1
            // 
            this.btnPage1.BackColor = System.Drawing.Color.White;
            this.btnPage1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPage1.FlatAppearance.BorderSize = 2;
            this.btnPage1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnPage1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPage1.Location = new System.Drawing.Point(508, 620);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(35, 35);
            this.btnPage1.TabIndex = 5;
            this.btnPage1.Text = "1";
            this.btnPage1.UseVisualStyleBackColor = false;
            this.btnPage1.MouseEnter += new System.EventHandler(this.btnPage_MouseEnter);
            this.btnPage1.MouseLeave += new System.EventHandler(this.btnPage_MouseLeave);
            // 
            // tblChart
            // 
            this.tblChart.BackColor = System.Drawing.Color.White;
            this.tblChart.ColumnCount = 2;
            this.tblChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblChart.Controls.Add(this.chartThietBi, 1, 0);
            this.tblChart.Controls.Add(this.chartPhong, 0, 0);
            this.tblChart.Location = new System.Drawing.Point(1, 72);
            this.tblChart.Name = "tblChart";
            this.tblChart.RowCount = 1;
            this.tblChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblChart.Size = new System.Drawing.Size(1091, 520);
            this.tblChart.TabIndex = 4;
            // 
            // chartPhong
            // 
            this.chartPhong.BorderlineColor = System.Drawing.Color.Black;
            this.chartPhong.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartPhong.BorderlineWidth = 2;
            chartArea7.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea7.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea7.BackColor = System.Drawing.Color.White;
            chartArea7.Name = "ChartArea1";
            this.chartPhong.ChartAreas.Add(chartArea7);
            this.chartPhong.Dock = System.Windows.Forms.DockStyle.Left;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            this.chartPhong.Legends.Add(legend7);
            this.chartPhong.Location = new System.Drawing.Point(3, 3);
            this.chartPhong.Name = "chartPhong";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartPhong.Series.Add(series7);
            this.chartPhong.Size = new System.Drawing.Size(539, 514);
            this.chartPhong.TabIndex = 0;
            this.chartPhong.Text = "chart1";
            // 
            // chartThietBi
            // 
            this.chartThietBi.BorderlineColor = System.Drawing.Color.Black;
            this.chartThietBi.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartThietBi.BorderlineWidth = 2;
            chartArea8.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea8.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea8.BackColor = System.Drawing.Color.White;
            chartArea8.Name = "ChartArea1";
            this.chartThietBi.ChartAreas.Add(chartArea8);
            this.chartThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            this.chartThietBi.Legends.Add(legend8);
            this.chartThietBi.Location = new System.Drawing.Point(548, 3);
            this.chartThietBi.Name = "chartThietBi";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartThietBi.Series.Add(series8);
            this.chartThietBi.Size = new System.Drawing.Size(540, 514);
            this.chartThietBi.TabIndex = 1;
            this.chartThietBi.Text = "chart2";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 681);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnPage2);
            this.Controls.Add(this.btnPage1);
            this.Controls.Add(this.tblChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tblChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.TableLayoutPanel tblChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThietBi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhong;
    }
}