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
            HienThiDuLieu(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
        }

        private void HienThiDuLieu(DateTime? tuNgay = null, DateTime? denNgay = null, string tuKhoa = "")
        {
            using AppDbContext context = new AppDbContext();

            var query = context.NhatKyHeThong.AsNoTracking();

            if (tuNgay.HasValue && denNgay.HasValue)
            {
                DateTime tu = tuNgay.Value.Date;
                DateTime den = denNgay.Value.Date.AddDays(1).AddTicks(-1);
                query = query.Where(r => r.ThoiGian >= tu && r.ThoiGian <= den);
            }

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                string mauTim = "%" + tuKhoa.Trim() + "%";
                query = query.Where(r =>
                    EF.Functions.Like(r.HanhDong, mauTim) ||
                    EF.Functions.Like(r.BangDuLieu, mauTim) ||
                    EF.Functions.Like(r.KhoaChinh ?? "", mauTim) ||
                    EF.Functions.Like(r.MoTa ?? "", mauTim) ||
                    EF.Functions.Like(r.TenDangNhap ?? "", mauTim) ||
                    EF.Functions.Like(r.HoVaTen ?? "", mauTim) ||
                    EF.Functions.Like(r.VaiTro ?? "", mauTim));
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
            string tuKhoa = txtTuKhoa.Text.Trim();
            HienThiDuLieu(tuNgay, denNgay, tuKhoa);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;
            HienThiDuLieu(dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
