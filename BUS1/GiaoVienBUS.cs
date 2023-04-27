using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class GiaoVienBUS
    {
        public static GiaoVienBUS instance;

        public static GiaoVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoVienBUS();
                return instance;
            }
        }

        public GiaoVienBUS() { }

        private GiaoVienDAL dal = new GiaoVienDAL();

        public List<GiaoVienDTO> TK(string name)
        {
            return GiaoVienDAL.Instance.TimKiemGVTheoTen(name);
        }



        public void Xem(DataGridView data)
        {
            data.DataSource = GiaoVienDAL.Instance.GetGiaoViens();

            data.Columns["MaGV"].HeaderText = "Mã Giáo Viên";
            data.Columns["TenGV"].HeaderText = "Tên Giáo Viên";
            data.Columns["Tuoi"].HeaderText = "Tuổi";
            data.Columns["MaLop"].HeaderText = "Mã Lớp";
            data.Columns["TrangThai"].HeaderText = "Trạng Thái";
            data.Columns["MaHP"].HeaderText = "Mã Học Phần";
        }

        public List<GiaoVienDTO> GetGiaoViens()
        {
            return dal.GetGiaoViens();
        }

        public bool ThemGiaoVien(GiaoVienDTO GiaoVien)
        {
            return GiaoVienDAL.Instance.ThemGiaoVien(GiaoVien);
        }

        public bool XoaGiaoVien(string MaGV)
        {
            if (MaGV == null || MaGV.Trim() == "")
            {
                return false;
            }


            return dal.XoaGiaoVien(MaGV);
        }
        public bool SuaGiaoVien(GiaoVienDTO GiaoVien)
        {
            bool result = dal.SuaGiaoVien(GiaoVien);
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
