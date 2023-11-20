using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class ChiNhanh_Model
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string machinhanh { get; set; }
        public string diachi { get; set; }
        public string SDT { get; set; }
        public string LinhVuc { get; set; }
        public ChiNhanh_Model() { }
        public ChiNhanh_Model(string maChiNhanh) { machinhanh = maChiNhanh; }




        public ChiNhanh_Model(string diaChi, string sdt, string linhvuc)
        {

            diachi = diaChi;
            SDT = sdt;
            LinhVuc = linhvuc;
        }

        public ChiNhanh_Model(string maChiNhanh, string diaChi, string sdt, string linhvuc)
        {
            machinhanh = maChiNhanh;
            diachi = diaChi;
            SDT = sdt;
            LinhVuc = linhvuc;
        }
    }
}

