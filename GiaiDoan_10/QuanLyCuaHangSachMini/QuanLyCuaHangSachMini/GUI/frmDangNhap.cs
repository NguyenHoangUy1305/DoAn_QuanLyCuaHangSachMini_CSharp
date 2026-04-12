using QuanLyCuaHangSachMini.Data;
using QuanLyCuaHangSachMini.Data.Entity;
using QuanLyCuaHangSachMini.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

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
            string matKhau = txtMatKhau.Text;

            NhanVien? nv = context.NhanVien
                .FirstOrDefault(r => r.TenDangNhap == tenDangNhap);

            bool dangNhapHopLe = nv != null && PasswordHelper.VerifyPassword(matKhau, nv.MatKhau);

            if (!dangNhapHopLe || nv == null)
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

            if (PasswordHelper.ShouldUpgradeLegacyPassword(nv.MatKhau))
            {
                nv.MatKhau = PasswordHelper.HashPassword(matKhau);
                context.NhanVien.Update(nv);
                context.SaveChanges();
            }

            SessionHelper.GanDuLieu(nv);
            NhatKyHelper.GhiLog("Đăng nhập", "Hệ thống", nv.ID.ToString(), "Đăng nhập vào hệ thống");

            frmMain frm = new frmMain();
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
