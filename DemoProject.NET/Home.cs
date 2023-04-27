using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.Logging;
using DAL;

namespace DemoProject.NET
{
    public partial class frmHome : Form
    {
        public GunaButton previousButton = null;

        public frmHome()
        {
            InitializeComponent();
            //btnSoYeuLiLich.PerformClick();
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
            ChildForm.Dock= DockStyle.Fill;
            pnForm.Controls.Add(ChildForm);
            pnForm.Tag = ChildForm;
            
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
            gunaElipsePanel1.Visible = false;
            lblHienThiName.Text = "TiếnAnh";
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //picHome.Visible = true;
           
        }


        
        private void btnTailieu_Click(object sender, EventArgs e)
        {
            //picHome.Visible = true;
            btnMenu.Visible = true;

            if (previousButton != null && previousButton != btnSoYeuLiLich)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnSoYeuLiLich.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnSoYeuLiLich;

            OpenChildForm(new frmSoyeulylich());
            lblHienthi.Text = btnSoYeuLiLich.Text;
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void menuChoice_Opening(object sender, CancelEventArgs e)
        {
         
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
          

        }

        private void menuThem_Click(object sender, EventArgs e)
        {

        }

        private void menuChoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
           

            btnMenu.Visible = true;
            if (previousButton != null && previousButton != btnDiem)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnDiem.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnDiem;
            OpenChildForm(new frmDiemSoHS());
            lblHienthi.Text = btnDiem.Text;

           
        }

        private void btnHocsinh_Click(object sender, EventArgs e)
        {
           

            btnMenu.Visible = true;

            if (previousButton != null && previousButton != btnHocsinh)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnHocsinh.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnHocsinh;
            OpenChildForm(new frmQuanlyhocsinh());
            lblHienthi.Text = btnHocsinh.Text;
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
         

            btnMenu.Visible = true;
            if (previousButton != null && previousButton != btnGiaovien)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnGiaovien.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnGiaovien;
            OpenChildForm(new frmQuanlyGiaovien());
            lblHienthi.Text = btnGiaovien.Text;
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            

            if (previousButton != null && previousButton != btnLopHoc)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnLopHoc.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnLopHoc;

            OpenChildForm(new frmQuanlyLophoc());
            lblHienthi.Text = btnLopHoc.Text;
        }

        private void btnThoikhoabieu_Click(object sender, EventArgs e)
        {
           

            if (previousButton != null && previousButton != btnThoikhoabieu)
            {
                previousButton.BaseColor = Color.FromArgb(52, 58, 64);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnThoikhoabieu.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnThoikhoabieu;
            OpenChildForm(new frmXemlichHoc());
            lblHienthi.Text = btnThoikhoabieu.Text;

        }

     

        private void gunaButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            btnTk.ContextMenuStrip = menuTK;
            btnTk.ContextMenuStrip.Show(btnTk, new Point(0, btnTk.Height));

        }

        private void menuTK_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void mnstChoice_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           if (gunaElipsePanel1.Visible == false)
            {
                gunaElipsePanel1.Visible = true;

            }
            else
            {
                gunaElipsePanel1.Visible = false;

            }
        }

        private void gunaControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void dtgHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemTL_Click(object sender, EventArgs e)
        {
           
        }
        
