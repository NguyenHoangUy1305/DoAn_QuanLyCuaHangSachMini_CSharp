-- =============================================
-- CSDL: QuanLyCuaHangSachMini
-- Full Seed Script: Dữ liệu lớn (Bulk Test Data)
-- =============================================

USE QuanLyCuaHangSachMini;
GO

-- 1. Xóa dữ liệu theo thứ tự tránh lỗi khóa ngoại
DELETE FROM dbo.PhieuHoanTra_ChiTiet;
DELETE FROM dbo.PhieuHoanTra;
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

-- 2. Reset IDENTITY
DBCC CHECKIDENT ('dbo.PhieuHoanTra_ChiTiet', RESEED, 0);
DBCC CHECKIDENT ('dbo.PhieuHoanTra', RESEED, 0);
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

-- =============================================
-- 3. INSERT DANH MỤC (THỂ LOẠI, NXB, NCC, NHÂN VIÊN)
-- =============================================
INSERT INTO dbo.TheLoai (MaTheLoai, TenTheLoai, MoTa) VALUES
(N'TL001', N'Văn học', N'Sách văn học trong và ngoài nước'),
(N'TL002', N'Kỹ năng sống', N'Sách phát triển bản thân'),
(N'TL003', N'Công nghệ thông tin', N'Sách lập trình, phần mềm'),
(N'TL004', N'Thiếu nhi', N'Sách dành cho trẻ em'),
(N'TL005', N'Kinh doanh', N'Sách kinh tế, quản trị'),
(N'TL006', N'Tâm lý', N'Sách tâm lý học, phát triển cảm xúc'),
(N'TL007', N'Lịch sử', N'Sách lịch sử Việt Nam và thế giới'),
(N'TL008', N'Khoa học', N'Kiến thức khoa học vũ trụ, tự nhiên'),
(N'TL009', N'Ngoại ngữ', N'Sách học tiếng Anh, Nhật, Hàn, Trung'),
(N'TL010', N'Nấu ăn', N'Hướng dẫn nấu ăn, ẩm thực'),
(N'TL011', N'Truyện tranh', N'Manga, Comic, Truyện tranh màu'),
(N'TL012', N'Tôn giáo', N'Tôn giáo, triết học'),
(N'TL013', N'Giáo khoa', N'Sách giáo khoa các cấp'),
(N'TL014', N'Nghệ thuật', N'Hội họa, âm nhạc, nhiếp ảnh'),
(N'TL015', N'Du ký', N'Ghi chép hành trình, cẩm nang du lịch');
GO

INSERT INTO dbo.NhaXuatBan (MaNhaXuatBan, TenNhaXuatBan, DienThoai, Email, DiaChi) VALUES
(N'NXB001', N'NXB Trẻ', '0283825163', 'nxbtre@gmail.com', N'TP.HCM'),
(N'NXB002', N'NXB Kim Đồng', '0243943473', 'kimdong@gmail.com', N'Hà Nội'),
(N'NXB003', N'NXB Giáo Dục', '0243971718', 'giaoduc@gmail.com', N'Hà Nội'),
(N'NXB004', N'NXB Lao Động', '0243944201', 'laodong@gmail.com', N'Hà Nội'),
(N'NXB005', N'NXB Tổng Hợp', '0283920001', 'tonghop@gmail.com', N'TP.HCM'),
(N'NXB006', N'NXB Phụ Nữ', '0243971616', 'phunu@gmail.com', N'Hà Nội'),
(N'NXB007', N'NXB Chính trị Quốc gia', '0243822150', 'ctqg@gmail.com', N'Hà Nội'),
(N'NXB008', N'NXB Văn Học', '0243825700', 'vanhoc@gmail.com', N'Hà Nội'),
(N'NXB009', N'NXB Thế Giới', '0243825380', 'thegioi@gmail.com', N'Hà Nội'),
(N'NXB010', N'NXB Tri Thức', '0243944727', 'trithuc@gmail.com', N'Hà Nội');
GO

