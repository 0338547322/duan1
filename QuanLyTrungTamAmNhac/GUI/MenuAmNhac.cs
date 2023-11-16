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
    public partial class MenuAmNhac : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public MenuAmNhac()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    pnTitleBar.BackColor = color;
                    pnlogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnmenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnChinh.Controls.Add(childForm);
            this.pnChinh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MenuAmNhac_Load(object sender, EventArgs e)
        {

        }

        private void btHocVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.FormAmNhac.HocVienAN(), sender);
            label1.Text = btHocVien.Text;
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.FormAmNhac.KhachHangAN(), sender);
            label1.Text = btKhachHang.Text;
        }

        private void btSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.FormAmNhac.SanPhamAN(), sender);
            label1.Text = btSanPham.Text;
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.FormAmNhac.HoaDonAN(), sender);
            label1.Text = btHoaDon.Text;
        }

        private void btKhoaHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.FormAmNhac.KhoaHocAN(), sender);
            label1.Text = btKhoaHoc.Text;
        }

        private void btThanNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.FormAmNhac.ThanNhanAN(), sender);
            label1.Text = btThanNhan.Text;
        }

        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.DoiMatKhau(), sender);
            label1.Text = btDoiMatKhau.Text;
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.FormAmNhac.NhanVienAN(), sender);
            label1.Text = btNhanVien.Text;
        }

        private void btChiNhanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.FormAmNhac.ChiNhanhAN(), sender);
            label1.Text = btChiNhanh.Text;
        }

        private void btVaiTro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.VaiTro(), sender);
            label1.Text = btVaiTro.Text;
        }

        private void btLuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Luong(), sender); 
            label1.Text = btLuong.Text;
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.FormAmNhac.ThongKeAN(), sender);
            label1.Text = btThongKe.Text;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
