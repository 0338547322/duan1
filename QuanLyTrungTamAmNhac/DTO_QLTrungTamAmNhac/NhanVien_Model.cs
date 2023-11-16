using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class NhanVien_Model
    {
        // setting models (nhớ đặt tên giống trong mongodb)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string manv { get; set; }
        public string tennv { get; set; }
        public string namsinh { get; set; }
        public string email { get; set; }
        public string SDT { get; set; }
        public string diachi { get; set; }
        public string matkhau { get; set; }
        public string hinhanh { get; set; }
        public string luong { get; set; }
        public string phai { get; set; }
        public string mavaitro { get; set; }
        public string noilamviec { get; set; }

        // constructor for querry
        public NhanVien_Model() { }
        public NhanVien_Model(string manv)
        {
            this.manv = manv;
        }
        public NhanVien_Model(string maNV, string tenNV,string namSinh, string email, string sDT, string diaChi, string matKhau, string hinhAnh, string luong, string phai, string maVT, string noiLamViec)
        {
            this.manv = maNV;
            this.tennv = tenNV;
            this.namsinh=namSinh;
            this.email = email;
            this.SDT = sDT;
            this.diachi = diaChi;
            this.matkhau = matKhau;
            this.hinhanh = hinhAnh;
            this.luong = luong;
            this.phai = phai;
            this.mavaitro = maVT;
            this.noilamviec = noiLamViec;
        }
        public NhanVien_Model(string tenNV, string namSinh, string email, string sDT, string diaChi, string hinhAnh, string luong, string phai, string maVT, string noiLamViec)
        {
            this.tennv = tenNV;
            this.namsinh = namSinh;
            this.email = email;
            this.SDT = sDT;
            this.diachi = diaChi;
            this.hinhanh = hinhAnh;
            this.luong = luong;
            this.phai = phai;
            this.mavaitro = maVT;
            this.noilamviec = noiLamViec;
        }
    }
}
