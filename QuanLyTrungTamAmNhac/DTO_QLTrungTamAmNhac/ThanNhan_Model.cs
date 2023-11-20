using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class ThanNhan_Model
    {
        // setting models (nhớ đặt tên giống trong mongodb)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string matn { get; set; }
        public string tentn { get; set; }
        public string SDT { get; set; }
        public string diachi { get; set; }
        public string quanhe { get; set; }
        public string mahv { get; set; }

        // constructor for querry
        public ThanNhan_Model() { }
        public ThanNhan_Model(string manv)
        {
            this.matn = matn;
        }
        public ThanNhan_Model(string matn, string tentn, string SDT, string diachi, string quanhe, string mahv)
        {
            this.matn = matn;
            this.tentn = tentn;
            this.SDT = SDT;
            this.diachi = diachi;
            this.quanhe = quanhe;
            this.mahv = mahv;
        }
    }
}
