using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1.UI.FormAnhVan
{
    public partial class HoaDonAV : Form
    {
        public HoaDonAV()
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
            //label2.ForeColor = ThemeColor.SecondaryColor;
            //label2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void HoaDonAV_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
