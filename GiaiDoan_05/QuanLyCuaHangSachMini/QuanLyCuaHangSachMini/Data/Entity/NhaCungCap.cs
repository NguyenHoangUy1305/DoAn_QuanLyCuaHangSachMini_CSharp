using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class NhaCungCap
    {
        public int ID { get; set; }
        public string MaNhaCungCap { get; set; } = string.Empty;
        public string TenNhaCungCap { get; set; } = string.Empty;
        public string? DienThoai { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }

        public virtual ObservableCollectionListSource<PhieuNhap> PhieuNhap { get; } = new();
    }
}