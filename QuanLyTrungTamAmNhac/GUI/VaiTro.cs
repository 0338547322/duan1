using BLL_QLTrungTamAmNhac;
using DAL_QLTrungTamAmNhac;
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

namespace GUI
{
    public partial class VaiTro : Form
    {
        BLL_VaiTro bLL= new BLL_VaiTro();
        public VaiTro()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string mavaitro = bLL.CreateMaVaiTro();
            VaiTro_Model themvaitro = new VaiTro_Model(mavaitro, txtTenVT.Text, cboNhiemVu.Text, cboChuyenMon.Text, txtLuong.Text);
            if (bLL.AddVaiTro(themvaitro) == "added")
            {
                MessageBox.Show("Add Succesfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = bLL.getallvaitro();
            }
        }
    }
}
