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
    public partial class frmXemlichHoc : Form
    {
        public frmXemlichHoc()
        {
            InitializeComponent();
            dtgHIenThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgHIenThi.ColumnHeadersHeight = 50;
            dtgHIenThi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dtgHIenThi.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // màu vàng
            dtgHIenThi.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9);
            dtgHIenThi.DefaultCellStyle.ForeColor = Color.Black;
            dtgHIenThi.RowTemplate.Height = 60;
            dtgHIenThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.;
            dtgHIenThi.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter };
            dtgHIenThi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lichhocsss.Xem(dtgHIenThi);

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private LichHocBUS bll = new LichHocBUS();

        LichHocBUS lichhocsss = new LichHocBUS();
        private void BtnXem_Click(object sender, EventArgs e)
        {
            lichhocsss.Xem(dtgHIenThi);
            //List<LichHocDTO> lichHocSS = bll.getLichHoc();

            //dtgHIenThi.DataSource = lichHocSS;
        }

        private void frmXemlichHoc_Load(object sender, EventArgs e)
        {
            List<LichHocDTO> lichHocSS = bll.getLichHoc();

            dtgHIenThi.DataSource = lichHocSS;
        }
        LichHocDTO LichHocSSS = new LichHocDTO();

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHocPhan.Text != "" && txtMaLop.Text != "")
            {              
                    LichHocSSS.MaHP = txtMaHocPhan.Text;
                    LichHocSSS.TenHP = txtTenHocPhan.Text;
                    LichHocSSS.MaLop = txtMaLop.Text;
                    LichHocSSS.CaHoc = cbCaHoc.SelectedItem.ToString();
                    LichHocSSS.Thu = cbThu.SelectedItem.ToString();
                    LichHocSSS.TenGV = txtGiaoVien.Text;
                    LichHocSSS.LichHoc = txtLichHoc.Text;                 
                    LichHocSSS.TenLop = txtTenLop.Text;
                    bool result = LichHocBUS.Instance.SuaLichHoc(LichHocSSS);
                    if (result)
                    {
                        MessageBox.Show("Sửa thông tin lịch học thành công!");
                        List<LichHocDTO> lichHocSS = bll.getLichHoc();
                        dtgHIenThi.DataSource = lichHocSS;

                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin lịch học thất bại!");
                    }
              

            }
            else
            {
                MessageBox.Show("Mã học phần và mã lớp không đúng!");
            }
        }

        private void btnXuatLichhoc_Click(object sender, EventArgs e)
        {
            string MaLop = txtMaLopIN.Text;

            if (txtMaLopIN.Text == "")
            {
                MessageBox.Show("Hãy Nhập Mã Lớp!");
            }
            else
            {

                DataTable dt = LichHocBUS.Instance.GetLichHocBUS(MaLop);
                rpLichHocLop r = new rpLichHocLop();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy lịch học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