INSERT INTO dbo.NhaCungCap (MaNhaCungCap, TenNhaCungCap, DienThoai, Email, DiaChi) VALUES
(N'NCC001', N'Công ty Phát Hành Sách A', '0901111111', 'phathanhA@gmail.com', N'Long Xuyên'),
(N'NCC002', N'Công ty Sách B', '0902222222', 'sachB@gmail.com', N'Cần Thơ'),
(N'NCC003', N'Nhà sách Tổng Hợp C', '0903333333', 'tonghopC@gmail.com', N'TP.HCM'),
(N'NCC004', N'Đơn vị Sách D', '0904444444', 'sachD@gmail.com', N'Đà Nẵng'),
(N'NCC005', N'Fahasa', '0905555555', 'fahasa@gmail.com', N'TP.HCM'),
(N'NCC006', N'Tiki Trading', '0906666666', 'tiki@gmail.com', N'TP.HCM'),
(N'NCC007', N'Phương Nam Book', '0907777777', 'phuongnam@gmail.com', N'Hà Nội'),
(N'NCC008', N'Alphabooks', '0908888888', 'alpha@gmail.com', N'Hà Nội'),
(N'NCC009', N'Nhã Nam', '0909999999', 'nhanam@gmail.com', N'Hà Nội'),
(N'NCC010', N'First News', '0910101010', 'firstnews@gmail.com', N'TP.HCM');
GO

INSERT INTO dbo.NhanVien (MaNhanVien, HoVaTen, DienThoai, DiaChi, TenDangNhap, MatKhau, QuyenHan, KichHoat) VALUES
(N'NV001', N'Nguyễn Hoàng Uy', '0911111111', N'Long Xuyên', 'admin', N'123456', 1, 1),
(N'NV002', N'Trần Minh Khoa', '0922222222', N'Châu Đốc', 'nv01', N'123456', 0, 1),
(N'NV003', N'Lê Thị Ngọc', '0933333333', N'Cần Thơ', 'nv02', N'123456', 0, 1),
(N'NV004', N'Phạm Văn Cường', '0944444444', N'Hà Nội', 'nv03', N'123456', 0, 1),
(N'NV005', N'Hoàng Thị Yến', '0955555555', N'Đà Nẵng', 'nv04', N'123456', 0, 1),
(N'NV006', N'Vũ Đức Đam', '0966666666', N'TP.HCM', 'nv05', N'123456', 0, 1),
(N'NV007', N'Đỗ Mỹ Linh', '0977777777', N'Hải Phòng', 'nv06', N'123456', 0, 1),
(N'NV008', N'Ngô Bảo Châu', '0988888888', N'Cần Thơ', 'nv07', N'123456', 0, 1),
(N'NV009', N'Lý Thường Kiệt', '0999999999', N'Bắc Ninh', 'nv08', N'123456', 0, 1),
(N'NV010', N'Trương Định', '0912121212', N'Long An', 'nv09', N'123456', 0, 1);
GO

