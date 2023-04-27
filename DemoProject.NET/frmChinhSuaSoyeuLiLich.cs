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
    public partial class frmChinhSuaSoyeuLiLich : Form
    {
        public frmChinhSuaSoyeuLiLich()
        {
            InitializeComponent();
        }

       

        private void frmChinhSuaSoyeuLiLich_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {   
            if (txtXoa.Text == "")
            {
                MessageBox.Show("Nhập ID Trước!","Confirm",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string maHS = txtXoa.Text.Trim();

            // Xác nhận lại việc xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sơ yếu lý lịch của học sinh có mã " + maHS + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi phương thức XoaSoYeuLyLich từ lớp BUS để xóa sơ yếu lý lịch
                if (SoYeuLyLichBUS.Instance.XoaSoYeuLyLich(maHS))
                {
                    MessageBox.Show("Xóa sơ yếu lý lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Sau khi xóa thành công, ta sẽ làm mới các controls và hiển thị lại danh sách sơ yếu lý lịch
                    
                }
                else
                {
                    MessageBox.Show("Xóa sơ yếu lý lịch thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMHS.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtNgaySinh.Text) || string.IsNullOrEmpty(txtNGayvaoDoan.Text) || string.IsNullOrEmpty(txtNgayVaoDang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            SoYeuLyLichDTO sll = new SoYeuLyLichDTO();

            sll.MaHS = txtMHS.Text;
            sll.HoTen = txtHoTen.Text;
            sll.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
            sll.GioiTinh = txtGioiTinh.Text;
            sll.NoiSinh = txtNoiSinh.Text;
            sll.QueQuan = txtQueQuan.Text;
            sll.DanToc = txtDanToc.Text;
            sll.QuocTich = txtQuocTich.Text;
            sll.TonGiao = txtTonGiao.Text;
            sll.TPXuatThan = txtXuatThan.Text;
            sll.NgayVaoDoan = DateTime.Parse( txtNGayvaoDoan.Text);
            sll.NgayVaoDang = DateTime.Parse( txtNgayVaoDang.Text);
            sll.NoiThuongTru = txtNoiThuongTru.Text;
            sll.XaPhuong = txtXxPhuong.Text;
            sll.QuanHuyen = txtQuanHuyen.Text;
            sll.TinhThanhPho = txtTinhTp.Text;
            sll.DoiTuongCS = txtDoiTuong.Text;
            sll.DoiTuongTroCap = txtDoiTuongTroCap.Text;
            sll.NhomDT = txtNhomDT.Text;
            sll.DienThoaiNhaRieng = txtDtnhaRieng.Text;
            sll.DienThoaiCaNhan = txtDienThoaiCaNhan.Text;
            sll.Email = txtEmail.Text;
            sll.SoCMND = txtSoCMND.Text;
            sll.DiaChiBaoTin = txtDiaChiBaoTin.Text;
            sll.NoiOHienNay = txtNoioHienNay.Text;

            bool result = SoYeuLyLichBUS.Instance.AddSoYeuLyLich(sll);

            if (result)
            {
                MessageBox.Show("Thêm sơ yếu lý lịch thành công");
               
            }
            else
            {
                MessageBox.Show("Thêm sơ yếu lý lịch không thành công");
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMHS.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thông tin học sinh");
                return;
            }
            SoYeuLyLichDTO sll = new SoYeuLyLichDTO();
            sll.MaHS = txtMHS.Text;
            sll.HoTen = txtHoTen.Text;
            sll.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
            sll.GioiTinh = txtGioiTinh.Text;
            sll.NoiSinh = txtNoiSinh.Text;
            sll.QueQuan = txtQueQuan.Text;
            sll.DanToc = txtDanToc.Text;
            sll.QuocTich = txtQuocTich.Text;
            sll.TonGiao = txtTonGiao.Text;
            sll.TPXuatThan = txtXuatThan.Text;
            sll.NgayVaoDoan = DateTime.Parse(txtNGayvaoDoan.Text);
            sll.NgayVaoDang = DateTime.Parse(txtNgayVaoDang.Text);
            sll.NoiThuongTru = txtNoiThuongTru.Text;
            sll.XaPhuong = txtXxPhuong.Text;
            sll.QuanHuyen = txtQuanHuyen.Text;
            sll.TinhThanhPho = txtTinhTp.Text;
            sll.DoiTuongCS = txtDoiTuong.Text;
            sll.DoiTuongTroCap = txtDoiTuongTroCap.Text;
            sll.NhomDT = txtNhomDT.Text;
            sll.DienThoaiNhaRieng = txtDtnhaRieng.Text;
            sll.DienThoaiCaNhan = txtDienThoaiCaNhan.Text;
            sll.Email = txtEmail.Text;
            sll.SoCMND = txtSoCMND.Text;
            sll.DiaChiBaoTin = txtDiaChiBaoTin.Text;
            sll.NoiOHienNay = txtNoioHienNay.Text;

            bool result = SoYeuLyLichBUS.Instance.SuaSoYeuLyLichBUS(sll);

            if (result)
            {
                MessageBox.Show("Sửa sơ yếu lý lịch thành công!");

            }
            else
            {
                MessageBox.Show("Sửa sơ yếu lý lịch thất bại!");
            }
        }
    }
}
