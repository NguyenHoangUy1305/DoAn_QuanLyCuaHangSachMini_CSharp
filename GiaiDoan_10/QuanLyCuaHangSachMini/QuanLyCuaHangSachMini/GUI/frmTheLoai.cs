using ClosedXML.Excel;
using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmTheLoai : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private readonly BindingSource bindingSource = new BindingSource();
        private bool xuLyThem = false;
        private int idSelected = 0; // Lưu ID đang chọn để sửa/xóa

        public frmTheLoai()
        {
            InitializeComponent();
        }

        // Giải phóng bộ nhớ khi đóng form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            bindingSource.Dispose();
            context.Dispose();
            base.OnFormClosed(e);
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            dgvTheLoai.AutoGenerateColumns = false;

            // CẤU HÌNH COMBOBOX: Cho phép gõ chữ mới và tự động gợi ý
            cboTenTheLoai.DropDownStyle = ComboBoxStyle.DropDown;
            cboTenTheLoai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenTheLoai.AutoCompleteSource = AutoCompleteSource.ListItems;

            LoadData();
            BatTatChucNang(false);
        }

        private void BatTatChucNang(bool đangThaoTac)
        {
            // Các ô nhập liệu
            txtMaTheLoai.Enabled = false; // Mã không cho sửa thủ công
            cboTenTheLoai.Enabled = true; // Luôn bật để có thể tìm kiếm ngay, không cần bấm Thêm
            txtMoTa.Enabled = đangThaoTac;
            cboTenTheLoai.DropDownStyle = ComboBoxStyle.DropDown;
            cboTenTheLoai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenTheLoai.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTenTheLoai.KeyDown += cboTenTheLoai_KeyDown;

            // Các nút điều khiển
            btnLuu.Enabled = đangThaoTac;
            btnHuyBo.Enabled = đangThaoTac;

            btnThem.Enabled = !đangThaoTac;
            btnSua.Enabled = !đangThaoTac;
            btnXoa.Enabled = !đangThaoTac;
            btnTimKiem.Enabled = !đangThaoTac;
            btnNhap.Enabled = !đangThaoTac;
            btnXuat.Enabled = !đangThaoTac;

            dgvTheLoai.Enabled = !đangThaoTac;
        }

        private List<TheLoai> LayDanhSachTheLoai(string tuKhoa = "")
        {
            var query = context.TheLoai.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                string keyword = tuKhoa.Trim();
                string pattern = $"%{keyword}%";
                query = query.Where(x =>
                    EF.Functions.Like(x.TenTheLoai ?? string.Empty, pattern) ||
                    EF.Functions.Like(x.MaTheLoai ?? string.Empty, pattern));
            }

            return query.OrderBy(t => t.MaTheLoai).ToList();
        }

        private void NapDanhSachTenTheLoai()
        {
            var danhSachTen = context.TheLoai
                .AsNoTracking()
                .Where(x => !string.IsNullOrWhiteSpace(x.TenTheLoai))
                .Select(x => x.TenTheLoai.Trim())
                .Distinct()
                .OrderBy(x => x)
                .ToArray();

            cboTenTheLoai.BeginUpdate();
            cboTenTheLoai.Items.Clear();
            cboTenTheLoai.Items.AddRange(danhSachTen);
            cboTenTheLoai.EndUpdate();
        }

        private void LoadData()
        {
            try
            {
                // Lấy dữ liệu từ Database
                var list = LayDanhSachTheLoai();
                bindingSource.DataSource = list;
                dgvTheLoai.DataSource = bindingSource;

                // Xóa binding cũ và thiết lập binding mới cho các control
                txtMaTheLoai.DataBindings.Clear();
                txtMaTheLoai.DataBindings.Add("Text", bindingSource, "MaTheLoai", true, DataSourceUpdateMode.Never);

                cboTenTheLoai.DataBindings.Clear();
                cboTenTheLoai.DataBindings.Add("Text", bindingSource, "TenTheLoai", true, DataSourceUpdateMode.Never);

                txtMoTa.DataBindings.Clear();
                txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", true, DataSourceUpdateMode.Never);

                NapDanhSachTenTheLoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string TaoMaTheLoaiMoi()
        {
            int soLonNhat = context.TheLoai
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

            return $"TL{soLonNhat + 1:000}";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            // Xóa trắng các ô nhập
            txtMaTheLoai.Text = TaoMaTheLoaiMoi();
            cboTenTheLoai.SelectedIndex = -1;
            cboTenTheLoai.DroppedDown = false;
            cboTenTheLoai.Text = "";
            txtMoTa.Text = "";

            cboTenTheLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            var item = (TheLoai)bindingSource.Current;
            idSelected = item.ID;

            xuLyThem = false;
            BatTatChucNang(true);
            cboTenTheLoai.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTenTheLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    // Thêm mới
                    string maTheLoai = txtMaTheLoai.Text.Trim();
                    if (string.IsNullOrWhiteSpace(maTheLoai))
                    {
                        maTheLoai = TaoMaTheLoaiMoi();
                        txtMaTheLoai.Text = maTheLoai;
                    }

                    TheLoai moi = new TheLoai
                    {
                        MaTheLoai = maTheLoai,
                        TenTheLoai = cboTenTheLoai.Text.Trim(),
                        MoTa = txtMoTa.Text.Trim()
                    };
                    context.TheLoai.Add(moi);

                    NhatKyHelper.GhiLog("Thêm", "TheLoai", moi.MaTheLoai, $"Thêm mới thể loại: {moi.TenTheLoai}");
                }
                else
                {
                    // Cập nhật
                    var item = context.TheLoai.Find(idSelected);
                    if (item != null)
                    {
                        item.TenTheLoai = cboTenTheLoai.Text.Trim();
                        item.MoTa = txtMoTa.Text.Trim();

                        NhatKyHelper.GhiLog("Sửa", "TheLoai", item.MaTheLoai, $"Sửa thể loại thành: {item.TenTheLoai}");
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");
                BatTatChucNang(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;
            var item = (TheLoai)bindingSource.Current;

            var confirm = MessageBox.Show($"Xác nhận xóa thể loại: {item.TenTheLoai}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    context.TheLoai.Remove(item);
                    context.SaveChanges();
                    NhatKyHelper.GhiLog("Xóa", "TheLoai", item.MaTheLoai, $"Xóa thể loại: {item.TenTheLoai}");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Không thể xóa thể loại này vì đang có sách thuộc thể loại này!");
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            idSelected = 0;
            BatTatChucNang(false);
            bindingSource.ResetBindings(false); // Trả lại dữ liệu ban đầu
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!btnTimKiem.Enabled)
                return;

            string search = cboTenTheLoai.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(search))
            {
                LoadData();
                return;
            }

            var result = LayDanhSachTheLoai(search);
            bindingSource.DataSource = result;
            dgvTheLoai.DataSource = bindingSource;

            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thể loại phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboTenTheLoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || !btnTimKiem.Enabled)
                return;

            e.SuppressKeyPress = true;
            btnTimKiem.PerformClick();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var data = context.TheLoai.Select(x => new { x.MaTheLoai, x.TenTheLoai, x.MoTa }).ToList();
                            var ws = wb.Worksheets.Add("TheLoai");
                            ws.Cell(1, 1).InsertTable(data);
                            ws.Columns().AdjustToContents();
                            wb.SaveAs(sfd.FileName);
                        }
                        NhatKyHelper.GhiLog("Xuất Excel", "TheLoai", null, "Xuất danh sách thể loại");
                        MessageBox.Show("Xuất file thành công!");
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook(ofd.FileName))
                        {
                            var rows = wb.Worksheet(1).RangeUsed().RowsUsed().Skip(1);
                            foreach (var row in rows)
                            {
                                string ma = row.Cell(1).Value.ToString();
                                if (!context.TheLoai.Any(x => x.MaTheLoai == ma))
                                {
                                    context.TheLoai.Add(new TheLoai
                                    {
                                        MaTheLoai = ma,
                                        TenTheLoai = row.Cell(2).Value.ToString(),
                                        MoTa = row.Cell(3).Value.ToString()
                                    });
                                }
                            }
                            context.SaveChanges();
                            LoadData();
                            MessageBox.Show("Nhập dữ liệu thành công!");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi nhập file: " + ex.Message); }
                }
            }
        }
    }
}