-- =============================================
-- 4. INSERT 40 KHÁCH HÀNG
-- =============================================
INSERT INTO dbo.KhachHang (MaKhachHang, HoVaTen, DienThoai, DiaChi, Email) VALUES
(N'KH001', N'Phạm Anh Tuấn', '0981111111', N'Long Xuyên', 'tuan@gmail.com'),
(N'KH002', N'Nguyễn Thị Mai', '0982222222', N'Cần Thơ', 'mai@gmail.com'),
(N'KH003', N'Trần Quốc Bảo', '0983333333', N'TP.HCM', 'bao@gmail.com'),
(N'KH004', N'Lê Minh Thư', '0984444444', N'Châu Đốc', 'thu@gmail.com'),
(N'KH005', N'Võ Thanh Sơn', '0985555555', N'Long An', 'son@gmail.com'),
(N'KH006', N'Đặng Ngọc Lan', '0986666666', N'Huế', 'lan@gmail.com'),
(N'KH007', N'Bùi Quang Sáng', '0987777777', N'Hà Nội', 'sang@gmail.com'),
(N'KH008', N'Hồ Tấn Tài', '0988888888', N'Bình Dương', 'tai@gmail.com'),
(N'KH009', N'Dương Thúy Kiều', '0989999999', N'Đồng Nai', 'kieu@gmail.com'),
(N'KH010', N'Đinh Tiến Dũng', '0910000000', N'Vĩnh Long', 'dung@gmail.com'),
(N'KH011', N'Lương Xuân Trường', '0911000001', N'Tuyên Quang', 'truong@gmail.com'),
(N'KH012', N'Phan Văn Đức', '0912000002', N'Nghệ An', 'duc@gmail.com'),
(N'KH013', N'Nguyễn Quang Hải', '0913000003', N'Hà Nội', 'hai@gmail.com'),
(N'KH014', N'Trần Đình Trọng', '0914000004', N'Hà Nội', 'trong@gmail.com'),
(N'KH015', N'Đoàn Văn Hậu', '0915000005', N'Thái Bình', 'hau@gmail.com'),
(N'KH016', N'Nguyễn Công Phượng', '0916000006', N'Nghệ An', 'phuong@gmail.com'),
(N'KH017', N'Nguyễn Văn Toàn', '0917000007', N'Hải Dương', 'toan@gmail.com'),
(N'KH018', N'Vũ Văn Thanh', '0918000008', N'Hải Dương', 'thanh@gmail.com'),
(N'KH019', N'Nguyễn Tuấn Anh', '0919000009', N'Thái Bình', 'anh@gmail.com'),
(N'KH020', N'Bùi Tiến Dũng', '0920000010', N'Thanh Hóa', 'dungbui@gmail.com'),
(N'KH021', N'Quế Ngọc Hải', '0921000011', N'Nghệ An', 'haingoc@gmail.com'),
(N'KH022', N'Đỗ Hùng Dũng', '0922000012', N'Hà Nội', 'dunghung@gmail.com'),
(N'KH023', N'Phạm Đức Huy', '0923000013', N'Hải Dương', 'huy@gmail.com'),
(N'KH024', N'Nguyễn Hoàng Đức', '0924000014', N'Hải Dương', 'hoangduc@gmail.com'),
(N'KH025', N'Nguyễn Tiến Linh', '0925000015', N'Hải Dương', 'linh@gmail.com'),
(N'KH026', N'Hà Đức Chinh', '0926000016', N'Phú Thọ', 'chinh@gmail.com'),
(N'KH027', N'Nguyễn Trọng Hoàng', '0927000017', N'Nghệ An', 'hoang@gmail.com'),
(N'KH028', N'Đặng Văn Lâm', '0928000018', N'Nga', 'lam@gmail.com'),
(N'KH029', N'Bùi Tấn Trường', '0929000019', N'Đồng Tháp', 'truongtan@gmail.com'),
(N'KH030', N'Hồ Tuấn Tài', '0930000020', N'Nghệ An', 'hotai@gmail.com'),
(N'KH031', N'Cao Văn Triền', '0931000021', N'Bình Định', 'trien@gmail.com'),
(N'KH032', N'Trần Minh Vương', '0932000022', N'Thái Bình', 'vuong@gmail.com'),
(N'KH033', N'Lê Văn Xuân', '0933000023', N'Thanh Hóa', 'xuan@gmail.com'),
(N'KH034', N'Nguyễn Thành Chung', '0934000024', N'Tuyên Quang', 'chung@gmail.com'),
(N'KH035', N'Bùi Hoàng Việt Anh', '0935000025', N'Thái Bình', 'vietanh@gmail.com'),
(N'KH036', N'Lý Công Hoàng Anh', '0936000026', N'Hòa Bình', 'hoanganh@gmail.com'),
(N'KH037', N'Nguyễn Thanh Bình', '0937000027', N'Thái Bình', 'binh@gmail.com'),
(N'KH038', N'Phan Tuấn Tài', '0938000028', N'Đắk Lắk', 'tuantai@gmail.com'),
(N'KH039', N'Khuất Văn Khang', '0939000029', N'Hà Nội', 'khang@gmail.com'),
(N'KH040', N'Nguyễn Văn Trường', '0940000030', N'Hưng Yên', 'truongvan@gmail.com');
GO

