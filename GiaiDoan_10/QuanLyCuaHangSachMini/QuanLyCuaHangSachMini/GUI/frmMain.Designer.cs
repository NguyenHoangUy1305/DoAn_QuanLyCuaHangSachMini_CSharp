using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnDangXuat = new Button();
            pnlMenuButtons = new FlowLayoutPanel();
            btnTrangChu = new Button();
            btnLoaiSach = new Button();
            btnNhaXuatBan = new Button();
            btnNhaCungCap = new Button();
            btnSach = new Button();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            btnPhieuNhap = new Button();
            btnPhieuHoanTra = new Button();
            btnBanSachHoaDon = new Button();
            btnThongKeSach = new Button();
            btnThongKeDoanhThu = new Button();
            btnNhatKyHeThong = new Button();
            panelLogo = new Panel();
            lblSubLogo = new Label();
            lblLogo = new Label();
            panelTop = new Panel();
            lblVaiTro = new Label();
            lblNguoiDung = new Label();
            lblTenHeThong = new Label();
            pnContainer = new Panel();
            panelMenu.SuspendLayout();
            pnlMenuButtons.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(71, 51, 255);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Controls.Add(pnlMenuButtons);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 760);
            panelMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(220, 53, 69);
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 25, 40);
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(0, 710);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(12, 0, 0, 0);
            btnDangXuat.Size = new Size(200, 50);
            btnDangXuat.TabIndex = 12;
            btnDangXuat.Text = "    Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // pnlMenuButtons
            // 
            pnlMenuButtons.AutoScroll = true;
            pnlMenuButtons.BackColor = Color.FromArgb(71, 51, 255);
            pnlMenuButtons.Controls.Add(btnTrangChu);
            pnlMenuButtons.Controls.Add(btnLoaiSach);
            pnlMenuButtons.Controls.Add(btnNhaXuatBan);
            pnlMenuButtons.Controls.Add(btnNhaCungCap);
            pnlMenuButtons.Controls.Add(btnSach);
            pnlMenuButtons.Controls.Add(btnKhachHang);
            pnlMenuButtons.Controls.Add(btnNhanVien);
            pnlMenuButtons.Controls.Add(btnPhieuNhap);
            pnlMenuButtons.Controls.Add(btnPhieuHoanTra);
            pnlMenuButtons.Controls.Add(btnBanSachHoaDon);
            pnlMenuButtons.Controls.Add(btnThongKeSach);
            pnlMenuButtons.Controls.Add(btnThongKeDoanhThu);
            pnlMenuButtons.Controls.Add(btnNhatKyHeThong);
            // Thêm nút đổi mật khẩu (chỉ admin thấy ở runtime)
            btnDoiMatKhau = new Button();
            btnDoiMatKhau.BackColor = Color.FromArgb(71, 51, 255);
            btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            btnDoiMatKhau.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnDoiMatKhau.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDoiMatKhau.ForeColor = Color.White;
            btnDoiMatKhau.Location = new Point(8, 720);
            btnDoiMatKhau.Margin = new Padding(0, 0, 0, 8);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Padding = new Padding(12, 0, 0, 0);
            btnDoiMatKhau.Size = new Size(184, 48);
            btnDoiMatKhau.TabIndex = 13;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.TextAlign = ContentAlignment.MiddleLeft;
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            pnlMenuButtons.Controls.Add(btnDoiMatKhau);
            pnlMenuButtons.Dock = DockStyle.Fill;
            pnlMenuButtons.FlowDirection = FlowDirection.TopDown;
            pnlMenuButtons.Location = new Point(0, 120);
            pnlMenuButtons.Name = "pnlMenuButtons";
            pnlMenuButtons.Padding = new Padding(8);
            pnlMenuButtons.Size = new Size(200, 640);
            pnlMenuButtons.TabIndex = 1;
            pnlMenuButtons.WrapContents = false;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.FromArgb(71, 51, 255);
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnTrangChu.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTrangChu.ForeColor = Color.White;
            btnTrangChu.Location = new Point(8, 8);
            btnTrangChu.Margin = new Padding(0, 0, 0, 8);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Padding = new Padding(12, 0, 0, 0);
            btnTrangChu.Size = new Size(184, 48);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // btnLoaiSach
            // 
            btnLoaiSach.BackColor = Color.FromArgb(71, 51, 255);
            btnLoaiSach.FlatAppearance.BorderSize = 0;
            btnLoaiSach.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnLoaiSach.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnLoaiSach.FlatStyle = FlatStyle.Flat;
            btnLoaiSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLoaiSach.ForeColor = Color.White;
            btnLoaiSach.Location = new Point(8, 64);
            btnLoaiSach.Margin = new Padding(0, 0, 0, 8);
            btnLoaiSach.Name = "btnLoaiSach";
            btnLoaiSach.Padding = new Padding(12, 0, 0, 0);
            btnLoaiSach.Size = new Size(184, 48);
            btnLoaiSach.TabIndex = 1;
            btnLoaiSach.Text = "Thể loại sách";
            btnLoaiSach.TextAlign = ContentAlignment.MiddleLeft;
            btnLoaiSach.UseVisualStyleBackColor = false;
            btnLoaiSach.Click += btnLoaiSach_Click;
            // 
            // btnNhaXuatBan
            // 
            btnNhaXuatBan.BackColor = Color.FromArgb(71, 51, 255);
            btnNhaXuatBan.FlatAppearance.BorderSize = 0;
            btnNhaXuatBan.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnNhaXuatBan.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnNhaXuatBan.FlatStyle = FlatStyle.Flat;
            btnNhaXuatBan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNhaXuatBan.ForeColor = Color.White;
            btnNhaXuatBan.Location = new Point(8, 120);
            btnNhaXuatBan.Margin = new Padding(0, 0, 0, 8);
            btnNhaXuatBan.Name = "btnNhaXuatBan";
            btnNhaXuatBan.Padding = new Padding(12, 0, 0, 0);
            btnNhaXuatBan.Size = new Size(184, 48);
            btnNhaXuatBan.TabIndex = 1;
            btnNhaXuatBan.Text = "Nhà xuất bản";
            btnNhaXuatBan.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaXuatBan.UseVisualStyleBackColor = false;
            btnNhaXuatBan.Click += btnNhaXuatBan_Click;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = Color.FromArgb(71, 51, 255);
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnNhaCungCap.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNhaCungCap.ForeColor = Color.White;
            btnNhaCungCap.Location = new Point(8, 176);
            btnNhaCungCap.Margin = new Padding(0, 0, 0, 8);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(12, 0, 0, 0);
            btnNhaCungCap.Size = new Size(184, 48);
            btnNhaCungCap.TabIndex = 2;
            btnNhaCungCap.Text = "Nhà cung cấp";
            btnNhaCungCap.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.UseVisualStyleBackColor = false;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnSach
            // 
            btnSach.BackColor = Color.FromArgb(71, 51, 255);
            btnSach.FlatAppearance.BorderSize = 0;
            btnSach.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnSach.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnSach.FlatStyle = FlatStyle.Flat;
            btnSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSach.ForeColor = Color.White;
            btnSach.Location = new Point(8, 232);
            btnSach.Margin = new Padding(0, 0, 0, 8);
            btnSach.Name = "btnSach";
            btnSach.Padding = new Padding(12, 0, 0, 0);
            btnSach.Size = new Size(184, 48);
            btnSach.TabIndex = 3;
            btnSach.Text = "Sách";
            btnSach.TextAlign = ContentAlignment.MiddleLeft;
            btnSach.UseVisualStyleBackColor = false;
            btnSach.Click += btnSach_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(71, 51, 255);
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnKhachHang.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Location = new Point(8, 288);
            btnKhachHang.Margin = new Padding(0, 0, 0, 8);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(12, 0, 0, 0);
            btnKhachHang.Size = new Size(184, 48);
            btnKhachHang.TabIndex = 4;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(71, 51, 255);
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Location = new Point(8, 344);
            btnNhanVien.Margin = new Padding(0, 0, 0, 8);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(12, 0, 0, 0);
            btnNhanVien.Size = new Size(184, 48);
            btnNhanVien.TabIndex = 5;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.BackColor = Color.FromArgb(71, 51, 255);
            btnPhieuNhap.FlatAppearance.BorderSize = 0;
            btnPhieuNhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnPhieuNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnPhieuNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPhieuNhap.ForeColor = Color.White;
            btnPhieuNhap.Location = new Point(8, 400);
            btnPhieuNhap.Margin = new Padding(0, 0, 0, 8);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Padding = new Padding(12, 0, 0, 0);
            btnPhieuNhap.Size = new Size(184, 48);
            btnPhieuNhap.TabIndex = 6;
            btnPhieuNhap.Text = "Phiếu nhập";
            btnPhieuNhap.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhap.UseVisualStyleBackColor = false;
            btnPhieuNhap.Click += btnPhieuNhap_Click;
            // 
            // btnPhieuHoanTra
            // 
            btnPhieuHoanTra.BackColor = Color.FromArgb(71, 51, 255);
            btnPhieuHoanTra.FlatAppearance.BorderSize = 0;
            btnPhieuHoanTra.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnPhieuHoanTra.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnPhieuHoanTra.FlatStyle = FlatStyle.Flat;
            btnPhieuHoanTra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPhieuHoanTra.ForeColor = Color.White;
            btnPhieuHoanTra.Location = new Point(8, 456);
            btnPhieuHoanTra.Margin = new Padding(0, 0, 0, 8);
            btnPhieuHoanTra.Name = "btnPhieuHoanTra";
            btnPhieuHoanTra.Padding = new Padding(12, 0, 0, 0);
            btnPhieuHoanTra.Size = new Size(184, 48);
            btnPhieuHoanTra.TabIndex = 7;
            btnPhieuHoanTra.Text = "Phiếu hoàn trả";
            btnPhieuHoanTra.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuHoanTra.UseVisualStyleBackColor = false;
            btnPhieuHoanTra.Click += btnPhieuHoanTra_Click;
            // 
            // btnBanSachHoaDon
            // 
            btnBanSachHoaDon.BackColor = Color.FromArgb(71, 51, 255);
            btnBanSachHoaDon.FlatAppearance.BorderSize = 0;
            btnBanSachHoaDon.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnBanSachHoaDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnBanSachHoaDon.FlatStyle = FlatStyle.Flat;
            btnBanSachHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBanSachHoaDon.ForeColor = Color.White;
            btnBanSachHoaDon.Location = new Point(8, 512);
            btnBanSachHoaDon.Margin = new Padding(0, 0, 0, 8);
            btnBanSachHoaDon.Name = "btnBanSachHoaDon";
            btnBanSachHoaDon.Padding = new Padding(12, 0, 0, 0);
            btnBanSachHoaDon.Size = new Size(184, 48);
            btnBanSachHoaDon.TabIndex = 8;
            btnBanSachHoaDon.Text = "Bán Sách-Hóa Đơn";
            btnBanSachHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnBanSachHoaDon.UseVisualStyleBackColor = false;
            btnBanSachHoaDon.Click += btnHoaDon_Click;
            // 
            // btnThongKeSach
            // 
            btnThongKeSach.BackColor = Color.FromArgb(71, 51, 255);
            btnThongKeSach.FlatAppearance.BorderSize = 0;
            btnThongKeSach.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnThongKeSach.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnThongKeSach.FlatStyle = FlatStyle.Flat;
            btnThongKeSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongKeSach.ForeColor = Color.White;
            btnThongKeSach.Location = new Point(8, 568);
            btnThongKeSach.Margin = new Padding(0, 0, 0, 8);
            btnThongKeSach.Name = "btnThongKeSach";
            btnThongKeSach.Padding = new Padding(12, 0, 0, 0);
            btnThongKeSach.Size = new Size(184, 48);
            btnThongKeSach.TabIndex = 9;
            btnThongKeSach.Text = "Thống kê sách";
            btnThongKeSach.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeSach.UseVisualStyleBackColor = false;
            btnThongKeSach.Click += btnThongKeSach_Click;
            // 
            // btnThongKeDoanhThu
            // 
            btnThongKeDoanhThu.BackColor = Color.FromArgb(71, 51, 255);
            btnThongKeDoanhThu.FlatAppearance.BorderSize = 0;
            btnThongKeDoanhThu.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnThongKeDoanhThu.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnThongKeDoanhThu.FlatStyle = FlatStyle.Flat;
            btnThongKeDoanhThu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongKeDoanhThu.ForeColor = Color.White;
            btnThongKeDoanhThu.Location = new Point(8, 624);
            btnThongKeDoanhThu.Margin = new Padding(0, 0, 0, 8);
            btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            btnThongKeDoanhThu.Padding = new Padding(12, 0, 0, 0);
            btnThongKeDoanhThu.Size = new Size(192, 30);
            btnThongKeDoanhThu.TabIndex = 10;
            btnThongKeDoanhThu.Text = "Thống kê doanh thu";
            btnThongKeDoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeDoanhThu.UseVisualStyleBackColor = false;
            btnThongKeDoanhThu.Click += btnThongKeDoanhThu_Click;
            // 
            // btnNhatKyHeThong
            // 
            btnNhatKyHeThong.BackColor = Color.FromArgb(71, 51, 255);
            btnNhatKyHeThong.FlatAppearance.BorderSize = 0;
            btnNhatKyHeThong.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnNhatKyHeThong.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnNhatKyHeThong.FlatStyle = FlatStyle.Flat;
            btnNhatKyHeThong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNhatKyHeThong.ForeColor = Color.White;
            btnNhatKyHeThong.Location = new Point(8, 662);
            btnNhatKyHeThong.Margin = new Padding(0, 0, 0, 8);
            btnNhatKyHeThong.Name = "btnNhatKyHeThong";
            btnNhatKyHeThong.Padding = new Padding(12, 0, 0, 0);
            btnNhatKyHeThong.Size = new Size(184, 48);
            btnNhatKyHeThong.TabIndex = 11;
            btnNhatKyHeThong.Text = "Nhật ký hệ thống";
            btnNhatKyHeThong.TextAlign = ContentAlignment.MiddleLeft;
            btnNhatKyHeThong.UseVisualStyleBackColor = false;
            btnNhatKyHeThong.Click += btnNhatKyHeThong_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(55, 38, 210);
            panelLogo.Controls.Add(lblSubLogo);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 120);
            panelLogo.TabIndex = 0;
            // 
            // lblSubLogo
            // 
            lblSubLogo.Font = new Font("Segoe UI", 8.5F);
            lblSubLogo.ForeColor = Color.FromArgb(230, 230, 255);
            lblSubLogo.Location = new Point(0, 64);
            lblSubLogo.Name = "lblSubLogo";
            lblSubLogo.Size = new Size(200, 36);
            lblSubLogo.TabIndex = 1;
            lblSubLogo.Text = "Quản lý cửa hàng sách mini";
            lblSubLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(200, 40);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "BOOKSTORE";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(lblVaiTro);
            panelTop.Controls.Add(lblNguoiDung);
            panelTop.Controls.Add(lblTenHeThong);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(200, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1080, 80);
            panelTop.TabIndex = 1;
            // 
            // lblVaiTro
            // 
            lblVaiTro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVaiTro.ForeColor = Color.Red;
            lblVaiTro.Location = new Point(623, 43);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(186, 23);
            lblVaiTro.TabIndex = 0;
            lblVaiTro.Text = "Vai trò: Chưa xác định";
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNguoiDung.AutoSize = true;
            lblNguoiDung.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNguoiDung.ForeColor = Color.Red;
            lblNguoiDung.Location = new Point(608, 20);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(249, 23);
            lblNguoiDung.TabIndex = 1;
            lblNguoiDung.Text = "Nguời dùng: Chưa đăng nhập";
            // 
            // lblTenHeThong
            // 
            lblTenHeThong.AutoSize = true;
            lblTenHeThong.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTenHeThong.ForeColor = Color.FromArgb(55, 38, 210);
            lblTenHeThong.Location = new Point(22, 20);
            lblTenHeThong.Name = "lblTenHeThong";
            lblTenHeThong.Size = new Size(435, 37);
            lblTenHeThong.TabIndex = 2;
            lblTenHeThong.Text = "QUẢN LÝ CỬA HÀNG SÁCH MINI";
            // 
            // pnContainer
            // 
            pnContainer.BackColor = Color.FromArgb(241, 245, 249);
            pnContainer.Dock = DockStyle.Fill;
            pnContainer.Location = new Point(200, 80);
            pnContainer.Name = "pnContainer";
            pnContainer.Size = new Size(1080, 680);
            pnContainer.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 760);
            Controls.Add(pnContainer);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cửa hàng sách mini";
            Load += frmMain_Load;
            panelMenu.ResumeLayout(false);
            pnlMenuButtons.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnDangXuat;
        private FlowLayoutPanel pnlMenuButtons;
        private Button btnDoiMatKhau;
        private Button btnTrangChu;
        private Button btnLoaiSach;
        private Button btnNhaXuatBan;
        private Button btnNhaCungCap;
        private Button btnSach;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Button btnPhieuNhap;
        private Button btnPhieuHoanTra;
        private Button btnBanSachHoaDon;
        private Button btnThongKeSach;
        private Button btnThongKeDoanhThu;
        private Button btnNhatKyHeThong;
        private Panel panelLogo;
        private Label lblSubLogo;
        private Label lblLogo;
        private Panel panelTop;
        private Label lblVaiTro;
        private Label lblNguoiDung;
        private Label lblTenHeThong;
        private Panel pnContainer;
    }
}

