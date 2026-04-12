namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class PhieuNhap_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int SachID { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; } = null!;
        public virtual Sach Sach { get; set; } = null!;
    }
}