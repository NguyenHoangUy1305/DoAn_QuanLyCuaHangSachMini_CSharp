namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                context.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dgvPhieuNhap = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaPhieuNhap = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            TongTienPhieuNhap = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnLapPhieuNhap = new Button();
            btnInPhieuNhap = new Button();
            btnXoaPhieuNhap = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPhieuNhap);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(889, 430);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToAddRows = false;
            dgvPhieuNhap.AllowUserToDeleteRows = false;
            
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] {
            ID,
            MaPhieuNhap,
            TenNhaCungCap,
            HoVaTenNhanVien,
            NgayNhap,
            TongTienPhieuNhap,
            XemChiTiet});
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.Location = new Point(3, 23);
            dgvPhieuNhap.MultiSelect = false;
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.Size = new Size(883, 404);
            dgvPhieuNhap.TabIndex = 0;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            dgvPhieuNhap.CellContentClick += dgvPhieuNhap_CellContentClick;
            dgvPhieuNhap.DataError += dgvPhieuNhap_DataError;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // MaPhieuNhap
            // 
            MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            MaPhieuNhap.MinimumWidth = 6;
            MaPhieuNhap.Name = "MaPhieuNhap";
            MaPhieuNhap.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            NgayNhap.DefaultCellStyle = dataGridViewCellStyle1;
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // TongTienPhieuNhap
            // 
            TongTienPhieuNhap.DataPropertyName = "TongTienPhieuNhap";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Blue;
            dataGridViewCellStyle2.Format = "N0";
            TongTienPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            TongTienPhieuNhap.HeaderText = "Tổng tiền";
            TongTienPhieuNhap.MinimumWidth = 6;
            TongTienPhieuNhap.Name = "TongTienPhieuNhap";
            TongTienPhieuNhap.ReadOnly = true;
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.HeaderText = "Chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.ReadOnly = true;
            XemChiTiet.Resizable = DataGridViewTriState.True;
            XemChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            XemChiTiet.TrackVisitedState = false;
            XemChiTiet.UseColumnTextForLinkValue = false;
            // 
            // btnLapPhieuNhap
            // 
            btnLapPhieuNhap.Location = new Point(150, 458);
            btnLapPhieuNhap.Name = "btnLapPhieuNhap";
            btnLapPhieuNhap.Size = new Size(140, 35);
            btnLapPhieuNhap.TabIndex = 1;
            btnLapPhieuNhap.Text = "Lập phiếu nhập...";
            btnLapPhieuNhap.UseVisualStyleBackColor = true;
            btnLapPhieuNhap.Click += btnLapPhieuNhap_Click;
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Location = new Point(306, 458);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(120, 35);
            btnInPhieuNhap.TabIndex = 2;
            btnInPhieuNhap.Text = "In phiếu nhập...";
            btnInPhieuNhap.UseVisualStyleBackColor = true;
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // btnXoaPhieuNhap
            // 
            btnXoaPhieuNhap.ForeColor = Color.Red;
            btnXoaPhieuNhap.Location = new Point(442, 458);
            btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            btnXoaPhieuNhap.Size = new Size(80, 35);
            btnXoaPhieuNhap.TabIndex = 3;
            btnXoaPhieuNhap.Text = "Xóa";
            btnXoaPhieuNhap.UseVisualStyleBackColor = true;
            btnXoaPhieuNhap.Click += btnXoaPhieuNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(538, 458);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 35);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 512);
            Controls.Add(btnThoat);
            Controls.Add(btnXoaPhieuNhap);
            Controls.Add(btnInPhieuNhap);
            Controls.Add(btnLapPhieuNhap);
            Controls.Add(groupBox1);
            Name = "frmPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu nhập";
            Load += frmPhieuNhap_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvPhieuNhap;
        private Button btnLapPhieuNhap;
        private Button btnInPhieuNhap;
        private Button btnXoaPhieuNhap;
        private Button btnThoat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaPhieuNhap;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn TongTienPhieuNhap;
        private DataGridViewLinkColumn XemChiTiet;
    }
}