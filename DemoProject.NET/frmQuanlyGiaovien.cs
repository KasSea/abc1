using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject.NET
{
    public partial class frmQuanlyGiaovien : Form
    {
        public frmQuanlyGiaovien()
        {
            InitializeComponent();
            dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgHienThi.ColumnHeadersHeight = 50;
            dtgHienThi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dtgHienThi.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // màu vàng
            dtgHienThi.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9);
            dtgHienThi.DefaultCellStyle.ForeColor = Color.Black;
            dtgHienThi.RowTemplate.Height = 60;
            dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.;
            dtgHienThi.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter };
            dtgHienThi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            giaoviensss.Xem(dtgHienThi);

            //List<GiaoVienDTO> giaovien = bll.GetGiaoViens();

            //dtgHienThi.DataSource = giaovien;
        }

        GiaoVienBUS giaoviensss = new GiaoVienBUS();
        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }
        private GiaoVienBUS bll = new GiaoVienBUS();

        private void btnXemTL_Click(object sender, EventArgs e)
        {
            //List<GiaoVienDTO> GiaoVien = bll.GetGiaoViens();

            //dtgHienThi.DataSource = GiaoVien;
            giaoviensss.Xem(dtgHienThi);
        }

        private void dtgHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        GiaoVienDTO GiaoVienSS = new GiaoVienDTO();

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Nhập Mã giáo viên!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string maGV = txtMaGV.Text.Trim();

            // Xác nhận lại việc xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa giáo viên có mã " + maGV + "?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi phương thức XoaSoYeuLyLich từ lớp BUS để xóa sơ yếu lý lịch
                if (GiaoVienBUS.Instance.XoaGiaoVien(maGV))
                {
                    MessageBox.Show("Xóa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    giaoviensss.Xem(dtgHienThi);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text != "" && txtTenGV.Text != "" && txtMaLop.Text != "" && txtTuoi.Text != "" && txtTrangThai.Text != "" && txtMaHP.Text != "")
            {
                GiaoVienSS.MaGV = txtMaGV.Text;
                GiaoVienSS.TenGV = txtTenGV.Text;
                GiaoVienSS.MaLop = txtMaLop.Text;
                GiaoVienSS.Tuoi = int.Parse(txtTuoi.Text);
                GiaoVienSS.TrangThai = txtTrangThai.Text;
                GiaoVienSS.MaHP = txtMaHP.Text;
                bool result = GiaoVienBUS.Instance.SuaGiaoVien(GiaoVienSS);
                if (result)
                {
                    MessageBox.Show("Sửa thông tin giáo viên thành công!");
                    giaoviensss.Xem(dtgHienThi);

                }
                else
                {
                    MessageBox.Show("Sửa thông tin giáo viên thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống!");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text != "" && txtTenGV.Text != "" && txtMaLop.Text != "" && txtTuoi.Text != "" && txtTrangThai.Text != "" && txtMaHP.Text != "")
            {
                GiaoVienSS.MaGV = txtMaGV.Text;
                GiaoVienSS.TenGV = txtTenGV.Text;
                GiaoVienSS.MaLop = txtMaLop.Text;
                GiaoVienSS.Tuoi = int.Parse(txtTuoi.Text);
                GiaoVienSS.TrangThai = txtTrangThai.Text;
                GiaoVienSS.MaHP = txtMaHP.Text;

                bool result = GiaoVienBUS.Instance.ThemGiaoVien(GiaoVienSS);
                if (result)
                {
                    MessageBox.Show("Thêm giáo viên thành công!");
                    giaoviensss.Xem(dtgHienThi);

                }
                else
                {
                    MessageBox.Show("Thêm giáo viên Thất Bại!");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống!");
            }
        }
    }
}
