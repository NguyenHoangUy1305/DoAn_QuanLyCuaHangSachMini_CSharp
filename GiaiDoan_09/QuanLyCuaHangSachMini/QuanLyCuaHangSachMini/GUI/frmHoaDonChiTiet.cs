using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.DTOs;
using QuanLyCuaHangSachMini.Helpers;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private int id;
        private bool chiXem = false;
        private int nhanVienDangNhapID = 0;
        private string quyenHanNguoiDung = "";
        private BindingList<DanhSachHoaDonChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>();

        public frmHoaDon_ChiTiet(int maHoaDon = 0, bool chiXemChiTiet = false, int nhanVienID = 0, string quyenHan = "")
        {
            InitializeComponent();
            id = maHoaDon;
            chiXem = chiXemChiTiet;
            nhanVienDangNhapID = nhanVienID;
            quyenHanNguoiDung = quyenHan ?? "";
        }

        public void LayNhanVienVaoComboBox()
        {
            if (quyenHanNguoiDung == "nhanvien")
            {
                cboNhanVien.DataSource = context.NhanVien
                    .Where(r => r.ID == nhanVienDangNhapID)
                    .ToList();
            }
            else
            {
                cboNhanVien.DataSource = context.NhanVien.ToList();
            }

            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }

        public void LaySachVaoComboBox()
        {
            cboSach.DataSource = context.Sach.OrderBy(r => r.TenSach).ToList();
            cboSach.ValueMember = "ID";
            cboSach.DisplayMember = "TenSach";
        }

        public void BatTatChucNang(bool giaTri)
        {
            cboNhanVien.Enabled = giaTri;
            cboKhachHang.Enabled = giaTri;
            txtGhiChuHoaDon.Enabled = giaTri;

            cboSach.Enabled = giaTri;
            numSoLuongBan.Enabled = giaTri;
            numDonGiaBan.Enabled = giaTri;

            btnXacNhanBan.Enabled = giaTri;
            btnXoa.Enabled = giaTri;
            btnLuuHoaDon.Enabled = giaTri;

            if (quyenHanNguoiDung == "nhanvien")
            {
                cboNhanVien.Enabled = false;
            }

            if (chiXem)
            {
                cboNhanVien.Enabled = false;
                cboKhachHang.Enabled = false;
                txtGhiChuHoaDon.Enabled = false;
                cboSach.Enabled = false;
                numSoLuongBan.Enabled = false;
                numDonGiaBan.Enabled = false;
                btnXacNhanBan.Enabled = false;
                btnXoa.Enabled = false;
                btnLuuHoaDon.Enabled = false;
            }
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LaySachVaoComboBox();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.CellClick -= dataGridView_CellClick;
            dataGridView.SelectionChanged -= dataGridView_SelectionChanged;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;

            numSoLuongBan.Minimum = 1;
            numSoLuongBan.Maximum = 100000;
            numSoLuongBan.ThousandsSeparator = true;

            numDonGiaBan.Minimum = 1;
            numDonGiaBan.Maximum = 1000000000;
            numDonGiaBan.ThousandsSeparator = true;

            if (id == 0)
            {
                if (quyenHanNguoiDung == "admin")
                {
                    MessageBox.Show("Quản trị viên chỉ được xem hóa đơn, không được lập hóa đơn bán.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }

                BatTatChucNang(true);

                if (quyenHanNguoiDung == "nhanvien")
                {
                    cboNhanVien.SelectedValue = nhanVienDangNhapID;
                    cboNhanVien.Enabled = false;
                }
                else
                {
                    cboNhanVien.SelectedIndex = -1;
                }

                cboKhachHang.SelectedIndex = -1;
                cboSach.SelectedIndex = 0;
                txtGhiChuHoaDon.Clear();
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 1;
                hoaDonChiTiet.Clear();
                TaiLaiLuoiChiTiet();
            }
            else
            {
                HoaDon? hoaDon = context.HoaDon.SingleOrDefault(r => r.ID == id);
                if (hoaDon != null)
                {
                    if (quyenHanNguoiDung == "nhanvien" && hoaDon.NhanVienID != nhanVienDangNhapID)
                    {
                        MessageBox.Show("Bạn chỉ được xem hoặc sửa hóa đơn do chính bạn lập.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        return;
                    }

                    cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                    cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                    txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;

                    List<DanhSachHoaDonChiTiet> ct = context.HoaDon_ChiTiet
                        .Where(r => r.HoaDonID == id)
                        .Select(r => new DanhSachHoaDonChiTiet
                        {
                            ID = r.ID,
                            HoaDonID = r.HoaDonID,
                            SachID = r.SachID,
                            MaSach = r.Sach.MaSach,
                            TenSach = r.Sach.TenSach,
                            SoLuongBan = r.SoLuongBan,
                            DonGiaBan = r.DonGiaBan,
                            ThanhTien = r.SoLuongBan * r.DonGiaBan
                        })
                        .ToList();

                    hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>(ct);
                    TaiLaiLuoiChiTiet();
                }

                if (chiXem || quyenHanNguoiDung == "admin")
                    BatTatChucNang(false);
                else
                    BatTatChucNang(true);
            }
        }

        private void TaiLaiLuoiChiTiet(int? sachIDCanChon = null)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = hoaDonChiTiet.ToList();

            if (dataGridView.Rows.Count > 0)
            {
                int rowIndex = 0;

                if (sachIDCanChon.HasValue)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells["SachID"].Value != null &&
                            Convert.ToInt32(row.Cells["SachID"].Value) == sachIDCanChon.Value)
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                }

                dataGridView.ClearSelection();
                dataGridView.Rows[rowIndex].Selected = true;
                dataGridView.CurrentCell = dataGridView.Rows[rowIndex].Cells["SachID"];
                HienThiThongTinSachBan();
            }
            else
            {
                XoaTrangThongTinSachBan();
            }

            btnLuuHoaDon.Enabled = hoaDonChiTiet.Count > 0 && !chiXem && quyenHanNguoiDung != "admin";
            btnXoa.Enabled = hoaDonChiTiet.Count > 0 && !chiXem && quyenHanNguoiDung != "admin";
        }

        private void HienThiThongTinSachBan()
        {
            if (dataGridView.CurrentRow == null || dataGridView.Rows.Count == 0)
            {
                XoaTrangThongTinSachBan();
                return;
            }

            int sachID = Convert.ToInt32(dataGridView.CurrentRow.Cells["SachID"].Value.ToString());
            DanhSachHoaDonChiTiet? chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SachID == sachID);

            if (chiTiet != null)
            {
                cboSach.SelectedValue = chiTiet.SachID;

                decimal soLuong = chiTiet.SoLuongBan;
                if (soLuong < numSoLuongBan.Minimum) soLuong = numSoLuongBan.Minimum;
                if (soLuong > numSoLuongBan.Maximum) soLuong = numSoLuongBan.Maximum;
                numSoLuongBan.Value = soLuong;

                decimal donGia = chiTiet.DonGiaBan;
                if (donGia < numDonGiaBan.Minimum) donGia = numDonGiaBan.Minimum;
                if (donGia > numDonGiaBan.Maximum) donGia = numDonGiaBan.Maximum;
                numDonGiaBan.Value = donGia;
            }
        }

        private void XoaTrangThongTinSachBan()
        {
            if (cboSach.Items.Count > 0 && !chiXem)
                cboSach.SelectedIndex = 0;
            else if (cboSach.Items.Count > 0)
                cboSach.SelectedIndex = -1;

            numSoLuongBan.Value = numSoLuongBan.Minimum;
            numDonGiaBan.Value = numDonGiaBan.Minimum;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                HienThiThongTinSachBan();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && dataGridView.CurrentRow != null)
                HienThiThongTinSachBan();
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (chiXem || quyenHanNguoiDung == "admin")
                return;

            if (string.IsNullOrWhiteSpace(cboSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numSoLuongBan.Value <= 0)
            {
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numDonGiaBan.Value <= 0)
            {
                MessageBox.Show("Đơn giá bán phải lớn hơn 0.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int maSach = Convert.ToInt32(cboSach.SelectedValue.ToString());
                DanhSachHoaDonChiTiet? chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SachID == maSach);

                if (chiTiet != null)
                {
                    chiTiet.SoLuongBan = Convert.ToInt32(numSoLuongBan.Value);
                    chiTiet.DonGiaBan = numDonGiaBan.Value;
                    chiTiet.ThanhTien = numSoLuongBan.Value * numDonGiaBan.Value;
                }
                else
                {
                    Sach? sach = context.Sach.Find(maSach);

                    DanhSachHoaDonChiTiet ct = new DanhSachHoaDonChiTiet
                    {
                        ID = 0,
                        HoaDonID = id,
                        SachID = maSach,
                        MaSach = sach != null ? sach.MaSach : string.Empty,
                        TenSach = cboSach.Text,
                        SoLuongBan = Convert.ToInt32(numSoLuongBan.Value),
                        DonGiaBan = numDonGiaBan.Value,
                        ThanhTien = numSoLuongBan.Value * numDonGiaBan.Value
                    };

                    hoaDonChiTiet.Add(ct);
                }

                TaiLaiLuoiChiTiet(maSach);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (chiXem || quyenHanNguoiDung == "admin")
                return;

            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng chi tiết cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSach = Convert.ToInt32(dataGridView.CurrentRow.Cells["SachID"].Value.ToString());
            DanhSachHoaDonChiTiet? chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SachID == maSach);

            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
            }

            TaiLaiLuoiChiTiet();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (quyenHanNguoiDung == "admin")
            {
                MessageBox.Show("Quản trị viên chỉ được xem hóa đơn, không được lập hóa đơn bán.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nhanVienDangNhapID <= 0)
            {
                MessageBox.Show("Không xác định được nhân viên đang đăng nhập.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hoaDonChiTiet.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có chi tiết bán.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var transaction = context.Database.BeginTransaction();
            try
            {
                List<DanhSachHoaDonChiTiet> danhSachMoi = hoaDonChiTiet.ToList();
                bool dangSua = id != 0;
                string maHoaDonLog = "";
                int hoaDonIDLog = 0;

                if (id != 0)
                {
                    HoaDon? hd = context.HoaDon.Find(id);
                    if (hd == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn cần cập nhật.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                        return;
                    }

                    if (hd.NhanVienID != nhanVienDangNhapID)
                    {
                        MessageBox.Show("Bạn chỉ được sửa hóa đơn do chính bạn lập.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                        return;
                    }

                    List<HoaDon_ChiTiet> old = context.HoaDon_ChiTiet
                        .Where(r => r.HoaDonID == id)
                        .ToList();

                    Dictionary<int, int> soLuongCuTheoSach = old
                        .GroupBy(r => r.SachID)
                        .ToDictionary(g => g.Key, g => g.Sum(x => x.SoLuongBan));

                    foreach (DanhSachHoaDonChiTiet item in danhSachMoi)
                    {
                        Sach? sach = context.Sach.Find(item.SachID);
                        if (sach == null)
                        {
                            MessageBox.Show("Có sách không tồn tại trong hệ thống.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }

                        int soLuongCu = soLuongCuTheoSach.ContainsKey(item.SachID) ? soLuongCuTheoSach[item.SachID] : 0;
                        int soLuongTonKhaDung = sach.SoLuongTon + soLuongCu;

                        if (soLuongTonKhaDung < item.SoLuongBan)
                        {
                            MessageBox.Show(
                                $"Sách \"{sach.TenSach}\" không đủ số lượng tồn.\nChỉ còn {soLuongTonKhaDung} quyển khả dụng.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }
                    }

                    hd.NhanVienID = nhanVienDangNhapID;
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                    context.HoaDon.Update(hd);

                    foreach (HoaDon_ChiTiet oldItem in old)
                    {
                        Sach? sach = context.Sach.Find(oldItem.SachID);
                        if (sach != null)
                        {
                            sach.SoLuongTon += oldItem.SoLuongBan;
                            sach.TrangThai = sach.SoLuongTon > 0 ? "Còn hàng" : "Hết hàng";
                        }
                    }

                    context.HoaDon_ChiTiet.RemoveRange(old);

                    foreach (DanhSachHoaDonChiTiet item in danhSachMoi)
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                        ct.HoaDonID = id;
                        ct.SachID = item.SachID;
                        ct.SoLuongBan = item.SoLuongBan;
                        ct.DonGiaBan = item.DonGiaBan;
                        context.HoaDon_ChiTiet.Add(ct);

                        Sach? sach = context.Sach.Find(item.SachID);
                        if (sach != null)
                        {
                            sach.SoLuongTon -= item.SoLuongBan;
                            if (sach.SoLuongTon < 0)
                                sach.SoLuongTon = 0;

                            sach.TrangThai = sach.SoLuongTon > 0 ? "Còn hàng" : "Hết hàng";
                        }
                    }

                    context.SaveChanges();
                    maHoaDonLog = hd.MaHoaDon;
                    hoaDonIDLog = hd.ID;
                }
                else
                {
                    foreach (DanhSachHoaDonChiTiet item in danhSachMoi)
                    {
                        Sach? sach = context.Sach.Find(item.SachID);
                        if (sach == null)
                        {
                            MessageBox.Show("Có sách không tồn tại trong hệ thống.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }

                        if (sach.SoLuongTon < item.SoLuongBan)
                        {
                            MessageBox.Show(
                                $"Sách \"{sach.TenSach}\" không đủ số lượng tồn.\nChỉ còn {sach.SoLuongTon} quyển.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }
                    }

                    HoaDon hd = new HoaDon();
                    hd.MaHoaDon = PhatSinhMaHoaDon();
                    hd.NhanVienID = nhanVienDangNhapID;
                    hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
                    hd.NgayLap = DateTime.Now;
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;

                    context.HoaDon.Add(hd);
                    context.SaveChanges();

                    foreach (DanhSachHoaDonChiTiet item in danhSachMoi)
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                        ct.HoaDonID = hd.ID;
                        ct.SachID = item.SachID;
                        ct.SoLuongBan = item.SoLuongBan;
                        ct.DonGiaBan = item.DonGiaBan;
                        context.HoaDon_ChiTiet.Add(ct);

                        Sach? sach = context.Sach.Find(item.SachID);
                        if (sach != null)
                        {
                            sach.SoLuongTon -= item.SoLuongBan;
                            if (sach.SoLuongTon < 0)
                                sach.SoLuongTon = 0;

                            sach.TrangThai = sach.SoLuongTon > 0 ? "Còn hàng" : "Hết hàng";
                        }
                    }

                    context.SaveChanges();
                    id = hd.ID;

                    maHoaDonLog = hd.MaHoaDon;
                    hoaDonIDLog = hd.ID;
                }

                transaction.Commit();

                NhatKyHelper.GhiLog(
                    dangSua ? "Sửa" : "Thêm",
                    "HoaDon",
                    hoaDonIDLog.ToString(),
                    (dangSua ? "Cập nhật hóa đơn: " : "Lập hóa đơn: ") + maHoaDonLog
                );

                MessageBox.Show("Đã lưu thành công!", "Hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private string PhatSinhMaHoaDon()
        {
            int soThuTu = 1;

            string? maCuoi = context.HoaDon
                .OrderByDescending(r => r.ID)
                .Select(r => r.MaHoaDon)
                .FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(maCuoi) &&
                maCuoi.StartsWith("HD") &&
                int.TryParse(maCuoi.Substring(2), out int so))
            {
                soThuTu = so + 1;
            }
            else if (context.HoaDon.Any())
            {
                soThuTu = context.HoaDon.Max(r => r.ID) + 1;
            }

            return "HD" + soThuTu.ToString("D3");
        }

        private void cboSach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSach.SelectedValue == null) return;

            int maSach = Convert.ToInt32(cboSach.SelectedValue.ToString());
            Sach? sach = context.Sach.Find(maSach);

            if (sach != null)
            {
                numDonGiaBan.Value = sach.GiaBan;
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần in hóa đơn bạn làm sau như yêu cầu.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}