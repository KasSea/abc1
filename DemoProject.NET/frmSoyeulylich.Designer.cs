namespace DemoProject.NET
{
    partial class frmSoyeulylich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnChinhSua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsoyeulyLich = new Guna.UI2.WinForms.Guna2Button();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHienThiSYLY = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgHienThi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.pnHienThiSYLY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Animated = true;
            this.btnChinhSua.BorderRadius = 4;
            this.btnChinhSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChinhSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChinhSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChinhSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChinhSua.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnChinhSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua.Location = new System.Drawing.Point(3, 14);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(176, 53);
            this.btnChinhSua.TabIndex = 2;
            this.btnChinhSua.Text = "Cập nhật";
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DarkOrchid;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(182, 14);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(196, 53);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Xem";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnInsoyeulyLich
            // 
            this.btnInsoyeulyLich.BorderRadius = 4;
            this.btnInsoyeulyLich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsoyeulyLich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsoyeulyLich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsoyeulyLich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsoyeulyLich.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnInsoyeulyLich.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsoyeulyLich.ForeColor = System.Drawing.Color.White;
            this.btnInsoyeulyLich.Location = new System.Drawing.Point(970, 14);
            this.btnInsoyeulyLich.Name = "btnInsoyeulyLich";
            this.btnInsoyeulyLich.PressedColor = System.Drawing.Color.Azure;
            this.btnInsoyeulyLich.Size = new System.Drawing.Size(176, 53);
            this.btnInsoyeulyLich.TabIndex = 2;
            this.btnInsoyeulyLich.Text = "In Sơ Yếu Lý Lich";
            this.btnInsoyeulyLich.Click += new System.EventHandler(this.btnInsoyeulyLich_Click);
            // 
            // txtID
            // 
            this.txtID.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtID.BorderRadius = 4;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(790, 14);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtID.PlaceholderText = "Nhập Mã Học Sinh ..";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(196, 53);
            this.txtID.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnChinhSua);
            this.guna2Panel1.Controls.Add(this.btnInsoyeulyLich);
            this.guna2Panel1.Controls.Add(this.txtID);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1150, 831);
            this.guna2Panel1.TabIndex = 4;
            // 
            // pnHienThiSYLY
            // 
            this.pnHienThiSYLY.BackColor = System.Drawing.Color.White;
            this.pnHienThiSYLY.Controls.Add(this.dtgHienThi);
            this.pnHienThiSYLY.Location = new System.Drawing.Point(0, 86);
            this.pnHienThiSYLY.Name = "pnHienThiSYLY";
            this.pnHienThiSYLY.Size = new System.Drawing.Size(1204, 742);
            this.pnHienThiSYLY.TabIndex = 5;
            // 
            // dtgHienThi
            // 
            this.dtgHienThi.AllowUserToResizeColumns = false;
            this.dtgHienThi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgHienThi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgHienThi.ColumnHeadersHeight = 4;
            this.dtgHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgHienThi.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHienThi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgHienThi.GridColor = System.Drawing.Color.White;
            this.dtgHienThi.Location = new System.Drawing.Point(3, 0);
            this.dtgHienThi.Name = "dtgHienThi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHienThi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgHienThi.RowHeadersVisible = false;
            this.dtgHienThi.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dtgHienThi.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgHienThi.RowTemplate.Height = 24;
            this.dtgHienThi.Size = new System.Drawing.Size(1147, 742);
            this.dtgHienThi.TabIndex = 2;
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
            this.dtgHienThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHienThi_CellClick);
            this.dtgHienThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHienThi_CellContentClick);
            this.dtgHienThi.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHienThi_CellMouseEnter);
            this.dtgHienThi.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHienThi_CellMouseLeave);
            // 
            // frmSoyeulylich
            // 
            this.AcceptButton = this.btnInsoyeulyLich;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1150, 831);
            this.Controls.Add(this.pnHienThiSYLY);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmSoyeulylich";
            this.Text = "frmSoyeulylich";
            this.Load += new System.EventHandler(this.frmSoyeulylich_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.pnHienThiSYLY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHienThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnChinhSua;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnInsoyeulyLich;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnHienThiSYLY;
        private Guna.UI2.WinForms.Guna2DataGridView dtgHienThi;
    }
}