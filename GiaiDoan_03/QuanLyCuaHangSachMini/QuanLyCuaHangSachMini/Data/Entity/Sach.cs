using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class Sach
    {
        public int ID { get; set; }
        public int TheLoaiID { get; set; }
        public int NhaXuatBanID { get; set; }

        public string MaSach { get; set; } = string.Empty;
        public string TenSach { get; set; } = string.Empty;
        public string TacGia { get; set; } = string.Empty;
        public int NamXuatBan { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }
        public string TrangThai { get; set; } = "Còn hàng";

        public virtual TheLoai TheLoai { get; set; } = null!;
        public virtual NhaXuatBan NhaXuatBan { get; set; } = null!;

        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual ObservableCollectionListSource<PhieuNhap_ChiTiet> PhieuNhap_ChiTiet { get; } = new();
    }
}