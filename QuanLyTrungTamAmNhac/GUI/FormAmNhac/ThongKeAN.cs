using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FormAmNhac
{
    public partial class ThongKeAN : Form
    {
        public ThongKeAN()
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
            lbNhanSu.ForeColor = ThemeColor.SecondaryColor;
            lbHocVien.ForeColor = ThemeColor.SecondaryColor;
            lbKhoaHoc.ForeColor = ThemeColor.SecondaryColor;
            lbSanPham.ForeColor = ThemeColor.SecondaryColor;
            lbHoaDon.ForeColor = ThemeColor.SecondaryColor;
            lbThanNhan.ForeColor = ThemeColor.SecondaryColor;
            lbChiNhanh.ForeColor = ThemeColor.SecondaryColor;
            lbKhachHang.ForeColor = ThemeColor.SecondaryColor;
            lbDoanhThu.ForeColor = ThemeColor.SecondaryColor;
            lbChiPhi.ForeColor = ThemeColor.SecondaryColor;
        }
        private void ThongKeAN_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void lbThanNhan_Click(object sender, EventArgs e)
        {

        }
    }
}
