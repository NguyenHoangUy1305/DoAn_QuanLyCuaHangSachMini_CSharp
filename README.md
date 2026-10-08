# 📚 HỆ THỐNG QUẢN LÝ CỬA HÀNG SÁCH MINI (.NET 8 & EF CORE CODE-FIRST)

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0_LTS-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 8" />
  <img src="https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C# 12" />
  <img src="https://img.shields.io/badge/ORM-EF_Core_8.0-68217A?style=for-the-badge" alt="Entity Framework Core 8" />
  <img src="https://img.shields.io/badge/Database-SQL_Server-CC292B?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="SQL Server" />
  <img src="https://img.shields.io/badge/UI_Suite-Guna.UI2_%2F_Krypton-0078D7?style=for-the-badge" alt="Guna UI2" />
  <img src="https://img.shields.io/badge/Reporting-RDLC_ReportViewer-FF8C00?style=for-the-badge" alt="RDLC ReportViewer" />
  <img src="https://img.shields.io/badge/Excel-ClosedXML-217346?style=for-the-badge&logo=microsoftexcel&logoColor=white" alt="ClosedXML" />
  <img src="https://img.shields.io/badge/Security-BCrypt.Net--Next-darkgreen?style=for-the-badge" alt="BCrypt" />
</p>

---

## 📌 1. TỔNG QUAN ĐỀ TÀI
* **Môn học:** Lập Trình Quản Lý
* **Đơn vị đào tạo:** Khoa Công nghệ Thông tin – Trường Đại học An Giang (ĐHQG TP.HCM)
* **Sinh viên thực hiện:** **Nguyễn Hoàng Uy** (MSSV: `DTH235812`) – Lớp: DH24TH3

Hệ thống **Quản lý Cửa hàng Sách Mini** là phần mềm quản lý bán hàng (POS) và điều hành kho hàng toàn diện được xây dựng trên nền tảng **.NET 8 LTS** mới nhất. Phần mềm số hóa toàn bộ nghiệp vụ từ quản lý danh mục đầu sách, nhập hàng chuỗi cung ứng, bán lẻ tại quầy, xuất hóa đơn nhiệt qua **RDLC Reports**, xuất dữ liệu báo cáo ra **Excel (.xlsx)** bằng `ClosedXML`, đến nghiệp vụ **Quản lý Hoàn trả hàng (Refunds)** và hệ thống **Nhật ký kiểm toán (Audit Logging)**.

---

## 💡 2. CÔNG NGHỆ & ĐIỂM NHẤN KIẾN TRÚC HIỆN ĐẠI

1. **Nền tảng .NET 8 LTS & C# 12:** Sử dụng các tính năng ngôn ngữ mới nhất, tối ưu hóa hiệu năng thực thi ứng dụng Windows.
2. **Entity Framework Core 8 (Code-First với Migrations):**
   - Định nghĩa mô hình thực thể hoàn toàn bằng C# Code (`AppDbContext`).
   - Quản lý phiên bản cấu trúc CSDL bằng **EF Core Migrations** (`20260406080033_CSDLEnd.cs`, `AppDbContextModelSnapshot.cs`), cho phép đồng bộ CSDL tự động mà không cần viết script SQL thủ công.
3. **Bộ thư viện Giao diện Cao cấp (Modern UI Suite):**
   - Tích hợp **Guna.UI2.WinForms**, **Krypton.Toolkit**, **MaterialSkin.2**, **ReaLTaiizor**, **SunnyUI**. Giao diện phẳng hiện đại, bo góc mềm mại, hỗ trợ animation chuyển cảnh mượt mà.
4. **Báo cáo & In ấn chuyên nghiệp (RDLC Reports via ReportViewerCore):**
   - Tích hợp công nghệ `ReportViewerCore.WinForms` hỗ trợ trực tiếp trên .NET 8.
   - Thiết kế các mẫu báo cáo chuẩn in ấn: Hóa đơn bán lẻ, Phiếu nhập kho, Phiếu hoàn trả, Báo cáo doanh thu theo mốc thời gian và Thống kê tồn kho sách.
5. **Trích xuất dữ liệu Excel với ClosedXML:**
   - Cho phép xuất báo cáo doanh thu tài chính, chi tiết hóa đơn ra tệp `.xlsx` định dạng chuẩn.
