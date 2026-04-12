using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.DTOs;
using QuanLyCuaHangSachMini.Helpers;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmPhieuHoanTra_ChiTiet : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private readonly BindingList<DanhSachPhieuHoanTra_ChiTiet> dsChiTiet = new BindingList<DanhSachPhieuHoanTra_ChiTiet>();
        private List<DanhSachPhieuHoanTra_ChiTiet> dsHoaDonChiTiet = new List<DanhSachPhieuHoanTra_ChiTiet>();

        private int hoaDonID;
        private int phieuHoanTraID;
        private bool laHoaDon;
        private bool chiXem;
        private int nhanVienDangNhapID;
        private string quyenHanNguoiDung = string.Empty;

        public frmPhieuHoanTra_ChiTiet(int id, bool laHoaDonID, bool chiXemChiTiet = false, int nhanVienID = 0, string quyenHan = "")
        {
            InitializeComponent();

            if (laHoaDonID)
                hoaDonID = id;
            else
                phieuHoanTraID = id;

            laHoaDon = laHoaDonID;
            chiXem = chiXemChiTiet;
            nhanVienDangNhapID = nhanVienID;
            quyenHanNguoiDung = quyenHan ?? string.Empty;
        }

        private void frmPhieuHoanTra_ChiTiet_Load(object sender, EventArgs e)
        {
            numSoLuongTra.Minimum = 1;
            numSoLuongTra.Maximum = 100000;
            numSoLuongTra.Value = 1;

            numDonGiaHoanTra.Minimum = 0;
            numDonGiaHoanTra.Maximum = 1000000000;
            numDonGiaHoanTra.Value = 0;

            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.DataSource = null;

            if (laHoaDon)
            {
                if (hoaDonID <= 0 || !NapDuLieuTuHoaDon())
                    return;

                PhieuHoanTra? daCo = context.PhieuHoanTra.AsNoTracking().FirstOrDefault(r => r.HoaDonID == hoaDonID);
                if (daCo != null)
                {
                    MessageBox.Show("Hóa đơn này đã có phiếu hoàn trả. Sẽ mở ở chế độ xem.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    phieuHoanTraID = daCo.ID;
                    laHoaDon = false;
                    chiXem = true;
                    NapDuLieuTuPhieuHoanTra();
                }
            }
            else if (phieuHoanTraID > 0)
            {
                chiXem = true;
                NapDuLieuTuPhieuHoanTra();
            }
            else
            {
                MessageBox.Show("Không xác định được dữ liệu phiếu hoàn trả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            CapNhatChucNangTheoTrangThai();
        }

        private bool NapDuLieuTuHoaDon()
        {
            HoaDon? hoaDon = context.HoaDon
                .Include(r => r.KhachHang)
                .Include(r => r.NhanVien)
                .FirstOrDefault(r => r.ID == hoaDonID);

            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn gốc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return false;
            }

            if (quyenHanNguoiDung == "nhanvien" && hoaDon.NhanVienID != nhanVienDangNhapID)
            {
                MessageBox.Show("Bạn chỉ được hoàn trả hóa đơn do chính bạn lập.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return false;
            }

            txtMaHoaDon.Text = hoaDon.MaHoaDon;
            txtKhachHang.Text = hoaDon.KhachHang?.HoVaTen ?? string.Empty;
            txtNhanVienXuLy.Text = LayTenNhanVienDangNhap();
            txtMaPhieuHoanTra.Text = PhatSinhMaPhieuHoanTra();
            txtNgayHoanTra.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtLyDo.Clear();
            txtTongTien.Text = "0";

            dsHoaDonChiTiet = context.HoaDon_ChiTiet
                .Include(r => r.Sach)
                .Where(r => r.HoaDonID == hoaDonID)
                .OrderBy(r => r.ID)
                .Select(r => new DanhSachPhieuHoanTra_ChiTiet
                {
                    HoaDonChiTietID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SachID = r.SachID,
                    MaSach = r.Sach.MaSach,
                    TenSach = r.Sach.TenSach,
                    SoLuongBan = r.SoLuongBan,
                    SoLuongTra = 0,
                    DonGiaHoanTra = r.DonGiaBan
                })
                .ToList();

            if (dsHoaDonChiTiet.Count == 0)
            {
                MessageBox.Show("Hóa đơn này không có chi tiết để hoàn trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return false;
            }

            GanDuLieuComboSach(dsHoaDonChiTiet, true);
            dsChiTiet.Clear();
            TaiLaiLuoiChiTiet();
            return true;
        }

        private void NapDuLieuTuPhieuHoanTra()
        {
            PhieuHoanTra? phieu = context.PhieuHoanTra
                .Include(r => r.HoaDon)
                    .ThenInclude(r => r.KhachHang)
                .Include(r => r.NhanVien)
                .Include(r => r.PhieuHoanTra_ChiTiet)
                    .ThenInclude(r => r.Sach)
                .FirstOrDefault(r => r.ID == phieuHoanTraID);

            if (phieu == null)
            {
                MessageBox.Show("Không tìm thấy phiếu hoàn trả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            hoaDonID = phieu.HoaDonID;
            txtMaPhieuHoanTra.Text = phieu.MaPhieuHoanTra;
            txtNgayHoanTra.Text = phieu.NgayHoanTra.ToString("dd/MM/yyyy HH:mm:ss");
            txtMaHoaDon.Text = phieu.HoaDon?.MaHoaDon ?? string.Empty;
            txtKhachHang.Text = phieu.HoaDon?.KhachHang?.HoVaTen ?? string.Empty;
            txtNhanVienXuLy.Text = phieu.NhanVien?.HoVaTen ?? string.Empty;
            txtLyDo.Text = phieu.LyDo ?? string.Empty;

            var dsHoaDon = context.HoaDon_ChiTiet
                .Include(r => r.Sach)
                .Where(r => r.HoaDonID == hoaDonID)
                .OrderBy(r => r.ID)
                .Select(r => new
                {
                    r.ID,
                    r.HoaDonID,
                    r.SachID,
                    r.Sach.MaSach,
                    r.Sach.TenSach,
                    r.SoLuongBan,
                    r.DonGiaBan
                })
                .ToList()
                .ToDictionary(r => r.SachID, r => r);

            dsChiTiet.Clear();
            foreach (PhieuHoanTra_ChiTiet ct in phieu.PhieuHoanTra_ChiTiet.OrderBy(r => r.ID))
            {
                dsHoaDon.TryGetValue(ct.SachID, out var chitietHoaDon);

                dsChiTiet.Add(new DanhSachPhieuHoanTra_ChiTiet
                {
                    ID = ct.ID,
                    HoaDonChiTietID = chitietHoaDon?.ID ?? 0,
                    HoaDonID = hoaDonID,
                    SachID = ct.SachID,
                    MaSach = chitietHoaDon?.MaSach ?? ct.Sach.MaSach,
                    TenSach = chitietHoaDon?.TenSach ?? ct.Sach.TenSach,
                    SoLuongBan = chitietHoaDon?.SoLuongBan ?? ct.SoLuongTra,
                    SoLuongTra = ct.SoLuongTra,
                    DonGiaHoanTra = ct.DonGiaHoanTra
                });
            }

            dsHoaDonChiTiet = dsChiTiet
                .Select(r => new DanhSachPhieuHoanTra_ChiTiet
                {
                    HoaDonChiTietID = r.HoaDonChiTietID,
                    HoaDonID = r.HoaDonID,
                    SachID = r.SachID,
                    MaSach = r.MaSach,
                    TenSach = r.TenSach,
                    SoLuongBan = r.SoLuongBan,
                    SoLuongTra = 0,
                    DonGiaHoanTra = r.DonGiaHoanTra
                })
                .ToList();

            GanDuLieuComboSach(dsHoaDonChiTiet, false);
            txtTongTien.Text = dsChiTiet.Sum(r => r.ThanhTien).ToString("N0");
            TaiLaiLuoiChiTiet();
        }

        private void GanDuLieuComboSach(List<DanhSachPhieuHoanTra_ChiTiet> ds, bool chonDauTien)
        {
            cboSach.DataSource = null;
            cboSach.DisplayMember = nameof(DanhSachPhieuHoanTra_ChiTiet.TenSach);
            cboSach.ValueMember = nameof(DanhSachPhieuHoanTra_ChiTiet.SachID);
            cboSach.DataSource = ds;

            if (ds.Count > 0)
            {
                cboSach.SelectedIndex = 0;
                if (chonDauTien)
                    cboSach_SelectionChangeCommitted(cboSach, EventArgs.Empty);
            }
        }
        private string LayTenNhanVienDangNhap()
        {
            if (nhanVienDangNhapID <= 0)
                return string.Empty;

            return context.NhanVien
                .AsNoTracking()
                .Where(r => r.ID == nhanVienDangNhapID)
                .Select(r => r.HoVaTen)
                .FirstOrDefault() ?? string.Empty;
        }

        private string PhatSinhMaPhieuHoanTra()
        {
            string? maCuoi = context.PhieuHoanTra
                .AsNoTracking()
                .OrderByDescending(r => r.ID)
                .Select(r => r.MaPhieuHoanTra)
                .FirstOrDefault();

            int soThuTu = 1;
            if (!string.IsNullOrWhiteSpace(maCuoi) && maCuoi.StartsWith("PHT", StringComparison.OrdinalIgnoreCase))
            {
                string phanSo = maCuoi.Substring(3);
                if (int.TryParse(phanSo, out int so))
                    soThuTu = so + 1;
            }
            else if (context.PhieuHoanTra.Any())
            {
                soThuTu = context.PhieuHoanTra.Max(r => r.ID) + 1;
            }

            return $"PHT{soThuTu:D3}";
        }

        private void CapNhatChucNangTheoTrangThai()
        {
            bool duocSua = !chiXem;

            cboSach.Enabled = duocSua;
            numSoLuongTra.Enabled = duocSua;
            numDonGiaHoanTra.Enabled = duocSua;
            btnThemSach.Enabled = duocSua;
            btnXoaSach.Enabled = duocSua;
            btnLuuPhieuHoanTra.Enabled = duocSua;
            btnHuyBo.Enabled = duocSua;
            txtLyDo.ReadOnly = !duocSua;

            Text = chiXem ? "Phiếu hoàn trả" : "Lập phiếu hoàn trả";
        }

        private DanhSachPhieuHoanTra_ChiTiet? LayChiTietDangChon()
        {
            if (dgvChiTiet.CurrentRow == null || dgvChiTiet.CurrentRow.DataBoundItem == null)
                return null;

            return dgvChiTiet.CurrentRow.DataBoundItem as DanhSachPhieuHoanTra_ChiTiet;
        }

        private void CapNhatTongTien()
        {
            txtTongTien.Text = dsChiTiet.Sum(r => r.ThanhTien).ToString("N0");
        }

        private void TaiLaiLuoiChiTiet(int? sachIDCanChon = null)
        {
            dgvChiTiet.DataSource = null;
            dgvChiTiet.DataSource = dsChiTiet.ToList();
            CapNhatTongTien();

            if (dgvChiTiet.Rows.Count == 0)
                return;

            int dongCanChon = 0;
            if (sachIDCanChon.HasValue)
            {
                foreach (DataGridViewRow row in dgvChiTiet.Rows)
                {
                    if (row.Cells["SachID"].Value != null && Convert.ToInt32(row.Cells["SachID"].Value) == sachIDCanChon.Value)
                    {
                        dongCanChon = row.Index;
                        break;
                    }
                }
            }

            dgvChiTiet.ClearSelection();
            dgvChiTiet.Rows[dongCanChon].Selected = true;
            dgvChiTiet.CurrentCell = dgvChiTiet.Rows[dongCanChon].Cells["TenSach"];
            HienThiThongTinSach();
        }

        private void HienThiThongTinSach()
        {
            DanhSachPhieuHoanTra_ChiTiet? item = LayChiTietDangChon();
            if (item == null)
                return;

            if (cboSach.Items.Count > 0)
                cboSach.SelectedValue = item.SachID;

            txtSoLuongBan.Text = item.SoLuongBan.ToString("N0");
            numSoLuongTra.Value = Math.Min(Math.Max(item.SoLuongTra, (int)numSoLuongTra.Minimum), (int)numSoLuongTra.Maximum);
            numDonGiaHoanTra.Value = Math.Min(Math.Max(item.DonGiaHoanTra, numDonGiaHoanTra.Minimum), numDonGiaHoanTra.Maximum);
        }

        private void cboSach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSach.SelectedItem is not DanhSachPhieuHoanTra_ChiTiet item)
                return;

            txtSoLuongBan.Text = item.SoLuongBan.ToString("N0");
            numSoLuongTra.Maximum = Math.Max(1, item.SoLuongBan);
            numSoLuongTra.Value = 1;
            numDonGiaHoanTra.Value = Math.Min(Math.Max(item.DonGiaHoanTra, numDonGiaHoanTra.Minimum), numDonGiaHoanTra.Maximum);
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (chiXem)
                return;

            if (cboSach.SelectedItem is not DanhSachPhieuHoanTra_ChiTiet item)
            {
                MessageBox.Show("Vui lòng chọn sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soLuongTra = Convert.ToInt32(numSoLuongTra.Value);
            if (soLuongTra <= 0)
            {
                MessageBox.Show("Số lượng hoàn trả phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (soLuongTra > item.SoLuongBan)
            {
                MessageBox.Show($"Sách \"{item.TenSach}\" chỉ được hoàn trả tối đa {item.SoLuongBan} quyển.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal donGia = numDonGiaHoanTra.Value;
            DanhSachPhieuHoanTra_ChiTiet? daCo = dsChiTiet.FirstOrDefault(r => r.SachID == item.SachID);

            if (daCo != null)
            {
                daCo.HoaDonChiTietID = item.HoaDonChiTietID;
                daCo.HoaDonID = item.HoaDonID;
                daCo.MaSach = item.MaSach;
                daCo.TenSach = item.TenSach;
                daCo.SoLuongBan = item.SoLuongBan;
                daCo.SoLuongTra = soLuongTra;
                daCo.DonGiaHoanTra = donGia;
            }
            else
            {
                dsChiTiet.Add(new DanhSachPhieuHoanTra_ChiTiet
                {
                    HoaDonChiTietID = item.HoaDonChiTietID,
                    HoaDonID = item.HoaDonID,
                    SachID = item.SachID,
                    MaSach = item.MaSach,
                    TenSach = item.TenSach,
                    SoLuongBan = item.SoLuongBan,
                    SoLuongTra = soLuongTra,
                    DonGiaHoanTra = donGia
                });
            }

            TaiLaiLuoiChiTiet(item.SachID);
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (chiXem)
                return;

            DanhSachPhieuHoanTra_ChiTiet? item = LayChiTietDangChon();
            if (item == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa khỏi phiếu hoàn trả.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dsChiTiet.Remove(item);
            TaiLaiLuoiChiTiet();
        }

        private void btnLuuPhieuHoanTra_Click(object sender, EventArgs e)
        {
            if (chiXem)
                return;

            if (hoaDonID <= 0)
            {
                MessageBox.Show("Không xác định được hóa đơn gốc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLyDo.Text))
            {
                MessageBox.Show("Vui lòng nhập lý do hoàn trả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dsChiTiet.Count == 0)
            {
                MessageBox.Show("Phiếu hoàn trả phải có ít nhất 1 sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (context.PhieuHoanTra.Any(r => r.HoaDonID == hoaDonID))
            {
                MessageBox.Show("Hóa đơn này đã có phiếu hoàn trả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var transaction = context.Database.BeginTransaction();
            try
            {
                PhieuHoanTra phieu = new PhieuHoanTra
                {
                    MaPhieuHoanTra = PhatSinhMaPhieuHoanTra(),
                    HoaDonID = hoaDonID,
                    NhanVienID = nhanVienDangNhapID,
                    NgayHoanTra = DateTime.Now,
                    LyDo = txtLyDo.Text.Trim()
                };

                context.PhieuHoanTra.Add(phieu);
                context.SaveChanges();

                foreach (DanhSachPhieuHoanTra_ChiTiet item in dsChiTiet)
                {
                    context.PhieuHoanTra_ChiTiet.Add(new PhieuHoanTra_ChiTiet
                    {
                        PhieuHoanTraID = phieu.ID,
                        SachID = item.SachID,
                        SoLuongTra = item.SoLuongTra,
                        DonGiaHoanTra = item.DonGiaHoanTra
                    });

                    Sach? sach = context.Sach.FirstOrDefault(r => r.ID == item.SachID);
                    if (sach != null)
                    {
                        sach.SoLuongTon += item.SoLuongTra;
                        sach.TrangThai = sach.SoLuongTon > 0 ? "Còn hàng" : "Hết hàng";
                    }
                }

                context.SaveChanges();
                transaction.Commit();

                NhatKyHelper.GhiLog(
                    "Thêm",
                    "PhieuHoanTra",
                    phieu.ID.ToString(),
                    $"Lập phiếu hoàn trả {phieu.MaPhieuHoanTra} cho hóa đơn {txtMaHoaDon.Text}"
                );

                MessageBox.Show("Lập phiếu hoàn trả thành công.", "Hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                string loi = ex.Message;
                if (ex.InnerException != null)
                    loi += Environment.NewLine + ex.InnerException.Message;

                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (chiXem)
                return;

            if (laHoaDon && hoaDonID > 0)
                NapDuLieuTuHoaDon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                HienThiThongTinSach();
        }

        private void dgvChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow != null)
                HienThiThongTinSach();
        }

        private void dgvChiTiet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
