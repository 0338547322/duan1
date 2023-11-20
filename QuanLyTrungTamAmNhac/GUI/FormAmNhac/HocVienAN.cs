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
    public partial class HocVienAN : Form
    {
        //khai bao cuc bo
        string takePhai;
        public string SaveEmage;
        public string Emage;
        BLL_HocVien bll_hocvien = new BLL_HocVien();

        //first load
        public HocVienAN()
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
        private void HocVienAN_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadData();
        }


        //method
        private void tatchucnang()
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if ((ctrl is Button))
                {
                    ctrl.Enabled = true;
                }
                if ((ctrl is TextBox || ctrl is DateTime || ctrl is Panel || ctrl is PictureBox || ctrl is RichTextBox))
                {
                    ctrl.Enabled = false;
                }
            }
        }
        private void batchucnang()
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if ((ctrl is Button))
                {
                    ctrl.Enabled = false;
                    btDanhSach.Enabled = true;
                    btThem.Enabled = true;
                }

                if ((ctrl is TextBox || ctrl is DateTime || ctrl is Panel || ctrl is PictureBox || ctrl is RichTextBox))
                {
                    ctrl.Enabled = true;
                }
            }
        }
        private void LoadData()
        {
            dataGridView1.DataSource = bll_hocvien.getallhocvien();
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

        //button controls
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll_hocvien.DeleteHocVien(txtMaHV.Text);
                LoadData();
                batchucnang();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHV.Text == string.Empty)   //Nếu mahv rỗng thì là thêm mới.
            {
                if (rdoNam.Checked == true)
                {
                    HocVien_Model themhocvien = new HocVien_Model(bll_hocvien.CreateMaHocVien(), txtTenHV.Text, dtpNamSinh.Text, txtSDT.Text, rtbDiaChi.Text, "Nam", SaveEmage, txtMaKH.Text);
                    if (bll_hocvien.AddHocVien(themhocvien) == "added")
                    {
                        MessageBox.Show("Add Succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                if (rdoNu.Checked == true)
                {
                    HocVien_Model themhocvien = new HocVien_Model(bll_hocvien.CreateMaHocVien(), txtTenHV.Text, dtpNamSinh.Text, txtSDT.Text, rtbDiaChi.Text, "Nữ", SaveEmage, txtMaKH.Text);
                    if (bll_hocvien.AddHocVien(themhocvien) == "added")
                    {
                        MessageBox.Show("Add Succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }
            else    // ngược lại mahv không rỗng thì là update.
            {
                if (rdoNam.Checked == true)
                {
                    HocVien_Model updatehocvien = new HocVien_Model(txtTenHV.Text, dtpNamSinh.Text, txtSDT.Text, rtbDiaChi.Text, "Nam", SaveEmage, txtMaKH.Text);
                    if (bll_hocvien.UpdateHocVien(txtMaHV.Text, updatehocvien) == "Update")
                    {
                        MessageBox.Show("Update Succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                if (rdoNu.Checked == true)
                {
                    HocVien_Model updatehocvien = new HocVien_Model(txtTenHV.Text, dtpNamSinh.Text, txtSDT.Text, rtbDiaChi.Text, "Nữ", SaveEmage, txtMaKH.Text);
                    if (bll_hocvien.UpdateHocVien(txtMaHV.Text, updatehocvien) == "Update")
                    {
                        MessageBox.Show("Update Succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }
        }

        private void pbHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg, *.gif)|*.jpg;*.png;*.jpeg;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveEmage = openFileDialog.FileName;
                pbHinhAnh.Image = Image.FromFile(SaveEmage);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0 || this.dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell cell = this.dataGridView1.SelectedCells[0];
                DataGridViewRow row = cell.OwningRow;
                this.txtMaHV.Text = row.Cells["mahv"].Value.ToString();
                this.txtTenHV.Text = row.Cells["tenhv"].Value.ToString();
                this.dtpNamSinh.Text = row.Cells["namsinh"].Value.ToString();
                this.txtSDT.Text = row.Cells["SDT"].Value.ToString();
                this.rtbDiaChi.Text = row.Cells["diachi"].Value.ToString();
                this.txtMaKH.Text = row.Cells["makhoahoc"].Value.ToString();
                this.SaveEmage= row.Cells["hinhanh"].Value.ToString();


                checkedphai();
                pbHinhAnh.Image = Image.FromFile(SaveEmage);

                btThem.Enabled = true;
                btXoa.Enabled = true;
                btSua.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
