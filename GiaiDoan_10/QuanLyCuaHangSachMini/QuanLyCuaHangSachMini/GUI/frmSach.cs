using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Helpers;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.DTOs;
using System.Data;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmSach : Form
    {
        AppDbContext context = new AppDbContext();
        bool xuLyThem = false;
        bool daTaiForm = false;
        int id = 0;

        string imagesFolder = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images"));

        public frmSach()
        {
            InitializeComponent();
            this.Activated += frmSach_Activated;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }

        private void LamMoiContext()
        {
            context.Dispose();
            context = new AppDbContext();
        }

        private void NapDanhMuc()
        {
            cboTheLoai.DataSource = context.TheLoai
                .AsNoTracking()
                .OrderBy(r => r.TenTheLoai)
                .ToList();
            cboTheLoai.ValueMember = "ID";
            cboTheLoai.DisplayMember = "TenTheLoai";

            cboNhaXuatBan.DataSource = context.NhaXuatBan
                .AsNoTracking()
                .OrderBy(r => r.TenNhaXuatBan)
                .ToList();
            cboNhaXuatBan.ValueMember = "ID";
            cboNhaXuatBan.DisplayMember = "TenNhaXuatBan";
        }

        private void TaiLaiToanBoDuLieu()
        {
            LamMoiContext();
            NapDanhMuc();
            TaiDanhSachTenSach();
            TaiDuLieuLenForm();
        }

        public void LamMoiSauKhiBanHang()
        {
            if (IsDisposed) return;
            if (btnLuu.Enabled) return;

            TaiLaiToanBoDuLieu();
            BatTatChucNang(false);
        }

        private void frmSach_Activated(object? sender, EventArgs e)
        {
            if (!daTaiForm) return;

            LamMoiSauKhiBanHang();
        }

        private void BatTatChucNang(bool giaTri)
        {
            txtMaSach.Enabled = false;

            cboTheLoai.Enabled = giaTri;
            cboNhaXuatBan.Enabled = giaTri;
            cboTenSach.Enabled = true; // luôn cho gõ để tìm kiếm
            txtTacGia.Enabled = giaTri;
            numSoLuongTon.Enabled = giaTri;
            numGiaNhap.Enabled = false;
            numGiaBan.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            btnDoiAnh.Enabled = giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnThoat.Enabled = !giaTri;
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            dgvSach.AutoGenerateColumns = false;

            numSoLuongTon.Minimum = 0;
            numSoLuongTon.Maximum = 100000;
            numSoLuongTon.ThousandsSeparator = true;

            numGiaNhap.Minimum = 0;
            numGiaNhap.Maximum = 1000000000;
            numGiaNhap.ThousandsSeparator = true;

            numGiaBan.Minimum = 0;
            numGiaBan.Maximum = 1000000000;
            numGiaBan.ThousandsSeparator = true;

            cboTenSach.DropDownStyle = ComboBoxStyle.DropDown;
            cboTenSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenSach.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTenSach.KeyDown += cboTenSach_KeyDown;

            NapDanhMuc();
            TaiDanhSachTenSach();
            TaiDuLieuLenForm();

            daTaiForm = true;
        }

        private void TaiDanhSachTenSach()
        {
            List<string> dsTenSach = context.Sach
                .AsNoTracking()
                .OrderBy(r => r.TenSach)
                .Select(r => r.TenSach)
                .Distinct()
                .ToList();

            cboTenSach.DataSource = null;
            cboTenSach.Items.Clear();

            foreach (string item in dsTenSach)
                cboTenSach.Items.Add(item);

            cboTenSach.DropDownStyle = ComboBoxStyle.DropDown;
            cboTenSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenSach.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void TaiDuLieuLenForm()
        {
            List<DanhSachSach> dsSach = context.Sach
                .AsNoTracking()
                .Select(r => new DanhSachSach
                {
                    ID = r.ID,
                    TheLoaiID = r.TheLoaiID,
                    TenTheLoai = r.TheLoai.TenTheLoai,
                    NhaXuatBanID = r.NhaXuatBanID,
                    TenNhaXuatBan = r.NhaXuatBan.TenNhaXuatBan,
                    MaSach = r.MaSach,
                    TenSach = r.TenSach,
                    TacGia = r.TacGia,
                    GiaNhap = r.GiaNhap,
                    GiaBan = r.GiaBan,
                    SoLuongTon = r.SoLuongTon,
                    HinhAnh = r.HinhAnh,
                    MoTa = r.MoTa,
                    TrangThai = r.TrangThai
                })
                .OrderBy(r => r.ID)
                .ToList();

            GanBinding(dsSach);

            if (dgvSach.Rows.Count > 0 && dgvSach.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvSach.CurrentRow.Cells["ID"].Value.ToString());
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXuat.Enabled = true;
            }
            else
            {
                id = 0;
                txtMaSach.Clear();
                cboTenSach.Text = "";
                txtTacGia.Clear();
                txtMoTa.Clear();
                numSoLuongTon.Value = 0;
                numGiaNhap.Value = 0;
                numGiaBan.Value = 0;
                picHinhAnh.Image = null;
                picHinhAnh.ImageLocation = null;
                picHinhAnh.Tag = null;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnXuat.Enabled = false;
            }
        }

        private void GanBinding(List<DanhSachSach> dsSach)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dsSach;

            txtMaSach.DataBindings.Clear();
            txtMaSach.DataBindings.Add("Text", bindingSource, "MaSach", false, DataSourceUpdateMode.Never);

            cboTheLoai.DataBindings.Clear();
            cboTheLoai.DataBindings.Add("SelectedValue", bindingSource, "TheLoaiID", false, DataSourceUpdateMode.Never);

            cboNhaXuatBan.DataBindings.Clear();
            cboNhaXuatBan.DataBindings.Add("SelectedValue", bindingSource, "NhaXuatBanID", false, DataSourceUpdateMode.Never);

            cboTenSach.DataBindings.Clear();
            cboTenSach.DataBindings.Add("Text", bindingSource, "TenSach", false, DataSourceUpdateMode.Never);

            txtTacGia.DataBindings.Clear();
            txtTacGia.DataBindings.Add("Text", bindingSource, "TacGia", false, DataSourceUpdateMode.Never);

            numSoLuongTon.DataBindings.Clear();
            numSoLuongTon.DataBindings.Add("Value", bindingSource, "SoLuongTon", false, DataSourceUpdateMode.Never);

            numGiaNhap.DataBindings.Clear();
            numGiaNhap.DataBindings.Add("Value", bindingSource, "GiaNhap", false, DataSourceUpdateMode.Never);

            numGiaBan.DataBindings.Clear();
            numGiaBan.DataBindings.Add("Value", bindingSource, "GiaBan", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();

            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, ev) =>
            {
                if (ev.Value == null || string.IsNullOrWhiteSpace(ev.Value.ToString()))
                    ev.Value = null;
                else
                {
                    string duongDan = Path.Combine(imagesFolder, ev.Value.ToString()!);
                    ev.Value = File.Exists(duongDan) ? duongDan : null;
                }
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
            picHinhAnh.DataBindings.Add("Tag", bindingSource, "HinhAnh", false, DataSourceUpdateMode.Never);

            dgvSach.DataSource = bindingSource;
        }

        private void NapThongTinTheoTenSach()
        {
            if (string.IsNullOrWhiteSpace(cboTenSach.Text))
                return;

            string tenSach = cboTenSach.Text.Trim();

            Sach? sach = context.Sach
                .AsNoTracking()
                .FirstOrDefault(r => r.TenSach == tenSach);

            if (sach == null)
                return;

            txtTacGia.Text = sach.TacGia;
            numGiaNhap.Value = sach.GiaNhap;
            numGiaBan.Value = sach.GiaBan;
            numSoLuongTon.Value = sach.SoLuongTon;
            txtMoTa.Text = sach.MoTa ?? "";

            if (context.TheLoai.Any(r => r.ID == sach.TheLoaiID))
                cboTheLoai.SelectedValue = sach.TheLoaiID;

            if (context.NhaXuatBan.Any(r => r.ID == sach.NhaXuatBanID))
                cboNhaXuatBan.SelectedValue = sach.NhaXuatBanID;

            picHinhAnh.Tag = sach.HinhAnh;

            if (!string.IsNullOrWhiteSpace(sach.HinhAnh))
            {
                string duongDan = Path.Combine(imagesFolder, sach.HinhAnh);
                if (File.Exists(duongDan))
                    picHinhAnh.ImageLocation = duongDan;
                else
                    picHinhAnh.ImageLocation = null;
            }
            else
            {
                picHinhAnh.ImageLocation = null;
                picHinhAnh.Image = null;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            int soLonNhat = 0;
            if (context.Sach.Any())
            {
                soLonNhat = context.Sach
                    .AsEnumerable()
                    .Select(r =>
                    {
                        if (string.IsNullOrWhiteSpace(r.MaSach))
                            return 0;

                        string so = new string(r.MaSach.Where(char.IsDigit).ToArray());
                        return int.TryParse(so, out int kq) ? kq : 0;
                    })
                    .DefaultIfEmpty(0)
                    .Max();
            }

            txtMaSach.DataBindings.Clear();
            cboTheLoai.DataBindings.Clear();
            cboNhaXuatBan.DataBindings.Clear();
            cboTenSach.DataBindings.Clear();
            txtTacGia.DataBindings.Clear();
            numSoLuongTon.DataBindings.Clear();
            numGiaNhap.DataBindings.Clear();
            numGiaBan.DataBindings.Clear();
            txtMoTa.DataBindings.Clear();
            picHinhAnh.DataBindings.Clear();

            txtMaSach.Text = "S" + (soLonNhat + 1).ToString("000");
            cboTheLoai.SelectedIndex = -1;
            cboNhaXuatBan.SelectedIndex = -1;
            cboTenSach.Text = "";
            txtTacGia.Clear();
            txtMoTa.Clear();
            numSoLuongTon.Value = 0;
            numGiaNhap.Value = 0;
            numGiaBan.Value = 0;
            picHinhAnh.Image = null;
            picHinhAnh.ImageLocation = null;
            picHinhAnh.Tag = null;
            cboTenSach.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSach.CurrentRow != null)
            {
                xuLyThem = false;
                BatTatChucNang(true);
                id = Convert.ToInt32(dgvSach.CurrentRow.Cells["ID"].Value.ToString());
                cboTenSach.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTheLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTheLoai.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cboNhaXuatBan.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNhaXuatBan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cboTenSach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenSach.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTacGia.Text))
            {
                MessageBox.Show("Vui lòng nhập tác giả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTacGia.Focus();
                return;
            }

            if (numGiaBan.Value <= 0)
            {
                MessageBox.Show("Giá bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numGiaBan.Focus();
                return;
            }

            try
            {
                string tenFileHinhAnh = picHinhAnh.Tag != null ? picHinhAnh.Tag.ToString()! : "";

                if (xuLyThem)
                {
                    bool tonTai = context.Sach.Any(r =>
                        r.TenSach == cboTenSach.Text.Trim() &&
                        r.TacGia == txtTacGia.Text.Trim() &&
                        r.NhaXuatBanID == Convert.ToInt32(cboNhaXuatBan.SelectedValue));

                    if (tonTai)
                    {
                        MessageBox.Show("Sách đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboTenSach.Focus();
                        return;
                    }

                    Sach s = new Sach();
                    s.MaSach = txtMaSach.Text.Trim();
                    s.TheLoaiID = Convert.ToInt32(cboTheLoai.SelectedValue);
                    s.NhaXuatBanID = Convert.ToInt32(cboNhaXuatBan.SelectedValue);
                    s.TenSach = cboTenSach.Text.Trim();
                    s.TacGia = txtTacGia.Text.Trim();
                    s.GiaNhap = numGiaNhap.Value;
                    s.GiaBan = numGiaBan.Value;
                    s.SoLuongTon = Convert.ToInt32(numSoLuongTon.Value);
                    s.HinhAnh = tenFileHinhAnh;
                    s.MoTa = txtMoTa.Text.Trim();
                    s.TrangThai = numSoLuongTon.Value > 0 ? "Còn hàng" : "Hết hàng";

                    context.Sach.Add(s);
                    context.SaveChanges();

                    NhatKyHelper.GhiLog(
                        "Thêm",
                        "Sach",
                        s.ID.ToString(),
                        "Thêm sách: " + s.TenSach
                    );
                }
                else
                {
                    Sach? s = context.Sach.Find(id);
                    if (s != null)
                    {
                        bool tonTai = context.Sach.Any(r =>
                            r.TenSach == cboTenSach.Text.Trim() &&
                            r.TacGia == txtTacGia.Text.Trim() &&
                            r.NhaXuatBanID == Convert.ToInt32(cboNhaXuatBan.SelectedValue) &&
                            r.ID != id);

                        if (tonTai)
                        {
                            MessageBox.Show("Sách đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboTenSach.Focus();
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(tenFileHinhAnh))
                            tenFileHinhAnh = s.HinhAnh ?? "";

                        s.TheLoaiID = Convert.ToInt32(cboTheLoai.SelectedValue);
                        s.NhaXuatBanID = Convert.ToInt32(cboNhaXuatBan.SelectedValue);
                        s.TenSach = cboTenSach.Text.Trim();
                        s.TacGia = txtTacGia.Text.Trim();
                        s.GiaNhap = numGiaNhap.Value;
                        s.GiaBan = numGiaBan.Value;
                        s.SoLuongTon = Convert.ToInt32(numSoLuongTon.Value);
                        s.HinhAnh = tenFileHinhAnh;
                        s.MoTa = txtMoTa.Text.Trim();
                        s.TrangThai = numSoLuongTon.Value > 0 ? "Còn hàng" : "Hết hàng";

                        context.Sach.Update(s);
                        context.SaveChanges();

                        NhatKyHelper.GhiLog(
                            "Sửa",
                            "Sach",
                            s.ID.ToString(),
                            "Sửa sách: " + s.TenSach
                        );
                    }
                }

                TaiLaiToanBoDuLieu();
                BatTatChucNang(false);
                xuLyThem = false;
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
            if (dgvSach.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa sách " + cboTenSach.Text + "?", "Xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        id = Convert.ToInt32(dgvSach.CurrentRow.Cells["ID"].Value.ToString());
                        Sach? s = context.Sach.Find(id);
                        if (s != null)
                        {
                            string khoaChinh = s.ID.ToString();
                            string tenSach = s.TenSach;

                            context.Sach.Remove(s);
                            context.SaveChanges();

                            NhatKyHelper.GhiLog(
                                "Xóa",
                                "Sach",
                                khoaChinh,
                                "Xóa sách: " + tenSach
                            );
                        }

                        TaiLaiToanBoDuLieu();
                        BatTatChucNang(false);
                        xuLyThem = false;
                    }
                    catch (Exception ex)
                    {
                        string loi = ex.Message;

                        if (ex.InnerException != null)
                            loi += "\n\n" + ex.InnerException.Message;

                        if (ex.InnerException != null && ex.InnerException.InnerException != null)
                            loi += "\n\n" + ex.InnerException.InnerException.Message;

                        MessageBox.Show("Không thể xóa sách này.\n" + loi, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            TaiLaiToanBoDuLieu();
            BatTatChucNang(false);
            xuLyThem = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = cboTenSach.Text.Trim();

            IQueryable<Sach> query = context.Sach.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                query = query.Where(r => EF.Functions.Like(r.TenSach, tuKhoa + "%"));
            }

            List<DanhSachSach> dsSach = query
                .Select(r => new DanhSachSach
                {
                    ID = r.ID,
                    TheLoaiID = r.TheLoaiID,
                    TenTheLoai = r.TheLoai.TenTheLoai,
                    NhaXuatBanID = r.NhaXuatBanID,
                    TenNhaXuatBan = r.NhaXuatBan.TenNhaXuatBan,
                    MaSach = r.MaSach,
                    TenSach = r.TenSach,
                    TacGia = r.TacGia,
                    GiaNhap = r.GiaNhap,
                    GiaBan = r.GiaBan,
                    SoLuongTon = r.SoLuongTon,
                    HinhAnh = r.HinhAnh,
                    MoTa = r.MoTa,
                    TrangThai = r.TrangThai
                })
                .OrderBy(r => r.ID)
                .ToList();

            GanBinding(dsSach);

            if (dsSach.Count > 0)
            {
                id = dsSach[0].ID;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXuat.Enabled = true;

                NhatKyHelper.GhiLog(
                    "Tìm kiếm",
                    "Sach",
                    null,
                    "Tìm kiếm sách với từ khóa: " + cboTenSach.Text.Trim()
                );
            }
            else
            {
                id = 0;
                txtMaSach.Clear();
                txtTacGia.Clear();
                txtMoTa.Clear();
                numSoLuongTon.Value = 0;
                numGiaNhap.Value = 0;
                numGiaBan.Value = 0;
                picHinhAnh.Image = null;
                picHinhAnh.ImageLocation = null;
                picHinhAnh.Tag = null;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnXuat.Enabled = false;

                MessageBox.Show("Không tìm thấy sách phù hợp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboTenSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void cboTenSach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (btnLuu.Enabled)
                NapThongTinTheoTenSach();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sách";
            openFileDialog.Filter = "Tập tin ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!Directory.Exists(imagesFolder))
                        Directory.CreateDirectory(imagesFolder);

                    string tenFile = Path.GetFileName(openFileDialog.FileName);
                    string duongDanMoi = Path.Combine(imagesFolder, tenFile);

                    picHinhAnh.ImageLocation = null;
                    if (picHinhAnh.Image != null)
                    {
                        picHinhAnh.Image.Dispose();
                        picHinhAnh.Image = null;
                    }

                    if (!string.Equals(openFileDialog.FileName, duongDanMoi, StringComparison.OrdinalIgnoreCase))
                    {
                        File.Copy(openFileDialog.FileName, duongDanMoi, true);
                    }

                    using (FileStream fs = new FileStream(duongDanMoi, FileMode.Open, FileAccess.Read))
                    {
                        picHinhAnh.Image = Image.FromStream(fs);
                    }

                    picHinhAnh.Tag = tenFile;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSach.Rows[e.RowIndex].Cells["ID"].Value != null)
                id = Convert.ToInt32(dgvSach.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }

        private void dgvSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSach.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null)
            {
                string tenFile = e.Value.ToString() ?? "";
                string duongDan = Path.Combine(imagesFolder, tenFile);

                if (File.Exists(duongDan))
                {
                    using MemoryStream ms = new MemoryStream(File.ReadAllBytes(duongDan));
                    e.Value = Image.FromStream(ms);
                }
                else
                {
                    e.Value = null;
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
                    }

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để nhập.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int soLonNhat = 0;
                    if (context.Sach.Any())
                    {
                        soLonNhat = context.Sach
                            .AsEnumerable()
                            .Select(r =>
                            {
                                if (string.IsNullOrWhiteSpace(r.MaSach))
                                    return 0;

                                string so = new string(r.MaSach.Where(char.IsDigit).ToArray());
                                return int.TryParse(so, out int kq) ? kq : 0;
                            })
                            .DefaultIfEmpty(0)
                            .Max();
                    }

                    int soLuongThemMoi = 0;

                    foreach (DataRow row in table.Rows)
                    {
                        string tenTheLoai = table.Columns.Contains("TenTheLoai") ? row["TenTheLoai"].ToString()!.Trim() : "";
                        string tenNxb = table.Columns.Contains("TenNhaXuatBan") ? row["TenNhaXuatBan"].ToString()!.Trim() : "";
                        string tenSach = table.Columns.Contains("TenSach") ? row["TenSach"].ToString()!.Trim() : "";
                        string tacGia = table.Columns.Contains("TacGia") ? row["TacGia"].ToString()!.Trim() : "";
                        string moTa = table.Columns.Contains("MoTa") ? row["MoTa"].ToString()!.Trim() : "";
                        string hinhAnh = table.Columns.Contains("HinhAnh") ? row["HinhAnh"].ToString()!.Trim() : "";

                        decimal giaNhap = 0;
                        decimal giaBan = 0;
                        int soLuongTon = 0;

                        if (table.Columns.Contains("GiaNhap"))
                            decimal.TryParse(row["GiaNhap"].ToString(), out giaNhap);

                        if (table.Columns.Contains("GiaBan"))
                            decimal.TryParse(row["GiaBan"].ToString(), out giaBan);

                        if (table.Columns.Contains("SoLuongTon"))
                            int.TryParse(row["SoLuongTon"].ToString(), out soLuongTon);

                        if (string.IsNullOrWhiteSpace(tenSach))
                            continue;

                        TheLoai? theLoai = context.TheLoai.FirstOrDefault(r => r.TenTheLoai == tenTheLoai);
                        if (theLoai == null && !string.IsNullOrWhiteSpace(tenTheLoai))
                        {
                            theLoai = new TheLoai
                            {
                                TenTheLoai = tenTheLoai
                            };
                            context.TheLoai.Add(theLoai);
                            context.SaveChanges();
                        }

                        NhaXuatBan? nxb = context.NhaXuatBan.FirstOrDefault(r => r.TenNhaXuatBan == tenNxb);
                        if (nxb == null && !string.IsNullOrWhiteSpace(tenNxb))
                        {
                            nxb = new NhaXuatBan
                            {
                                TenNhaXuatBan = tenNxb
                            };
                            context.NhaXuatBan.Add(nxb);
                            context.SaveChanges();
                        }

                        bool tonTai = context.Sach.Any(r => r.TenSach == tenSach && r.TacGia == tacGia);
                        if (tonTai)
                            continue;

                        soLonNhat++;

                        Sach s = new Sach();
                        s.MaSach = "S" + soLonNhat.ToString("000");
                        s.TheLoaiID = theLoai != null ? theLoai.ID : context.TheLoai.First().ID;
                        s.NhaXuatBanID = nxb != null ? nxb.ID : context.NhaXuatBan.First().ID;
                        s.TenSach = tenSach;
                        s.TacGia = tacGia;
                        s.GiaNhap = giaNhap;
                        s.GiaBan = giaBan;
                        s.SoLuongTon = soLuongTon;
                        s.MoTa = moTa;
                        s.HinhAnh = hinhAnh;
                        s.TrangThai = soLuongTon > 0 ? "Còn hàng" : "Hết hàng";

                        context.Sach.Add(s);
                        soLuongThemMoi++;
                    }

                    context.SaveChanges();

                    NhatKyHelper.GhiLog(
                        "Nhập Excel",
                        "Sach",
                        null,
                        "Nhập Excel sách, thêm mới " + soLuongThemMoi + " dòng."
                    );

                    TaiLaiToanBoDuLieu();
                    BatTatChucNang(false);
                    xuLyThem = false;

                    MessageBox.Show("Nhập Excel thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            saveFileDialog.FileName = "DanhSachSach.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<DanhSachSach> dsSach = context.Sach
                        .AsNoTracking()
                        .Select(r => new DanhSachSach
                        {
                            ID = r.ID,
                            TheLoaiID = r.TheLoaiID,
                            TenTheLoai = r.TheLoai.TenTheLoai,
                            NhaXuatBanID = r.NhaXuatBanID,
                            TenNhaXuatBan = r.NhaXuatBan.TenNhaXuatBan,
                            MaSach = r.MaSach,
                            TenSach = r.TenSach,
                            TacGia = r.TacGia,
                            GiaNhap = r.GiaNhap,
                            GiaBan = r.GiaBan,
                            SoLuongTon = r.SoLuongTon,
                            HinhAnh = r.HinhAnh,
                            MoTa = r.MoTa,
                            TrangThai = r.TrangThai
                        }).OrderBy(r => r.ID).ToList();

                    using XLWorkbook workbook = new XLWorkbook();
                    IXLWorksheet worksheet = workbook.Worksheets.Add("Sach");

                    worksheet.Cell(1, 1).Value = "MaSach";
                    worksheet.Cell(1, 2).Value = "TenTheLoai";
                    worksheet.Cell(1, 3).Value = "TenNhaXuatBan";
                    worksheet.Cell(1, 4).Value = "TenSach";
                    worksheet.Cell(1, 5).Value = "TacGia";
                    worksheet.Cell(1, 6).Value = "GiaNhap";
                    worksheet.Cell(1, 7).Value = "GiaBan";
                    worksheet.Cell(1, 8).Value = "SoLuongTon";
                    worksheet.Cell(1, 9).Value = "MoTa";
                    worksheet.Cell(1, 10).Value = "HinhAnh";

                    int dong = 2;
                    foreach (DanhSachSach item in dsSach)
                    {
                        worksheet.Cell(dong, 1).Value = item.MaSach;
                        worksheet.Cell(dong, 2).Value = item.TenTheLoai;
                        worksheet.Cell(dong, 3).Value = item.TenNhaXuatBan;
                        worksheet.Cell(dong, 4).Value = item.TenSach;
                        worksheet.Cell(dong, 5).Value = item.TacGia;
                        worksheet.Cell(dong, 6).Value = item.GiaNhap;
                        worksheet.Cell(dong, 7).Value = item.GiaBan;
                        worksheet.Cell(dong, 8).Value = item.SoLuongTon;
                        worksheet.Cell(dong, 9).Value = item.MoTa;
                        worksheet.Cell(dong, 10).Value = item.HinhAnh;
                        dong++;
                    }

                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(saveFileDialog.FileName);

                    NhatKyHelper.GhiLog(
                        "Xuất Excel",
                        "Sach",
                        null,
                        "Xuất danh sách sách ra Excel, số dòng: " + dsSach.Count
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
