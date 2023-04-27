namespace DemoProject.NET
{
    partial class frmQuanlyLophoc
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
            this.dtgHienThi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtTenLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTrangThai = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienThi)).BeginInit();
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
            // dtgHienThi
            // 
            this.dtgHienThi.AllowUserToResizeColumns = false;
            this.dtgHienThi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgHienThi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgHienThi.ColumnHeadersHeight = 4;
            this.dtgHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHienThi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgHienThi.GridColor = System.Drawing.Color.White;
            this.dtgHienThi.Location = new System.Drawing.Point(3, 12);
            this.dtgHienThi.Name = "dtgHienThi";
            this.dtgHienThi.RowHeadersVisible = false;
            this.dtgHienThi.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgHienThi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgHienThi.RowTemplate.Height = 24;
            this.dtgHienThi.Size = new System.Drawing.Size(1147, 480);
            this.dtgHienThi.TabIndex = 32;
            this.dtgHienThi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgHienThi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgHienThi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgHienThi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgHienThi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgHienThi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgHienThi.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgHienThi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgHienThi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgHienThi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgHienThi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgHienThi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgHienThi.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgHienThi.ThemeStyle.ReadOnly = false;
            this.dtgHienThi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgHienThi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgHienThi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgHienThi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgHienThi.ThemeStyle.RowsStyle.Height = 24;
            this.dtgHienThi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgHienThi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgHienThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHienThi_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnXoa.BorderRadius = 4;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnXoa.Location = new System.Drawing.Point(783, 642);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(343, 64);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseTransparentBackground = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(783, 549);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(153, 49);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseTransparentBackground = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnThem.BorderRadius = 4;
            this.btnThem.BorderThickness = 1;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(973, 549);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 49);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseTransparentBackground = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.White;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(30, 610);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 28);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.Text = "Tên lớp";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.White;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(434, 502);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(141, 28);
            this.gunaLabel4.TabIndex = 25;
            this.gunaLabel4.Text = "Trạng thái";
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
            this.txtTenLop.Location = new System.Drawing.Point(34, 642);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.PasswordChar = '\0';
            this.txtTenLop.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenLop.PlaceholderText = "Tên lớp..";
            this.txtTenLop.SelectedText = "";
            this.txtTenLop.Size = new System.Drawing.Size(300, 64);
            this.txtTenLop.TabIndex = 20;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Animated = true;
            this.txtTrangThai.BackColor = System.Drawing.Color.White;
            this.txtTrangThai.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtTrangThai.BorderRadius = 4;
            this.txtTrangThai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrangThai.DefaultText = "";
            this.txtTrangThai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrangThai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrangThai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrangThai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrangThai.ForeColor = System.Drawing.Color.Black;
            this.txtTrangThai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrangThai.Location = new System.Drawing.Point(438, 534);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.PasswordChar = '\0';
            this.txtTrangThai.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTrangThai.PlaceholderText = "Trạng thái..";
            this.txtTrangThai.SelectedText = "";
            this.txtTrangThai.Size = new System.Drawing.Size(300, 64);
            this.txtTrangThai.TabIndex = 21;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.White;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(30, 502);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 28);
            this.gunaLabel3.TabIndex = 19;
            this.gunaLabel3.Text = "Mã lớp ";
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
            this.txtMaLop.Location = new System.Drawing.Point(34, 534);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.PasswordChar = '\0';
            this.txtMaLop.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMaLop.PlaceholderText = "Mã lớp..";
            this.txtMaLop.SelectedText = "";
            this.txtMaLop.Size = new System.Drawing.Size(344, 64);
            this.txtMaLop.TabIndex = 18;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Animated = true;
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtGhiChu.BorderRadius = 4;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Location = new System.Drawing.Point(394, 642);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtGhiChu.PlaceholderText = "Ghi chú..";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(344, 64);
            this.txtGhiChu.TabIndex = 21;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(390, 610);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(306, 28);
            this.gunaLabel1.TabIndex = 25;
            this.gunaLabel1.Text = "Ghi chú";
            // 
            // frmQuanlyLophoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 730);
            this.Controls.Add(this.dtgHienThi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtMaLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanlyLophoc";
            this.Text = "frmQuanlyLophoc";
            this.Load += new System.EventHandler(this.frmQuanlyLophoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLop;
        private Guna.UI2.WinForms.Guna2TextBox txtTrangThai;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLop;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2DataGridView dtgHienThi;
    }
}