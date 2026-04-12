using ClosedXML.Excel;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.Helpers;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmNhanVien : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private readonly BindingSource bindingSource = new BindingSource();
        private bool xuLyThem = false;
        private int id = 0;

        private bool LaTaiKhoanDangNhap(int nhanVienId)
        {
            return nhanVienId == SessionHelper.NhanVienID;
        }

        public frmNhanVien()
        {
            InitializeComponent();
            txtDienThoai.KeyPress += txtDienThoai_KeyPress;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bindingSource.Dispose();
            context.Dispose();
            base.OnFormClosed(e);
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(cboHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHoVaTen.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                if (!txtDienThoai.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Điện thoại chỉ được nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDienThoai.Focus();
                    return false;
                }

                if (txtDienThoai.Text.Length != 10)
                {
                    MessageBox.Show("Điện thoại phải đủ 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDienThoai.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return false;
            }

            return true;
        }

        private string ChuanHoaMatKhauDeLuu(string matKhauNhap)
        {
            string matKhau = matKhauNhap.Trim();
            if (PasswordHelper.IsHashedPassword(matKhau))
                return matKhau;

            return PasswordHelper.HashPassword(matKhau);
        }

        private void BatTatChucNang(bool giaTri)
        {
            txtMaNhanVien.Enabled = false;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;

            cboHoVaTen.Enabled = true;
            cboHoVaTen.DropDownStyle = ComboBoxStyle.DropDown;
            cboHoVaTen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboHoVaTen.AutoCompleteSource = AutoCompleteSource.ListItems;

            txtDienThoai.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            chkQuyenHan.Enabled = giaTri;
            chkKichHoat.Enabled = giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            txtDienThoai.MaxLength = 10;
            dgvNhanVien.AutoGenerateColumns = false;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<NhanVien> nhanVien = context.NhanVien.OrderBy(r => r.ID).ToList();
                bindingSource.DataSource = nhanVien;

                txtMaNhanVien.DataBindings.Clear();
                txtMaNhanVien.DataBindings.Add("Text", bindingSource, "MaNhanVien", false, DataSourceUpdateMode.Never);

                cboHoVaTen.DataBindings.Clear();
                cboHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

                txtDienThoai.DataBindings.Clear();
                txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

                txtTenDangNhap.DataBindings.Clear();
                txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

                txtMatKhau.DataBindings.Clear();
                txtMatKhau.DataBindings.Add("Text", bindingSource, "MatKhau", false, DataSourceUpdateMode.Never);

                chkKichHoat.DataBindings.Clear();
                chkKichHoat.DataBindings.Add("Checked", bindingSource, "KichHoat", false, DataSourceUpdateMode.Never);

                dgvNhanVien.DataSource = bindingSource;

                List<string> dsHoVaTen = context.NhanVien
                    .OrderBy(r => r.HoVaTen)
                    .Select(r => r.HoVaTen)
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .Distinct()
                    .ToList();

                cboHoVaTen.BeginUpdate();
                cboHoVaTen.Items.Clear();
                cboHoVaTen.Items.AddRange(dsHoVaTen.ToArray());
                cboHoVaTen.EndUpdate();

                cboHoVaTen.DropDownStyle = ComboBoxStyle.DropDown;
                cboHoVaTen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboHoVaTen.AutoCompleteSource = AutoCompleteSource.ListItems;

                if (bindingSource.Current is NhanVien nvHienTai)
                    chkQuyenHan.Checked = nvHienTai.QuyenHan;
                else
                    chkQuyenHan.Checked = false;

                if (dgvNhanVien.Rows.Count > 0 && dgvNhanVien.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnXuat.Enabled = true;
                }
                else
                {
                    id = 0;
                    txtMaNhanVien.Clear();
                    cboHoVaTen.SelectedIndex = -1;
                    cboHoVaTen.Text = string.Empty;
                    txtDienThoai.Clear();
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    chkQuyenHan.Checked = false;
                    chkKichHoat.Checked = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnXuat.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string TaoMaNhanVienMoi()
        {
            int soLonNhat = context.NhanVien
                .AsEnumerable()
                .Select(r =>
                {
                    if (string.IsNullOrWhiteSpace(r.MaNhanVien))
                        return 0;

                    string so = new string(r.MaNhanVien.Where(char.IsDigit).ToArray());
                    return int.TryParse(so, out int kq) ? kq : 0;
                })
                .DefaultIfEmpty(0)
                .Max();

            return $"NV{soLonNhat + 1:000}";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaNhanVien.DataBindings.Clear();
            cboHoVaTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            chkKichHoat.DataBindings.Clear();

            txtMaNhanVien.Text = TaoMaNhanVienMoi();
            cboHoVaTen.SelectedIndex = -1;
            cboHoVaTen.DroppedDown = false;
            cboHoVaTen.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtTenDangNhap.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            chkQuyenHan.Checked = false;
            chkKichHoat.Checked = true;
            cboHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                if (LaTaiKhoanDangNhap(id))
                {
                    MessageBox.Show("Không thể chỉnh sửa tài khoản đang đăng nhập.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                xuLyThem = false;
                BatTatChucNang(true);

                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                    chkQuyenHan.Checked = nv.QuyenHan;

                cboHoVaTen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            try
            {
                bool laQuanTriVien = chkQuyenHan.Checked;

                if (xuLyThem)
                {
                    bool tonTaiTenDangNhap = context.NhanVien.Any(r => r.TenDangNhap == txtTenDangNhap.Text.Trim());
                    if (tonTaiTenDangNhap)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenDangNhap.Focus();
                        return;
                    }

                    string maNhanVien = txtMaNhanVien.Text.Trim();
                    if (string.IsNullOrWhiteSpace(maNhanVien))
                    {
                        maNhanVien = TaoMaNhanVienMoi();
                        txtMaNhanVien.Text = maNhanVien;
                    }

                    NhanVien nv = new NhanVien();
                    nv.MaNhanVien = maNhanVien;
                    nv.HoVaTen = cboHoVaTen.Text.Trim();
                    nv.DienThoai = txtDienThoai.Text.Trim();
                    nv.TenDangNhap = txtTenDangNhap.Text.Trim();
                    nv.MatKhau = ChuanHoaMatKhauDeLuu(txtMatKhau.Text);
                    nv.QuyenHan = laQuanTriVien;
                    nv.KichHoat = chkKichHoat.Checked;

                    context.NhanVien.Add(nv);
                    context.SaveChanges();

                    NhatKyHelper.GhiLog(
                        "Thêm",
                        "NhanVien",
                        nv.ID.ToString(),
                        "Thêm nhân viên: " + nv.HoVaTen
                    );
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        if (LaTaiKhoanDangNhap(nv.ID))
                        {
                            MessageBox.Show("Không thể chỉnh sửa tài khoản đang đăng nhập.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        bool tonTaiTenDangNhap = context.NhanVien.Any(r => r.TenDangNhap == txtTenDangNhap.Text.Trim() && r.ID != id);
                        if (tonTaiTenDangNhap)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTenDangNhap.Focus();
                            return;
                        }

                        nv.HoVaTen = cboHoVaTen.Text.Trim();
                        nv.DienThoai = txtDienThoai.Text.Trim();
                        nv.TenDangNhap = txtTenDangNhap.Text.Trim();
                        nv.MatKhau = ChuanHoaMatKhauDeLuu(txtMatKhau.Text);
                        nv.QuyenHan = laQuanTriVien;
                        nv.KichHoat = chkKichHoat.Checked;

                        context.NhanVien.Update(nv);
                        context.SaveChanges();

                        NhatKyHelper.GhiLog(
                            "Sửa",
                            "NhanVien",
                            nv.ID.ToString(),
                            "Sửa nhân viên: " + nv.HoVaTen
                        );
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                xuLyThem = false;
                id = 0;
                LoadData();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa nhân viên " + cboHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                        NhanVien nv = context.NhanVien.Find(id);
                        if (nv != null)
                        {
                            if (nv.ID == SessionHelper.NhanVienID)
                            {
                                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (nv.QuyenHan)
                            {
                                int soLuongAdmin = context.NhanVien.Count(x => x.QuyenHan);
                                if (soLuongAdmin <= 1)
                                {
                                    MessageBox.Show("Không thể xóa quản trị viên cuối cùng của hệ thống.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            string khoaChinh = nv.ID.ToString();
                            string ten = nv.HoVaTen;

                            context.NhanVien.Remove(nv);
                            context.SaveChanges();

                            NhatKyHelper.GhiLog(
                                "Xóa",
                                "NhanVien",
                                khoaChinh,
                                "Xóa nhân viên: " + ten
                            );
                        }

                        xuLyThem = false;
                        id = 0;
                        LoadData();
                        BatTatChucNang(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa nhân viên này.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            id = 0;
            LoadData();
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = cboHoVaTen.Text.Trim();
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadData();
                BatTatChucNang(false);
            }
            else
            {
                List<NhanVien> nhanVien = context.NhanVien
                    .Where(r => r.HoVaTen.Contains(tuKhoa) || r.MaNhanVien.Contains(tuKhoa) || r.DienThoai.Contains(tuKhoa))
                    .OrderBy(r => r.ID)
                    .ToList();

                bindingSource.DataSource = nhanVien;
                dgvNhanVien.DataSource = bindingSource;

                if (nhanVien.Count > 0)
                {
                    if (bindingSource.Current is NhanVien nvHienTai)
                        chkQuyenHan.Checked = nvHienTai.QuyenHan;
                    else
                        chkQuyenHan.Checked = false;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chkQuyenHan.Checked = false;
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());

                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            int soLonNhat = 0;
                            if (context.NhanVien.Any())
                            {
                                soLonNhat = context.NhanVien
                                    .AsEnumerable()
                                    .Select(r =>
                                    {
                                        if (string.IsNullOrWhiteSpace(r.MaNhanVien))
                                            return 0;

                                        string so = new string(r.MaNhanVien.Where(char.IsDigit).ToArray());
                                        return int.TryParse(so, out int kq) ? kq : 0;
                                    })
                                    .DefaultIfEmpty(0)
                                    .Max();
                            }

                            int demThanhCong = 0;
                            foreach (DataRow r in table.Rows)
                            {
                                string hoVaTen = "";
                                string dienThoai = "";
                                string tenDangNhap = "";
                                string matKhau = "";
                                string quyenHan = "";
                                string kichHoat = "";

                                if (table.Columns.Contains("HoVaTen")) hoVaTen = r["HoVaTen"].ToString();
                                else if (table.Columns.Contains("Họ và tên")) hoVaTen = r["Họ và tên"].ToString();

                                if (table.Columns.Contains("DienThoai")) dienThoai = r["DienThoai"].ToString();
                                else if (table.Columns.Contains("Điện thoại")) dienThoai = r["Điện thoại"].ToString();

                                if (table.Columns.Contains("TenDangNhap")) tenDangNhap = r["TenDangNhap"].ToString();
                                else if (table.Columns.Contains("Tên đăng nhập")) tenDangNhap = r["Tên đăng nhập"].ToString();

                                if (table.Columns.Contains("MatKhau")) matKhau = r["MatKhau"].ToString();
                                else if (table.Columns.Contains("Mật khẩu")) matKhau = r["Mật khẩu"].ToString();

                                if (table.Columns.Contains("QuyenHan")) quyenHan = r["QuyenHan"].ToString();
                                else if (table.Columns.Contains("Quyền hạn")) quyenHan = r["Quyền hạn"].ToString();

                                if (table.Columns.Contains("KichHoat")) kichHoat = r["KichHoat"].ToString();
                                else if (table.Columns.Contains("Trạng thái")) kichHoat = r["Trạng thái"].ToString();


                                if (!string.IsNullOrWhiteSpace(hoVaTen) && !string.IsNullOrWhiteSpace(tenDangNhap))
                                {
                                    bool tonTai = context.NhanVien.Any(x => x.TenDangNhap == tenDangNhap);
                                    if (!tonTai)
                                    {
                                        if (string.IsNullOrWhiteSpace(matKhau))
                                            matKhau = "123456";

                                        soLonNhat++;
                                        NhanVien nv = new NhanVien();
                                        nv.MaNhanVien = $"NV{soLonNhat:000}";
                                        nv.HoVaTen = hoVaTen;
                                        nv.DienThoai = dienThoai;
                                        nv.TenDangNhap = tenDangNhap;
                                        nv.MatKhau = ChuanHoaMatKhauDeLuu(matKhau);
                                        nv.QuyenHan = quyenHan.ToLower() == "admin" || quyenHan.ToLower() == "quản trị viên" || quyenHan.ToLower() == "true";
                                        nv.KichHoat = kichHoat.ToLower() == "đang hoạt động" || kichHoat.ToLower() == "true" || kichHoat == "1";

                                        context.NhanVien.Add(nv);
                                        demThanhCong++;
                                    }
                                }
                            }

                            if (demThanhCong > 0)
                            {
                                context.SaveChanges();

                                NhatKyHelper.GhiLog(
                                    "Nhập Excel",
                                    "NhanVien",
                                    null,
                                    "Nhập Excel nhân viên, thêm mới " + demThanhCong + " dòng."
                                );

                                MessageBox.Show("Đã nhập thành công " + demThanhCong + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                                BatTatChucNang(false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "DanhSachNhanVien.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<NhanVien> nhanVien = context.NhanVien.OrderBy(r => r.ID).ToList();

                    DataTable table = new DataTable();
                    table.Columns.Add("Mã nhân viên");
                    table.Columns.Add("Họ và tên");
                    table.Columns.Add("Điện thoại");
                    table.Columns.Add("Tên đăng nhập");
                    table.Columns.Add("Quyền hạn");
                    table.Columns.Add("Trạng thái");

                    foreach (var item in nhanVien)
                    {
                        table.Rows.Add(
                            item.MaNhanVien,
                            item.HoVaTen,
                            item.DienThoai,
                            item.TenDangNhap,
                            item.QuyenHan ? "Admin" : "Nhân viên",
                            item.KichHoat ? "Đang hoạt động" : "Đã khóa"
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

                        NhatKyHelper.GhiLog(
                            "Xuất Excel",
                            "NhanVien",
                            null,
                            "Xuất danh sách nhân viên ra Excel, số dòng: " + nhanVien.Count
                        );

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
