using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.DTOs;
using QuanLyCuaHangSachMini.Reports;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmPhieuHoanTra : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private readonly int nhanVienDangNhapID = 0;
        private readonly string quyenHanNguoiDung = "";

        public frmPhieuHoanTra()
        {
            InitializeComponent();
        }

        public frmPhieuHoanTra(int nhanVienID, string quyenHan)
        {
            InitializeComponent();
            nhanVienDangNhapID = nhanVienID;
            quyenHanNguoiDung = quyenHan ?? "";
        }

        private void frmPhieuHoanTra_Load(object sender, EventArgs e)
        {
            dgvPhieuHoanTra.AutoGenerateColumns = false;
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            IQueryable<Data.Entity.PhieuHoanTra> query = context.PhieuHoanTra
                .AsNoTracking()
                .Include(r => r.HoaDon)
                    .ThenInclude(r => r.KhachHang)
                .Include(r => r.NhanVien)
                .Include(r => r.PhieuHoanTra_ChiTiet);

            if (quyenHanNguoiDung == "nhanvien")
                query = query.Where(r => r.NhanVienID == nhanVienDangNhapID);

            List<DanhSachPhieuHoanTra> ds = query
                .Select(r => new DanhSachPhieuHoanTra
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    NhanVienID = r.NhanVienID,
                    KhachHangID = r.HoaDon.KhachHangID,
                    MaPhieuHoanTra = r.MaPhieuHoanTra,
                    MaHoaDon = r.HoaDon.MaHoaDon,
                    TenNhanVien = r.NhanVien.HoVaTen,
                    TenKhachHang = r.HoaDon.KhachHang.HoVaTen,
                    NgayHoanTra = r.NgayHoanTra,
                    LyDo = r.LyDo,
                    TongTienHoan = r.PhieuHoanTra_ChiTiet.Sum(ct => (decimal?)ct.SoLuongTra * ct.DonGiaHoanTra) ?? 0,
                    XemChiTiet = "Xem chi tiết"
                })
                .OrderBy(r => r.NgayHoanTra)
                .ThenBy(r => r.ID)
                .ToList();

            dgvPhieuHoanTra.DataSource = null;
            dgvPhieuHoanTra.DataSource = ds;
        }

        private void dgvPhieuHoanTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private DanhSachPhieuHoanTra? LayDongDangChon()
        {
            if (dgvPhieuHoanTra.CurrentRow?.DataBoundItem is DanhSachPhieuHoanTra row)
                return row;

            return null;
        }

        private int LayPhieuHoanTraIDTuDong(DanhSachPhieuHoanTra row)
        {
            int phieuHoanTraID = row.ID;
            if (phieuHoanTraID <= 0 && !string.IsNullOrWhiteSpace(row.MaPhieuHoanTra))
            {
                phieuHoanTraID = context.PhieuHoanTra
                    .AsNoTracking()
                    .Where(x => x.MaPhieuHoanTra == row.MaPhieuHoanTra)
                    .Select(x => x.ID)
                    .FirstOrDefault();
            }

            return phieuHoanTraID;
        }

        private void MoChiTiet(DanhSachPhieuHoanTra row)
        {
            int phieuHoanTraID = LayPhieuHoanTraIDTuDong(row);
            if (phieuHoanTraID <= 0)
            {
                MessageBox.Show(
                    $"ID phiếu hoàn trả không hợp lệ. Mã phiếu: {row.MaPhieuHoanTra}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            using (frmPhieuHoanTra_ChiTiet frm = new frmPhieuHoanTra_ChiTiet(
                phieuHoanTraID, false, true, nhanVienDangNhapID, quyenHanNguoiDung))
            {
                frm.ShowDialog();
            }
        }

        private void MoInPhieu(DanhSachPhieuHoanTra row)
        {
            int phieuHoanTraID = LayPhieuHoanTraIDTuDong(row);
            if (phieuHoanTraID <= 0)
            {
                MessageBox.Show(
                    $"ID phiếu hoàn trả không hợp lệ. Mã phiếu: {row.MaPhieuHoanTra}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            using (frmInPhieuHoanTra frm = new frmInPhieuHoanTra(phieuHoanTraID))
            {
                frm.ShowDialog();
            }
        }

        private void dgvPhieuHoanTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string colName = dgvPhieuHoanTra.Columns[e.ColumnIndex].Name;
            if (colName != "XemChiTiet")
                return;

            if (dgvPhieuHoanTra.Rows[e.RowIndex].DataBoundItem is not DanhSachPhieuHoanTra row)
            {
                MessageBox.Show("Không lấy được dữ liệu phiếu hoàn trả.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MoChiTiet(row);
            TaiDuLieu();
        }

        private void dgvPhieuHoanTra_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            DanhSachPhieuHoanTra? row = LayDongDangChon();
            if (row == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu hoàn trả.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MoInPhieu(row);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
