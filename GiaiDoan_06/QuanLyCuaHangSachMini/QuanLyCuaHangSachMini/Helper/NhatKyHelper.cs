using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;

namespace QuanLyCuaHangSachMini.Helpers
{
    public static class NhatKyHelper
    {
        public static void GhiLog(string hanhDong, string bangDuLieu, string? khoaChinh = null, string? moTa = null)
        {
            try
            {
                using AppDbContext db = new AppDbContext();

                NhatKyHeThong nk = new NhatKyHeThong
                {
                    NhanVienID = SessionHelper.DaDangNhap ? SessionHelper.NhanVienID : null,
                    ThoiGian = DateTime.Now,
                    HanhDong = hanhDong,
                    BangDuLieu = bangDuLieu,
                    KhoaChinh = khoaChinh,
                    MoTa = moTa,
                    TenDangNhap = SessionHelper.TenDangNhap,
                    HoVaTen = SessionHelper.HoVaTen,
                    VaiTro = SessionHelper.TenVaiTro
                };

                db.NhatKyHeThong.Add(nk);
                db.SaveChanges();
            }
            catch
            {
                // Không làm văng nghiệp vụ chính
            }
        }
    }
}