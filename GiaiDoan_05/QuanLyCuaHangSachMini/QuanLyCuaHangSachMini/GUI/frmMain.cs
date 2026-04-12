using QuanLyCuaHangSachMini.Data;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmMain : Form
    {
        private readonly AppDbContext context = new AppDbContext();

        private frmTheLoai theLoai = null;
        private frmNhaXuatBan nhaXuatBan = null;
        private frmNhaCungCap nhaCungCap = null;
        private frmSach sach = null;
        private frmKhachHang khachHang = null;
        private frmNhanVien nhanVien = null;
        private frmPhieuNhap phieuNhap = null;
        private frmHoaDon hoaDon = null;
        private frmDangNhap dangNhap = null;

        private int nhanVienDangNhapID = 0;
        private string tenDangNhapNhanVien = "";
        private string hoVaTenNhanVien = "";
        private string quyenHanNhanVien = "";

        public int NhanVienDangNhapID
        {
            get { return nhanVienDangNhapID; }
        }

        public string TenDangNhapNhanVien
        {
            get { return tenDangNhapNhanVien; }
        }

        public string HoVaTenNhanVien
        {
            get { return hoVaTenNhanVien; }
        }

        public string QuyenHanNhanVien
        {
            get { return quyenHanNhanVien; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();

            dangNhap.txtTenDangNhap.Clear();
            dangNhap.txtMatKhau.Clear();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text.Trim();
                string matKhau = dangNhap.txtMatKhau.Text.Trim();

                if (tenDangNhap == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var taiKhoan = context.NhanVien.SingleOrDefault(r => r.TenDangNhap == tenDangNhap);

                    if (taiKhoan == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (taiKhoan.MatKhau == matKhau)
                        {
                            if (taiKhoan.KichHoat == false)
                            {
                                MessageBox.Show("Tài khoản này đã bị khóa hoặc ngừng hoạt động!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto LamLai;
                            }

                            nhanVienDangNhapID = taiKhoan.ID;
                            tenDangNhapNhanVien = taiKhoan.TenDangNhap;
                            hoVaTenNhanVien = taiKhoan.HoVaTen;
                            quyenHanNhanVien = taiKhoan.QuyenHan ? "admin" : "nhanvien";

                            if (taiKhoan.QuyenHan == true)
                                QuyenAdmin();
                            else
                                QuyenNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }

        public void ChuaDangNhap()
        {
            nhanVienDangNhapID = 0;
            tenDangNhapNhanVien = "";
            hoVaTenNhanVien = "";
            quyenHanNhanVien = "";

            mnuDangNhap.Enabled = true;

            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            mnuLoaiSach.Enabled = false;
            mnuNhaXuatBan.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuSach.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuPhieuNhap.Enabled = false;
            mnuHoaDon.Enabled = false;

            mnuThongKeSach.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;

            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        public void QuyenAdmin()
        {
            mnuDangNhap.Enabled = false;

            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuLoaiSach.Enabled = true;
            mnuNhaXuatBan.Enabled = true;
            mnuNhaCungCap.Enabled = true;
            mnuSach.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuPhieuNhap.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSach.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            lblTrangThai.Text = "Quản trị viên: " + hoVaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            mnuDangNhap.Enabled = false;

            mnuLoaiSach.Enabled = false;
            mnuNhaXuatBan.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuSach.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuPhieuNhap.Enabled = false;

            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKeSach.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;

            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }

            ChuaDangNhap();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuLoaiSach_Click(object sender, EventArgs e)
        {
            if (theLoai == null || theLoai.IsDisposed)
            {
                theLoai = new frmTheLoai();
                theLoai.MdiParent = this;
                theLoai.Show();
            }
            else
                theLoai.Activate();
        }

        private void mnuNhaXuatBan_Click(object sender, EventArgs e)
        {
            if (nhaXuatBan == null || nhaXuatBan.IsDisposed)
            {
                nhaXuatBan = new frmNhaXuatBan();
                nhaXuatBan.MdiParent = this;
                nhaXuatBan.Show();
            }
            else
                nhaXuatBan.Activate();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            if (nhaCungCap == null || nhaCungCap.IsDisposed)
            {
                nhaCungCap = new frmNhaCungCap();
                nhaCungCap.MdiParent = this;
                nhaCungCap.Show();
            }
            else
                nhaCungCap.Activate();
        }

        private void mnuSach_Click(object sender, EventArgs e)
        {
            if (sach == null || sach.IsDisposed)
            {
                sach = new frmSach();
                sach.MdiParent = this;
                sach.Show();
            }
            else
                sach.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void mnuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (phieuNhap == null || phieuNhap.IsDisposed)
            {
                phieuNhap = new frmPhieuNhap();
                phieuNhap.MdiParent = this;
                phieuNhap.Show();
            }
            else
                phieuNhap.Activate();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon(nhanVienDangNhapID, quyenHanNhanVien, hoVaTenNhanVien);
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đổi mật khẩu sẽ làm tiếp sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuThongKeSach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thống kê sách sẽ làm tiếp sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thống kê doanh thu sẽ làm tiếp sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập tài khoản để sử dụng hệ thống.\nCác chức năng sẽ mở trong cửa sổ chính dạng MDI.", "Hướng dẫn sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuThongTinPhanMem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PHẦN MỀM QUẢN LÝ CỬA HÀNG SÁCH MINI\nThiết kế theo form mẫu của thầy, chỉnh lại theo đồ án của bạn.", "Thông tin phần mềm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }
    }
}