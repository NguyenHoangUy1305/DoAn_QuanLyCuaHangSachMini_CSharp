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
    public partial class frmInHoaDon : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private readonly int id;

        private readonly string reportsFolder = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Reports")
        );

        public frmInHoaDon(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                string reportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");

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

                var hoaDon = context.HoaDon
                    .Include(r => r.KhachHang)
                    .Include(r => r.NhanVien)
                    .SingleOrDefault(r => r.ID == id);

                if (hoaDon == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy hóa đơn với ID = " + id,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    Close();
                    return;
                }

                var hoaDonChiTiet = context.HoaDon_ChiTiet
                    .Include(r => r.Sach)
                    .Where(r => r.HoaDonID == id)
                    .Select(r => new DanhSachHoaDonChiTiet
                    {
                        ID = r.ID,
                        HoaDonID = r.HoaDonID,
                        SachID = r.SachID,
                        MaSach = r.Sach != null ? r.Sach.MaSach : "",
                        TenSach = r.Sach != null ? r.Sach.TenSach : "",
                        SoLuongBan = r.SoLuongBan,
                        DonGiaBan = r.DonGiaBan,
                        ThanhTien = r.SoLuongBan * r.DonGiaBan
                    })
                    .ToList();

                reportViewer1.Reset();
                reportViewer1.LocalReport.ReportPath = reportPath;
                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource reportDataSource = new ReportDataSource
                {
                    Name = "DanhSachHoaDonChiTiet",
                    Value = hoaDonChiTiet
                };

                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter(
                        "NgayLap",
                        string.Format(
                            "Ngày {0} tháng {1} năm {2}",
                            hoaDon.NgayLap.Day,
                            hoaDon.NgayLap.Month,
                            hoaDon.NgayLap.Year
                        )
                    ),
                    new ReportParameter("NguoiBanTen", hoaDon.NhanVien?.HoVaTen ?? ""),
                    new ReportParameter("NguoiBanDiaChi", hoaDon.NhanVien?.DiaChi ?? ""),
                    new ReportParameter("NguoiMuaTen", hoaDon.KhachHang?.HoVaTen ?? ""),
                    new ReportParameter("NguoiMuaDiaChi", hoaDon.KhachHang?.DiaChi ?? "")
                };

                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ShowFullException("Lỗi frmInHoaDon_Load", ex);
            }
        }

        private void ShowFullException(string title, Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(title);
            sb.AppendLine(new string('-', 60));

            int level = 0;
            Exception current = ex;

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
