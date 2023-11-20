using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLTrungTamAmNhac
{
    public class VaiTro_Model
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string mavaitro { get; set; }
        public string tenvaitro { get; set; }
        public string nhiemvu { get; set; }
        public string chuyenmon { get; set; }
        public string luong { get; set; }
        public VaiTro_Model() { }
        public VaiTro_Model(string mavaitro) { }
        public VaiTro_Model(string MaVaiTro, string TenVaiTro, string NhiemVu, string ChuyenMon, string Luong)
        {
            this.mavaitro = MaVaiTro;
            this.tenvaitro= TenVaiTro;
            this.nhiemvu = NhiemVu;
            this.chuyenmon = ChuyenMon;
            this.luong = Luong; 
        }

        public VaiTro_Model(string TenVaiTro, string NhiemVu, string ChuyenMon, string Luong)
        {
            this.tenvaitro = TenVaiTro;
            this.nhiemvu= NhiemVu;
            this.chuyenmon= ChuyenMon;
            this.luong = Luong;
        }
    }
}
