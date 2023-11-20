using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class KhoaHoc_Model
    {
        // setting models (nhớ đặt tên giống trong mongodb)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string makhoahoc { get; set; }
        public string tenkhoahoc { get; set; }
        public string sobuoihoc { get; set; }
        public string hocphi { get; set; }
        public string manv { get; set; }

        // constructor for querry
        public KhoaHoc_Model() { }
        public KhoaHoc_Model(string manv)
        {
            this.makhoahoc = makhoahoc;
        }
        public KhoaHoc_Model(string makhoahoc, string tenkhoahoc, string sobuoihoc, string hocphi, string manv)
        {
            this.makhoahoc = makhoahoc;
            this.tenkhoahoc = tenkhoahoc;
            this.sobuoihoc = sobuoihoc;
            this.hocphi = hocphi;
            this.manv = manv;
        }
    }
}
