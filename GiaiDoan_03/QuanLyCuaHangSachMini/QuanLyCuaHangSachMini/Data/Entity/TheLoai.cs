using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class TheLoai
    {
        public int ID { get; set; }
        public string MaTheLoai { get; set; } = string.Empty;
        public string TenTheLoai { get; set; } = string.Empty;
        public string? MoTa { get; set; }

        public virtual ObservableCollectionListSource<Sach> Sach { get; } = new();
    }
}