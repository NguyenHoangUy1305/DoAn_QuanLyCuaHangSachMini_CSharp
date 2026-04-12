using QuanLyCuaHangSachMini.Data.Entity;

namespace QuanLyCuaHangSachMini.Helpers
{
    public static class SessionHelper
    {
        public static int NhanVienID { get; set; } = 0;
        public static string TenDangNhap { get; set; } = string.Empty;
        public static string HoVaTen { get; set; } = string.Empty;

        // admin / nhanvien
        public static string QuyenHan { get; set; } = string.Empty;

        // Quản trị viên / Nhân viên
        public static string TenVaiTro { get; set; } = string.Empty;

        public static bool DaDangNhap => NhanVienID > 0;
        public static bool LaQuanTri => QuyenHan == "admin";

        public static void GanDuLieu(NhanVien nv)
        {
            NhanVienID = nv.ID;
            TenDangNhap = nv.TenDangNhap ?? string.Empty;
            HoVaTen = nv.HoVaTen ?? string.Empty;
            QuyenHan = nv.QuyenHan ? "admin" : "nhanvien";
            TenVaiTro = nv.QuyenHan ? "Quản trị viên" : "Nhân viên";
        }

        public static void DangXuat()
        {
            NhanVienID = 0;
            TenDangNhap = string.Empty;
            HoVaTen = string.Empty;
            QuyenHan = string.Empty;
            TenVaiTro = string.Empty;
        }
    }
}