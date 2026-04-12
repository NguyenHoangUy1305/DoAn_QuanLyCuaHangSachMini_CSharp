using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmDoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblNhanVien = new Label();
            cboNhanVien = new ComboBox();
            lblMatKhauMoi = new Label();
            txtMatKhauMoi = new TextBox();
            lblXacNhan = new Label();
            txtXacNhan = new TextBox();
            btnCapNhat = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 10F);
            lblNhanVien.Location = new Point(24, 24);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(90, 23);
            lblNhanVien.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.Font = new Font("Segoe UI", 10F);
            cboNhanVien.Location = new Point(24, 50);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(360, 31);
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Segoe UI", 10F);
            lblMatKhauMoi.Location = new Point(24, 95);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(108, 23);
            lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 10F);
            txtMatKhauMoi.Location = new Point(24, 121);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(360, 30);
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblXacNhan
            // 
            lblXacNhan.AutoSize = true;
            lblXacNhan.Font = new Font("Segoe UI", 10F);
            lblXacNhan.Location = new Point(24, 165);
            lblXacNhan.Name = "lblXacNhan";
            lblXacNhan.Size = new Size(128, 23);
            lblXacNhan.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacNhan
            // 
            txtXacNhan.Font = new Font("Segoe UI", 10F);
            txtXacNhan.Location = new Point(24, 191);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.Size = new Size(360, 30);
            txtXacNhan.UseSystemPasswordChar = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(71, 51, 255);
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(204, 240);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(90, 32);
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThoat.ForeColor = Color.FromArgb(71, 51, 255);
            btnThoat.Location = new Point(304, 240);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 32);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 290);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(txtXacNhan);
            Controls.Add(lblXacNhan);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(cboNhanVien);
            Controls.Add(lblNhanVien);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDoiMatKhau";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi mật khẩu cho nhân viên";
            Load += frmDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhanVien;
        private ComboBox cboNhanVien;
        private Label lblMatKhauMoi;
        private TextBox txtMatKhauMoi;
        private Label lblXacNhan;
        private TextBox txtXacNhan;
        private Button btnCapNhat;
        private Button btnThoat;
    }
}
