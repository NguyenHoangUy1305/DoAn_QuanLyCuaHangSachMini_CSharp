
-- =============================================
-- CSDL: QuanLyCuaHangSachMini
-- Script 3: DELETE FROM + DBCC CHECKIDENT + SELECT * FROM
-- =============================================

USE QuanLyCuaHangSachMini;
GO

-- Xóa dữ liệu theo thứ tự tránh lỗi khóa ngoại
DELETE FROM dbo.NhatKyHeThong;
DELETE FROM dbo.HoaDon_ChiTiet;
DELETE FROM dbo.PhieuNhap_ChiTiet;
DELETE FROM dbo.HoaDon;
DELETE FROM dbo.PhieuNhap;
DELETE FROM dbo.Sach;
DELETE FROM dbo.KhachHang;
DELETE FROM dbo.NhanVien;
DELETE FROM dbo.NhaXuatBan;
DELETE FROM dbo.NhaCungCap;
DELETE FROM dbo.TheLoai;
GO

-- Reset IDENTITY về lại từ 1
DBCC CHECKIDENT ('dbo.NhatKyHeThong', RESEED, 0);
DBCC CHECKIDENT ('dbo.HoaDon_ChiTiet', RESEED, 0);
DBCC CHECKIDENT ('dbo.PhieuNhap_ChiTiet', RESEED, 0);
DBCC CHECKIDENT ('dbo.HoaDon', RESEED, 0);
DBCC CHECKIDENT ('dbo.PhieuNhap', RESEED, 0);
DBCC CHECKIDENT ('dbo.Sach', RESEED, 0);
DBCC CHECKIDENT ('dbo.KhachHang', RESEED, 0);
DBCC CHECKIDENT ('dbo.NhanVien', RESEED, 0);
DBCC CHECKIDENT ('dbo.NhaXuatBan', RESEED, 0);
DBCC CHECKIDENT ('dbo.NhaCungCap', RESEED, 0);
DBCC CHECKIDENT ('dbo.TheLoai', RESEED, 0);
GO
-- 1. Thể loại
INSERT INTO dbo.TheLoai (MaTheLoai, TenTheLoai, MoTa) VALUES
(N'TL001', N'Văn học', N'Sách văn học trong và ngoài nước'),
(N'TL002', N'Kỹ năng sống', N'Sách phát triển bản thân'),
(N'TL003', N'Công nghệ thông tin', N'Sách lập trình, phần mềm'),
(N'TL004', N'Thiếu nhi', N'Sách dành cho trẻ em');
GO

-- 2. Nhà xuất bản
INSERT INTO dbo.NhaXuatBan (MaNhaXuatBan, TenNhaXuatBan, DienThoai, Email, DiaChi) VALUES
(N'NXB001', N'NXB Trẻ', '0283825163', 'nxbtre@gmail.com', N'TP.HCM'),
(N'NXB002', N'NXB Kim Đồng', '0243943473', 'kimdong@gmail.com', N'Hà Nội'),
(N'NXB003', N'NXB Giáo Dục', '0243971718', 'giaoduc@gmail.com', N'Hà Nội'),
(N'NXB004', N'NXB Lao Động', '0243944201', 'laodong@gmail.com', N'Hà Nội');
GO

-- 3. Nhà cung cấp
INSERT INTO dbo.NhaCungCap (MaNhaCungCap, TenNhaCungCap, DienThoai, Email, DiaChi) VALUES
(N'NCC001', N'Công ty Phát Hành Sách A', '0901111111', 'phathanhA@gmail.com', N'Long Xuyên - An Giang'),
(N'NCC002', N'Công ty Sách B', '0902222222', 'sachB@gmail.com', N'Cần Thơ'),
(N'NCC003', N'Nhà sách Tổng Hợp C', '0903333333', 'tonghopC@gmail.com', N'TP.HCM');
GO

-- 4. Nhân viên
INSERT INTO dbo.NhanVien (MaNhanVien, HoVaTen, DienThoai, DiaChi, TenDangNhap, MatKhau, QuyenHan, KichHoat) VALUES
(N'NV001', N'Nguyễn Hoàng Uy', '0911111111', N'Long Xuyên', 'admin', N'123456', 1, 1),
(N'NV002', N'Trần Minh Khoa', '0922222222', N'Châu Đốc', 'nv01', N'123456', 0, 1),
(N'NV003', N'Lê Thị Ngọc', '0933333333', N'Cần Thơ', 'nv02', N'123456', 0, 1);
GO

-- 5. Khách hàng
INSERT INTO dbo.KhachHang (MaKhachHang, HoVaTen, DienThoai, DiaChi, Email) VALUES
(N'KH001', N'Phạm Anh Tuấn', '0981111111', N'Long Xuyên', 'tuan@gmail.com'),
(N'KH002', N'Nguyễn Thị Mai', '0982222222', N'Cần Thơ', 'mai@gmail.com'),
(N'KH003', N'Trần Quốc Bảo', '0983333333', N'TP.HCM', 'bao@gmail.com'),
(N'KH004', N'Lê Minh Thư', '0984444444', N'Châu Đốc', 'thu@gmail.com');
GO

-- 6. Sách
INSERT INTO dbo.Sach
(
    TheLoaiID, NhaXuatBanID, MaSach, TenSach, TacGia, NamXuatBan,
    GiaNhap, GiaBan, SoLuongTon, HinhAnh, MoTa, TrangThai
)
VALUES
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai = N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan = N'NXB001'),
 N'S001', N'Nhà giả kim', N'Paulo Coelho', 2020, 50000, 78000, 42, N'nhagiakim.jpg', N'Tiểu thuyết nổi tiếng', N'Còn hàng'),

