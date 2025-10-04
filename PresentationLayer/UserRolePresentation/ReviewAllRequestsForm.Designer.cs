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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvXemLai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemLai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuaYeuCau
            // 
            this.btnSuaYeuCau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSuaYeuCau.FlatAppearance.BorderSize = 0;
            this.btnSuaYeuCau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(184)))));
            this.btnSuaYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaYeuCau.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSuaYeuCau.ForeColor = System.Drawing.Color.White;
            this.btnSuaYeuCau.Location = new System.Drawing.Point(840, 444);
            this.btnSuaYeuCau.Name = "btnSuaYeuCau";
            this.btnSuaYeuCau.Size = new System.Drawing.Size(161, 62);
            this.btnSuaYeuCau.TabIndex = 1;
            this.btnSuaYeuCau.Text = "Sửa yêu cầu";
            this.btnSuaYeuCau.UseVisualStyleBackColor = false;
            this.btnSuaYeuCau.Click += new System.EventHandler(this.btnSuaYeuCau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nội dung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thiết bị";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(768, 33);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(287, 242);
            this.txtNoiDung.TabIndex = 5;
            // 
            // cboPhong
            // 
            this.cboPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(830, 340);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(225, 25);
            this.cboPhong.TabIndex = 6;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            // 
            // cboThietBi
            // 
            this.cboThietBi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboThietBi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThietBi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThietBi.FormattingEnabled = true;
            this.cboThietBi.Location = new System.Drawing.Point(830, 397);
            this.cboThietBi.Name = "cboThietBi";
            this.cboThietBi.Size = new System.Drawing.Size(225, 26);
            this.cboThietBi.TabIndex = 7;
            this.cboThietBi.SelectedIndexChanged += new System.EventHandler(this.cboThietBi_SelectedIndexChanged);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đang dùng",
            "Bảo trì",
            "Cũ"});
            this.cboTrangThai.Location = new System.Drawing.Point(830, 281);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(225, 25);
            this.cboTrangThai.TabIndex = 39;
            this.cboTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboTrangThai_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(765, 284);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 17);
            this.label19.TabIndex = 38;
            this.label19.Text = "Trạng thái";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(840, 531);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(161, 62);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Hủy yêu cầu";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvXemLai
            // 
            this.dgvXemLai.AllowUserToAddRows = false;
            this.dgvXemLai.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvXemLai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvXemLai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXemLai.BackgroundColor = System.Drawing.Color.White;
            this.dgvXemLai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvXemLai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXemLai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvXemLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXemLai.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvXemLai.EnableHeadersVisualStyles = false;
            this.dgvXemLai.Location = new System.Drawing.Point(12, 12);
            this.dgvXemLai.Name = "dgvXemLai";
            this.dgvXemLai.ReadOnly = true;
            this.dgvXemLai.RowHeadersVisible = false;
            this.dgvXemLai.Size = new System.Drawing.Size(736, 581);
            this.dgvXemLai.TabIndex = 41;
            // 
            // ReviewAllRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1068, 642);
            this.Controls.Add(this.dgvXemLai);
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
            this.Name = "ReviewAllRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem lại yêu cầu bảo trì";
            this.Load += new System.EventHandler(this.ReviewAllRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dgvXemLai;
    }
}