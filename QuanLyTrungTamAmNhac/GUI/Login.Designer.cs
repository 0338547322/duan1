namespace GUI
{
    partial class Login
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
            panel1 = new Panel();
            btThoat = new Button();
            btDangNhap = new Button();
            rdoNhoMatKhau = new RadioButton();
            cboChon = new ComboBox();
            lbChoose = new Label();
            txtMatKhau = new TextBox();
            lbMatKhau = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btThoat);
            panel1.Controls.Add(btDangNhap);
            panel1.Controls.Add(rdoNhoMatKhau);
            panel1.Controls.Add(cboChon);
            panel1.Controls.Add(lbChoose);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(lbMatKhau);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lbEmail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 450);
            panel1.TabIndex = 1;
            // 
            // btThoat
            // 
            btThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btThoat.Location = new Point(125, 290);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(300, 44);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btDangNhap
            // 
            btDangNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btDangNhap.Location = new Point(125, 240);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(300, 44);
            btDangNhap.TabIndex = 8;
            btDangNhap.Text = "Đăng Nhập";
            btDangNhap.UseVisualStyleBackColor = true;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // rdoNhoMatKhau
            // 
            rdoNhoMatKhau.AutoSize = true;
            rdoNhoMatKhau.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdoNhoMatKhau.Location = new Point(125, 210);
            rdoNhoMatKhau.Name = "rdoNhoMatKhau";
            rdoNhoMatKhau.Size = new Size(182, 24);
            rdoNhoMatKhau.TabIndex = 7;
            rdoNhoMatKhau.TabStop = true;
            rdoNhoMatKhau.Text = "Ghi Nhớ Mật Khẩu";
            rdoNhoMatKhau.UseVisualStyleBackColor = true;
            // 
            // cboChon
            // 
            cboChon.FormattingEnabled = true;
            cboChon.Location = new Point(125, 176);
            cboChon.Name = "cboChon";
            cboChon.Size = new Size(300, 28);
            cboChon.TabIndex = 6;
            // 
            // lbChoose
            // 
            lbChoose.AutoSize = true;
            lbChoose.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbChoose.Location = new Point(125, 151);
            lbChoose.Name = "lbChoose";
            lbChoose.Size = new Size(115, 22);
            lbChoose.TabIndex = 5;
            lbChoose.Text = "Chuyên Môn";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(125, 111);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(300, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbMatKhau.Location = new Point(125, 86);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(142, 22);
            lbMatKhau.TabIndex = 3;
            lbMatKhau.Text = "Nhập Mật Khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.Location = new Point(125, 22);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(107, 22);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Nhập Email";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btThoat;
        private Button btDangNhap;
        private RadioButton rdoNhoMatKhau;
        private ComboBox cboChon;
        private Label lbChoose;
        private TextBox txtMatKhau;
        private Label lbMatKhau;
        private TextBox txtEmail;
        private Label lbEmail;
    }
}