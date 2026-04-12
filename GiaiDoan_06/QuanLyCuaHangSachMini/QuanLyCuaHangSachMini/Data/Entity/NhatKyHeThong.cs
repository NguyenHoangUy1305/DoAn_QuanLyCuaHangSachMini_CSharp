namespace QuanLyCuaHangSachMini.Data.Entity
{
    public class NhatKyHeThong
    {
        public int ID { get; set; }
        public int? NhanVienID { get; set; }

        public DateTime ThoiGian { get; set; } = DateTime.Now;
        public string HanhDong { get; set; } = string.Empty;       // Đăng nhập, Xem, Thêm, Sửa, Xóa...
        public string BangDuLieu { get; set; } = string.Empty;     // Sach, HoaDon, KhachHang...
        public string? KhoaChinh { get; set; }                     // ID bản ghi bị tác động
        public string? MoTa { get; set; }
        public string? TenDangNhap { get; set; }
        public string? HoVaTen { get; set; }
        public string? VaiTro { get; set; }                        // Quản trị viên / Nhân viên

        public virtual NhanVien? NhanVien { get; set; }
    }
}