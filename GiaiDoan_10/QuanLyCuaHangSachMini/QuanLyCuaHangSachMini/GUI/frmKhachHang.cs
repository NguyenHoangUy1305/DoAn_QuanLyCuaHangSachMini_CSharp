using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.Helpers;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmKhachHang : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private bool xuLyThem = false;
        private int id = 0;

        private readonly string quyenHanNguoiDung = "";

        public frmKhachHang(string quyenHan = "")
        {
            InitializeComponent();
            quyenHanNguoiDung = quyenHan ?? "";
            txtDienThoai.KeyPress += txtDienThoai_KeyPress;
            dgvKhachHang.DataBindingComplete += dgvKhachHang_DataBindingComplete;
        }

        private void dgvKhachHang_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            CapNhatCotPhanLoaiKhach();
        }

        private bool LaAdmin()
        {
            return quyenHanNguoiDung == "admin";
        }

        private void ApDungQuyen()
        {
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = true;
            btnHuyBo.Visible = true;
            btnNhap.Visible = true;
            btnTimKiem.Visible = true;
            btnXuat.Visible = true;
            btnThoat.Visible = true;

            if (LaAdmin())
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnHuyBo.Enabled = false;
                btnNhap.Enabled = false;

                btnTimKiem.Enabled = true;
                btnXuat.Enabled = true;
                btnThoat.Enabled = true;

                txtMaKhachHang.Enabled = false;
                txtDienThoai.Enabled = false;
                txtEmail.Enabled = false;
                txtDiaChi.Enabled = false;
                cboHoVaTen.Enabled = true;
            }
            else
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
                btnHuyBo.Enabled = true;
                btnNhap.Enabled = true;
                btnTimKiem.Enabled = true;
                btnXuat.Enabled = true;
                btnThoat.Enabled = true;
            }
        }

        private bool KhongChoPhepAdminChinhSua()
        {
            if (LaAdmin())
            {
                MessageBox.Show("Quản trị viên chỉ được xem, tìm kiếm và xuất Excel khách hàng.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
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
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHoVaTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập điện thoại.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                return false;
            }

            if (!txtDienThoai.Text.All(char.IsDigit))
            {
                MessageBox.Show("Điện thoại chỉ được nhập số.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                return false;
            }

            if (txtDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Điện thoại phải đúng 10 số.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void BatTatChucNang(bool giaTri)
        {
            txtMaKhachHang.Enabled = false;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;

            cboHoVaTen.Enabled = true;
            txtDienThoai.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            ApDungQuyen();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            txtDienThoai.MaxLength = 10;
            dgvKhachHang.AutoGenerateColumns = false;

            List<KhachHang> kh = context.KhachHang
                .OrderBy(r => r.ID)
                .ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtMaKhachHang.DataBindings.Clear();
            txtMaKhachHang.DataBindings.Add("Text", bindingSource, "MaKhachHang", false, DataSourceUpdateMode.Never);

            cboHoVaTen.DataBindings.Clear();
            cboHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            dgvKhachHang.DataSource = bindingSource;
            CapNhatCotPhanLoaiKhach();

            cboHoVaTen.Items.Clear();
            List<string> dsHoVaTen = context.KhachHang
                .OrderBy(r => r.HoVaTen)
                .Select(r => r.HoVaTen)
                .Distinct()
                .ToList();

            foreach (string item in dsHoVaTen)
                cboHoVaTen.Items.Add(item);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            auto.AddRange(dsHoVaTen.ToArray());
            cboHoVaTen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboHoVaTen.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboHoVaTen.AutoCompleteCustomSource = auto;

            if (dgvKhachHang.Rows.Count > 0 && dgvKhachHang.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value.ToString());

                if (!LaAdmin())
                {
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }

                btnXuat.Enabled = true;
            }
            else
            {
                id = 0;
                txtMaKhachHang.Clear();
                cboHoVaTen.Text = "";
                txtDienThoai.Clear();
                txtEmail.Clear();
                txtDiaChi.Clear();

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnXuat.Enabled = false;
            }

            ApDungQuyen();
        }

        private void CapNhatCotPhanLoaiKhach()
        {
            if (dgvKhachHang.Columns["LoaiKhach"] == null)
                return;

            Dictionary<int, int> soLanMuaTheoKhach = context.HoaDon
                .AsNoTracking()
                .GroupBy(r => r.KhachHangID)
                .Select(g => new { KhachHangID = g.Key, SoLan = g.Count() })
                .ToDictionary(x => x.KhachHangID, x => x.SoLan);

            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                if (row.IsNewRow)
                    continue;

                int khachHangId = 0;
                if (row.DataBoundItem is KhachHang khach)
                {
                    khachHangId = khach.ID;
                }
                else if (row.Cells["ID"].Value != null)
                {
                    khachHangId = Convert.ToInt32(row.Cells["ID"].Value);
                }

                if (khachHangId <= 0)
                    continue;

                int soLanMua = soLanMuaTheoKhach.TryGetValue(khachHangId, out int soLan) ? soLan : 0;

                string phanLoai = soLanMua >= 2 ? "Khách quen" : "Khách mới";
                row.Cells["LoaiKhach"].Value = phanLoai;
                row.Cells["LoaiKhach"].Style.ForeColor = soLanMua >= 2 ? Color.FromArgb(22, 163, 74) : Color.FromArgb(71, 85, 105);
                row.Cells["LoaiKhach"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KhongChoPhepAdminChinhSua())
                return;

            xuLyThem = true;
            BatTatChucNang(true);

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

            txtMaKhachHang.DataBindings.Clear();
            cboHoVaTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();

            txtMaKhachHang.Text = "KH" + (soLonNhat + 1).ToString("000");
            cboHoVaTen.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            cboHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KhongChoPhepAdminChinhSua())
                return;

            if (dgvKhachHang.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value.ToString());
                cboHoVaTen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KhongChoPhepAdminChinhSua())
                return;

            if (!KiemTraDuLieu())
                return;

            try
            {
                if (xuLyThem)
                {
                    bool tonTai = context.KhachHang.Any(r =>
                        r.HoVaTen == cboHoVaTen.Text.Trim() &&
                        (r.DienThoai ?? "") == txtDienThoai.Text.Trim());

                    if (tonTai)
                    {
                        MessageBox.Show("Khách hàng đã tồn tại.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboHoVaTen.Focus();
                        return;
                    }

                    KhachHang kh = new KhachHang();
                    kh.MaKhachHang = txtMaKhachHang.Text.Trim();
                    kh.HoVaTen = cboHoVaTen.Text.Trim();
                    kh.DienThoai = txtDienThoai.Text.Trim();
                    kh.Email = txtEmail.Text.Trim();
                    kh.DiaChi = txtDiaChi.Text.Trim();

                    context.KhachHang.Add(kh);
                    context.SaveChanges();

                    NhatKyHelper.GhiLog(
                        "Thêm",
                        "KhachHang",
                        kh.ID.ToString(),
                        "Thêm khách hàng: " + kh.HoVaTen
                    );
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        bool tonTai = context.KhachHang.Any(r =>
                            r.HoVaTen == cboHoVaTen.Text.Trim() &&
                            (r.DienThoai ?? "") == txtDienThoai.Text.Trim() &&
                            r.ID != id);

                        if (tonTai)
                        {
                            MessageBox.Show("Khách hàng đã tồn tại.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboHoVaTen.Focus();
                            return;
                        }

                        kh.HoVaTen = cboHoVaTen.Text.Trim();
                        kh.DienThoai = txtDienThoai.Text.Trim();
                        kh.Email = txtEmail.Text.Trim();
                        kh.DiaChi = txtDiaChi.Text.Trim();

                        context.KhachHang.Update(kh);
                        context.SaveChanges();

                        NhatKyHelper.GhiLog(
                            "Sửa",
                            "KhachHang",
                            kh.ID.ToString(),
                            "Sửa khách hàng: " + kh.HoVaTen
                        );
                    }
                }

                frmKhachHang_Load(sender, e);
            }
            catch (Exception ex)
            {
                string loi = ex.Message;

                if (ex.InnerException != null)
                    loi += "\n\n" + ex.InnerException.Message;

                if (ex.InnerException != null && ex.InnerException.InnerException != null)
                    loi += "\n\n" + ex.InnerException.InnerException.Message;

                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KhongChoPhepAdminChinhSua())
                return;

            if (dgvKhachHang.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa khách hàng " + cboHoVaTen.Text + "?", "Xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value.ToString());
                        KhachHang kh = context.KhachHang.Find(id);
                        if (kh != null)
                        {
                            string khoaChinh = kh.ID.ToString();
                            string hoTen = kh.HoVaTen;

                            context.KhachHang.Remove(kh);
                            context.SaveChanges();

                            NhatKyHelper.GhiLog(
                                "Xóa",
                                "KhachHang",
                                khoaChinh,
                                "Xóa khách hàng: " + hoTen
                            );
                        }

                        frmKhachHang_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        string loi = ex.Message;

                        if (ex.InnerException != null)
                            loi += "\n\n" + ex.InnerException.Message;

                        if (ex.InnerException != null && ex.InnerException.InnerException != null)
                            loi += "\n\n" + ex.InnerException.InnerException.Message;

                        MessageBox.Show("Không thể xóa khách hàng này.\n" + loi, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (KhongChoPhepAdminChinhSua())
                return;

            frmKhachHang_Load(sender, e);
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
                frmKhachHang_Load(sender, e);
            }
            else
            {
                List<KhachHang> kh = context.KhachHang
                    .Where(r => r.HoVaTen.Contains(tuKhoa))
                    .OrderBy(r => r.ID)
                    .ToList();

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = kh;

                txtMaKhachHang.DataBindings.Clear();
                txtMaKhachHang.DataBindings.Add("Text", bindingSource, "MaKhachHang", false, DataSourceUpdateMode.Never);

                cboHoVaTen.DataBindings.Clear();
                cboHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

                txtDienThoai.DataBindings.Clear();
                txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

                txtEmail.DataBindings.Clear();
                txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

                dgvKhachHang.DataSource = bindingSource;
                CapNhatCotPhanLoaiKhach();

                if (dgvKhachHang.Rows.Count > 0 && dgvKhachHang.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value.ToString());

                    NhatKyHelper.GhiLog(
                        "Tìm kiếm",
                        "KhachHang",
                        null,
                        "Tìm kiếm khách hàng với từ khóa: " + tuKhoa
                    );
                }
                else
                {
                    txtMaKhachHang.Clear();
                    txtDienThoai.Clear();
                    txtEmail.Clear();
                    txtDiaChi.Clear();

                    MessageBox.Show("Không tìm thấy khách hàng phù hợp.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ApDungQuyen();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (KhongChoPhepAdminChinhSua())
                return;

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

                            int demThanhCong = 0;

                            foreach (DataRow r in table.Rows)
                            {
                                string hoVaTen = "";
                                string dienThoai = "";
                                string email = "";
                                string diaChi = "";

                                if (table.Columns.Contains("HoVaTen"))
                                    hoVaTen = r["HoVaTen"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("TenKhachHang"))
                                    hoVaTen = r["TenKhachHang"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("TenKH"))
                                    hoVaTen = r["TenKH"]?.ToString()?.Trim() ?? "";

                                if (table.Columns.Contains("DienThoai"))
                                    dienThoai = r["DienThoai"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("SoDienThoai"))
                                    dienThoai = r["SoDienThoai"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("SDT"))
                                    dienThoai = r["SDT"]?.ToString()?.Trim() ?? "";

                                if (table.Columns.Contains("Email"))
                                    email = r["Email"]?.ToString()?.Trim() ?? "";

                                if (table.Columns.Contains("DiaChi"))
                                    diaChi = r["DiaChi"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("DiaChiKhachHang"))
                                    diaChi = r["DiaChiKhachHang"]?.ToString()?.Trim() ?? "";

                                if (string.IsNullOrWhiteSpace(hoVaTen))
                                    continue;

                                if (string.IsNullOrWhiteSpace(dienThoai))
                                    continue;

                                if (!dienThoai.All(char.IsDigit))
                                    continue;

                                if (dienThoai.Length != 10)
                                    continue;

                                bool tonTai = context.KhachHang.Any(x =>
                                    x.HoVaTen == hoVaTen &&
                                    (x.DienThoai ?? "") == dienThoai);
                                if (tonTai)
                                    continue;

                                soLonNhat++;

                                KhachHang kh = new KhachHang();
                                kh.MaKhachHang = "KH" + soLonNhat.ToString("000");
                                kh.HoVaTen = hoVaTen;
                                kh.DienThoai = dienThoai;
                                kh.Email = email;
                                kh.DiaChi = diaChi;

                                context.KhachHang.Add(kh);
                                demThanhCong++;
                            }

                            context.SaveChanges();

                            NhatKyHelper.GhiLog(
                                "Nhập Excel",
                                "KhachHang",
                                null,
                                "Nhập Excel khách hàng, thêm mới " + demThanhCong + " dòng."
                            );

                            frmKhachHang_Load(sender, e);

                            MessageBox.Show("Nhập Excel thành công.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu để nhập.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "DanhSachKhachHang.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<KhachHang> kh = context.KhachHang
                        .OrderBy(r => r.ID)
                        .ToList();

                    using XLWorkbook workbook = new XLWorkbook();
                    IXLWorksheet worksheet = workbook.Worksheets.Add("KhachHang");

                    worksheet.Cell(1, 1).Value = "MaKhachHang";
                    worksheet.Cell(1, 2).Value = "HoVaTen";
                    worksheet.Cell(1, 3).Value = "DienThoai";
                    worksheet.Cell(1, 4).Value = "Email";
                    worksheet.Cell(1, 5).Value = "DiaChi";

                    int dong = 2;
                    foreach (KhachHang item in kh)
                    {
                        worksheet.Cell(dong, 1).Value = item.MaKhachHang;
                        worksheet.Cell(dong, 2).Value = item.HoVaTen;
                        worksheet.Cell(dong, 3).Value = item.DienThoai;
                        worksheet.Cell(dong, 4).Value = item.Email;
                        worksheet.Cell(dong, 5).Value = item.DiaChi;
                        dong++;
                    }

                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(saveFileDialog.FileName);

                    NhatKyHelper.GhiLog(
                        "Xuất Excel",
                        "KhachHang",
                        null,
                        "Xuất danh sách khách hàng ra Excel, số dòng: " + kh.Count
                    );

                    MessageBox.Show("Xuất Excel thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
