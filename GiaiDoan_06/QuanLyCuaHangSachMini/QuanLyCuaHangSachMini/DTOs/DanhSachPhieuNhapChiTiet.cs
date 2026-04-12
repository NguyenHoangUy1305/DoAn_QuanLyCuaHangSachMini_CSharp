using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangSachMini.DTOs
{
    [NotMapped]
    public class DanhSachPhieuNhapChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int SachID { get; set; }
        public string MaSach { get; set; } = string.Empty;
        public string TenSach { get; set; } = string.Empty;
        public int SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal ThanhTien { get; set; }
    }
}