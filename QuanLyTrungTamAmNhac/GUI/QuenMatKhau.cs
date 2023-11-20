using BLL_QLTrungTamAmNhac;
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
    public partial class QuenMatKhau : Form
    {
        BLL_NhanVien bll= new BLL_NhanVien();
        public QuenMatKhau()
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
        }
        private void QuenMatKhau_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                string random = bll.GenerateRandomPassword(6);
                var forgot = bll.ForgotPassword(txtEmail.Text, random);
                if (forgot != null)
                {
                    bll.SendEmail(txtEmail.Text, "Substring", "Matkhaumoi cua ban la: " + random);
                    if (MessageBox.Show("SendEmail Sucessfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}
