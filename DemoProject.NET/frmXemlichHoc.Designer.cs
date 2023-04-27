namespace DemoProject.NET
{
    partial class frmXemlichHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dtgHIenThi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnXuatLichhoc = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaHocPhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenHocPhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cbCaHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtGiaoVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtLichHoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbThu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaLopIN = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnXem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHIenThi)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // dtgHIenThi
            // 
            this.dtgHIenThi.AllowUserToResizeColumns = false;
            this.dtgHIenThi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgHIenThi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHIenThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgHIenThi.ColumnHeadersHeight = 4;
            this.dtgHIenThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHIenThi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgHIenThi.GridColor = System.Drawing.Color.White;
            this.dtgHIenThi.Location = new System.Drawing.Point(1, 303);
            this.dtgHIenThi.Name = "dtgHIenThi";
            this.dtgHIenThi.RowHeadersVisible = false;
            this.dtgHIenThi.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgHIenThi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgHIenThi.RowTemplate.Height = 24;
            this.dtgHIenThi.Size = new System.Drawing.Size(1137, 372);
            this.dtgHIenThi.TabIndex = 0;
            this.dtgHIenThi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgHIenThi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgHIenThi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgHIenThi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgHIenThi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgHIenThi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgHIenThi.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgHIenThi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgHIenThi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgHIenThi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgHIenThi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgHIenThi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgHIenThi.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgHIenThi.ThemeStyle.ReadOnly = false;
            this.dtgHIenThi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgHIenThi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgHIenThi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgHIenThi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgHIenThi.ThemeStyle.RowsStyle.Height = 24;
            this.dtgHIenThi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgHIenThi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgHIenThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // btnXuatLichhoc
            // 
            this.btnXuatLichhoc.BackColor = System.Drawing.Color.Transparent;
            this.btnXuatLichhoc.BorderRadius = 4;
            this.btnXuatLichhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatLichhoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatLichhoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatLichhoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatLichhoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatLichhoc.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnXuatLichhoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatLichhoc.ForeColor = System.Drawing.Color.White;
            this.btnXuatLichhoc.Location = new System.Drawing.Point(982, 681);
            this.btnXuatLichhoc.Name = "btnXuatLichhoc";
            this.btnXuatLichhoc.Size = new System.Drawing.Size(156, 37);
            this.btnXuatLichhoc.TabIndex = 14;
            this.btnXuatLichhoc.Text = "Xuất Lịch Học";
            this.btnXuatLichhoc.UseTransparentBackground = true;
            this.btnXuatLichhoc.Click += new System.EventHandler(this.btnXuatLichhoc_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(20, 100);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(193, 20);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "Mã học phần";
            // 
            // txtMaHocPhan
            // 
            this.txtMaHocPhan.Animated = true;
            this.txtMaHocPhan.BackColor = System.Drawing.Color.White;
            this.txtMaHocPhan.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtMaHocPhan.BorderRadius = 4;
            this.txtMaHocPhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHocPhan.DefaultText = "";
            this.txtMaHocPhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHocPhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHocPhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHocPhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHocPhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHocPhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaHocPhan.ForeColor = System.Drawing.Color.Black;
            this.txtMaHocPhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHocPhan.Location = new System.Drawing.Point(24, 124);
            this.txtMaHocPhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHocPhan.Name = "txtMaHocPhan";
            this.txtMaHocPhan.PasswordChar = '\0';
            this.txtMaHocPhan.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMaHocPhan.PlaceholderText = "Mã học phần..";
            this.txtMaHocPhan.SelectedText = "";
            this.txtMaHocPhan.Size = new System.Drawing.Size(217, 47);
            this.txtMaHocPhan.TabIndex = 21;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(21, 194);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(193, 20);
            this.gunaLabel1.TabIndex = 17;
            this.gunaLabel1.Text = "Tên học phần";
            // 
            // txtTenHocPhan
            // 
            this.txtTenHocPhan.Animated = true;
            this.txtTenHocPhan.BackColor = System.Drawing.Color.White;
            this.txtTenHocPhan.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtTenHocPhan.BorderRadius = 4;
            this.txtTenHocPhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHocPhan.DefaultText = "";
            this.txtTenHocPhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenHocPhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenHocPhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHocPhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHocPhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHocPhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenHocPhan.ForeColor = System.Drawing.Color.Black;
            this.txtTenHocPhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHocPhan.Location = new System.Drawing.Point(25, 218);
            this.txtTenHocPhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHocPhan.Name = "txtTenHocPhan";
            this.txtTenHocPhan.PasswordChar = '\0';
            this.txtTenHocPhan.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenHocPhan.PlaceholderText = "Tên học phần..";
            this.txtTenHocPhan.SelectedText = "";
            this.txtTenHocPhan.Size = new System.Drawing.Size(496, 47);
            this.txtTenHocPhan.TabIndex = 21;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.White;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(300, 100);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(193, 20);
            this.gunaLabel4.TabIndex = 17;
            this.gunaLabel4.Text = "Mã lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Animated = true;
            this.txtMaLop.BackColor = System.Drawing.Color.White;
            this.txtMaLop.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtMaLop.BorderRadius = 4;
            this.txtMaLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLop.DefaultText = "";
            this.txtMaLop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLop.ForeColor = System.Drawing.Color.Black;
            this.txtMaLop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLop.Location = new System.Drawing.Point(304, 124);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.PasswordChar = '\0';
            this.txtMaLop.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMaLop.PlaceholderText = "Mã lớp..";
            this.txtMaLop.SelectedText = "";
            this.txtMaLop.Size = new System.Drawing.Size(217, 47);
            this.txtMaLop.TabIndex = 21;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.BackColor = System.Drawing.Color.White;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(300, 13);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(193, 20);
            this.gunaLabel5.TabIndex = 17;
            this.gunaLabel5.Text = "Ca học";
            // 
            // cbCaHoc
            // 
            this.cbCaHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbCaHoc.BorderColor = System.Drawing.Color.DarkOrchid;
            this.cbCaHoc.BorderRadius = 4;
            this.cbCaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCaHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCaHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCaHoc.ForeColor = System.Drawing.Color.Black;
            this.cbCaHoc.ItemHeight = 30;
            this.cbCaHoc.Items.AddRange(new object[] {
            "Sáng-Chiều",
            "Chiều-Tối",
            "Sáng-Tối",
            "Sáng",
            "Chiều",
            "Tối"});
            this.cbCaHoc.Location = new System.Drawing.Point(304, 37);
            this.cbCaHoc.Name = "cbCaHoc";
            this.cbCaHoc.Size = new System.Drawing.Size(217, 36);
            this.cbCaHoc.TabIndex = 18;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.BackColor = System.Drawing.Color.White;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(617, 13);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(193, 20);
            this.gunaLabel6.TabIndex = 17;
            this.gunaLabel6.Text = "Giáo viên";
            // 
            // txtGiaoVien
            // 
            this.txtGiaoVien.Animated = true;
            this.txtGiaoVien.BackColor = System.Drawing.Color.White;
            this.txtGiaoVien.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtGiaoVien.BorderRadius = 4;
            this.txtGiaoVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaoVien.DefaultText = "";
            this.txtGiaoVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaoVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaoVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaoVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaoVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaoVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaoVien.ForeColor = System.Drawing.Color.Black;
            this.txtGiaoVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaoVien.Location = new System.Drawing.Point(621, 37);
            this.txtGiaoVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaoVien.Name = "txtGiaoVien";
            this.txtGiaoVien.PasswordChar = '\0';
            this.txtGiaoVien.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtGiaoVien.PlaceholderText = "Tên giáo viên..";
            this.txtGiaoVien.SelectedText = "";
            this.txtGiaoVien.Size = new System.Drawing.Size(512, 47);
            this.txtGiaoVien.TabIndex = 21;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BackColor = System.Drawing.Color.White;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(617, 100);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(193, 20);
            this.gunaLabel7.TabIndex = 17;
            this.gunaLabel7.Text = "Lịch học";
            // 
            // txtLichHoc
            // 
            this.txtLichHoc.Animated = true;
            this.txtLichHoc.BackColor = System.Drawing.Color.White;
            this.txtLichHoc.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtLichHoc.BorderRadius = 4;
            this.txtLichHoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLichHoc.DefaultText = "";
            this.txtLichHoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLichHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLichHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLichHoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLichHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLichHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLichHoc.ForeColor = System.Drawing.Color.Black;
            this.txtLichHoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLichHoc.Location = new System.Drawing.Point(621, 124);
            this.txtLichHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLichHoc.Name = "txtLichHoc";
            this.txtLichHoc.PasswordChar = '\0';
            this.txtLichHoc.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtLichHoc.PlaceholderText = "Lịch học..";
            this.txtLichHoc.SelectedText = "";
            this.txtLichHoc.Size = new System.Drawing.Size(512, 47);
            this.txtLichHoc.TabIndex = 21;
            // 
            // cbThu
            // 
            this.cbThu.BackColor = System.Drawing.Color.Transparent;
            this.cbThu.BorderColor = System.Drawing.Color.DarkOrchid;
            this.cbThu.BorderRadius = 4;
            this.cbThu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbThu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbThu.ForeColor = System.Drawing.Color.Black;
            this.cbThu.ItemHeight = 30;
            this.cbThu.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư ",
            "Thứ năm",
            "Thứ sáu",
            "Thứ bảy",
            "Chủ nhật"});
            this.cbThu.Location = new System.Drawing.Point(25, 37);
            this.cbThu.Name = "cbThu";
            this.cbThu.Size = new System.Drawing.Size(217, 36);
            this.cbThu.TabIndex = 18;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.White;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(21, 13);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(193, 20);
            this.gunaLabel3.TabIndex = 16;
            this.gunaLabel3.Text = "Thứ";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.BackColor = System.Drawing.Color.White;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(617, 194);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(193, 20);
            this.gunaLabel8.TabIndex = 17;
            this.gunaLabel8.Text = "Tên lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Animated = true;
            this.txtTenLop.BackColor = System.Drawing.Color.White;
            this.txtTenLop.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtTenLop.BorderRadius = 4;
            this.txtTenLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLop.DefaultText = "";
            this.txtTenLop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLop.ForeColor = System.Drawing.Color.Black;
            this.txtTenLop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLop.Location = new System.Drawing.Point(621, 218);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.PasswordChar = '\0';
            this.txtTenLop.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenLop.PlaceholderText = "Tên lớp..";
            this.txtTenLop.SelectedText = "";
            this.txtTenLop.Size = new System.Drawing.Size(289, 47);
            this.txtTenLop.TabIndex = 21;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnSua.BorderRadius = 4;
            this.btnSua.BorderThickness = 1;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(977, 226);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(156, 39);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseTransparentBackground = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaLopIN
            // 
            this.txtMaLopIN.Animated = true;
            this.txtMaLopIN.BackColor = System.Drawing.Color.White;
            this.txtMaLopIN.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtMaLopIN.BorderRadius = 4;
            this.txtMaLopIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLopIN.DefaultText = "";
            this.txtMaLopIN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLopIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLopIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLopIN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLopIN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLopIN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLopIN.ForeColor = System.Drawing.Color.Black;
            this.txtMaLopIN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLopIN.Location = new System.Drawing.Point(892, 682);
            this.txtMaLopIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLopIN.Name = "txtMaLopIN";
            this.txtMaLopIN.PasswordChar = '\0';
            this.txtMaLopIN.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMaLopIN.PlaceholderText = "Mã lớp..";
            this.txtMaLopIN.SelectedText = "";
            this.txtMaLopIN.Size = new System.Drawing.Size(110, 35);
            this.txtMaLopIN.TabIndex = 21;
            // 
            // BtnXem
            // 
            this.BtnXem.BackColor = System.Drawing.Color.Transparent;
            this.BtnXem.BorderColor = System.Drawing.Color.DarkOrchid;
            this.BtnXem.BorderRadius = 4;
            this.BtnXem.BorderThickness = 1;
            this.BtnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnXem.FillColor = System.Drawing.Color.DarkOrchid;
            this.BtnXem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXem.ForeColor = System.Drawing.Color.White;
            this.BtnXem.Location = new System.Drawing.Point(977, 226);
            this.BtnXem.Name = "BtnXem";
            this.BtnXem.Size = new System.Drawing.Size(156, 39);
            this.BtnXem.TabIndex = 14;
            this.BtnXem.Text = "Xem";
            this.BtnXem.UseTransparentBackground = true;
            this.BtnXem.Click += new System.EventHandler(this.BtnXem_Click);
            // 
            // frmXemlichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 730);
            this.Controls.Add(this.txtTenHocPhan);
            this.Controls.Add(this.txtGiaoVien);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtLichHoc);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtMaHocPhan);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cbCaHoc);
            this.Controls.Add(this.cbThu);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.BtnXem);
            this.Controls.Add(this.dtgHIenThi);
            this.Controls.Add(this.btnXuatLichhoc);
            this.Controls.Add(this.txtMaLopIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXemlichHoc";
            this.Text = "frmXemlichHoc";
            this.Load += new System.EventHandler(this.frmXemlichHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHIenThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgHIenThi;
        private Guna.UI2.WinForms.Guna2Button btnXuatLichhoc;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHocPhan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHocPhan;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLop;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaoVien;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox cbCaHoc;
        private Guna.UI2.WinForms.Guna2TextBox txtLichHoc;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLop;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox cbThu;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLopIN;
        private Guna.UI2.WinForms.Guna2Button BtnXem;
    }
}