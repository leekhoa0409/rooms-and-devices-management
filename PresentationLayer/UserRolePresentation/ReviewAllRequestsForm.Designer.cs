namespace PresentationLayer.UserRolePresentation
{
    partial class ReviewAllRequestsForm
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
            this.dgvXemLai = new System.Windows.Forms.DataGridView();
            this.btnSuaYeuCau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboThietBi = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemLai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXemLai
            // 
            this.dgvXemLai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXemLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemLai.Location = new System.Drawing.Point(12, 12);
            this.dgvXemLai.Name = "dgvXemLai";
            this.dgvXemLai.Size = new System.Drawing.Size(570, 385);
            this.dgvXemLai.TabIndex = 0;
            this.dgvXemLai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXemLai_CellClick);
            // 
            // btnSuaYeuCau
            // 
            this.btnSuaYeuCau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaYeuCau.Location = new System.Drawing.Point(667, 444);
            this.btnSuaYeuCau.Name = "btnSuaYeuCau";
            this.btnSuaYeuCau.Size = new System.Drawing.Size(161, 62);
            this.btnSuaYeuCau.TabIndex = 1;
            this.btnSuaYeuCau.Text = "Sửa yêu cầu";
            this.btnSuaYeuCau.UseVisualStyleBackColor = true;
            this.btnSuaYeuCau.Click += new System.EventHandler(this.btnSuaYeuCau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nội dung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(593, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thiết bị";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(602, 33);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(281, 230);
            this.txtNoiDung.TabIndex = 5;
            // 
            // cboPhong
            // 
            this.cboPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(658, 312);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(225, 26);
            this.cboPhong.TabIndex = 6;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            // 
            // cboThietBi
            // 
            this.cboThietBi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThietBi.FormattingEnabled = true;
            this.cboThietBi.Location = new System.Drawing.Point(658, 354);
            this.cboThietBi.Name = "cboThietBi";
            this.cboThietBi.Size = new System.Drawing.Size(225, 26);
            this.cboThietBi.TabIndex = 7;
            this.cboThietBi.SelectedIndexChanged += new System.EventHandler(this.cboThietBi_SelectedIndexChanged);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đang dùng",
            "Bảo trì",
            "Cũ"});
            this.cboTrangThai.Location = new System.Drawing.Point(675, 269);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(208, 26);
            this.cboTrangThai.TabIndex = 39;
            this.cboTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboTrangThai_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(593, 272);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 18);
            this.label19.TabIndex = 38;
            this.label19.Text = "Trạng thái";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(228, 444);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(161, 62);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Hủy yêu cầu";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // ReviewAllRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 518);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cboThietBi);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuaYeuCau);
            this.Controls.Add(this.dgvXemLai);
            this.Name = "ReviewAllRequestsForm";
            this.Text = "ReviewAllRequestsForm";
            this.Load += new System.EventHandler(this.ReviewAllRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXemLai;
        private System.Windows.Forms.Button btnSuaYeuCau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboThietBi;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnHuy;
    }
}