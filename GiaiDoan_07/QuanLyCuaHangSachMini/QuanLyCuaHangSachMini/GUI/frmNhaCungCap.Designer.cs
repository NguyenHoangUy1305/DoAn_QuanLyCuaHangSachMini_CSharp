namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmNhaCungCap
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
            grpNCC = new GroupBox();
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
            cboTenNhaCungCap = new ComboBox();
            txtMaNhaCungCap = new TextBox();
            lblNCC = new Label();
            lblMaNCC = new Label();
            grpDSNCC = new GroupBox();
            dgvNhaCungCap = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaNhaCungCap = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            grpNCC.SuspendLayout();
            grpDSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // grpNCC
            // 
            grpNCC.Controls.Add(txtDiaChi);
            grpNCC.Controls.Add(lblDiaChi);
            grpNCC.Controls.Add(txtEmail);
            grpNCC.Controls.Add(lblEmail);
            grpNCC.Controls.Add(txtDienThoai);
            grpNCC.Controls.Add(lblDienThoai);
            grpNCC.Controls.Add(btnXuat);
            grpNCC.Controls.Add(btnNhap);
            grpNCC.Controls.Add(btnThoat);
            grpNCC.Controls.Add(btnHuyBo);
            grpNCC.Controls.Add(btnSua);
            grpNCC.Controls.Add(btnLuu);
            grpNCC.Controls.Add(btnXoa);
            grpNCC.Controls.Add(btnThem);
            grpNCC.Controls.Add(btnTimKiem);
            grpNCC.Controls.Add(cboTenNhaCungCap);
            grpNCC.Controls.Add(txtMaNhaCungCap);
            grpNCC.Controls.Add(lblNCC);
            grpNCC.Controls.Add(lblMaNCC);
            grpNCC.Location = new Point(12, 12);
            grpNCC.Name = "grpNCC";
            grpNCC.Size = new Size(980, 185);
            grpNCC.TabIndex = 0;
            grpNCC.TabStop = false;
            grpNCC.Text = "Thông tin nhà cung cấp";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(157, 138);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(276, 27);
            txtDiaChi.TabIndex = 6;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(18, 141);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(58, 20);
            lblDiaChi.TabIndex = 18;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(494, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(126, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(439, 86);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(453, 31);
            txtDienThoai.MaxLength = 10;
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(144, 27);
            txtDienThoai.TabIndex = 5;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(366, 34);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(81, 20);
            lblDienThoai.TabIndex = 14;
            lblDienThoai.Text = "Điện thoại:";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(857, 86);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(100, 30);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(857, 34);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(100, 30);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(751, 141);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 30);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(751, 86);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 30);
            btnHuyBo.TabIndex = 9;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(751, 34);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 30);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(645, 86);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 30);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(645, 141);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 30);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(645, 34);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 30);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(333, 86);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 30);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboTenNhaCungCap
            // 
            cboTenNhaCungCap.FormattingEnabled = true;
            cboTenNhaCungCap.Location = new Point(157, 86);
            cboTenNhaCungCap.Name = "cboTenNhaCungCap";
            cboTenNhaCungCap.Size = new Size(154, 28);
            cboTenNhaCungCap.TabIndex = 3;
            // 
            // txtMaNhaCungCap
            // 
            txtMaNhaCungCap.Location = new Point(157, 34);
            txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            txtMaNhaCungCap.ReadOnly = true;
            txtMaNhaCungCap.Size = new Size(154, 27);
            txtMaNhaCungCap.TabIndex = 2;
            // 
            // lblNCC
            // 
            lblNCC.AutoSize = true;
            lblNCC.Location = new Point(18, 89);
            lblNCC.Name = "lblNCC";
            lblNCC.Size = new Size(127, 20);
            lblNCC.TabIndex = 1;
            lblNCC.Text = "Tên nhà cung cấp:";
            // 
            // lblMaNCC
            // 
            lblMaNCC.AutoSize = true;
            lblMaNCC.Location = new Point(18, 37);
            lblMaNCC.Name = "lblMaNCC";
            lblMaNCC.Size = new Size(125, 20);
            lblMaNCC.TabIndex = 0;
            lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // grpDSNCC
            // 
            grpDSNCC.Controls.Add(dgvNhaCungCap);
            grpDSNCC.Location = new Point(12, 203);
            grpDSNCC.Name = "grpDSNCC";
            grpDSNCC.Size = new Size(980, 380);
            grpDSNCC.TabIndex = 1;
            grpDSNCC.TabStop = false;
            grpDSNCC.Text = "Danh sách nhà cung cấp";
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.AllowUserToDeleteRows = false;
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { ID, MaNhaCungCap, TenNhaCungCap, DienThoai, Email, DiaChi });
            dgvNhaCungCap.Dock = DockStyle.Fill;
            dgvNhaCungCap.Location = new Point(3, 23);
            dgvNhaCungCap.MultiSelect = false;
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.ReadOnly = true;
            dgvNhaCungCap.RowHeadersVisible = false;
            dgvNhaCungCap.RowHeadersWidth = 51;
            dgvNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhaCungCap.Size = new Size(974, 354);
            dgvNhaCungCap.TabIndex = 0;
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
            // MaNhaCungCap
            // 
            MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            MaNhaCungCap.HeaderText = "Mã nhà cung cấp";
            MaNhaCungCap.MinimumWidth = 6;
            MaNhaCungCap.Name = "MaNhaCungCap";
            MaNhaCungCap.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Tên nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
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
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 595);
            Controls.Add(grpDSNCC);
            Controls.Add(grpNCC);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhà cung cấp";
            Load += frmNhaCungCap_Load;
            grpNCC.ResumeLayout(false);
            grpNCC.PerformLayout();
            grpDSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNCC;
        private GroupBox grpDSNCC;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThem;
        private Button btnTimKiem;
        private ComboBox cboTenNhaCungCap;
        private TextBox txtMaNhaCungCap;
        private TextBox txtDienThoai;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private Label lblNCC;
        private Label lblMaNCC;
        private Label lblDienThoai;
        private Label lblEmail;
        private Label lblDiaChi;
        private DataGridView dgvNhaCungCap;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaNhaCungCap;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
    }
}