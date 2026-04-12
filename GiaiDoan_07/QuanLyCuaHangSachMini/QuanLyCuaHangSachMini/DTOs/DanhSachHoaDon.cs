using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangSachMini.DTOs
{
    [NotMapped]
    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public string MaHoaDon { get; set; } = string.Empty;
        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } = string.Empty;
        public int KhachHangID { get; set; }
        public string HoVaTenKhachHang { get; set; } = string.Empty;
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public decimal TongTienHoaDon { get; set; }
        public string? XemChiTiet { get; set; }
    }
}