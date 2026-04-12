using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmDangNhap
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnLoginLeft;
        private Panel pnLoginRight;
        private Label lblLogo;
        private Label lblSubLogo;
        private Label lblTitle;
        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnHuyBo;
        private Label lblHint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            pnLoginLeft = new Panel();
            lblSubLogo = new Label();
            lblLogo = new Label();
            pnLoginRight = new Panel();
            lblHint = new Label();
            btnHuyBo = new Button();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            lblTenDangNhap = new Label();
            lblTitle = new Label();
            pnLoginLeft.SuspendLayout();
            pnLoginRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnLoginLeft
            // 
            pnLoginLeft.BackColor = Color.FromArgb(71, 51, 255);
            pnLoginLeft.Controls.Add(lblSubLogo);
            pnLoginLeft.Controls.Add(lblLogo);
            pnLoginLeft.Dock = DockStyle.Left;
            pnLoginLeft.Location = new Point(0, 0);
            pnLoginLeft.Name = "pnLoginLeft";
            pnLoginLeft.Size = new Size(280, 520);
            pnLoginLeft.TabIndex = 0;
            // 
            // lblSubLogo
            // 
            lblSubLogo.Font = new Font("Segoe UI", 10F);
            lblSubLogo.ForeColor = Color.White;
            lblSubLogo.Location = new Point(0, 205);
            lblSubLogo.Name = "lblSubLogo";
            lblSubLogo.Size = new Size(280, 30);
            lblSubLogo.TabIndex = 1;
            lblSubLogo.Text = "Quản lý cửa hàng sách mini";
            lblSubLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 160);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(280, 45);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "BOOKSTORE";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnLoginRight
            // 
            pnLoginRight.BackColor = Color.White;
            pnLoginRight.Controls.Add(lblHint);
            pnLoginRight.Controls.Add(btnHuyBo);
            pnLoginRight.Controls.Add(btnDangNhap);
            pnLoginRight.Controls.Add(txtMatKhau);
            pnLoginRight.Controls.Add(txtTenDangNhap);
            pnLoginRight.Controls.Add(lblMatKhau);
            pnLoginRight.Controls.Add(lblTenDangNhap);
            pnLoginRight.Controls.Add(lblTitle);
            pnLoginRight.Dock = DockStyle.Fill;
            pnLoginRight.Location = new Point(280, 0);
            pnLoginRight.Name = "pnLoginRight";
            pnLoginRight.Size = new Size(500, 520);
            pnLoginRight.TabIndex = 1;
            // 
            // lblHint
            // 
            lblHint.Font = new Font("Segoe UI", 9F);
            lblHint.ForeColor = Color.FromArgb(68, 68, 68);
            lblHint.Location = new Point(60, 465);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(380, 25);
            lblHint.TabIndex = 9;
            lblHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.White;
            btnHuyBo.FlatAppearance.BorderColor = Color.FromArgb(71, 51, 255);
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.FromArgb(71, 51, 255);
            btnHuyBo.Location = new Point(60, 410);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(380, 44);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "HỦY BỎ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(71, 51, 255);
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(60, 355);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(380, 44);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "ÐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.White;
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.ForeColor = Color.Black;
            txtMatKhau.Location = new Point(60, 280);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '?';
            txtMatKhau.Size = new Size(380, 32);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.White;
            txtTenDangNhap.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.ForeColor = Color.Black;
            txtTenDangNhap.Location = new Point(60, 185);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(380, 32);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 11F);
            lblMatKhau.ForeColor = Color.Black;
            lblMatKhau.Location = new Point(60, 250);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(91, 25);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 11F);
            lblTenDangNhap.ForeColor = Color.Black;
            lblTenDangNhap.Location = new Point(60, 155);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(137, 25);
            lblTenDangNhap.TabIndex = 2;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(71, 51, 255);
            lblTitle.Location = new Point(60, 76);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(228, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ÐĂNG NHẬP";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 520);
            Controls.Add(pnLoginRight);
            Controls.Add(pnLoginLeft);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ CỬA HÀNG SÁCH-NGUYỄN HOÀNG UY";
            Load += frmDangNhap_Load;
            pnLoginLeft.ResumeLayout(false);
            pnLoginRight.ResumeLayout(false);
            pnLoginRight.PerformLayout();
            ResumeLayout(false);
        }
    }
}

