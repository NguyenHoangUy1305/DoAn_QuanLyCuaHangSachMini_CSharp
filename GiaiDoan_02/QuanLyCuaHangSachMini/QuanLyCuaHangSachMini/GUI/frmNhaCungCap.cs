using ClosedXML.Excel;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmNhaCungCap : Form
    {
        AppDbContext context = new AppDbContext();
        bool xuLyThem = false;
        int id = 0;

        public frmNhaCungCap()
        {
            InitializeComponent();
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
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvNhaCungCap.AutoGenerateColumns = false;

            List<NhaCungCap> ncc = new List<NhaCungCap>();
            ncc = context.NhaCungCap.OrderBy(r => r.ID).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ncc;

            txtMaNhaCungCap.DataBindings.Clear();
            txtMaNhaCungCap.DataBindings.Add("Text", bindingSource, "MaNhaCungCap", false, DataSourceUpdateMode.Never);

            cboTenNhaCungCap.DataBindings.Clear();
            cboTenNhaCungCap.DataBindings.Add("Text", bindingSource, "TenNhaCungCap", false, DataSourceUpdateMode.Never);

            dgvNhaCungCap.DataSource = bindingSource;

            cboTenNhaCungCap.Items.Clear();
            List<string> dsTenNhaCungCap = context.NhaCungCap
                .OrderBy(r => r.TenNhaCungCap)
                .Select(r => r.TenNhaCungCap)
                .ToList();

            foreach (string item in dsTenNhaCungCap)
                cboTenNhaCungCap.Items.Add(item);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            auto.AddRange(dsTenNhaCungCap.ToArray());
            cboTenNhaCungCap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenNhaCungCap.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboTenNhaCungCap.AutoCompleteCustomSource = auto;

            if (dgvNhaCungCap.Rows.Count > 0 && dgvNhaCungCap.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value.ToString());
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXuat.Enabled = true;
            }
            else
            {
                id = 0;
                txtMaNhaCungCap.Clear();
                cboTenNhaCungCap.Text = "";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnXuat.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

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

            txtMaNhaCungCap.Text = "NCC" + (soLonNhat + 1).ToString("000");
            cboTenNhaCungCap.DataBindings.Clear();
            cboTenNhaCungCap.Text = "";
            cboTenNhaCungCap.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value.ToString());
                cboTenNhaCungCap.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTenNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenNhaCungCap.Focus();
            }
            else
            {
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

                        NhaCungCap ncc = new NhaCungCap();
                        ncc.MaNhaCungCap = txtMaNhaCungCap.Text.Trim();
                        ncc.TenNhaCungCap = cboTenNhaCungCap.Text.Trim();

                        context.NhaCungCap.Add(ncc);
                        context.SaveChanges();
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
                            context.NhaCungCap.Update(ncc);
                            context.SaveChanges();
                        }
                    }

                    frmNhaCungCap_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                        id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value.ToString());
                        NhaCungCap ncc = context.NhaCungCap.Find(id);
                        if (ncc != null)
                        {
                            context.NhaCungCap.Remove(ncc);
                            context.SaveChanges();
                        }

                        frmNhaCungCap_Load(sender, e);
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
            frmNhaCungCap_Load(sender, e);
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
                frmNhaCungCap_Load(sender, e);
            }
            else
            {
                List<NhaCungCap> ncc = new List<NhaCungCap>();
                ncc = context.NhaCungCap
                    .Where(r => r.TenNhaCungCap.Contains(tuKhoa))
                    .OrderBy(r => r.ID)
                    .ToList();

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = ncc;

                txtMaNhaCungCap.DataBindings.Clear();
                txtMaNhaCungCap.DataBindings.Add("Text", bindingSource, "MaNhaCungCap", false, DataSourceUpdateMode.Never);

                cboTenNhaCungCap.DataBindings.Clear();
                cboTenNhaCungCap.DataBindings.Add("Text", bindingSource, "TenNhaCungCap", false, DataSourceUpdateMode.Never);

                dgvNhaCungCap.DataSource = bindingSource;

                if (dgvNhaCungCap.Rows.Count > 0 && dgvNhaCungCap.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value.ToString());
                }
                else
                {
                    txtMaNhaCungCap.Clear();
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

                                if (table.Columns.Contains("TenNhaCungCap"))
                                    tenNhaCungCap = r["TenNhaCungCap"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("TenNCC"))
                                    tenNhaCungCap = r["TenNCC"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("TenNhaCungUng"))
                                    tenNhaCungCap = r["TenNhaCungUng"]?.ToString()?.Trim() ?? "";

                                if (string.IsNullOrWhiteSpace(tenNhaCungCap))
                                    continue;

                                bool tonTai = context.NhaCungCap.Any(x => x.TenNhaCungCap == tenNhaCungCap);
                                if (tonTai)
                                    continue;

                                soLonNhat++;

                                NhaCungCap ncc = new NhaCungCap();
                                ncc.MaNhaCungCap = "NCC" + soLonNhat.ToString("000");
                                ncc.TenNhaCungCap = tenNhaCungCap;

                                context.NhaCungCap.Add(ncc);
                                demThanhCong++;
                            }

                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + demThanhCong + " dòng.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmNhaCungCap_Load(sender, e);
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
                    table.Columns.AddRange(new DataColumn[2]
                    {
                        new DataColumn("MaNhaCungCap", typeof(string)),
                        new DataColumn("TenNhaCungCap", typeof(string))
                    });

                    List<NhaCungCap> ncc = new List<NhaCungCap>();
                    ncc = context.NhaCungCap.OrderBy(r => r.ID).ToList();

                    foreach (NhaCungCap item in ncc)
                        table.Rows.Add(item.MaNhaCungCap, item.TenNhaCungCap);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhaCungCap");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

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

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhaCungCap.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["ID"].Value.ToString());
                txtMaNhaCungCap.Text = dgvNhaCungCap.CurrentRow.Cells["MaNhaCungCap"].Value.ToString();
                cboTenNhaCungCap.Text = dgvNhaCungCap.CurrentRow.Cells["TenNhaCungCap"].Value.ToString();
            }
        }
    }
}