6. **Bảo mật & Kiểm toán Hệ thống (Enterprise Security & Audit):**
   - Mật khẩu nhân viên và quản lý được băm bằng thuật toán **BCrypt** (`BCrypt.Net-Next`) kèm muối ngẫu nhiên (Salt), chống tấn công Rainbow Table.
   - Quản lý phiên đăng nhập với `SessionHelper`.
   - `NhatKyHelper` ghi nhận tự động toàn bộ thao tác Thêm, Sửa, Xóa dữ liệu vào bảng `NhatKyHeThong` để phục vụ đối soát.

---

## 🗄️ 3. THIẾT KẾ CƠ SỞ DỮ LIỆU & THỰC THỂ (ENTITIES)

Mô hình dữ liệu Code-First quản lý các thực thể quan hệ chặt chẽ:

* **`Sach`**: Mã sách, Tên sách, Tác giả, Năm xuất bản, Đơn giá nhập, Đơn giá bán, Số lượng tồn, Hình ảnh bìa, Mã thể loại (FK), Mã NXB (FK).
* **`TheLoai`**: Danh mục thể loại sách (Văn học, Kinh tế, CNTT, Tâm lý,...).
* **`NhaXuatBan`**: Thông tin đơn vị xuất bản (Kim Đồng, Trẻ, NXB Tổng Hợp,...).
* **`NhaCungCap`**: Đối tác cung ứng đầu sách, liên hệ, công nợ.
* **`KhachHang`**: Thông tin hội viên, tích điểm mua hàng, số điện thoại.
* **`NhanVien`**: Nhân viên bán hàng & Admin, phân quyền, mật khẩu băm BCrypt.
* **`HoaDon` & `HoaDonChiTiet`**: Giao dịch bán hàng tại quầy, chiết khấu, phương thức thanh toán, tự động trừ tồn kho.
* **`PhieuNhap` & `PhieuNhapChiTiet`**: Quản lý nhập hàng từ Nhà cung cấp, tính giá vốn và tự động cộng dồn tồn kho.
* **`PhieuHoanTra` & `PhieuHoanTraChiTiet`**: Nghiệp vụ xử lý khách đổi trả sách lỗi hoặc hoàn trả sách cho NCC, đối soát hoàn tiền và hoàn kho.
* **`NhatKyHeThong`**: Lưu trữ lịch sử thời gian, người dùng, hành động và nội dung can thiệp dữ liệu.

---

## 📂 4. QUÁ TRÌNH PHÁT TRIỂN QUA 10 GIAI ĐOẠN (MILESTONES)

Repository được tổ chức theo quy trình phát triển bài bản qua **10 giai đoạn**:

| Thư mục | Nội dung công việc & Kỹ thuật triển khai |
| :---: | :--- |
| 📁 **`GiaiDoan_01`** | Khảo sát nghiệp vụ, phân tích bài toán, thiết kế mô hình thực thể ERD & CSDL SQL Server |
| 📁 **`GiaiDoan_02`** | Khởi tạo Solution Visual Studio, thiết kế Dashboard Form Main, phân quyền hệ thống |
| 📁 **`GiaiDoan_03`** | Xây dựng phân hệ Quản lý Danh mục Sách (Thêm, Sửa, Xóa, Validation ràng buộc giá/kho) |
| 📁 **`GiaiDoan_04`** | Xây dựng phân hệ Quản lý Tác giả, Thể loại và Nhà xuất bản (Khóa ngoại toàn vẹn) |
| 📁 **`GiaiDoan_05`** | Quản lý Khách hàng & Nhân viên, mã hóa mật khẩu và phân quyền Admin / Thu ngân |
| 📁 **`GiaiDoan_06`** | Phân hệ Bán hàng POS & Lập Hóa đơn (Tính toán tiền, chiết khấu, trừ tồn kho tự động) |
| 📁 **`GiaiDoan_07`** | Phân hệ Quản lý Nhập kho & Phiếu nhập hàng (Cập nhật số lượng tồn kho tự động) |
| 📁 **`GiaiDoan_08`** | Chức năng Tìm kiếm nâng cao, Lọc sách theo giá/thể loại & Phân trang dữ liệu |
| 📁 **`GiaiDoan_09`** | Tích hợp hệ thống Báo cáo Thống kê doanh thu (ReportViewer .rdlc, Xuất phiếu hóa đơn) |
| 📁 **`GiaiDoan_10`** | **Bản phát hành hoàn thiện (Final Release):** Hoàn thiện phân hệ Hoàn trả hàng (Refund), xuất Excel ClosedXML, tối ưu hóa giao diện Guna UI2 và kiểm thử |

---

## 📂 5. CẤU TRÚC CODE DỰ ÁN BẢN HOÀN THIỆN (`GiaiDoan_10`)

