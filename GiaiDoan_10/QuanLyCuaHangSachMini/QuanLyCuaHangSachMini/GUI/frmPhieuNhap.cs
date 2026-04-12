using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.DTOs;
using QuanLyCuaHangSachMini.Helpers;
using QuanLyCuaHangSachMini.Reports;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmPhieuNhap : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private int id = 0;
        private readonly int nhanVienDangNhapID = 0;
        private readonly string quyenHanNguoiDung = "";

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        public frmPhieuNhap(int nhanVienID, string quyenHan)
        {
            InitializeComponent();
            nhanVienDangNhapID = nhanVienID;
            quyenHanNguoiDung = quyenHan ?? "";
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.AutoGenerateColumns = false;
            TaiDuLieu();
            PhanQuyenChucNang();
        }

        private void PhanQuyenChucNang()
        {
            bool laAdmin = quyenHanNguoiDung.Equals("admin", StringComparison.OrdinalIgnoreCase);

            btnLapPhieuNhap.Enabled = laAdmin;
            btnXoaPhieuNhap.Enabled = laAdmin && dgvPhieuNhap.Rows.Count > 0;
        }

        private void TaiDuLieu()
        {
            List<DanhSachPhieuNhap> ds = context.PhieuNhap
                .AsNoTracking()
                .Select(r => new DanhSachPhieuNhap
                {
                    ID = r.ID,
                    MaPhieuNhap = r.MaPhieuNhap,
                    NhaCungCapID = r.NhaCungCapID,
                    TenNhaCungCap = r.NhaCungCap.TenNhaCungCap,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    NgayNhap = r.NgayNhap,
                    GhiChuPhieuNhap = r.GhiChuPhieuNhap,
                    TongTienPhieuNhap = r.PhieuNhap_ChiTiet.Sum(ct => (decimal?)ct.SoLuongNhap * ct.DonGiaNhap) ?? 0,
                    XemChiTiet = "Xem chi tiết"
                })
                .OrderBy(r => r.ID)
                .ToList();

            dgvPhieuNhap.DataSource = null;
            dgvPhieuNhap.DataSource = ds;

            if (dgvPhieuNhap.Rows.Count > 0 && dgvPhieuNhap.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvPhieuNhap.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
            }
            else
            {
                id = 0;
            }

            PhanQuyenChucNang();
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            if (!quyenHanNguoiDung.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Chỉ quản trị viên mới được lập phiếu nhập.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (frmPhieuNhapChiTiet frm = new frmPhieuNhapChiTiet(0, false, nhanVienDangNhapID, quyenHanNguoiDung))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    TaiDuLieu();
            }
        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            if (!quyenHanNguoiDung.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Chỉ quản trị viên mới được xóa phiếu nhập.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvPhieuNhap.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int phieuNhapID = Convert.ToInt32(dgvPhieuNhap.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");

            if (MessageBox.Show("Xác nhận xóa phiếu nhập này?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using var transaction = context.Database.BeginTransaction();
                try
                {
                    PhieuNhap? pn = context.PhieuNhap
                        .Include(r => r.PhieuNhap_ChiTiet)
                        .FirstOrDefault(r => r.ID == phieuNhapID);

                    if (pn == null)
                    {
                        MessageBox.Show("Không tìm thấy phiếu nhập cần xóa.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        transaction.Rollback();
                        return;
                    }

                    foreach (var ct in pn.PhieuNhap_ChiTiet)
                    {
                        Sach? s = context.Sach.Find(ct.SachID);
                        if (s != null && s.SoLuongTon < ct.SoLuongNhap)
                        {
                            MessageBox.Show(
                                $"Không thể xóa phiếu nhập {pn.MaPhieuNhap} vì sách \"{s.TenSach}\" chỉ còn {s.SoLuongTon} quyển trong kho.",
                                "Không thể xóa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }
                    }

                    foreach (var ct in pn.PhieuNhap_ChiTiet.ToList())
                    {
                        Sach? s = context.Sach.Find(ct.SachID);
                        if (s != null)
                        {
                            s.SoLuongTon -= ct.SoLuongNhap;
                            s.TrangThai = s.SoLuongTon > 0 ? "Còn hàng" : "Hết hàng";

                            var chiTietNhapConLai = context.PhieuNhap_ChiTiet
                                .Include(x => x.PhieuNhap)
                                .Where(x => x.SachID == s.ID && x.PhieuNhapID != pn.ID)
                                .OrderByDescending(x => x.PhieuNhap.NgayNhap)
                                .ThenByDescending(x => x.ID)
                                .FirstOrDefault();

                            s.GiaNhap = chiTietNhapConLai != null ? chiTietNhapConLai.DonGiaNhap : 0;
                        }
                    }

                    context.PhieuNhap_ChiTiet.RemoveRange(pn.PhieuNhap_ChiTiet);
                    context.PhieuNhap.Remove(pn);
                    context.SaveChanges();
                    transaction.Commit();

                    NhatKyHelper.GhiLog(
                        "Xóa",
                        "PhieuNhap",
                        pn.ID.ToString(),
                        "Xóa phiếu nhập: " + pn.MaPhieuNhap
                    );

                    TaiDuLieu();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    string loi = ex.Message;
                    if (ex.InnerException != null)
                        loi += "\n\n" + ex.InnerException.Message;
                    if (ex.InnerException != null && ex.InnerException.InnerException != null)
                        loi += "\n\n" + ex.InnerException.InnerException.Message;

                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần in.");
                return;
            }

            int id = Convert.ToInt32(dgvPhieuNhap.CurrentRow.Cells["ID"].Value);

            using (frmInPhieuNhap inPhieuNhap = new frmInPhieuNhap(id))
            {
                inPhieuNhap.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhieuNhap.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvPhieuNhap.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                PhanQuyenChucNang();
            }
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhieuNhap.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                int phieuNhapID = Convert.ToInt32(dgvPhieuNhap.Rows[e.RowIndex].Cells["ID"].Value?.ToString() ?? "0");

                using (frmPhieuNhapChiTiet frm = new frmPhieuNhapChiTiet(phieuNhapID, true, nhanVienDangNhapID, quyenHanNguoiDung))
                {
                    frm.ShowDialog();
                }

                TaiDuLieu();
            }
        }

        private void dgvPhieuNhap_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
