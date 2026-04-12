namespace QuanLyCuaHangSachMini.DTOs
{
    public class DanhSachPhieuHoanTra
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }

        public string MaPhieuHoanTra { get; set; } = string.Empty;
        public string MaHoaDon { get; set; } = string.Empty;
        public string TenNhanVien { get; set; } = string.Empty;
        public string TenKhachHang { get; set; } = string.Empty;

        public DateTime NgayHoanTra { get; set; }
        public string? LyDo { get; set; }
        public decimal TongTienHoan { get; set; }

        public string XemChiTiet { get; set; } = "Xem chi tiết";
    }
}
