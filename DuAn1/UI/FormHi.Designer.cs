namespace DuAn1.UI
{
    partial class FormHi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHi));
            this.pnmenu = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btDoiMatKhau = new System.Windows.Forms.Button();
            this.btQuenMatKhau = new System.Windows.Forms.Button();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.pnlogo = new System.Windows.Forms.Panel();
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnchinh = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnmenu.SuspendLayout();
            this.pnTitleBar.SuspendLayout();
            this.pnchinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnmenu
            // 
            this.pnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnmenu.Controls.Add(this.btThoat);
            this.pnmenu.Controls.Add(this.btDoiMatKhau);
            this.pnmenu.Controls.Add(this.btQuenMatKhau);
            this.pnmenu.Controls.Add(this.btDangNhap);
            this.pnmenu.Controls.Add(this.pnlogo);
            this.pnmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnmenu.Location = new System.Drawing.Point(0, 0);
            this.pnmenu.Name = "pnmenu";
            this.pnmenu.Size = new System.Drawing.Size(220, 551);
            this.pnmenu.TabIndex = 3;
            // 
            // btThoat
            // 
            this.btThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(0, 260);
            this.btThoat.Name = "btThoat";
            this.btThoat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btThoat.Size = new System.Drawing.Size(220, 60);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = " Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDoiMatKhau
            // 
            this.btDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDoiMatKhau.ForeColor = System.Drawing.Color.Gainsboro;
            this.btDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btDoiMatKhau.Image")));
            this.btDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDoiMatKhau.Location = new System.Drawing.Point(0, 200);
            this.btDoiMatKhau.Name = "btDoiMatKhau";
            this.btDoiMatKhau.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btDoiMatKhau.Size = new System.Drawing.Size(220, 60);
            this.btDoiMatKhau.TabIndex = 10;
            this.btDoiMatKhau.Text = " Đổi Mật Khẩu";
            this.btDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDoiMatKhau.UseVisualStyleBackColor = true;
            this.btDoiMatKhau.Click += new System.EventHandler(this.btDoiMatKhau_Click);
            // 
            // btQuenMatKhau
            // 
            this.btQuenMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQuenMatKhau.FlatAppearance.BorderSize = 0;
            this.btQuenMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuenMatKhau.ForeColor = System.Drawing.Color.Gainsboro;
            this.btQuenMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btQuenMatKhau.Image")));
            this.btQuenMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuenMatKhau.Location = new System.Drawing.Point(0, 140);
            this.btQuenMatKhau.Name = "btQuenMatKhau";
            this.btQuenMatKhau.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btQuenMatKhau.Size = new System.Drawing.Size(220, 60);
            this.btQuenMatKhau.TabIndex = 6;
            this.btQuenMatKhau.Text = " Quên Mật Khẩu";
            this.btQuenMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuenMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuenMatKhau.UseVisualStyleBackColor = true;
            this.btQuenMatKhau.Click += new System.EventHandler(this.btQuenMatKhau_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDangNhap.FlatAppearance.BorderSize = 0;
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDangNhap.ForeColor = System.Drawing.Color.Gainsboro;
            this.btDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btDangNhap.Image")));
            this.btDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDangNhap.Location = new System.Drawing.Point(0, 80);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btDangNhap.Size = new System.Drawing.Size(220, 60);
            this.btDangNhap.TabIndex = 1;
            this.btDangNhap.Text = " Đăng Nhập";
            this.btDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // pnlogo
            // 
            this.pnlogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlogo.Location = new System.Drawing.Point(0, 0);
            this.pnlogo.Name = "pnlogo";
            this.pnlogo.Size = new System.Drawing.Size(220, 80);
            this.pnlogo.TabIndex = 0;
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnTitleBar.Controls.Add(this.label1);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(220, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(546, 80);
            this.pnTitleBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stars Light";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnchinh
            // 
            this.pnchinh.BackColor = System.Drawing.Color.White;
            this.pnchinh.Controls.Add(this.label2);
            this.pnchinh.Controls.Add(this.pictureBox1);
            this.pnchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnchinh.Location = new System.Drawing.Point(220, 80);
            this.pnchinh.Name = "pnchinh";
            this.pnchinh.Size = new System.Drawing.Size(546, 471);
            this.pnchinh.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phần Mềm Trung Tâm Âm Nhạc";
            // 
            // FormHi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 551);
            this.Controls.Add(this.pnchinh);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.pnmenu);
            this.Name = "FormHi";
            this.Text = "FormHi";
            this.Load += new System.EventHandler(this.FormHi_Load);
            this.pnmenu.ResumeLayout(false);
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            this.pnchinh.ResumeLayout(false);
            this.pnchinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnmenu;
        private Button btDoiMatKhau;
        private Button btQuenMatKhau;
        private Button btDangNhap;
        private Panel pnlogo;
        private Panel pnTitleBar;
        private Label label1;
        private Panel pnchinh;
        private Button btThoat;
        private Label label2;
        private PictureBox pictureBox1;
    }
}