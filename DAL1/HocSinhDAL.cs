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
    public class HocSinhDAL : IThemHocSinhDAL , ISuaHocSinhDAL , IXoaHocSinhDAL
    {
        public static HocSinhDAL instance;

        public static HocSinhDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HocSinhDAL();
                return instance;
            }
        }
        public HocSinhDAL() { }

        public List<HocSinhDTO> TimKiemHocSinh(string name)
        {
            List<HocSinhDTO> HocSinhS = new List<HocSinhDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("TimKiemHocSinh", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenHS", name);


                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maHS = reader.GetString(reader.GetOrdinal("MaHS"));
                            string tenHs = reader.IsDBNull(reader.GetOrdinal("TenHS")) ? null : reader.GetString(reader.GetOrdinal("TenHS"));
                            int Tuoi = reader.IsDBNull(reader.GetOrdinal("Tuoi")) ? 0 : Convert.ToInt32(reader["Tuoi"]);
                            string Malop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : reader.GetString(reader.GetOrdinal("MaLop"));
                            string Trangthai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : reader.GetString(reader.GetOrdinal("TrangThai"));

                            HocSinhDTO HocSinh = new HocSinhDTO(maHS, tenHs, Tuoi, Malop, Trangthai);

                            HocSinhS.Add(HocSinh);
                        }
                    }
                }
            }

            return HocSinhS;
        }


        public List<HocSinhDTO> GetHocSinhs()
        {
            List<HocSinhDTO> HocSinhS = new List<HocSinhDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("XemThongTinHocSinh", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maHS = reader.GetString(reader.GetOrdinal("MaHS"));
                            string tenHs = reader.IsDBNull(reader.GetOrdinal("TenHS")) ? null : reader.GetString(reader.GetOrdinal("TenHS"));
                            int Tuoi = reader.IsDBNull(reader.GetOrdinal("Tuoi")) ? 0 : Convert.ToInt32(reader["Tuoi"]);
                            string Malop = reader.IsDBNull(reader.GetOrdinal("MaLop")) ? null : reader.GetString(reader.GetOrdinal("MaLop"));
                            string Trangthai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? null : reader.GetString(reader.GetOrdinal("TrangThai"));

                            HocSinhDTO HocSinh = new HocSinhDTO(maHS, tenHs, Tuoi, Malop, Trangthai);

                            HocSinhS.Add(HocSinh);
                        }
                    }
                }
            }

            return HocSinhS;
        }



        public bool SuaHocSinh(HocSinhDTO HocSinh)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SuaThongTinHocSinh", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHS", HocSinh.MaHS);
                    cmd.Parameters.AddWithValue("@TenHS", HocSinh.TenHS);
                    cmd.Parameters.AddWithValue("@Tuoi", HocSinh.Tuoi);
                    cmd.Parameters.AddWithValue("@MaLop", HocSinh.MaLop);
                    cmd.Parameters.AddWithValue("@TrangThai", HocSinh.TrangThai);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }

            }
            catch (Exception)
            {
                throw new ArgumentException("Phải nhập đúng mã Học Sinh!");
            }
        }


        public bool ThemHocSinh(HocSinhDTO HocSinh)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                    conn.Open();
                    SqlCommand command = new SqlCommand("ThemHocSinh", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHS", HocSinh.MaHS);
                    command.Parameters.AddWithValue("@TenHS", HocSinh.TenHS);
                    command.Parameters.AddWithValue("@Tuoi", HocSinh.Tuoi);
                    command.Parameters.AddWithValue("@MaLop", HocSinh.MaLop);
                    command.Parameters.AddWithValue("@TrangThai", HocSinh.TrangThai);           
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

        public bool XoaHocSinh(string MaHs)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("XoaHocSinh", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHs", MaHs);
                    int result = command.ExecuteNonQuery();

                    conn.Close();

                    return result > 0;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy mã học sinh!");
                return false;
            }
        }
    }
}
