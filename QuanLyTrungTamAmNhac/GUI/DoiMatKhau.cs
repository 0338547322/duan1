using BLL_QLTrungTamAmNhac;
using DAL_QLTrungTamAmNhac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DoiMatKhau : Form
    {
        DAL_Nhanvien dal = new DAL_Nhanvien();
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            foreach (Control btns in panel1.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            lbEmail.ForeColor = ThemeColor.SecondaryColor;
            lbMatKhauCu.ForeColor = ThemeColor.SecondaryColor;
            lbMatKhauMoi.ForeColor = ThemeColor.SecondaryColor;
            lbNhapLaiMatKhau.ForeColor = ThemeColor.SecondaryColor;
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.VerticalScroll.Value = e.NewValue;
        }

        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
            {
                var change = dal.ChangePass(txtEmail.Text, txtMatKhauCu.Text, txtMatKhauMoi.Text);
                if (MessageBox.Show("ChangePassword Succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Login login = new Login();
                    login.Show();
                }
            }
        }
    }
}
