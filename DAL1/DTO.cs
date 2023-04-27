using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichHocDTO
    {
        public string MaHP { get; set; }
        public string TenHP { get; set; }
        public string MaLop { get; set; }
        public string CaHoc { get; set; }
        public string Thu { get; set; }
        public string TenGV { get; set; }
        public string LichHoc { get; set; }
        public string TenLop { get; set; }

        public LichHocDTO(string maHP, string tenHP, string maLop, string caHoc, string thu, string tenGV, string lichHoc, string tenLop)
        {
            MaHP = maHP;
            TenHP = tenHP;
            MaLop = maLop;
            CaHoc = caHoc;
            Thu = thu;
            TenGV = tenGV;
            LichHoc = lichHoc;
            TenLop = tenLop;
        }

        public LichHocDTO() { }

    }

    public class LopDTO
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }

        public LopDTO(string maLop, string tenLop, string trangThai, string ghiChu)
        {
            MaLop = maLop;
            TenLop = tenLop;
            TrangThai = trangThai;
            GhiChu = ghiChu;
        }

        public LopDTO() { } 
    }


    public class GiaoVienDTO
    {
        public string MaGV { get; set; }
        public string TenGV { get; set; }
        public int Tuoi { get; set; }
        public string MaLop { get; set; }
        public string TrangThai { get; set; }
        public string MaHP { get; set; }
        public GiaoVienDTO(string maGV, string tenGV, int tuoi, string maLop, string trangThai, string maHP)
        {
            MaGV = maGV;
            TenGV = tenGV;
            Tuoi = tuoi;
            MaLop = maLop;
            TrangThai = trangThai;
            MaHP = maHP;
        }
        public GiaoVienDTO() { }

    }


    public class HocSinhDTO
    {
        public string MaHS { get; set; }
        public string TenHS { get; set; }
        public int Tuoi { get; set; }
        public string MaLop { get; set; }
        public string TrangThai { get; set; }

        public HocSinhDTO(string maHS, string tenHS, int tuoi, string maLop, string trangThai)
        {
            MaHS = maHS;
            TenHS = tenHS;
            Tuoi = tuoi;
            MaLop = maLop;
            TrangThai = trangThai;
        }

        public HocSinhDTO() { }
    }

    public class DiemSoDTO
    {
        public string MaHP { get; set; }
        public string MaHs { get; set; }
        public string TenHP { get; set; }
        public float DiemSo { get; set; }
        public string HocKy { get; set; }
        public string NamHoc { get; set; }

        public DiemSoDTO() { }

        public DiemSoDTO(string maHP, string maHs, string tenHP, float diemSo, string hocKy, string namHoc)
        {
            MaHP = maHP;
            MaHs = maHs;
            TenHP = tenHP;
            DiemSo = diemSo;
            HocKy = hocKy;
            NamHoc = namHoc;
        }
    }
    // sơ yếu lý lịch
    public class SoYeuLyLichDTO
    {

        public SoYeuLyLichDTO()
        {
        }

        public SoYeuLyLichDTO(string maHS) {
            MaHS = maHS;
        }
        public SoYeuLyLichDTO(string maHS, string hoTen, DateTime ngaySinh ,string gioiTinh
            , string noiSinh, string queQuan , string danToc, string quocTich, string tonGiao, string tPXuatThan, DateTime ngayVaoDoan, DateTime ngayVaoDang, string noiThuongTru, string xaPhuong, string quanHuyen, string tinhThanhPho, string doiTuongCS, string doiTuongTroCap, string nhomDT, string dienThoaiNhaRieng, string dienThoaiCaNhan, string email, string soCMND, string diaChiBaoTin, string noiOHienNay)
        {
            MaHS = maHS;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            NoiSinh = noiSinh;
            QueQuan = queQuan;
            DanToc = danToc;
            QuocTich = quocTich;
            TonGiao = tonGiao;
            TPXuatThan = tPXuatThan;
            NgayVaoDoan = ngayVaoDoan;
            NgayVaoDang = ngayVaoDang;
            NoiThuongTru = noiThuongTru;
            XaPhuong = xaPhuong;
            QuanHuyen = quanHuyen;
            TinhThanhPho = tinhThanhPho;
            DoiTuongCS = doiTuongCS;
            DoiTuongTroCap = doiTuongTroCap;
            NhomDT = nhomDT;
            DienThoaiNhaRieng = dienThoaiNhaRieng;
            DienThoaiCaNhan = dienThoaiCaNhan;
            Email = email;
            SoCMND = soCMND;
            DiaChiBaoTin = diaChiBaoTin;
            NoiOHienNay = noiOHienNay;
        }

        public string MaHS { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string NoiSinh { get; set; }
        public string QueQuan { get; set; }
        public string DanToc { get; set; }
        public string QuocTich { get; set; }
        public string TonGiao { get; set; }
        public string TPXuatThan { get; set; }
        public DateTime NgayVaoDoan { get; set; }
        public DateTime NgayVaoDang { get; set; }
        public string NoiThuongTru { get; set; }
        public string XaPhuong { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanhPho { get; set; }
        public string DoiTuongCS { get; set; }
        public string DoiTuongTroCap { get; set; }
        public string NhomDT { get; set; }
        public string DienThoaiNhaRieng { get; set; }
        public string DienThoaiCaNhan { get; set; }
        public string Email { get; set; }
        public string SoCMND { get; set; }
        public string DiaChiBaoTin { get; set; }
        public string NoiOHienNay { get; set; }
    }
    // end 


    public class TaiKhoan
    {
        public string maTk { get; set; }
        public string tenTk { get; set; }
        public string matkhauTk { get; set; }
        public int Fk_maQuyen { get; set; }
        public string emailTk { get; set; }
    }
    public class QuenMatKhau
    {
        public string emailTk { get; set; }
    }
    public class DangKyTaiKhoan
    {
        public string tenTk { get; set; }
        public string matkhauTk { get; set; }
        public string emailTk { get; set; }

    }

    public class BaoCaoDiemSo
    {
        private string maHP;
        private string tenHp;
        private string maHs;
        private string tenHs;
        private DateTime ngaysinh;
        private double diemso;

        public BaoCaoDiemSo(string maHP, string tenHp, string maHs, string tenHs, DateTime ngaysinh, double diemso)
        {
            MaHP = maHP;
            TenHp = tenHp;
            MaHs = maHs;
            TenHs = tenHs;
            Ngaysinh = ngaysinh;
            Diemso = diemso;
        }

        public string MaHP { get => maHP; set => maHP = value; }
        public string TenHp { get => tenHp; set => tenHp = value; }
        public string MaHs { get => maHs; set => maHs = value; }
        public string TenHs { get => tenHs; set => tenHs = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public double Diemso { get => diemso; set => diemso = value; }
    }
    public class QuanLyTaiLieu
    {
        private string maTL;

        public string MaTL { get => maTL; set => maTL = value; }
        public string TenTl { get => tenTl; set => tenTl = value; }
        public string TlMon { get => tlMon; set => tlMon = value; }
        public DateTime NgayXuatBan { get => ngayXuatBan; set => ngayXuatBan = value; }

        private string tenTl;

        private string tlMon;

        private DateTime ngayXuatBan;

        // constructor
        public QuanLyTaiLieu(string maTL, string tenTL, string tlMon, DateTime ngayXuatBan)
        {
            this.maTL = maTL;
            this.tenTl = tenTL;
            this.tlMon = tlMon;
            this.ngayXuatBan = ngayXuatBan;
        }
    }
}

