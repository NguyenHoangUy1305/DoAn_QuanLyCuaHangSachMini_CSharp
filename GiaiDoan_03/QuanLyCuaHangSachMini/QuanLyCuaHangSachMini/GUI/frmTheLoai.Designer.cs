namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmTheLoai
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
            grpThongTinTheLoai = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboTenTheLoai = new ComboBox();
            txtMaTheLoai = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpDanhSachTheLoai = new GroupBox();
            dgvTheLoai = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaTheLoai = new DataGridViewTextBoxColumn();
            TenTheLoai = new DataGridViewTextBoxColumn();
            grpThongTinTheLoai.SuspendLayout();
            grpDanhSachTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinTheLoai
            // 
            grpThongTinTheLoai.Controls.Add(btnXuat);
            grpThongTinTheLoai.Controls.Add(btnNhap);
            grpThongTinTheLoai.Controls.Add(btnTimKiem);
            grpThongTinTheLoai.Controls.Add(btnThoat);
            grpThongTinTheLoai.Controls.Add(btnHuyBo);
            grpThongTinTheLoai.Controls.Add(btnLuu);
            grpThongTinTheLoai.Controls.Add(btnXoa);
            grpThongTinTheLoai.Controls.Add(btnSua);
            grpThongTinTheLoai.Controls.Add(btnThem);
            grpThongTinTheLoai.Controls.Add(cboTenTheLoai);
            grpThongTinTheLoai.Controls.Add(txtMaTheLoai);
            grpThongTinTheLoai.Controls.Add(label2);
            grpThongTinTheLoai.Controls.Add(label1);
            grpThongTinTheLoai.Location = new Point(12, 12);
            grpThongTinTheLoai.Name = "grpThongTinTheLoai";
            grpThongTinTheLoai.Size = new Size(860, 130);
            grpThongTinTheLoai.TabIndex = 0;
            grpThongTinTheLoai.TabStop = false;
            grpThongTinTheLoai.Text = "Thông tin thể loại";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(733, 56);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(100, 30);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(733, 20);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(100, 30);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(277, 61);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 30);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(611, 56);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 30);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(611, 92);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 30);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(505, 56);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 30);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(611, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 30);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(505, 92);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 30);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(505, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 30);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboTenTheLoai
            // 
            cboTenTheLoai.FormattingEnabled = true;
            cboTenTheLoai.Location = new Point(121, 63);
            cboTenTheLoai.Name = "cboTenTheLoai";
            cboTenTheLoai.Size = new Size(150, 28);
            cboTenTheLoai.TabIndex = 3;
            // 
            // txtMaTheLoai
            // 
            txtMaTheLoai.Location = new Point(121, 27);
            txtMaTheLoai.Name = "txtMaTheLoai";
            txtMaTheLoai.ReadOnly = true;
            txtMaTheLoai.Size = new Size(150, 27);
            txtMaTheLoai.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 66);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên thể loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã thể loại:";
            // 
            // grpDanhSachTheLoai
            // 
            grpDanhSachTheLoai.Controls.Add(dgvTheLoai);
            grpDanhSachTheLoai.Location = new Point(12, 148);
            grpDanhSachTheLoai.Name = "grpDanhSachTheLoai";
            grpDanhSachTheLoai.Size = new Size(860, 340);
            grpDanhSachTheLoai.TabIndex = 1;
            grpDanhSachTheLoai.TabStop = false;
            grpDanhSachTheLoai.Text = "Danh sách thể loại";
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.AllowUserToAddRows = false;
            dgvTheLoai.AllowUserToDeleteRows = false;
            dgvTheLoai.AllowUserToResizeRows = false;
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Columns.AddRange(new DataGridViewColumn[] { ID, MaTheLoai, TenTheLoai });
            dgvTheLoai.Dock = DockStyle.Fill;
            dgvTheLoai.Location = new Point(3, 23);
            dgvTheLoai.MultiSelect = false;
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.ReadOnly = true;
            dgvTheLoai.RowHeadersVisible = false;
            dgvTheLoai.RowHeadersWidth = 51;
            dgvTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoai.Size = new Size(854, 314);
            dgvTheLoai.TabIndex = 0;
            dgvTheLoai.CellClick += dgvTheLoai_CellClick;
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
            // MaTheLoai
            // 
            MaTheLoai.DataPropertyName = "MaTheLoai";
            MaTheLoai.HeaderText = "Mã thể loại";
            MaTheLoai.MinimumWidth = 6;
            MaTheLoai.Name = "MaTheLoai";
            MaTheLoai.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            TenTheLoai.DataPropertyName = "TenTheLoai";
            TenTheLoai.HeaderText = "Tên thể loại";
            TenTheLoai.MinimumWidth = 6;
            TenTheLoai.Name = "TenTheLoai";
            TenTheLoai.ReadOnly = true;
            // 
            // frmTheLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 500);
            Controls.Add(grpDanhSachTheLoai);
            Controls.Add(grpThongTinTheLoai);
            Name = "frmTheLoai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thể loại";
            Load += frmTheLoai_Load;
            grpThongTinTheLoai.ResumeLayout(false);
            grpThongTinTheLoai.PerformLayout();
            grpDanhSachTheLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinTheLoai;
        private GroupBox grpDanhSachTheLoai;
        private Label label1;
        private Label label2;
        private TextBox txtMaTheLoai;
        private ComboBox cboTenTheLoai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnNhap;
        private Button btnXuat;
        private DataGridView dgvTheLoai;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaTheLoai;
        private DataGridViewTextBoxColumn TenTheLoai;
    }
}