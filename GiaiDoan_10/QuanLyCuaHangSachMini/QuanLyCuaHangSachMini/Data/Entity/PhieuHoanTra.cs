using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class PhieuHoanTra
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int NhanVienID { get; set; }

        public string MaPhieuHoanTra { get; set; } = string.Empty;
        public DateTime NgayHoanTra { get; set; } = DateTime.Now;
        public string? LyDo { get; set; }

        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual ObservableCollectionListSource<PhieuHoanTra_ChiTiet> PhieuHoanTra_ChiTiet { get; } = new();
    }
}