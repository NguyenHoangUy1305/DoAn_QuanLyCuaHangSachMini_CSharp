namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class PhieuHoanTra_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuHoanTraID { get; set; }
        public int SachID { get; set; }
        public int SoLuongTra { get; set; }
        public decimal DonGiaHoanTra { get; set; }

        public virtual PhieuHoanTra PhieuHoanTra { get; set; } = null!;
        public virtual Sach Sach { get; set; } = null!;
    }
}