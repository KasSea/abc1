using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class TaikhoanAccessDAL:DatabaseAccessDAL
    {
        public string Checklogin(TaiKhoan taikhoan)
        {
            string info = CheckloginDTO(taikhoan);
            return info;
        }
    }
}
