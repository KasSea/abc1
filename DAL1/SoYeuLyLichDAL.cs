using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class SoYeuLyLichDAL : IThemSoYeuLyLichDAL, IXoaSoYeuLyLichDAL , ISuaSoYeuLyLichDAL
    {

        private static SoYeuLyLichDAL instance;

        public static SoYeuLyLichDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SoYeuLyLichDAL();
                return instance;
            }
        }

        public SoYeuLyLichDAL() { }

        public DataTable GetSoYeuLyLich(string MaHs)
        {

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                conn.Open();
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("GetSYLLHS", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaHS", MaHs);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                conn.Close();
                return dataTable;
                //


                // Gán bảng này cho DataGridView để hiển thị dữ liệ

            }

        }


        public List<SoYeuLyLichDTO> TimKiemHS(string name)
        {
            List<SoYeuLyLichDTO> SoYeuLyLichS = new List<SoYeuLyLichDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                using (SqlCommand command = new SqlCommand("TimKiemHS", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenHS", name);

                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Tạo bảng tạm trong bộ nhớ để chứa dữ liệu
                    while (reader.Read())
                    {
                        string maHS = reader["MaHs"].ToString();
                        string hoTen = reader["HoTen"].ToString();
                        DateTime ngaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        string gioiTinh = reader["GioiTinh"].ToString();
                        string noiSinh = reader["NoiSinh"].ToString();
                        string queQuan = reader["QueQuan"].ToString();
                        string danToc = reader["DanToc"].ToString();
                        string quocTich = reader["QuocTich"].ToString();
                        string tonGiao = reader["TonGiao"].ToString();
                        string tPXuatThan = reader["TPXuatThan"].ToString();
                        DateTime ngayVaoDoan = Convert.ToDateTime(reader["NgayVaoDoan"]);
                        DateTime ngayVaoDang = Convert.ToDateTime(reader["NgayVaoDang"]);
                        string noiThuongTru = reader["NoiThuongTru"].ToString();
                        string xaPhuong = reader["XaPhuong"].ToString();
                        string quanHuyen = reader["QuanHuyen"].ToString();
                        string tinhThanhPho = reader["TinhThanhPho"].ToString();
                        string doiTuongCS = reader["DoiTuongCS"].ToString();
                        string doiTuongTroCap = reader["DoiTuongTroCap"].ToString();
                        string nhomDT = reader["NhomDT"].ToString();
                        string dienThoaiNhaRieng = reader["DienThoaiNhaRieng"].ToString();
                        string dienThoaiCaNhan = reader["DienThoaiCaNhan"].ToString();
                        string email = reader["Email"].ToString();
                        string soCMND = reader["SoCMND"].ToString();
                        string diaChiBaoTin = reader["DiaChiBaoTin"].ToString();
                        string noiOHienNay = reader["NoiOHienNay"].ToString();


                        SoYeuLyLichDTO syll = new SoYeuLyLichDTO(maHS, hoTen, ngaySinh, gioiTinh, noiSinh, queQuan,
                            danToc, quocTich, tonGiao, tPXuatThan, ngayVaoDoan, ngayVaoDang, noiThuongTru, xaPhuong, quanHuyen, tinhThanhPho,
                            doiTuongCS, doiTuongTroCap, nhomDT, dienThoaiNhaRieng, dienThoaiCaNhan, email, soCMND, diaChiBaoTin, noiOHienNay
                            );

                        SoYeuLyLichS.Add(syll);
                    }
                    reader.Close();

                    // Gán bảng này cho DataGridView để hiển thị dữ liệu

                }

            }

            return SoYeuLyLichS;
        }




        public List<SoYeuLyLichDTO> Xem()
        {
            List<SoYeuLyLichDTO> SoYeuLyLichS = new List<SoYeuLyLichDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                using (SqlCommand command = new SqlCommand("XemThongTinAllSV", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Tạo bảng tạm trong bộ nhớ để chứa dữ liệu
                    while (reader.Read())
                    {
                        string maHS = reader["MaHs"].ToString();                            
                        string hoTen = reader["HoTen"].ToString();
                        DateTime ngaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        string gioiTinh = reader["GioiTinh"].ToString();
                        string noiSinh = reader["NoiSinh"].ToString();
                        string queQuan = reader["QueQuan"].ToString();
                        string danToc = reader["DanToc"].ToString();
                        string quocTich = reader["QuocTich"].ToString();
                        string tonGiao = reader["TonGiao"].ToString();
                        string tPXuatThan = reader["TPXuatThan"].ToString();
                        DateTime ngayVaoDoan = Convert.ToDateTime(reader["NgayVaoDoan"]);
                        DateTime ngayVaoDang = Convert.ToDateTime(reader["NgayVaoDang"]);
                        string noiThuongTru = reader["NoiThuongTru"].ToString();
                        string xaPhuong = reader["XaPhuong"].ToString();
                        string quanHuyen = reader["QuanHuyen"].ToString();
                        string tinhThanhPho = reader["TinhThanhPho"].ToString();
                        string doiTuongCS = reader["DoiTuongCS"].ToString();
                        string doiTuongTroCap = reader["DoiTuongTroCap"].ToString();
                        string nhomDT = reader["NhomDT"].ToString();
                        string dienThoaiNhaRieng = reader["DienThoaiNhaRieng"].ToString();
                        string dienThoaiCaNhan = reader["DienThoaiCaNhan"].ToString();
                        string email = reader["Email"].ToString();
                        string soCMND = reader["SoCMND"].ToString();
                        string diaChiBaoTin = reader["DiaChiBaoTin"].ToString();
                        string noiOHienNay = reader["NoiOHienNay"].ToString();


                        SoYeuLyLichDTO syll = new SoYeuLyLichDTO(maHS, hoTen, ngaySinh, gioiTinh ,noiSinh, queQuan,
                            danToc, quocTich, tonGiao, tPXuatThan, ngayVaoDoan, ngayVaoDang, noiThuongTru, xaPhuong, quanHuyen, tinhThanhPho,
                            doiTuongCS, doiTuongTroCap, nhomDT, dienThoaiNhaRieng, dienThoaiCaNhan, email, soCMND, diaChiBaoTin, noiOHienNay
                            );

                        SoYeuLyLichS.Add(syll);
                    }
                    reader.Close();


                    // Gán bảng này cho DataGridView để hiển thị dữ liệu

                }

            }



            return SoYeuLyLichS;
        }

        public bool SuaSoYeuLyLich(SoYeuLyLichDTO sSoYeuLyLich)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                { 
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SuaSinhVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHS", sSoYeuLyLich.MaHS);
                    cmd.Parameters.AddWithValue("@HoTen", sSoYeuLyLich.HoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", sSoYeuLyLich.NgaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", sSoYeuLyLich.GioiTinh);
                    cmd.Parameters.AddWithValue("@NoiSinh", sSoYeuLyLich.NoiSinh);
                    cmd.Parameters.AddWithValue("@QueQuan", sSoYeuLyLich.QueQuan);
                    cmd.Parameters.AddWithValue("@DanToc", sSoYeuLyLich.DanToc);
                    cmd.Parameters.AddWithValue("@QuocTich", sSoYeuLyLich.QuocTich);
                    cmd.Parameters.AddWithValue("@TonGiao", sSoYeuLyLich.TonGiao);
                    cmd.Parameters.AddWithValue("@TPXuatThan", sSoYeuLyLich.TPXuatThan);
                    cmd.Parameters.AddWithValue("@NgayVaoDoan", sSoYeuLyLich.NgayVaoDoan);
                    cmd.Parameters.AddWithValue("@NgayVaoDang", sSoYeuLyLich.NgayVaoDang);
                    cmd.Parameters.AddWithValue("@NoiThuongTru", sSoYeuLyLich.NoiThuongTru);
                    cmd.Parameters.AddWithValue("@XaPhuong", sSoYeuLyLich.XaPhuong);
                    cmd.Parameters.AddWithValue("@QuanHuyen", sSoYeuLyLich.QuanHuyen);
                    cmd.Parameters.AddWithValue("@TinhThanhPho", sSoYeuLyLich.TinhThanhPho);
                    cmd.Parameters.AddWithValue("@DoiTuongCS", sSoYeuLyLich.DoiTuongCS);
                    cmd.Parameters.AddWithValue("@DoiTuongTroCap", sSoYeuLyLich.DoiTuongTroCap);
                    cmd.Parameters.AddWithValue("@NhomDT", sSoYeuLyLich.NhomDT);
                    cmd.Parameters.AddWithValue("@DienThoaiNhaRieng", sSoYeuLyLich.DienThoaiNhaRieng);
                    cmd.Parameters.AddWithValue("@DienThoaiCaNhan", sSoYeuLyLich.DienThoaiCaNhan);
                    cmd.Parameters.AddWithValue("@Email", sSoYeuLyLich.Email);
                    cmd.Parameters.AddWithValue("@SoCMND", sSoYeuLyLich.SoCMND);
                    cmd.Parameters.AddWithValue("@DiaChiBaoTin", sSoYeuLyLich.DiaChiBaoTin);
                    cmd.Parameters.AddWithValue("@NoiOHienNay", sSoYeuLyLich.NoiOHienNay);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }

                }catch (Exception ) 
                {
                    throw new ArgumentException("Phải nhập đúng mã Học Sinh");
            }
            
        }


        public bool ThemSoYeuLyLich(SoYeuLyLichDTO soYeuLyLich)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemSinhVien", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHS", soYeuLyLich.MaHS);
                    command.Parameters.AddWithValue("@HoTen", soYeuLyLich.HoTen);
                    command.Parameters.AddWithValue("@NgaySinh", soYeuLyLich.NgaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", soYeuLyLich.GioiTinh);
                    command.Parameters.AddWithValue("@NoiSinh", soYeuLyLich.NoiSinh);
                    command.Parameters.AddWithValue("@QueQuan", soYeuLyLich.QueQuan);
                    command.Parameters.AddWithValue("@DanToc", soYeuLyLich.DanToc);
                    command.Parameters.AddWithValue("@QuocTich", soYeuLyLich.QuocTich);
                    command.Parameters.AddWithValue("@TonGiao", soYeuLyLich.TonGiao);
                    command.Parameters.AddWithValue("@TPXuatThan", soYeuLyLich.TPXuatThan);
                    command.Parameters.AddWithValue("@NgayVaoDoan", soYeuLyLich.NgayVaoDoan);
                    command.Parameters.AddWithValue("@NgayVaoDang", soYeuLyLich.NgayVaoDang);
                    command.Parameters.AddWithValue("@NoiThuongTru", soYeuLyLich.NoiThuongTru);
                    command.Parameters.AddWithValue("@XaPhuong", soYeuLyLich.XaPhuong);
                    command.Parameters.AddWithValue("@QuanHuyen", soYeuLyLich.QuanHuyen);
                    command.Parameters.AddWithValue("@TinhThanhPho", soYeuLyLich.TinhThanhPho);
                    command.Parameters.AddWithValue("@DoiTuongCS", soYeuLyLich.DoiTuongCS);
                    command.Parameters.AddWithValue("@DoiTuongTroCap", soYeuLyLich.DoiTuongTroCap);
                    command.Parameters.AddWithValue("@NhomDT", soYeuLyLich.NhomDT);
                    command.Parameters.AddWithValue("@DienThoaiNhaRieng", soYeuLyLich.DienThoaiNhaRieng);
                    command.Parameters.AddWithValue("@DienThoaiCaNhan", soYeuLyLich.DienThoaiCaNhan);
                    command.Parameters.AddWithValue("@Email", soYeuLyLich.Email);
                    command.Parameters.AddWithValue("@SoCMND", soYeuLyLich.SoCMND);
                    command.Parameters.AddWithValue("@DiaChiBaoTin", soYeuLyLich.DiaChiBaoTin);
                    command.Parameters.AddWithValue("@NoiOHienNay", soYeuLyLich.NoiOHienNay);

                    int rowsAffected = command.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;



                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Phải nhập đủ thông tin cần thiết!");
            }
        }

        public bool XoaSoYeuLyLich(string maHS)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("XoaSinhVien", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHS", maHS);

                    int result = command.ExecuteNonQuery();

                    conn.Close();
                    
                     return result > 0;
          
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("ID học sinh không đúng!");
            }
        }

       
    }

   
}
