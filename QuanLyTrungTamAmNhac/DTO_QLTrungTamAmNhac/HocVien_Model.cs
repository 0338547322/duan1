using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class HocVien_Model
    {
        // setting models (nhớ đặt tên giống trong mongodb)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string mahv { get; set; }
        public string tenhv { get; set; }
        public string namsinh { get; set; }
        public string SDT { get; set; }
        public string phai { get; set; }
        public string hinhanh { get; set; }
        public string makhoahoc { get; set; }

        // constructor for querry
        public HocVien_Model() { }
        public HocVien_Model(string maHV) { mahv = maHV; }
        public HocVien_Model(string maHV, string tenHV, string namSinh, string sDT, string Phai, string hinhAnh, string maKH)
        {
            mahv = maHV;
            tenhv = tenHV;
            namsinh = namSinh;
            SDT = sDT;
            phai = Phai;
            hinhanh = hinhAnh;
            makhoahoc = maKH;
        }
    }
}
