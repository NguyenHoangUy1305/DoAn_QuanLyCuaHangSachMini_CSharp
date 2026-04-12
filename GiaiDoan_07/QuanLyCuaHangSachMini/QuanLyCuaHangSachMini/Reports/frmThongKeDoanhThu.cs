using Microsoft.Reporting.WinForms;
using QuanLyCuaHangSachMini.Data;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmThongKeDoanhThu : Form
    {
        private readonly AppDbContext context = new AppDbContext();

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private string LayDuongDanReport()
        {
            return Path.GetFullPath(
                Path.Combine(Application.StartupPath, @"..\..\..\Reports\rptThongKeDoanhThu.rdlc"));
        }

        private DataTable TaoBangHoaDon(List<dynamic> danhSachHoaDon)
        {
            DataTable table = new DataTable("DanhSachHoaDon");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("MaHoaDon", typeof(string));
            table.Columns.Add("NhanVienID", typeof(int));
            table.Columns.Add("HoVaTenNhanVien", typeof(string));
            table.Columns.Add("KhachHangID", typeof(int));
            table.Columns.Add("HoVaTenKhachHang", typeof(string));
            table.Columns.Add("NgayLap", typeof(DateTime));
            table.Columns.Add("GhiChuHoaDon", typeof(string));
            table.Columns.Add("TongTienHoaDon", typeof(decimal));

            foreach (var row in danhSachHoaDon)
            {
                table.Rows.Add(
                    row.ID,
                    row.MaHoaDon,
                    row.NhanVienID,
                    row.HoVaTenNhanVien,
                    row.KhachHangID,
                    row.HoVaTenKhachHang,
                    row.NgayLap,
                    row.GhiChuHoaDon ?? "",
                    row.TongTienHoaDon
                );
            }

            return table;
        }

        private List<dynamic> LayTatCaHoaDon()
        {
            return context.HoaDon
                .Select(r => new
                {
                    ID = r.ID,
                    MaHoaDon = r.MaHoaDon,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    KhachHangID = r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (decimal?)ct.SoLuongBan * ct.DonGiaBan) ?? 0
                })
                .OrderBy(r => r.NgayLap)
                .ToList<dynamic>();
        }

        private List<dynamic> LayHoaDonTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return context.HoaDon
                .Where(r => r.NgayLap >= tuNgay && r.NgayLap <= denNgay)
                .Select(r => new
                {
                    ID = r.ID,
                    MaHoaDon = r.MaHoaDon,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    KhachHangID = r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (decimal?)ct.SoLuongBan * ct.DonGiaBan) ?? 0
                })
                .OrderBy(r => r.NgayLap)
                .ToList<dynamic>();
        }

        private void NapReport(List<dynamic> danhSachHoaDon, string moTa)
        {
            try
            {
                string reportPath = LayDuongDanReport();

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file report: rptThongKeDoanhThu.rdlc", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable table = TaoBangHoaDon(danhSachHoaDon);

                reportViewer1.Reset();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportPath = reportPath;

                ReportDataSource reportDataSource = new ReportDataSource("DanhSachHoaDon", table);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                bool coThamSoMoTa = reportViewer1.LocalReport.GetParameters()
                    .Any(p => p.Name == "MoTaKetQuaHienThi");

                if (coThamSoMoTa)
                {
                    ReportParameter[] parameters =
                    {
                        new ReportParameter("MoTaKetQuaHienThi", moTa)
                    };
                    reportViewer1.LocalReport.SetParameters(parameters);
                }

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                string loi = ex.Message;

                if (ex.InnerException != null)
                    loi += "\n\n" + ex.InnerException.Message;

                if (ex.InnerException != null && ex.InnerException.InnerException != null)
                    loi += "\n\n" + ex.InnerException.InnerException.Message;

                MessageBox.Show(loi, "Lỗi report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Today;

            List<dynamic> danhSachHoaDon = LayTatCaHoaDon();
            NapReport(danhSachHoaDon, "(Tất cả hóa đơn)");
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<dynamic> danhSachHoaDon = LayHoaDonTheoNgay(tuNgay, denNgay);

            string moTa = "Từ ngày " + dtpTuNgay.Text + " - Đến ngày " + dtpDenNgay.Text;
            NapReport(danhSachHoaDon, moTa);
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu_Load(sender, e);
        }
    }
}