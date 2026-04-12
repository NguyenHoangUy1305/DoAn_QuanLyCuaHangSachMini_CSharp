using QuanLyCuaHangSachMini.Helpers;
using System;
using System.Windows.Forms;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmMain : Form
    {
        private Form? currentChildForm = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblNguoiDung.Text = $"Người dùng: {SessionHelper.HoVaTen}";
            lblVaiTro.Text = $"Vai trò: {SessionHelper.QuyenHan}";


            if (SessionHelper.LaQuanTri)
                QuyenAdmin();
            else
                QuyenNhanVien();

            OpenChildForm(new frmTrangChu(SessionHelper.LaQuanTri));
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                pnContainer.Controls.Clear();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnContainer.Controls.Add(childForm);
            pnContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void QuyenAdmin()
        {
            btnTrangChu.Visible = true;
            btnLoaiSach.Visible = true;
            btnNhaXuatBan.Visible = true;
            btnNhaCungCap.Visible = true;
            btnSach.Visible = true;
            btnKhachHang.Visible = true;
            btnNhanVien.Visible = true;
            btnPhieuNhap.Visible = true;
            btnPhieuHoanTra.Visible = true;
            btnBanSachHoaDon.Visible = true;
            btnThongKeSach.Visible = true;
            btnThongKeDoanhThu.Visible = true;
            btnNhatKyHeThong.Visible = true;
            btnDangXuat.Visible = true;
            btnDoiMatKhau.Visible = true;
        }

        public void QuyenNhanVien()
        {
            btnTrangChu.Visible = true;
            btnLoaiSach.Visible = false;
            btnNhaXuatBan.Visible = false;
            btnNhaCungCap.Visible = false;
            btnSach.Visible = false;
            btnNhanVien.Visible = false;
            btnPhieuNhap.Visible = false;
            btnPhieuHoanTra.Visible = true;
            btnThongKeSach.Visible = false;
            btnThongKeDoanhThu.Visible = false;
            btnNhatKyHeThong.Visible = false;

            // Ẩn chức năng đổi mật khẩu nếu là nhân viên thường
            btnDoiMatKhau.Visible = false;

            btnKhachHang.Visible = true;
            btnBanSachHoaDon.Visible = true;
            btnDangXuat.Visible = true;
        }

        private void btnLoaiSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTheLoai());
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangChu(SessionHelper.LaQuanTri));
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaXuatBan());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhaCungCap());
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSach());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang(SessionHelper.QuyenHan));
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuNhap(SessionHelper.NhanVienID, SessionHelper.QuyenHan));
        }

        private void btnPhieuHoanTra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuHoanTra(SessionHelper.NhanVienID, SessionHelper.QuyenHan));
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon(SessionHelper.NhanVienID, SessionHelper.QuyenHan, SessionHelper.HoVaTen));
        }

        private void btnThongKeSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeSach());
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeDoanhThu());
        }

        private void btnNhatKyHeThong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhatKyHeThong());
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!SessionHelper.LaQuanTri)
            {
                MessageBox.Show("Chỉ quản trị viên mới có quyền đổi mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var f = new frmDoiMatKhau();
            f.ShowDialog(this);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Ðăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhatKyHelper.GhiLog("Ðăng xuất", "Hệ thống", SessionHelper.NhanVienID.ToString(), "Ðang xuất");
                SessionHelper.DangXuat();
                Application.Restart();
            }
        }



    }
}



