using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.DiemSoDAL;

namespace BUS
{
    public class SoYeuLyLichBUS
    {
        public static SoYeuLyLichBUS instance;

        public static SoYeuLyLichBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SoYeuLyLichBUS();
                return instance;
            }
        }

        

        public SoYeuLyLichBUS() { }


        private SoYeuLyLichDAL data = new SoYeuLyLichDAL();

        public DataTable GetSoYeuLyLich(string MaHs)
        {
            return data.GetSoYeuLyLich(MaHs);
        }

        public List<SoYeuLyLichDTO> TK(string name)
        {
            return SoYeuLyLichDAL.Instance.TimKiemHS(name);
        }


        public void Xem(DataGridView data)
        {
            data.DataSource = SoYeuLyLichDAL.Instance.Xem();
            data.Columns["MaHS"].HeaderText = "Mã Học Sinh";
            data.Columns["HoTen"].HeaderText = "Họ và tên";
            data.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            data.Columns["GioiTinh"].HeaderText = "Giới Tính";
            data.Columns["NoiSinh"].HeaderText = "Nơi Sinh";
            data.Columns["QueQuan"].HeaderText = "Quê Quán";
            data.Columns["DanToc"].HeaderText = "Dân Tộc";
            data.Columns["QuocTich"].HeaderText = "Quốc Tịch";
            data.Columns["TonGiao"].HeaderText = "Tôn Giáo";
            data.Columns["TPXuatThan"].HeaderText = "TP Xuất Thân";
            data.Columns["NgayVaoDoan"].HeaderText = "Ngày Vào Đoàn";
            data.Columns["NgayVaoDang"].HeaderText = "Ngày Vào Đảng";
            data.Columns["NoiThuongTru"].HeaderText = "Nơi Thường Trú";
            data.Columns["XaPhuong"].HeaderText = "Xã/Phường";
            data.Columns["QuanHuyen"].HeaderText = "Quận/Huyện";
            data.Columns["TinhThanhPho"].HeaderText = "Tỉnh/ThànhPhố";
            data.Columns["DoiTuongCS"].HeaderText = "Đối TượngCS";
            data.Columns["DoiTuongTroCap"].HeaderText = "Đối Tượng Trợ Cấp";
            data.Columns["NhomDT"].HeaderText = "Nhóm ĐT";
            data.Columns["DienThoaiNhaRieng"].HeaderText = "ĐT Nhà Riêng";
            data.Columns["DienThoaiCaNhan"].HeaderText = "ĐT Cá Nhân";
            data.Columns["Email"].HeaderText = "Email";
            data.Columns["SoCMND"].HeaderText = "Số CMND";
            data.Columns["DiaChiBaoTin"].HeaderText = "Địa Chỉ Báo Tin";
            data.Columns["NoiOHienNay"].HeaderText = "Nơi Ở Hiện Nay";
        }
           
        public bool SuaSoYeuLyLichBUS(SoYeuLyLichDTO SuasoYeuLyLich) 
        {
            SoYeuLyLichDAL SsoYeuLyLichDAL = new SoYeuLyLichDAL();
            bool result = SsoYeuLyLichDAL.SuaSoYeuLyLich(SuasoYeuLyLich);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool AddSoYeuLyLich(SoYeuLyLichDTO soYeuLyLich)
        {
            // Kiểm tra tính hợp lệ của đối tượng SoYeuLyLichDTO
            //if (soYeuLyLich.MaHS <= 0)
            //{
            //    throw new Exception("Mã học sinh không hợp lệ!");
            //}

            // Gọi phương thức thêm sơ yếu lý lịch trong lớp DAO
            return SoYeuLyLichDAL.Instance.ThemSoYeuLyLich(soYeuLyLich);


        }

        public bool XoaSoYeuLyLich(string maHS)
        {
            if (maHS == null || maHS.Trim() == "")
            {
                return false;
            }

            SoYeuLyLichDAL soyeulylichdal = new SoYeuLyLichDAL();
            return soyeulylichdal.XoaSoYeuLyLich(maHS);
        }
    }



}

