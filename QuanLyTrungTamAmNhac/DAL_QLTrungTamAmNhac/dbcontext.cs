using DTO_QLTrungTamAmNhac;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DAL_QLTrungTamAmNhac
{
    public class dbcontext : MongoClient
    {
        //connectionString
        public const string connectionString = "mongodb://127.0.0.1:27017";

        //connect models to collention from mongodb
        public IMongoCollection<NhanVien_Model> NhanVien { get; set; }
        public IMongoCollection<HocVien_Model> hocvien { get; set; }

        //connect to mongodb
        public dbcontext(string connectionString) : base(connectionString)
        {
            var database = GetDatabase("QLTrungTamAmNhac");
            NhanVien = database.GetCollection<NhanVien_Model>("NhanVien");
            hocvien = database.GetCollection<HocVien_Model>("HocVien");
        }
    }
}
