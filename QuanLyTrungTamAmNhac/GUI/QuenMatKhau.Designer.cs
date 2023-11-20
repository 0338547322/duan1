namespace GUI
{
    partial class QuenMatKhau
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
            btLayLaiMatKhau = new Button();
            txtEmail = new TextBox();
            lbEmail = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btThoat);
            panel1.Controls.Add(btLayLaiMatKhau);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lbEmail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 285);
            panel1.TabIndex = 2;
            // 
            // btThoat
            // 
            btThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btThoat.Location = new Point(122, 186);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(313, 44);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btLayLaiMatKhau
            // 
            btLayLaiMatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btLayLaiMatKhau.Location = new Point(122, 118);
            btLayLaiMatKhau.Name = "btLayLaiMatKhau";
            btLayLaiMatKhau.Size = new Size(313, 44);
            btLayLaiMatKhau.TabIndex = 8;
            btLayLaiMatKhau.Text = "Tạo lại Mật Khẩu";
            btLayLaiMatKhau.UseVisualStyleBackColor = true;
            btLayLaiMatKhau.Click += btLayLaiMatKhau_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 64);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(313, 27);
            txtEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.Location = new Point(122, 39);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(107, 22);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Nhập Email";
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 285);
            Controls.Add(panel1);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            Load += QuenMatKhau_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btThoat;
        private Button btLayLaiMatKhau;
        private TextBox txtEmail;
        private Label lbEmail;
    }
}