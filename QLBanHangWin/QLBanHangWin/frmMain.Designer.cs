namespace QLBanHangWin

{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.doangThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHoaDonBan = new System.Windows.Forms.Button();
            this.KhachHang = new System.Windows.Forms.Button();
            this.btnMatHang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuHangHoa});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "&Danh mục";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.mnuNhanVien.Size = new System.Drawing.Size(177, 22);
            this.mnuNhanVien.Text = "&Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.mnuKhachHang.Size = new System.Drawing.Size(177, 22);
            this.mnuKhachHang.Text = "&Khách hàng ";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.mnuHangHoa.Size = new System.Drawing.Size(177, 22);
            this.mnuHangHoa.Text = "&Mặt Hàng";
            this.mnuHangHoa.Click += new System.EventHandler(this.mnuHangHoa_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonBan});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(68, 20);
            this.mnuHoaDon.Text = "Hóa đơn ";
            // 
            // mnuHoaDonBan
            // 
            this.mnuHoaDonBan.Name = "mnuHoaDonBan";
            this.mnuHoaDonBan.Size = new System.Drawing.Size(143, 22);
            this.mnuHoaDonBan.Text = "Hóa đơn bán";
            this.mnuHoaDonBan.Click += new System.EventHandler(this.mnuHoaDonBan_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindHoaDon,
            this.mnuFindHang,
            this.mnuFindKhachHang});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(68, 20);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuFindHoaDon
            // 
            this.mnuFindHoaDon.Name = "mnuFindHoaDon";
            this.mnuFindHoaDon.Size = new System.Drawing.Size(143, 22);
            this.mnuFindHoaDon.Text = "Hóa đơn bán";
            this.mnuFindHoaDon.Click += new System.EventHandler(this.mnuFindHoaDon_Click);
            // 
            // mnuFindHang
            // 
            this.mnuFindHang.Name = "mnuFindHang";
            this.mnuFindHang.Size = new System.Drawing.Size(143, 22);
            this.mnuFindHang.Text = "Mặt hàng";
            // 
            // mnuFindKhachHang
            // 
            this.mnuFindKhachHang.Name = "mnuFindKhachHang";
            this.mnuFindKhachHang.Size = new System.Drawing.Size(143, 22);
            this.mnuFindKhachHang.Text = "Khách hàng";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doangThuToolStripMenuItem});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // doangThuToolStripMenuItem
            // 
            this.doangThuToolStripMenuItem.Name = "doangThuToolStripMenuItem";
            this.doangThuToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.doangThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuThoat});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(877, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(49, 20);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Body.Location = new System.Drawing.Point(198, 24);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(679, 465);
            this.panel_Body.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHoaDonBan);
            this.panel1.Controls.Add(this.KhachHang);
            this.panel1.Controls.Add(this.btnMatHang);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 465);
            this.panel1.TabIndex = 4;
            // 
            // btnHoaDonBan
            // 
            this.btnHoaDonBan.Location = new System.Drawing.Point(0, 282);
            this.btnHoaDonBan.Name = "btnHoaDonBan";
            this.btnHoaDonBan.Size = new System.Drawing.Size(200, 33);
            this.btnHoaDonBan.TabIndex = 4;
            this.btnHoaDonBan.Text = "Hóa đơn bán";
            this.btnHoaDonBan.UseVisualStyleBackColor = true;
            this.btnHoaDonBan.Click += new System.EventHandler(this.mnuHoaDonBan_Click);
            // 
            // KhachHang
            // 
            this.KhachHang.Location = new System.Drawing.Point(0, 243);
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Size = new System.Drawing.Size(200, 33);
            this.KhachHang.TabIndex = 3;
            this.KhachHang.Text = "Khách hàng";
            this.KhachHang.UseVisualStyleBackColor = true;
            this.KhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // btnMatHang
            // 
            this.btnMatHang.Location = new System.Drawing.Point(0, 204);
            this.btnMatHang.Name = "btnMatHang";
            this.btnMatHang.Size = new System.Drawing.Size(200, 33);
            this.btnMatHang.TabIndex = 2;
            this.btnMatHang.Text = "Mặt hàng";
            this.btnMatHang.UseVisualStyleBackColor = true;
            this.btnMatHang.Click += new System.EventHandler(this.mnuHangHoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(0, 167);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(200, 33);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(694, 5);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(58, 13);
            this.lbLogin.TabIndex = 6;
            this.lbLogin.Text = "Tài khoản:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 489);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Trang chủ quản lý bán hàng";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHang;
        private System.Windows.Forms.ToolStripMenuItem mnuFindKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHoaDonBan;
        private System.Windows.Forms.Button KhachHang;
        private System.Windows.Forms.Button btnMatHang;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.ToolStripMenuItem doangThuToolStripMenuItem;

    }
}

