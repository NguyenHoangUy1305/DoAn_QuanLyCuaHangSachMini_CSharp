using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.DTOs;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmHoaDon : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private int id;

        private readonly int nhanVienDangNhapID = 0;
        private readonly string quyenHanNguoiDung = "";
        private readonly string hoVaTenNguoiDung = "";

        public frmHoaDon(int nhanVienID, string quyenHan, string hoVaTen)
        {
            InitializeComponent();
            nhanVienDangNhapID = nhanVienID;
            quyenHanNguoiDung = quyenHan ?? "";
            hoVaTenNguoiDung = hoVaTen ?? "";
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            HienThiDanhSachHoaDon();
            ApDungQuyen();
        }

        private void ApDungQuyen()
        {
            if (quyenHanNguoiDung == "admin")
            {
                btnLapHoaDon.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                btnInHoaDon.Enabled = true;
                btnTimKiem.Enabled = true;
                btnXuat.Enabled = true;
            }
            else
            {
                btnLapHoaDon.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                btnInHoaDon.Enabled = true;
                btnTimKiem.Enabled = true;
                btnXuat.Enabled = true;
            }
        }

        private void HienThiDanhSachHoaDon()
        {
            IQueryable<HoaDon> query = context.HoaDon;

            if (quyenHanNguoiDung == "nhanvien")
            {
                query = query.Where(r => r.NhanVienID == nhanVienDangNhapID);
            }

            List<DanhSachHoaDon> hd = query
                .Select(r => new DanhSachHoaDon
                {
                    ID = r.ID,
                    MaHoaDon = r.MaHoaDon,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    KhachHangID = r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (decimal?)ct.SoLuongBan * ct.DonGiaBan) ?? 0,
                    XemChiTiet = "Xem chi tiết"
                })
                .OrderByDescending(r => r.ID)
                .ToList();

            dataGridView.DataSource = null;
            dataGridView.DataSource = hd;
        }

        private DanhSachHoaDon? LayHoaDonDangChon()
        {
            if (dataGridView.CurrentRow == null)
                return null;

            return dataGridView.CurrentRow.DataBoundItem as DanhSachHoaDon;
        }

        private bool KiemTraQuyenSuaXoa(DanhSachHoaDon? hoaDonDangChon)
        {
            if (hoaDonDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (quyenHanNguoiDung == "admin")
            {
                MessageBox.Show("Quản trị viên chỉ được xem hóa đơn, không được lập, sửa, xóa hóa đơn bán.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (hoaDonDangChon.NhanVienID != nhanVienDangNhapID)
            {
                MessageBox.Show("Bạn chỉ được thao tác trên hóa đơn do chính bạn lập.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            if (quyenHanNguoiDung == "admin")
            {
                MessageBox.Show("Quản trị viên chỉ được xem hóa đơn, không được lập hóa đơn bán.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(0, false, nhanVienDangNhapID, quyenHanNguoiDung))
            {
                chiTiet.ShowDialog();
            }

            HienThiDanhSachHoaDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon? hoaDonDangChon = LayHoaDonDangChon();
            if (!KiemTraQuyenSuaXoa(hoaDonDangChon))
                return;

            id = hoaDonDangChon.ID;

            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id, false, nhanVienDangNhapID, quyenHanNguoiDung))
            {
                chiTiet.ShowDialog();
            }

            HienThiDanhSachHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon? hoaDonDangChon = LayHoaDonDangChon();
            if (!KiemTraQuyenSuaXoa(hoaDonDangChon))
                return;

            id = hoaDonDangChon.ID;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hóa đơn này không?\nKhi xóa sẽ xóa luôn chi tiết hóa đơn.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using var transaction = context.Database.BeginTransaction();
                try
                {
                    HoaDon? hd = context.HoaDon.Find(id);
                    if (hd != null)
                    {
                        if (quyenHanNguoiDung == "nhanvien" && hd.NhanVienID != nhanVienDangNhapID)
                        {
                            MessageBox.Show("Bạn chỉ được xóa hóa đơn của chính mình.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }

                        List<HoaDon_ChiTiet> chiTiet = context.HoaDon_ChiTiet
                            .Where(r => r.HoaDonID == id)
                            .ToList();

                        foreach (HoaDon_ChiTiet item in chiTiet)
                        {
                            Sach? sach = context.Sach.Find(item.SachID);
                            if (sach != null)
                            {
                                sach.SoLuongTon += item.SoLuongBan;
                                sach.TrangThai = sach.SoLuongTon > 0 ? "Còn hàng" : "Hết hàng";
                            }
                        }

                        context.HoaDon_ChiTiet.RemoveRange(chiTiet);
                        context.HoaDon.Remove(hd);
                        context.SaveChanges();
                        transaction.Commit();

                        MessageBox.Show("Đã xóa hóa đơn thành công.", "Hoàn tất",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        HienThiDanhSachHoaDon();
                    }
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                DanhSachHoaDon? hoaDonDangChon = dataGridView.Rows[e.RowIndex].DataBoundItem as DanhSachHoaDon;
                if (hoaDonDangChon == null)
                    return;

                if (quyenHanNguoiDung == "nhanvien" && hoaDonDangChon.NhanVienID != nhanVienDangNhapID)
                {
                    MessageBox.Show("Bạn chỉ được xem hóa đơn do chính bạn lập.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                id = hoaDonDangChon.ID;

                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id, true, nhanVienDangNhapID, quyenHanNguoiDung))
                {
                    chiTiet.ShowDialog();
                }

                HienThiDanhSachHoaDon();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần in hóa đơn bạn làm sau như yêu cầu.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập mã hóa đơn hoặc tên khách hàng cần tìm:",
                "Tìm kiếm hóa đơn",
                "");

            IQueryable<HoaDon> query = context.HoaDon;

            if (quyenHanNguoiDung == "nhanvien")
            {
                query = query.Where(r => r.NhanVienID == nhanVienDangNhapID);
            }

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                tuKhoa = tuKhoa.Trim();
                query = query.Where(r =>
                    r.MaHoaDon.Contains(tuKhoa) ||
                    r.KhachHang.HoVaTen.Contains(tuKhoa));
            }

            List<DanhSachHoaDon> hd = query
                .Select(r => new DanhSachHoaDon
                {
                    ID = r.ID,
                    MaHoaDon = r.MaHoaDon,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    KhachHangID = r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (decimal?)ct.SoLuongBan * ct.DonGiaBan) ?? 0,
                    XemChiTiet = "Xem chi tiết"
                })
                .OrderByDescending(r => r.ID)
                .ToList();

            dataGridView.DataSource = null;
            dataGridView.DataSource = hd;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon? hoaDonDangChon = LayHoaDonDangChon();
            if (hoaDonDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (quyenHanNguoiDung == "nhanvien" && hoaDonDangChon.NhanVienID != nhanVienDangNhapID)
            {
                MessageBox.Show("Bạn chỉ được xuất hóa đơn do chính bạn lập.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int hoaDonID = hoaDonDangChon.ID;

            HoaDon? hoaDon = context.HoaDon
                .Include(r => r.NhanVien)
                .Include(r => r.KhachHang)
                .Include(r => r.HoaDon_ChiTiet)
                .ThenInclude(r => r.Sach)
                .FirstOrDefault(r => r.ID == hoaDonID);

            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn cần xuất.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<DanhSachHoaDonChiTiet> chiTietHoaDon = context.HoaDon_ChiTiet
                .Where(r => r.HoaDonID == hoaDonID)
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
                .OrderBy(r => r.ID)
                .ToList();

            decimal tongTien = chiTietHoaDon.Sum(r => r.ThanhTien);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất hóa đơn ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = $"{hoaDon.MaHoaDon}.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using XLWorkbook workbook = new XLWorkbook();

                    IXLWorksheet wsHoaDon = workbook.Worksheets.Add("HoaDon");

                    wsHoaDon.Cell("A1").Value = "THÔNG TIN HÓA ĐƠN";
                    wsHoaDon.Range("A1:D1").Merge();
                    wsHoaDon.Cell("A1").Style.Font.Bold = true;
                    wsHoaDon.Cell("A1").Style.Font.FontSize = 16;
                    wsHoaDon.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    wsHoaDon.Cell("A3").Value = "ID";
                    wsHoaDon.Cell("B3").Value = hoaDon.ID;

                    wsHoaDon.Cell("A4").Value = "Mã hóa đơn";
                    wsHoaDon.Cell("B4").Value = hoaDon.MaHoaDon;

                    wsHoaDon.Cell("A5").Value = "Ngày lập";
                    wsHoaDon.Cell("B5").Value = hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm:ss");

                    wsHoaDon.Cell("A6").Value = "Nhân viên";
                    wsHoaDon.Cell("B6").Value = hoaDon.NhanVien != null ? hoaDon.NhanVien.HoVaTen : "";

                    wsHoaDon.Cell("A7").Value = "Khách hàng";
                    wsHoaDon.Cell("B7").Value = hoaDon.KhachHang != null ? hoaDon.KhachHang.HoVaTen : "";

                    wsHoaDon.Cell("A8").Value = "Ghi chú";
                    wsHoaDon.Cell("B8").Value = hoaDon.GhiChuHoaDon ?? "";

                    wsHoaDon.Cell("A9").Value = "Tổng tiền";
                    wsHoaDon.Cell("B9").Value = tongTien;
                    wsHoaDon.Cell("B9").Style.NumberFormat.Format = "#,##0";
                    wsHoaDon.Cell("B9").Style.Font.Bold = true;

                    wsHoaDon.Range("A3:A9").Style.Font.Bold = true;
                    wsHoaDon.Columns().AdjustToContents();

                    IXLWorksheet wsChiTiet = workbook.Worksheets.Add("ChiTietHoaDon");

                    wsChiTiet.Cell("A1").Value = "CHI TIẾT HÓA ĐƠN";
                    wsChiTiet.Range("A1:F1").Merge();
                    wsChiTiet.Cell("A1").Style.Font.Bold = true;
                    wsChiTiet.Cell("A1").Style.Font.FontSize = 16;
                    wsChiTiet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    wsChiTiet.Cell("A3").Value = "STT";
                    wsChiTiet.Cell("B3").Value = "Mã sách";
                    wsChiTiet.Cell("C3").Value = "Tên sách";
                    wsChiTiet.Cell("D3").Value = "Số lượng bán";
                    wsChiTiet.Cell("E3").Value = "Đơn giá bán";
                    wsChiTiet.Cell("F3").Value = "Thành tiền";

                    wsChiTiet.Range("A3:F3").Style.Font.Bold = true;
                    wsChiTiet.Range("A3:F3").Style.Fill.BackgroundColor = XLColor.LightGray;
                    wsChiTiet.Range("A3:F3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    int dong = 4;
                    int stt = 1;

                    foreach (DanhSachHoaDonChiTiet item in chiTietHoaDon)
                    {
                        wsChiTiet.Cell(dong, 1).Value = stt;
                        wsChiTiet.Cell(dong, 2).Value = item.MaSach;
                        wsChiTiet.Cell(dong, 3).Value = item.TenSach;
                        wsChiTiet.Cell(dong, 4).Value = item.SoLuongBan;
                        wsChiTiet.Cell(dong, 5).Value = item.DonGiaBan;
                        wsChiTiet.Cell(dong, 6).Value = item.ThanhTien;

                        wsChiTiet.Cell(dong, 4).Style.NumberFormat.Format = "#,##0";
                        wsChiTiet.Cell(dong, 5).Style.NumberFormat.Format = "#,##0";
                        wsChiTiet.Cell(dong, 6).Style.NumberFormat.Format = "#,##0";

                        dong++;
                        stt++;
                    }

                    wsChiTiet.Cell(dong, 5).Value = "Tổng tiền";
                    wsChiTiet.Cell(dong, 5).Style.Font.Bold = true;
                    wsChiTiet.Cell(dong, 6).Value = tongTien;
                    wsChiTiet.Cell(dong, 6).Style.NumberFormat.Format = "#,##0";
                    wsChiTiet.Cell(dong, 6).Style.Font.Bold = true;

                    wsChiTiet.Range(3, 1, dong, 6).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    wsChiTiet.Range(3, 1, dong, 6).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    wsChiTiet.Columns().AdjustToContents();

                    workbook.SaveAs(saveFileDialog.FileName);

                    MessageBox.Show("Xuất hóa đơn thành công.", "Hoàn tất",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string loi = ex.Message;
                    if (ex.InnerException != null)
                        loi += "\n\n" + ex.InnerException.Message;
                    if (ex.InnerException != null && ex.InnerException.InnerException != null)
                        loi += "\n\n" + ex.InnerException.InnerException.Message;

                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}