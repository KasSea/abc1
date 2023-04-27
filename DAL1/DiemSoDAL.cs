
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DAL
{
    public class DiemSoDAL : IThemDiemSoDAL , ISuaDiemSoDAL , IXoaDiemSoDAL
    {
        public static DiemSoDAL instance;

        public static DiemSoDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DiemSoDAL();
                return instance;
            }
        }

        public DiemSoDAL() { }

        public List<DiemSoDTO> TimKiemDiemTheoTenHS(string name)
        {
            List<DiemSoDTO> diemSos = new List<DiemSoDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("TimKiemDiemTheoTenHS", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenHS", name);


                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maHP = reader.GetString(reader.GetOrdinal("MaHP"));
                            string maHS = reader.GetString(reader.GetOrdinal("MaHs"));
                            string tenHP = reader.GetString(reader.GetOrdinal("TenHP"));
                            float diemSo = Convert.ToSingle(reader["DiemSo"]);
                            string hocKy = reader.GetString(reader.GetOrdinal("HocKy"));
                            string namHoc = reader.GetString(reader.GetOrdinal("NamHoc"));

                            DiemSoDTO diemSoDTO = new DiemSoDTO(maHP, maHS, tenHP, diemSo, hocKy, namHoc);

                            diemSos.Add(diemSoDTO);
                        }
                    }
                }
            }

            return diemSos;
        }



        public DataTable GetDiemSoDAL(string MaHs,string HocKy,string NamHoc)
        {

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                conn.Open();
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("DiemSoTrungBinh", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaHS", MaHs);
                sqlCommand.Parameters.AddWithValue("@HocKy", HocKy);
                sqlCommand.Parameters.AddWithValue("@NamHoc", NamHoc);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                conn.Close();
                return dataTable;
                //


                // Gán bảng này cho DataGridView để hiển thị dữ liệ

            }

        }


        public List<DiemSoDTO> GetDiemSos()
        {
            List<DiemSoDTO> diemSos = new List<DiemSoDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("XemDiemSo", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maHP = reader.GetString(reader.GetOrdinal("MaHP"));
                            string maHS = reader.GetString(reader.GetOrdinal("MaHs"));
                            string tenHP = reader.GetString(reader.GetOrdinal("TenHP"));
                            float diemSo = Convert.ToSingle(reader["DiemSo"]);
                            string hocKy = reader.GetString(reader.GetOrdinal("HocKy"));
                            string namHoc = reader.GetString(reader.GetOrdinal("NamHoc"));

                            DiemSoDTO diemSoDTO = new DiemSoDTO(maHP, maHS, tenHP, diemSo, hocKy, namHoc);

                            diemSos.Add(diemSoDTO);
                        }
                    }
                }
            }

            return diemSos;
        }




        public bool ThemDiemSo(DiemSoDTO DiemSo)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemDiemSo", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHP",DiemSo.MaHP);
                    command.Parameters.AddWithValue("@MaHS", DiemSo.MaHs);
                    command.Parameters.AddWithValue("@TenHP", DiemSo.TenHP);
                    command.Parameters.AddWithValue("@DiemSo", DiemSo.DiemSo);
                    command.Parameters.AddWithValue("@HocKy", DiemSo.HocKy);
                    command.Parameters.AddWithValue("@NamHoc", DiemSo.NamHoc);

                    int rowsAffected = command.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể chèn dữ liệu!\n" + ex.Message);
                return false;
            }
        }

        public bool SuaDiemSo(DiemSoDTO DiemSo)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SuaDiemSo", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHp", DiemSo.MaHP);
                    cmd.Parameters.AddWithValue("@MaHS", DiemSo.MaHs);
                    cmd.Parameters.AddWithValue("@TenHP", DiemSo.TenHP);
                    cmd.Parameters.AddWithValue("@DiemSo", DiemSo.DiemSo);
                    cmd.Parameters.AddWithValue("@HocKy", DiemSo.HocKy);
                    cmd.Parameters.AddWithValue("@NamHoc", DiemSo.NamHoc);
                   

                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }

            }
            catch (Exception)
            {
                throw new ArgumentException("Phải nhập đúng mã Học Sinh, Mã học Phần và Tên Học Phần!");
            }
        }

        public bool XoaDiemSo(string MaHp, string MaHs, string TenHP)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("XoaDiemSo", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHP", MaHp);
                    command.Parameters.AddWithValue("@MaHs", MaHs);
                    command.Parameters.AddWithValue("@TenHP", TenHP);

                    int result = command.ExecuteNonQuery();

                    conn.Close();

                    return result > 0;

                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Nhập Đúng mã học sinh, mã và tên học phần!");
            }
        }
    }
}
