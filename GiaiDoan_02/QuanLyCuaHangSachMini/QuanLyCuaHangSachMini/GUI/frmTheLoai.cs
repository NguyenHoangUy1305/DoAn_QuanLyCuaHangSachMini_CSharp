using ClosedXML.Excel;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmTheLoai : Form
    {
        AppDbContext context = new AppDbContext();
        bool xuLyThem = false;
        int id = 0;

        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            txtMaTheLoai.Enabled = false;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;

            // Giữ combo luôn dùng được vì em đang dùng chung cho nhập + tìm kiếm
            cboTenTheLoai.Enabled = true;
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvTheLoai.AutoGenerateColumns = false;

            List<TheLoai> tl = new List<TheLoai>();
            tl = context.TheLoai.OrderBy(r => r.ID).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tl;

            txtMaTheLoai.DataBindings.Clear();
            txtMaTheLoai.DataBindings.Add("Text", bindingSource, "MaTheLoai", false, DataSourceUpdateMode.Never);

            cboTenTheLoai.DataBindings.Clear();
            cboTenTheLoai.DataBindings.Add("Text", bindingSource, "TenTheLoai", false, DataSourceUpdateMode.Never);

            dgvTheLoai.DataSource = bindingSource;

            cboTenTheLoai.Items.Clear();
            List<string> dsTenTheLoai = context.TheLoai
                .OrderBy(r => r.TenTheLoai)
                .Select(r => r.TenTheLoai)
                .ToList();

            foreach (string item in dsTenTheLoai)
                cboTenTheLoai.Items.Add(item);

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            auto.AddRange(dsTenTheLoai.ToArray());
            cboTenTheLoai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenTheLoai.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboTenTheLoai.AutoCompleteCustomSource = auto;

            if (dgvTheLoai.Rows.Count > 0 && dgvTheLoai.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvTheLoai.CurrentRow.Cells["ID"].Value.ToString());
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXuat.Enabled = true;
            }
            else
            {
                id = 0;
                txtMaTheLoai.Clear();
                cboTenTheLoai.Text = "";
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
            if (context.TheLoai.Any())
            {
                soLonNhat = context.TheLoai
                    .AsEnumerable()
                    .Select(r =>
                    {
                        if (string.IsNullOrWhiteSpace(r.MaTheLoai))
                            return 0;

                        string so = new string(r.MaTheLoai.Where(char.IsDigit).ToArray());
                        return int.TryParse(so, out int kq) ? kq : 0;
                    })
                    .DefaultIfEmpty(0)
                    .Max();
            }

            txtMaTheLoai.Text = "TL" + (soLonNhat + 1).ToString("000");
            cboTenTheLoai.DataBindings.Clear();
            cboTenTheLoai.Text = "";
            cboTenTheLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvTheLoai.CurrentRow.Cells["ID"].Value.ToString());
                cboTenTheLoai.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thể loại cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTenTheLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenTheLoai.Focus();
            }
            else
            {
                try
                {
                    if (xuLyThem)
                    {
                        bool tonTai = context.TheLoai.Any(r => r.TenTheLoai == cboTenTheLoai.Text.Trim());
                        if (tonTai)
                        {
                            MessageBox.Show("Tên thể loại đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboTenTheLoai.Focus();
                            return;
                        }

                        TheLoai tl = new TheLoai();
                        tl.MaTheLoai = txtMaTheLoai.Text.Trim();
                        tl.TenTheLoai = cboTenTheLoai.Text.Trim();

                        context.TheLoai.Add(tl);
                        context.SaveChanges();
                    }
                    else
                    {
                        TheLoai tl = context.TheLoai.Find(id);
                        if (tl != null)
                        {
                            bool tonTai = context.TheLoai.Any(r => r.TenTheLoai == cboTenTheLoai.Text.Trim() && r.ID != id);
                            if (tonTai)
                            {
                                MessageBox.Show("Tên thể loại đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cboTenTheLoai.Focus();
                                return;
                            }

                            tl.TenTheLoai = cboTenTheLoai.Text.Trim();
                            context.TheLoai.Update(tl);
                            context.SaveChanges();
                        }
                    }

                    frmTheLoai_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa thể loại " + cboTenTheLoai.Text + "?", "Xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        id = Convert.ToInt32(dgvTheLoai.CurrentRow.Cells["ID"].Value.ToString());
                        TheLoai tl = context.TheLoai.Find(id);
                        if (tl != null)
                        {
                            context.TheLoai.Remove(tl);
                            context.SaveChanges();
                        }

                        frmTheLoai_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa thể loại này.\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmTheLoai_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = cboTenTheLoai.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                frmTheLoai_Load(sender, e);
            }
            else
            {
                List<TheLoai> tl = new List<TheLoai>();
                tl = context.TheLoai
                    .Where(r => r.TenTheLoai.Contains(tuKhoa))
                    .OrderBy(r => r.ID)
                    .ToList();

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = tl;

                txtMaTheLoai.DataBindings.Clear();
                txtMaTheLoai.DataBindings.Add("Text", bindingSource, "MaTheLoai", false, DataSourceUpdateMode.Never);

                cboTenTheLoai.DataBindings.Clear();
                cboTenTheLoai.DataBindings.Add("Text", bindingSource, "TenTheLoai", false, DataSourceUpdateMode.Never);

                dgvTheLoai.DataSource = bindingSource;

                if (dgvTheLoai.Rows.Count > 0 && dgvTheLoai.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvTheLoai.CurrentRow.Cells["ID"].Value.ToString());
                }
                else
                {
                    txtMaTheLoai.Clear();
                    MessageBox.Show("Không tìm thấy thể loại phù hợp.", "Thông báo",
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
                            if (context.TheLoai.Any())
                            {
                                soLonNhat = context.TheLoai
                                    .AsEnumerable()
                                    .Select(r =>
                                    {
                                        if (string.IsNullOrWhiteSpace(r.MaTheLoai))
                                            return 0;

                                        string so = new string(r.MaTheLoai.Where(char.IsDigit).ToArray());
                                        return int.TryParse(so, out int kq) ? kq : 0;
                                    })
                                    .DefaultIfEmpty(0)
                                    .Max();
                            }

                            int demThanhCong = 0;

                            foreach (DataRow r in table.Rows)
                            {
                                string tenTheLoai = "";

                                if (table.Columns.Contains("TenTheLoai"))
                                    tenTheLoai = r["TenTheLoai"]?.ToString()?.Trim() ?? "";
                                else if (table.Columns.Contains("TenLoai"))
                                    tenTheLoai = r["TenLoai"]?.ToString()?.Trim() ?? "";

                                if (string.IsNullOrWhiteSpace(tenTheLoai))
                                    continue;

                                bool tonTai = context.TheLoai.Any(x => x.TenTheLoai == tenTheLoai);
                                if (tonTai)
                                    continue;

                                soLonNhat++;

                                TheLoai tl = new TheLoai();
                                tl.MaTheLoai = "TL" + soLonNhat.ToString("000");
                                tl.TenTheLoai = tenTheLoai;

                                context.TheLoai.Add(tl);
                                demThanhCong++;
                            }

                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + demThanhCong + " dòng.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmTheLoai_Load(sender, e);
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
            saveFileDialog.FileName = "TheLoai_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[2]
                    {
                        new DataColumn("MaTheLoai", typeof(string)),
                        new DataColumn("TenTheLoai", typeof(string))
                    });

                    List<TheLoai> tl = new List<TheLoai>();
                    tl = context.TheLoai.OrderBy(r => r.ID).ToList();

                    foreach (TheLoai item in tl)
                        table.Rows.Add(item.MaTheLoai, item.TenTheLoai);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "TheLoai");
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

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTheLoai.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvTheLoai.CurrentRow.Cells["ID"].Value.ToString());
                txtMaTheLoai.Text = dgvTheLoai.CurrentRow.Cells["MaTheLoai"].Value.ToString();
                cboTenTheLoai.Text = dgvTheLoai.CurrentRow.Cells["TenTheLoai"].Value.ToString();
            }
        }
    }
}