using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.Helpers;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        private readonly AppDbContext _context = new AppDbContext();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            if (!SessionHelper.LaQuanTri)
            {
                MessageBox.Show("Chỉ quản trị viên mới có quyền đổi mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            // Hiển thị theo mã nhân viên (NV...) và sắp xếp theo phần số trong mã, hiển thị dạng "Mã - Họ và tên (tên đăng nhập)"
            // Không hiển thị tài khoản quản trị viên trong danh sách (admin không cần đổi mật khẩu)
            cboNhanVien.DataSource = _context.NhanVien
                .Where(r => r.KichHoat && !r.QuyenHan)
                .AsEnumerable()
                .OrderBy(r =>
                {
                    var digits = new string((r.MaNhanVien ?? "").Where(char.IsDigit).ToArray());
                    return int.TryParse(digits, out int n) ? n : int.MaxValue;
                })
                .Select(r => new { r.ID, TenHienThi = (r.MaNhanVien ?? "") + " - " + (r.HoVaTen ?? "") + " (" + (r.TenDangNhap ?? "") + ")" })
                .ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "TenHienThi";

            if (cboNhanVien.Items.Count > 0)
                cboNhanVien.SelectedIndex = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!SessionHelper.LaQuanTri)
                return;

            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text) || string.IsNullOrWhiteSpace(txtXacNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới và xác nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nvId = Convert.ToInt32(cboNhanVien.SelectedValue);
            var nv = _context.NhanVien.Find(nvId);
            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            if (matKhauMoi.Length < 4)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 4 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauMoi.Focus();
                return;
            }

            using var transaction = _context.Database.BeginTransaction();
            try
            {
                // Hash mật khẩu mới và lưu
                nv.MatKhau = PasswordHelper.HashPassword(matKhauMoi);
                _context.NhanVien.Update(nv);
                _context.SaveChanges();

                // Đọc lại từ DB để xác nhận (không track)
                var nvReload = _context.NhanVien.AsNoTracking().FirstOrDefault(x => x.ID == nvId);
                if (nvReload == null || !PasswordHelper.VerifyPassword(matKhauMoi, nvReload.MatKhau))
                    throw new Exception("Xác nhận lưu mật khẩu thất bại.");

                transaction.Commit();

                NhatKyHelper.GhiLog("Cập nhật", "NhanVien", nv.ID.ToString(), "Cập nhật mật khẩu cho nhân viên: " + nv.HoVaTen);

                MessageBox.Show("Cập nhật mật khẩu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Lỗi cập nhật mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
