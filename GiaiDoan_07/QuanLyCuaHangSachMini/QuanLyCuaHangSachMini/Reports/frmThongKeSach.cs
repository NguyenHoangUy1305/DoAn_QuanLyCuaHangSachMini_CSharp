using Microsoft.Reporting.WinForms;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.DTOs;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmThongKeSach : Form
    {
        private readonly AppDbContext context = new AppDbContext();

        public frmThongKeSach()
        {
            InitializeComponent();
        }

        private void frmThongKeSach_Load(object sender, EventArgs e)
        {
            try
            {
                string reportPath = Path.GetFullPath(
                    Path.Combine(Application.StartupPath, @"..\..\..\Reports\rptThongKeSach.rdlc"));

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file report: rptThongKeSach.rdlc", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<DanhSachSach> danhSachSach = context.Sach
                    .Select(r => new DanhSachSach
                    {
                        ID = r.ID,
                        TheLoaiID = r.TheLoaiID,
                        TenTheLoai = r.TheLoai.TenTheLoai,
                        NhaXuatBanID = r.NhaXuatBanID,
                        TenNhaXuatBan = r.NhaXuatBan.TenNhaXuatBan,
                        MaSach = r.MaSach,
                        TenSach = r.TenSach,
                        TacGia = r.TacGia,
                        NamXuatBan = r.NamXuatBan,
                        GiaNhap = r.GiaNhap,
                        GiaBan = r.GiaBan,
                        SoLuongTon = r.SoLuongTon,
                        HinhAnh = r.HinhAnh,
                        MoTa = r.MoTa,
                        TrangThai = r.TrangThai
                    })
                    .OrderBy(r => r.ID)
                    .ToList();

                DataTable table = new DataTable("DanhSachSach");
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("TheLoaiID", typeof(int));
                table.Columns.Add("TenTheLoai", typeof(string));
                table.Columns.Add("NhaXuatBanID", typeof(int));
                table.Columns.Add("TenNhaXuatBan", typeof(string));
                table.Columns.Add("MaSach", typeof(string));
                table.Columns.Add("TenSach", typeof(string));
                table.Columns.Add("TacGia", typeof(string));
                table.Columns.Add("NamXuatBan", typeof(int));
                table.Columns.Add("GiaNhap", typeof(decimal));
                table.Columns.Add("GiaBan", typeof(decimal));
                table.Columns.Add("SoLuongTon", typeof(int));
                table.Columns.Add("HinhAnh", typeof(string));
                table.Columns.Add("MoTa", typeof(string));
                table.Columns.Add("TrangThai", typeof(string));

                foreach (DanhSachSach row in danhSachSach)
                {
                    table.Rows.Add(
                        row.ID,
                        row.TheLoaiID,
                        row.TenTheLoai,
                        row.NhaXuatBanID,
                        row.TenNhaXuatBan,
                        row.MaSach,
                        row.TenSach,
                        row.TacGia,
                        row.NamXuatBan,
                        row.GiaNhap,
                        row.GiaBan,
                        row.SoLuongTon,
                        row.HinhAnh ?? "",
                        row.MoTa ?? "",
                        row.TrangThai
                    );
                }

                reportViewer1.Reset();
                reportViewer1.ProcessingMode = ProcessingMode.Local;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportPath = reportPath;

                ReportDataSource reportDataSource = new ReportDataSource("DanhSachSach", table);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                bool coThamSoMoTa = reportViewer1.LocalReport.GetParameters()
                    .Any(p => p.Name == "MoTaKetQuaHienThi");

                if (coThamSoMoTa)
                {
                    ReportParameter[] parameters =
                    {
                        new ReportParameter("MoTaKetQuaHienThi", "(Tất cả sách)")
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
    }
}