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
    public partial class frmQuanlyhocsinh : Form
    {
        public frmQuanlyhocsinh()
        {
            InitializeComponent();
            dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgHienThi.ColumnHeadersHeight = 50;
            dtgHienThi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dtgHienThi.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // màu vàng
            dtgHienThi.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9);
            dtgHienThi.DefaultCellStyle.ForeColor = Color.White;
            dtgHienThi.RowTemplate.Height = 60;
            dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.;
            dtgHienThi.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter };
            dtgHienThi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            hocsinhsss.Xem(dtgHienThi);
        }

        HocSinhBUS hocsinhsss = new HocSinhBUS();
        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        HocSinhDTO HocSinh = new HocSinhDTO();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text != "" && txtTenHS.Text != "" && txtMaLopHoc.Text != "" && txtAge.Text != "" && txtTrangThai.Text != "")
            {
                HocSinh.MaHS = txtMaHS.Text;
                HocSinh.TenHS = txtTenHS.Text;
                HocSinh.MaLop = txtMaLopHoc.Text;
                HocSinh.Tuoi = int.Parse(txtAge.Text);
                HocSinh.TrangThai = txtTrangThai.Text;       
                
                bool result = HocSinhBUS.Instance.ThemHocSinh(HocSinh);
                if (result)
                {
                    MessageBox.Show("Thêm Học Sinh thành công!");
                    hocsinhsss.Xem(dtgHienThi);

                }
                else
                {
                    MessageBox.Show("Thêm Học Sinh Thất Bại!");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text != "" && txtTenHS.Text != "" && txtMaLopHoc.Text != "" && txtAge.Text != "" && txtTrangThai.Text != "")
            {
                HocSinh.MaHS = txtMaHS.Text;
                HocSinh.TenHS = txtTenHS.Text;
                HocSinh.MaLop = txtMaLopHoc.Text;
                HocSinh.Tuoi = int.Parse(txtAge.Text);
                HocSinh.TrangThai = txtTrangThai.Text;
                bool result = HocSinhBUS.Instance.SuaHocSinh(HocSinh);

                if (result)
                {
                    MessageBox.Show("Sửa thông tin học sinh thành công!");
                    hocsinhsss.Xem(dtgHienThi);

                }
                else
                {
                    MessageBox.Show("Sửa thông tin học sinh thất bại!");
                }

            }else
            {
                MessageBox.Show("Không được để trống!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Nhập Mã Học sinh!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


            string maHS = txtMaHS.Text.Trim();
         
            // Xác nhận lại việc xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa học sinh có mã " + maHS + "?" ,"Question?",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi phương thức XoaSoYeuLyLich từ lớp BUS để xóa sơ yếu lý lịch
                if (HocSinhBUS.Instance.XoaHocSinh(maHS))
                {
                    MessageBox.Show("Xóa học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hocsinhsss.Xem(dtgHienThi);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private HocSinhBUS HocSinhbus = new HocSinhBUS();
        private void btnXem_Click(object sender, EventArgs e)
        {
            //List<HocSinhDTO> HocSinhs = HocSinhbus.GetDiemSos();

            //dtgHienThi.DataSource = HocSinhs;

            hocsinhsss.Xem(dtgHienThi);
        }

        private void frmQuanlyhocsinh_Load(object sender, EventArgs e)
        {
            List<HocSinhDTO> HocSinhs = HocSinhbus.GetDiemSos();

            dtgHienThi.DataSource = HocSinhs;
        }

        private void dtgHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
