using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.DTOs;
using QuanLyCuaHangSachMini.Helpers;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmPhieuNhapChiTiet : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private List<DanhSachPhieuNhapChiTiet> dsChiTietTam = new List<DanhSachPhieuNhapChiTiet>();
        private int idPhieuNhap = 0;
        private bool chiXem = false;

        public frmPhieuNhapChiTiet()
        {
            InitializeComponent();
        }

        public frmPhieuNhapChiTiet(int phieuNhapID, bool chiXemChiTiet)
        {
            InitializeComponent();
            idPhieuNhap = phieuNhapID;
            chiXem = chiXemChiTiet;
        }

        private void BatTatChucNang(bool giaTri)
        {
            cboNhaCungCap.Enabled = giaTri;
            cboNhanVien.Enabled = giaTri;
            dtpNgayNhap.Enabled = giaTri;
            txtGhiChu.Enabled = giaTri;

            cboTenSach.Enabled = giaTri;
            numSoLuongNhap.Enabled = giaTri;
            numDonGiaNhap.Enabled = giaTri;

            btnThemSach.Enabled = giaTri;
            btnXoaSach.Enabled = giaTri;
            btnLuuPhieuNhap.Enabled = giaTri;
        }

        private void frmPhieuNhapChiTiet_Load(object sender, EventArgs e)
        {
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.CellClick -= dgvChiTiet_CellClick;
            dgvChiTiet.SelectionChanged -= dgvChiTiet_SelectionChanged;
            dgvChiTiet.CellClick += dgvChiTiet_CellClick;
            dgvChiTiet.SelectionChanged += dgvChiTiet_SelectionChanged;

            numSoLuongNhap.Minimum = 1;
            numSoLuongNhap.Maximum = 100000;
            numSoLuongNhap.ThousandsSeparator = true;

            numDonGiaNhap.Minimum = 1;
            numDonGiaNhap.Maximum = 1000000000;
            numDonGiaNhap.ThousandsSeparator = true;

            cboNhaCungCap.DataSource = context.NhaCungCap.OrderBy(r => r.TenNhaCungCap).ToList();
            cboNhaCungCap.ValueMember = "ID";
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";

            cboNhanVien.DataSource = context.NhanVien
                .Where(r => r.KichHoat)
                .OrderBy(r => r.HoVaTen)
                .ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";

            cboTenSach.DataSource = context.Sach
                .OrderBy(r => r.TenSach)
                .ToList();
            cboTenSach.ValueMember = "ID";
            cboTenSach.DisplayMember = "TenSach";

            if (idPhieuNhap == 0)
            {
                BatTatChucNang(true);

                int soLonNhat = 0;
                if (context.PhieuNhap.Any())
                {
                    soLonNhat = context.PhieuNhap
                        .AsEnumerable()
                        .Select(r =>
                        {
                            if (string.IsNullOrWhiteSpace(r.MaPhieuNhap))
                                return 0;

                            string so = new string(r.MaPhieuNhap.Where(char.IsDigit).ToArray());
                            return int.TryParse(so, out int kq) ? kq : 0;
                        })
                        .DefaultIfEmpty(0)
                        .Max();
                }

                txtMaPhieuNhap.Text = "PN" + (soLonNhat + 1).ToString("000");
                dtpNgayNhap.Value = DateTime.Now;
                txtGhiChu.Clear();
                dsChiTietTam.Clear();
                TaiLaiLuoiChiTiet();

                if (cboTenSach.Items.Count > 0)
                {
                    cboTenSach.SelectedIndex = 0;
                    cboTenSach_SelectedIndexChanged(sender, e);
                }

                numSoLuongNhap.Value = 1;
                numDonGiaNhap.Value = 1;
            }
            else
            {
                PhieuNhap? pn = context.PhieuNhap
                    .Include(r => r.PhieuNhap_ChiTiet)
                    .ThenInclude(r => r.Sach)
                    .FirstOrDefault(r => r.ID == idPhieuNhap);

                if (pn != null)
                {
                    txtMaPhieuNhap.Text = pn.MaPhieuNhap;
                    cboNhaCungCap.SelectedValue = pn.NhaCungCapID;
                    cboNhanVien.SelectedValue = pn.NhanVienID;
                    dtpNgayNhap.Value = pn.NgayNhap;
                    txtGhiChu.Text = pn.GhiChuPhieuNhap ?? "";

                    dsChiTietTam = pn.PhieuNhap_ChiTiet
                        .Select(r => new DanhSachPhieuNhapChiTiet
                        {
                            ID = r.ID,
                            PhieuNhapID = r.PhieuNhapID,
                            SachID = r.SachID,
                            MaSach = r.Sach.MaSach,
                            TenSach = r.Sach.TenSach,
                            SoLuongNhap = r.SoLuongNhap,
                            DonGiaNhap = r.DonGiaNhap,
                            ThanhTien = r.SoLuongNhap * r.DonGiaNhap
                        })
                        .ToList();

                    TaiLaiLuoiChiTiet();
                }

                if (chiXem)
                {
                    BatTatChucNang(false);
                    btnHuyBo.Enabled = false;
                }
                else
                {
                    BatTatChucNang(true);
                }
            }
        }

        private void TaiLaiLuoiChiTiet(int? sachIDCanChon = null)
        {
            dgvChiTiet.DataSource = null;
            dgvChiTiet.DataSource = dsChiTietTam.ToList();
            txtTongTien.Text = dsChiTietTam.Sum(r => r.ThanhTien).ToString("N0");

            if (dgvChiTiet.Rows.Count > 0)
            {
                int rowIndex = 0;

                if (sachIDCanChon.HasValue)
                {
                    foreach (DataGridViewRow row in dgvChiTiet.Rows)
                    {
                        if (row.Cells["SachID"].Value != null &&
                            Convert.ToInt32(row.Cells["SachID"].Value) == sachIDCanChon.Value)
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                }

                dgvChiTiet.ClearSelection();
                dgvChiTiet.Rows[rowIndex].Selected = true;
                dgvChiTiet.CurrentCell = dgvChiTiet.Rows[rowIndex].Cells["MaSach"];
                HienThiThongTinSachNhap();
            }
            else
            {
                XoaTrangThongTinSachNhap();
            }
        }

        private void HienThiThongTinSachNhap()
        {
            if (dgvChiTiet.CurrentRow == null || dgvChiTiet.Rows.Count == 0)
            {
                XoaTrangThongTinSachNhap();
                return;
            }

            int sachID = Convert.ToInt32(dgvChiTiet.CurrentRow.Cells["SachID"].Value.ToString());
            DanhSachPhieuNhapChiTiet? chiTiet = dsChiTietTam.FirstOrDefault(r => r.SachID == sachID);

            if (chiTiet != null)
            {
                txtMaSach.Text = chiTiet.MaSach;
                cboTenSach.SelectedValue = chiTiet.SachID;

                decimal soLuong = chiTiet.SoLuongNhap;
                if (soLuong < numSoLuongNhap.Minimum) soLuong = numSoLuongNhap.Minimum;
                if (soLuong > numSoLuongNhap.Maximum) soLuong = numSoLuongNhap.Maximum;
                numSoLuongNhap.Value = soLuong;

                decimal donGia = chiTiet.DonGiaNhap;
                if (donGia < numDonGiaNhap.Minimum) donGia = numDonGiaNhap.Minimum;
                if (donGia > numDonGiaNhap.Maximum) donGia = numDonGiaNhap.Maximum;
                numDonGiaNhap.Value = donGia;
            }
        }

        private void XoaTrangThongTinSachNhap()
        {
            if (cboTenSach.Items.Count > 0 && !chiXem)
            {
                cboTenSach.SelectedIndex = 0;
                cboTenSach_SelectedIndexChanged(null!, EventArgs.Empty);
            }
            else
            {
                txtMaSach.Clear();
                if (cboTenSach.Items.Count > 0)
                    cboTenSach.SelectedIndex = -1;
            }

            numSoLuongNhap.Value = numSoLuongNhap.Minimum;
            numDonGiaNhap.Value = numDonGiaNhap.Minimum;
        }

        private void cboTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenSach.SelectedValue != null && int.TryParse(cboTenSach.SelectedValue.ToString(), out int sachID))
            {
                Sach? s = context.Sach.Find(sachID);
                if (s != null)
                    txtMaSach.Text = s.MaSach;
            }
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                HienThiThongTinSachNhap();
        }

        private void dgvChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChiTiet.Rows.Count > 0 && dgvChiTiet.CurrentRow != null)
                HienThiThongTinSachNhap();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (cboTenSach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenSach.Focus();
                return;
            }

            if (numSoLuongNhap.Value <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numSoLuongNhap.Focus();
                return;
            }

            if (numDonGiaNhap.Value <= 0)
            {
                MessageBox.Show("Đơn giá nhập phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numDonGiaNhap.Focus();
                return;
            }

            int sachID = Convert.ToInt32(cboTenSach.SelectedValue);
            Sach? s = context.Sach.Find(sachID);

            if (s != null)
            {
                var chiTietDaCo = dsChiTietTam.FirstOrDefault(r => r.SachID == sachID);
                if (chiTietDaCo != null)
                {
                    chiTietDaCo.SoLuongNhap += Convert.ToInt32(numSoLuongNhap.Value);
                    chiTietDaCo.DonGiaNhap = numDonGiaNhap.Value;
                    chiTietDaCo.ThanhTien = chiTietDaCo.SoLuongNhap * chiTietDaCo.DonGiaNhap;
                }
                else
                {
                    DanhSachPhieuNhapChiTiet ct = new DanhSachPhieuNhapChiTiet();
                    ct.ID = 0;
                    ct.PhieuNhapID = 0;
                    ct.SachID = sachID;
                    ct.MaSach = s.MaSach;
                    ct.TenSach = s.TenSach;
                    ct.SoLuongNhap = Convert.ToInt32(numSoLuongNhap.Value);
                    ct.DonGiaNhap = numDonGiaNhap.Value;
                    ct.ThanhTien = ct.SoLuongNhap * ct.DonGiaNhap;

                    dsChiTietTam.Add(ct);
                }

                TaiLaiLuoiChiTiet(sachID);

                numSoLuongNhap.Value = 1;
                numDonGiaNhap.Value = 1;
                cboTenSach.Focus();
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow != null)
            {
                int sachID = Convert.ToInt32(dgvChiTiet.CurrentRow.Cells["SachID"].Value.ToString());
                var chiTiet = dsChiTietTam.FirstOrDefault(r => r.SachID == sachID);
                if (chiTiet != null)
                {
                    dsChiTietTam.Remove(chiTiet);
                    TaiLaiLuoiChiTiet();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa khỏi phiếu nhập.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNhaCungCap.Focus();
                return;
            }

            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNhanVien.Focus();
                return;
            }

            if (dsChiTietTam.Count == 0)
            {
                MessageBox.Show("Phiếu nhập phải có ít nhất 1 sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenSach.Focus();
                return;
            }

            using var transaction = context.Database.BeginTransaction();
            try
            {
                PhieuNhap pn = new PhieuNhap();
                pn.MaPhieuNhap = txtMaPhieuNhap.Text.Trim();
                pn.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                pn.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                pn.NgayNhap = dtpNgayNhap.Value;
                pn.GhiChuPhieuNhap = txtGhiChu.Text.Trim();

                context.PhieuNhap.Add(pn);
                context.SaveChanges();

                foreach (var item in dsChiTietTam)
                {
                    PhieuNhap_ChiTiet ct = new PhieuNhap_ChiTiet();
                    ct.PhieuNhapID = pn.ID;
                    ct.SachID = item.SachID;
                    ct.SoLuongNhap = item.SoLuongNhap;
                    ct.DonGiaNhap = item.DonGiaNhap;
                    context.PhieuNhap_ChiTiet.Add(ct);

                    Sach? s = context.Sach.Find(item.SachID);
                    if (s != null)
                    {
                        s.SoLuongTon += item.SoLuongNhap;
                        s.GiaNhap = item.DonGiaNhap;
                        s.TrangThai = s.SoLuongTon > 0 ? "Còn hàng" : "Hết hàng";
                    }
                }

                context.SaveChanges();
                transaction.Commit();

                NhatKyHelper.GhiLog(
                    "Thêm",
                    "PhieuNhap",
                    pn.ID.ToString(),
                    "Lập phiếu nhập: " + pn.MaPhieuNhap + " - Tổng tiền: " + dsChiTietTam.Sum(r => r.ThanhTien).ToString("N0")
                );

                MessageBox.Show("Lập phiếu nhập thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
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

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            dsChiTietTam.Clear();
            txtTongTien.Text = "0";
            txtGhiChu.Clear();
            dtpNgayNhap.Value = DateTime.Now;
            TaiLaiLuoiChiTiet();

            if (cboTenSach.Items.Count > 0)
            {
                cboTenSach.SelectedIndex = 0;
                cboTenSach_SelectedIndexChanged(sender, e);
            }

            numSoLuongNhap.Value = 1;
            numDonGiaNhap.Value = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}