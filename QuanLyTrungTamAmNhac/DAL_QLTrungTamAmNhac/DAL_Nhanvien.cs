using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Data;
using DTO_QLTrungTamAmNhac;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using System.Collections.Specialized;

namespace DAL_QLTrungTamAmNhac
{
    public class DAL_Nhanvien
    {
        //khai bao cuc bo
        string chuoiKetNoi = "mongodb://127.0.0.1:27017";
        dbcontext dbcontext = new dbcontext("mongodb://127.0.0.1:27017");

        //controls
        public DataTable getallnhanvien()
        {
            var client = new MongoClient(chuoiKetNoi);
            var database = client.GetDatabase("QLTrungTamAmNhac");
            var collection = database.GetCollection<BsonDocument>("NhanVien");
            var documents = collection.Find(new BsonDocument()).ToList();
            /*var documents = dbcontext.NhanVien.Find(new BsonDocument()).ToList();*/
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
        public string CreateMaNV()
        {
            if (dbcontext.NhanVien.CountDocuments(FilterDefinition<NhanVien_Model>.Empty) > 0)
            {
                List<NhanVien_Model> myCodeList = dbcontext.NhanVien
                    .Find(x => x.manv !="" ).ToList();
                List<int> myCode = myCodeList.Select(x => int.Parse(x.manv.Substring(3))).ToList();
                int myNewCode = myCode.Max() + 1;   
                if (myNewCode < 10)
                {
                    return "NV00" + myNewCode;
                }
                if (myNewCode > 99)
                {
                    return "NV" + myNewCode;
                }
                return "NV0" + myNewCode;
            }
            else
            {
                return "NV001";
            }
        }
        public string AddNhanVien(NhanVien_Model nhanVien)
        {
            try
            {
                dbcontext.NhanVien.InsertOne(nhanVien);
                return "added";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string CheckValid(string tenNV, string namSinh, string email, string sDT, string diaChi, string hinhAnh, string luong, string phai, string maVT, string noiLamViec)
        {
            if (tenNV ==string.Empty || namSinh == string.Empty || email == string.Empty || sDT == string.Empty || diaChi == string.Empty || hinhAnh == null || luong == string.Empty || phai == null || maVT == string.Empty || noiLamViec == string.Empty)
            {
                return "False";
            }return "True";
        }
        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
        public string GenerateRandomPassword(int length)
        {
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            using (var rng = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[length];
                rng.GetBytes(randomBytes);

                var chars = randomBytes.Select(b => allowedChars[b % allowedChars.Length]);
                return new string(chars.ToArray());
            }
        }
        public string SendEmail(string Email, string subject, string body)  
        {
            // Cấu hình thông tin người gửi email
            string senderEmail = "tranngoch509@gmail.com";
            string password = "cdznibmulzausxrg";

            // Tạo đối tượng MailMessage
            MailMessage mail = new MailMessage(senderEmail, Email, subject, body);

            // Cấu hình thông tin SMTP
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(senderEmail, password);

            try
            {
                // Gửi email
                client.Send(mail);
                return "True";
            }
            catch (Exception ex)
            {
                return "False";
            }
        }
        public bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Kiểm tra so khớp với mẫu email
            return Regex.IsMatch(email, pattern);
        }
        public string DeleteNhanVien(string manv)
        {
            try
            {
                var filter = Builders<NhanVien_Model>.Filter.Eq(x => x.manv, manv);
                var result = dbcontext.NhanVien.DeleteOne(filter);

                if (result.DeletedCount > 0)
                {
                    return "Deleted";
                }
                else
                {
                    return "delete fail";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateNhanVien(string manv, NhanVien_Model nhanvien)
        {
            try
            {
                var filter = Builders<NhanVien_Model>.Filter.Eq(x => x.manv, manv);
                var update = Builders<NhanVien_Model>.Update
                    .Set(x => x.tennv, nhanvien.tennv)
                    .Set(x => x.namsinh, nhanvien.namsinh)
                    .Set(x => x.email, nhanvien.email)
                    .Set(x => x.SDT, nhanvien.SDT)
                    .Set(x => x.diachi, nhanvien.diachi)
                    .Set(x => x.hinhanh, nhanvien.hinhanh)
                    .Set(x => x.luong, nhanvien.luong)
                    .Set(x => x.phai, nhanvien.phai)
                    .Set(x => x.mavaitro, nhanvien.mavaitro)
                    .Set(x => x.noilamviec, nhanvien.noilamviec);
                var collection = dbcontext.NhanVien.UpdateOne(filter, update);
                if (collection.ModifiedCount > 0)
                {
                    return "Updated";
                }
                else
                {
                    return "Update Fail";
                }
            }catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
