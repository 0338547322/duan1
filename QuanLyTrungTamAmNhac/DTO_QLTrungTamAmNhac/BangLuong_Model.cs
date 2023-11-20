using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class BangLuong_Model
    {
        // setting models (nhớ đặt tên giống trong mongodb)
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string maluong { get; set; }
        public string tongsoca { get; set; }
        public string luongtheoca { get; set; }
        public string tongluong { get; set; }
        public string thang { get; set; }
        public string manv { get; set; }
        public string macc { get; set; }

        // constructor for querry
        public BangLuong_Model() { }
        public BangLuong_Model(string maluong)
        {
            this.maluong = maluong;
        }
        public BangLuong_Model(string maluong, string tongsoca, string luongtheoca, string tongluong, string thang, string manv, string macc)
        {
            this.maluong = maluong;
            this.tongsoca = tongsoca;
            this.luongtheoca = luongtheoca;
            this.tongluong = tongluong;
            this.thang = thang;
            this.manv = manv;
            this.macc = macc;
        }
    }
}
