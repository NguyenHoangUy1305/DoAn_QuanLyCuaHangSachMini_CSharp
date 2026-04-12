using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string MaNhanVien { get; set; } = string.Empty;
        public string HoVaTen { get; set; } = string.Empty;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
        public bool QuyenHan { get; set; } // true = Quản trị viên, false = Nhân viên
        public bool KichHoat { get; set; } = true;

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
        public virtual ObservableCollectionListSource<PhieuNhap> PhieuNhap { get; } = new();
        public virtual ObservableCollectionListSource<NhatKyHeThong> NhatKyHeThong { get; } = new();
    }
}