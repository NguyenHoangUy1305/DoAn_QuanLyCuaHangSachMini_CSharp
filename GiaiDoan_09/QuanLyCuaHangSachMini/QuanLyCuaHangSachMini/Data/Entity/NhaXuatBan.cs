using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class NhaXuatBan
    {
        public int ID { get; set; }
        public string MaNhaXuatBan { get; set; } = string.Empty;
        public string TenNhaXuatBan { get; set; } = string.Empty;
        public string? DienThoai { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }

        public virtual ObservableCollectionListSource<Sach> Sach { get; } = new();
    }
}