-- =============================================
-- 5. INSERT 50 SÁCH
-- =============================================
-- Giả lập tồn kho ban đầu bằng 0 (sẽ cập nhật qua Phiếu Nhập)
INSERT INTO dbo.Sach (TheLoaiID, NhaXuatBanID, MaSach, TenSach, TacGia, NamXuatBan, GiaNhap, GiaBan, SoLuongTon, HinhAnh, MoTa, TrangThai) VALUES
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S001', N'Nhà giả kim', N'Paulo Coelho', 2020, 50000, 78000, 0, N's001.jpg', N'Tiểu thuyết nổi tiếng', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL002'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB004'), N'S002', N'Đắc nhân tâm', N'Dale Carnegie', 2019, 55000, 85000, 0, N's002.jpg', N'Sách kỹ năng sống', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL003'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB003'), N'S003', N'Lập trình C# cơ bản', N'Nhiều tác giả', 2023, 90000, 130000, 0, N's003.jpg', N'Sách học lập trình C#', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL003'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB003'), N'S004', N'Cơ sở dữ liệu SQL Server', N'Nhiều tác giả', 2022, 85000, 125000, 0, N's004.jpg', N'Sách học SQL Server', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL004'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB002'), N'S005', N'Dế mèn phiêu lưu ký', N'Tô Hoài', 2021, 45000, 70000, 0, N's005.jpg', N'Sách thiếu nhi', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S006', N'Tôi thấy hoa vàng trên cỏ xanh', N'Nguyễn Nhật Ánh', 2020, 60000, 90000, 0, N's006.jpg', N'Tiểu thuyết Việt Nam', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL002'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB004'), N'S007', N'Thói quen nguyên tử', N'James Clear', 2022, 80000, 120000, 0, N's007.jpg', N'Thay đổi thói quen', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL005'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB005'), N'S008', N'Cha giàu cha nghèo', N'Robert Kiyosaki', 2021, 75000, 110000, 0, N's008.jpg', N'Sách tài chính cá nhân', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL006'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB005'), N'S009', N'Tư duy nhanh và chậm', N'Daniel Kahneman', 2018, 120000, 180000, 0, N's009.jpg', N'Tâm lý học hành vi', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S010', N'Không gia đình', N'Hector Malot', 2019, 65000, 95000, 0, N's010.jpg', N'Văn học kinh điển', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL007'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB007'), N'S011', N'Sử Việt 12 khúc tráng ca', N'Dũng Phan', 2020, 70000, 105000, 0, N's011.jpg', N'Lịch sử Việt Nam', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL008'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S012', N'Lược sử thời gian', N'Stephen Hawking', 2017, 90000, 140000, 0, N's012.jpg', N'Khoa học vũ trụ', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL009'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB005'), N'S013', N'Hack não 1500 từ tiếng Anh', N'Nhiều tác giả', 2021, 200000, 395000, 0, N's013.jpg', N'Học tiếng anh', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL011'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB002'), N'S014', N'Doraemon Vol 1', N'Fujiko F. Fujio', 2022, 15000, 20000, 0, N's014.jpg', N'Truyện tranh Nhật Bản', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL011'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB002'), N'S015', N'Conan Vol 100', N'Gosho Aoyama', 2023, 18000, 25000, 0, N's015.jpg', N'Truyện tranh trinh thám', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB008'), N'S016', N'Tắt đèn', N'Ngô Tất Tố', 2015, 30000, 45000, 0, N's016.jpg', N'Văn học hiện thực', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB008'), N'S017', N'Số đỏ', N'Vũ Trọng Phụng', 2016, 35000, 50000, 0, N's017.jpg', N'Văn học châm biếm', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL005'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S018', N'Từ tốt đến vĩ đại', N'Jim Collins', 2019, 95000, 145000, 0, N's018.jpg', N'Quản trị kinh doanh', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL002'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S019', N'Sức mạnh của thói quen', N'Charles Duhigg', 2020, 85000, 130000, 0, N's019.jpg', N'Kỹ năng', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL006'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB005'), N'S020', N'Đọc vị bất kỳ ai', N'David J. Lieberman', 2018, 55000, 80000, 0, N's020.jpg', N'Tâm lý', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB009'), N'S021', N'Suối nguồn', N'Ayn Rand', 2015, 150000, 220000, 0, N's021.jpg', N'Tiểu thuyết triết học', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL004'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB002'), N'S022', N'Harry Potter và Hòn đá phù thủy', N'J.K. Rowling', 2018, 120000, 175000, 0, N's022.jpg', N'Thiếu nhi, kỳ ảo', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL010'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB006'), N'S023', N'Món ngon mỗi ngày', N'Nhiều tác giả', 2021, 60000, 90000, 0, N's023.jpg', N'Sách nấu ăn', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL003'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB010'), N'S024', N'Python cho người mới', N'Nguyễn Văn A', 2023, 110000, 160000, 0, N's024.jpg', N'Lập trình Python', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL003'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB010'), N'S025', N'Clean Code', N'Robert C. Martin', 2020, 200000, 300000, 0, N's025.jpg', N'Kỹ thuật phần mềm', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL007'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB009'), N'S026', N'Sapiens: Lược sử loài người', N'Yuval Noah Harari', 2019, 140000, 210000, 0, N's026.jpg', N'Lịch sử tiến hóa', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL005'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB005'), N'S027', N'Nghĩ giàu và làm giàu', N'Napoleon Hill', 2018, 65000, 95000, 0, N's027.jpg', N'Kinh doanh, phát triển', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S028', N'Hai vạn dặm dưới đáy biển', N'Jules Verne', 2016, 75000, 115000, 0, N's028.jpg', N'Viễn tưởng', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL004'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB002'), N'S029', N'Hoàng tử bé', N'Antoine de Saint-Exupéry', 2021, 45000, 65000, 0, N's029.jpg', N'Văn học thiếu nhi', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL002'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S030', N'Tuổi trẻ đáng giá bao nhiêu', N'Rosie Nguyễn', 2018, 55000, 85000, 0, N's030.jpg', N'Tản văn, kỹ năng', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB008'), N'S031', N'Chí Phèo', N'Nam Cao', 2015, 25000, 40000, 0, N's031.jpg', N'Truyện ngắn', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S032', N'Bắt trẻ đồng xanh', N'J.D. Salinger', 2017, 60000, 90000, 0, N's032.jpg', N'Tiểu thuyết Mỹ', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S033', N'Đại gia Gatsby', N'F. Scott Fitzgerald', 2018, 65000, 95000, 0, N's033.jpg', N'Tiểu thuyết Mỹ', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL006'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB005'), N'S034', N'Sự im lặng của bầy cừu', N'Thomas Harris', 2019, 85000, 125000, 0, N's034.jpg', N'Tâm lý tội phạm', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL008'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB010'), N'S035', N'Vũ trụ', N'Carl Sagan', 2020, 110000, 165000, 0, N's035.jpg', N'Khoa học phổ thông', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S036', N'Trăm năm cô đơn', N'Gabriel García Márquez', 2017, 130000, 195000, 0, N's036.jpg', N'Hiện thực huyền ảo', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL004'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB002'), N'S037', N'Tốt-tô-chan cô bé bên cửa sổ', N'Tetsuko Kuroyanagi', 2019, 55000, 85000, 0, N's037.jpg', N'Thiếu nhi, giáo dục', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL011'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB002'), N'S038', N'Dragon Ball Vol 1', N'Akira Toriyama', 2021, 20000, 30000, 0, N's038.jpg', N'Truyện tranh', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL011'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB002'), N'S039', N'Naruto Vol 1', N'Masashi Kishimoto', 2020, 18000, 25000, 0, N's039.jpg', N'Truyện tranh Ninja', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL011'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB002'), N'S040', N'One Piece Vol 1', N'Eiichiro Oda', 2022, 20000, 30000, 0, N's040.jpg', N'Truyện tranh hải tặc', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL002'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S041', N'Tâm lý học thành công', N'Carol S. Dweck', 2019, 90000, 135000, 0, N's041.jpg', N'Phát triển tư duy', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL005'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB005'), N'S042', N'Chiến lược đại dương xanh', N'W. Chan Kim', 2018, 100000, 150000, 0, N's042.jpg', N'Kinh doanh chiến lược', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL012'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB009'), N'S043', N'Đường xưa mây trắng', N'Thích Nhất Hạnh', 2020, 120000, 180000, 0, N's043.jpg', N'Tôn giáo, Phật giáo', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL013'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB003'), N'S044', N'Toán 12', N'Bộ Giáo Dục', 2023, 15000, 22000, 0, N's044.jpg', N'Sách giáo khoa', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL013'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB003'), N'S045', N'Ngữ Văn 12 Tập 1', N'Bộ Giáo Dục', 2023, 14000, 20000, 0, N's045.jpg', N'Sách giáo khoa', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL013'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB003'), N'S046', N'Vật Lý 12', N'Bộ Giáo Dục', 2023, 16000, 24000, 0, N's046.jpg', N'Sách giáo khoa', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL003'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB010'), N'S047', N'Lập trình Java', N'Quách Tuấn Ngọc', 2015, 80000, 120000, 0, N's047.jpg', N'Sách tin học đại cương', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL015'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S048', N'Xách ba lô lên và đi', N'Huyền Chip', 2014, 60000, 90000, 0, N's048.jpg', N'Du ký', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL014'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB006'), N'S049', N'Lịch sử mỹ thuật thế giới', N'E.H. Gombrich', 2020, 250000, 380000, 0, N's049.jpg', N'Nghệ thuật', N'Hết hàng'),
((SELECT ID FROM dbo.TheLoai WHERE MaTheLoai=N'TL001'), (SELECT ID FROM dbo.NhaXuatBan WHERE MaNhaXuatBan=N'NXB001'), N'S050', N'Mắt biếc', N'Nguyễn Nhật Ánh', 2019, 70000, 105000, 0, N's050.jpg', N'Tiểu thuyết lãng mạn', N'Hết hàng');
GO

