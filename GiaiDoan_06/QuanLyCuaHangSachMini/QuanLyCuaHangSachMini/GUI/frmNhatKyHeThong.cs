using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Helpers;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmNhatKyHeThong : Form
    {
        public frmNhatKyHeThong()
        {
            InitializeComponent();
        }

        private void frmNhatKyHeThong_Load(object sender, EventArgs e)
        {
            if (!SessionHelper.LaQuanTri)
            {
                MessageBox.Show("Bạn không có quyền xem nhật ký hệ thống.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            using AppDbContext context = new AppDbContext();

            var ds = context.NhatKyHeThong
                .AsNoTracking()
                .OrderByDescending(r => r.ThoiGian)
                .Select(r => new
                {
                    r.ID,
                    r.ThoiGian,
                    r.HanhDong,
                    r.BangDuLieu,
                    r.KhoaChinh,
                    r.MoTa,
                    r.TenDangNhap,
                    r.HoVaTen,
                    r.VaiTro
                })
                .ToList();

            dgvNhatKy.DataSource = ds;
            DinhDangLuoi();
        }

        private void DinhDangLuoi()
        {
            if (dgvNhatKy.Columns.Count <= 0)
                return;

            dgvNhatKy.Columns["ID"].HeaderText = "ID";
            dgvNhatKy.Columns["ThoiGian"].HeaderText = "Thời gian";
            dgvNhatKy.Columns["HanhDong"].HeaderText = "Hành động";
            dgvNhatKy.Columns["BangDuLieu"].HeaderText = "Bảng dữ liệu";
            dgvNhatKy.Columns["KhoaChinh"].HeaderText = "Khóa chính";
            dgvNhatKy.Columns["MoTa"].HeaderText = "Mô tả";
            dgvNhatKy.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dgvNhatKy.Columns["HoVaTen"].HeaderText = "Họ và tên";
            dgvNhatKy.Columns["VaiTro"].HeaderText = "Vai trò";

            dgvNhatKy.Columns["ID"].Width = 60;
            dgvNhatKy.Columns["ThoiGian"].Width = 140;
            dgvNhatKy.Columns["HanhDong"].Width = 100;
            dgvNhatKy.Columns["BangDuLieu"].Width = 120;
            dgvNhatKy.Columns["KhoaChinh"].Width = 100;
            dgvNhatKy.Columns["TenDangNhap"].Width = 120;
            dgvNhatKy.Columns["VaiTro"].Width = 120;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);
            string tuKhoa = txtTuKhoa.Text.Trim().ToLower();

            using AppDbContext context = new AppDbContext();

            var query = context.NhatKyHeThong
                .AsNoTracking()
                .Where(r => r.ThoiGian >= tuNgay && r.ThoiGian <= denNgay);

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                query = query.Where(r =>
                    (r.HanhDong ?? "").ToLower().Contains(tuKhoa) ||
                    (r.BangDuLieu ?? "").ToLower().Contains(tuKhoa) ||
                    (r.KhoaChinh ?? "").ToLower().Contains(tuKhoa) ||
                    (r.MoTa ?? "").ToLower().Contains(tuKhoa) ||
                    (r.TenDangNhap ?? "").ToLower().Contains(tuKhoa) ||
                    (r.HoVaTen ?? "").ToLower().Contains(tuKhoa) ||
                    (r.VaiTro ?? "").ToLower().Contains(tuKhoa));
            }

            var ds = query
                .OrderByDescending(r => r.ThoiGian)
                .Select(r => new
                {
                    r.ID,
                    r.ThoiGian,
                    r.HanhDong,
                    r.BangDuLieu,
                    r.KhoaChinh,
                    r.MoTa,
                    r.TenDangNhap,
                    r.HoVaTen,
                    r.VaiTro
                })
                .ToList();

            dgvNhatKy.DataSource = ds;
            DinhDangLuoi();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;
            HienThiDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}