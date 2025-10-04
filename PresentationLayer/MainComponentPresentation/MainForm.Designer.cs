namespace PresentationLayer
{
    partial class MainForm
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
        //    this.paneNav = new System.Windows.Forms.Panel();
        //    this.btnTYCBT = new System.Windows.Forms.Button();
        //    this.btnDB = new System.Windows.Forms.Button();
        //    this.btnLogout = new System.Windows.Forms.Button();
        //    this.btnTK = new System.Windows.Forms.Button();
        //    this.btnBT = new System.Windows.Forms.Button();
        //    this.btnThietBi = new System.Windows.Forms.Button();
        //    this.btnPhong = new System.Windows.Forms.Button();
        //    this.panelMain = new System.Windows.Forms.Panel();
        //    this.paneNav.SuspendLayout();
        //    this.SuspendLayout();
        //    // 
        //    // paneNav
        //    // 
        //    this.paneNav.BackColor = System.Drawing.Color.DarkBlue;
        //    this.paneNav.Controls.Add(this.btnTYCBT);
        //    this.paneNav.Controls.Add(this.btnDB);
        //    this.paneNav.Controls.Add(this.btnLogout);
        //    this.paneNav.Controls.Add(this.btnTK);
        //    this.paneNav.Controls.Add(this.btnBT);
        //    this.paneNav.Controls.Add(this.btnThietBi);
        //    this.paneNav.Controls.Add(this.btnPhong);
        //    this.paneNav.Dock = System.Windows.Forms.DockStyle.Left;
        //    this.paneNav.Location = new System.Drawing.Point(0, 0);
        //    this.paneNav.Name = "paneNav";
        //    this.paneNav.Size = new System.Drawing.Size(173, 681);
        //    this.paneNav.TabIndex = 2;
        //    // 
        //    // btnTYCBT
        //    // 
        //    this.btnTYCBT.BackColor = System.Drawing.Color.DarkBlue;
        //    this.btnTYCBT.FlatAppearance.BorderSize = 0;
        //    this.btnTYCBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.btnTYCBT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnTYCBT.ForeColor = System.Drawing.Color.White;
        //    this.btnTYCBT.Location = new System.Drawing.Point(3, 138);
        //    this.btnTYCBT.Name = "btnTYCBT";
        //    this.btnTYCBT.Size = new System.Drawing.Size(170, 92);
        //    this.btnTYCBT.TabIndex = 6;
        //    this.btnTYCBT.Text = "Yêu cầu bảo trì";
        //    this.btnTYCBT.UseVisualStyleBackColor = false;
        //    this.btnTYCBT.Click += new System.EventHandler(this.btnTYCBT_Click);
        //    // 
        //    // btnDB
        //    // 
        //    this.btnDB.BackColor = System.Drawing.Color.DarkBlue;
        //    this.btnDB.FlatAppearance.BorderSize = 0;
        //    this.btnDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.btnDB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnDB.ForeColor = System.Drawing.Color.White;
        //    this.btnDB.Location = new System.Drawing.Point(0, 138);
        //    this.btnDB.Name = "btnDB";
        //    this.btnDB.Size = new System.Drawing.Size(170, 92);
        //    this.btnDB.TabIndex = 5;
        //    this.btnDB.Text = "Dashboard";
        //    this.btnDB.UseVisualStyleBackColor = false;
        //    this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
        //    // 
        //    // btnLogout
        //    // 
        //    this.btnLogout.BackColor = System.Drawing.Color.DarkBlue;
        //    this.btnLogout.FlatAppearance.BorderSize = 0;
        //    this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnLogout.ForeColor = System.Drawing.Color.White;
        //    this.btnLogout.Location = new System.Drawing.Point(0, 628);
        //    this.btnLogout.Name = "btnLogout";
        //    this.btnLogout.Size = new System.Drawing.Size(170, 53);
        //    this.btnLogout.TabIndex = 4;
        //    this.btnLogout.Text = "> Đăng xuất";
        //    this.btnLogout.UseVisualStyleBackColor = false;
        //    this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
        //    // 
        //    // btnTK
        //    // 
        //    this.btnTK.BackColor = System.Drawing.Color.DarkBlue;
        //    this.btnTK.FlatAppearance.BorderSize = 0;
        //    this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.btnTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnTK.ForeColor = System.Drawing.Color.White;
        //    this.btnTK.Location = new System.Drawing.Point(-3, 236);
        //    this.btnTK.Name = "btnTK";
        //    this.btnTK.Size = new System.Drawing.Size(173, 92);
        //    this.btnTK.TabIndex = 4;
        //    this.btnTK.Text = "Tài khoản";
        //    this.btnTK.UseVisualStyleBackColor = false;
        //    this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
        //    // 
        //    // btnBT
        //    // 
        //    this.btnBT.BackColor = System.Drawing.Color.DarkBlue;
        //    this.btnBT.FlatAppearance.BorderSize = 0;
        //    this.btnBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.btnBT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnBT.ForeColor = System.Drawing.Color.White;
        //    this.btnBT.Location = new System.Drawing.Point(0, 530);
        //    this.btnBT.Name = "btnBT";
        //    this.btnBT.Size = new System.Drawing.Size(170, 92);
        //    this.btnBT.TabIndex = 3;
        //    this.btnBT.Text = "Bảo trì";
        //    this.btnBT.UseVisualStyleBackColor = false;
        //    this.btnBT.Click += new System.EventHandler(this.btnBT_Click);
        //    // 
        //    // btnThietBi
        //    // 
        //    this.btnThietBi.BackColor = System.Drawing.Color.DarkBlue;
        //    this.btnThietBi.FlatAppearance.BorderSize = 0;
        //    this.btnThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.btnThietBi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnThietBi.ForeColor = System.Drawing.Color.White;
        //    this.btnThietBi.Location = new System.Drawing.Point(-3, 432);
        //    this.btnThietBi.Name = "btnThietBi";
        //    this.btnThietBi.Size = new System.Drawing.Size(173, 92);
        //    this.btnThietBi.TabIndex = 2;
        //    this.btnThietBi.Text = "Thiết bị";
        //    this.btnThietBi.UseVisualStyleBackColor = false;
        //    this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
        //    // 
        //    // btnPhong
        //    // 
        //    this.btnPhong.BackColor = System.Drawing.Color.DarkBlue;
        //    this.btnPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
        //    this.btnPhong.FlatAppearance.BorderSize = 0;
        //    this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //    this.btnPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.btnPhong.ForeColor = System.Drawing.Color.White;
        //    this.btnPhong.Location = new System.Drawing.Point(-3, 334);
        //    this.btnPhong.Name = "btnPhong";
        //    this.btnPhong.Size = new System.Drawing.Size(173, 92);
        //    this.btnPhong.TabIndex = 1;
        //    this.btnPhong.Text = "Phòng";
        //    this.btnPhong.UseVisualStyleBackColor = false;
        //    this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
        //    // 
        //    // panelMain
        //    // 
        //    this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.panelMain.Location = new System.Drawing.Point(173, 0);
        //    this.panelMain.Name = "panelMain";
        //    this.panelMain.Size = new System.Drawing.Size(1091, 681);
        //    this.panelMain.TabIndex = 3;
        //    // 
        //    // MainForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(1264, 681);
        //    this.Controls.Add(this.panelMain);
        //    this.Controls.Add(this.paneNav);
        //    this.Margin = new System.Windows.Forms.Padding(2);
        //    this.Name = "MainForm";
        //    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        //    this.Text = "Quản lý thư viện";
        //    this.Load += new System.EventHandler(this.MainForm_Load);
        //    this.paneNav.ResumeLayout(false);
        //    this.ResumeLayout(false);

        //}
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.paneNav = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTYCBT = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnBT = new System.Windows.Forms.Button();
            this.btnThietBi = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.paneNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneNav
            // 
            this.paneNav.BackColor = System.Drawing.Color.DarkBlue;
            this.paneNav.Controls.Add(this.pictureBox1);
            this.paneNav.Controls.Add(this.btnTYCBT);
            this.paneNav.Controls.Add(this.btnDB);
            this.paneNav.Controls.Add(this.btnLogout);
            this.paneNav.Controls.Add(this.btnTK);
            this.paneNav.Controls.Add(this.btnBT);
            this.paneNav.Controls.Add(this.btnThietBi);
            this.paneNav.Controls.Add(this.btnPhong);
            this.paneNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneNav.Location = new System.Drawing.Point(0, 0);
            this.paneNav.Name = "paneNav";
            this.paneNav.Size = new System.Drawing.Size(180, 681);
            this.paneNav.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTYCBT
            // 
            this.btnTYCBT.BackColor = System.Drawing.Color.Transparent;
            this.btnTYCBT.FlatAppearance.BorderSize = 0;
            this.btnTYCBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTYCBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTYCBT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTYCBT.ForeColor = System.Drawing.Color.White;
            this.btnTYCBT.Location = new System.Drawing.Point(0, 351);
            this.btnTYCBT.Name = "btnTYCBT";
            this.btnTYCBT.Size = new System.Drawing.Size(180, 70);
            this.btnTYCBT.TabIndex = 6;
            this.btnTYCBT.Text = "📝 Yêu cầu bảo trì";
            this.btnTYCBT.UseVisualStyleBackColor = false;
            this.btnTYCBT.Click += new System.EventHandler(this.btnTYCBT_Click);
            // 
            // btnDB
            // 
            this.btnDB.BackColor = System.Drawing.Color.Transparent;
            this.btnDB.FlatAppearance.BorderSize = 0;
            this.btnDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDB.ForeColor = System.Drawing.Color.White;
            this.btnDB.Location = new System.Drawing.Point(0, 201);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(180, 70);
            this.btnDB.TabIndex = 5;
            this.btnDB.Text = "📊 Dashboard";
            this.btnDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDB.UseVisualStyleBackColor = false;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 628);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 53);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "👉 Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Transparent;
            this.btnTK.FlatAppearance.BorderSize = 0;
            this.btnTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(0, 276);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(180, 70);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "👤 Tài khoản";
            this.btnTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnBT
            // 
            this.btnBT.BackColor = System.Drawing.Color.Transparent;
            this.btnBT.FlatAppearance.BorderSize = 0;
            this.btnBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBT.ForeColor = System.Drawing.Color.White;
            this.btnBT.Location = new System.Drawing.Point(0, 503);
            this.btnBT.Name = "btnBT";
            this.btnBT.Size = new System.Drawing.Size(180, 70);
            this.btnBT.TabIndex = 3;
            this.btnBT.Text = "🛠 Bảo trì";
            this.btnBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBT.UseVisualStyleBackColor = false;
            this.btnBT.Click += new System.EventHandler(this.btnBT_Click);
            // 
            // btnThietBi
            // 
            this.btnThietBi.BackColor = System.Drawing.Color.Transparent;
            this.btnThietBi.FlatAppearance.BorderSize = 0;
            this.btnThietBi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietBi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietBi.ForeColor = System.Drawing.Color.White;
            this.btnThietBi.Location = new System.Drawing.Point(0, 427);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(180, 70);
            this.btnThietBi.TabIndex = 2;
            this.btnThietBi.Text = "💻 Thiết bị";
            this.btnThietBi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThietBi.UseVisualStyleBackColor = false;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.Color.White;
            this.btnPhong.Location = new System.Drawing.Point(0, 351);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(180, 70);
            this.btnPhong.TabIndex = 1;
            this.btnPhong.Text = "🏠 Phòng";
            this.btnPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(180, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1084, 681);
            this.panelMain.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.paneNav);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cơ sở vật chất thư viện";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.paneNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel paneNav;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnBT;
        private System.Windows.Forms.Button btnThietBi;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnTYCBT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

