using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmTrangChu : Form
    {
        private AppDbContext? context;
        private readonly bool laQuanTri = false;
        private readonly System.Windows.Forms.Timer boDemLamMoi = new();
        private const int NguongCanhBaoTon = 10;
        private const int SoNgayThongKeBanChay = 30;

        // Đã sửa thành PUBLIC để DataGridView có thể đọc và map dữ liệu
        public class GiaoDichTongQuanItem
        {
            public DateTime ThoiGian { get; set; }
            public string LoaiGiaoDich { get; set; } = string.Empty;
            public string MaChungTu { get; set; } = string.Empty;
            public string KhachHang { get; set; } = string.Empty;
            public decimal GiaTri { get; set; }
        }

        // Parameterless constructor used by Designer
        public frmTrangChu()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                GanDuLieuMauChoDesigner();
            }
        }

        public frmTrangChu(bool laQuanTri)
        {
            InitializeComponent();
            this.laQuanTri = laQuanTri;

            // initialize runtime-only resources
            context = new AppDbContext();

            // Setup timer tự động làm mới mỗi 15 giây
            boDemLamMoi.Interval = 15000;
            boDemLamMoi.Tick += (_, _) => TaiDuLieuTongQuan();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            boDemLamMoi.Stop();
            boDemLamMoi.Dispose();
            if (context != null)
                context.Dispose();
            base.OnFormClosed(e);
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            lblDoanhThuTitle.Text = "Doanh thu thuần hôm nay";
            grpXuHuong.Text = "Giao dịch 7 ngày gần nhất (Bán hàng / Hoàn trả)";
            context ??= new AppDbContext();

            ApDungPhanQuyenHienThi();
            if (!laQuanTri)
            {
                return;
            }

            // Cấu hình lại toàn bộ DataGridView cho chuẩn form đồ án
            DinhDangChungChoGrid(dgvXuHuong7Ngay);

            // Ghi chú cho giáo viên: Các cột đã được map DataPropertyName trực tiếp trong Designer
            TaiDuLieuTongQuan();
            boDemLamMoi.Start();
        }

        private void ApDungPhanQuyenHienThi()
        {
            if (laQuanTri)
            {
                pnlSachNhap.Visible = true;
                return;
            }

            tblCards.Visible = false;
            grpXuHuong.Visible = false;
            pnlSachBanChayCard.Visible = false;
            pnlCanhBaoTonKhoCard.Visible = false;
            btnLamMoi.Visible = false;
            lblCapNhat.Visible = false;

            var lblKhongCoQuyen = new Label
            {
                AutoSize = false,
                Name = "lblKhongCoQuyenTongQuan",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(71, 51, 255),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Tài khoản nhân viên không có quyền xem số liệu tổng quan."
            };

            Controls.Add(lblKhongCoQuyen);
            lblKhongCoQuyen.BringToFront();
            lblTieuDe.BringToFront();
        }

        // Tối ưu hiển thị cho tất cả các grid
        private void DinhDangChungChoGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(71, 51, 255);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
            dgv.RowTemplate.Height = 35;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        }

        private void GanDuLieuMauChoDesigner()
        {
            dgvXuHuong7Ngay.DataSource = new List<GiaoDichTongQuanItem>
            {
                new GiaoDichTongQuanItem
                {
                    ThoiGian = DateTime.Now,
                    LoaiGiaoDich = "Ban hang",
                    MaChungTu = "HD001",
                    KhachHang = "Khach mau",
                    GiaTri = 120000
                }
            };
            lblSachBanChayCardValue.Text = "Sach mau";
            lblSachBanChayCardDetail.Text = "Da ban 20 cuon / 30 ngay";
            lblCanhBaoTonKhoCardValue.Text = "3";
            lblCanhBaoTonKhoCardDetail.Text = "Dau sach duoi nguong ton";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (!laQuanTri) return;

            lblCapNhat.Text = "Đang cập nhật dữ liệu...";
            btnLamMoi.Enabled = false;
            Application.DoEvents();

            TaiDuLieuTongQuan();

            lblCapNhat.Text = $"Cập nhật lúc: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
            btnLamMoi.Enabled = true;
        }

        private void dgvXuHuong7Ngay_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvXuHuong7Ngay.Columns[e.ColumnIndex].Name == "colGiaTri" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal giaTri))
                {
                    e.Value = $"{giaTri:N0} đ";
                    e.CellStyle.ForeColor = giaTri < 0 ? Color.FromArgb(220, 38, 38) : Color.FromArgb(22, 163, 74);
                    e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    e.FormattingApplied = true;
                }
            }
        }

        private void TaiDuLieuTongQuan()
        {
            if (context == null)
                return;

            try
            {
                DateTime homNay = DateTime.Today;
                DateTime homQua = homNay.AddDays(-1);
                DateTime ngayMai = homNay.AddDays(1);

                decimal tongBanHomNay = context.HoaDon_ChiTiet
                    .AsNoTracking()
                    .Where(x => x.HoaDon.NgayLap >= homNay && x.HoaDon.NgayLap < ngayMai)
                    .Select(x => (decimal?)x.SoLuongBan * x.DonGiaBan)
                    .Sum() ?? 0m;

                decimal tongHoanHomNay = context.PhieuHoanTra_ChiTiet
                    .AsNoTracking()
                    .Where(x => x.PhieuHoanTra.NgayHoanTra >= homNay && x.PhieuHoanTra.NgayHoanTra < ngayMai)
                    .Select(x => (decimal?)x.SoLuongTra * x.DonGiaHoanTra)
                    .Sum() ?? 0m;

                decimal tongBanHomQua = context.HoaDon_ChiTiet
                    .AsNoTracking()
                    .Where(x => x.HoaDon.NgayLap >= homQua && x.HoaDon.NgayLap < homNay)
                    .Select(x => (decimal?)x.SoLuongBan * x.DonGiaBan)
                    .Sum() ?? 0m;

                decimal tongHoanHomQua = context.PhieuHoanTra_ChiTiet
                    .AsNoTracking()
                    .Where(x => x.PhieuHoanTra.NgayHoanTra >= homQua && x.PhieuHoanTra.NgayHoanTra < homNay)
                    .Select(x => (decimal?)x.SoLuongTra * x.DonGiaHoanTra)
                    .Sum() ?? 0m;

                decimal doanhThuHomNay = tongBanHomNay - tongHoanHomNay;
                decimal doanhThuHomQua = tongBanHomQua - tongHoanHomQua;

                int hoaDonHomNay = context.HoaDon
                    .AsNoTracking()
                    .Count(x => x.NgayLap >= homNay && x.NgayLap < ngayMai);

                int tongKhachHang = context.KhachHang.AsNoTracking().Count();

                int soSachNhapHomNay = context.PhieuNhap_ChiTiet
                    .AsNoTracking()
                    .Where(x => x.PhieuNhap.NgayNhap >= homNay && x.PhieuNhap.NgayNhap < ngayMai)
                    .Select(x => (int?)x.SoLuongNhap)
                    .Sum() ?? 0;

                lblDoanhThuValue.Text = $"{doanhThuHomNay:N0} đ";
                lblHoaDonValue.Text = hoaDonHomNay.ToString("N0");
                lblKhachHangValue.Text = tongKhachHang.ToString("N0");
                lblSachNhapValue.Text = soSachNhapHomNay.ToString("N0");

                decimal chenhLech = doanhThuHomNay - doanhThuHomQua;
                if (doanhThuHomQua == 0)
                {
                    lblDoanhThuChange.Text = doanhThuHomNay == 0 ? "Không đổi so với hôm qua" : "Mới phát sinh doanh thu";
                    lblDoanhThuChange.ForeColor = Color.FromArgb(71, 85, 105);
                }
                else
                {
                    decimal phanTram = (chenhLech / doanhThuHomQua) * 100m;
                    lblDoanhThuChange.Text = $"{(phanTram >= 0 ? "+" : string.Empty)}{phanTram:N1}% so với hôm qua";
                    lblDoanhThuChange.ForeColor = phanTram >= 0
                        ? Color.FromArgb(22, 163, 74)
                        : Color.FromArgb(220, 53, 69);
                }

                lblCapNhat.Text = $"Cập nhật lúc: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

                TaiDuLieuGiaoDich7Ngay(homNay);
                TaiDuLieuSachBanChayVaCanhBao(homNay);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu tổng quan.\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiDuLieuGiaoDich7Ngay(DateTime homNay)
        {
            if (context == null)
                return;

            DateTime tuNgay = homNay.AddDays(-6);
            DateTime denNgay = homNay.AddDays(1);

            var tienHoaDonTheoId = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Where(x => x.HoaDon.NgayLap >= tuNgay && x.HoaDon.NgayLap < denNgay)
                .GroupBy(x => x.HoaDonID)
                .Select(g => new
                {
                    HoaDonID = g.Key,
                    TongTien = g.Sum(i => (decimal?)i.SoLuongBan * i.DonGiaBan) ?? 0m
                })
                .ToDictionary(x => x.HoaDonID, x => x.TongTien);

            var tienHoanTraTheoId = context.PhieuHoanTra_ChiTiet
                .AsNoTracking()
                .Where(x => x.PhieuHoanTra.NgayHoanTra >= tuNgay && x.PhieuHoanTra.NgayHoanTra < denNgay)
                .GroupBy(x => x.PhieuHoanTraID)
                .Select(g => new
                {
                    PhieuHoanTraID = g.Key,
                    TongTien = g.Sum(i => (decimal?)i.SoLuongTra * i.DonGiaHoanTra) ?? 0m
                })
                .ToDictionary(x => x.PhieuHoanTraID, x => x.TongTien);

            var giaoDichBan = context.HoaDon
                .AsNoTracking()
                .Where(x => x.NgayLap >= tuNgay && x.NgayLap < denNgay)
                .Select(x => new
                {
                    x.ID,
                    ThoiGian = x.NgayLap,
                    Loai = "Bán hàng",
                    Ma = x.MaHoaDon,
                    Khach = x.KhachHang.HoVaTen
                })
                .ToList()
                .Select(x => new GiaoDichTongQuanItem
                {
                    ThoiGian = x.ThoiGian,
                    LoaiGiaoDich = x.Loai,
                    MaChungTu = x.Ma ?? string.Empty,
                    KhachHang = x.Khach ?? string.Empty,
                    GiaTri = decimal.Round(tienHoaDonTheoId.TryGetValue(x.ID, out decimal tien) ? tien : 0m, 0)
                });

            var giaoDichHoan = context.PhieuHoanTra
                .AsNoTracking()
                .Where(x => x.NgayHoanTra >= tuNgay && x.NgayHoanTra < denNgay)
                .Select(x => new
                {
                    x.ID,
                    ThoiGian = x.NgayHoanTra,
                    Loai = "Hoàn trả",
                    Ma = x.MaPhieuHoanTra,
                    Khach = x.HoaDon.KhachHang.HoVaTen
                })
                .ToList()
                .Select(x => new GiaoDichTongQuanItem
                {
                    ThoiGian = x.ThoiGian,
                    LoaiGiaoDich = x.Loai,
                    MaChungTu = x.Ma ?? string.Empty,
                    KhachHang = x.Khach ?? string.Empty,
                    GiaTri = -decimal.Round(tienHoanTraTheoId.TryGetValue(x.ID, out decimal tien) ? tien : 0m, 0)
                });

            var data = giaoDichBan
                .Concat(giaoDichHoan)
                .OrderByDescending(x => x.ThoiGian)
                .Take(100)
                .ToList();

            dgvXuHuong7Ngay.DataSource = null;
            dgvXuHuong7Ngay.DataSource = data;
        }

        private void TaiDuLieuSachBanChayVaCanhBao(DateTime homNay)
        {
            if (context == null)
                return;

            DateTime tuNgay = homNay.AddDays(-(SoNgayThongKeBanChay - 1));
            DateTime denNgay = homNay.AddDays(1);

            var soLuongBanTheoSach = context.HoaDon_ChiTiet
                .AsNoTracking()
                .Where(x => x.HoaDon.NgayLap >= tuNgay && x.HoaDon.NgayLap < denNgay)
                .GroupBy(x => x.SachID)
                .Select(g => new { SachID = g.Key, SoLuong = g.Sum(i => (int?)i.SoLuongBan) ?? 0 })
                .ToDictionary(x => x.SachID, x => x.SoLuong);

            var soLuongHoanTheoSach = context.PhieuHoanTra_ChiTiet
                .AsNoTracking()
                .Where(x => x.PhieuHoanTra.NgayHoanTra >= tuNgay && x.PhieuHoanTra.NgayHoanTra < denNgay)
                .GroupBy(x => x.SachID)
                .Select(g => new { SachID = g.Key, SoLuong = g.Sum(i => (int?)i.SoLuongTra) ?? 0 })
                .ToDictionary(x => x.SachID, x => x.SoLuong);

            var danhSachSach = context.Sach
                .AsNoTracking()
                .Select(x => new { x.ID, x.MaSach, x.TenSach, x.SoLuongTon })
                .ToList();

            var sachBanChay = danhSachSach
                .Select(x => new
                {
                    MaSach = x.MaSach ?? string.Empty,
                    TenSach = x.TenSach ?? string.Empty,
                    DaBan30Ngay = (soLuongBanTheoSach.TryGetValue(x.ID, out int ban) ? ban : 0)
                                 - (soLuongHoanTheoSach.TryGetValue(x.ID, out int hoan) ? hoan : 0),
                    TonKho = x.SoLuongTon
                })
                .Where(x => x.DaBan30Ngay > 0)
                .OrderByDescending(x => x.DaBan30Ngay)
                .ThenBy(x => x.TenSach)
                .FirstOrDefault();

            var canhBaoTon = danhSachSach
                .Where(x => x.SoLuongTon <= NguongCanhBaoTon)
                .OrderBy(x => x.SoLuongTon)
                .ThenBy(x => x.TenSach)
                .ToList();

            if (sachBanChay != null)
            {
                lblSachBanChayCardValue.Text = sachBanChay.TenSach;
                lblSachBanChayCardDetail.Text = $"{sachBanChay.DaBan30Ngay:N0} cuốn / 30 ngày";
            }
            else
            {
                lblSachBanChayCardValue.Text = "Chưa có";
                lblSachBanChayCardDetail.Text = "Không có dữ liệu bán hàng";
            }

            int tongCanhBao = canhBaoTon.Count;
            int soHetHang = canhBaoTon.Count(x => x.SoLuongTon <= 0);
            lblCanhBaoTonKhoCardValue.Text = tongCanhBao.ToString("N0");
            lblCanhBaoTonKhoCardDetail.Text = soHetHang > 0
                ? $"{soHetHang:N0} đầu sách hết hàng"
                : $"Ngưỡng cảnh báo <= {NguongCanhBaoTon:N0}";
            lblCanhBaoTonKhoCardDetail.ForeColor = soHetHang > 0
                ? Color.FromArgb(220, 38, 38)
                : Color.FromArgb(71, 85, 105);
        }
    }
}
