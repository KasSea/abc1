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
    public class LichHocDAL
    {

        public static LichHocDAL instance;

        public static LichHocDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichHocDAL();
                return instance;
            }
        }
        public LichHocDAL() { }


        public DataTable GetLichHocDAL(string MaLop)
        {

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                conn.Open();
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("XuatLichHoc", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaLop", MaLop);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                conn.Close();
                return dataTable;
                //


                // Gán bảng này cho DataGridView để hiển thị dữ liệ

            }

        }

        public List<LichHocDTO> GetLichHocs()
        {
            List<LichHocDTO> LichHocs = new List<LichHocDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("XemThongTinLichHoc", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string MaHP = reader.GetString(reader.GetOrdinal("MaHP"));
                            string TenHP = reader.IsDBNull(reader.GetOrdinal("TenHP")) ? null : reader.GetString(reader.GetOrdinal("TenHP"));
                            string MaLop = reader.GetString(reader.GetOrdinal("MaLop"));
                            string CaHoc = reader.IsDBNull(reader.GetOrdinal("CaHoc")) ? null : reader.GetString(reader.GetOrdinal("CaHoc"));
                            string Thu = reader.IsDBNull(reader.GetOrdinal("Thu")) ? null : reader.GetString(reader.GetOrdinal("Thu"));
                            string TenGV = reader.IsDBNull(reader.GetOrdinal("TenGV")) ? null : reader.GetString(reader.GetOrdinal("TenGV"));
                            string LichHoc = reader.IsDBNull(reader.GetOrdinal("LichHoc")) ? null : reader.GetString(reader.GetOrdinal("LichHoc"));
                            string TenLop = reader.IsDBNull(reader.GetOrdinal("TenLop")) ? null : reader.GetString(reader.GetOrdinal("TenLop"));


                            LichHocDTO LichHocSS = new LichHocDTO(MaHP, TenHP, MaLop, CaHoc, Thu, TenGV, LichHoc, TenLop);

                            LichHocs.Add(LichHocSS);
                        }
                    }
                }
            }

            return LichHocs;
        }




        public List<LichHocDTO> TimKienLichHoc(string name)
        {
            List<LichHocDTO> LichHocs = new List<LichHocDTO>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                using (SqlCommand command = new SqlCommand("TimKienLichHoc", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenHP", name);

                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string MaHP = reader.GetString(reader.GetOrdinal("MaHP"));
                            string TenHP = reader.IsDBNull(reader.GetOrdinal("TenHP")) ? null : reader.GetString(reader.GetOrdinal("TenHP"));
                            string MaLop = reader.GetString(reader.GetOrdinal("MaLop"));
                            string CaHoc = reader.IsDBNull(reader.GetOrdinal("CaHoc")) ? null : reader.GetString(reader.GetOrdinal("CaHoc"));
                            string Thu = reader.IsDBNull(reader.GetOrdinal("Thu")) ? null : reader.GetString(reader.GetOrdinal("Thu"));
                            string TenGV = reader.IsDBNull(reader.GetOrdinal("TenGV")) ? null : reader.GetString(reader.GetOrdinal("TenGV"));
                            string LichHoc = reader.IsDBNull(reader.GetOrdinal("LichHoc")) ? null : reader.GetString(reader.GetOrdinal("LichHoc"));
                            string TenLop = reader.IsDBNull(reader.GetOrdinal("TenLop")) ? null : reader.GetString(reader.GetOrdinal("TenLop"));


                            LichHocDTO LichHocSS = new LichHocDTO(MaHP, TenHP, MaLop, CaHoc, Thu, TenGV, LichHoc, TenLop);

                            LichHocs.Add(LichHocSS);
                        }
                    }
                }
            }

            return LichHocs;
        }

     
      
        public bool SuaLichHoc(LichHocDTO LichHoc)
        {
            try
            {
                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SuaThongTinLichHoc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHP", LichHoc.MaHP);
                    cmd.Parameters.AddWithValue("@MaLop", LichHoc.MaLop);
                    cmd.Parameters.AddWithValue("@TenHP", LichHoc.TenHP);
                    cmd.Parameters.AddWithValue("@CaHoc", LichHoc.CaHoc);
                    cmd.Parameters.AddWithValue("@Thu", LichHoc.Thu);
                    cmd.Parameters.AddWithValue("@TenGV", LichHoc.TenGV);
                    cmd.Parameters.AddWithValue("@LichHoc", LichHoc.LichHoc);
                    cmd.Parameters.AddWithValue("@TenLop", LichHoc.TenLop);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();
                    return rowsAffected > 0;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy lịch học !");
                return false;
            }
        }
    }
}
