using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BUS.LopHocBUS;

namespace BUS
{
    public class LopHocBUS
    {
        public static LopHocBUS instance;

        public static LopHocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LopHocBUS();
                return instance;
            }
        }

        public LopHocBUS() { }

        private LopHocDAL dal = new LopHocDAL();

        public void XoaLop(string maLop)
        {         
            dal.XoaLop(maLop);
        }


        public List<LopDTO> TK(string name)
        {
            return LopHocDAL.Instance.TimKiemLop(name);
        }

        public void Xem(DataGridView data)
        {
            data.DataSource = LopHocDAL.Instance.GetLops();

         
            data.Columns["TenLop"].HeaderText = "Tên Lớp";
          
            data.Columns["MaLop"].HeaderText = "Mã Lớp";
            data.Columns["TrangThai"].HeaderText = "Trạng Thái";
            data.Columns["GhiChu"].HeaderText = "Ghi Chú";
        }

        public List<LopDTO> getLopS()
        {
            return dal.GetLops();
        }

        public bool ThemLop(LopDTO LopHoc)
        {
            return LopHocDAL.Instance.ThemLop(LopHoc);
        }

        public bool XoaLopHoc(string MaLop)
        {
            if (MaLop == null || MaLop.Trim() == "")
            {
                return false;
            }


            return dal.XoaLopHoc(MaLop);
        }
        public bool SuaLopHoc(LopDTO LopHoc)
        {
            bool result = dal.SuaLop(LopHoc);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
