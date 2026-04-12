using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.DTOs;
using QuanLyCuaHangSachMini.Reports;

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
                //btnSua.Enabled = false;
                btnHoanTra.Enabled = true;

                btnInHoaDon.Enabled = true;
                btnTimKiem.Enabled = true;
                btnXuat.Enabled = true;
            }
            else
            {
                btnLapHoaDon.Enabled = true;
                //btnSua.Enabled = true;
                btnHoanTra.Enabled = true;

                btnInHoaDon.Enabled = true;
                btnTimKiem.Enabled = true;
                btnXuat.Enabled = true;
            }
        }

        private void HienThiDanhSachHoaDon()
        {
            IQueryable<HoaDon> query = context.HoaDon.AsNoTracking();

            if (quyenHanNguoiDung == "nhanvien")
            {
                query = query.Where(r => r.NhanVienID == nhanVienDangNhapID);
            }

            List<DanhSachHoaDon> hd = LayDanhSachHoaDon(query);

            dataGridView.DataSource = null;
            dataGridView.DataSource = hd;
        }

        private List<DanhSachHoaDon> LayDanhSachHoaDon(IQueryable<HoaDon> query)
        {
            return query
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
                .OrderBy(r => r.ID)
                .ToList();
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
                MessageBox.Show("Quản trị viên chỉ được xem hóa đơn, không được lập, sửa hóa đơn bán.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (quyenHanNguoiDung == "nhanvien" && hoaDonDangChon.NhanVienID != nhanVienDangNhapID)
            {
                MessageBox.Show("Bạn chỉ được thao tác trên hóa đơn do chính bạn lập.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool KiemTraQuyenHoanTra(DanhSachHoaDon? hoaDonDangChon)
        {
            if (hoaDonDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (quyenHanNguoiDung == "nhanvien" && hoaDonDangChon.NhanVienID != nhanVienDangNhapID)
            {
                MessageBox.Show("Bạn chỉ được hoàn trả hóa đơn do chính bạn lập.",
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

      //  private void btnSua_Click(object sender, EventArgs e)
      //  {
        //    DanhSachHoaDon? hoaDonDangChon = LayHoaDonDangChon();
        //    if (!KiemTraQuyenSuaXoa(hoaDonDangChon))
            //    return;
       
          //  id = hoaDonDangChon.ID;

          //  using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id, false, nhanVienDangNhapID, quyenHanNguoiDung))
           // {
           //     chiTiet.ShowDialog();
            //}

          //  HienThiDanhSachHoaDon();
      //  }

        private void btnHoanTra_Click(object sender, EventArgs e)
        {
            if (quyenHanNguoiDung == "admin")
            {
                using (frmPhieuHoanTra frm = new frmPhieuHoanTra(nhanVienDangNhapID, quyenHanNguoiDung))
                {
                    frm.ShowDialog();
                }

                return;
            }

            DanhSachHoaDon? hoaDonDangChon = LayHoaDonDangChon();
            if (!KiemTraQuyenHoanTra(hoaDonDangChon))
                return;

            id = hoaDonDangChon.ID;

            PhieuHoanTra? phieuHoanTraDaCo = context.PhieuHoanTra
                .FirstOrDefault(r => r.HoaDonID == id);

            if (phieuHoanTraDaCo != null)
            {
                MessageBox.Show("Hóa đơn này đã có phiếu hoàn trả. Sẽ mở ở chế độ xem.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (frmPhieuHoanTra_ChiTiet frm = new frmPhieuHoanTra_ChiTiet(phieuHoanTraDaCo.ID, false, true,
                    nhanVienDangNhapID, quyenHanNguoiDung))
                {
                    frm.ShowDialog();
                }
                HienThiDanhSachHoaDon();
                return;
            }

            DialogResult result = MessageBox.Show(
                "Lập phiếu hoàn trả cho hóa đơn này?",
                "Xác nhận hoàn trả",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using (frmPhieuHoanTra_ChiTiet frm = new frmPhieuHoanTra_ChiTiet(id, true, false,
                nhanVienDangNhapID, quyenHanNguoiDung))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    HienThiDanhSachHoaDon();
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
            DanhSachHoaDon? hoaDonDangChon = LayHoaDonDangChon();
            if (hoaDonDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (quyenHanNguoiDung == "nhanvien" && hoaDonDangChon.NhanVienID != nhanVienDangNhapID)
            {
                MessageBox.Show("Bạn chỉ được in hóa đơn do chính bạn lập.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            id = hoaDonDangChon.ID;
            if (id <= 0)
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ, không thể in.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (frmInHoaDon inHoaDon = new frmInHoaDon(id))
            {
                inHoaDon.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập mã hóa đơn hoặc tên khách hàng cần tìm:",
                "Tìm kiếm hóa đơn",
                "");

            IQueryable<HoaDon> query = context.HoaDon.AsNoTracking();

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

            List<DanhSachHoaDon> hd = LayDanhSachHoaDon(query);

            dataGridView.DataSource = null;
            dataGridView.DataSource = hd;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            IQueryable<HoaDon> query = context.HoaDon
                .AsNoTracking()
                .Include(r => r.NhanVien)
                .Include(r => r.KhachHang)
                .Include(r => r.HoaDon_ChiTiet)
                .ThenInclude(r => r.Sach);

            if (quyenHanNguoiDung == "nhanvien")
            {
                query = query.Where(r => r.NhanVienID == nhanVienDangNhapID);
            }

            List<HoaDon> dsHoaDon = query
                .OrderBy(r => r.ID)
                .ToList();

            if (dsHoaDon.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất toàn bộ hóa đơn ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = $"DanhSachHoaDon_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using XLWorkbook workbook = new XLWorkbook();

                    IXLWorksheet wsHoaDon = workbook.Worksheets.Add("DanhSachHoaDon");

                    wsHoaDon.Cell("A1").Value = "DANH SÁCH HÓA ĐƠN";
                    wsHoaDon.Range("A1:G1").Merge();
                    wsHoaDon.Cell("A1").Style.Font.Bold = true;
                    wsHoaDon.Cell("A1").Style.Font.FontSize = 16;
                    wsHoaDon.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    wsHoaDon.Cell("A3").Value = "STT";
                    wsHoaDon.Cell("B3").Value = "Mã hóa đơn";
                    wsHoaDon.Cell("C3").Value = "Ngày lập";
                    wsHoaDon.Cell("D3").Value = "Nhân viên";
                    wsHoaDon.Cell("E3").Value = "Khách hàng";
                    wsHoaDon.Cell("F3").Value = "Tổng tiền";
                    wsHoaDon.Cell("G3").Value = "Ghi chú";

                    wsHoaDon.Range("A3:G3").Style.Font.Bold = true;
                    wsHoaDon.Range("A3:G3").Style.Fill.BackgroundColor = XLColor.LightGray;
                    wsHoaDon.Range("A3:G3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    int dongHoaDon = 4;
                    int sttHoaDon = 1;
                    decimal tongTatCaHoaDon = 0;

                    foreach (HoaDon hoaDon in dsHoaDon)
                    {
                        decimal tongTien = hoaDon.HoaDon_ChiTiet.Sum(ct => ct.SoLuongBan * ct.DonGiaBan);
                        tongTatCaHoaDon += tongTien;

                        wsHoaDon.Cell(dongHoaDon, 1).Value = sttHoaDon;
                        wsHoaDon.Cell(dongHoaDon, 2).Value = hoaDon.MaHoaDon;
                        wsHoaDon.Cell(dongHoaDon, 3).Value = hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm:ss");
                        wsHoaDon.Cell(dongHoaDon, 4).Value = hoaDon.NhanVien != null ? hoaDon.NhanVien.HoVaTen : "";
                        wsHoaDon.Cell(dongHoaDon, 5).Value = hoaDon.KhachHang != null ? hoaDon.KhachHang.HoVaTen : "";
                        wsHoaDon.Cell(dongHoaDon, 6).Value = tongTien;
                        wsHoaDon.Cell(dongHoaDon, 6).Style.NumberFormat.Format = "#,##0";
                        wsHoaDon.Cell(dongHoaDon, 7).Value = hoaDon.GhiChuHoaDon ?? "";

                        dongHoaDon++;
                        sttHoaDon++;
                    }

                    wsHoaDon.Cell(dongHoaDon, 5).Value = "Tổng cộng";
                    wsHoaDon.Cell(dongHoaDon, 5).Style.Font.Bold = true;
                    wsHoaDon.Cell(dongHoaDon, 6).Value = tongTatCaHoaDon;
                    wsHoaDon.Cell(dongHoaDon, 6).Style.NumberFormat.Format = "#,##0";
                    wsHoaDon.Cell(dongHoaDon, 6).Style.Font.Bold = true;

                    wsHoaDon.Range(3, 1, dongHoaDon, 7).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    wsHoaDon.Range(3, 1, dongHoaDon, 7).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    wsHoaDon.Columns().AdjustToContents();

                    IXLWorksheet wsChiTiet = workbook.Worksheets.Add("ChiTietTatCaHoaDon");

                    wsChiTiet.Cell("A1").Value = "CHI TIẾT TẤT CẢ HÓA ĐƠN";
                    wsChiTiet.Range("A1:J1").Merge();
                    wsChiTiet.Cell("A1").Style.Font.Bold = true;
                    wsChiTiet.Cell("A1").Style.Font.FontSize = 16;
                    wsChiTiet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    wsChiTiet.Cell("A3").Value = "STT";
                    wsChiTiet.Cell("B3").Value = "Mã hóa đơn";
                    wsChiTiet.Cell("C3").Value = "Ngày lập";
                    wsChiTiet.Cell("D3").Value = "Nhân viên";
                    wsChiTiet.Cell("E3").Value = "Khách hàng";
                    wsChiTiet.Cell("F3").Value = "Mã sách";
                    wsChiTiet.Cell("G3").Value = "Tên sách";
                    wsChiTiet.Cell("H3").Value = "Số lượng bán";
                    wsChiTiet.Cell("I3").Value = "Đơn giá bán";
                    wsChiTiet.Cell("J3").Value = "Thành tiền";

                    wsChiTiet.Range("A3:J3").Style.Font.Bold = true;
                    wsChiTiet.Range("A3:J3").Style.Fill.BackgroundColor = XLColor.LightGray;
                    wsChiTiet.Range("A3:J3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    int dongChiTiet = 4;
                    int sttChiTiet = 1;

                    foreach (HoaDon hoaDon in dsHoaDon)
                    {
                        List<HoaDon_ChiTiet> dsChiTiet = hoaDon.HoaDon_ChiTiet
                            .OrderBy(r => r.ID)
                            .ToList();

                        foreach (HoaDon_ChiTiet item in dsChiTiet)
                        {
                            decimal thanhTien = item.SoLuongBan * item.DonGiaBan;

                            wsChiTiet.Cell(dongChiTiet, 1).Value = sttChiTiet;
                            wsChiTiet.Cell(dongChiTiet, 2).Value = hoaDon.MaHoaDon;
                            wsChiTiet.Cell(dongChiTiet, 3).Value = hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm:ss");
                            wsChiTiet.Cell(dongChiTiet, 4).Value = hoaDon.NhanVien != null ? hoaDon.NhanVien.HoVaTen : "";
                            wsChiTiet.Cell(dongChiTiet, 5).Value = hoaDon.KhachHang != null ? hoaDon.KhachHang.HoVaTen : "";
                            wsChiTiet.Cell(dongChiTiet, 6).Value = item.Sach != null ? item.Sach.MaSach : "";
                            wsChiTiet.Cell(dongChiTiet, 7).Value = item.Sach != null ? item.Sach.TenSach : "";
                            wsChiTiet.Cell(dongChiTiet, 8).Value = item.SoLuongBan;
                            wsChiTiet.Cell(dongChiTiet, 9).Value = item.DonGiaBan;
                            wsChiTiet.Cell(dongChiTiet, 10).Value = thanhTien;

                            wsChiTiet.Cell(dongChiTiet, 8).Style.NumberFormat.Format = "#,##0";
                            wsChiTiet.Cell(dongChiTiet, 9).Style.NumberFormat.Format = "#,##0";
                            wsChiTiet.Cell(dongChiTiet, 10).Style.NumberFormat.Format = "#,##0";

                            dongChiTiet++;
                            sttChiTiet++;
                        }
                    }

                    if (dongChiTiet > 4)
                    {
                        wsChiTiet.Range(3, 1, dongChiTiet - 1, 10).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        wsChiTiet.Range(3, 1, dongChiTiet - 1, 10).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    }

                    wsChiTiet.Columns().AdjustToContents();

                    workbook.SaveAs(saveFileDialog.FileName);

                    MessageBox.Show("Xuất toàn bộ hóa đơn thành công.", "Hoàn tất",
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
