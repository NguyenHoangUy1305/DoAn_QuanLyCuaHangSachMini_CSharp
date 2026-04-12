using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.DTOs;
using QuanLyCuaHangSachMini.Helpers;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private int id;
        private bool chiXem = false;
        private int nhanVienDangNhapID = 0;
        private string quyenHanNguoiDung = "";
        private BindingList<DanhSachHoaDonChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>();

        public frmHoaDon_ChiTiet(int maHoaDon = 0, bool chiXemChiTiet = false, int nhanVienID = 0, string quyenHan = "")
        {
            InitializeComponent();
            id = maHoaDon;
            chiXem = chiXemChiTiet;
            nhanVienDangNhapID = nhanVienID;
            quyenHanNguoiDung = quyenHan ?? "";
            txtSdtTraCuu.KeyPress += txtSdtTraCuu_KeyPress;
            txtSdtTraCuu.KeyDown += txtSdtTraCuu_KeyDown;
            txtSdtTraCuu.TextChanged += txtSdtTraCuu_TextChanged;
        }

        public void LayNhanVienVaoComboBox()
        {
            if (quyenHanNguoiDung == "nhanvien")
            {
                cboNhanVien.DataSource = context.NhanVien
                    .Where(r => r.ID == nhanVienDangNhapID)
                    .ToList();
            }
            else
            {
                cboNhanVien.DataSource = context.NhanVien.ToList();
            }

            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }

        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang
                .OrderBy(r => r.HoVaTen)
                .ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDown;
            cboKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboKhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private string PhatSinhMaKhachHang()
        {
            int soLonNhat = 0;
            if (context.KhachHang.Any())
            {
                soLonNhat = context.KhachHang
                    .AsEnumerable()
                    .Select(r =>
                    {
                        if (string.IsNullOrWhiteSpace(r.MaKhachHang))
                            return 0;

                        string so = new string(r.MaKhachHang.Where(char.IsDigit).ToArray());
                        return int.TryParse(so, out int kq) ? kq : 0;
                    })
                    .DefaultIfEmpty(0)
                    .Max();
            }

            return "KH" + (soLonNhat + 1).ToString("000");
        }

        private static string ChuanHoaTenKhach(string? ten)
        {
            if (string.IsNullOrWhiteSpace(ten))
                return string.Empty;

            return string.Join(" ",
                ten.Trim()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries))
                .ToLowerInvariant();
        }

        private int DamBaoKhachHangTonTaiTrongHeThong()
        {
            string tenKhach = cboKhachHang.Text?.Trim() ?? string.Empty;
            string sdtTraCuu = txtSdtTraCuu.Text?.Trim() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(sdtTraCuu))
            {
                KhachHang? khTheoSdt = context.KhachHang
                    .FirstOrDefault(r => (r.DienThoai ?? "") == sdtTraCuu);
                if (khTheoSdt != null)
                {
                    cboKhachHang.SelectedValue = khTheoSdt.ID;
                    return khTheoSdt.ID;
                }
            }

            if (string.IsNullOrWhiteSpace(tenKhach))
                return 0;

            int idDangChon = 0;
            if (cboKhachHang.SelectedValue != null)
            {
                int.TryParse(cboKhachHang.SelectedValue.ToString(), out idDangChon);
            }

            if (idDangChon > 0)
            {
                KhachHang? khTheoId = context.KhachHang.Find(idDangChon);
                if (khTheoId != null &&
                    string.Equals(khTheoId.HoVaTen?.Trim(), tenKhach, StringComparison.CurrentCultureIgnoreCase))
                {
                    return khTheoId.ID;
                }
            }

            string tenChuanHoa = ChuanHoaTenKhach(tenKhach);
            KhachHang? khTonTai = context.KhachHang
                .AsEnumerable()
                .FirstOrDefault(r => ChuanHoaTenKhach(r.HoVaTen) == tenChuanHoa);
            if (khTonTai != null)
            {
                cboKhachHang.SelectedValue = khTonTai.ID;
                return khTonTai.ID;
            }

            KhachHang khMoi = new KhachHang
            {
                MaKhachHang = PhatSinhMaKhachHang(),
                HoVaTen = tenKhach,
                DienThoai = string.IsNullOrWhiteSpace(sdtTraCuu) ? null : sdtTraCuu,
                Email = null,
                DiaChi = null
            };

            context.KhachHang.Add(khMoi);
            context.SaveChanges();

            LayKhachHangVaoComboBox();
            cboKhachHang.SelectedValue = khMoi.ID;
            return khMoi.ID;
        }

        private void txtSdtTraCuu_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtSdtTraCuu_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TimKhachHangTheoSoDienThoai(true);
            }
        }

        private void cboKhachHang_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null || !int.TryParse(cboKhachHang.SelectedValue.ToString(), out int khachHangId))
                return;

            KhachHang? kh = context.KhachHang.Find(khachHangId);
            if (kh != null)
                txtSdtTraCuu.Text = kh.DienThoai ?? string.Empty;
        }
        private void TimKhachHangTheoSoDienThoai(bool hienThongBaoKhiKhongThay)
        {
            string sdt = txtSdtTraCuu.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdt))
            {
                if (hienThongBaoKhiKhongThay)
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại để tra cứu.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cboKhachHang.SelectedIndex = -1;
                }
                return;
            }

            bool hopLe10So = sdt.Length == 10 && sdt.All(char.IsDigit);
            if (!hopLe10So)
            {
                if (hienThongBaoKhiKhongThay)
                {
                    MessageBox.Show("Số điện thoại phải đúng 10 số.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSdtTraCuu.Focus();
                }
                return;
            }

            KhachHang? kh = context.KhachHang.FirstOrDefault(r => (r.DienThoai ?? "") == sdt);
            if (kh == null)
            {
                if (hienThongBaoKhiKhongThay)
                {
                    MessageBox.Show("Chưa có khách hàng với số điện thoại này.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cboKhachHang.SelectedIndex = -1;
                }
                return;
            }

            cboKhachHang.SelectedValue = kh.ID;
        }
private void btnTimKhachTheoSdt_Click(object sender, EventArgs e)
        {
            TimKhachHangTheoSoDienThoai(true);
        }

        private void btnLapKhachHangMoi_Click(object sender, EventArgs e)
        {
            if (chiXem || quyenHanNguoiDung == "admin")
                return;

            using Form frmTaoKhach = new Form
            {
                Text = "Lập khách hàng mới",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = new Size(460, 290),
                Font = new Font("Segoe UI", 10F)
            };

            Label lblHoTen = new Label { Text = "Họ và tên (*):", Left = 20, Top = 24, Width = 120 };
            TextBox txtHoTen = new TextBox { Left = 145, Top = 20, Width = 285 };

            Label lblDienThoai = new Label { Text = "Điện thoại (*):", Left = 20, Top = 64, Width = 120 };
            TextBox txtDienThoai = new TextBox { Left = 145, Top = 60, Width = 285, MaxLength = 10 };
            txtDienThoai.KeyPress += (_, keyPress) =>
            {
                if (!char.IsControl(keyPress.KeyChar) && !char.IsDigit(keyPress.KeyChar))
                    keyPress.Handled = true;
            };

            Label lblEmail = new Label { Text = "Email:", Left = 20, Top = 104, Width = 120 };
            TextBox txtEmail = new TextBox { Left = 145, Top = 100, Width = 285 };

            Label lblDiaChi = new Label { Text = "Địa chỉ:", Left = 20, Top = 144, Width = 120 };
            TextBox txtDiaChi = new TextBox { Left = 145, Top = 140, Width = 285 };

            Button btnLuuKhach = new Button
            {
                Text = "Lưu",
                Left = 245,
                Top = 210,
                Width = 88,
                BackColor = Color.FromArgb(71, 51, 255),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnLuuKhach.FlatAppearance.BorderSize = 0;

            Button btnHuy = new Button
            {
                Text = "Hủy",
                Left = 342,
                Top = 210,
                Width = 88,
                FlatStyle = FlatStyle.Flat
            };

            frmTaoKhach.Controls.AddRange(new Control[]
            {
                lblHoTen, txtHoTen,
                lblDienThoai, txtDienThoai,
                lblEmail, txtEmail,
                lblDiaChi, txtDiaChi,
                btnLuuKhach, btnHuy
            });

            bool daLuu = false;
            int khachHangMoiId = 0;

            btnLuuKhach.Click += (_, _) =>
            {
                string hoTen = txtHoTen.Text.Trim();
                string dienThoai = txtDienThoai.Text.Trim();
                string email = txtEmail.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();

                if (string.IsNullOrWhiteSpace(hoTen))
                {
                    MessageBox.Show("Vui lòng nhập họ và tên khách hàng.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHoTen.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(dienThoai))
                {
                    MessageBox.Show("Vui lòng nhập điện thoại khách hàng.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDienThoai.Focus();
                    return;
                }

                if (dienThoai.Length != 10 || !dienThoai.All(char.IsDigit))
                {
                    MessageBox.Show("Điện thoại phải đúng 10 số.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDienThoai.Focus();
                    return;
                }

                if (!string.IsNullOrWhiteSpace(email) && !email.Contains("@"))
                {
                    MessageBox.Show("Email không hợp lệ.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }

                KhachHang? khTonTai = null;

                if (!string.IsNullOrWhiteSpace(dienThoai))
                {
                    khTonTai = context.KhachHang
                        .FirstOrDefault(r => (r.DienThoai ?? "") == dienThoai);
                }

                if (khTonTai == null)
                {
                    string hoTenChuan = ChuanHoaTenKhach(hoTen);
                    khTonTai = context.KhachHang
                        .AsEnumerable()
                        .FirstOrDefault(r => ChuanHoaTenKhach(r.HoVaTen) == hoTenChuan);
                }

                if (khTonTai != null)
                {
                    if (string.IsNullOrWhiteSpace(khTonTai.DienThoai) && !string.IsNullOrWhiteSpace(dienThoai))
                        khTonTai.DienThoai = dienThoai;
                    if (string.IsNullOrWhiteSpace(khTonTai.Email) && !string.IsNullOrWhiteSpace(email))
                        khTonTai.Email = email;
                    if (string.IsNullOrWhiteSpace(khTonTai.DiaChi) && !string.IsNullOrWhiteSpace(diaChi))
                        khTonTai.DiaChi = diaChi;

                    context.SaveChanges();

                    khachHangMoiId = khTonTai.ID;
                    daLuu = true;
                    frmTaoKhach.DialogResult = DialogResult.OK;
                    frmTaoKhach.Close();
                    return;
                }

                KhachHang khMoi = new KhachHang
                {
                    MaKhachHang = PhatSinhMaKhachHang(),
                    HoVaTen = hoTen,
                    DienThoai = dienThoai,
                    Email = string.IsNullOrWhiteSpace(email) ? null : email,
                    DiaChi = string.IsNullOrWhiteSpace(diaChi) ? null : diaChi
                };

                context.KhachHang.Add(khMoi);
                context.SaveChanges();

                khachHangMoiId = khMoi.ID;
                daLuu = true;
                frmTaoKhach.DialogResult = DialogResult.OK;
                frmTaoKhach.Close();
            };

            btnHuy.Click += (_, _) =>
            {
                frmTaoKhach.DialogResult = DialogResult.Cancel;
                frmTaoKhach.Close();
            };

            frmTaoKhach.AcceptButton = btnLuuKhach;
            frmTaoKhach.CancelButton = btnHuy;

            if (frmTaoKhach.ShowDialog(this) == DialogResult.OK && daLuu && khachHangMoiId > 0)
            {
                LayKhachHangVaoComboBox();
                cboKhachHang.SelectedValue = khachHangMoiId;
                KhachHang? khMoi = context.KhachHang.Find(khachHangMoiId);
                txtSdtTraCuu.Text = khMoi?.DienThoai ?? string.Empty;
            }
        }

        public void LaySachVaoComboBox()
        {
            cboSach.DataSource = context.Sach.OrderBy(r => r.TenSach).ToList();
            cboSach.ValueMember = "ID";
            cboSach.DisplayMember = "TenSach";
        }

        public void BatTatChucNang(bool giaTri)
        {
            cboNhanVien.Enabled = giaTri;
            cboKhachHang.Enabled = giaTri;
            txtSdtTraCuu.Enabled = giaTri;
            btnTimKhachTheoSdt.Enabled = giaTri;
            btnLapKhachHangMoi.Enabled = giaTri;
            txtGhiChuHoaDon.Enabled = giaTri;

            cboSach.Enabled = giaTri;
            numSoLuongBan.Enabled = giaTri;
            numDonGiaBan.Enabled = giaTri;

            btnXacNhanBan.Enabled = giaTri;
            btnXoa.Enabled = giaTri;
            btnLuuHoaDon.Enabled = giaTri;

            if (quyenHanNguoiDung == "nhanvien")
                cboNhanVien.Enabled = false;

            if (chiXem)
            {
                cboNhanVien.Enabled = false;
                cboKhachHang.Enabled = false;
                txtSdtTraCuu.Enabled = false;
                btnTimKhachTheoSdt.Enabled = false;
                btnLapKhachHangMoi.Enabled = false;
                txtGhiChuHoaDon.Enabled = false;
                cboSach.Enabled = false;
                numSoLuongBan.Enabled = false;
                numDonGiaBan.Enabled = false;
                btnXacNhanBan.Enabled = false;
                btnXoa.Enabled = false;
                btnLuuHoaDon.Enabled = false;
            }
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LaySachVaoComboBox();
            cboKhachHang.SelectionChangeCommitted += cboKhachHang_SelectionChangeCommitted;

            btnTimKhachTheoSdt.Visible = false;
            btnTimKhachTheoSdt.Enabled = false;

            dataGridView.AutoGenerateColumns = false;
            dataGridView.CellClick -= dataGridView_CellClick;
            dataGridView.SelectionChanged -= dataGridView_SelectionChanged;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;

            numSoLuongBan.Minimum = 1;
            numSoLuongBan.Maximum = 100000;
            numSoLuongBan.ThousandsSeparator = true;

            numDonGiaBan.Minimum = 1;
            numDonGiaBan.Maximum = 1000000000;
            numDonGiaBan.ThousandsSeparator = true;

            if (id == 0)
            {
                if (quyenHanNguoiDung == "admin")
                {
                    MessageBox.Show("Quản trị viên chỉ được xem hóa đơn, không được lập hóa đơn bán.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }

                BatTatChucNang(true);

                if (quyenHanNguoiDung == "nhanvien")
                {
                    cboNhanVien.SelectedValue = nhanVienDangNhapID;
                    cboNhanVien.Enabled = false;
                }
                else
                {
                    cboNhanVien.SelectedIndex = -1;
                }

                cboKhachHang.SelectedIndex = -1;
                txtSdtTraCuu.Clear();
                if (cboSach.Items.Count > 0)
                    cboSach.SelectedIndex = 0;

                txtGhiChuHoaDon.Clear();
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 1;
                hoaDonChiTiet.Clear();
                TaiLaiLuoiChiTiet();
            }
            else
            {
                HoaDon? hoaDon = context.HoaDon.SingleOrDefault(r => r.ID == id);
                if (hoaDon != null)
                {
                    if (quyenHanNguoiDung == "nhanvien" && hoaDon.NhanVienID != nhanVienDangNhapID)
                    {
                        MessageBox.Show("Bạn chỉ được xem hoặc sửa hóa đơn do chính bạn lập.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        return;
                    }

                    cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                    cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                    KhachHang? kh = context.KhachHang.Find(hoaDon.KhachHangID);
                    txtSdtTraCuu.Text = kh?.DienThoai ?? string.Empty;
                    txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;

                    List<DanhSachHoaDonChiTiet> ct = context.HoaDon_ChiTiet
                        .Where(r => r.HoaDonID == id)
                        .Select(r => new DanhSachHoaDonChiTiet
                        {
                            ID = r.ID,
                            HoaDonID = r.HoaDonID,
                            SachID = r.SachID,
                            MaSach = r.Sach.MaSach,
                            TenSach = r.Sach.TenSach,
                            SoLuongBan = r.SoLuongBan,
                            DonGiaBan = r.DonGiaBan,
                            ThanhTien = r.SoLuongBan * r.DonGiaBan
                        })
                        .ToList();

                    hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>(ct);
                    TaiLaiLuoiChiTiet();
                }

                if (chiXem || quyenHanNguoiDung == "admin")
                    BatTatChucNang(false);
                else
                    BatTatChucNang(true);
            }
        }

        private void TaiLaiLuoiChiTiet(int? sachIDCanChon = null)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = hoaDonChiTiet.ToList();

            if (dataGridView.Rows.Count > 0)
            {
                int rowIndex = 0;

                if (sachIDCanChon.HasValue)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells["SachID"].Value != null &&
                            Convert.ToInt32(row.Cells["SachID"].Value) == sachIDCanChon.Value)
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                }

                dataGridView.ClearSelection();
                dataGridView.Rows[rowIndex].Selected = true;

                if (dataGridView.Columns["TenSach"] != null && dataGridView.Columns["TenSach"].Visible)
                    dataGridView.CurrentCell = dataGridView.Rows[rowIndex].Cells["TenSach"];

                HienThiThongTinSachBan();
            }
            else
            {
                XoaTrangThongTinSachBan();
            }

            btnLuuHoaDon.Enabled = hoaDonChiTiet.Count > 0 && !chiXem && quyenHanNguoiDung != "admin";
            btnXoa.Enabled = hoaDonChiTiet.Count > 0 && !chiXem && quyenHanNguoiDung != "admin";
        }

        private void HienThiThongTinSachBan()
        {
            if (dataGridView.CurrentRow == null || dataGridView.Rows.Count == 0)
            {
                XoaTrangThongTinSachBan();
                return;
            }

            if (dataGridView.CurrentRow.Cells["SachID"].Value == null)
            {
                XoaTrangThongTinSachBan();
                return;
            }

            int sachID = Convert.ToInt32(dataGridView.CurrentRow.Cells["SachID"].Value.ToString());
            DanhSachHoaDonChiTiet? chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SachID == sachID);

            if (chiTiet != null)
            {
                cboSach.SelectedValue = chiTiet.SachID;

                decimal soLuong = chiTiet.SoLuongBan;
                if (soLuong < numSoLuongBan.Minimum) soLuong = numSoLuongBan.Minimum;
                if (soLuong > numSoLuongBan.Maximum) soLuong = numSoLuongBan.Maximum;
                numSoLuongBan.Value = soLuong;

                decimal donGia = chiTiet.DonGiaBan;
                if (donGia < numDonGiaBan.Minimum) donGia = numDonGiaBan.Minimum;
                if (donGia > numDonGiaBan.Maximum) donGia = numDonGiaBan.Maximum;
                numDonGiaBan.Value = donGia;
            }
        }

        private void XoaTrangThongTinSachBan()
        {
            if (cboSach.Items.Count > 0 && !chiXem)
                cboSach.SelectedIndex = 0;
            else if (cboSach.Items.Count > 0)
                cboSach.SelectedIndex = -1;

            numSoLuongBan.Value = numSoLuongBan.Minimum;
            numDonGiaBan.Value = numDonGiaBan.Minimum;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                HienThiThongTinSachBan();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && dataGridView.CurrentRow != null)
                HienThiThongTinSachBan();
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (chiXem || quyenHanNguoiDung == "admin")
                return;

            if (string.IsNullOrWhiteSpace(cboSach.Text))
            {
                MessageBox.Show("Vui lòng chọn sách.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numSoLuongBan.Value <= 0)
            {
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numDonGiaBan.Value <= 0)
            {
                MessageBox.Show("Đơn giá bán phải lớn hơn 0.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maSach = Convert.ToInt32(cboSach.SelectedValue.ToString());
            DanhSachHoaDonChiTiet? chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SachID == maSach);

            if (chiTiet != null)
            {
                chiTiet.SoLuongBan = Convert.ToInt32(numSoLuongBan.Value);
                chiTiet.DonGiaBan = numDonGiaBan.Value;
                chiTiet.ThanhTien = numSoLuongBan.Value * numDonGiaBan.Value;
            }
            else
            {
                Sach? sach = context.Sach.Find(maSach);

                DanhSachHoaDonChiTiet ct = new DanhSachHoaDonChiTiet
                {
                    ID = 0,
                    HoaDonID = id,
                    SachID = maSach,
                    MaSach = sach != null ? sach.MaSach : string.Empty,
                    TenSach = cboSach.Text,
                    SoLuongBan = Convert.ToInt32(numSoLuongBan.Value),
                    DonGiaBan = numDonGiaBan.Value,
                    ThanhTien = numSoLuongBan.Value * numDonGiaBan.Value
                };

                hoaDonChiTiet.Add(ct);
            }

            TaiLaiLuoiChiTiet(maSach);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (chiXem || quyenHanNguoiDung == "admin")
                return;

            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng chi tiết cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView.CurrentRow.Cells["SachID"].Value == null)
                return;

            int maSach = Convert.ToInt32(dataGridView.CurrentRow.Cells["SachID"].Value.ToString());
            DanhSachHoaDonChiTiet? chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SachID == maSach);

            if (chiTiet != null)
                hoaDonChiTiet.Remove(chiTiet);

            TaiLaiLuoiChiTiet();
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (quyenHanNguoiDung == "admin")
            {
                MessageBox.Show("Quản trị viên chỉ được xem hóa đơn, không được lập hóa đơn bán.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nhanVienDangNhapID <= 0)
            {
                MessageBox.Show("Không xác định được nhân viên đang đăng nhập.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hoaDonChiTiet.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có chi tiết bán.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var transaction = context.Database.BeginTransaction();
            try
            {
                int khachHangID = DamBaoKhachHangTonTaiTrongHeThong();
                if (khachHangID <= 0)
                {
                    MessageBox.Show("Không xác định được khách hàng.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                    return;
                }

                List<DanhSachHoaDonChiTiet> danhSachMoi = hoaDonChiTiet.ToList();
                bool dangSua = id != 0;
                string maHoaDonLog = "";
                int hoaDonIDLog = 0;

                if (id != 0)
                {
                    HoaDon? hd = context.HoaDon.Find(id);
                    if (hd == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn cần cập nhật.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                        return;
                    }

                    if (hd.NhanVienID != nhanVienDangNhapID)
                    {
                        MessageBox.Show("Bạn chỉ được sửa hóa đơn do chính bạn lập.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                        return;
                    }

                    List<HoaDon_ChiTiet> old = context.HoaDon_ChiTiet
                        .Where(r => r.HoaDonID == id)
                        .ToList();

                    Dictionary<int, int> soLuongCuTheoSach = old
                        .GroupBy(r => r.SachID)
                        .ToDictionary(g => g.Key, g => g.Sum(x => x.SoLuongBan));

                    foreach (DanhSachHoaDonChiTiet item in danhSachMoi)
                    {
                        Sach? sach = context.Sach.Find(item.SachID);
                        if (sach == null)
                        {
                            MessageBox.Show("Có sách không tồn tại trong hệ thống.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }

                        int soLuongCu = soLuongCuTheoSach.ContainsKey(item.SachID) ? soLuongCuTheoSach[item.SachID] : 0;
                        int soLuongTonKhaDung = sach.SoLuongTon + soLuongCu;

                        if (soLuongTonKhaDung < item.SoLuongBan)
                        {
                            MessageBox.Show(
                                $"Sách \"{sach.TenSach}\" không đủ số lượng tồn.\nChỉ còn {soLuongTonKhaDung} quyển khả dụng.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }
                    }

                    hd.NhanVienID = nhanVienDangNhapID;
                    hd.KhachHangID = khachHangID;
                    hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                    context.HoaDon.Update(hd);

                    foreach (HoaDon_ChiTiet oldItem in old)
                    {
                        Sach? sach = context.Sach.Find(oldItem.SachID);
                        if (sach != null)
                        {
                            sach.SoLuongTon += oldItem.SoLuongBan;
                            sach.TrangThai = sach.SoLuongTon > 0 ? "Còn hàng" : "Hết hàng";
                        }
                    }

                    context.HoaDon_ChiTiet.RemoveRange(old);

                    foreach (DanhSachHoaDonChiTiet item in danhSachMoi)
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                        {
                            HoaDonID = id,
                            SachID = item.SachID,
                            SoLuongBan = item.SoLuongBan,
                            DonGiaBan = item.DonGiaBan
                        };
                        context.HoaDon_ChiTiet.Add(ct);

                        Sach? sach = context.Sach.Find(item.SachID);
                        if (sach != null)
                        {
                            sach.SoLuongTon -= item.SoLuongBan;
                            if (sach.SoLuongTon < 0)
                                sach.SoLuongTon = 0;

                            sach.TrangThai = sach.SoLuongTon > 0 ? "Còn hàng" : "Hết hàng";
                        }
                    }

                    context.SaveChanges();
                    maHoaDonLog = hd.MaHoaDon;
                    hoaDonIDLog = hd.ID;
                }
                else
                {
                    foreach (DanhSachHoaDonChiTiet item in danhSachMoi)
                    {
                        Sach? sach = context.Sach.Find(item.SachID);
                        if (sach == null)
                        {
                            MessageBox.Show("Có sách không tồn tại trong hệ thống.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }

                        if (sach.SoLuongTon < item.SoLuongBan)
                        {
                            MessageBox.Show(
                                $"Sách \"{sach.TenSach}\" không đủ số lượng tồn.\nChỉ còn {sach.SoLuongTon} quyển.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }
                    }

                    HoaDon hd = new HoaDon
                    {
                        MaHoaDon = PhatSinhMaHoaDon(),
                        NhanVienID = nhanVienDangNhapID,
                        KhachHangID = khachHangID,
                        NgayLap = DateTime.Now,
                        GhiChuHoaDon = txtGhiChuHoaDon.Text
                    };

                    context.HoaDon.Add(hd);
                    context.SaveChanges();

                    foreach (DanhSachHoaDonChiTiet item in danhSachMoi)
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                        {
                            HoaDonID = hd.ID,
                            SachID = item.SachID,
                            SoLuongBan = item.SoLuongBan,
                            DonGiaBan = item.DonGiaBan
                        };
                        context.HoaDon_ChiTiet.Add(ct);

                        Sach? sach = context.Sach.Find(item.SachID);
                        if (sach != null)
                        {
                            sach.SoLuongTon -= item.SoLuongBan;
                            if (sach.SoLuongTon < 0)
                                sach.SoLuongTon = 0;

                            sach.TrangThai = sach.SoLuongTon > 0 ? "Còn hàng" : "Hết hàng";
                        }
                    }

                    context.SaveChanges();
                    id = hd.ID;

                    maHoaDonLog = hd.MaHoaDon;
                    hoaDonIDLog = hd.ID;
                }

                transaction.Commit();

                NhatKyHelper.GhiLog(
                    dangSua ? "Sửa" : "Thêm",
                    "HoaDon",
                    hoaDonIDLog.ToString(),
                    (dangSua ? "Cập nhật hóa đơn: " : "Lập hóa đơn: ") + maHoaDonLog
                );

                MessageBox.Show("Đã lưu thành công!", "Hoàn tất",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                string loi = ex.Message;
                if (ex.InnerException != null)
                    loi += "\n\n" + ex.InnerException.Message;
                if (ex.InnerException != null && ex.InnerException.InnerException != null)
                    loi += "\n\n" + ex.InnerException.InnerException.Message;

                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string PhatSinhMaHoaDon()
        {
            int soThuTu = 1;

            string? maCuoi = context.HoaDon
                .OrderByDescending(r => r.ID)
                .Select(r => r.MaHoaDon)
                .FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(maCuoi) &&
                maCuoi.StartsWith("HD") &&
                int.TryParse(maCuoi.Substring(2), out int so))
            {
                soThuTu = so + 1;
            }
            else if (context.HoaDon.Any())
            {
                soThuTu = context.HoaDon.Max(r => r.ID) + 1;
            }

            return "HD" + soThuTu.ToString("D3");
        }

        private void cboSach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSach.SelectedValue == null)
                return;

            int maSach = Convert.ToInt32(cboSach.SelectedValue.ToString());
            Sach? sach = context.Sach.Find(maSach);

            if (sach != null)
                numDonGiaBan.Value = sach.GiaBan;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần in hóa đơn bạn làm sau như yêu cầu.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txtSdtTraCuu_TextChanged(object sender, EventArgs e)
        {
            if (chiXem || quyenHanNguoiDung == "admin")
                return;

            string sdt = txtSdtTraCuu.Text.Trim();

            if (string.IsNullOrWhiteSpace(sdt))
            {
                cboKhachHang.SelectedIndex = -1;
                return;
            }

            if (sdt.Length == 10)
                TimKhachHangTheoSoDienThoai(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

