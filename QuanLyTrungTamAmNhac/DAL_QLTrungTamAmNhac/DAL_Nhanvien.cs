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
        public List<string> GetVaiTro()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("QLTrungTamAmNhac");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("VaiTro");

            var vaiTroList = collection.Find(new BsonDocument()).ToList();

            List<string> vaiTroNames = new List<string>();
            foreach (var vaiTro in vaiTroList)
            {
                vaiTroNames.Add(vaiTro["tenvaitro"].AsString);
            }

            return vaiTroNames;
        }
        public List<string> GetChiNhanh()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("QLTrungTamAmNhac");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("ChiNhanh");

            var vaiTroList = collection.Find(new BsonDocument()).ToList();

            List<string> vaiTroNames = new List<string>();
            foreach (var vaiTro in vaiTroList)
            {
                vaiTroNames.Add(vaiTro["diachi"].AsString);
            }

            return vaiTroNames;
        }
        public string GetMaVaiTro(string vaiTroName)
        {
            try
            {
                var Filter = Builders<VaiTro_Model>.Filter.Eq(x => x.tenvaitro, vaiTroName);
                var login = dbcontext.VaiTro.Find(Filter).FirstOrDefault();

                if (login != null)
                {
                    return login.mavaitro;
                }
                else
                {
                    return "Fail";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string GetMaChiNhanh(string vaiCNName)
        {
            try
            {
                var Filter = Builders<ChiNhanh_Model>.Filter.Eq(x => x.diachi, vaiCNName);
                var login = dbcontext.ChiNhanh.Find(Filter).FirstOrDefault();

                if (login != null)
                {
                    return login.machinhanh;
                }
                else
                {
                    return "Fail";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public DataTable getallnhanvien()
        {
            var client = new MongoClient(chuoiKetNoi);
            var database = client.GetDatabase("QLTrungTamAmNhac");
            var collection = database.GetCollection<BsonDocument>("NhanVien");
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
            if (tenNV ==string.Empty || namSinh == string.Empty || email == string.Empty || sDT == string.Empty || diaChi == string.Empty || hinhAnh == "" || luong == string.Empty || phai == "" || maVT == string.Empty || noiLamViec == string.Empty)
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
        public string checklogin(string email, string matkhau)
        {
            try
            {
                var checkmail = Builders<NhanVien_Model>.Filter.Eq(x => x.email, email);
                var login = dbcontext.NhanVien.Find(checkmail).FirstOrDefault();

                if (login != null && login.matkhau == matkhau)
                {
                    return "Pass";
                }
                else
                {
                    return "Fail";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string CheckVaiTro(string email)
        {
            try
            {
                var Filter = Builders<NhanVien_Model>.Filter.Eq(x => x.email, email);
                var login = dbcontext.NhanVien.Find(Filter).FirstOrDefault();

                if (login != null)
                {
                    return login.mavaitro;
                }
                else
                {
                    return "Fail";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string ChangePass(string emailToCheck, string oldpass, string newpass)
        {
            try
            {
                var filter = Builders<NhanVien_Model>.Filter.Eq(x => x.email, emailToCheck);
                var existingEmail = dbcontext.NhanVien.Find(filter).FirstOrDefault();
                if (existingEmail != null && existingEmail.matkhau == HashPassword(oldpass))
                {
                    var update = Builders<NhanVien_Model>.Update.Set(x => x.matkhau, HashPassword(newpass));
                    dbcontext.NhanVien.UpdateOne(filter, update);
                    return "Password updated successfully!";
                }
                else
                {
                    return "Incorrect email or old password!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string ForgotPassword(string email, string newpass)
        {
            try
            {
                var filter = Builders<NhanVien_Model>.Filter.Eq(x => x.email, email);
                var existingEmployee = dbcontext.NhanVien.Find(filter).FirstOrDefault();

                if (existingEmployee != null)
                {
                    var update = Builders<NhanVien_Model>.Update.Set(x => x.matkhau,HashPassword( newpass));
                    dbcontext.NhanVien.UpdateOne(filter, update);
                    return "Password updated successfully!";
                }
                else
                {
                    return "Email not found!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
