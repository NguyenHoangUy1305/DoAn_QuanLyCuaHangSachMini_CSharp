using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.DTOs;

namespace QuanLyCuaHangSachMini.Reports
{
    public partial class frmInPhieuHoanTra : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private readonly int id;

        private readonly string reportsFolder = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Reports")
        );

        public frmInPhieuHoanTra(int phieuHoanTraID = 0)
        {
            InitializeComponent();
            id = phieuHoanTraID;
        }

        private void frmInPhieuHoanTra_Load(object sender, EventArgs e)
        {
            try
            {
                string reportPath = Path.Combine(reportsFolder, "rptInPhieuHoanTra.rdlc");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show(
                        "Không tìm thấy file report:\n" + reportPath,
                        "Lỗi đường dẫn report",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                var phieu = context.PhieuHoanTra
                    .Include(r => r.HoaDon)
                        .ThenInclude(r => r.KhachHang)
                    .Include(r => r.NhanVien)
                    .Include(r => r.PhieuHoanTra_ChiTiet)
                        .ThenInclude(r => r.Sach)
                    .SingleOrDefault(r => r.ID == id);

                if (phieu == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy phiếu hoàn trả với ID = " + id,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    Close();
                    return;
                }

                List<DanhSachPhieuHoanTra_ChiTiet> ds = phieu.PhieuHoanTra_ChiTiet
                    .Select(ct =>
                    {
                        int soLuongBan = context.HoaDon_ChiTiet
                            .Where(x => x.HoaDonID == phieu.HoaDonID && x.SachID == ct.SachID)
                            .Select(x => x.SoLuongBan)
                            .FirstOrDefault();

                        return new DanhSachPhieuHoanTra_ChiTiet
                        {
                            ID = ct.ID,
                            PhieuHoanTraID = phieu.ID,
                            MaPhieuHoanTra = phieu.MaPhieuHoanTra ?? string.Empty,
                            HoaDonID = phieu.HoaDonID,
                            MaHoaDon = phieu.HoaDon?.MaHoaDon ?? string.Empty,
                            NhanVienID = phieu.NhanVienID,
                            TenNhanVien = phieu.NhanVien?.HoVaTen ?? string.Empty,
                            KhachHangID = phieu.HoaDon?.KhachHangID ?? 0,
                            TenKhachHang = phieu.HoaDon?.KhachHang?.HoVaTen ?? string.Empty,
                            NgayHoanTra = phieu.NgayHoanTra,
                            LyDo = phieu.LyDo ?? string.Empty,
                            HoaDonChiTietID = context.HoaDon_ChiTiet
                                .Where(x => x.HoaDonID == phieu.HoaDonID && x.SachID == ct.SachID)
                                .Select(x => x.ID)
                                .FirstOrDefault(),
                            SachID = ct.SachID,
                            MaSach = ct.Sach?.MaSach ?? string.Empty,
                            TenSach = ct.Sach?.TenSach ?? string.Empty,
                            SoLuongBan = soLuongBan,
                            SoLuongTra = ct.SoLuongTra,
                            DonGiaHoanTra = ct.DonGiaHoanTra
                        };
                    })
                    .ToList();

                reportViewer1.Reset();
                reportViewer1.LocalReport.ReportPath = reportPath;
                reportViewer1.LocalReport.DataSources.Clear();

                var reportDataSource = new ReportDataSource
                {
                    Name = "DanhSachPhieuHoanTra",
                    Value = ds
                };

                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")),
                    new ReportParameter("NgayHoanTra", phieu.NgayHoanTra.ToString("dd/MM/yyyy HH:mm:ss")),
                    new ReportParameter("MaPhieuHoanTra", phieu.MaPhieuHoanTra ?? string.Empty),
                    new ReportParameter("MaHoaDon", phieu.HoaDon?.MaHoaDon ?? string.Empty),
                    new ReportParameter("TenNhanVien", phieu.NhanVien?.HoVaTen ?? string.Empty),
                    new ReportParameter("TenKhachHang", phieu.HoaDon?.KhachHang?.HoVaTen ?? string.Empty),
                    new ReportParameter("LyDo", phieu.LyDo ?? string.Empty)
                };

                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ShowFullException("Lỗi frmInPhieuHoanTra_Load", ex);
            }
        }

        private void ShowFullException(string title, Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(title);
            sb.AppendLine(new string('-', 60));

            int level = 0;
            Exception? current = ex;

            while (current != null)
            {
                sb.AppendLine($"[Level {level}] {current.GetType().FullName}");
                sb.AppendLine(current.Message);
                sb.AppendLine();
                current = current.InnerException;
                level++;
            }

            MessageBox.Show(
                sb.ToString(),
                "Chi tiết lỗi report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
