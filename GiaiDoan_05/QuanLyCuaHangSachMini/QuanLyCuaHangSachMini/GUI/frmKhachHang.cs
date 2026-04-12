using ClosedXML.Excel;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmKhachHang : Form
    {
        AppDbContext context = new AppDbContext();
        bool xuLyThem = false;
        int id = 0;

        public frmKhachHang()
        {
            InitializeComponent();
            txtDienThoai.KeyPress += txtDienThoai_KeyPress;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
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
            txtDiaChi.Enabled = giaTri;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            txtDienThoai.MaxLength = 10;
            dgvKhachHang.AutoGenerateColumns = false;

            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.OrderBy(r => r.ID).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtMaKhachHang.DataBindings.Clear();
            txtMaKhachHang.DataBindings.Add("Text", bindingSource, "MaKhachHang", false, DataSourceUpdateMode.Never);

            cboHoVaTen.DataBindings.Clear();
            cboHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            dgvKhachHang.DataSource = bindingSource;

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
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXuat.Enabled = true;
            }
            else
            {
                id = 0;
                txtMaKhachHang.Clear();
                cboHoVaTen.Text = "";
                txtDienThoai.Clear();
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
            txtDiaChi.DataBindings.Clear();

            txtMaKhachHang.Text = "KH" + (soLonNhat + 1).ToString("000");
            cboHoVaTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            cboHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value.ToString());
                cboHoVaTen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHoVaTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                return;
            }

            if (!txtDienThoai.Text.All(char.IsDigit))
            {
                MessageBox.Show("Điện thoại chỉ được nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                return;
            }

            if (txtDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Điện thoại phải đúng 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    bool tonTai = context.KhachHang.Any(r =>
                        r.HoVaTen == cboHoVaTen.Text.Trim() &&
                        (r.DienThoai ?? "") == txtDienThoai.Text.Trim());

                    if (tonTai)
                    {
                        MessageBox.Show("Khách hàng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboHoVaTen.Focus();
                        return;
                    }

                    KhachHang kh = new KhachHang();
                    kh.MaKhachHang = txtMaKhachHang.Text.Trim();
                    kh.HoVaTen = cboHoVaTen.Text.Trim();
                    kh.DienThoai = txtDienThoai.Text.Trim();
                    kh.DiaChi = txtDiaChi.Text.Trim();

                    context.KhachHang.Add(kh);
                    context.SaveChanges();
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
                            MessageBox.Show("Khách hàng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboHoVaTen.Focus();
                            return;
                        }

                        kh.HoVaTen = cboHoVaTen.Text.Trim();
                        kh.DienThoai = txtDienThoai.Text.Trim();
                        kh.DiaChi = txtDiaChi.Text.Trim();

                        context.KhachHang.Update(kh);
                        context.SaveChanges();
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
                            context.KhachHang.Remove(kh);
                            context.SaveChanges();
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
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
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
                List<KhachHang> kh = new List<KhachHang>();
                kh = context.KhachHang
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

                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

                dgvKhachHang.DataSource = bindingSource;

                if (dgvKhachHang.Rows.Count > 0 && dgvKhachHang.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value.ToString());
                }
                else
                {
                    txtMaKhachHang.Clear();
                    txtDienThoai.Clear();
                    txtDiaChi.Clear();
                    MessageBox.Show("Không tìm thấy khách hàng phù hợp.", "Thông báo",
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
                                string diaChi = "";

                                if (table.Columns.Contains("HoVaTen"))
                                    hoVaTen = r["HoVaTen"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("TenKhachHang"))
                                    hoVaTen = r["TenKhachHang"]?.ToString()?.Trim() ?? "";

                                if (table.Columns.Contains("DienThoai"))
                                    dienThoai = r["DienThoai"]?.ToString()?.Trim() ?? "";

                                if (table.Columns.Contains("DiaChi"))
                                    diaChi = r["DiaChi"]?.ToString()?.Trim() ?? "";

                                if (string.IsNullOrWhiteSpace(hoVaTen) || string.IsNullOrWhiteSpace(dienThoai))
                                    continue;

                                if (!dienThoai.All(char.IsDigit) || dienThoai.Length != 10)
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
                                kh.DiaChi = diaChi;

                                context.KhachHang.Add(kh);
                                demThanhCong++;
                            }

                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + demThanhCong + " dòng.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmKhachHang_Load(sender, e);
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
                    string loi = ex.Message;

                    if (ex.InnerException != null)
                        loi += "\n\n" + ex.InnerException.Message;

                    if (ex.InnerException != null && ex.InnerException.InnerException != null)
                        loi += "\n\n" + ex.InnerException.InnerException.Message;

                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "KhachHang_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[4]
                    {
                        new DataColumn("MaKhachHang", typeof(string)),
                        new DataColumn("HoVaTen", typeof(string)),
                        new DataColumn("DienThoai", typeof(string)),
                        new DataColumn("DiaChi", typeof(string))
                    });

                    List<KhachHang> kh = new List<KhachHang>();
                    kh = context.KhachHang.OrderBy(r => r.ID).ToList();

                    foreach (KhachHang item in kh)
                        table.Rows.Add(item.MaKhachHang, item.HoVaTen, item.DienThoai, item.DiaChi);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "KhachHang");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    string loi = ex.Message;

                    if (ex.InnerException != null)
                        loi += "\n\n" + ex.InnerException.Message;

                    if (ex.InnerException != null && ex.InnerException.InnerException != null)
                        loi += "\n\n" + ex.InnerException.InnerException.Message;

                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvKhachHang.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value.ToString());
                txtMaKhachHang.Text = dgvKhachHang.CurrentRow.Cells["MaKhachHang"].Value.ToString();
                cboHoVaTen.Text = dgvKhachHang.CurrentRow.Cells["HoVaTen"].Value.ToString();
                txtDienThoai.Text = dgvKhachHang.CurrentRow.Cells["DienThoai"].Value?.ToString() ?? "";
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["DiaChi"].Value?.ToString() ?? "";
            }
        }
    }
}