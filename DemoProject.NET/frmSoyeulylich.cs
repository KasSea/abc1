using BUS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using DevExpress.XtraRichEdit.Import.Html;
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
    public partial class frmSoyeulylich : Form
    {
        public frmSoyeulylich()
        {
            InitializeComponent();
            dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgHienThi.ColumnHeadersHeight = 50;
            dtgHienThi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dtgHienThi.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // màu vàng
            dtgHienThi.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9);
            dtgHienThi.DefaultCellStyle.ForeColor = Color.White;
            dtgHienThi.RowTemplate.Height = 60;
            //dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.;
            dtgHienThi.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter };
            dtgHienThi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

           
            // Đổi tên header của tất cả các cộtx   
            // Đặt tên cho cột trong DataGridView

        }

        private Form currentFormchild;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }
            currentFormchild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnHienThiSYLY.Controls.Add(ChildForm);
            pnHienThiSYLY.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            dtgHienThi.Columns["HoTen"].HeaderText = "Họ và tên";
        }

        private void btnInsoyeulyLich_Click(object sender, EventArgs e)
        {
            string Mahs = txtID.Text;

            if (txtID.Text == "")
            {
                MessageBox.Show("Hãy Nhập Mã Học Sinh!");
            }

            DataTable dt = SoYeuLyLichBUS.Instance.GetSoYeuLyLich(Mahs);
            rptSoYeuLyLich r = new rptSoYeuLyLich();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hồ sơ sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // Set DataSource cho report document
            r.SetDataSource(dt);

            // Hiển thị form báo cáo
            frmBaoCao frm = new frmBaoCao();
            frm.crystalReportViewer1.ReportSource = r;
            frm.ShowDialog();
        

        }

    private void btnChinhSua_Click(object sender, EventArgs e)
        {

                dtgHienThi.Visible = false;

            OpenChildForm(new frmChinhSuaSoyeuLiLich());

        }

        private void frmSoyeulylich_Load(object sender, EventArgs e)
        {
            
            SoYeuLyLichBUS.Instance.Xem(dtgHienThi);
           

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dtgHienThi.Visible == false)
            {
                dtgHienThi.Visible = true;
                dtgHienThi.BringToFront();
               
            }   else
            {
                dtgHienThi.Visible = true;
                
            }

            SoYeuLyLichBUS.Instance.Xem(dtgHienThi);

        }

        private void dtgHienThi_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgHienThi_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu người dùng click vào header
          
        }

        private void dtgHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
