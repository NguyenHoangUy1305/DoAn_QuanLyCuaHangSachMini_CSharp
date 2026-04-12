using System.Configuration;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data.Entity;

namespace QuanLyCuaHangSachMini.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TheLoai> TheLoai { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBan { get; set; }
        public DbSet<Sach> Sach { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }
        public DbSet<PhieuNhap> PhieuNhap { get; set; }
        public DbSet<PhieuNhap_ChiTiet> PhieuNhap_ChiTiet { get; set; }
        public DbSet<NhatKyHeThong> NhatKyHeThong { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    ConfigurationManager.ConnectionStrings["QuanLyCuaHangSachMiniConnection"].ConnectionString
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Table
            builder.Entity<TheLoai>().ToTable("TheLoai");
            builder.Entity<NhaCungCap>().ToTable("NhaCungCap");
            builder.Entity<NhaXuatBan>().ToTable("NhaXuatBan");
            builder.Entity<Sach>().ToTable("Sach");
            builder.Entity<NhanVien>().ToTable("NhanVien");
            builder.Entity<KhachHang>().ToTable("KhachHang");
            builder.Entity<HoaDon>().ToTable("HoaDon");
            builder.Entity<HoaDon_ChiTiet>().ToTable("HoaDon_ChiTiet");
            builder.Entity<PhieuNhap>().ToTable("PhieuNhap");
            builder.Entity<PhieuNhap_ChiTiet>().ToTable("PhieuNhap_ChiTiet");
            builder.Entity<NhatKyHeThong>().ToTable("NhatKyHeThong");

            // Key
            builder.Entity<TheLoai>().HasKey(x => x.ID);
            builder.Entity<NhaCungCap>().HasKey(x => x.ID);
            builder.Entity<NhaXuatBan>().HasKey(x => x.ID);
            builder.Entity<Sach>().HasKey(x => x.ID);
            builder.Entity<NhanVien>().HasKey(x => x.ID);
            builder.Entity<KhachHang>().HasKey(x => x.ID);
            builder.Entity<HoaDon>().HasKey(x => x.ID);
            builder.Entity<HoaDon_ChiTiet>().HasKey(x => x.ID);
            builder.Entity<PhieuNhap>().HasKey(x => x.ID);
            builder.Entity<PhieuNhap_ChiTiet>().HasKey(x => x.ID);
            builder.Entity<NhatKyHeThong>().HasKey(x => x.ID);

            // Unique mã
            builder.Entity<TheLoai>().HasIndex(x => x.MaTheLoai).IsUnique();
            builder.Entity<NhaCungCap>().HasIndex(x => x.MaNhaCungCap).IsUnique();
            builder.Entity<NhaXuatBan>().HasIndex(x => x.MaNhaXuatBan).IsUnique();
            builder.Entity<Sach>().HasIndex(x => x.MaSach).IsUnique();
            builder.Entity<NhanVien>().HasIndex(x => x.MaNhanVien).IsUnique();
            builder.Entity<NhanVien>().HasIndex(x => x.TenDangNhap).IsUnique();
            builder.Entity<KhachHang>().HasIndex(x => x.MaKhachHang).IsUnique();
            builder.Entity<HoaDon>().HasIndex(x => x.MaHoaDon).IsUnique();
            builder.Entity<PhieuNhap>().HasIndex(x => x.MaPhieuNhap).IsUnique();

            // TheLoai
            builder.Entity<TheLoai>().Property(x => x.MaTheLoai).HasMaxLength(10).IsRequired();
            builder.Entity<TheLoai>().Property(x => x.TenTheLoai).HasMaxLength(100).IsRequired();
            builder.Entity<TheLoai>().Property(x => x.MoTa).HasMaxLength(500);

            // NhaCungCap
            builder.Entity<NhaCungCap>().Property(x => x.MaNhaCungCap).HasMaxLength(10).IsRequired();
            builder.Entity<NhaCungCap>().Property(x => x.TenNhaCungCap).HasMaxLength(150).IsRequired();
            builder.Entity<NhaCungCap>().Property(x => x.DienThoai).HasMaxLength(10).IsUnicode(false);
            builder.Entity<NhaCungCap>().Property(x => x.Email).HasMaxLength(100).IsUnicode(false);
            builder.Entity<NhaCungCap>().Property(x => x.DiaChi).HasMaxLength(255);

            // NhaXuatBan
            builder.Entity<NhaXuatBan>().Property(x => x.MaNhaXuatBan).HasMaxLength(10).IsRequired();
            builder.Entity<NhaXuatBan>().Property(x => x.TenNhaXuatBan).HasMaxLength(150).IsRequired();
            builder.Entity<NhaXuatBan>().Property(x => x.DienThoai).HasMaxLength(10).IsUnicode(false);
            builder.Entity<NhaXuatBan>().Property(x => x.Email).HasMaxLength(100).IsUnicode(false);
            builder.Entity<NhaXuatBan>().Property(x => x.DiaChi).HasMaxLength(255);

            // Sach
            builder.Entity<Sach>().Property(x => x.MaSach).HasMaxLength(10).IsRequired();
            builder.Entity<Sach>().Property(x => x.TenSach).HasMaxLength(200).IsRequired();
            builder.Entity<Sach>().Property(x => x.TacGia).HasMaxLength(150).IsRequired();
            builder.Entity<Sach>().Property(x => x.GiaNhap).HasColumnType("decimal(18,2)");
            builder.Entity<Sach>().Property(x => x.GiaBan).HasColumnType("decimal(18,2)");
            builder.Entity<Sach>().Property(x => x.HinhAnh).HasMaxLength(255);
            builder.Entity<Sach>().Property(x => x.MoTa).HasMaxLength(1000);
            builder.Entity<Sach>().Property(x => x.TrangThai).HasMaxLength(50).IsRequired();

            // NhanVien
            builder.Entity<NhanVien>().Property(x => x.MaNhanVien).HasMaxLength(10).IsRequired();
            builder.Entity<NhanVien>().Property(x => x.HoVaTen).HasMaxLength(150).IsRequired();
            builder.Entity<NhanVien>().Property(x => x.DienThoai).HasMaxLength(10).IsUnicode(false);
            builder.Entity<NhanVien>().Property(x => x.DiaChi).HasMaxLength(255);
            builder.Entity<NhanVien>().Property(x => x.TenDangNhap).HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Entity<NhanVien>().Property(x => x.MatKhau).HasMaxLength(255).IsRequired();

            // KhachHang
            builder.Entity<KhachHang>().Property(x => x.MaKhachHang).HasMaxLength(10).IsRequired();
            builder.Entity<KhachHang>().Property(x => x.HoVaTen).HasMaxLength(150).IsRequired();
            builder.Entity<KhachHang>().Property(x => x.DienThoai).HasMaxLength(10).IsUnicode(false);
            builder.Entity<KhachHang>().Property(x => x.DiaChi).HasMaxLength(255);
            builder.Entity<KhachHang>().Property(x => x.Email).HasMaxLength(100).IsUnicode(false);

            // HoaDon
            builder.Entity<HoaDon>().Property(x => x.MaHoaDon).HasMaxLength(10).IsRequired();
            builder.Entity<HoaDon>().Property(x => x.GhiChuHoaDon).HasMaxLength(500);

            // HoaDon_ChiTiet
            builder.Entity<HoaDon_ChiTiet>().Property(x => x.DonGiaBan).HasColumnType("decimal(18,2)");

            // PhieuNhap
            builder.Entity<PhieuNhap>().Property(x => x.MaPhieuNhap).HasMaxLength(10).IsRequired();
            builder.Entity<PhieuNhap>().Property(x => x.GhiChuPhieuNhap).HasMaxLength(500);

            // PhieuNhap_ChiTiet
            builder.Entity<PhieuNhap_ChiTiet>().Property(x => x.DonGiaNhap).HasColumnType("decimal(18,2)");

            // NhatKyHeThong
            builder.Entity<NhatKyHeThong>().Property(x => x.HanhDong).HasMaxLength(50).IsRequired();
            builder.Entity<NhatKyHeThong>().Property(x => x.BangDuLieu).HasMaxLength(100).IsRequired();
            builder.Entity<NhatKyHeThong>().Property(x => x.KhoaChinh).HasMaxLength(50);
            builder.Entity<NhatKyHeThong>().Property(x => x.MoTa).HasMaxLength(1000);
            builder.Entity<NhatKyHeThong>().Property(x => x.TenDangNhap).HasMaxLength(50);
            builder.Entity<NhatKyHeThong>().Property(x => x.HoVaTen).HasMaxLength(150);
            builder.Entity<NhatKyHeThong>().Property(x => x.VaiTro).HasMaxLength(50);
            

            // Relationship
            builder.Entity<Sach>()
                .HasOne(x => x.TheLoai)
                .WithMany(x => x.Sach)
                .HasForeignKey(x => x.TheLoaiID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Sach>()
                .HasOne(x => x.NhaXuatBan)
                .WithMany(x => x.Sach)
                .HasForeignKey(x => x.NhaXuatBanID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<HoaDon>()
                .HasOne(x => x.NhanVien)
                .WithMany(x => x.HoaDon)
                .HasForeignKey(x => x.NhanVienID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<HoaDon>()
                .HasOne(x => x.KhachHang)
                .WithMany(x => x.HoaDon)
                .HasForeignKey(x => x.KhachHangID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<HoaDon_ChiTiet>()
                .HasOne(x => x.HoaDon)
                .WithMany(x => x.HoaDon_ChiTiet)
                .HasForeignKey(x => x.HoaDonID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<HoaDon_ChiTiet>()
                .HasOne(x => x.Sach)
                .WithMany(x => x.HoaDon_ChiTiet)
                .HasForeignKey(x => x.SachID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<PhieuNhap>()
                .HasOne(x => x.NhaCungCap)
                .WithMany(x => x.PhieuNhap)
                .HasForeignKey(x => x.NhaCungCapID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<PhieuNhap>()
                .HasOne(x => x.NhanVien)
                .WithMany(x => x.PhieuNhap)
                .HasForeignKey(x => x.NhanVienID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<PhieuNhap_ChiTiet>()
                .HasOne(x => x.PhieuNhap)
                .WithMany(x => x.PhieuNhap_ChiTiet)
                .HasForeignKey(x => x.PhieuNhapID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<PhieuNhap_ChiTiet>()
                .HasOne(x => x.Sach)
                .WithMany(x => x.PhieuNhap_ChiTiet)
                .HasForeignKey(x => x.SachID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<NhatKyHeThong>()
                .HasOne(x => x.NhanVien)
                .WithMany(x => x.NhatKyHeThong)
                .HasForeignKey(x => x.NhanVienID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}