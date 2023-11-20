using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class ChamCong_Model
    {
        // setting models (nhớ đặt tên giống trong mongodb)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string macc { get; set; }
        public string ngay { get; set; }
        public string thang { get; set; }
        public string soca { get; set; }
        public string manv { get; set; }

        // constructor for querry
        public ChamCong_Model() { }
        public ChamCong_Model(string macc)
        {
            this.macc = macc;
        }
        public ChamCong_Model(string macc, string ngay, string thang, string soca, string manv)
        {
            this.macc = macc;
            this.ngay = ngay;
            this.thang = thang;
            this.soca = soca;
            this.manv = manv;
        }
    }
}