-- =============================================
-- 6. INSERT PHIẾU NHẬP (15 PHIẾU) VÀ CHI TIẾT
-- =============================================
INSERT INTO dbo.PhieuNhap (NhaCungCapID, NhanVienID, MaPhieuNhap, NgayNhap, GhiChuPhieuNhap) VALUES
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC001'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV001'), N'PN001', '2026-03-01 09:00:00', N'Nhập lô văn học 1'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC002'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), N'PN002', '2026-03-02 10:00:00', N'Nhập lô kỹ năng'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC003'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV003'), N'PN003', '2026-03-05 14:30:00', N'Nhập lô CNTT'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC004'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV004'), N'PN004', '2026-03-10 08:15:00', N'Nhập thiếu nhi'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC005'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV005'), N'PN005', '2026-03-12 16:00:00', N'Nhập Fahasa'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC006'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV001'), N'PN006', '2026-03-15 09:00:00', N'Nhập Tiki'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC007'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), N'PN007', '2026-03-18 11:20:00', N'Nhập Phương Nam'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC008'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV003'), N'PN008', '2026-03-20 14:00:00', N'Nhập Alphabooks'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC009'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV004'), N'PN009', '2026-03-22 09:45:00', N'Nhập Nhã Nam'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC010'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV005'), N'PN010', '2026-03-25 15:30:00', N'Nhập First News'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC001'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV001'), N'PN011', '2026-03-28 10:00:00', N'Nhập SGK'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC002'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), N'PN012', '2026-04-01 08:00:00', N'Nhập truyện tranh'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC003'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV003'), N'PN013', '2026-04-02 14:10:00', N'Bổ sung tồn kho'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC004'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV004'), N'PN014', '2026-04-05 09:20:00', N'Nhập mới'),
((SELECT ID FROM dbo.NhaCungCap WHERE MaNhaCungCap=N'NCC005'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV005'), N'PN015', '2026-04-08 10:00:00', N'Nhập mới');
GO

-- Chèn chi tiết nhập (mỗi phiếu nhập 3-5 cuốn, số lượng từ 20-100 cuốn để tạo tồn kho)
INSERT INTO dbo.PhieuNhap_ChiTiet (PhieuNhapID, SachID, SoLuongNhap, DonGiaNhap) VALUES
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN001'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S001'), 100, 50000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN001'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S006'), 80, 60000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN001'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S010'), 50, 65000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN002'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S002'), 150, 55000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN002'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S007'), 100, 80000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN003'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S003'), 60, 90000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN003'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S004'), 60, 85000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN004'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S005'), 200, 45000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN004'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S022'), 100, 120000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN005'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S008'), 120, 75000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN005'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S009'), 80, 120000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN006'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S011'), 50, 70000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN006'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S012'), 50, 90000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN007'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S014'), 300, 15000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN007'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S015'), 300, 18000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN008'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S018'), 100, 95000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN008'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S019'), 100, 85000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN009'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S026'), 70, 140000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN009'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S036'), 60, 130000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN010'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S030'), 150, 55000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN010'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S041'), 90, 90000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN011'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S044'), 500, 15000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN011'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S045'), 500, 14000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN011'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S046'), 500, 16000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN012'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S038'), 200, 20000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN012'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S039'), 200, 18000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN012'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S040'), 200, 20000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN013'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S001'), 50, 50000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN013'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S050'), 100, 70000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN014'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S024'), 80, 110000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN014'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S025'), 50, 200000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN015'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S048'), 60, 60000),
((SELECT ID FROM dbo.PhieuNhap WHERE MaPhieuNhap=N'PN015'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S049'), 30, 250000);
GO

-- Cập nhật tồn kho sau nhập
UPDATE s
SET s.SoLuongTon = s.SoLuongTon + x.TongNhap,
    s.TrangThai = CASE WHEN s.SoLuongTon + x.TongNhap > 0 THEN N'Còn hàng' ELSE N'Hết hàng' END
FROM dbo.Sach s
INNER JOIN (
    SELECT SachID, SUM(SoLuongNhap) AS TongNhap
    FROM dbo.PhieuNhap_ChiTiet
    GROUP BY SachID
) x ON x.SachID = s.ID;
GO

-- =============================================
-- 7. INSERT HÓA ĐƠN (40 HÓA ĐƠN) VÀ CHI TIẾT
-- =============================================
INSERT INTO dbo.HoaDon (NhanVienID, KhachHangID, MaHoaDon, NgayLap, GhiChuHoaDon) VALUES
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH001'), N'HD001', '2026-03-05 10:00:00', N'Khách vãng lai'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV003'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH002'), N'HD002', '2026-03-06 11:30:00', N'Thanh toán TM'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV004'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH003'), N'HD003', '2026-03-07 14:15:00', N'Cà thẻ'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV005'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH004'), N'HD004', '2026-03-08 09:45:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH005'), N'HD005', '2026-03-10 16:20:00', N'Mua làm quà tặng'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV003'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH006'), N'HD006', '2026-03-11 18:00:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV004'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH007'), N'HD007', '2026-03-12 10:10:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV005'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH008'), N'HD008', '2026-03-15 08:30:00', N'Chuyển khoản'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV006'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH009'), N'HD009', '2026-03-16 19:00:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV007'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH010'), N'HD010', '2026-03-18 13:40:00', N'Khách VIP'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH011'), N'HD011', '2026-03-20 15:50:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV003'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH012'), N'HD012', '2026-03-22 09:10:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV004'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH013'), N'HD013', '2026-03-23 11:20:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV005'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH014'), N'HD014', '2026-03-25 14:00:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV006'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH015'), N'HD015', '2026-03-26 16:30:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV007'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH016'), N'HD016', '2026-03-28 10:45:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH017'), N'HD017', '2026-03-30 08:15:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV003'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH018'), N'HD018', '2026-04-01 12:00:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV004'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH019'), N'HD019', '2026-04-02 18:20:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV005'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH020'), N'HD020', '2026-04-03 09:30:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV006'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH021'), N'HD021', '2026-04-04 14:10:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV007'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH022'), N'HD022', '2026-04-05 16:45:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH023'), N'HD023', '2026-04-06 10:00:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV003'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH024'), N'HD024', '2026-04-06 11:30:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV004'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH025'), N'HD025', '2026-04-06 15:20:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV005'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH026'), N'HD026', '2026-04-07 09:15:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV006'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH027'), N'HD027', '2026-04-07 14:40:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV007'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH028'), N'HD028', '2026-04-07 19:10:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH029'), N'HD029', '2026-04-08 08:50:00', N''),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV003'), (SELECT ID FROM dbo.KhachHang WHERE MaKhachHang=N'KH030'), N'HD030', '2026-04-08 10:30:00', N'');
GO

