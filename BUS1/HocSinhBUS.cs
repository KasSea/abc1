using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class HocSinhBUS
    {
        public static HocSinhBUS instance;

        public static HocSinhBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HocSinhBUS();
                return instance;
            }
        }

        public HocSinhBUS() { }


        HocSinhDAL HocSinhDAL = new HocSinhDAL();

        public List<HocSinhDTO> TK(string name)
        {
            return HocSinhDAL.Instance.TimKiemHocSinh(name);
        }



        public void Xem(DataGridView data)
        {
            data.DataSource = HocSinhDAL.Instance.GetHocSinhs();
      
            data.Columns["MaHs"].HeaderText = "Mã Học Sinh";
            data.Columns["TenHS"].HeaderText = "Tên Học Sinh";
            data.Columns["Tuoi"].HeaderText = "Tuổi";
            data.Columns["MaLop"].HeaderText = "Mã Lớp";
            data.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }


        public List<HocSinhDTO> GetDiemSos()
        {
            return HocSinhDAL.GetHocSinhs();
        }

        public bool XoaHocSinh(string MaHs)
        {
            if ( MaHs == null || MaHs.Trim() == "" )
            {
                return false;
            }

           
            return HocSinhDAL.XoaHocSinh( MaHs);
        }

        public bool SuaHocSinh(HocSinhDTO HocSinh)
        {
            bool result = HocSinhDAL.SuaHocSinh(HocSinh);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool ThemHocSinh(HocSinhDTO HocSinh)
        {
            return HocSinhDAL.Instance.ThemHocSinh(HocSinh);
        }
    }
}