((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai = N'TL002'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan = N'NXB004'),
 N'S002', N'Đắc nhân tâm', N'Dale Carnegie', 2019, 55000, 85000, 35, N'dacnhantam.jpg', N'Sách kỹ năng sống', N'Còn hàng'),

((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai = N'TL003'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan = N'NXB003'),
 N'S003', N'Lập trình C# cơ bản', N'Nhiều tác giả', 2023, 90000, 130000, 26, N'laptrinhcsharp.jpg', N'Sách học lập trình C#', N'Còn hàng'),

((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai = N'TL003'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan = N'NXB003'),
 N'S004', N'Cơ sở dữ liệu SQL Server', N'Nhiều tác giả', 2022, 85000, 125000, 23, N'sqlserver.jpg', N'Sách học SQL Server', N'Còn hàng'),

((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai = N'TL004'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan = N'NXB002'),
 N'S005', N'Dế mèn phiêu lưu ký', N'Tô Hoài', 2021, 45000, 70000, 29, N'demen.jpg', N'Sách thiếu nhi', N'Còn hàng'),

((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai = N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan = N'NXB001'),
 N'S006', N'Tôi thấy hoa vàng trên cỏ xanh', N'Nguyễn Nhật Ánh', 2020, 60000, 90000, 17, N'hoavang.jpg', N'Tiểu thuyết Việt Nam', N'Còn hàng');
GO

-- 7. Phiếu nhập
INSERT INTO dbo.PhieuNhap (NhaCungCapID, NhanVienID, MaPhieuNhap, NgayNhap, GhiChuPhieuNhap) VALUES
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap = N'NCC001'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien = N'NV001'),
 N'PN001', '2026-03-20 09:00:00', N'Nhập đợt 1'),

((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap = N'NCC002'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien = N'NV002'),
 N'PN002', '2026-03-25 14:00:00', N'Nhập đợt 2');
GO

-- 8. Chi tiết phiếu nhập
INSERT INTO dbo.PhieuNhap_ChiTiet (PhieuNhapID, SachID, SoLuongNhap, DonGiaNhap) VALUES
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap = N'PN001'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S001'), 50, 50000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap = N'PN001'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S002'), 40, 55000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap = N'PN001'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S003'), 30, 90000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap = N'PN002'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S004'), 25, 85000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap = N'PN002'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S005'), 35, 45000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap = N'PN002'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S006'), 20, 60000);
GO

-- 9. Hóa đơn
INSERT INTO dbo.HoaDon (NhanVienID, KhachHangID, MaHoaDon, NgayLap, GhiChuHoaDon) VALUES
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien = N'NV002'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang = N'KH001'),
 N'HD001', '2026-03-28 10:15:00', N'Khách mua trực tiếp'),

((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien = N'NV003'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang = N'KH002'),
 N'HD002', '2026-03-30 15:30:00', N'Khách quen');
GO

-- 10. Chi tiết hóa đơn
INSERT INTO dbo.HoaDon_ChiTiet (HoaDonID, SachID, SoLuongBan, DonGiaBan) VALUES
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon = N'HD001'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S001'), 8, 78000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon = N'HD001'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S003'), 4, 130000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon = N'HD001'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S005'), 6, 70000),

((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon = N'HD002'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S002'), 5, 85000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon = N'HD002'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S004'), 2, 125000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon = N'HD002'), (SELECT ID FROM dbo.Sach WHERE MaSach = N'S006'), 3, 90000);
GO

-- 11. Nhật ký hệ thống
INSERT INTO dbo.NhatKyHeThong
(
    NhanVienID, ThoiGian, HanhDong, BangDuLieu, KhoaChinh, MoTa, TenDangNhap, HoVaTen, VaiTro
)
VALUES
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien = N'NV001'), '2026-04-04 08:00:00', N'Đăng nhập', N'Hệ thống', N'1', N'Đăng nhập vào hệ thống', N'admin', N'Nguyễn Hoàng Uy', N'Quản trị viên'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien = N'NV002'), '2026-04-04 08:30:00', N'Thêm', N'HoaDon', N'1', N'Lập hóa đơn: HD001', N'nv01', N'Trần Minh Khoa', N'Nhân viên'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien = N'NV003'), '2026-04-04 09:00:00', N'Thêm', N'HoaDon', N'2', N'Lập hóa đơn: HD002', N'nv02', N'Lê Thị Ngọc', N'Nhân viên'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien = N'NV001'), '2026-04-04 09:30:00', N'Xem', N'NhatKyHeThong', NULL, N'Xem nhật ký hệ thống', N'admin', N'Nguyễn Hoàng Uy', N'Quản trị viên');
GO

-- Kiểm tra dữ liệu
SELECT * FROM dbo.TheLoai;
SELECT * FROM dbo.NhaCungCap;
SELECT * FROM dbo.NhaXuatBan;
SELECT * FROM dbo.NhanVien;
SELECT * FROM dbo.KhachHang;
SELECT * FROM dbo.Sach;
SELECT * FROM dbo.PhieuNhap;
SELECT * FROM dbo.PhieuNhap_ChiTiet;
SELECT * FROM dbo.HoaDon;
SELECT * FROM dbo.HoaDon_ChiTiet;
SELECT * FROM dbo.NhatKyHeThong;
GO
