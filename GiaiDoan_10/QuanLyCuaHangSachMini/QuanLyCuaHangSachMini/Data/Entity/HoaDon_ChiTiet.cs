namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class HoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SachID { get; set; }
        public int SoLuongBan { get; set; }
        public decimal DonGiaBan { get; set; }

        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual Sach Sach { get; set; } = null!;
    }
}