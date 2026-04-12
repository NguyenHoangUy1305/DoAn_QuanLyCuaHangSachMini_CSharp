namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmPhieuHoanTra_ChiTiet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                context.Dispose(); // Lưu ý: Nếu context báo lỗi, bạn hãy xóa bỏ dòng này
            }
            base.Dispose(disposing);
        }

        private GroupBox grpThongTinPhieu;
        private GroupBox grpThongTinChiTiet;
        private GroupBox grpDanhSachChiTiet;
        private DataGridView dgvChiTiet;
        private Button btnThemSach;
        private Button btnXoaSach;
        private Button btnLuuPhieuHoanTra;
        private Button btnHuyBo;
        private Button btnThoat;
        private System.Windows.Forms.TextBox txtMaPhieuHoanTra;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.TextBox txtNgayHoanTra;
        private System.Windows.Forms.TextBox txtNhanVienXuLy;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtSoLuongBan;
        private System.Windows.Forms.ComboBox cboSach;
        private System.Windows.Forms.NumericUpDown numSoLuongTra;
        private System.Windows.Forms.NumericUpDown numDonGiaHoanTra;
        private System.Windows.Forms.Label lblMaPhieuHoanTra;
        private System.Windows.Forms.Label lblNgayHoanTra;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblNhanVienXuLy;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.Label lblSach;
        private System.Windows.Forms.Label lblSoLuongBan;
        private System.Windows.Forms.Label lblSoLuongTra;
        private System.Windows.Forms.Label lblDonGiaHoanTra;

        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoaDonChiTietID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoaDonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SachID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaHoanTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            grpThongTinPhieu = new GroupBox();
            lblMaPhieuHoanTra = new Label();
            txtMaPhieuHoanTra = new TextBox();
            lblNgayHoanTra = new Label();
            txtNgayHoanTra = new TextBox();
            lblMaHoaDon = new Label();
            txtMaHoaDon = new TextBox();
            lblKhachHang = new Label();
            txtKhachHang = new TextBox();
            lblNhanVienXuLy = new Label();
            txtNhanVienXuLy = new TextBox();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            lblLyDo = new Label();
            txtLyDo = new TextBox();
            grpThongTinChiTiet = new GroupBox();
            lblSach = new Label();
            cboSach = new ComboBox();
            lblSoLuongBan = new Label();
            txtSoLuongBan = new TextBox();
            lblDonGiaHoanTra = new Label();
            numDonGiaHoanTra = new NumericUpDown();
            lblSoLuongTra = new Label();
            numSoLuongTra = new NumericUpDown();
            btnThemSach = new Button();
            btnXoaSach = new Button();
            grpDanhSachChiTiet = new GroupBox();
            dgvChiTiet = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoaDonChiTietID = new DataGridViewTextBoxColumn();
            HoaDonID = new DataGridViewTextBoxColumn();
            SachID = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            SoLuongTra = new DataGridViewTextBoxColumn();
            DonGiaHoanTra = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuuPhieuHoanTra = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            grpThongTinPhieu.SuspendLayout();
            grpThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaHoanTra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongTra).BeginInit();
            grpDanhSachChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinPhieu
            // 
            grpThongTinPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinPhieu.BackColor = Color.White;
            grpThongTinPhieu.Controls.Add(lblMaPhieuHoanTra);
            grpThongTinPhieu.Controls.Add(txtMaPhieuHoanTra);
            grpThongTinPhieu.Controls.Add(lblNgayHoanTra);
            grpThongTinPhieu.Controls.Add(txtNgayHoanTra);
            grpThongTinPhieu.Controls.Add(lblMaHoaDon);
            grpThongTinPhieu.Controls.Add(txtMaHoaDon);
            grpThongTinPhieu.Controls.Add(lblKhachHang);
            grpThongTinPhieu.Controls.Add(txtKhachHang);
            grpThongTinPhieu.Controls.Add(lblNhanVienXuLy);
            grpThongTinPhieu.Controls.Add(txtNhanVienXuLy);
            grpThongTinPhieu.Controls.Add(lblTongTien);
            grpThongTinPhieu.Controls.Add(txtTongTien);
            grpThongTinPhieu.Controls.Add(lblLyDo);
            grpThongTinPhieu.Controls.Add(txtLyDo);
            grpThongTinPhieu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTinPhieu.ForeColor = Color.FromArgb(55, 38, 210);
            grpThongTinPhieu.Location = new Point(11, 12);
            grpThongTinPhieu.Name = "grpThongTinPhieu";
            grpThongTinPhieu.Size = new Size(1008, 178);
            grpThongTinPhieu.TabIndex = 0;
            grpThongTinPhieu.TabStop = false;
            grpThongTinPhieu.Text = "Thông tin phiếu hoàn trả";
            // 
            // lblMaPhieuHoanTra
            // 
            lblMaPhieuHoanTra.AutoSize = true;
            lblMaPhieuHoanTra.Font = new Font("Segoe UI", 10F);
            lblMaPhieuHoanTra.ForeColor = Color.FromArgb(33, 37, 41);
            lblMaPhieuHoanTra.Location = new Point(18, 47);
            lblMaPhieuHoanTra.Name = "lblMaPhieuHoanTra";
            lblMaPhieuHoanTra.Size = new Size(86, 23);
            lblMaPhieuHoanTra.TabIndex = 0;
            lblMaPhieuHoanTra.Text = "Mã phiếu:";
            // 
            // txtMaPhieuHoanTra
            // 
            txtMaPhieuHoanTra.BackColor = Color.FromArgb(248, 250, 252);
            txtMaPhieuHoanTra.Font = new Font("Segoe UI", 10F);
            txtMaPhieuHoanTra.Location = new Point(103, 44);
            txtMaPhieuHoanTra.Name = "txtMaPhieuHoanTra";
            txtMaPhieuHoanTra.ReadOnly = true;
            txtMaPhieuHoanTra.Size = new Size(220, 30);
            txtMaPhieuHoanTra.TabIndex = 1;
            // 
            // lblNgayHoanTra
            // 
            lblNgayHoanTra.AutoSize = true;
            lblNgayHoanTra.Font = new Font("Segoe UI", 10F);
            lblNgayHoanTra.ForeColor = Color.FromArgb(33, 37, 41);
            lblNgayHoanTra.Location = new Point(18, 86);
            lblNgayHoanTra.Name = "lblNgayHoanTra";
            lblNgayHoanTra.Size = new Size(54, 23);
            lblNgayHoanTra.TabIndex = 2;
            lblNgayHoanTra.Text = "Ngày:";
            // 
            // txtNgayHoanTra
            // 
            txtNgayHoanTra.BackColor = Color.FromArgb(248, 250, 252);
            txtNgayHoanTra.Font = new Font("Segoe UI", 10F);
            txtNgayHoanTra.Location = new Point(103, 83);
            txtNgayHoanTra.Name = "txtNgayHoanTra";
            txtNgayHoanTra.ReadOnly = true;
            txtNgayHoanTra.Size = new Size(220, 30);
            txtNgayHoanTra.TabIndex = 3;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI", 10F);
            lblMaHoaDon.ForeColor = Color.FromArgb(33, 37, 41);
            lblMaHoaDon.Location = new Point(355, 47);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(80, 23);
            lblMaHoaDon.TabIndex = 4;
            lblMaHoaDon.Text = "Hóa đơn:";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.BackColor = Color.FromArgb(248, 250, 252);
            txtMaHoaDon.Font = new Font("Segoe UI", 10F);
            txtMaHoaDon.Location = new Point(455, 44);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.ReadOnly = true;
            txtMaHoaDon.Size = new Size(180, 30);
            txtMaHoaDon.TabIndex = 5;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 10F);
            lblKhachHang.ForeColor = Color.FromArgb(33, 37, 41);
            lblKhachHang.Location = new Point(355, 86);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(61, 23);
            lblKhachHang.TabIndex = 6;
            lblKhachHang.Text = "Khách:";
            // 
            // txtKhachHang
            // 
            txtKhachHang.BackColor = Color.FromArgb(248, 250, 252);
            txtKhachHang.Font = new Font("Segoe UI", 10F);
            txtKhachHang.Location = new Point(455, 83);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.ReadOnly = true;
            txtKhachHang.Size = new Size(180, 30);
            txtKhachHang.TabIndex = 7;
            // 
            // lblNhanVienXuLy
            // 
            lblNhanVienXuLy.AutoSize = true;
            lblNhanVienXuLy.Font = new Font("Segoe UI", 10F);
            lblNhanVienXuLy.ForeColor = Color.FromArgb(33, 37, 41);
            lblNhanVienXuLy.Location = new Point(655, 47);
            lblNhanVienXuLy.Name = "lblNhanVienXuLy";
            lblNhanVienXuLy.Size = new Size(132, 23);
            lblNhanVienXuLy.TabIndex = 8;
            lblNhanVienXuLy.Text = "Nhân viên xử lý:";
            // 
            // txtNhanVienXuLy
            // 
            txtNhanVienXuLy.BackColor = Color.FromArgb(248, 250, 252);
            txtNhanVienXuLy.Font = new Font("Segoe UI", 10F);
            txtNhanVienXuLy.Location = new Point(803, 44);
            txtNhanVienXuLy.Name = "txtNhanVienXuLy";
            txtNhanVienXuLy.ReadOnly = true;
            txtNhanVienXuLy.Size = new Size(180, 30);
            txtNhanVienXuLy.TabIndex = 9;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10F);
            lblTongTien.ForeColor = Color.FromArgb(33, 37, 41);
            lblTongTien.Location = new Point(655, 86);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(87, 23);
            lblTongTien.TabIndex = 10;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.FromArgb(248, 250, 252);
            txtTongTien.Font = new Font("Segoe UI", 10F);
            txtTongTien.Location = new Point(803, 83);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(180, 30);
            txtTongTien.TabIndex = 11;
            // 
            // lblLyDo
            // 
            lblLyDo.AutoSize = true;
            lblLyDo.Font = new Font("Segoe UI", 10F);
            lblLyDo.ForeColor = Color.FromArgb(33, 37, 41);
            lblLyDo.Location = new Point(18, 124);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new Size(54, 23);
            lblLyDo.TabIndex = 12;
            lblLyDo.Text = "Lý do:";
            // 
            // txtLyDo
            // 
            txtLyDo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLyDo.Font = new Font("Segoe UI", 10F);
            txtLyDo.Location = new Point(103, 121);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(880, 40);
            txtLyDo.TabIndex = 13;
            // 
            // grpThongTinChiTiet
            // 
            grpThongTinChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinChiTiet.BackColor = Color.White;
            grpThongTinChiTiet.Controls.Add(lblSach);
            grpThongTinChiTiet.Controls.Add(cboSach);
            grpThongTinChiTiet.Controls.Add(lblSoLuongBan);
            grpThongTinChiTiet.Controls.Add(txtSoLuongBan);
            grpThongTinChiTiet.Controls.Add(lblDonGiaHoanTra);
            grpThongTinChiTiet.Controls.Add(numDonGiaHoanTra);
            grpThongTinChiTiet.Controls.Add(lblSoLuongTra);
            grpThongTinChiTiet.Controls.Add(numSoLuongTra);
            grpThongTinChiTiet.Controls.Add(btnThemSach);
            grpThongTinChiTiet.Controls.Add(btnXoaSach);
            grpThongTinChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTinChiTiet.ForeColor = Color.FromArgb(55, 38, 210);
            grpThongTinChiTiet.Location = new Point(11, 196);
            grpThongTinChiTiet.Name = "grpThongTinChiTiet";
            grpThongTinChiTiet.Size = new Size(1008, 95);
            grpThongTinChiTiet.TabIndex = 1;
            grpThongTinChiTiet.TabStop = false;
            grpThongTinChiTiet.Text = "Thông tin chi tiết hoàn trả";
            // 
            // lblSach
            // 
            lblSach.AutoSize = true;
            lblSach.Font = new Font("Segoe UI", 10F);
            lblSach.ForeColor = Color.FromArgb(33, 37, 41);
            lblSach.Location = new Point(8, 51);
            lblSach.Name = "lblSach";
            lblSach.Size = new Size(50, 23);
            lblSach.TabIndex = 0;
            lblSach.Text = "Sách:";
            // 
            // cboSach
            // 
            cboSach.BackColor = Color.White;
            cboSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSach.FlatStyle = FlatStyle.Flat;
            cboSach.Font = new Font("Segoe UI", 10F);
            cboSach.FormattingEnabled = true;
            cboSach.Location = new Point(66, 48);
            cboSach.Name = "cboSach";
            cboSach.Size = new Size(305, 31);
            cboSach.TabIndex = 1;
            cboSach.SelectionChangeCommitted += cboSach_SelectionChangeCommitted;
            // 
            // lblSoLuongBan
            // 
            lblSoLuongBan.AutoSize = true;
            lblSoLuongBan.Font = new Font("Segoe UI", 10F);
            lblSoLuongBan.ForeColor = Color.FromArgb(33, 37, 41);
            lblSoLuongBan.Location = new Point(377, 48);
            lblSoLuongBan.Name = "lblSoLuongBan";
            lblSoLuongBan.Size = new Size(65, 23);
            lblSoLuongBan.TabIndex = 2;
            lblSoLuongBan.Text = "SL bán:";
            // 
            // txtSoLuongBan
            // 
            txtSoLuongBan.BackColor = Color.FromArgb(248, 250, 252);
            txtSoLuongBan.Font = new Font("Segoe UI", 10F);
            txtSoLuongBan.Location = new Point(452, 45);
            txtSoLuongBan.Name = "txtSoLuongBan";
            txtSoLuongBan.ReadOnly = true;
            txtSoLuongBan.Size = new Size(74, 30);
            txtSoLuongBan.TabIndex = 3;
            // 
            // lblDonGiaHoanTra
            // 
            lblDonGiaHoanTra.AutoSize = true;
            lblDonGiaHoanTra.Font = new Font("Segoe UI", 10F);
            lblDonGiaHoanTra.ForeColor = Color.FromArgb(33, 37, 41);
            lblDonGiaHoanTra.Location = new Point(532, 47);
            lblDonGiaHoanTra.Name = "lblDonGiaHoanTra";
            lblDonGiaHoanTra.Size = new Size(74, 23);
            lblDonGiaHoanTra.TabIndex = 4;
            lblDonGiaHoanTra.Text = "Đơn giá:";
            // 
            // numDonGiaHoanTra
            // 
            numDonGiaHoanTra.Font = new Font("Segoe UI", 10F);
            numDonGiaHoanTra.Location = new Point(617, 44);
            numDonGiaHoanTra.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaHoanTra.Name = "numDonGiaHoanTra";
            numDonGiaHoanTra.Size = new Size(106, 30);
            numDonGiaHoanTra.TabIndex = 5;
            numDonGiaHoanTra.ThousandsSeparator = true;
            // 
            // lblSoLuongTra
            // 
            lblSoLuongTra.AutoSize = true;
            lblSoLuongTra.Font = new Font("Segoe UI", 10F);
            lblSoLuongTra.ForeColor = Color.FromArgb(33, 37, 41);
            lblSoLuongTra.Location = new Point(736, 47);
            lblSoLuongTra.Name = "lblSoLuongTra";
            lblSoLuongTra.Size = new Size(31, 23);
            lblSoLuongTra.TabIndex = 6;
            lblSoLuongTra.Text = "SL:";
            // 
            // numSoLuongTra
            // 
            numSoLuongTra.Font = new Font("Segoe UI", 10F);
            numSoLuongTra.Location = new Point(776, 44);
            numSoLuongTra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSoLuongTra.Name = "numSoLuongTra";
            numSoLuongTra.Size = new Size(74, 30);
            numSoLuongTra.TabIndex = 7;
            numSoLuongTra.ThousandsSeparator = true;
            // 
            // btnThemSach
            // 
            btnThemSach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemSach.BackColor = Color.FromArgb(71, 51, 255);
            btnThemSach.Cursor = Cursors.Hand;
            btnThemSach.FlatAppearance.BorderSize = 0;
            btnThemSach.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnThemSach.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnThemSach.FlatStyle = FlatStyle.Flat;
            btnThemSach.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThemSach.ForeColor = Color.White;
            btnThemSach.Location = new Point(867, 42);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(70, 30);
            btnThemSach.TabIndex = 8;
            btnThemSach.Text = "Thêm";
            btnThemSach.UseVisualStyleBackColor = false;
            btnThemSach.Click += btnThemSach_Click;
            // 
            // btnXoaSach
            // 
            btnXoaSach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoaSach.BackColor = Color.Red;
            btnXoaSach.Cursor = Cursors.Hand;
            btnXoaSach.FlatAppearance.BorderSize = 0;
            btnXoaSach.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 25, 40);
            btnXoaSach.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            btnXoaSach.FlatStyle = FlatStyle.Flat;
            btnXoaSach.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXoaSach.ForeColor = Color.White;
            btnXoaSach.Location = new Point(943, 42);
            btnXoaSach.Name = "btnXoaSach";
            btnXoaSach.Size = new Size(59, 30);
            btnXoaSach.TabIndex = 9;
            btnXoaSach.Text = "Xóa";
            btnXoaSach.UseVisualStyleBackColor = false;
            btnXoaSach.Click += btnXoaSach_Click;
            // 
            // grpDanhSachChiTiet
            // 
            grpDanhSachChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSachChiTiet.BackColor = Color.White;
            grpDanhSachChiTiet.Controls.Add(dgvChiTiet);
            grpDanhSachChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSachChiTiet.ForeColor = Color.FromArgb(55, 38, 210);
            grpDanhSachChiTiet.Location = new Point(11, 297);
            grpDanhSachChiTiet.Name = "grpDanhSachChiTiet";
            grpDanhSachChiTiet.Size = new Size(1008, 300);
            grpDanhSachChiTiet.TabIndex = 2;
            grpDanhSachChiTiet.TabStop = false;
            grpDanhSachChiTiet.Text = "Danh sách chi tiết hoàn trả";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.AllowUserToResizeRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.BorderStyle = BorderStyle.None;
            dgvChiTiet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { ID, HoaDonChiTietID, HoaDonID, SachID, MaSach, TenSach, SoLuongBan, SoLuongTra, DonGiaHoanTra, ThanhTien });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle6;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.EnableHeadersVisualStyles = false;
            dgvChiTiet.GridColor = Color.FromArgb(226, 232, 240);
            dgvChiTiet.Location = new Point(3, 26);
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 32;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(1002, 271);
            dgvChiTiet.TabIndex = 0;
            dgvChiTiet.CellClick += dgvChiTiet_CellClick;
            dgvChiTiet.DataError += dgvChiTiet_DataError;
            dgvChiTiet.SelectionChanged += dgvChiTiet_SelectionChanged;
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
            // HoaDonChiTietID
            // 
            HoaDonChiTietID.DataPropertyName = "HoaDonChiTietID";
            HoaDonChiTietID.HeaderText = "HoaDonChiTietID";
            HoaDonChiTietID.MinimumWidth = 6;
            HoaDonChiTietID.Name = "HoaDonChiTietID";
            HoaDonChiTietID.ReadOnly = true;
            HoaDonChiTietID.Visible = false;
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
            // SachID
            // 
            SachID.DataPropertyName = "SachID";
            SachID.HeaderText = "SachID";
            SachID.MinimumWidth = 6;
            SachID.Name = "SachID";
            SachID.ReadOnly = true;
            SachID.Visible = false;
            // 
            // MaSach
            // 
            MaSach.DataPropertyName = "MaSach";
            MaSach.HeaderText = "Mã sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongBan.HeaderText = "SL bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // SoLuongTra
            // 
            SoLuongTra.DataPropertyName = "SoLuongTra";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoLuongTra.DefaultCellStyle = dataGridViewCellStyle3;
            SoLuongTra.HeaderText = "SL hoàn";
            SoLuongTra.MinimumWidth = 6;
            SoLuongTra.Name = "SoLuongTra";
            SoLuongTra.ReadOnly = true;
            // 
            // DonGiaHoanTra
            // 
            DonGiaHoanTra.DataPropertyName = "DonGiaHoanTra";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            DonGiaHoanTra.DefaultCellStyle = dataGridViewCellStyle4;
            DonGiaHoanTra.HeaderText = "Đơn giá";
            DonGiaHoanTra.MinimumWidth = 6;
            DonGiaHoanTra.Name = "DonGiaHoanTra";
            DonGiaHoanTra.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.Blue;
            dataGridViewCellStyle5.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle5;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // btnLuuPhieuHoanTra
            // 
            btnLuuPhieuHoanTra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuuPhieuHoanTra.BackColor = Color.Red;
            btnLuuPhieuHoanTra.Cursor = Cursors.Hand;
            btnLuuPhieuHoanTra.FlatAppearance.BorderSize = 0;
            btnLuuPhieuHoanTra.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnLuuPhieuHoanTra.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnLuuPhieuHoanTra.FlatStyle = FlatStyle.Flat;
            btnLuuPhieuHoanTra.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLuuPhieuHoanTra.ForeColor = Color.White;
            btnLuuPhieuHoanTra.Location = new Point(686, 611);
            btnLuuPhieuHoanTra.Name = "btnLuuPhieuHoanTra";
            btnLuuPhieuHoanTra.Size = new Size(167, 38);
            btnLuuPhieuHoanTra.TabIndex = 2;
            btnLuuPhieuHoanTra.Text = "Lưu phiếu hoàn trả";
            btnLuuPhieuHoanTra.UseVisualStyleBackColor = false;
            btnLuuPhieuHoanTra.Click += btnLuuPhieuHoanTra_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHuyBo.BackColor = Color.White;
            btnHuyBo.Cursor = Cursors.Hand;
            btnHuyBo.FlatAppearance.BorderColor = Color.FromArgb(71, 51, 255);
            btnHuyBo.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 255);
            btnHuyBo.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 244, 255);
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.FromArgb(71, 51, 255);
            btnHuyBo.Location = new Point(859, 611);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(69, 38);
            btnHuyBo.TabIndex = 1;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThoat.BackColor = Color.White;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(71, 51, 255);
            btnThoat.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 255);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 244, 255);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThoat.ForeColor = Color.FromArgb(71, 51, 255);
            btnThoat.Location = new Point(936, 611);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(83, 38);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Đóng";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmPhieuHoanTra_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1030, 662);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuuPhieuHoanTra);
            Controls.Add(grpDanhSachChiTiet);
            Controls.Add(grpThongTinChiTiet);
            Controls.Add(grpThongTinPhieu);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1046, 701);
            Name = "frmPhieuHoanTra_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu hoàn trả";
            Load += frmPhieuHoanTra_ChiTiet_Load;
            grpThongTinPhieu.ResumeLayout(false);
            grpThongTinPhieu.PerformLayout();
            grpThongTinChiTiet.ResumeLayout(false);
            grpThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaHoanTra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongTra).EndInit();
            grpDanhSachChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }
    }
}
