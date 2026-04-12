# 📚 ĐỒ ÁN MÔN HỌC: HỆ THỐNG QUẢN LÝ CỬA HÀNG SÁCH MINI
> **Sinh viên thực hiện:** Nguyễn Hoàng Uy  
> **Ngôn ngữ & Nền tảng:** C#, .NET Framework, Windows Forms (WinForms), SQL Server, Entity Framework / ADO.NET  
> **Môn học:** Lập Trình Quản Lý - Đại Học An Giang  

---

## 📌 GIỚI THIỆU ĐỒ ÁN
Đồ án xây dựng phần mềm quản lý bán hàng hoàn chỉnh cho **Cửa Hàng Sách Mini**, bao gồm đầy đủ các phân hệ nghiệp vụ: quản lý danh mục đầu sách, tác giả, nhà xuất bản, thể loại, quản lý kho hàng nhập/xuất, bán lẻ tại quầy, xuất hóa đơn in nhiệt và báo cáo doanh thu theo kỳ.

Toàn bộ đồ án được phát triển bài bản qua **10 giai đoạn (Milestones)** từ thiết kế cơ sở dữ liệu đến đóng gói phần mềm.

---

## 📂 QUÁ TRÌNH PHÁT TRIỂN QUA 10 GIAI ĐOẠN

| Thư mục giai đoạn | Nội dung công việc & Kỹ thuật triển khai |
| :---: | :--- |
| 📁 **[GiaiDoan_01](./GiaiDoan_01)** | Khảo sát bài toán nghiệp vụ, thiết kế mô hình thực thể ERD & CSDL SQL Server |
| 📁 **[GiaiDoan_02](./GiaiDoan_02)** | Tạo cấu trúc Solution Visual Studio, thiết kế giao diện Form Main (Dashboard) |
| 📁 **[GiaiDoan_03](./GiaiDoan_03)** | Xây dựng phân hệ Quản lý Danh mục Sách (Thêm, Sửa, Xóa, Validation giá/tồn kho) |
| 📁 **[GiaiDoan_04](./GiaiDoan_04)** | Phân hệ Quản lý Tác giả, Thể loại và Nhà xuất bản (Ràng buộc khóa ngoại) |
| 📁 **[GiaiDoan_05](./GiaiDoan_05)** | Quản lý Khách hàng & Nhân viên (Phân quyền Admin / Thu ngân) |
| 📁 **[GiaiDoan_06](./GiaiDoan_06)** | Phân hệ Bán hàng & Lập Hóa đơn (Tính toán tiền, chiết khấu, tự động trừ kho) |
| 📁 **[GiaiDoan_07](./GiaiDoan_07)** | Phân hệ Quản lý Nhập hàng & Phiếu nhập (Cập nhật số lượng tồn kho tự động) |
| 📁 **[GiaiDoan_08](./GiaiDoan_08)** | Chức năng Tìm kiếm nâng cao, Lọc sách theo giá/thể loại & Phân trang dữ liệu |
| 📁 **[GiaiDoan_09](./GiaiDoan_09)** | Báo cáo & Thống kê doanh thu (ReportViewer .rdlc, Xuất phiếu in hóa đơn) |
| 📁 **[GiaiDoan_10](./GiaiDoan_10)** | **Bản phát hành hoàn thiện (Final Release):** Tối ưu hóa UI/UX, kiểm thử bảo mật & đóng gói |

---

## 🛠️ HƯỚNG DẪN CÀI ĐẶT & CHẠY PHẦN MỀM
1. Mở file giải pháp .sln bằng **Visual Studio 2019 / 2022**.
2. Mở file script CSDL .sql trong thư mục giai đoạn cuối bằng **SQL Server Management Studio (SSMS)** và bấm Execute.
3. Kiểm tra lại chuỗi kết nối connectionString trong file App.config để đảm bảo kết nối đúng máy chủ SQL Server của bạn.
4. Bấm F5 để khởi chạy phần mềm.\n