namespace PresentationLayer
{
    partial class RoomManagementForm
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
        //    this.dgvPhong = new System.Windows.Forms.DataGridView();
        //    this.btnThemPhong = new System.Windows.Forms.Button();
        //    this.btnXoaPhong = new System.Windows.Forms.Button();
        //    this.btnSuaPhong = new System.Windows.Forms.Button();
        //    this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
        //    this.label6 = new System.Windows.Forms.Label();
        //    this.label7 = new System.Windows.Forms.Label();
        //    this.label9 = new System.Windows.Forms.Label();
        //    this.txtTimPhong = new System.Windows.Forms.TextBox();
        //    this.btnTimKiem = new System.Windows.Forms.Button();
        //    this.label1 = new System.Windows.Forms.Label();
        //    this.cboTinhTrang = new System.Windows.Forms.ComboBox();
        //    ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // dgvPhong
        //    // 
        //    this.dgvPhong.AllowUserToAddRows = false;
        //    this.dgvPhong.AllowUserToDeleteRows = false;
        //    this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        //    this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    this.dgvPhong.Location = new System.Drawing.Point(25, 136);
        //    this.dgvPhong.Name = "dgvPhong";
        //    this.dgvPhong.ReadOnly = true;
        //    this.dgvPhong.Size = new System.Drawing.Size(725, 533);
        //    this.dgvPhong.TabIndex = 0;
        //    // 
        //    // btnThemPhong
        //    // 
        //    this.btnThemPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnThemPhong.Location = new System.Drawing.Point(373, 73);
        //    this.btnThemPhong.Name = "btnThemPhong";
        //    this.btnThemPhong.Size = new System.Drawing.Size(107, 47);
        //    this.btnThemPhong.TabIndex = 11;
        //    this.btnThemPhong.Text = "Thêm";
        //    this.btnThemPhong.UseVisualStyleBackColor = true;
        //    this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
        //    // 
        //    // btnXoaPhong
        //    // 
        //    this.btnXoaPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnXoaPhong.Location = new System.Drawing.Point(643, 73);
        //    this.btnXoaPhong.Name = "btnXoaPhong";
        //    this.btnXoaPhong.Size = new System.Drawing.Size(107, 47);
        //    this.btnXoaPhong.TabIndex = 12;
        //    this.btnXoaPhong.Text = "Xóa";
        //    this.btnXoaPhong.UseVisualStyleBackColor = true;
        //    this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
        //    // 
        //    // btnSuaPhong
        //    // 
        //    this.btnSuaPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnSuaPhong.Location = new System.Drawing.Point(509, 73);
        //    this.btnSuaPhong.Name = "btnSuaPhong";
        //    this.btnSuaPhong.Size = new System.Drawing.Size(107, 47);
        //    this.btnSuaPhong.TabIndex = 13;
        //    this.btnSuaPhong.Text = "Sửa";
        //    this.btnSuaPhong.UseVisualStyleBackColor = true;
        //    this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
        //    // 
        //    // cboLoaiPhong
        //    // 
        //    this.cboLoaiPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.cboLoaiPhong.FormattingEnabled = true;
        //    this.cboLoaiPhong.Items.AddRange(new object[] {
        //    "Tất cả",
        //    "Máy tính",
        //    "Đọc sách",
        //    "Mượn trả",
        //    "Kho",
        //    "Làm việc",
        //    "In ấn"});
        //    this.cboLoaiPhong.Location = new System.Drawing.Point(174, 36);
        //    this.cboLoaiPhong.Name = "cboLoaiPhong";
        //    this.cboLoaiPhong.Size = new System.Drawing.Size(139, 26);
        //    this.cboLoaiPhong.TabIndex = 14;
        //    this.cboLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhong_SelectedIndexChanged);
        //    // 
        //    // label6
        //    // 
        //    this.label6.AutoSize = true;
        //    this.label6.Location = new System.Drawing.Point(248, 84);
        //    this.label6.Name = "label6";
        //    this.label6.Size = new System.Drawing.Size(0, 13);
        //    this.label6.TabIndex = 15;
        //    // 
        //    // label7
        //    // 
        //    this.label7.AutoSize = true;
        //    this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.label7.Location = new System.Drawing.Point(22, 39);
        //    this.label7.Name = "label7";
        //    this.label7.Size = new System.Drawing.Size(152, 18);
        //    this.label7.TabIndex = 16;
        //    this.label7.Text = "Lọc theo loại phòng: ";
        //    // 
        //    // label9
        //    // 
        //    this.label9.AutoSize = true;
        //    this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.label9.Location = new System.Drawing.Point(370, 39);
        //    this.label9.Name = "label9";
        //    this.label9.Size = new System.Drawing.Size(71, 18);
        //    this.label9.TabIndex = 18;
        //    this.label9.Text = "Tìm kiếm";
        //    // 
        //    // txtTimPhong
        //    // 
        //    this.txtTimPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.txtTimPhong.Location = new System.Drawing.Point(447, 37);
        //    this.txtTimPhong.Name = "txtTimPhong";
        //    this.txtTimPhong.Size = new System.Drawing.Size(227, 26);
        //    this.txtTimPhong.TabIndex = 19;
        //    // 
        //    // btnTimKiem
        //    // 
        //    this.btnTimKiem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnTimKiem.Location = new System.Drawing.Point(680, 37);
        //    this.btnTimKiem.Name = "btnTimKiem";
        //    this.btnTimKiem.Size = new System.Drawing.Size(70, 26);
        //    this.btnTimKiem.TabIndex = 20;
        //    this.btnTimKiem.Text = "Tìm";
        //    this.btnTimKiem.UseVisualStyleBackColor = true;
        //    this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
        //    // 
        //    // label1
        //    // 
        //    this.label1.AutoSize = true;
        //    this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.label1.Location = new System.Drawing.Point(22, 86);
        //    this.label1.Name = "label1";
        //    this.label1.Size = new System.Drawing.Size(142, 18);
        //    this.label1.TabIndex = 22;
        //    this.label1.Text = "Lọc theo tình trạng: ";
        //    // 
        //    // cboTinhTrang
        //    // 
        //    this.cboTinhTrang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.cboTinhTrang.FormattingEnabled = true;
        //    this.cboTinhTrang.Items.AddRange(new object[] {
        //    "Tất cả",
        //    "Đang dùng",
        //    "Bảo trì",
        //    "Cũ"});
        //    this.cboTinhTrang.Location = new System.Drawing.Point(174, 83);
        //    this.cboTinhTrang.Name = "cboTinhTrang";
        //    this.cboTinhTrang.Size = new System.Drawing.Size(139, 26);
        //    this.cboTinhTrang.TabIndex = 21;
        //    this.cboTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cboTinhTrang_SelectedIndexChanged);
        //    // 
        //    // RoomManagementForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(1264, 681);
        //    this.Controls.Add(this.label1);
        //    this.Controls.Add(this.cboTinhTrang);
        //    this.Controls.Add(this.btnTimKiem);
        //    this.Controls.Add(this.txtTimPhong);
        //    this.Controls.Add(this.label9);
        //    this.Controls.Add(this.label7);
        //    this.Controls.Add(this.label6);
        //    this.Controls.Add(this.cboLoaiPhong);
        //    this.Controls.Add(this.btnSuaPhong);
        //    this.Controls.Add(this.btnXoaPhong);
        //    this.Controls.Add(this.btnThemPhong);
        //    this.Controls.Add(this.dgvPhong);
        //    this.Name = "RoomManagementForm";
        //    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        //    this.Text = "RoomManagementForm";
        //    this.Load += new System.EventHandler(this.RoomManagementForm_Load);
        //    ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimPhong = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.lbPhong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPhong.EnableHeadersVisualStyles = false;
            this.dgvPhong.Location = new System.Drawing.Point(12, 114);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.Size = new System.Drawing.Size(1060, 555);
            this.dgvPhong.TabIndex = 0;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.Color.White;
            this.btnThemPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThemPhong.FlatAppearance.BorderSize = 2;
            this.btnThemPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnThemPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThemPhong.Location = new System.Drawing.Point(605, 53);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(107, 47);
            this.btnThemPhong.TabIndex = 11;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            this.btnThemPhong.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnThemPhong.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.Color.White;
            this.btnXoaPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnXoaPhong.FlatAppearance.BorderSize = 2;
            this.btnXoaPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnXoaPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnXoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnXoaPhong.Location = new System.Drawing.Point(965, 53);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(107, 47);
            this.btnXoaPhong.TabIndex = 13;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            this.btnXoaPhong.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnXoaPhong.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.BackColor = System.Drawing.Color.White;
            this.btnSuaPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSuaPhong.FlatAppearance.BorderSize = 2;
            this.btnSuaPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnSuaPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSuaPhong.Location = new System.Drawing.Point(801, 53);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(107, 47);
            this.btnSuaPhong.TabIndex = 12;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            this.btnSuaPhong.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnSuaPhong.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.BackColor = System.Drawing.Color.Gainsboro;
            this.cboLoaiPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "Tất cả",
            "Máy tính",
            "Đọc sách",
            "Mượn trả",
            "Kho",
            "Làm việc",
            "In ấn"});
            this.cboLoaiPhong.Location = new System.Drawing.Point(324, 16);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(220, 25);
            this.cboLoaiPhong.TabIndex = 14;
            this.cboLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhong_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lọc theo loại phòng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(601, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tìm kiếm";
            // 
            // txtTimPhong
            // 
            this.txtTimPhong.BackColor = System.Drawing.Color.White;
            this.txtTimPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimPhong.Location = new System.Drawing.Point(671, 16);
            this.txtTimPhong.Name = "txtTimPhong";
            this.txtTimPhong.Size = new System.Drawing.Size(325, 25);
            this.txtTimPhong.TabIndex = 19;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 2;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTimKiem.Location = new System.Drawing.Point(1002, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(70, 26);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.btnTimKiem.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnTimKiem.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lọc theo tình trạng:";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.BackColor = System.Drawing.Color.Gainsboro;
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
            this.cboTinhTrang.Location = new System.Drawing.Point(324, 75);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(220, 25);
            this.cboTinhTrang.TabIndex = 21;
            this.cboTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cboTinhTrang_SelectedIndexChanged);
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.ForeColor = System.Drawing.Color.Red;
            this.lbPhong.Location = new System.Drawing.Point(42, 50);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(42, 50);
            this.lbPhong.TabIndex = 44;
            this.lbPhong.Text = "0";
            this.lbPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "🏠 Tổng số phòng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.ControlBox = false;
            this.Controls.Add(this.lbPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimPhong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.btnSuaPhong);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.dgvPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.RoomManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimPhong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label label5;
    }
}