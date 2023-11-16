using DAL_QLTrungTamAmNhac;
using DTO_QLTrungTamAmNhac;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QLTrungTamAmNhac
{
    public class BLL_NhanVien
    {
        //khai bao cuc bo
        DAL_Nhanvien dal= new DAL_Nhanvien();

        //controls
        public DataTable getallnhanvien()
        {
            return dal.getallnhanvien();
        }
        public string CreateMaNV()
        {
            return dal.CreateMaNV();
        }
        public string AddNhanVien(NhanVien_Model nhanvien)
        {
            return dal.AddNhanVien(nhanvien);
        }
        public string CheckValid(string tenNV, string namSinh, string email, string sDT, string diaChi, string hinhAnh, string luong, string phai, string maVT, string noiLamViec)
        {
            return dal.CheckValid(tenNV, namSinh, email, sDT, diaChi, hinhAnh, luong, phai, maVT, noiLamViec);
        }
        public string HashPassword(string password)
        {
            return dal.HashPassword(password);
        }
        public string GenerateRandomPassword(int length)
        {
            return dal.GenerateRandomPassword(length);
        }
        public string SendEmail(string Email, string subject, string body)
        {
            return dal.SendEmail(Email, subject,body);
        }
        public bool IsValidEmail(string email)
        {
            return dal.IsValidEmail(email);
        }
        public string DeleteNhanVien(string manv)
        {
            return dal.DeleteNhanVien(manv);
        }
        public string UpdateNhanVien(string manv, NhanVien_Model nhanvien)
        {
            return dal.UpdateNhanVien(manv, nhanvien);
        }
    }
}
