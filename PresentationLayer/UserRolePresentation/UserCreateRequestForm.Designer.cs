using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.UserRolePresentation
{
    partial class UserCreateRequestForm
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnXemLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPhong.EnableHeadersVisualStyles = false;
            this.dgvPhong.Location = new System.Drawing.Point(29, 61);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(1024, 520);
            this.dgvPhong.TabIndex = 4;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTaoMoi.FlatAppearance.BorderSize = 0;
            this.btnTaoMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(184)))));
            this.btnTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTaoMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoi.Location = new System.Drawing.Point(29, 587);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(231, 61);
            this.btnTaoMoi.TabIndex = 1;
            this.btnTaoMoi.Text = "Tạo mới yêu cầu";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnXemLai
            // 
            this.btnXemLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnXemLai.FlatAppearance.BorderSize = 0;
            this.btnXemLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnXemLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXemLai.ForeColor = System.Drawing.Color.White;
            this.btnXemLai.Location = new System.Drawing.Point(836, 588);
            this.btnXemLai.Name = "btnXemLai";
            this.btnXemLai.Size = new System.Drawing.Size(217, 60);
            this.btnXemLai.TabIndex = 2;
            this.btnXemLai.Text = "Xem lại các yêu cầu";
            this.btnXemLai.UseVisualStyleBackColor = false;
            this.btnXemLai.Click += new System.EventHandler(this.btnXemLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách các yêu cầu";
            // 
            // UserCreateRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemLai);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.btnTaoMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserCreateRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserCreateRequestForm";
            this.Load += new System.EventHandler(this.UserCreateRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnXemLai;
        private Label label1;
    }
}