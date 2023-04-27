using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DangkyTaiKhoanDAL:DangkyTk
    {
        public string dkTaiKhoanmoi(DangKyTaiKhoan taikhoanmoi)
        {
            string infonewacc = TaoTaiKhoanDTO(taikhoanmoi);
            return infonewacc;

        }
    }
}
