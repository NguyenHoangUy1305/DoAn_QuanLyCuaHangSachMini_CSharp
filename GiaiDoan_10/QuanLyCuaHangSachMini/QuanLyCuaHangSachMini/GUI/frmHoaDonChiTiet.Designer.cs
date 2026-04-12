namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmHoaDon_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtGhiChuHoaDon = new TextBox();
            btnTimKhachTheoSdt = new Button();
            txtSdtTraCuu = new TextBox();
            lblSdtTraCuu = new Label();
            btnLapKhachHangMoi = new Button();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            lblGhiChu = new Label();
            lblKhachHang = new Label();
            lblNhanVien = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            numSoLuongBan = new NumericUpDown();
            numDonGiaBan = new NumericUpDown();
            cboSach = new ComboBox();
            lblSoLuongBan = new Label();
            lblDonGiaBan = new Label();
            lblSach = new Label();
            dataGridView = new DataGridView();
            SachID = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(btnTimKhachTheoSdt);
            groupBox1.Controls.Add(txtSdtTraCuu);
            groupBox1.Controls.Add(lblSdtTraCuu);
            groupBox1.Controls.Add(btnLapKhachHangMoi);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(lblGhiChu);
            groupBox1.Controls.Add(lblKhachHang);
            groupBox1.Controls.Add(lblNhanVien);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(55, 38, 210);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(871, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGhiChuHoaDon.Font = new Font("Segoe UI", 10F);
            txtGhiChuHoaDon.Location = new Point(113, 78);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(245, 30);
            txtGhiChuHoaDon.TabIndex = 5;
            // 
            // btnTimKhachTheoSdt
            // 
            btnTimKhachTheoSdt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimKhachTheoSdt.BackColor = Color.FromArgb(71, 51, 255);
            btnTimKhachTheoSdt.Cursor = Cursors.Hand;
            btnTimKhachTheoSdt.FlatAppearance.BorderSize = 0;
            btnTimKhachTheoSdt.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnTimKhachTheoSdt.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnTimKhachTheoSdt.FlatStyle = FlatStyle.Flat;
            btnTimKhachTheoSdt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKhachTheoSdt.ForeColor = Color.White;
            btnTimKhachTheoSdt.Location = new Point(718, 78);
            btnTimKhachTheoSdt.Name = "btnTimKhachTheoSdt";
            btnTimKhachTheoSdt.Size = new Size(110, 30);
            btnTimKhachTheoSdt.TabIndex = 8;
            btnTimKhachTheoSdt.Text = "Tìm kiếm sđt";
            btnTimKhachTheoSdt.UseVisualStyleBackColor = false;
            btnTimKhachTheoSdt.Visible = false;
            btnTimKhachTheoSdt.TabStop = false;
            btnTimKhachTheoSdt.Click += btnTimKhachTheoSdt_Click;
            // 
            // txtSdtTraCuu
            // 
            txtSdtTraCuu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSdtTraCuu.Font = new Font("Segoe UI", 10F);
            txtSdtTraCuu.Location = new Point(503, 78);
            txtSdtTraCuu.MaxLength = 10;
            txtSdtTraCuu.Name = "txtSdtTraCuu";
            txtSdtTraCuu.Size = new Size(325, 30);
            txtSdtTraCuu.TabIndex = 7;
            // 
            // lblSdtTraCuu
            // 
            lblSdtTraCuu.AutoSize = true;
            lblSdtTraCuu.Font = new Font("Segoe UI", 10F);
            lblSdtTraCuu.ForeColor = Color.FromArgb(33, 37, 41);
            lblSdtTraCuu.Location = new Point(369, 81);
            lblSdtTraCuu.Name = "lblSdtTraCuu";
            lblSdtTraCuu.Size = new Size(116, 23);
            lblSdtTraCuu.TabIndex = 6;
            lblSdtTraCuu.Text = "SĐT khách (*):";
            // 
            // btnLapKhachHangMoi
            // 
            btnLapKhachHangMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLapKhachHangMoi.BackColor = Color.White;
            btnLapKhachHangMoi.Cursor = Cursors.Hand;
            btnLapKhachHangMoi.FlatAppearance.BorderColor = Color.FromArgb(71, 51, 255);
            btnLapKhachHangMoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 255);
            btnLapKhachHangMoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 244, 255);
            btnLapKhachHangMoi.FlatStyle = FlatStyle.Flat;
            btnLapKhachHangMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLapKhachHangMoi.ForeColor = Color.Red;
            btnLapKhachHangMoi.Location = new Point(808, 34);
            btnLapKhachHangMoi.Name = "btnLapKhachHangMoi";
            btnLapKhachHangMoi.Size = new Size(55, 31);
            btnLapKhachHangMoi.TabIndex = 4;
            btnLapKhachHangMoi.Text = "Mới";
            btnLapKhachHangMoi.UseVisualStyleBackColor = false;
            btnLapKhachHangMoi.Click += btnLapKhachHangMoi_Click;
            // 
            // cboKhachHang
            // 
            cboKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboKhachHang.BackColor = Color.White;
            cboKhachHang.FlatStyle = FlatStyle.Flat;
            cboKhachHang.Font = new Font("Segoe UI", 10F);
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(503, 34);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(299, 31);
            cboKhachHang.TabIndex = 3;
            // 
            // cboNhanVien
            // 
            cboNhanVien.BackColor = Color.White;
            cboNhanVien.FlatStyle = FlatStyle.Flat;
            cboNhanVien.Font = new Font("Segoe UI", 10F);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(135, 34);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(223, 31);
            cboNhanVien.TabIndex = 1;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 10F);
            lblGhiChu.ForeColor = Color.FromArgb(33, 37, 41);
            lblGhiChu.Location = new Point(15, 81);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(95, 23);
            lblGhiChu.TabIndex = 4;
            lblGhiChu.Text = "Ghi chú (*):";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 10F);
            lblKhachHang.ForeColor = Color.FromArgb(33, 37, 41);
            lblKhachHang.Location = new Point(369, 37);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(127, 23);
            lblKhachHang.TabIndex = 2;
            lblKhachHang.Text = "Khách hàng (*):";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 10F);
            lblNhanVien.ForeColor = Color.FromArgb(33, 37, 41);
            lblNhanVien.Location = new Point(15, 37);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(114, 23);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "Nhân viên (*):";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(cboSach);
            groupBox2.Controls.Add(lblSoLuongBan);
            groupBox2.Controls.Add(lblDonGiaBan);
            groupBox2.Controls.Add(lblSach);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(55, 38, 210);
            groupBox2.Location = new Point(11, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(871, 95);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.BackColor = Color.Red;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 25, 40);
            btnXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(780, 38);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(73, 35);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXacNhanBan.BackColor = Color.FromArgb(71, 51, 255);
            btnXacNhanBan.Cursor = Cursors.Hand;
            btnXacNhanBan.FlatAppearance.BorderSize = 0;
            btnXacNhanBan.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnXacNhanBan.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnXacNhanBan.FlatStyle = FlatStyle.Flat;
            btnXacNhanBan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXacNhanBan.ForeColor = Color.White;
            btnXacNhanBan.Location = new Point(652, 38);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(122, 35);
            btnXacNhanBan.TabIndex = 6;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = false;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Font = new Font("Segoe UI", 10F);
            numSoLuongBan.Location = new Point(496, 42);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(133, 30);
            numSoLuongBan.TabIndex = 5;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Font = new Font("Segoe UI", 10F);
            numDonGiaBan.Location = new Point(286, 42);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(151, 30);
            numDonGiaBan.TabIndex = 3;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // cboSach
            // 
            cboSach.BackColor = Color.White;
            cboSach.FlatStyle = FlatStyle.Flat;
            cboSach.Font = new Font("Segoe UI", 10F);
            cboSach.FormattingEnabled = true;
            cboSach.Location = new Point(84, 42);
            cboSach.Name = "cboSach";
            cboSach.Size = new Size(139, 31);
            cboSach.TabIndex = 1;
            cboSach.SelectionChangeCommitted += cboSach_SelectionChangeCommitted;
            // 
            // lblSoLuongBan
            // 
            lblSoLuongBan.AutoSize = true;
            lblSoLuongBan.Font = new Font("Segoe UI", 10F);
            lblSoLuongBan.ForeColor = Color.FromArgb(33, 37, 41);
            lblSoLuongBan.Location = new Point(443, 45);
            lblSoLuongBan.Name = "lblSoLuongBan";
            lblSoLuongBan.Size = new Size(53, 23);
            lblSoLuongBan.TabIndex = 4;
            lblSoLuongBan.Text = "SL (*):";
            // 
            // lblDonGiaBan
            // 
            lblDonGiaBan.AutoSize = true;
            lblDonGiaBan.Font = new Font("Segoe UI", 10F);
            lblDonGiaBan.ForeColor = Color.FromArgb(33, 37, 41);
            lblDonGiaBan.Location = new Point(241, 44);
            lblDonGiaBan.Name = "lblDonGiaBan";
            lblDonGiaBan.Size = new Size(39, 23);
            lblDonGiaBan.TabIndex = 2;
            lblDonGiaBan.Text = "Giá:";
            // 
            // lblSach
            // 
            lblSach.AutoSize = true;
            lblSach.Font = new Font("Segoe UI", 10F);
            lblSach.ForeColor = Color.FromArgb(33, 37, 41);
            lblSach.Location = new Point(15, 45);
            lblSach.Name = "lblSach";
            lblSach.Size = new Size(72, 23);
            lblSach.TabIndex = 0;
            lblSach.Text = "Sách (*):";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.Gray;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SachID, TenSach, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(226, 232, 240);
            dataGridView.Location = new Point(11, 249);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 32;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(871, 270);
            dataGridView.TabIndex = 2;
            // 
            // SachID
            // 
            SachID.DataPropertyName = "SachID";
            SachID.FillWeight = 55F;
            SachID.HeaderText = "ID";
            SachID.MinimumWidth = 6;
            SachID.Name = "SachID";
            SachID.ReadOnly = true;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle2;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle3;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.Blue;
            dataGridViewCellStyle4.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Anchor = AnchorStyles.Bottom;
            btnLuuHoaDon.BackColor = Color.FromArgb(71, 51, 255);
            btnLuuHoaDon.Cursor = Cursors.Hand;
            btnLuuHoaDon.FlatAppearance.BorderSize = 0;
            btnLuuHoaDon.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnLuuHoaDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnLuuHoaDon.FlatStyle = FlatStyle.Flat;
            btnLuuHoaDon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLuuHoaDon.ForeColor = Color.White;
            btnLuuHoaDon.Location = new Point(252, 536);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(118, 35);
            btnLuuHoaDon.TabIndex = 3;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.Bottom;
            btnInHoaDon.BackColor = Color.Red;
            btnInHoaDon.Cursor = Cursors.Hand;
            btnInHoaDon.FlatAppearance.BorderSize = 0;
            btnInHoaDon.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnInHoaDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.White;
            btnInHoaDon.Location = new Point(395, 536);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(112, 35);
            btnInHoaDon.TabIndex = 4;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
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
            btnThoat.Location = new Point(534, 536);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(84, 35);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(892, 590);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(dataGridView);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(908, 629);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChuHoaDon;
        private System.Windows.Forms.Button btnTimKhachTheoSdt;
        private System.Windows.Forms.TextBox txtSdtTraCuu;
        private System.Windows.Forms.Label lblSdtTraCuu;
        private System.Windows.Forms.Button btnLapKhachHangMoi;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXacNhanBan;
        private System.Windows.Forms.NumericUpDown numSoLuongBan;
        private System.Windows.Forms.NumericUpDown numDonGiaBan;
        private System.Windows.Forms.ComboBox cboSach;
        private System.Windows.Forms.Label lblSoLuongBan;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.Label lblSach;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SachID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}

