namespace PresentationLayer
{
    partial class DeviceAndRoomForm
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
            this.dgvPhongThietBi = new System.Windows.Forms.DataGridView();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSuaThietBi = new System.Windows.Forms.Button();
            this.btnXoaThietBi = new System.Windows.Forms.Button();
            this.btnThemThietBi = new System.Windows.Forms.Button();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboThietBi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongThietBi
            // 
            this.dgvPhongThietBi.AllowUserToAddRows = false;
            this.dgvPhongThietBi.AllowUserToDeleteRows = false;
            this.dgvPhongThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongThietBi.Location = new System.Drawing.Point(10, 64);
            this.dgvPhongThietBi.Name = "dgvPhongThietBi";
            this.dgvPhongThietBi.ReadOnly = true;
            this.dgvPhongThietBi.Size = new System.Drawing.Size(667, 566);
            this.dgvPhongThietBi.TabIndex = 0;
            this.dgvPhongThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongThietBi_CellClick);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(823, 177);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(240, 26);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(701, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên thiết bị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(701, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng";
            // 
            // btnSuaThietBi
            // 
            this.btnSuaThietBi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThietBi.Location = new System.Drawing.Point(956, 251);
            this.btnSuaThietBi.Name = "btnSuaThietBi";
            this.btnSuaThietBi.Size = new System.Drawing.Size(107, 47);
            this.btnSuaThietBi.TabIndex = 29;
            this.btnSuaThietBi.Text = "Sửa";
            this.btnSuaThietBi.UseVisualStyleBackColor = true;
            this.btnSuaThietBi.Click += new System.EventHandler(this.btnSuaThietBi_Click);
            // 
            // btnXoaThietBi
            // 
            this.btnXoaThietBi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThietBi.Location = new System.Drawing.Point(832, 251);
            this.btnXoaThietBi.Name = "btnXoaThietBi";
            this.btnXoaThietBi.Size = new System.Drawing.Size(107, 47);
            this.btnXoaThietBi.TabIndex = 28;
            this.btnXoaThietBi.Text = "Xóa";
            this.btnXoaThietBi.UseVisualStyleBackColor = true;
            this.btnXoaThietBi.Click += new System.EventHandler(this.btnXoaThietBi_Click);
            // 
            // btnThemThietBi
            // 
            this.btnThemThietBi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThietBi.Location = new System.Drawing.Point(704, 251);
            this.btnThemThietBi.Name = "btnThemThietBi";
            this.btnThemThietBi.Size = new System.Drawing.Size(107, 47);
            this.btnThemThietBi.TabIndex = 27;
            this.btnThemThietBi.Text = "Thêm";
            this.btnThemThietBi.UseVisualStyleBackColor = true;
            this.btnThemThietBi.Click += new System.EventHandler(this.btnThemThietBi_Click);
            // 
            // cboPhong
            // 
            this.cboPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(823, 64);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(240, 26);
            this.cboPhong.TabIndex = 30;
            // 
            // cboThietBi
            // 
            this.cboThietBi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThietBi.FormattingEnabled = true;
            this.cboThietBi.Location = new System.Drawing.Point(823, 122);
            this.cboThietBi.Name = "cboThietBi";
            this.cboThietBi.Size = new System.Drawing.Size(240, 26);
            this.cboThietBi.TabIndex = 31;
            // 
            // DeviceAndRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 642);
            this.Controls.Add(this.cboThietBi);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.btnSuaThietBi);
            this.Controls.Add(this.btnXoaThietBi);
            this.Controls.Add(this.btnThemThietBi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.dgvPhongThietBi);
            this.Name = "DeviceAndRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceAndRoomForm";
            this.Load += new System.EventHandler(this.DeviceAndRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongThietBi;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSuaThietBi;
        private System.Windows.Forms.Button btnXoaThietBi;
        private System.Windows.Forms.Button btnThemThietBi;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboThietBi;
    }
}