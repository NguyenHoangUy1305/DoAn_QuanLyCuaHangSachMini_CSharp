using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCuaHangSachMini.DTOs
{
    [NotMapped]
    public class DanhSachHoaDonChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SachID { get; set; }
        public string MaSach { get; set; } = string.Empty;
        public string TenSach { get; set; } = string.Empty;
        public int SoLuongBan { get; set; }
        public decimal DonGiaBan { get; set; }
        public decimal ThanhTien { get; set; }
    }
}