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
    public partial class frmKQTK : Form
    {
        public frmKQTK()
        {
            InitializeComponent();
            //dgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvHienThi.ColumnHeadersHeight = 50;
            dgvHienThi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dgvHienThi.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // màu vàng
            dgvHienThi.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9);
            dgvHienThi.DefaultCellStyle.ForeColor = Color.Black;
            dgvHienThi.RowTemplate.Height = 60;
            //dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dtgHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.;
            dgvHienThi.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter };
            dgvHienThi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
