using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHangSachMini.Reports
{
    public partial class frmInPhieuNhap : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private readonly int id;

        private readonly string reportsFolder = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Reports")
        );

        public frmInPhieuNhap(int maPhieuNhap = 0)
        {
            InitializeComponent();
            id = maPhieuNhap;
        }

        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            try
            {
                string reportPath = Path.Combine(reportsFolder, "rptInPhieuNhap.rdlc");

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

                var phieuNhap = context.PhieuNhap
                    .Include(r => r.NhanVien)
                    .Include(r => r.NhaCungCap)
                    .SingleOrDefault(r => r.ID == id);

                if (phieuNhap == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy phiếu nhập với ID = " + id,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    Close();
                    return;
                }

                var phieuNhapChiTiet = context.PhieuNhap_ChiTiet
                    .Include(r => r.Sach)
                    .Where(r => r.PhieuNhapID == id)
                    .Select(r => new DanhSachPhieuNhapChiTiet
                    {
                        ID = r.ID,
                        PhieuNhapID = r.PhieuNhapID,
                        SachID = r.SachID,
                        MaSach = r.Sach != null ? r.Sach.MaSach : "",
                        TenSach = r.Sach != null ? r.Sach.TenSach : "",
                        SoLuongNhap = r.SoLuongNhap,
                        DonGiaNhap = r.DonGiaNhap,
                        ThanhTien = r.SoLuongNhap * r.DonGiaNhap
                    })
                    .ToList();

                reportViewer1.Reset();
                reportViewer1.LocalReport.ReportPath = reportPath;
                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource reportDataSource = new ReportDataSource
                {
                    Name = "DanhSachPhieuNhap",
                    Value = phieuNhapChiTiet
                };

                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter(
                        "NgayNhap",
                        FormatNgayNhap(GetDateTimeProperty(phieuNhap, "NgayNhap", "NgayLap", "NgayTao"))
                    ),
                    new ReportParameter(
                        "NhanVienLap",
                        GetStringProperty(phieuNhap.NhanVien, "HoVaTen", "HoTen", "TenNhanVien")
                    ),
                    new ReportParameter(
                        "NhaCungCap",
                        GetStringProperty(phieuNhap.NhaCungCap, "TenNhaCungCap", "Ten", "TenNCC")
                    ),
                    new ReportParameter(
                        "NhaCungCapDiaChi",
                        GetStringProperty(phieuNhap.NhaCungCap, "DiaChi", "DiaChiNhaCungCap", "NoiDen")
                    )
                };

                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ShowFullException("Lỗi frmInPhieuNhap_Load", ex);
            }
        }

        private static string FormatNgayNhap(DateTime ngayNhap)
        {
            if (ngayNhap == DateTime.MinValue)
                return string.Empty;

            return $"Ngày {ngayNhap.Day} tháng {ngayNhap.Month} năm {ngayNhap.Year}";
        }

        private static DateTime GetDateTimeProperty(object obj, params string[] propertyNames)
        {
            if (obj == null)
                return DateTime.MinValue;

            foreach (string propertyName in propertyNames)
            {
                PropertyInfo prop = obj.GetType().GetProperty(propertyName);
                if (prop == null)
                    continue;

                object value = prop.GetValue(obj);
                if (value == null)
                    continue;

                if (value is DateTime dateTimeValue)
                    return dateTimeValue;

                if (DateTime.TryParse(value.ToString(), out DateTime parsedDate))
                    return parsedDate;
            }

            return DateTime.MinValue;
        }

        private static string GetStringProperty(object obj, params string[] propertyNames)
        {
            if (obj == null)
                return string.Empty;

            foreach (string propertyName in propertyNames)
            {
                PropertyInfo prop = obj.GetType().GetProperty(propertyName);
                if (prop == null)
                    continue;

                object value = prop.GetValue(obj);
                if (value != null)
                    return value.ToString();
            }

            return string.Empty;
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