-- Chèn chi tiết hóa đơn (mỗi hóa đơn mua vài cuốn sách)
INSERT INTO dbo.HoaDon_ChiTiet (HoaDonID, SachID, SoLuongBan, DonGiaBan) VALUES
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD001'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S001'), 2, 78000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD001'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S002'), 1, 85000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD002'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S003'), 1, 130000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD003'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S005'), 5, 70000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD003'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S022'), 2, 175000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD004'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S008'), 1, 110000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD005'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S014'), 10, 20000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD005'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S015'), 10, 25000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD006'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S044'), 2, 22000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD006'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S045'), 2, 20000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD007'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S026'), 1, 210000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD008'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S030'), 3, 85000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD009'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S038'), 5, 30000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD010'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S050'), 2, 105000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD011'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S001'), 1, 78000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD011'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S007'), 1, 120000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD012'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S009'), 1, 180000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD013'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S011'), 2, 105000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD014'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S018'), 1, 145000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD015'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S019'), 2, 130000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD016'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S041'), 1, 135000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD017'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S048'), 1, 90000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD018'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S049'), 1, 380000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD019'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S024'), 1, 160000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD020'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S004'), 2, 125000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD021'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S012'), 1, 140000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD022'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S036'), 1, 195000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD023'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S006'), 3, 90000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD024'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S010'), 2, 95000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD025'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S039'), 5, 25000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD026'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S040'), 4, 30000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD027'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S046'), 3, 24000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD028'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S025'), 1, 300000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD029'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S050'), 5, 105000),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD030'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S001'), 4, 78000);
GO

