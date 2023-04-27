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
    public class GiaoVienDAL : IThemGiaoVienDAL , ISuaGiaoVienDAL , IXoaGiaoVienDAL
    {
      
            public static GiaoVienDAL instance;

            public static GiaoVienDAL Instance
            {
                get
                {
                    if (instance == null)
                        instance = new GiaoVienDAL();
                    return instance;
                }
            }
            public GiaoVienDAL() { }


        public List<GiaoVienDTO> TimKiemGVTheoTen(string name)
        {
            List<GiaoVienDTO> GiaoVienS = new List<GiaoVienDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("TimKiemGVTheoTen", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenGV", name);


                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maGV = reader.GetString(reader.GetOrdinal("MaGV"));
                            string tenGV = reader.IsDBNull(reader.GetOrdinal("TenGV")) ? null : reader.GetString(reader.GetOrdinal("TenGV"));
                            int Tuoi = reader.IsDBNull(reader.GetOrdinal("Tuoi")) ? 0 : Convert.ToInt32(reader["Tuoi"]);
                            string Malop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : reader.GetString(reader.GetOrdinal("MaLop"));
                            string Trangthai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : reader.GetString(reader.GetOrdinal("TrangThai"));
                            string MaHp = reader.IsDBNull(reader.GetOrdinal("MaHP")) ? null : reader.GetString(reader.GetOrdinal("MaHP"));

                            GiaoVienDTO GiaoVien = new GiaoVienDTO(maGV, tenGV, Tuoi, Malop, Trangthai, MaHp);

                            GiaoVienS.Add(GiaoVien);
                        }
                    }
                }
            }

            return GiaoVienS;
        }

        public List<GiaoVienDTO> GetGiaoViens()
        {
            List<GiaoVienDTO> GiaoVienS = new List<GiaoVienDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("XemThongTinGiaoVien", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maGV = reader.GetString(reader.GetOrdinal("MaGV"));
                            string tenGV = reader.IsDBNull(reader.GetOrdinal("TenGV")) ? null : reader.GetString(reader.GetOrdinal("TenGV"));
                            int Tuoi = reader.IsDBNull(reader.GetOrdinal("Tuoi")) ? 0 : Convert.ToInt32(reader["Tuoi"]);
                            string Malop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : reader.GetString(reader.GetOrdinal("MaLop"));
                            string Trangthai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : reader.GetString(reader.GetOrdinal("TrangThai"));
                            string MaHp = reader.IsDBNull(reader.GetOrdinal("MaHP")) ? null : reader.GetString(reader.GetOrdinal("MaHP"));

                            GiaoVienDTO GiaoVien = new GiaoVienDTO(maGV, tenGV, Tuoi, Malop, Trangthai, MaHp);

                            GiaoVienS.Add(GiaoVien);
                        }
                    }
                }
            }

            return GiaoVienS;
        }

        public bool ThemGiaoVien(GiaoVienDTO GiaoVien)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemGiaoVien", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaGV", GiaoVien.MaGV);
                    command.Parameters.AddWithValue("@TenGV", GiaoVien.TenGV);
                    command.Parameters.AddWithValue("@Tuoi", GiaoVien.Tuoi);
                    command.Parameters.AddWithValue("@MaLop", GiaoVien.MaLop);
                    command.Parameters.AddWithValue("@TrangThai", GiaoVien.TrangThai);
                    command.Parameters.AddWithValue("@MaHP", GiaoVien.MaHP);
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

        public bool XoaGiaoVien(string MaGV)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("XoaGiaoVien", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaGV", MaGV);
                    int result = command.ExecuteNonQuery();

                    conn.Close();

                    return result > 0;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy mã giáo viên!");
                return false;
            }
        }

        public bool SuaGiaoVien(GiaoVienDTO GiaoVien)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SuaThongTinGiaoVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaGV", GiaoVien.MaGV);
                    cmd.Parameters.AddWithValue("@TenGV", GiaoVien.TenGV);
                    cmd.Parameters.AddWithValue("@Tuoi", GiaoVien.Tuoi);
                    cmd.Parameters.AddWithValue("@MaLop", GiaoVien.MaLop);
                    cmd.Parameters.AddWithValue("@TrangThai", GiaoVien.TrangThai);
                    cmd.Parameters.AddWithValue("@MaHP", GiaoVien.MaHP);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }

            }
            catch (Exception)
            {
                throw new ArgumentException("Phải nhập đúng mã giáo Viên!");
            }
        }
    }
}
