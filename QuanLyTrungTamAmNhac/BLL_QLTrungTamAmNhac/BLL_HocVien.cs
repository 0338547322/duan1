using DAL_QLTrungTamAmNhac;
using DTO_QLTrungTamAmNhac;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QLTrungTamAmNhac
{
    public class BLL_HocVien
    {
        DAL_HocVien dal_hocvien = new DAL_HocVien();
        public DataTable getallhocvien()
        {
            return dal_hocvien.getallhocvien();
        }

        public string CreateMaHocVien()
        {
            return dal_hocvien.CreateMaHocVien().ToString();
        }

        public string AddHocVien(HocVien_Model HocVien)
        {
            return dal_hocvien.AddHocVien(HocVien);
        }

        public string DeleteHocVien(String mahv)
        {
            return dal_hocvien.DeleteHocVien(mahv);
        }

        public string UpdateHocVien(string Mahv, HocVien_Model HocVien)
        {
            return dal_hocvien.UpdateHocVien(Mahv, HocVien);
        }
        public string CheckValid(string TenHV, string NamSinh, string SDT, string diaChi, string phai, string hinhAnh, string MaKhoaHoc)
        {
            return dal_hocvien.CheckValid(TenHV,NamSinh,SDT,diaChi,phai,hinhAnh,MaKhoaHoc);
        }
    }
}
