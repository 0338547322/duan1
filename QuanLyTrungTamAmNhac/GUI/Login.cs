using BLL_QLTrungTamAmNhac;
using DAL_QLTrungTamAmNhac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        BLL_NhanVien bllnv = new BLL_NhanVien();

        public Login()
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
            lbMatKhau.ForeColor = ThemeColor.SecondaryColor;
            lbChoose.ForeColor = ThemeColor.SecondaryColor;
            rdoNhoMatKhau.ForeColor = ThemeColor.SecondaryColor;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            LoadTheme();
            cboChon.Items.Add("Âm nhạc");
            cboChon.Items.Add("Tiếng Anh");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string hash = bllnv.HashPassword(txtMatKhau.Text);
            if (bllnv.checklogin(txtEmail.Text, hash) =="Pass")
            {
                if (cboChon.Text == "Âm nhạc")
                {
                    MenuAmNhac menu = new MenuAmNhac();
                    menu.receiEmail=txtEmail.Text;
                    menu.Show();
                }else if(cboChon.Text=="Tiếng Anh")
                {
                    MenuAnhVan menu2 = new MenuAnhVan();
                    menu2.Show();
                }
            }
            else
            {
                MessageBox.Show("sai j do roi", "canh bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
