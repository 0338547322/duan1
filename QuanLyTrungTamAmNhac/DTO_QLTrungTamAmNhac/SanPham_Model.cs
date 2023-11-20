using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class SanPham_Model
    {
        // setting models (nhớ đặt tên giống trong mongodb)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string masp { get; set; }
        public string tensp { get; set; }
        public string thuonghieu { get; set; }
        public string dongianhap { get; set; }
        public string dongiaban { get; set; }
        public string soluong { get; set; }
        public string hinhanh { get; set; }
        public string ghichu { get; set; }
        public string manv { get; set; }
        public string mavaitro { get; set; }
        public string noilamviec { get; set; }

        // constructor for querry
        public SanPham_Model() { }
        public SanPham_Model(string manv)
        {
            this.masp = masp;
        }
        public SanPham_Model(string masp, string tensp, string thuonghieu, string dongianhap, string dongiaban, string soluong, string hinhanh, string ghichu, string manv, string mavaitro, string noilamviec)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.thuonghieu = thuonghieu;
            this.dongianhap = dongianhap;
            this.dongiaban = dongiaban;
            this.soluong = soluong;
            this.hinhanh = hinhanh;
            this.ghichu = ghichu;
            this.manv = manv;
            this.mavaitro = mavaitro;
            this.noilamviec = noilamviec;
        }
    }
}
