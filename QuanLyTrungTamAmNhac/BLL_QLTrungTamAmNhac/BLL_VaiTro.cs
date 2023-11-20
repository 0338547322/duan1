using DAL_QLTrungTamAmNhac;
using DTO_QLTrungTamAmNhac;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QLTrungTamAmNhac
{
    public class BLL_VaiTro
    {
        DAL_VaiTro dal = new DAL_VaiTro();
        public string CreateMaVaiTro()
        {
            return dal.CreateMaVaiTro();
        }
        public string AddVaiTro(VaiTro_Model VaiTro)
        {
            return dal.AddVaiTro(VaiTro);
        }
        public DataTable getallvaitro()
        {
            return dal.getallvaitro();
        }
    }
}
