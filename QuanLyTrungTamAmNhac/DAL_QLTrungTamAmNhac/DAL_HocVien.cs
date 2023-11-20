using DTO_QLTrungTamAmNhac;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLTrungTamAmNhac
{
    public class DAL_HocVien
    {
        //khai bao cuc bo
        string chuoiKetNoi = "mongodb://127.0.0.1:27017";
        dbcontext dbcontext = new dbcontext("mongodb://127.0.0.1:27017");

        public DataTable getallhocvien()
        {
            var client = new MongoClient(chuoiKetNoi);
            var database = client.GetDatabase("QLTrungTamAmNhac");
            var collection = database.GetCollection<BsonDocument>("HocVien");
            var documents = collection.Find(new BsonDocument()).ToList();
            var dataTable = new DataTable();
            foreach (var field in documents[0].Elements)
            {
                dataTable.Columns.Add(field.Name);
            }
            foreach (var document in documents)
            {
                var row = dataTable.NewRow();
                foreach (var field in document.Elements)
                {
                    row[field.Name] = field.Value.ToString();
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
        public string CreateMaHocVien()
        {
            if (dbcontext.HocVien.CountDocuments(FilterDefinition<HocVien_Model>.Empty) > 0)
            {
                List<HocVien_Model> myCodeList = dbcontext.HocVien
                    .Find(x => x.mahv != "").ToList();
                List<int> myCode = myCodeList.Select(x => int.Parse(x.mahv.Substring(3))).ToList();
                int myNewCode = myCode.Max() + 1;
                if (myNewCode < 10)
                {
                    return "HV000" + myNewCode;
                }
                if (myNewCode < 100)
                {
                    return "HV00" + myNewCode;
                }
                if (myNewCode < 1000)
                {
                    return "HV0" + myNewCode;
                }

                return "HV" + myNewCode;
            }
            else
            {
                return "NV0001";
            }
        }

        public string AddHocVien(HocVien_Model HocVien)
        {
            try
            {
                dbcontext.HocVien.InsertOne(HocVien);
                return "added";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteHocVien(String mahv)
        {
            try
            {
                HocVien_Model HocVien = new HocVien_Model(mahv);
                var filter = Builders<HocVien_Model>.Filter.Eq(x => x.mahv, mahv);
                dbcontext.HocVien.DeleteOne(filter);
                return "Delete";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateHocVien(string Mahv, HocVien_Model HocVien)
        {
            try
            {
                HocVien_Model Update = new HocVien_Model(Mahv);
                var filter = Builders<HocVien_Model>.Filter.Eq(x => x.mahv, Mahv);
                var updateDefinition = Builders<HocVien_Model>.Update
                    .Set(x => x.tenhv, HocVien.tenhv)
                    .Set(x => x.namsinh, HocVien.namsinh)
                    .Set(x => x.SDT, HocVien.SDT)
                    .Set(x => x.diachi, HocVien.diachi)
                    .Set(x => x.phai, HocVien.phai)
                    .Set(x => x.hinhanh, HocVien.hinhanh)
                    .Set(x => x.makhoahoc, HocVien.makhoahoc);

                var updateResult = dbcontext.HocVien.UpdateOne(filter, updateDefinition);

                if (updateResult.ModifiedCount > 0)
                {
                    return "Update";
                }
                else
                {
                    return "Update Fail";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string CheckValid(string TenHV, string NamSinh, string SDT, string diaChi, string phai, string hinhAnh, string MaKhoaHoc)
        {
            if (TenHV == string.Empty || NamSinh == string.Empty || SDT == string.Empty || phai == string.Empty || diaChi == string.Empty || hinhAnh == string.Empty || MaKhoaHoc == string.Empty)
            {
                return "False";
            }
            return "True";
        }
    }
}
