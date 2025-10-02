using System.Windows.Forms;

namespace PresentationLayer
{
    partial class DeviceManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimThietBi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSuaThietBi = new System.Windows.Forms.Button();
            this.btnXoaThietBi = new System.Windows.Forms.Button();
            this.btnThemThietBi = new System.Windows.Forms.Button();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnLocNgay = new System.Windows.Forms.Button();
            this.btnQLTB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbThietBi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Lọc theo tình trạng: ";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.BackColor = System.Drawing.Color.Gainsboro;
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTinhTrang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Tất cả",
            "Đang dùng",
            "Cũ"});
            this.cboTinhTrang.Location = new System.Drawing.Point(315, 20);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(200, 25);
            this.cboTinhTrang.TabIndex = 33;
            this.cboTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cboTinhTrang_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 2;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTimKiem.Location = new System.Drawing.Point(981, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 32);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.btnTimKiem.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnTimKiem.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // txtTimThietBi
            // 
            this.txtTimThietBi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimThietBi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimThietBi.Location = new System.Drawing.Point(673, 22);
            this.txtTimThietBi.Name = "txtTimThietBi";
            this.txtTimThietBi.Size = new System.Drawing.Size(302, 25);
            this.txtTimThietBi.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(603, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tìm kiếm";
            // 
            // btnSuaThietBi
            // 
            this.btnSuaThietBi.BackColor = System.Drawing.Color.White;
            this.btnSuaThietBi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSuaThietBi.FlatAppearance.BorderSize = 2;
            this.btnSuaThietBi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnSuaThietBi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSuaThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaThietBi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaThietBi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSuaThietBi.Location = new System.Drawing.Point(927, 392);
            this.btnSuaThietBi.Name = "btnSuaThietBi";
            this.btnSuaThietBi.Size = new System.Drawing.Size(134, 47);
            this.btnSuaThietBi.TabIndex = 26;
            this.btnSuaThietBi.Text = "Sửa";
            this.btnSuaThietBi.UseVisualStyleBackColor = false;
            this.btnSuaThietBi.Click += new System.EventHandler(this.btnSuaThietBi_Click);
            this.btnSuaThietBi.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnSuaThietBi.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // btnXoaThietBi
            // 
            this.btnXoaThietBi.BackColor = System.Drawing.Color.White;
            this.btnXoaThietBi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnXoaThietBi.FlatAppearance.BorderSize = 2;
            this.btnXoaThietBi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnXoaThietBi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnXoaThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThietBi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaThietBi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnXoaThietBi.Location = new System.Drawing.Point(927, 300);
            this.btnXoaThietBi.Name = "btnXoaThietBi";
            this.btnXoaThietBi.Size = new System.Drawing.Size(134, 47);
            this.btnXoaThietBi.TabIndex = 25;
            this.btnXoaThietBi.Text = "Xóa";
            this.btnXoaThietBi.UseVisualStyleBackColor = false;
            this.btnXoaThietBi.Click += new System.EventHandler(this.btnXoaThietBi_Click);
            this.btnXoaThietBi.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnXoaThietBi.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // btnThemThietBi
            // 
            this.btnThemThietBi.BackColor = System.Drawing.Color.White;
            this.btnThemThietBi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThemThietBi.FlatAppearance.BorderSize = 2;
            this.btnThemThietBi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnThemThietBi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThemThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThietBi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemThietBi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThemThietBi.Location = new System.Drawing.Point(927, 211);
            this.btnThemThietBi.Name = "btnThemThietBi";
            this.btnThemThietBi.Size = new System.Drawing.Size(134, 47);
            this.btnThemThietBi.TabIndex = 24;
            this.btnThemThietBi.Text = "Thêm";
            this.btnThemThietBi.UseVisualStyleBackColor = false;
            this.btnThemThietBi.Click += new System.EventHandler(this.btnThemThietBi_Click);
            this.btnThemThietBi.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnThemThietBi.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvThietBi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.Color.White;
            this.dgvThietBi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThietBi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThietBi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThietBi.EnableHeadersVisualStyles = false;
            this.dgvThietBi.Location = new System.Drawing.Point(12, 144);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.ReadOnly = true;
            this.dgvThietBi.RowHeadersVisible = false;
            this.dgvThietBi.Size = new System.Drawing.Size(892, 512);
            this.dgvThietBi.TabIndex = 23;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dtpFrom.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpFrom.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(212, 78);
            this.dtpFrom.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(303, 25);
            this.dtpFrom.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(179, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Từ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(630, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Đến:";
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dtpTo.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpTo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dtpTo.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(673, 78);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(299, 25);
            this.dtpTo.TabIndex = 38;
            // 
            // btnLocNgay
            // 
            this.btnLocNgay.BackColor = System.Drawing.Color.White;
            this.btnLocNgay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLocNgay.FlatAppearance.BorderSize = 2;
            this.btnLocNgay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnLocNgay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLocNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLocNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLocNgay.Location = new System.Drawing.Point(981, 74);
            this.btnLocNgay.Name = "btnLocNgay";
            this.btnLocNgay.Size = new System.Drawing.Size(80, 32);
            this.btnLocNgay.TabIndex = 39;
            this.btnLocNgay.Text = "Lọc";
            this.btnLocNgay.UseVisualStyleBackColor = false;
            this.btnLocNgay.Click += new System.EventHandler(this.btnLocNgay_Click);
            this.btnLocNgay.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnLocNgay.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // btnQLTB
            // 
            this.btnQLTB.BackColor = System.Drawing.Color.White;
            this.btnQLTB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLTB.FlatAppearance.BorderSize = 2;
            this.btnQLTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnQLTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLTB.Location = new System.Drawing.Point(927, 483);
            this.btnQLTB.Name = "btnQLTB";
            this.btnQLTB.Size = new System.Drawing.Size(134, 47);
            this.btnQLTB.TabIndex = 40;
            this.btnQLTB.Text = "Quản lý thiết bị";
            this.btnQLTB.UseVisualStyleBackColor = false;
            this.btnQLTB.Click += new System.EventHandler(this.btnQLTB_Click);
            this.btnQLTB.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnQLTB.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Lọc theo ngày";
            // 
            // lbThietBi
            // 
            this.lbThietBi.AutoSize = true;
            this.lbThietBi.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThietBi.ForeColor = System.Drawing.Color.Red;
            this.lbThietBi.Location = new System.Drawing.Point(45, 51);
            this.lbThietBi.Name = "lbThietBi";
            this.lbThietBi.Size = new System.Drawing.Size(42, 50);
            this.lbThietBi.TabIndex = 44;
            this.lbThietBi.Text = "0";
            this.lbThietBi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.WindowText;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "💻 Tổng số thiết bị";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeviceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.ControlBox = false;
            this.Controls.Add(this.lbThietBi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnQLTB);
            this.Controls.Add(this.btnLocNgay);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimThietBi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSuaThietBi);
            this.Controls.Add(this.btnXoaThietBi);
            this.Controls.Add(this.btnThemThietBi);
            this.Controls.Add(this.dgvThietBi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeviceManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceManagementForm";
            this.Load += new System.EventHandler(this.DeviceManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimThietBi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSuaThietBi;
        private System.Windows.Forms.Button btnXoaThietBi;
        private System.Windows.Forms.Button btnThemThietBi;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnLocNgay;
        private System.Windows.Forms.Button btnQLTB;
        private System.Windows.Forms.Label label4;
        private Label lbThietBi;
        private Label label5;
    }
}