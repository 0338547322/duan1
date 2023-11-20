using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class HoaDon_Model
    {
        // setting models (nhớ đặt tên giống trong mongodb)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string mahd { get; set; }
        public string trangthai { get; set; }
        public string ngaylaphoadon { get; set; }
        public string ngaynhanhang { get; set; }
        public string tongtien { get; set; }
        public string nguoilaphoadon { get; set; }
        public string makhachhang { get; set; }

        // constructor for querry
        public HoaDon_Model() { }
        public HoaDon_Model(string mahd)
        {
            this.mahd = mahd;
        }
        public HoaDon_Model(string mahd, string trangthai, string ngaylaphoadon, string ngaynhanhang, string tongtien, string nguoilaphoadon, string makhachhang)
        {
            this.mahd = mahd;
            this.trangthai = trangthai;
            this.ngaylaphoadon = ngaylaphoadon;
            this.ngaynhanhang = ngaynhanhang;
            this.nguoilaphoadon = nguoilaphoadon;
            this.makhachhang = makhachhang;
        }
    }
}
