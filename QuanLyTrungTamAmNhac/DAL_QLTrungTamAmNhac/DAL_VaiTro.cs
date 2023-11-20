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
    public class DAL_VaiTro
    {
        //khai bao cuc bo
        string chuoiKetNoi = "mongodb://127.0.0.1:27017";
        dbcontext dbcontext = new dbcontext("mongodb://127.0.0.1:27017");
        public string CreateMaVaiTro()
        {
            if (dbcontext.VaiTro.CountDocuments(FilterDefinition<VaiTro_Model>.Empty) > 0)
            {
                List<VaiTro_Model> myCodeList = dbcontext.VaiTro
                    .Find(x => x.mavaitro != "").ToList();
                List<int> myCode = myCodeList.Select(x => int.Parse(x.mavaitro.Substring(2))).ToList();
                int myNewCode = myCode.Max() + 1;
                if (myNewCode < 10)
                {
                    return "VT0" + myNewCode;
                }
                return "VT" + myNewCode;
            }
            else
            {
                return "VT01";
            }
        }
        public string AddVaiTro(VaiTro_Model VaiTro)
        {
            try
            {
                dbcontext.VaiTro.InsertOne(VaiTro);
                return "added";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public DataTable getallvaitro()
        {
            var client = new MongoClient(chuoiKetNoi);
            var database = client.GetDatabase("QLTrungTamAmNhac");
            var collection = database.GetCollection<BsonDocument>("VaiTro");
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
    }
}
