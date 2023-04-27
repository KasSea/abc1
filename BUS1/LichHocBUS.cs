using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class LichHocBUS
    {
        public static LichHocBUS instance;

        public static LichHocBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichHocBUS();
                return instance;
            }
        }

        public LichHocBUS() { }

        private LichHocDAL dal = new LichHocDAL();


        public DataTable GetLichHocBUS(string MaLop)
        {
            return dal.GetLichHocDAL(MaLop);
        }

        public List<LichHocDTO> TK(string name)
        {
            return LichHocDAL.Instance.TimKienLichHoc(name);
        }


        public void Xem(DataGridView data)
        {
            data.DataSource = LichHocDAL.Instance.GetLichHocs();


            data.Columns["MaHP"].HeaderText = "Mã Học Phần";
            data.Columns["TenHP"].HeaderText = "Tên Học Phần";
            data.Columns["MaLop"].HeaderText = "Mã Lớp";  

            data.Columns["MaLop"].HeaderText = "Mã Lớp";
            data.Columns["CaHoc"].HeaderText = "Ca Học";
            data.Columns["Thu"].HeaderText = "Thứ";
            data.Columns["TenGV"].HeaderText = "Tên Giáo Viên";
            data.Columns["LichHoc"].HeaderText = "Lịch Học";
            data.Columns["TenLop"].HeaderText = "Tên Lớp";
        }

        public List<LichHocDTO> getLichHoc()
        {
            return dal.GetLichHocs();
        }

       
        public bool SuaLichHoc(LichHocDTO LichHoc)
        {
            bool result = dal.SuaLichHoc(LichHoc);
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
