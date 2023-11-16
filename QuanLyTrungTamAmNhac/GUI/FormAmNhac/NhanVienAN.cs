using BLL_QLTrungTamAmNhac;
using DTO_QLTrungTamAmNhac;
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
    public partial class NhanVienAN : Form
    {
        // bien cuc bo
        BLL_NhanVien bll = new BLL_NhanVien();
        string takemanv;
        string imgPath;
        string takePhai;
        string HashPass;
        string RandomPass;
        string subject = "Xin chao thanh vien moi";
        string body = "Day la mat khau cua ban ";


        // load form
        public NhanVienAN()
        {
            InitializeComponent();
        }
        private void NhanVienAN_Load(object sender, EventArgs e)
        {
            LoadTheme();
            loaddata();
        }


        // method
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
        }
        void checkphai()
        {
            if (rdoNam.Checked == true)
            {
                takePhai = "Nam";
            }
            else if (rdoNu.Checked == true)
            {
                takePhai = "Nữ";
            }
        }
        void loaddata()
        {
            dataGridView1.DataSource = bll.getallnhanvien();
        }
        void checkedphai()
        {
            if (takePhai == "Nam")
            {
                rdoNam.Checked = true;
            }
            else if (takePhai == "Nữ")
            {
                rdoNu.Checked = true;
            }
        }



        // button, control
        private void btLuu_Click(object sender, EventArgs e)
        {
            checkphai();
            string checkvalid = bll.CheckValid(txtTenNV.Text, dtpNamSinh.Text, txtEmail.Text, txtSDT.Text, rtbDiaChi.Text, imgPath, txtLuong.Text, takePhai, cboVaiTro.Text, cboNoiLamViec.Text);
            if (checkvalid == "True")
            {
                RandomPass = bll.GenerateRandomPassword(6);
                HashPass = bll.HashPassword(RandomPass);
                takemanv = bll.CreateMaNV();
                NhanVien_Model nhanvien = new NhanVien_Model(takemanv, txtTenNV.Text, dtpNamSinh.Text, txtEmail.Text, txtSDT.Text, rtbDiaChi.Text, HashPass, imgPath, txtLuong.Text, takePhai, cboVaiTro.Text, cboNoiLamViec.Text);
                if (bll.AddNhanVien(nhanvien) == "added")
                {
                    string bodys = body + RandomPass;
                    bll.SendEmail(txtEmail.Text, subject, bodys);
                    MessageBox.Show("Save succesfully!...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Save fail!...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pbHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg, *.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgPath = openFileDialog.FileName;
                pbHinhAnh.Image = Image.FromFile(imgPath);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!bll.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email dose not exist!...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (bll.DeleteNhanVien(takemanv) == "Deleted")
            {
                MessageBox.Show("Delete succesfully!...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
            }
            else if (bll.DeleteNhanVien(takemanv) == "delete fail")
            {
                MessageBox.Show("Delete fail!...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            NhanVien_Model model = new NhanVien_Model(txtTenNV.Text, dtpNamSinh.Text, txtEmail.Text, txtSDT.Text, rtbDiaChi.Text, imgPath, txtLuong.Text, takePhai, cboVaiTro.Text, cboNoiLamViec.Text);
            if (bll.UpdateNhanVien(takemanv, model) == "Updated")
            {
                MessageBox.Show("Updated succesfully!...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
            }
            else if (bll.UpdateNhanVien(takemanv, model) == "Update Fail")
            {
                MessageBox.Show("Delete fail!...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 || this.dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell cell = this.dataGridView1.SelectedCells[0];
                DataGridViewRow row = cell.OwningRow;
                this.takemanv = row.Cells["manv"].Value.ToString();
                this.txtTenNV.Text = row.Cells["tennv"].Value.ToString();
                this.dtpNamSinh.Text = row.Cells["namsinh"].Value.ToString();
                this.txtEmail.Text = row.Cells["email"].Value.ToString();
                this.txtSDT.Text = row.Cells["SDT"].Value.ToString();
                this.rtbDiaChi.Text = row.Cells["diachi"].Value.ToString();
                this.imgPath = row.Cells["hinhanh"].Value.ToString();
                this.txtLuong.Text = row.Cells["luong"].Value.ToString();
                this.takePhai = row.Cells["phai"].Value.ToString();
                this.cboVaiTro.Text = row.Cells["mavaitro"].Value.ToString();
                this.cboNoiLamViec.Text = row.Cells["noilamviec"].Value.ToString();
                checkedphai();
                pbHinhAnh.Image = Image.FromFile(imgPath);
            }
        }
    }
}
