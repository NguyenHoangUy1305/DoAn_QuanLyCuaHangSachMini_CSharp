using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class PhieuNhap
    {
        public int ID { get; set; }
        public int NhaCungCapID { get; set; }
        public int NhanVienID { get; set; }

        public string MaPhieuNhap { get; set; } = string.Empty;
        public DateTime NgayNhap { get; set; } = DateTime.Now;
        public string? GhiChuPhieuNhap { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual ObservableCollectionListSource<PhieuNhap_ChiTiet> PhieuNhap_ChiTiet { get; } = new();
    }
}