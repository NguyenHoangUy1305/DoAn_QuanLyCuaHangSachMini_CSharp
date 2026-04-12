using QuanLyCuaHangSachMini.Helpers;
using System.Diagnostics;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmMain : Form
    {
        private frmTheLoai? theLoai = null;
        private frmNhaXuatBan? nhaXuatBan = null;
        private frmNhaCungCap? nhaCungCap = null;
        private frmSach? sach = null;
        private frmKhachHang? khachHang = null;
        private frmNhanVien? nhanVien = null;
        private frmPhieuNhap? phieuNhap = null;
        private frmHoaDon? hoaDon = null;
        private frmNhatKyHeThong? nhatKyHeThong = null;

        public int NhanVienDangNhapID
        {
            get { return SessionHelper.NhanVienID; }
        }

        public string TenDangNhapNhanVien
        {
            get { return SessionHelper.TenDangNhap; }
        }

        public string HoVaTenNhanVien
        {
            get { return SessionHelper.HoVaTen; }
        }

        public string QuyenHanNhanVien
        {
            get { return SessionHelper.QuyenHan; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SessionHelper.DangXuat();
            ChuaDangNhap();

            bool dangNhapThanhCong = HienThiDangNhap(true);
            if (!dangNhapThanhCong)
                Close();
        }

        private bool HienThiDangNhap(bool batBuocDangNhap = false)
        {
            using (frmDangNhap dangNhap = new frmDangNhap())
            {
                if (dangNhap.ShowDialog() == DialogResult.OK)
                {
                    if (SessionHelper.LaQuanTri)
                        QuyenAdmin();
                    else
                        QuyenNhanVien();

                    return true;
                }
            }

            if (batBuocDangNhap)
                return false;

            return false;
        }

        public void ChuaDangNhap()
        {
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
            mnuNhatKyHeThong.Enabled = false;

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
            mnuNhatKyHeThong.Enabled = true;

            lblTrangThai.Text = "Quản trị viên: " + SessionHelper.HoVaTen + " | " + SessionHelper.TenDangNhap;
        }

        public void QuyenNhanVien()
        {
            mnuDangNhap.Enabled = false;

            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;

            mnuLoaiSach.Enabled = false;
            mnuNhaXuatBan.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuSach.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuPhieuNhap.Enabled = false;

            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;

            mnuThongKeSach.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            mnuNhatKyHeThong.Enabled = false;

            lblTrangThai.Text = "Nhân viên: " + SessionHelper.HoVaTen + " | " + SessionHelper.TenDangNhap;
        }

        private void DongTatCaFormCon()
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }

            theLoai = null;
            nhaXuatBan = null;
            nhaCungCap = null;
            sach = null;
            khachHang = null;
            nhanVien = null;
            phieuNhap = null;
            hoaDon = null;
            nhatKyHeThong = null;
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            if (SessionHelper.DaDangNhap)
            {
                MessageBox.Show("Hiện tại bạn đã đăng nhập rồi.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            HienThiDangNhap(false);
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (!SessionHelper.DaDangNhap)
            {
                MessageBox.Show("Hiện tại chưa có tài khoản nào đăng nhập.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhatKyHelper.GhiLog(
                    "Đăng xuất",
                    "Hệ thống",
                    SessionHelper.NhanVienID.ToString(),
                    "Đăng xuất khỏi hệ thống"
                );

                DongTatCaFormCon();
                SessionHelper.DangXuat();
                ChuaDangNhap();
            }
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
                hoaDon = new frmHoaDon(
                    SessionHelper.NhanVienID,
                    SessionHelper.QuyenHan,
                    SessionHelper.HoVaTen
                );
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
        }

        private void mnuNhatKyHeThong_Click(object sender, EventArgs e)
        {
            if (!SessionHelper.LaQuanTri)
            {
                MessageBox.Show("Bạn không có quyền xem nhật ký hệ thống.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nhatKyHeThong == null || nhatKyHeThong.IsDisposed)
            {
                nhatKyHeThong = new frmNhatKyHeThong();
                nhatKyHeThong.MdiParent = this;
                nhatKyHeThong.Show();
            }
            else
                nhatKyHeThong.Activate();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đổi mật khẩu sẽ làm tiếp sau.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuThongKeSach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thống kê sách sẽ làm tiếp sau.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thống kê doanh thu sẽ làm tiếp sau.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. Đăng nhập tài khoản để sử dụng hệ thống." +
                "\n2. Admin quản lý toàn bộ danh mục, nhân viên, phiếu nhập, hóa đơn và nhật ký hệ thống." +
                "\n3. Nhân viên chỉ thao tác các chức năng được phân quyền." +
                "\n4. Các form sẽ mở trong cửa sổ chính dạng MDI.",
                "Hướng dẫn sử dụng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void mnuThongTinPhanMem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "PHẦN MỀM QUẢN LÝ CỬA HÀNG SÁCH MINI" +
                "\nThiết kế theo form mẫu WinForms dạng MDI." +
                "\nĐã chỉnh lại theo đúng đồ án và phân quyền của bạn.",
                "Thông tin phần mềm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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