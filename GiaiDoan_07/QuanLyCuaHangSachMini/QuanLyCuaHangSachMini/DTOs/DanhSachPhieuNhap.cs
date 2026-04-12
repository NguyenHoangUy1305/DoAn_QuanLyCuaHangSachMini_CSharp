using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangSachMini.DTOs
{
    [NotMapped]
    public class DanhSachPhieuNhap
    {
        public int ID { get; set; }
        public string MaPhieuNhap { get; set; } = string.Empty;
        public int NhaCungCapID { get; set; }
        public string TenNhaCungCap { get; set; } = string.Empty;
        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } = string.Empty;
        public DateTime NgayNhap { get; set; }
        public string? GhiChuPhieuNhap { get; set; }
        public decimal TongTienPhieuNhap { get; set; }
        public string? XemChiTiet { get; set; }
    }
}