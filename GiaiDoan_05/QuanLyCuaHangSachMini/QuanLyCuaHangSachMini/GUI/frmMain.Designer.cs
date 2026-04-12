namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaXuatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDanSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinPhanMem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCanGiua = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLienKet = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLy,
            this.mnuBaoCaoThongKe,
            this.mnuTroGiup});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1264, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.mnuDoiMatKhau,
            this.toolStripSeparator1,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(85, 24);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(196, 26);
            this.mnuDangNhap.Text = "Đăng nhập...";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(196, 26);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(196, 26);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu...";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(196, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoaiSach,
            this.mnuNhaXuatBan,
            this.mnuNhaCungCap,
            this.mnuSach,
            this.toolStripSeparator2,
            this.mnuKhachHang,
            this.mnuNhanVien,
            this.toolStripSeparator3,
            this.mnuPhieuNhap,
            this.mnuHoaDon});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(76, 24);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuLoaiSach
            // 
            this.mnuLoaiSach.Name = "mnuLoaiSach";
            this.mnuLoaiSach.Size = new System.Drawing.Size(231, 26);
            this.mnuLoaiSach.Text = "Thể loại sách...";
            this.mnuLoaiSach.Click += new System.EventHandler(this.mnuLoaiSach_Click);
            // 
            // mnuNhaXuatBan
            // 
            this.mnuNhaXuatBan.Name = "mnuNhaXuatBan";
            this.mnuNhaXuatBan.Size = new System.Drawing.Size(231, 26);
            this.mnuNhaXuatBan.Text = "Nhà xuất bản...";
            this.mnuNhaXuatBan.Click += new System.EventHandler(this.mnuNhaXuatBan_Click);
            // 
            // mnuNhaCungCap
            // 
            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.Size = new System.Drawing.Size(231, 26);
            this.mnuNhaCungCap.Text = "Nhà cung cấp...";
            this.mnuNhaCungCap.Click += new System.EventHandler(this.mnuNhaCungCap_Click);
            // 
            // mnuSach
            // 
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Size = new System.Drawing.Size(231, 26);
            this.mnuSach.Text = "Sách...";
            this.mnuSach.Click += new System.EventHandler(this.mnuSach_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(228, 6);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(231, 26);
            this.mnuKhachHang.Text = "Khách hàng...";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(231, 26);
            this.mnuNhanVien.Text = "Nhân viên...";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(228, 6);
            // 
            // mnuPhieuNhap
            // 
            this.mnuPhieuNhap.Name = "mnuPhieuNhap";
            this.mnuPhieuNhap.Size = new System.Drawing.Size(231, 26);
            this.mnuPhieuNhap.Text = "Phiếu nhập...";
            this.mnuPhieuNhap.Click += new System.EventHandler(this.mnuPhieuNhap_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(231, 26);
            this.mnuHoaDon.Text = "Hóa đơn bán hàng...";
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            // 
            // mnuBaoCaoThongKe
            // 
            this.mnuBaoCaoThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKeSach,
            this.mnuThongKeDoanhThu});
            this.mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            this.mnuBaoCaoThongKe.Size = new System.Drawing.Size(152, 24);
            this.mnuBaoCaoThongKe.Text = "Báo cáo - Thống kê";
            // 
            // mnuThongKeSach
            // 
            this.mnuThongKeSach.Name = "mnuThongKeSach";
            this.mnuThongKeSach.Size = new System.Drawing.Size(234, 26);
            this.mnuThongKeSach.Text = "Thống kê sách...";
            this.mnuThongKeSach.Click += new System.EventHandler(this.mnuThongKeSach_Click);
            // 
            // mnuThongKeDoanhThu
            // 
            this.mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            this.mnuThongKeDoanhThu.Size = new System.Drawing.Size(234, 26);
            this.mnuThongKeDoanhThu.Text = "Thống kê doanh thu...";
            this.mnuThongKeDoanhThu.Click += new System.EventHandler(this.mnuThongKeDoanhThu_Click);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDanSuDung,
            this.mnuThongTinPhanMem});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(77, 24);
            this.mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuHuongDanSuDung
            // 
            this.mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            this.mnuHuongDanSuDung.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.mnuHuongDanSuDung.Size = new System.Drawing.Size(273, 26);
            this.mnuHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            this.mnuHuongDanSuDung.Click += new System.EventHandler(this.mnuHuongDanSuDung_Click);
            // 
            // mnuThongTinPhanMem
            // 
            this.mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            this.mnuThongTinPhanMem.Size = new System.Drawing.Size(273, 26);
            this.mnuThongTinPhanMem.Text = "Thông tin phần mềm...";
            this.mnuThongTinPhanMem.Click += new System.EventHandler(this.mnuThongTinPhanMem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai,
            this.lblCanGiua,
            this.lblLienKet});
            this.statusStrip.Location = new System.Drawing.Point(0, 659);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1264, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(120, 20);
            this.lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // lblCanGiua
            // 
            this.lblCanGiua.Name = "lblCanGiua";
            this.lblCanGiua.Size = new System.Drawing.Size(1072, 20);
            this.lblCanGiua.Spring = true;
            // 
            // lblLienKet
            // 
            this.lblLienKet.IsLink = true;
            this.lblLienKet.Name = "lblLienKet";
            this.lblLienKet.Size = new System.Drawing.Size(55, 20);
            this.lblLienKet.Text = "© 2024 FIT";
            this.lblLienKet.Click += new System.EventHandler(this.lblLienKet_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 685);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng sách mini";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiSach;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaXuatBan;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeSach;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDanSuDung;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinPhanMem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel lblCanGiua;
        private System.Windows.Forms.ToolStripStatusLabel lblLienKet;
    }
}