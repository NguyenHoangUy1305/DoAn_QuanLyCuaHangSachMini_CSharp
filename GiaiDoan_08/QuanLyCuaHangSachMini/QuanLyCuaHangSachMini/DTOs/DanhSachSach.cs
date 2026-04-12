using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangSachMini.DTOs
{
    [NotMapped]
    public class DanhSachSach
    {
        public int ID { get; set; }
        public int TheLoaiID { get; set; }
        public string TenTheLoai { get; set; } = string.Empty;
        public int NhaXuatBanID { get; set; }
        public string TenNhaXuatBan { get; set; } = string.Empty;

        public string MaSach { get; set; } = string.Empty;
        public string TenSach { get; set; } = string.Empty;
        public string TacGia { get; set; } = string.Empty;
        public int NamXuatBan { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }
        public string TrangThai { get; set; } = string.Empty;
    }
}