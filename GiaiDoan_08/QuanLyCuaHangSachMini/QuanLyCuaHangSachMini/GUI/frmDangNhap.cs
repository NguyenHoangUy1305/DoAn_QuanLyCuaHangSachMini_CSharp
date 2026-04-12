using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.Helpers;

namespace QuanLyCuaHangSachMini.GUI
{
    public partial class frmDangNhap : Form
    {
        private readonly AppDbContext context = new AppDbContext();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return;
            }

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            NhanVien? nv = context.NhanVien
                .FirstOrDefault(r => r.TenDangNhap == tenDangNhap && r.MatKhau == matKhau);

            if (nv == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.SelectAll();
                txtMatKhau.Focus();
                return;
            }

            if (!nv.KichHoat)
            {
                MessageBox.Show("Tài khoản này đã bị khóa hoặc ngừng hoạt động.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SessionHelper.GanDuLieu(nv);

            NhatKyHelper.GhiLog(
                "Đăng nhập",
                "Hệ thống",
                nv.ID.ToString(),
                "Đăng nhập vào hệ thống"
            );

            MessageBox.Show("Đăng nhập thành công.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}