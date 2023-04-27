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
    public partial class frmDiemSoHS : Form
    {
       
        public frmDiemSoHS()
        {
            InitializeComponent();
            
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string Mahs = txtBCmaHS.Text;
            string HocKy = cbHocKy.Text;
            string namHoc = cbNamhoc.Text;

            if (txtBCmaHS.Text == ""  )
            {
                MessageBox.Show("Hãy Nhập Mã Học Sinh!");
                return;
            }
            if (cbHocKy.Text == "")
            {
                MessageBox.Show("Hãy Nhập Học Kỳ!");
                return;
            }
            if (cbNamhoc.Text == "")
            {
                MessageBox.Show("Hãy Nhập Năm Học!");
                return;
            }
            else
            {
                DataTable dt = DiemSoBUS.Instance.GetDiemSoBUS(Mahs, HocKy, namHoc);
                rpDiemSoHS r = new rpDiemSoHS();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy điểm học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                // Set DataSource cho report document
                r.SetDataSource(dt);

                // Hiển thị form báo cáo
                frmBaoCao frm = new frmBaoCao();
                frm.crystalReportViewer1.ReportSource = r;
                frm.ShowDialog();
            }


           
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            frmHome frmLogin = new frmHome();
            Form existingForm = Application.OpenForms.OfType<Form>().FirstOrDefault(f => f.GetType() == frmLogin.GetType());

            // Nếu form1 đã được mở, hiển thị lại form1
            if (existingForm != null)
            {
                existingForm.Show();
            }
        }
        DiemSoBUS diemSo = new DiemSoBUS();

        private void frmDiemSoHS_Load(object sender, EventArgs e)
        {
            dtgHienTHiDiemSo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgHienTHiDiemSo.ColumnHeadersHeight = 50;
            dtgHienTHiDiemSo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dtgHienTHiDiemSo.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // màu vàng
            dtgHienTHiDiemSo.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9);
            dtgHienTHiDiemSo.DefaultCellStyle.ForeColor = Color.Black;
            dtgHienTHiDiemSo.RowTemplate.Height = 60;
            dtgHienTHiDiemSo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.;
            dtgHienTHiDiemSo.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter };
            dtgHienTHiDiemSo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

           
            // 2 cách hiển thị // cách 1

            diemSo.Xem(dtgHienTHiDiemSo);

            // cách 2
            //List<DiemSoDTO> diemSos = bll.GetDiemSos();
            //dtgHienTHiDiemSo.DataSource = diemSos;
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXemTL_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHocPhan.Text != "" && txtMaHS.Text != "" && txtTenMonHoc.Text != "" && txtDiemSo.Text != "" && cboHocKy.SelectedItem != null && cboNamHoc.SelectedItem != null)
            {

                DiemSoDTO DiemSo = new DiemSoDTO();
                DiemSo.MaHP = txtMaHocPhan.Text;
                DiemSo.MaHs = txtMaHS.Text;
                DiemSo.TenHP = txtTenMonHoc.Text;
                DiemSo.DiemSo = float.Parse(txtDiemSo.Text);
                DiemSo.HocKy = cboHocKy.SelectedItem.ToString();
                DiemSo.NamHoc = cboNamHoc.SelectedItem.ToString();
                bool result = DiemSoBUS.Instance.AddDiemSo(DiemSo);
                if (result)
                {
                    MessageBox.Show("Thêm Điểm thành công!");
                    diemSo.Xem(dtgHienTHiDiemSo);

                }
                else
                {
                    MessageBox.Show("Thêm Điểm Thất Bại!");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống!");
            }

            

          
        }
        private DiemSoBUS bll = new DiemSoBUS();
        private void btnXem_Click(object sender, EventArgs e)
        {
            //List<DiemSoDTO> diemSos = bll.GetDiemSos();
            
            //dtgHienTHiDiemSo.DataSource = diemSos;
            diemSo.Xem(dtgHienTHiDiemSo);

        }

        private void dtgHienTHiDiemSo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHocPhan.Text) || string.IsNullOrEmpty(txtMaHS.Text) || string.IsNullOrEmpty(txtTenMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thông tin học sinh,mã và tên học phần");
                return;
            }
            DiemSoDTO sll = new DiemSoDTO();
            sll.MaHP = txtMaHocPhan.Text;
            sll.MaHs = txtMaHS.Text;
            sll.DiemSo = float.Parse(txtDiemSo.Text);
            sll.HocKy = cboHocKy.SelectedItem.ToString();
            sll.TenHP = txtTenMonHoc.Text;
            sll.NamHoc = cboNamHoc.SelectedItem.ToString();
          

            bool result = DiemSoBUS.Instance.SuaDiemSo(sll);

            if (result)
            {
                MessageBox.Show("Sửa Điểm số thành công!");
                diemSo.Xem(dtgHienTHiDiemSo);

            }
            else
            {
                MessageBox.Show("Sửa điểm số thất bại!");
            }
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            if (txtMaHocPhan.Text == "")
            {
                MessageBox.Show("Nhập ID Học phần!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } if (txtTenMonHoc.Text == "")
            {
                MessageBox.Show("Nhập Tên Học phần!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Nhập ID Học Sinh!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string maHS = txtMaHS.Text.Trim();
            string maHP = txtMaHocPhan.Text.Trim();
            string TenHP = txtTenMonHoc.Text.Trim();

            // Xác nhận lại việc xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa Điểm số của học sinh có mã " + maHS +", mã học phần "+ maHP + ", tên học phần là "+ TenHP+"?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Gọi phương thức XoaSoYeuLyLich từ lớp BUS để xóa sơ yếu lý lịch
                if (DiemSoBUS.Instance.XoaDiemSo(maHP, maHS, TenHP))
                {
                    MessageBox.Show("Xóa Điểm số thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    diemSo.Xem(dtgHienTHiDiemSo);
                    // Sau khi xóa thành công, ta sẽ làm mới các controls và hiển thị lại danh sách sơ yếu lý lịch

                }
                else
                {
                    MessageBox.Show("Xóa Điểm số thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