        LopHocBUS bus = new LopHocBUS();
        HocSinhBUS HocSinhBUS = new HocSinhBUS();
        GiaoVienBUS GiaoVienBUS = new GiaoVienBUS();
        DiemSoBUS DiemSoBUS = new DiemSoBUS();
        SoYeuLyLichBUS SoYeuLyLichBUS = new SoYeuLyLichBUS();
        LichHocBUS LichHocBUS = new LichHocBUS();
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            if (previousButton == btnLopHoc) {
                if (txtTimKiem.Text != "")
                {
                    string TimKiem = txtTimKiem.Text;

                    // Gọi phương thức tìm kiếm của lớp BUS và lấy kết quả trả về
                    List<LopDTO> results = bus.TK(TimKiem);

                    // Truyền dữ liệu vào DataGridView của form con
                    frmKQTK frmQLLH = new frmKQTK();
                    frmQLLH.dgvHienThi.DataSource = results;
                    frmQLLH.lblTimKiem.Text = "Tìm kiếm lớp học";
                    frmQLLH.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã lớp học!");
                }
            }
            if (previousButton == btnHocsinh)
            {
                if (txtTimKiem.Text != "")
                {
                    string TimKiem = txtTimKiem.Text;

                    // Gọi phương thức tìm kiếm của lớp BUS và lấy kết quả trả về
                    List<HocSinhDTO> results = HocSinhBUS.TK(TimKiem);

                    // Truyền dữ liệu vào DataGridView của form con
                    frmKQTK frmQLLH = new frmKQTK();
                    frmQLLH.dgvHienThi.DataSource = results;
                    frmQLLH.lblTimKiem.Text = "Tìm kiếm học sinh";
                    frmQLLH.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy học sinh!");
                }
            }
            if (previousButton == btnGiaovien)
            {
                if (txtTimKiem.Text != "")
                {
                    string TimKiem = txtTimKiem.Text;

                    // Gọi phương thức tìm kiếm của lớp BUS và lấy kết quả trả về
                    List<GiaoVienDTO> results = GiaoVienBUS.TK(TimKiem);

                    // Truyền dữ liệu vào DataGridView của form con
                    frmKQTK frmQLLH = new frmKQTK();
                    frmQLLH.dgvHienThi.DataSource = results;
                    frmQLLH.lblTimKiem.Text = "Tìm kiếm giáo viên";
                    frmQLLH.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giáo viên!");
                }
            } if (previousButton == btnDiem)
            {
                if (txtTimKiem.Text != "")
                {
                    string TimKiem = txtTimKiem.Text;

                    // Gọi phương thức tìm kiếm của lớp BUS và lấy kết quả trả về
                    List<DiemSoDTO> results = DiemSoBUS.TK(TimKiem);

                    // Truyền dữ liệu vào DataGridView của form con
                    frmKQTK frmQLLH = new frmKQTK();
                    frmQLLH.dgvHienThi.DataSource = results;
                    frmQLLH.lblTimKiem.Text = "Tìm kiếm điểm số";
                    frmQLLH.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy điểm số!");
                }
            } if (previousButton == btnSoYeuLiLich)
            {
                if (txtTimKiem.Text != "")
                {
                    string TimKiem = txtTimKiem.Text;

                    // Gọi phương thức tìm kiếm của lớp BUS và lấy kết quả trả về
                    List<SoYeuLyLichDTO> results = SoYeuLyLichBUS.TK(TimKiem);

                    // Truyền dữ liệu vào DataGridView của form con
                    frmKQTK frmQLLH = new frmKQTK();
                    frmQLLH.dgvHienThi.DataSource = results;
                    frmQLLH.dgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    frmQLLH.lblTimKiem.Text = "Tìm kiếm sơ yếu lý lịch";
                    frmQLLH.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!");
                }
            } if (previousButton == btnThoikhoabieu)
            {
                if (txtTimKiem.Text != "")
                {
                    string TimKiem = txtTimKiem.Text;

                    // Gọi phương thức tìm kiếm của lớp BUS và lấy kết quả trả về
                    List<LichHocDTO> results = LichHocBUS.TK(TimKiem);

                    // Truyền dữ liệu vào DataGridView của form con
                    frmKQTK frmQLLH = new frmKQTK();
                    frmQLLH.dgvHienThi.DataSource = results;
                    frmQLLH.lblTimKiem.Text = "Tìm kiếm lịch học";
                    frmQLLH.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!");
                }
            }
        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvHienThiTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnMenuchoice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuTK_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?" ,"Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
           

            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }
            lblHienthi.Text = "Home";
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnForm_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
