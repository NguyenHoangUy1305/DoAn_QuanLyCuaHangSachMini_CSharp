using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.DTOs;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmHoaDon : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        private int id;

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            HienThiDanhSachHoaDon();
        }

        private void HienThiDanhSachHoaDon()
        {
            List<DanhSachHoaDon> hd = context.HoaDon
                .Select(r => new DanhSachHoaDon
                {
                    ID = r.ID,
                    MaHoaDon = r.MaHoaDon,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    KhachHangID = r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (decimal?)ct.SoLuongBan * ct.DonGiaBan) ?? 0,
                    XemChiTiet = "Xem chi tiết"
                })
                .OrderBy(r => r.ID)
                .ToList();

            dataGridView.DataSource = null;
            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }
            HienThiDanhSachHoaDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());

            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id, false))
            {
                chiTiet.ShowDialog();
            }
            HienThiDanhSachHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hóa đơn này không?\nKhi xóa sẽ xóa luôn chi tiết hóa đơn.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                HoaDon? hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    List<HoaDon_ChiTiet> chiTiet = context.HoaDon_ChiTiet
                        .Where(r => r.HoaDonID == id)
                        .ToList();

                    context.HoaDon_ChiTiet.RemoveRange(chiTiet);
                    context.HoaDon.Remove(hd);
                    context.SaveChanges();

                    MessageBox.Show("Đã xóa hóa đơn thành công.", "Hoàn tất",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HienThiDanhSachHoaDon();
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id, true))
                {
                    chiTiet.ShowDialog();
                }
                HienThiDanhSachHoaDon();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần in hóa đơn bạn làm sau như yêu cầu.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần tìm kiếm bạn làm sau như yêu cầu.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần xuất Excel bạn làm sau như yêu cầu.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}