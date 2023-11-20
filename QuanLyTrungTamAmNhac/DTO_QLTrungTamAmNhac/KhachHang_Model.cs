using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class KhachHang_Model
    {
        // setting models (nhớ đặt tên giống trong mongodb)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string makhachhang { get; set; }
        public string tenkhachhang { get; set; }
        public string SDT { get; set; }
        public string diachi { get; set; }
        public string email { get; set; }
        public string ghichu { get; set; }
        public string manv { get; set; }

        // constructor for querry
        public KhachHang_Model() { }
        public KhachHang_Model(string manv)
        {
            this.makhachhang = makhachhang;
        }
        public KhachHang_Model(string makhachhang, string tenkhachhang, string SDT, string diachi, string email, string ghichu, string manv)
        {
            this.makhachhang = makhachhang;
            this.tenkhachhang = tenkhachhang;
            this.SDT = SDT;
            this.diachi = diachi;
            this.email = email;
            this.ghichu = ghichu;
            this.manv = manv;
        }
    }
}
