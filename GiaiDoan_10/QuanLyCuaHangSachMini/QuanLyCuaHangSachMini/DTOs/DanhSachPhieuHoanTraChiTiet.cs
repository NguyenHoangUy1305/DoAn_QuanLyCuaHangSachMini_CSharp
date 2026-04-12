namespace QuanLyCuaHangSachMini.DTOs
{
    public class DanhSachPhieuHoanTra_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuHoanTraID { get; set; }
        public string MaPhieuHoanTra { get; set; } = string.Empty;

        public int HoaDonID { get; set; }
        public string MaHoaDon { get; set; } = string.Empty;

        public int NhanVienID { get; set; }
        public string TenNhanVien { get; set; } = string.Empty;

        public int KhachHangID { get; set; }
        public string TenKhachHang { get; set; } = string.Empty;

        public DateTime NgayHoanTra { get; set; }
        public string? LyDo { get; set; }

        public int HoaDonChiTietID { get; set; }
        public int SachID { get; set; }
        public string MaSach { get; set; } = string.Empty;
        public string TenSach { get; set; } = string.Empty;
        public int SoLuongBan { get; set; }
        public int SoLuongTra { get; set; }
        public decimal DonGiaHoanTra { get; set; }
        public decimal ThanhTien => SoLuongTra * DonGiaHoanTra;
    }

    public class DanhSachPhieuHoanTraChiTiet : DanhSachPhieuHoanTra_ChiTiet
    {
    }
}
