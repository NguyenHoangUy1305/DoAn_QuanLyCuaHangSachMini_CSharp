namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grpThongTinNhanVien = new GroupBox();
            chkKichHoat = new CheckBox();
            chkQuyenHan = new CheckBox();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            txtDienThoai = new TextBox();
            lblDienThoai = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            cboHoVaTen = new ComboBox();
            txtMaNhanVien = new TextBox();
            lblHoVaTen = new Label();
            lblMaNhanVien = new Label();
            grpDanhSachNhanVien = new GroupBox();
            dgvNhanVien = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewCheckBoxColumn();
            KichHoat = new DataGridViewCheckBoxColumn();
            grpThongTinNhanVien.SuspendLayout();
            grpDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinNhanVien
            // 
            grpThongTinNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinNhanVien.BackColor = Color.White;
            grpThongTinNhanVien.Controls.Add(chkKichHoat);
            grpThongTinNhanVien.Controls.Add(chkQuyenHan);
            grpThongTinNhanVien.Controls.Add(txtMatKhau);
            grpThongTinNhanVien.Controls.Add(lblMatKhau);
            grpThongTinNhanVien.Controls.Add(txtTenDangNhap);
            grpThongTinNhanVien.Controls.Add(lblTenDangNhap);
            grpThongTinNhanVien.Controls.Add(txtDienThoai);
            grpThongTinNhanVien.Controls.Add(lblDienThoai);
            grpThongTinNhanVien.Controls.Add(btnXuat);
            grpThongTinNhanVien.Controls.Add(btnNhap);
            grpThongTinNhanVien.Controls.Add(btnThoat);
            grpThongTinNhanVien.Controls.Add(btnHuyBo);
            grpThongTinNhanVien.Controls.Add(btnSua);
            grpThongTinNhanVien.Controls.Add(btnLuu);
            grpThongTinNhanVien.Controls.Add(btnXoa);
            grpThongTinNhanVien.Controls.Add(btnThem);
            grpThongTinNhanVien.Controls.Add(btnTimKiem);
            grpThongTinNhanVien.Controls.Add(cboHoVaTen);
            grpThongTinNhanVien.Controls.Add(txtMaNhanVien);
            grpThongTinNhanVien.Controls.Add(lblHoVaTen);
            grpThongTinNhanVien.Controls.Add(lblMaNhanVien);
            grpThongTinNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTinNhanVien.ForeColor = Color.FromArgb(55, 38, 210);
            grpThongTinNhanVien.Location = new Point(12, 12);
            grpThongTinNhanVien.Name = "grpThongTinNhanVien";
            grpThongTinNhanVien.Size = new Size(980, 220);
            grpThongTinNhanVien.TabIndex = 0;
            grpThongTinNhanVien.TabStop = false;
            grpThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // chkKichHoat
            // 
            chkKichHoat.AutoSize = true;
            chkKichHoat.Font = new Font("Segoe UI", 10F);
            chkKichHoat.ForeColor = Color.FromArgb(33, 37, 41);
            chkKichHoat.Location = new Point(379, 138);
            chkKichHoat.Name = "chkKichHoat";
            chkKichHoat.Size = new Size(104, 27);
            chkKichHoat.TabIndex = 8;
            chkKichHoat.Text = "Kích hoạt";
            chkKichHoat.UseVisualStyleBackColor = true;
            // 
            // chkQuyenHan
            // 
            chkQuyenHan.AutoSize = true;
            chkQuyenHan.Font = new Font("Segoe UI", 10F);
            chkQuyenHan.ForeColor = Color.FromArgb(33, 37, 41);
            chkQuyenHan.Location = new Point(116, 138);
            chkQuyenHan.Name = "chkQuyenHan";
            chkQuyenHan.Size = new Size(131, 27);
            chkQuyenHan.TabIndex = 6;
            chkQuyenHan.Text = "Quản trị viên";
            chkQuyenHan.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.Location = new Point(116, 186);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(190, 30);
            txtMatKhau.TabIndex = 7;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.ForeColor = Color.FromArgb(33, 37, 41);
            lblMatKhau.Location = new Point(18, 189);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 23);
            lblMatKhau.TabIndex = 19;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10F);
            txtTenDangNhap.Location = new Point(454, 92);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(150, 30);
            txtTenDangNhap.TabIndex = 5;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10F);
            lblTenDangNhap.ForeColor = Color.FromArgb(33, 37, 41);
            lblTenDangNhap.Location = new Point(326, 95);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(128, 23);
            lblTenDangNhap.TabIndex = 17;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Segoe UI", 10F);
            txtDienThoai.Location = new Point(454, 48);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(150, 30);
            txtDienThoai.TabIndex = 4;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Font = new Font("Segoe UI", 10F);
            lblDienThoai.ForeColor = Color.FromArgb(33, 37, 41);
            lblDienThoai.Location = new Point(346, 51);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(93, 23);
            lblDienThoai.TabIndex = 15;
            lblDienThoai.Text = "Điện thoại:";
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuat.BackColor = Color.FromArgb(71, 51, 255);
            btnXuat.Cursor = Cursors.Hand;
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(859, 98);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(115, 30);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNhap.BackColor = Color.FromArgb(71, 51, 255);
            btnNhap.Cursor = Cursors.Hand;
            btnNhap.FlatAppearance.BorderSize = 0;
            btnNhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNhap.ForeColor = Color.White;
            btnNhap.Location = new Point(859, 51);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(115, 30);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThoat.BackColor = Color.White;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(71, 51, 255);
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 255);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 244, 255);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThoat.ForeColor = Color.FromArgb(71, 51, 255);
            btnThoat.Location = new Point(859, 149);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 30);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Đóng";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHuyBo.BackColor = Color.White;
            btnHuyBo.Cursor = Cursors.Hand;
            btnHuyBo.FlatAppearance.BorderColor = Color.FromArgb(71, 51, 255);
            btnHuyBo.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 255);
            btnHuyBo.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 244, 255);
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.FromArgb(71, 51, 255);
            btnHuyBo.Location = new Point(730, 149);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 30);
            btnHuyBo.TabIndex = 15;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.FromArgb(71, 51, 255);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnSua.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(620, 149);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 30);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.BackColor = Color.FromArgb(71, 51, 255);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnLuu.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(620, 98);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 30);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 25, 40);
            btnXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(730, 98);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 30);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(71, 51, 255);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnThem.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(620, 48);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 30);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKiem.BackColor = Color.FromArgb(71, 51, 255);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnTimKiem.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(730, 48);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 30);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboHoVaTen
            // 
            cboHoVaTen.BackColor = Color.White;
            cboHoVaTen.FlatStyle = FlatStyle.Flat;
            cboHoVaTen.Font = new Font("Segoe UI", 10F);
            cboHoVaTen.FormattingEnabled = true;
            cboHoVaTen.Location = new Point(116, 92);
            cboHoVaTen.Name = "cboHoVaTen";
            cboHoVaTen.Size = new Size(190, 31);
            cboHoVaTen.TabIndex = 3;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.BackColor = Color.FromArgb(248, 250, 252);
            txtMaNhanVien.Font = new Font("Segoe UI", 10F);
            txtMaNhanVien.Location = new Point(116, 48);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(190, 30);
            txtMaNhanVien.TabIndex = 2;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Font = new Font("Segoe UI", 10F);
            lblHoVaTen.ForeColor = Color.FromArgb(33, 37, 41);
            lblHoVaTen.Location = new Point(18, 95);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(88, 23);
            lblHoVaTen.TabIndex = 1;
            lblHoVaTen.Text = "Họ và tên:";
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Font = new Font("Segoe UI", 10F);
            lblMaNhanVien.ForeColor = Color.FromArgb(33, 37, 41);
            lblMaNhanVien.Location = new Point(18, 51);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(118, 23);
            lblMaNhanVien.TabIndex = 0;
            lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // grpDanhSachNhanVien
            // 
            grpDanhSachNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSachNhanVien.BackColor = Color.White;
            grpDanhSachNhanVien.Controls.Add(dgvNhanVien);
            grpDanhSachNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSachNhanVien.ForeColor = Color.FromArgb(55, 38, 210);
            grpDanhSachNhanVien.Location = new Point(12, 238);
            grpDanhSachNhanVien.Name = "grpDanhSachNhanVien";
            grpDanhSachNhanVien.Size = new Size(980, 396);
            grpDanhSachNhanVien.TabIndex = 1;
            grpDanhSachNhanVien.TabStop = false;
            grpDanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AllowUserToResizeRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { ID, MaNhanVien, HoVaTen, DienThoai, TenDangNhap, QuyenHan, KichHoat });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.GridColor = Color.FromArgb(226, 232, 240);
            dgvNhanVien.Location = new Point(3, 26);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 32;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(974, 367);
            dgvNhanVien.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quản trị viên";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // KichHoat
            // 
            KichHoat.DataPropertyName = "KichHoat";
            KichHoat.HeaderText = "Kích hoạt";
            KichHoat.MinimumWidth = 6;
            KichHoat.Name = "KichHoat";
            KichHoat.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1004, 646);
            Controls.Add(grpDanhSachNhanVien);
            Controls.Add(grpThongTinNhanVien);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1020, 685);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            Load += frmNhanVien_Load;
            grpThongTinNhanVien.ResumeLayout(false);
            grpThongTinNhanVien.PerformLayout();
            grpDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinNhanVien;
        private GroupBox grpDanhSachNhanVien;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private Button btnTimKiem;
        private ComboBox cboHoVaTen;
        private TextBox txtMaNhanVien;
        private TextBox txtDienThoai;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private CheckBox chkQuyenHan;
        private CheckBox chkKichHoat;
        private Label lblHoVaTen;
        private Label lblMaNhanVien;
        private Label lblDienThoai;
        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewCheckBoxColumn QuyenHan;
        private DataGridViewCheckBoxColumn KichHoat;
    }
}   
