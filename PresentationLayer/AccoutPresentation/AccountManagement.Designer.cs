namespace PresentationLayer.AccoutPresentation
{
    partial class AccountManagement
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
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenTK
            // 
            this.txtTenTK.Enabled = false;
            this.txtTenTK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Location = new System.Drawing.Point(815, 45);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(253, 25);
            this.txtTenTK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(724, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên tài khoản";
            // 
            // cboRole
            // 
            this.cboRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "AdminRole",
            "ManagerRole",
            "UserRole"});
            this.cboRole.Location = new System.Drawing.Point(815, 103);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(252, 25);
            this.cboRole.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vai trò";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(12, 45);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(706, 512);
            this.dgvTaiKhoan.TabIndex = 24;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSua.Location = new System.Drawing.Point(853, 458);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 47);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnSua.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnSua.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnXoa.Location = new System.Drawing.Point(853, 366);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 47);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnXoa.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThem.FlatAppearance.BorderSize = 2;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThem.Location = new System.Drawing.Point(853, 277);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 47);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnThem.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.ControlBox = false;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "AccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountManagement";
            this.Load += new System.EventHandler(this.AccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}