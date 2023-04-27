using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public interface IXoaLopDAL
    {
        bool XoaLop(string MaLop);
    }
    public interface IThemLopDAL
    {
        bool ThemLop(LopDTO Lop);
    }

    public interface ISuaLopDAL
    {
        bool SuaLop(LopDTO Lop);
    }

    public interface IXoaLichDAL
    {
        bool XoaLichHoc(string MaLop);
    }
    public interface IThemLichDAL
    {
        bool ThemLichHoc(LopDTO Lop);
    }

    public interface ISuaLichDAL
    {
        bool SuaLichHoc(LopDTO Lop);
    }

    public interface IXoaGiaoVienDAL
    {
        bool XoaGiaoVien(string MaGV);
    }
    public interface IThemGiaoVienDAL
    {
        bool ThemGiaoVien(GiaoVienDTO GiaoVien);
    }

    public interface ISuaGiaoVienDAL
    {
        bool SuaGiaoVien(GiaoVienDTO GiaoVien);
    }
    // end

    // begin interface Điểm Số
    public interface IXoaDiemSoDAL
    {
        bool XoaDiemSo(string MaHp, string MaHs, string TenHP);
    }
    public interface IThemDiemSoDAL
    {
        bool ThemDiemSo(DiemSoDTO DiemSo);
    }

    public interface ISuaDiemSoDAL
    {
        bool SuaDiemSo(DiemSoDTO DiemSo);
    }


    // end 

    // begin interface Học Sinh

    public interface IXoaHocSinhDAL
    {
        bool XoaHocSinh(string MaHs);
    }
    public interface IThemHocSinhDAL
    {
        bool ThemHocSinh(HocSinhDTO HocSinh);
    }

    public interface ISuaHocSinhDAL
    {
        bool SuaHocSinh(HocSinhDTO HocSinh);
    }

    //end
    public interface IThemSoYeuLyLichDAL
    {
        bool ThemSoYeuLyLich(SoYeuLyLichDTO soYeuLyLich);

    }
    public interface IXoaSoYeuLyLichDAL
    {
        bool XoaSoYeuLyLich(string maHS);
    }
    public interface ISuaSoYeuLyLichDAL
    {
        bool SuaSoYeuLyLich(SoYeuLyLichDTO sSoYeuLyLich);
    }

    public interface IGetYeuLyLichDAL
    {
        SoYeuLyLichDTO GetSYLLHS(string maHS);
    }
}
