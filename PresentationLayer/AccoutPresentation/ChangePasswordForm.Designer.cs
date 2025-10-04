namespace PresentationLayer.AccoutPresentation
{
    partial class ChangePasswordForm
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
            this.lbNhapLaiMK = new System.Windows.Forms.Label();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.ckbHienMK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbNhapLaiMK
            // 
            this.lbNhapLaiMK.AutoSize = true;
            this.lbNhapLaiMK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbNhapLaiMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbNhapLaiMK.Location = new System.Drawing.Point(13, 165);
            this.lbNhapLaiMK.Name = "lbNhapLaiMK";
            this.lbNhapLaiMK.Size = new System.Drawing.Size(137, 20);
            this.lbNhapLaiMK.TabIndex = 31;
            this.lbNhapLaiMK.Text = "Nhập lại mật khẩu";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhapLaiMK.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNhapLaiMK.Location = new System.Drawing.Point(151, 163);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(243, 27);
            this.txtNhapLaiMK.TabIndex = 30;
            this.txtNhapLaiMK.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên tài khoản";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Enabled = false;
            this.txtTenTK.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenTK.Location = new System.Drawing.Point(151, 32);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.ReadOnly = true;
            this.txtTenTK.Size = new System.Drawing.Size(243, 27);
            this.txtTenTK.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mật khẩu mới";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatKhau.Location = new System.Drawing.Point(151, 100);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(243, 27);
            this.txtMatKhau.TabIndex = 25;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(184)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(17, 248);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 45);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(244, 248);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 45);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // ckbHienMK
            // 
            this.ckbHienMK.AutoSize = true;
            this.ckbHienMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ckbHienMK.ForeColor = System.Drawing.Color.DimGray;
            this.ckbHienMK.Location = new System.Drawing.Point(151, 196);
            this.ckbHienMK.Name = "ckbHienMK";
            this.ckbHienMK.Size = new System.Drawing.Size(104, 19);
            this.ckbHienMK.TabIndex = 32;
            this.ckbHienMK.Text = "Hiện mật khẩu";
            this.ckbHienMK.CheckedChanged += new System.EventHandler(this.ckbHienMK_CheckedChanged);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(406, 324);
            this.Controls.Add(this.ckbHienMK);
            this.Controls.Add(this.lbNhapLaiMK);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapLaiMK;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.CheckBox ckbHienMK;
    }
}