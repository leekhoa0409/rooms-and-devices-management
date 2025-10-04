namespace PresentationLayer
{
    partial class CreateWarrantyRequest
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayYC = new System.Windows.Forms.DateTimePicker();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTB = new System.Windows.Forms.Label();
            this.cboThietBi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(316, 454);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 46);
            this.btnHuy.TabIndex = 34;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(184)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(37, 454);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 46);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ngày yêu cầu";
            // 
            // dtpNgayYC
            // 
            this.dtpNgayYC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayYC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayYC.Location = new System.Drawing.Point(142, 77);
            this.dtpNgayYC.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpNgayYC.Name = "dtpNgayYC";
            this.dtpNgayYC.Size = new System.Drawing.Size(306, 25);
            this.dtpNgayYC.TabIndex = 41;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(142, 286);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(306, 138);
            this.txtNoiDung.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nội dung";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(142, 22);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(306, 25);
            this.txtTaiKhoan.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tên tài khoản";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.Location = new System.Drawing.Point(34, 184);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(84, 17);
            this.lbPhong.TabIndex = 43;
            this.lbPhong.Text = "Chọn phòng";
            // 
            // cboPhong
            // 
            this.cboPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(142, 181);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(306, 25);
            this.cboPhong.TabIndex = 46;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTinhTrang.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTinhTrang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Tất cả",
            "Đang dùng",
            "Bảo trì",
            "Cũ"});
            this.cboTinhTrang.Location = new System.Drawing.Point(142, 131);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(306, 25);
            this.cboTinhTrang.TabIndex = 49;
            this.cboTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cboTinhTrang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Tình trạng";
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.Location = new System.Drawing.Point(31, 233);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(89, 17);
            this.lbTB.TabIndex = 45;
            this.lbTB.Text = "Chọn thiết bị";
            // 
            // cboThietBi
            // 
            this.cboThietBi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboThietBi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThietBi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThietBi.FormattingEnabled = true;
            this.cboThietBi.Location = new System.Drawing.Point(142, 233);
            this.cboThietBi.Name = "cboThietBi";
            this.cboThietBi.Size = new System.Drawing.Size(306, 25);
            this.cboThietBi.TabIndex = 47;
            // 
            // CreateWarrantyRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(482, 532);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboThietBi);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.lbPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgayYC);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Name = "CreateWarrantyRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo mới yêu cầu bảo trì";
            this.Load += new System.EventHandler(this.CreateWarrantyRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayYC;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.ComboBox cboThietBi;
    }
}