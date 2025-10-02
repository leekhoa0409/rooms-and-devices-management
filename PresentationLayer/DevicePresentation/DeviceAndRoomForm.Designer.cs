using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvPhongThietBi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhongThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongThietBi.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongThietBi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhongThietBi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhongThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongThietBi.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPhongThietBi.EnableHeadersVisualStyles = false;
            this.dgvPhongThietBi.Location = new System.Drawing.Point(12, 21);
            this.dgvPhongThietBi.Name = "dgvPhongThietBi";
            this.dgvPhongThietBi.ReadOnly = true;
            this.dgvPhongThietBi.RowHeadersVisible = false;
            this.dgvPhongThietBi.Size = new System.Drawing.Size(674, 609);
            this.dgvPhongThietBi.TabIndex = 0;
            this.dgvPhongThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongThietBi_CellClick);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(779, 137);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(277, 25);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(694, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(694, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên thiết bị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(694, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng";
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
            this.btnSuaThietBi.Location = new System.Drawing.Point(949, 205);
            this.btnSuaThietBi.Name = "btnSuaThietBi";
            this.btnSuaThietBi.Size = new System.Drawing.Size(107, 47);
            this.btnSuaThietBi.TabIndex = 29;
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
            this.btnXoaThietBi.Location = new System.Drawing.Point(823, 205);
            this.btnXoaThietBi.Name = "btnXoaThietBi";
            this.btnXoaThietBi.Size = new System.Drawing.Size(107, 47);
            this.btnXoaThietBi.TabIndex = 28;
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
            this.btnThemThietBi.Location = new System.Drawing.Point(697, 205);
            this.btnThemThietBi.Name = "btnThemThietBi";
            this.btnThemThietBi.Size = new System.Drawing.Size(107, 47);
            this.btnThemThietBi.TabIndex = 27;
            this.btnThemThietBi.Text = "Thêm";
            this.btnThemThietBi.UseVisualStyleBackColor = false;
            this.btnThemThietBi.Click += new System.EventHandler(this.btnThemThietBi_Click);
            this.btnThemThietBi.MouseEnter += new System.EventHandler(this.BtnHover_MouseEnter);
            this.btnThemThietBi.MouseLeave += new System.EventHandler(this.BtnHover_MouseLeave);
            // 
            // cboPhong
            // 
            this.cboPhong.BackColor = System.Drawing.Color.Gainsboro;
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(779, 18);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(277, 25);
            this.cboPhong.TabIndex = 30;
            // 
            // cboThietBi
            // 
            this.cboThietBi.BackColor = System.Drawing.Color.Gainsboro;
            this.cboThietBi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThietBi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboThietBi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboThietBi.FormattingEnabled = true;
            this.cboThietBi.Location = new System.Drawing.Point(779, 76);
            this.cboThietBi.Name = "cboThietBi";
            this.cboThietBi.Size = new System.Drawing.Size(277, 25);
            this.cboThietBi.TabIndex = 31;
            // 
            // DeviceAndRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 642);
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