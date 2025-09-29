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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.btnTaoMoiPhong = new System.Windows.Forms.Button();
            this.btnXemLai = new System.Windows.Forms.Button();
            this.btnTaoMoiTB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(12, 44);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.Size = new System.Drawing.Size(822, 465);
            this.dgvPhong.TabIndex = 0;
            // 
            // btnTaoMoiPhong
            // 
            this.btnTaoMoiPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoiPhong.Location = new System.Drawing.Point(12, 539);
            this.btnTaoMoiPhong.Name = "btnTaoMoiPhong";
            this.btnTaoMoiPhong.Size = new System.Drawing.Size(231, 61);
            this.btnTaoMoiPhong.TabIndex = 1;
            this.btnTaoMoiPhong.Text = "Yêu cầu bảo trì phòng";
            this.btnTaoMoiPhong.UseVisualStyleBackColor = true;
            this.btnTaoMoiPhong.Click += new System.EventHandler(this.btnTaoMoiPhong_Click);
            // 
            // btnXemLai
            // 
            this.btnXemLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLai.Location = new System.Drawing.Point(617, 539);
            this.btnXemLai.Name = "btnXemLai";
            this.btnXemLai.Size = new System.Drawing.Size(217, 60);
            this.btnXemLai.TabIndex = 2;
            this.btnXemLai.Text = "Xem lại các yêu cầu";
            this.btnXemLai.UseVisualStyleBackColor = true;
            this.btnXemLai.Click += new System.EventHandler(this.btnXemLai_Click);
            // 
            // btnTaoMoiTB
            // 
            this.btnTaoMoiTB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoiTB.Location = new System.Drawing.Point(315, 539);
            this.btnTaoMoiTB.Name = "btnTaoMoiTB";
            this.btnTaoMoiTB.Size = new System.Drawing.Size(231, 61);
            this.btnTaoMoiTB.TabIndex = 3;
            this.btnTaoMoiTB.Text = "Yêu cầu bảo trì thiết bị";
            this.btnTaoMoiTB.UseVisualStyleBackColor = true;
            this.btnTaoMoiTB.Click += new System.EventHandler(this.btnTaoMoiTB_Click);
            // 
            // UserCreateRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 681);
            this.Controls.Add(this.btnXemLai);
            this.Controls.Add(this.btnTaoMoiTB);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.btnTaoMoiPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserCreateRequestForm";
            this.Text = "UserCreateRequestForm";
            this.Load += new System.EventHandler(this.UserCreateRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button btnTaoMoiPhong;
        private System.Windows.Forms.Button btnXemLai;
        private System.Windows.Forms.Button btnTaoMoiTB;
    }
}