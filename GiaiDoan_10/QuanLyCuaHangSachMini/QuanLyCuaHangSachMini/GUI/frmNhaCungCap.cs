using ClosedXML.Excel;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.Helpers;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmNhaCungCap : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private readonly BindingSource bindingSource = new BindingSource();
        private bool xuLyThem = false;
        private int id = 0;

        public frmNhaCungCap()
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
            if (string.IsNullOrWhiteSpace(cboTenNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenNhaCungCap.Focus();
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

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void BatTatChucNang(bool giaTri)
        {
            txtMaNhaCungCap.Enabled = false;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;

            cboTenNhaCungCap.Enabled = true;
            cboTenNhaCungCap.DropDownStyle = ComboBoxStyle.DropDown;
            cboTenNhaCungCap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenNhaCungCap.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtDienThoai.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            txtDienThoai.MaxLength = 10;
            dgvNhaCungCap.AutoGenerateColumns = false;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<NhaCungCap> ncc = context.NhaCungCap.OrderBy(r => r.ID).ToList();
                bindingSource.DataSource = ncc;

                txtMaNhaCungCap.DataBindings.Clear();
                txtMaNhaCungCap.DataBindings.Add("Text", bindingSource, "MaNhaCungCap", false, DataSourceUpdateMode.Never);

                cboTenNhaCungCap.DataBindings.Clear();
                cboTenNhaCungCap.DataBindings.Add("Text", bindingSource, "TenNhaCungCap", false, DataSourceUpdateMode.Never);

                txtDienThoai.DataBindings.Clear();
                txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

                txtEmail.DataBindings.Clear();
                txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

                dgvNhaCungCap.DataSource = bindingSource;

                List<string> dsTenNhaCungCap = context.NhaCungCap
                    .OrderBy(r => r.TenNhaCungCap)
                    .Select(r => r.TenNhaCungCap)
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .Distinct()
                    .ToList();

                cboTenNhaCungCap.BeginUpdate();
                cboTenNhaCungCap.Items.Clear();
                cboTenNhaCungCap.Items.AddRange(dsTenNhaCungCap.ToArray());
                cboTenNhaCungCap.EndUpdate();

                cboTenNhaCungCap.DropDownStyle = ComboBoxStyle.DropDown;
                cboTenNhaCungCap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboTenNhaCungCap.AutoCompleteSource = AutoCompleteSource.ListItems;

                if (dgvNhaCungCap.Rows.Count > 0 && dgvNhaCungCap.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnXuat.Enabled = true;
                }
                else
                {
                    id = 0;
                    txtMaNhaCungCap.Clear();
                    cboTenNhaCungCap.SelectedIndex = -1;
                    cboTenNhaCungCap.Text = string.Empty;
                    txtDienThoai.Clear();
                    txtEmail.Clear();
                    txtDiaChi.Clear();
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

        private string TaoMaNhaCungCapMoi()
        {
            int soLonNhat = context.NhaCungCap
                .AsEnumerable()
                .Select(r =>
                {
                    if (string.IsNullOrWhiteSpace(r.MaNhaCungCap))
                        return 0;

                    string so = new string(r.MaNhaCungCap.Where(char.IsDigit).ToArray());
                    return int.TryParse(so, out int kq) ? kq : 0;
                })
                .DefaultIfEmpty(0)
                .Max();

            return $"NCC{soLonNhat + 1:000}";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaNhaCungCap.DataBindings.Clear();
            cboTenNhaCungCap.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();

            txtMaNhaCungCap.Text = TaoMaNhaCungCapMoi();
            cboTenNhaCungCap.SelectedIndex = -1;
            cboTenNhaCungCap.DroppedDown = false;
            cboTenNhaCungCap.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            cboTenNhaCungCap.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                cboTenNhaCungCap.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            try
            {
                if (xuLyThem)
                {
                    bool tonTai = context.NhaCungCap.Any(r => r.TenNhaCungCap == cboTenNhaCungCap.Text.Trim());
                    if (tonTai)
                    {
                        MessageBox.Show("Tên nhà cung cấp đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboTenNhaCungCap.Focus();
                        return;
                    }

                    string maNhaCungCap = txtMaNhaCungCap.Text.Trim();
                    if (string.IsNullOrWhiteSpace(maNhaCungCap))
                    {
                        maNhaCungCap = TaoMaNhaCungCapMoi();
                        txtMaNhaCungCap.Text = maNhaCungCap;
                    }

                    NhaCungCap ncc = new NhaCungCap();
                    ncc.MaNhaCungCap = maNhaCungCap;
                    ncc.TenNhaCungCap = cboTenNhaCungCap.Text.Trim();
                    ncc.DienThoai = txtDienThoai.Text.Trim();
                    ncc.Email = txtEmail.Text.Trim();
                    ncc.DiaChi = txtDiaChi.Text.Trim();

                    context.NhaCungCap.Add(ncc);
                    context.SaveChanges();

                    NhatKyHelper.GhiLog(
                        "Thêm",
                        "NhaCungCap",
                        ncc.ID.ToString(),
                        "Thêm nhà cung cấp: " + ncc.TenNhaCungCap
                    );
                }
                else
                {
                    NhaCungCap ncc = context.NhaCungCap.Find(id);
                    if (ncc != null)
                    {
                        bool tonTai = context.NhaCungCap.Any(r => r.TenNhaCungCap == cboTenNhaCungCap.Text.Trim() && r.ID != id);
                        if (tonTai)
                        {
                            MessageBox.Show("Tên nhà cung cấp đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboTenNhaCungCap.Focus();
                            return;
                        }

                        ncc.TenNhaCungCap = cboTenNhaCungCap.Text.Trim();
                        ncc.DienThoai = txtDienThoai.Text.Trim();
                        ncc.Email = txtEmail.Text.Trim();
                        ncc.DiaChi = txtDiaChi.Text.Trim();

                        context.NhaCungCap.Update(ncc);
                        context.SaveChanges();

                        NhatKyHelper.GhiLog(
                            "Sửa",
                            "NhaCungCap",
                            ncc.ID.ToString(),
                            "Sửa nhà cung cấp: " + ncc.TenNhaCungCap
                        );
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhà cung cấp cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvNhaCungCap.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa nhà cung cấp " + cboTenNhaCungCap.Text + "?", "Xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                        NhaCungCap ncc = context.NhaCungCap.Find(id);
                        if (ncc != null)
                        {
                            string khoaChinh = ncc.ID.ToString();
                            string ten = ncc.TenNhaCungCap;

                            context.NhaCungCap.Remove(ncc);
                            context.SaveChanges();

                            NhatKyHelper.GhiLog(
                                "Xóa",
                                "NhaCungCap",
                                khoaChinh,
                                "Xóa nhà cung cấp: " + ten
                            );
                        }

                        xuLyThem = false;
                        id = 0;
                        LoadData();
                        BatTatChucNang(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa nhà cung cấp này.\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string tuKhoa = cboTenNhaCungCap.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadData();
                BatTatChucNang(false);
            }
            else
            {
                List<NhaCungCap> ncc = context.NhaCungCap
                    .Where(r => r.TenNhaCungCap.Contains(tuKhoa))
                    .OrderBy(r => r.ID)
                    .ToList();

                bindingSource.DataSource = ncc;

                txtMaNhaCungCap.DataBindings.Clear();
                txtMaNhaCungCap.DataBindings.Add("Text", bindingSource, "MaNhaCungCap", false, DataSourceUpdateMode.Never);

                cboTenNhaCungCap.DataBindings.Clear();
                cboTenNhaCungCap.DataBindings.Add("Text", bindingSource, "TenNhaCungCap", false, DataSourceUpdateMode.Never);

                txtDienThoai.DataBindings.Clear();
                txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

                txtEmail.DataBindings.Clear();
                txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

                dgvNhaCungCap.DataSource = bindingSource;

                if (dgvNhaCungCap.Rows.Count > 0 && dgvNhaCungCap.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnXuat.Enabled = true;

                    NhatKyHelper.GhiLog(
                        "Tìm kiếm",
                        "NhaCungCap",
                        null,
                        "Tìm kiếm nhà cung cấp với từ khóa: " + tuKhoa
                    );
                }
                else
                {
                    id = 0;
                    txtMaNhaCungCap.Clear();
                    cboTenNhaCungCap.SelectedIndex = -1;
                    cboTenNhaCungCap.Text = string.Empty;
                    txtDienThoai.Clear();
                    txtEmail.Clear();
                    txtDiaChi.Clear();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnXuat.Enabled = false;

                    MessageBox.Show("Không tìm thấy nhà cung cấp phù hợp.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            if (context.NhaCungCap.Any())
                            {
                                soLonNhat = context.NhaCungCap
                                    .AsEnumerable()
                                    .Select(r =>
                                    {
                                        if (string.IsNullOrWhiteSpace(r.MaNhaCungCap))
                                            return 0;

                                        string so = new string(r.MaNhaCungCap.Where(char.IsDigit).ToArray());
                                        return int.TryParse(so, out int kq) ? kq : 0;
                                    })
                                    .DefaultIfEmpty(0)
                                    .Max();
                            }

                            int demThanhCong = 0;

                            foreach (DataRow r in table.Rows)
                            {
                                string tenNhaCungCap = "";
                                string dienThoai = "";
                                string email = "";
                                string diaChi = "";

                                if (table.Columns.Contains("TenNhaCungCap"))
                                    tenNhaCungCap = r["TenNhaCungCap"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("TenNCC"))
                                    tenNhaCungCap = r["TenNCC"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("TenNhaCungUng"))
                                    tenNhaCungCap = r["TenNhaCungUng"]?.ToString()?.Trim() ?? "";

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

                                if (string.IsNullOrWhiteSpace(tenNhaCungCap))
                                    continue;

                                if (!string.IsNullOrWhiteSpace(dienThoai))
                                {
                                    if (!dienThoai.All(char.IsDigit))
                                        continue;
                                    if (dienThoai.Length != 10)
                                        continue;
                                }

                                bool tonTai = context.NhaCungCap.Any(x =>
                                    x.TenNhaCungCap == tenNhaCungCap &&
                                    (x.DienThoai ?? "") == dienThoai);
                                if (tonTai)
                                    continue;

                                soLonNhat++;

                                NhaCungCap ncc = new NhaCungCap();
                                ncc.MaNhaCungCap = "NCC" + soLonNhat.ToString("000");
                                ncc.TenNhaCungCap = tenNhaCungCap;
                                ncc.DienThoai = dienThoai;
                                ncc.Email = email;
                                ncc.DiaChi = diaChi;

                                context.NhaCungCap.Add(ncc);
                                demThanhCong++;
                            }

                            context.SaveChanges();

                            NhatKyHelper.GhiLog(
                                "Nhập Excel",
                                "NhaCungCap",
                                null,
                                "Nhập Excel nhà cung cấp, thêm mới " + demThanhCong + " dòng."
                            );

                            MessageBox.Show("Đã nhập thành công " + demThanhCong + " dòng.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadData();
                            BatTatChucNang(false);
                        }
                        else
                        {
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NhaCungCap_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[5]
                    {
                        new DataColumn("MaNhaCungCap", typeof(string)),
                        new DataColumn("TenNhaCungCap", typeof(string)),
                        new DataColumn("DienThoai", typeof(string)),
                        new DataColumn("Email", typeof(string)),
                        new DataColumn("DiaChi", typeof(string))
                    });

                    List<NhaCungCap> ncc = context.NhaCungCap.OrderBy(r => r.ID).ToList();

                    foreach (NhaCungCap item in ncc)
                        table.Rows.Add(item.MaNhaCungCap, item.TenNhaCungCap, item.DienThoai, item.Email, item.DiaChi);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhaCungCap");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

                        NhatKyHelper.GhiLog(
                            "Xuất Excel",
                            "NhaCungCap",
                            null,
                            "Xuất danh sách nhà cung cấp ra Excel, số dòng: " + ncc.Count
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
