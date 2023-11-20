using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class HoaDonChiTiet_Model
    {
        // setting models (nhớ đặt tên giống trong mongodb)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string mahd { get; set; }
        public string makhoahoc { get; set; }
        public string masp { get; set; }
        public string soluong { get; set; }

        // constructor for querry
        public HoaDonChiTiet_Model() { }
        public HoaDonChiTiet_Model(string mahd)
        {
            this.mahd = mahd;
        }
        public HoaDonChiTiet_Model(string mahd, string makhoahoc, string masp, string soluong)
        {
            this.mahd = mahd;
            this.makhoahoc = makhoahoc;
            this.masp = masp;
            this.soluong = soluong;
        }
    }
}
