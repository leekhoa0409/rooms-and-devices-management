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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartThietBi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPhong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartThietBi, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartPhong, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 520);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // chartThietBi
            // 
            chartArea5.Name = "ChartArea1";
            this.chartThietBi.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartThietBi.Legends.Add(legend5);
            this.chartThietBi.Location = new System.Drawing.Point(548, 3);
            this.chartThietBi.Name = "chartThietBi";
            this.chartThietBi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartThietBi.Series.Add(series5);
            this.chartThietBi.Size = new System.Drawing.Size(540, 514);
            this.chartThietBi.TabIndex = 1;
            this.chartThietBi.Text = "chart2";
            // 
            // chartPhong
            // 
            chartArea6.Name = "ChartArea1";
            this.chartPhong.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPhong.Legends.Add(legend6);
            this.chartPhong.Location = new System.Drawing.Point(3, 3);
            this.chartPhong.Name = "chartPhong";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartPhong.Series.Add(series6);
            this.chartPhong.Size = new System.Drawing.Size(539, 514);
            this.chartPhong.TabIndex = 0;
            this.chartPhong.Text = "chart1";
            // 
            // btnPage1
            // 
            this.btnPage1.Location = new System.Drawing.Point(519, 646);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(23, 23);
            this.btnPage1.TabIndex = 5;
            this.btnPage1.Text = "1";
            this.btnPage1.UseVisualStyleBackColor = true;
            // 
            // btnPage2
            // 
            this.btnPage2.Location = new System.Drawing.Point(548, 646);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(23, 23);
            this.btnPage2.TabIndex = 6;
            this.btnPage2.Text = "2";
            this.btnPage2.UseVisualStyleBackColor = true;
            this.btnPage2.Click += new System.EventHandler(this.btnPage2_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 681);
            this.Controls.Add(this.btnPage2);
            this.Controls.Add(this.btnPage1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThietBi;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnPage2;
    }
}