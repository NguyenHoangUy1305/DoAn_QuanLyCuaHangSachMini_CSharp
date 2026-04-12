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
            grpThongTinNXB = new GroupBox();
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
            grpThongTinNXB.SuspendLayout();
            grpDanhSachNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaXuatBan).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinNXB
            // 
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
            grpThongTinNXB.Location = new Point(12, 12);
            grpThongTinNXB.Name = "grpThongTinNXB";
            grpThongTinNXB.Size = new Size(900, 135);
            grpThongTinNXB.TabIndex = 0;
            grpThongTinNXB.TabStop = false;
            grpThongTinNXB.Text = "Thông tin nhà xuất bản";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(777, 63);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(100, 30);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(777, 26);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(100, 30);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(660, 99);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 30);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(660, 26);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 30);
            btnHuyBo.TabIndex = 9;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(660, 63);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 30);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(554, 63);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 30);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(554, 99);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 30);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(554, 27);
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
            // cboTenNhaXuatBan
            // 
            cboTenNhaXuatBan.FormattingEnabled = true;
            cboTenNhaXuatBan.Location = new Point(151, 86);
            cboTenNhaXuatBan.Name = "cboTenNhaXuatBan";
            cboTenNhaXuatBan.Size = new Size(160, 28);
            cboTenNhaXuatBan.TabIndex = 3;
            // 
            // txtMaNhaXuatBan
            // 
            txtMaNhaXuatBan.Location = new Point(151, 34);
            txtMaNhaXuatBan.Name = "txtMaNhaXuatBan";
            txtMaNhaXuatBan.Size = new Size(160, 27);
            txtMaNhaXuatBan.TabIndex = 2;
            // 
            // lblTenNXB
            // 
            lblTenNXB.AutoSize = true;
            lblTenNXB.Location = new Point(18, 89);
            lblTenNXB.Name = "lblTenNXB";
            lblTenNXB.Size = new Size(124, 20);
            lblTenNXB.TabIndex = 1;
            lblTenNXB.Text = "Tên nhà xuất bản:";
            // 
            // lblMaXB
            // 
            lblMaXB.AutoSize = true;
            lblMaXB.Location = new Point(18, 37);
            lblMaXB.Name = "lblMaXB";
            lblMaXB.Size = new Size(122, 20);
            lblMaXB.TabIndex = 0;
            lblMaXB.Text = "Mã nhà xuất bản:";
            // 
            // grpDanhSachNXB
            // 
            grpDanhSachNXB.Controls.Add(dgvNhaXuatBan);
            grpDanhSachNXB.Location = new Point(12, 153);
            grpDanhSachNXB.Name = "grpDanhSachNXB";
            grpDanhSachNXB.Size = new Size(900, 380);
            grpDanhSachNXB.TabIndex = 1;
            grpDanhSachNXB.TabStop = false;
            grpDanhSachNXB.Text = "Danh sách nhà xuất bản";
            // 
            // dgvNhaXuatBan
            // 
            dgvNhaXuatBan.AllowUserToAddRows = false;
            dgvNhaXuatBan.AllowUserToDeleteRows = false;
            dgvNhaXuatBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaXuatBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaXuatBan.Columns.AddRange(new DataGridViewColumn[] { ID, MaNhaXuatBan, TenNhaXuatBan });
            dgvNhaXuatBan.Dock = DockStyle.Fill;
            dgvNhaXuatBan.Location = new Point(3, 23);
            dgvNhaXuatBan.MultiSelect = false;
            dgvNhaXuatBan.Name = "dgvNhaXuatBan";
            dgvNhaXuatBan.ReadOnly = true;
            dgvNhaXuatBan.RowHeadersVisible = false;
            dgvNhaXuatBan.RowHeadersWidth = 51;
            dgvNhaXuatBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhaXuatBan.Size = new Size(894, 354);
            dgvNhaXuatBan.TabIndex = 0;
            dgvNhaXuatBan.CellClick += dgvNhaXuatBan_CellClick;
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
            // frmNhaXuatBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 545);
            Controls.Add(grpDanhSachNXB);
            Controls.Add(grpThongTinNXB);
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
        private Label lblTenNXB;
        private Label lblMaXB;
        private DataGridView dgvNhaXuatBan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaNhaXuatBan;
        private DataGridViewTextBoxColumn TenNhaXuatBan;
    }
}