```text
QuanLyCuaHangSachMini/
├── QuanLyCuaHangSachMini.slnx                # Solution file
└── QuanLyCuaHangSachMini/
    ├── QuanLyCuaHangSachMini.csproj          # Cấu hình .NET 8 và các gói NuGet
    ├── Program.cs                            # Điểm khởi chạy ứng dụng
    ├── Migrations/                           # Các file EF Core Code-First Migrations
    │   ├── 20260406080033_CSDLEnd.cs
    │   └── AppDbContextModelSnapshot.cs
    ├── Helper/                               # Các lớp tiện ích bảo mật & hệ thống
    │   ├── PasswordHelper.cs                 # Mã hóa băm & xác thực mật khẩu BCrypt
    │   ├── SessionHelper.cs                  # Quản lý phiên đăng nhập hiện tại
    │   └── NhatKyHelper.cs                   # Ghi log kiểm toán hệ thống tự động
    ├── Forms/
    │   ├── frmMain.cs                        # Form chính điều hướng Dashboard
    │   ├── frmDangNhap.cs                    # Form đăng nhập bảo mật
    │   ├── frmSach.cs                        # Form quản lý kho sách & ảnh bìa
    │   ├── frmTheLoai.cs                     # Form quản lý danh mục thể loại
    │   ├── frmNhaXuatBan.cs                  # Form quản lý nhà xuất bản
    │   ├── frmNhaCungCap.cs                  # Form quản lý đối tác cung ứng
    │   ├── frmKhachHang.cs                   # Form quản lý thông tin khách hàng
    │   ├── frmNhanVien.cs                    # Form quản lý tài khoản & nhân sự
    │   ├── frmHoaDon.cs & frmHoaDonChiTiet.cs# Form bán hàng POS & chi tiết hóa đơn
    │   ├── frmPhieuNhap.cs                   # Form nhập hàng từ nhà cung cấp
    │   ├── frmPhieuHoanTra.cs                # Form xử lý nghiệp vụ hoàn trả sách
    │   └── frmNhatKyHeThong.cs               # Form tra cứu lịch sử thao tác hệ thống
    └── Reports/                              # Mẫu báo cáo RDLC & Typed DataSet
        ├── QLSach.xsd                        # Schema Typed DataSet
        ├── rptInHoaDon.rdlc                  # Mẫu in hóa đơn thanh toán
        ├── rptInPhieuNhap.rdlc               # Mẫu in phiếu nhập hàng
        ├── rptInPhieuHoanTra.rdlc            # Mẫu in phiếu hoàn trả
        ├── rptThongKeDoanhThu.rdlc           # Mẫu báo cáo doanh thu tài chính
        └── rptThongKeSach.rdlc               # Mẫu báo cáo thống kê kho sách
```

---

## 🚀 6. HƯỚNG DẪN CÀI ĐẶT & CHẠY LOCAL

### Yêu cầu hệ thống:
* **Hệ điều hành:** Windows 10 / 11.
* **Môi trường phát triển:** Visual Studio 2022 (phiên bản 17.8 trở lên hỗ trợ .NET 8 SDK).
* **Cơ sở dữ liệu:** Microsoft SQL Server (LocalDB, Express hoặc Enterprise).

### Các bước cài đặt:
1. **Clone repository:**
   ```bash
   git clone https://github.com/NguyenHoangUy1305/DoAn_QuanLyCuaHangSachMini_CSharp.git
   ```
2. **Khởi chạy bản hoàn thiện:**
   - Điều hướng vào thư mục: `GiaiDoan_10/QuanLyCuaHangSachMini`.
   - Mở file giải pháp `QuanLyCuaHangSachMini.slnx` bằng Visual Studio 2022.
3. **Cập nhật Database qua EF Core Migrations:**
   - Mở **Package Manager Console** trong Visual Studio và chạy lệnh:
     ```powershell
     Update-Database
     ```
     *(EF Core sẽ tự động khởi tạo CSDL SQL Server và thiết lập toàn bộ quan hệ bảng)*.
4. **Khởi chạy ứng dụng:**
   - Bấm **F5** để build và chạy chương trình.
   - Tài khoản đăng nhập mặc định: `admin` / Mật khẩu: `admin123` (hoặc tạo tài khoản nhân viên mới).

---

## 👨‍💻 7. TÁC GIẢ DỰ ÁN
* **Nguyễn Hoàng Uy** – *Full-stack .NET 8, EF Core & UI Architecture* – [`NguyenHoangUy1305`](https://github.com/NguyenHoangUy1305)

*Khoa Công nghệ Thông tin – Trường Đại học An Giang (ĐHQG TP.HCM)*
