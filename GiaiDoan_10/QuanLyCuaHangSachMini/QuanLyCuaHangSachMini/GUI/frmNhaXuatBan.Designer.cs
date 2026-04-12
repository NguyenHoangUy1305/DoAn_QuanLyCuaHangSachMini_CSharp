namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmNhaXuatBan
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
            grpThongTinNXB = new GroupBox();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
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
            cboTenNhaXuatBan = new ComboBox();
            txtMaNhaXuatBan = new TextBox();
            lblTenNXB = new Label();
            lblMaXB = new Label();
            grpDanhSachNXB = new GroupBox();
            dgvNhaXuatBan = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaNhaXuatBan = new DataGridViewTextBoxColumn();
            TenNhaXuatBan = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            grpThongTinNXB.SuspendLayout();
            grpDanhSachNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaXuatBan).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinNXB
            // 
            grpThongTinNXB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinNXB.BackColor = Color.White;
            grpThongTinNXB.Controls.Add(txtDiaChi);
            grpThongTinNXB.Controls.Add(lblDiaChi);
            grpThongTinNXB.Controls.Add(txtEmail);
            grpThongTinNXB.Controls.Add(lblEmail);
            grpThongTinNXB.Controls.Add(txtDienThoai);
            grpThongTinNXB.Controls.Add(lblDienThoai);
            grpThongTinNXB.Controls.Add(btnXuat);
            grpThongTinNXB.Controls.Add(btnNhap);
            grpThongTinNXB.Controls.Add(btnThoat);
            grpThongTinNXB.Controls.Add(btnHuyBo);
            grpThongTinNXB.Controls.Add(btnSua);
            grpThongTinNXB.Controls.Add(btnLuu);
            grpThongTinNXB.Controls.Add(btnXoa);
            grpThongTinNXB.Controls.Add(btnThem);
            grpThongTinNXB.Controls.Add(btnTimKiem);
            grpThongTinNXB.Controls.Add(cboTenNhaXuatBan);
            grpThongTinNXB.Controls.Add(txtMaNhaXuatBan);
            grpThongTinNXB.Controls.Add(lblTenNXB);
            grpThongTinNXB.Controls.Add(lblMaXB);
            grpThongTinNXB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTinNXB.ForeColor = Color.FromArgb(55, 38, 210);
            grpThongTinNXB.Location = new Point(12, 12);
            grpThongTinNXB.Name = "grpThongTinNXB";
            grpThongTinNXB.Size = new Size(980, 185);
            grpThongTinNXB.TabIndex = 0;
            grpThongTinNXB.TabStop = false;
            grpThongTinNXB.Text = "Thông tin nhà xuất bản";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(151, 138);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(426, 30);
            txtDiaChi.TabIndex = 6;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10F);
            lblDiaChi.ForeColor = Color.FromArgb(33, 37, 41);
            lblDiaChi.Location = new Point(18, 141);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(66, 23);
            lblDiaChi.TabIndex = 18;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(494, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(99, 30);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(33, 37, 41);
            lblEmail.Location = new Point(439, 91);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Segoe UI", 10F);
            txtDienThoai.Location = new Point(451, 37);
            txtDienThoai.MaxLength = 10;
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(118, 30);
            txtDienThoai.TabIndex = 5;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Font = new Font("Segoe UI", 10F);
            lblDienThoai.ForeColor = Color.FromArgb(33, 37, 41);
            lblDienThoai.Location = new Point(352, 39);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(93, 23);
            lblDienThoai.TabIndex = 14;
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
            btnXuat.Location = new Point(857, 130);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(117, 34);
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
            btnNhap.Location = new Point(857, 78);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(117, 34);
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
            btnThoat.Location = new Point(751, 131);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 34);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
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
            btnHuyBo.Location = new Point(751, 81);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 34);
            btnHuyBo.TabIndex = 9;
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
            btnSua.Location = new Point(645, 131);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 34);
            btnSua.TabIndex = 8;
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
            btnLuu.Location = new Point(645, 81);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 34);
            btnLuu.TabIndex = 7;
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
            btnXoa.Location = new Point(751, 34);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 34);
            btnXoa.TabIndex = 6;
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
            btnThem.Location = new Point(645, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 34);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(71, 51, 255);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnTimKiem.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(333, 86);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 34);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboTenNhaXuatBan
            // 
            cboTenNhaXuatBan.BackColor = Color.White;
            cboTenNhaXuatBan.FlatStyle = FlatStyle.Flat;
            cboTenNhaXuatBan.Font = new Font("Segoe UI", 10F);
            cboTenNhaXuatBan.FormattingEnabled = true;
            cboTenNhaXuatBan.Location = new Point(167, 84);
            cboTenNhaXuatBan.Name = "cboTenNhaXuatBan";
            cboTenNhaXuatBan.Size = new Size(160, 31);
            cboTenNhaXuatBan.TabIndex = 3;
            // 
            // txtMaNhaXuatBan
            // 
            txtMaNhaXuatBan.BackColor = Color.FromArgb(248, 250, 252);
            txtMaNhaXuatBan.Font = new Font("Segoe UI", 10F);
            txtMaNhaXuatBan.Location = new Point(168, 34);
            txtMaNhaXuatBan.Name = "txtMaNhaXuatBan";
            txtMaNhaXuatBan.ReadOnly = true;
            txtMaNhaXuatBan.Size = new Size(160, 30);
            txtMaNhaXuatBan.TabIndex = 2;
            // 
            // lblTenNXB
            // 
            lblTenNXB.AutoSize = true;
            lblTenNXB.Font = new Font("Segoe UI", 10F);
            lblTenNXB.ForeColor = Color.FromArgb(33, 37, 41);
            lblTenNXB.Location = new Point(18, 89);
            lblTenNXB.Name = "lblTenNXB";
            lblTenNXB.Size = new Size(146, 23);
            lblTenNXB.TabIndex = 1;
            lblTenNXB.Text = "Tên nhà xuất bản:";
            // 
            // lblMaXB
            // 
            lblMaXB.AutoSize = true;
            lblMaXB.Font = new Font("Segoe UI", 10F);
            lblMaXB.ForeColor = Color.FromArgb(33, 37, 41);
            lblMaXB.Location = new Point(18, 37);
            lblMaXB.Name = "lblMaXB";
            lblMaXB.Size = new Size(144, 23);
            lblMaXB.TabIndex = 0;
            lblMaXB.Text = "Mã nhà xuất bản:";
            // 
            // grpDanhSachNXB
            // 
            grpDanhSachNXB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSachNXB.BackColor = Color.White;
            grpDanhSachNXB.Controls.Add(dgvNhaXuatBan);
            grpDanhSachNXB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSachNXB.ForeColor = Color.FromArgb(55, 38, 210);
            grpDanhSachNXB.Location = new Point(12, 203);
            grpDanhSachNXB.Name = "grpDanhSachNXB";
            grpDanhSachNXB.Size = new Size(980, 380);
            grpDanhSachNXB.TabIndex = 1;
            grpDanhSachNXB.TabStop = false;
            grpDanhSachNXB.Text = "Danh sách nhà xuất bản";
            // 
            // dgvNhaXuatBan
            // 
            dgvNhaXuatBan.AllowUserToAddRows = false;
            dgvNhaXuatBan.AllowUserToDeleteRows = false;
            dgvNhaXuatBan.AllowUserToResizeRows = false;
            dgvNhaXuatBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaXuatBan.BackgroundColor = Color.Silver;
            dgvNhaXuatBan.BorderStyle = BorderStyle.None;
            dgvNhaXuatBan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhaXuatBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhaXuatBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaXuatBan.Columns.AddRange(new DataGridViewColumn[] { ID, MaNhaXuatBan, TenNhaXuatBan, DienThoai, Email, DiaChi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNhaXuatBan.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhaXuatBan.Dock = DockStyle.Fill;
            dgvNhaXuatBan.EnableHeadersVisualStyles = false;
            dgvNhaXuatBan.GridColor = Color.FromArgb(226, 232, 240);
            dgvNhaXuatBan.Location = new Point(3, 26);
            dgvNhaXuatBan.MultiSelect = false;
            dgvNhaXuatBan.Name = "dgvNhaXuatBan";
            dgvNhaXuatBan.ReadOnly = true;
            dgvNhaXuatBan.RowHeadersVisible = false;
            dgvNhaXuatBan.RowHeadersWidth = 51;
            dgvNhaXuatBan.RowTemplate.Height = 32;
            dgvNhaXuatBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhaXuatBan.Size = new Size(974, 351);
            dgvNhaXuatBan.TabIndex = 0;
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
            // MaNhaXuatBan
            // 
            MaNhaXuatBan.DataPropertyName = "MaNhaXuatBan";
            MaNhaXuatBan.HeaderText = "Mã nhà xuất bản";
            MaNhaXuatBan.MinimumWidth = 6;
            MaNhaXuatBan.Name = "MaNhaXuatBan";
            MaNhaXuatBan.ReadOnly = true;
            // 
            // TenNhaXuatBan
            // 
            TenNhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            TenNhaXuatBan.HeaderText = "Tên nhà xuất bản";
            TenNhaXuatBan.MinimumWidth = 6;
            TenNhaXuatBan.Name = "TenNhaXuatBan";
            TenNhaXuatBan.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // frmNhaXuatBan
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1004, 595);
            Controls.Add(grpDanhSachNXB);
            Controls.Add(grpThongTinNXB);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1020, 640);
            Name = "frmNhaXuatBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhà xuất bản";
            Load += frmNhaXuatBan_Load;
            grpThongTinNXB.ResumeLayout(false);
            grpThongTinNXB.PerformLayout();
            grpDanhSachNXB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhaXuatBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinNXB;
        private GroupBox grpDanhSachNXB;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private Button btnTimKiem;
        private ComboBox cboTenNhaXuatBan;
        private TextBox txtMaNhaXuatBan;
        private TextBox txtDienThoai;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private Label lblTenNXB;
        private Label lblMaXB;
        private Label lblDienThoai;
        private Label lblEmail;
        private Label lblDiaChi;
        private DataGridView dgvNhaXuatBan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaNhaXuatBan;
        private DataGridViewTextBoxColumn TenNhaXuatBan;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
    }
}
