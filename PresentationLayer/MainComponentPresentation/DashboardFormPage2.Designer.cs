namespace PresentationLayer.MainComponentPresentation
{
    partial class DashboardFormPage2
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
            this.chartChiPhiBaoTri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBaoTri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartChiPhiBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBaoTri)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartBaoTri, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartChiPhiBaoTri, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartChiPhiBaoTri
            // 
            chartArea5.Name = "ChartArea1";
            this.chartChiPhiBaoTri.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartChiPhiBaoTri.Legends.Add(legend5);
            this.chartChiPhiBaoTri.Location = new System.Drawing.Point(548, 3);
            this.chartChiPhiBaoTri.Name = "chartChiPhiBaoTri";
            this.chartChiPhiBaoTri.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartChiPhiBaoTri.Series.Add(series5);
            this.chartChiPhiBaoTri.Size = new System.Drawing.Size(540, 514);
            this.chartChiPhiBaoTri.TabIndex = 4;
            this.chartChiPhiBaoTri.Text = "chart4";
            // 
            // chartBaoTri
            // 
            chartArea6.Name = "ChartArea1";
            this.chartBaoTri.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartBaoTri.Legends.Add(legend6);
            this.chartBaoTri.Location = new System.Drawing.Point(3, 3);
            this.chartBaoTri.Name = "chartBaoTri";
            this.chartBaoTri.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartBaoTri.Series.Add(series6);
            this.chartBaoTri.Size = new System.Drawing.Size(539, 514);
            this.chartBaoTri.TabIndex = 3;
            this.chartBaoTri.Text = "chart3";
            // 
            // cboNam
            // 
            this.cboNam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(120, 534);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(164, 26);
            this.cboNam.TabIndex = 1;
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lọc theo năm";
            // 
            // btnPage2
            // 
            this.btnPage2.Location = new System.Drawing.Point(548, 646);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(23, 23);
            this.btnPage2.TabIndex = 8;
            this.btnPage2.Text = "2";
            this.btnPage2.UseVisualStyleBackColor = true;
            // 
            // btnPage1
            // 
            this.btnPage1.Location = new System.Drawing.Point(519, 646);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(23, 23);
            this.btnPage1.TabIndex = 7;
            this.btnPage1.Text = "1";
            this.btnPage1.UseVisualStyleBackColor = true;
            this.btnPage1.Click += new System.EventHandler(this.btnPage1_Click);
            // 
            // DashboardFormPage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 681);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnPage2);
            this.Controls.Add(this.btnPage1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "DashboardFormPage2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardFormPage2";
            this.Load += new System.EventHandler(this.DashboardFormPage2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartChiPhiBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBaoTri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBaoTri;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChiPhiBaoTri;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.Button btnPage1;
    }
}