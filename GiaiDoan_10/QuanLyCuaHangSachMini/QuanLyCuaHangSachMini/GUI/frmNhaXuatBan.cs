using ClosedXML.Excel;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.Helpers;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmNhaXuatBan : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private readonly BindingSource bindingSource = new BindingSource();
        private bool xuLyThem = false;
        private int id = 0;

        public frmNhaXuatBan()
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
            if (string.IsNullOrWhiteSpace(cboTenNhaXuatBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenNhaXuatBan.Focus();
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
            txtMaNhaXuatBan.Enabled = false;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;

            cboTenNhaXuatBan.Enabled = true;
            cboTenNhaXuatBan.DropDownStyle = ComboBoxStyle.DropDown;
            cboTenNhaXuatBan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenNhaXuatBan.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtDienThoai.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            txtDienThoai.MaxLength = 10;
            dgvNhaXuatBan.AutoGenerateColumns = false;

            BatTatChucNang(false);
            LoadData();
        }

        private string TaoMaNhaXuatBanMoi()
        {
            int soLonNhat = context.NhaXuatBan
                .AsEnumerable()
                .Select(r =>
                {
                    if (string.IsNullOrWhiteSpace(r.MaNhaXuatBan))
                        return 0;

                    string so = new string(r.MaNhaXuatBan.Where(char.IsDigit).ToArray());
                    return int.TryParse(so, out int kq) ? kq : 0;
                })
                .DefaultIfEmpty(0)
                .Max();

            return $"NXB{soLonNhat + 1:000}";
        }

        private void LoadData()
        {
            List<NhaXuatBan> nxb = context.NhaXuatBan.OrderBy(r => r.ID).ToList();

            bindingSource.DataSource = nxb;

            txtMaNhaXuatBan.DataBindings.Clear();
            txtMaNhaXuatBan.DataBindings.Add("Text", bindingSource, "MaNhaXuatBan", false, DataSourceUpdateMode.Never);

            cboTenNhaXuatBan.DataBindings.Clear();
            cboTenNhaXuatBan.DataBindings.Add("Text", bindingSource, "TenNhaXuatBan", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            dgvNhaXuatBan.DataSource = bindingSource;

            cboTenNhaXuatBan.BeginUpdate();
            cboTenNhaXuatBan.Items.Clear();
            cboTenNhaXuatBan.Items.AddRange(nxb.Select(r => r.TenNhaXuatBan).Distinct().ToArray());
            cboTenNhaXuatBan.EndUpdate();

            if (dgvNhaXuatBan.Rows.Count > 0 && dgvNhaXuatBan.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvNhaXuatBan.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXuat.Enabled = true;
            }
            else
            {
                id = 0;
                txtMaNhaXuatBan.Clear();
                cboTenNhaXuatBan.SelectedIndex = -1;
                cboTenNhaXuatBan.Text = string.Empty;
                txtDienThoai.Clear();
                txtEmail.Clear();
                txtDiaChi.Clear();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnXuat.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaNhaXuatBan.DataBindings.Clear();
            cboTenNhaXuatBan.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();

            txtMaNhaXuatBan.Text = TaoMaNhaXuatBanMoi();
            cboTenNhaXuatBan.SelectedIndex = -1;
            cboTenNhaXuatBan.DroppedDown = false;
            cboTenNhaXuatBan.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            cboTenNhaXuatBan.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhaXuatBan.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvNhaXuatBan.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                cboTenNhaXuatBan.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    bool tonTai = context.NhaXuatBan.Any(r => r.TenNhaXuatBan == cboTenNhaXuatBan.Text.Trim());
                    if (tonTai)
                    {
                        MessageBox.Show("Tên nhà xuất bản đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboTenNhaXuatBan.Focus();
                        return;
                    }

                    string maNhaXuatBan = txtMaNhaXuatBan.Text.Trim();
                    if (string.IsNullOrWhiteSpace(maNhaXuatBan))
                    {
                        maNhaXuatBan = TaoMaNhaXuatBanMoi();
                        txtMaNhaXuatBan.Text = maNhaXuatBan;
                    }

                    NhaXuatBan nxb = new NhaXuatBan();
                    nxb.MaNhaXuatBan = maNhaXuatBan;
                    nxb.TenNhaXuatBan = cboTenNhaXuatBan.Text.Trim();
                    nxb.DienThoai = txtDienThoai.Text.Trim();
                    nxb.Email = txtEmail.Text.Trim();
                    nxb.DiaChi = txtDiaChi.Text.Trim();

                    context.NhaXuatBan.Add(nxb);
                    context.SaveChanges();

                    NhatKyHelper.GhiLog(
                        "Thêm",
                        "NhaXuatBan",
                        nxb.ID.ToString(),
                        "Thêm nhà xuất bản: " + nxb.TenNhaXuatBan
                    );
                }
                else
                {
                    NhaXuatBan nxb = context.NhaXuatBan.Find(id);
                    if (nxb != null)
                    {
                        bool tonTai = context.NhaXuatBan.Any(r => r.TenNhaXuatBan == cboTenNhaXuatBan.Text.Trim() && r.ID != id);
                        if (tonTai)
                        {
                            MessageBox.Show("Tên nhà xuất bản đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboTenNhaXuatBan.Focus();
                            return;
                        }

                        nxb.TenNhaXuatBan = cboTenNhaXuatBan.Text.Trim();
                        nxb.DienThoai = txtDienThoai.Text.Trim();
                        nxb.Email = txtEmail.Text.Trim();
                        nxb.DiaChi = txtDiaChi.Text.Trim();

                        context.NhaXuatBan.Update(nxb);
                        context.SaveChanges();

                        NhatKyHelper.GhiLog(
                            "Sửa",
                            "NhaXuatBan",
                            nxb.ID.ToString(),
                            "Sửa nhà xuất bản: " + nxb.TenNhaXuatBan
                        );
                    }
                }

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
            if (dgvNhaXuatBan.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa nhà xuất bản " + cboTenNhaXuatBan.Text + "?", "Xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        id = Convert.ToInt32(dgvNhaXuatBan.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                        NhaXuatBan nxb = context.NhaXuatBan.Find(id);
                        if (nxb != null)
                        {
                            string khoaChinh = nxb.ID.ToString();
                            string ten = nxb.TenNhaXuatBan;

                            context.NhaXuatBan.Remove(nxb);
                            context.SaveChanges();

                            NhatKyHelper.GhiLog(
                                "Xóa",
                                "NhaXuatBan",
                                khoaChinh,
                                "Xóa nhà xuất bản: " + ten
                            );
                        }

                        LoadData();
                        BatTatChucNang(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa nhà xuất bản này.\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string tuKhoa = cboTenNhaXuatBan.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadData();
                BatTatChucNang(false);
            }
            else
            {
                List<NhaXuatBan> nxb = context.NhaXuatBan
                    .Where(r => r.TenNhaXuatBan.Contains(tuKhoa))
                    .OrderBy(r => r.ID)
                    .ToList();

                bindingSource.DataSource = nxb;

                txtMaNhaXuatBan.DataBindings.Clear();
                txtMaNhaXuatBan.DataBindings.Add("Text", bindingSource, "MaNhaXuatBan", false, DataSourceUpdateMode.Never);

                cboTenNhaXuatBan.DataBindings.Clear();
                cboTenNhaXuatBan.DataBindings.Add("Text", bindingSource, "TenNhaXuatBan", false, DataSourceUpdateMode.Never);

                txtDienThoai.DataBindings.Clear();
                txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

                txtEmail.DataBindings.Clear();
                txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

                dgvNhaXuatBan.DataSource = bindingSource;

                if (dgvNhaXuatBan.Rows.Count > 0 && dgvNhaXuatBan.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvNhaXuatBan.CurrentRow.Cells["ID"].Value?.ToString() ?? "0");
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnXuat.Enabled = true;

                    NhatKyHelper.GhiLog(
                        "Tìm kiếm",
                        "NhaXuatBan",
                        null,
                        "Tìm kiếm nhà xuất bản với từ khóa: " + tuKhoa
                    );
                }
                else
                {
                    id = 0;
                    txtMaNhaXuatBan.Clear();
                    txtDienThoai.Clear();
                    txtEmail.Clear();
                    txtDiaChi.Clear();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnXuat.Enabled = false;

                    MessageBox.Show("Không tìm thấy nhà xuất bản phù hợp.", "Thông báo",
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
                            if (context.NhaXuatBan.Any())
                            {
                                soLonNhat = context.NhaXuatBan
                                    .AsEnumerable()
                                    .Select(r =>
                                    {
                                        if (string.IsNullOrWhiteSpace(r.MaNhaXuatBan))
                                            return 0;

                                        string so = new string(r.MaNhaXuatBan.Where(char.IsDigit).ToArray());
                                        return int.TryParse(so, out int kq) ? kq : 0;
                                    })
                                    .DefaultIfEmpty(0)
                                    .Max();
                            }

                            int demThanhCong = 0;

                            foreach (DataRow r in table.Rows)
                            {
                                string tenNhaXuatBan = "";
                                string dienThoai = "";
                                string email = "";
                                string diaChi = "";

                                if (table.Columns.Contains("TenNhaXuatBan"))
                                    tenNhaXuatBan = r["TenNhaXuatBan"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("TenHangSanXuat"))
                                    tenNhaXuatBan = r["TenHangSanXuat"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("TenNXB"))
                                    tenNhaXuatBan = r["TenNXB"]?.ToString()?.Trim() ?? "";

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

                                if (string.IsNullOrWhiteSpace(tenNhaXuatBan))
                                    continue;

                                if (!string.IsNullOrWhiteSpace(dienThoai))
                                {
                                    if (!dienThoai.All(char.IsDigit))
                                        continue;
                                    if (dienThoai.Length != 10)
                                        continue;
                                }

                                bool tonTai = context.NhaXuatBan.Any(x =>
                                    x.TenNhaXuatBan == tenNhaXuatBan &&
                                    (x.DienThoai ?? "") == dienThoai);
                                if (tonTai)
                                    continue;

                                soLonNhat++;

                                NhaXuatBan nxb = new NhaXuatBan();
                                nxb.MaNhaXuatBan = "NXB" + soLonNhat.ToString("000");
                                nxb.TenNhaXuatBan = tenNhaXuatBan;
                                nxb.DienThoai = dienThoai;
                                nxb.Email = email;
                                nxb.DiaChi = diaChi;

                                context.NhaXuatBan.Add(nxb);
                                demThanhCong++;
                            }

                            context.SaveChanges();

                            NhatKyHelper.GhiLog(
                                "Nhập Excel",
                                "NhaXuatBan",
                                null,
                                "Nhập Excel nhà xuất bản, thêm mới " + demThanhCong + " dòng."
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
            saveFileDialog.FileName = "NhaXuatBan_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[5]
                    {
                        new DataColumn("MaNhaXuatBan", typeof(string)),
                        new DataColumn("TenNhaXuatBan", typeof(string)),
                        new DataColumn("DienThoai", typeof(string)),
                        new DataColumn("Email", typeof(string)),
                        new DataColumn("DiaChi", typeof(string))
                    });

                    List<NhaXuatBan> nxb = context.NhaXuatBan.OrderBy(r => r.ID).ToList();

                    foreach (NhaXuatBan item in nxb)
                        table.Rows.Add(item.MaNhaXuatBan, item.TenNhaXuatBan, item.DienThoai, item.Email, item.DiaChi);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhaXuatBan");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

                        NhatKyHelper.GhiLog(
                            "Xuất Excel",
                            "NhaXuatBan",
                            null,
                            "Xuất danh sách nhà xuất bản ra Excel, số dòng: " + nxb.Count
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
