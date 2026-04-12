using ClosedXML.Excel;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmNhanVien : Form
    {
        AppDbContext context = new AppDbContext();
        bool xuLyThem = false;
        int id = 0;

        public frmNhanVien()
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
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;
            chkKichHoat.Enabled = giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            txtDienThoai.MaxLength = 10;
            dgvNhanVien.AutoGenerateColumns = false;

            cboQuyenHan.Items.Clear();
            cboQuyenHan.Items.Add("Nhân viên");
            cboQuyenHan.Items.Add("Quản trị viên");

            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.OrderBy(r => r.ID).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", bindingSource, "MaNhanVien", false, DataSourceUpdateMode.Never);

            cboHoVaTen.DataBindings.Clear();
            cboHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bindingSource, "MatKhau", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);

            chkKichHoat.DataBindings.Clear();
            chkKichHoat.DataBindings.Add("Checked", bindingSource, "KichHoat", true, DataSourceUpdateMode.Never);

            dgvNhanVien.DataSource = bindingSource;

            for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
            {
                bool quyenHan = false;
                bool.TryParse(dgvNhanVien.Rows[i].Cells["QuyenHan"].Value?.ToString(), out quyenHan);
                dgvNhanVien.Rows[i].Cells["TenQuyenHan"].Value = quyenHan ? "Quản trị viên" : "Nhân viên";

                bool kichHoat = false;
                bool.TryParse(dgvNhanVien.Rows[i].Cells["KichHoat"].Value?.ToString(), out kichHoat);
                dgvNhanVien.Rows[i].Cells["TrangThai"].Value = kichHoat ? "Đang hoạt động" : "Ngừng hoạt động";
            }

            cboHoVaTen.Items.Clear();
            List<string> dsHoVaTen = context.NhanVien
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

            if (dgvNhanVien.Rows.Count > 0 && dgvNhanVien.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXuat.Enabled = true;
            }
            else
            {
                id = 0;
                txtMaNhanVien.Clear();
                cboHoVaTen.Text = "";
                txtDienThoai.Clear();
                txtDiaChi.Clear();
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                cboQuyenHan.SelectedIndex = -1;
                chkKichHoat.Checked = true;
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

            txtMaNhanVien.DataBindings.Clear();
            cboHoVaTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            cboQuyenHan.DataBindings.Clear();
            chkKichHoat.DataBindings.Clear();

            txtMaNhanVien.Text = "NV" + (soLonNhat + 1).ToString("000");
            cboHoVaTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            cboQuyenHan.SelectedIndex = 0;
            chkKichHoat.Checked = true;
            cboHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                cboHoVaTen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
            {
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboQuyenHan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text) && xuLyThem)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            try
            {
                bool quyenHan = cboQuyenHan.SelectedIndex == 1;

                if (xuLyThem)
                {
                    bool tonTaiTenDangNhap = context.NhanVien.Any(r => r.TenDangNhap == txtTenDangNhap.Text.Trim());
                    if (tonTaiTenDangNhap)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenDangNhap.Focus();
                        return;
                    }

                    NhanVien nv = new NhanVien();
                    nv.MaNhanVien = txtMaNhanVien.Text.Trim();
                    nv.HoVaTen = cboHoVaTen.Text.Trim();
                    nv.DienThoai = txtDienThoai.Text.Trim();
                    nv.DiaChi = txtDiaChi.Text.Trim();
                    nv.TenDangNhap = txtTenDangNhap.Text.Trim();
                    nv.MatKhau = txtMatKhau.Text.Trim();
                    nv.QuyenHan = quyenHan;
                    nv.KichHoat = chkKichHoat.Checked;

                    context.NhanVien.Add(nv);
                    context.SaveChanges();
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        bool tonTaiTenDangNhap = context.NhanVien.Any(r => r.TenDangNhap == txtTenDangNhap.Text.Trim() && r.ID != id);
                        if (tonTaiTenDangNhap)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTenDangNhap.Focus();
                            return;
                        }

                        nv.HoVaTen = cboHoVaTen.Text.Trim();
                        nv.DienThoai = txtDienThoai.Text.Trim();
                        nv.DiaChi = txtDiaChi.Text.Trim();
                        nv.TenDangNhap = txtTenDangNhap.Text.Trim();
                        nv.QuyenHan = quyenHan;
                        nv.KichHoat = chkKichHoat.Checked;

                        if (!string.IsNullOrWhiteSpace(txtMatKhau.Text))
                            nv.MatKhau = txtMatKhau.Text.Trim();

                        context.NhanVien.Update(nv);
                        context.SaveChanges();
                    }
                }

                frmNhanVien_Load(sender, e);
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
            if (dgvNhanVien.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa nhân viên " + cboHoVaTen.Text + "?", "Xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                        NhanVien nv = context.NhanVien.Find(id);
                        if (nv != null)
                        {
                            context.NhanVien.Remove(nv);
                            context.SaveChanges();
                        }

                        frmNhanVien_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        string loi = ex.Message;

                        if (ex.InnerException != null)
                            loi += "\n\n" + ex.InnerException.Message;

                        if (ex.InnerException != null && ex.InnerException.InnerException != null)
                            loi += "\n\n" + ex.InnerException.InnerException.Message;

                        MessageBox.Show("Không thể xóa nhân viên này.\n" + loi, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            frmNhanVien_Load(sender, e);
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
                frmNhanVien_Load(sender, e);
            }
            else
            {
                List<NhanVien> nv = new List<NhanVien>();
                nv = context.NhanVien
                    .Where(r => r.HoVaTen.Contains(tuKhoa))
                    .OrderBy(r => r.ID)
                    .ToList();

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = nv;

                txtMaNhanVien.DataBindings.Clear();
                txtMaNhanVien.DataBindings.Add("Text", bindingSource, "MaNhanVien", false, DataSourceUpdateMode.Never);

                cboHoVaTen.DataBindings.Clear();
                cboHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

                txtDienThoai.DataBindings.Clear();
                txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

                txtTenDangNhap.DataBindings.Clear();
                txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

                txtMatKhau.DataBindings.Clear();
                txtMatKhau.DataBindings.Add("Text", bindingSource, "MatKhau", false, DataSourceUpdateMode.Never);

                cboQuyenHan.DataBindings.Clear();
                cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);

                chkKichHoat.DataBindings.Clear();
                chkKichHoat.DataBindings.Add("Checked", bindingSource, "KichHoat", true, DataSourceUpdateMode.Never);

                dgvNhanVien.DataSource = bindingSource;

                for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
                {
                    bool quyen = false;
                    bool.TryParse(dgvNhanVien.Rows[i].Cells["QuyenHan"].Value?.ToString(), out quyen);
                    dgvNhanVien.Rows[i].Cells["TenQuyenHan"].Value = quyen ? "Quản trị viên" : "Nhân viên";

                    bool kichHoat = false;
                    bool.TryParse(dgvNhanVien.Rows[i].Cells["KichHoat"].Value?.ToString(), out kichHoat);
                    dgvNhanVien.Rows[i].Cells["TrangThai"].Value = kichHoat ? "Đang hoạt động" : "Ngừng hoạt động";
                }

                if (dgvNhanVien.Rows.Count > 0 && dgvNhanVien.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                }
                else
                {
                    txtMaNhanVien.Clear();
                    txtDienThoai.Clear();
                    txtDiaChi.Clear();
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    cboQuyenHan.SelectedIndex = -1;
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp.", "Thông báo",
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
                                string hoVaTen = table.Columns.Contains("HoVaTen") ? r["HoVaTen"]?.ToString()?.Trim() ?? "" : "";
                                string dienThoai = table.Columns.Contains("DienThoai") ? r["DienThoai"]?.ToString()?.Trim() ?? "" : "";
                                string diaChi = table.Columns.Contains("DiaChi") ? r["DiaChi"]?.ToString()?.Trim() ?? "" : "";
                                string tenDangNhap = table.Columns.Contains("TenDangNhap") ? r["TenDangNhap"]?.ToString()?.Trim() ?? "" : "";
                                string matKhau = table.Columns.Contains("MatKhau") ? r["MatKhau"]?.ToString()?.Trim() ?? "" : "";
                                string quyenHan = table.Columns.Contains("QuyenHan") ? r["QuyenHan"]?.ToString()?.Trim() ?? "" : "";
                                string kichHoat = table.Columns.Contains("KichHoat") ? r["KichHoat"]?.ToString()?.Trim() ?? "" : "";

                                if (string.IsNullOrWhiteSpace(hoVaTen) ||
                                    string.IsNullOrWhiteSpace(dienThoai) ||
                                    string.IsNullOrWhiteSpace(tenDangNhap) ||
                                    string.IsNullOrWhiteSpace(matKhau))
                                    continue;

                                if (!dienThoai.All(char.IsDigit) || dienThoai.Length != 10)
                                    continue;

                                bool tonTaiTenDangNhap = context.NhanVien.Any(x => x.TenDangNhap == tenDangNhap);
                                if (tonTaiTenDangNhap)
                                    continue;

                                soLonNhat++;

                                NhanVien nv = new NhanVien();
                                nv.MaNhanVien = "NV" + soLonNhat.ToString("000");
                                nv.HoVaTen = hoVaTen;
                                nv.DienThoai = dienThoai;
                                nv.DiaChi = diaChi;
                                nv.TenDangNhap = tenDangNhap;
                                nv.MatKhau = matKhau;
                                nv.QuyenHan = quyenHan == "Quản trị viên" || quyenHan == "True" || quyenHan == "1";
                                nv.KichHoat = kichHoat == "" || kichHoat == "Đang hoạt động" || kichHoat == "True" || kichHoat == "1";

                                context.NhanVien.Add(nv);
                                demThanhCong++;
                            }

                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + demThanhCong + " dòng.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmNhanVien_Load(sender, e);
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
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[7]
                    {
                        new DataColumn("MaNhanVien", typeof(string)),
                        new DataColumn("HoVaTen", typeof(string)),
                        new DataColumn("DienThoai", typeof(string)),
                        new DataColumn("DiaChi", typeof(string)),
                        new DataColumn("TenDangNhap", typeof(string)),
                        new DataColumn("QuyenHan", typeof(string)),
                        new DataColumn("KichHoat", typeof(string))
                    });

                    List<NhanVien> nv = new List<NhanVien>();
                    nv = context.NhanVien.OrderBy(r => r.ID).ToList();

                    foreach (NhanVien item in nv)
                    {
                        table.Rows.Add(
                            item.MaNhanVien,
                            item.HoVaTen,
                            item.DienThoai,
                            item.DiaChi,
                            item.TenDangNhap,
                            item.QuyenHan ? "Quản trị viên" : "Nhân viên",
                            item.KichHoat ? "Đang hoạt động" : "Ngừng hoạt động"
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhanVien.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                cboHoVaTen.Text = dgvNhanVien.CurrentRow.Cells["HoVaTen"].Value.ToString();
                txtDienThoai.Text = dgvNhanVien.CurrentRow.Cells["DienThoai"].Value?.ToString() ?? "";
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value?.ToString() ?? "";
                txtTenDangNhap.Text = dgvNhanVien.CurrentRow.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dgvNhanVien.CurrentRow.Cells["MatKhau"].Value.ToString();

                bool quyenHan = false;
                bool.TryParse(dgvNhanVien.CurrentRow.Cells["QuyenHan"].Value?.ToString(), out quyenHan);
                cboQuyenHan.SelectedIndex = quyenHan ? 1 : 0;

                bool kichHoat = false;
                bool.TryParse(dgvNhanVien.CurrentRow.Cells["KichHoat"].Value?.ToString(), out kichHoat);
                chkKichHoat.Checked = kichHoat;
            }
        }
    }
}