-- Cập nhật tồn kho sau bán
UPDATE s
SET s.SoLuongTon = s.SoLuongTon - x.TongBan,
    s.TrangThai = CASE WHEN s.SoLuongTon - x.TongBan > 0 THEN N'Còn hàng' ELSE N'Hết hàng' END
FROM dbo.Sach s
INNER JOIN (
    SELECT SachID, SUM(SoLuongBan) AS TongBan
    FROM dbo.HoaDon_ChiTiet
    GROUP BY SachID
) x ON x.SachID = s.ID;
GO

-- =============================================
-- 8. INSERT PHIẾU HOÀN TRẢ (5 PHIẾU) VÀ CHI TIẾT
-- =============================================
INSERT INTO dbo.PhieuHoanTra (HoaDonID, NhanVienID, MaPhieuHoanTra, NgayHoanTra, LyDo) VALUES
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD001'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), N'PHT001', '2026-03-06 09:00:00', N'Khách trả lại S001 do sách lỗi in'),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD005'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), N'PHT002', '2026-03-12 10:00:00', N'Trả lại 2 quyển Doraemon'),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD011'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), N'PHT003', '2026-03-21 15:00:00', N'Khách đổi ý'),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD023'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), N'PHT004', '2026-04-07 09:30:00', N'Sách bị rách bìa'),
((SELECT ID FROM dbo.HoaDon WHERE MaHoaDon=N'HD030'), (SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV003'), N'PHT005', '2026-04-09 08:00:00', N'Mua dư');
GO

INSERT INTO dbo.PhieuHoanTra_ChiTiet (PhieuHoanTraID, SachID, SoLuongTra, DonGiaHoanTra) VALUES
((SELECT ID FROM dbo.PhieuHoanTra WHERE MaPhieuHoanTra=N'PHT001'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S001'), 1, 78000),
((SELECT ID FROM dbo.PhieuHoanTra WHERE MaPhieuHoanTra=N'PHT002'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S014'), 2, 20000),
((SELECT ID FROM dbo.PhieuHoanTra WHERE MaPhieuHoanTra=N'PHT003'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S007'), 1, 120000),
((SELECT ID FROM dbo.PhieuHoanTra WHERE MaPhieuHoanTra=N'PHT004'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S006'), 1, 90000),
((SELECT ID FROM dbo.PhieuHoanTra WHERE MaPhieuHoanTra=N'PHT005'), (SELECT ID FROM dbo.Sach WHERE MaSach=N'S001'), 2, 78000);
GO

-- Cập nhật tồn kho sau hoàn trả
UPDATE s
SET s.SoLuongTon = s.SoLuongTon + x.TongTra,
    s.TrangThai = CASE WHEN s.SoLuongTon + x.TongTra > 0 THEN N'Còn hàng' ELSE N'Hết hàng' END
FROM dbo.Sach s
INNER JOIN (
    SELECT SachID, SUM(SoLuongTra) AS TongTra
    FROM dbo.PhieuHoanTra_ChiTiet
    GROUP BY SachID
) x ON x.SachID = s.ID;
GO

-- =============================================
-- 9. INSERT NHẬT KÝ HỆ THỐNG
-- =============================================
INSERT INTO dbo.NhatKyHeThong (NhanVienID, ThoiGian, HanhDong, BangDuLieu, KhoaChinh, MoTa, TenDangNhap, HoVaTen, VaiTro) VALUES
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV001'), '2026-03-01 08:00:00', N'Đăng nhập', N'Hệ thống', N'', N'Admin đăng nhập', N'admin', N'Nguyễn Hoàng Uy', N'Quản trị viên'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV001'), '2026-03-01 08:05:00', N'Thêm', N'PhieuNhap', N'PN001', N'Lập phiếu nhập đợt 1', N'admin', N'Nguyễn Hoàng Uy', N'Quản trị viên'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), '2026-03-05 09:50:00', N'Đăng nhập', N'Hệ thống', N'', N'NV đăng nhập', N'nv01', N'Trần Minh Khoa', N'Nhân viên'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), '2026-03-05 10:00:00', N'Thêm', N'HoaDon', N'HD001', N'Lập hóa đơn HD001', N'nv01', N'Trần Minh Khoa', N'Nhân viên'),
((SELECT ID FROM dbo.NhanVien WHERE MaNhanVien=N'NV002'), '2026-03-06 09:00:00', N'Thêm', N'PhieuHoanTra', N'PHT001', N'Nhận hoàn trả HD001', N'nv01', N'Trần Minh Khoa', N'Nhân viên');
GO

-- 10. Kiểm tra dữ liệu
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
SELECT * FROM dbo.PhieuHoanTra;
SELECT * FROM dbo.PhieuHoanTra_ChiTiet;
SELECT * FROM dbo.NhatKyHeThong;
GO
