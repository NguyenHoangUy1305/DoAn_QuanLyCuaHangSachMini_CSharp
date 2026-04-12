namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmPhieuHoanTra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                context.Dispose(); // Lưu ý: Nếu 'context' báo lỗi không tồn tại, bạn có thể xóa dòng này
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grpDanhSachPhieuHoanTra = new GroupBox();
            dgvPhieuHoanTra = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoaDonID = new DataGridViewTextBoxColumn();
            NhanVienID = new DataGridViewTextBoxColumn();
            KhachHangID = new DataGridViewTextBoxColumn();
            MaPhieuHoanTra = new DataGridViewTextBoxColumn();
            MaHoaDon = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            NgayHoanTra = new DataGridViewTextBoxColumn();
            TongTienHoan = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnInPhieu = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();
            grpDanhSachPhieuHoanTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuHoanTra).BeginInit();
            SuspendLayout();
            // 
            // grpDanhSachPhieuHoanTra
            // 
            grpDanhSachPhieuHoanTra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSachPhieuHoanTra.BackColor = Color.White;
            grpDanhSachPhieuHoanTra.Controls.Add(dgvPhieuHoanTra);
            grpDanhSachPhieuHoanTra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSachPhieuHoanTra.ForeColor = Color.FromArgb(55, 38, 210);
            grpDanhSachPhieuHoanTra.Location = new Point(12, 12);
            grpDanhSachPhieuHoanTra.Name = "grpDanhSachPhieuHoanTra";
            grpDanhSachPhieuHoanTra.Size = new Size(1010, 430);
            grpDanhSachPhieuHoanTra.TabIndex = 0;
            grpDanhSachPhieuHoanTra.TabStop = false;
            grpDanhSachPhieuHoanTra.Text = "Danh sách phiếu hoàn trả";
            // 
            // dgvPhieuHoanTra
            // 
            dgvPhieuHoanTra.AllowUserToAddRows = false;
            dgvPhieuHoanTra.AllowUserToDeleteRows = false;
            dgvPhieuHoanTra.AllowUserToResizeRows = false;
            dgvPhieuHoanTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuHoanTra.BackgroundColor = Color.White;
            dgvPhieuHoanTra.BorderStyle = BorderStyle.None;
            dgvPhieuHoanTra.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPhieuHoanTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhieuHoanTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuHoanTra.Columns.AddRange(new DataGridViewColumn[] { ID, HoaDonID, NhanVienID, KhachHangID, MaPhieuHoanTra, MaHoaDon, TenNhanVien, TenKhachHang, NgayHoanTra, TongTienHoan, XemChiTiet });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPhieuHoanTra.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPhieuHoanTra.Dock = DockStyle.Fill;
            dgvPhieuHoanTra.EnableHeadersVisualStyles = false;
            dgvPhieuHoanTra.GridColor = Color.FromArgb(226, 232, 240);
            dgvPhieuHoanTra.Location = new Point(3, 26);
            dgvPhieuHoanTra.MultiSelect = false;
            dgvPhieuHoanTra.Name = "dgvPhieuHoanTra";
            dgvPhieuHoanTra.ReadOnly = true;
            dgvPhieuHoanTra.RowHeadersVisible = false;
            dgvPhieuHoanTra.RowHeadersWidth = 51;
            dgvPhieuHoanTra.RowTemplate.Height = 32;
            dgvPhieuHoanTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuHoanTra.Size = new Size(1004, 401);
            dgvPhieuHoanTra.TabIndex = 0;
            dgvPhieuHoanTra.CellClick += dgvPhieuHoanTra_CellClick;
            dgvPhieuHoanTra.CellContentClick += dgvPhieuHoanTra_CellContentClick;
            dgvPhieuHoanTra.DataError += dgvPhieuHoanTra_DataError;
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
            // HoaDonID
            // 
            HoaDonID.DataPropertyName = "HoaDonID";
            HoaDonID.HeaderText = "HoaDonID";
            HoaDonID.MinimumWidth = 6;
            HoaDonID.Name = "HoaDonID";
            HoaDonID.ReadOnly = true;
            HoaDonID.Visible = false;
            // 
            // NhanVienID
            // 
            NhanVienID.DataPropertyName = "NhanVienID";
            NhanVienID.HeaderText = "NhanVienID";
            NhanVienID.MinimumWidth = 6;
            NhanVienID.Name = "NhanVienID";
            NhanVienID.ReadOnly = true;
            NhanVienID.Visible = false;
            // 
            // KhachHangID
            // 
            KhachHangID.DataPropertyName = "KhachHangID";
            KhachHangID.HeaderText = "KhachHangID";
            KhachHangID.MinimumWidth = 6;
            KhachHangID.Name = "KhachHangID";
            KhachHangID.ReadOnly = true;
            KhachHangID.Visible = false;
            // 
            // MaPhieuHoanTra
            // 
            MaPhieuHoanTra.DataPropertyName = "MaPhieuHoanTra";
            MaPhieuHoanTra.HeaderText = "Mã phiếu hoàn trả";
            MaPhieuHoanTra.MinimumWidth = 6;
            MaPhieuHoanTra.Name = "MaPhieuHoanTra";
            MaPhieuHoanTra.ReadOnly = true;
            // 
            // MaHoaDon
            // 
            MaHoaDon.DataPropertyName = "MaHoaDon";
            MaHoaDon.HeaderText = "Mã hóa đơn";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Nhân viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Khách hàng";
            TenKhachHang.MinimumWidth = 6;
            TenKhachHang.Name = "TenKhachHang";
            TenKhachHang.ReadOnly = true;
            // 
            // NgayHoanTra
            // 
            NgayHoanTra.DataPropertyName = "NgayHoanTra";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            NgayHoanTra.DefaultCellStyle = dataGridViewCellStyle2;
            NgayHoanTra.HeaderText = "Ngày hoàn trả";
            NgayHoanTra.MinimumWidth = 6;
            NgayHoanTra.Name = "NgayHoanTra";
            NgayHoanTra.ReadOnly = true;
            // 
            // TongTienHoan
            // 
            TongTienHoan.DataPropertyName = "TongTienHoan";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            TongTienHoan.DefaultCellStyle = dataGridViewCellStyle3;
            TongTienHoan.HeaderText = "Tổng tiền hoàn";
            TongTienHoan.MinimumWidth = 6;
            TongTienHoan.Name = "TongTienHoan";
            TongTienHoan.ReadOnly = true;
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
            // 
            // btnInPhieu
            // 
            btnInPhieu.Anchor = AnchorStyles.Bottom;
            btnInPhieu.BackColor = Color.Yellow;
            btnInPhieu.Cursor = Cursors.Hand;
            btnInPhieu.FlatAppearance.BorderSize = 0;
            btnInPhieu.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnInPhieu.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnInPhieu.FlatStyle = FlatStyle.Flat;
            btnInPhieu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnInPhieu.ForeColor = Color.Black;
            btnInPhieu.Location = new Point(353, 458);
            btnInPhieu.Name = "btnInPhieu";
            btnInPhieu.Size = new Size(110, 35);
            btnInPhieu.TabIndex = 1;
            btnInPhieu.Text = "In phiếu";
            btnInPhieu.UseVisualStyleBackColor = false;
            btnInPhieu.Click += btnInPhieu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Bottom;
            btnLamMoi.BackColor = Color.FromArgb(71, 51, 255);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnLamMoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(481, 458);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 35);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom;
            btnThoat.BackColor = Color.White;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(71, 51, 255);
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 255);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 244, 255);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThoat.ForeColor = Color.FromArgb(71, 51, 255);
            btnThoat.Location = new Point(609, 458);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(90, 35);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Đóng";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmPhieuHoanTra
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1034, 512);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnInPhieu);
            Controls.Add(grpDanhSachPhieuHoanTra);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1050, 551);
            Name = "frmPhieuHoanTra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu hoàn trả";
            Load += frmPhieuHoanTra_Load;
            grpDanhSachPhieuHoanTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPhieuHoanTra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDanhSachPhieuHoanTra;
        private DataGridView dgvPhieuHoanTra;
        private Button btnInPhieu;
        private Button btnLamMoi;
        private Button btnThoat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoaDonID;
        private DataGridViewTextBoxColumn NhanVienID;
        private DataGridViewTextBoxColumn KhachHangID;
        private DataGridViewTextBoxColumn MaPhieuHoanTra;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn NgayHoanTra;
        private DataGridViewTextBoxColumn TongTienHoan;
        private DataGridViewLinkColumn XemChiTiet;
    }
}
