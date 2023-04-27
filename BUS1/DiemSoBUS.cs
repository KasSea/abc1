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
    public class DiemSoBUS
    {

        public static DiemSoBUS instance;

        public static DiemSoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DiemSoBUS();
                return instance;
            }
        }

        public DiemSoBUS() { }

        private DiemSoDAL dal = new DiemSoDAL();


        public List<DiemSoDTO> TK(string name)
        {
            return DiemSoDAL.Instance.TimKiemDiemTheoTenHS(name);
        }


        public DataTable GetDiemSoBUS(string MaHs,string HocKy,string NamHoc)
        {
            return dal.GetDiemSoDAL(MaHs, HocKy, NamHoc);
        }

        public void Xem(DataGridView data) 
        {          
            data.DataSource = DiemSoDAL.Instance.GetDiemSos();
            data.Columns["MaHP"].HeaderText = "Mã Học Phần";
            data.Columns["MaHs"].HeaderText = "Mã Học Sinh";
            data.Columns["TenHP"].HeaderText = "Tên Học Phần";
            data.Columns["DiemSo"].HeaderText = "Điểm Số";
            data.Columns["HocKy"].HeaderText = "Học Kỳ";
            data.Columns["NamHoc"].HeaderText = "Năm Học";          
        }


        public List<DiemSoDTO> GetDiemSos()
        {
            return dal.GetDiemSos();
        }

        public bool AddDiemSo(DiemSoDTO DiemSo)
        {
            
            return DiemSoDAL.Instance.ThemDiemSo(DiemSo);

        }

        public bool SuaDiemSo(DiemSoDTO diemSo)
        {
            DiemSoDAL DiemSoDaL = new DiemSoDAL();
            bool result = DiemSoDaL.SuaDiemSo(diemSo);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool XoaDiemSo(string MaHp, string MaHs, string TenHP)
        {
            if (MaHp == null || MaHp.Trim() == "" || MaHs == null || MaHs.Trim() == "" || TenHP == null || TenHP.Trim() == "")
            {
                return false;
            }

            DiemSoDAL diemso = new DiemSoDAL();
            return diemso.XoaDiemSo(MaHp, MaHs, TenHP);
        }
    }
}
