namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmPhieuNhapChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtTongTien = new TextBox();
            txtGhiChu = new TextBox();
            dtpNgayNhap = new DateTimePicker();
            cboNhanVien = new ComboBox();
            cboNhaCungCap = new ComboBox();
            txtMaPhieuNhap = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoaSach = new Button();
            btnThemSach = new Button();
            numDonGiaNhap = new NumericUpDown();
            numSoLuongNhap = new NumericUpDown();
            cboTenSach = new ComboBox();
            txtMaSach = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            dgvChiTiet = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PhieuNhapID = new DataGridViewTextBoxColumn();
            SachID = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            DonGiaNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuuPhieuNhap = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtTongTien);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(dtpNgayNhap);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(txtMaPhieuNhap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(55, 38, 210);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(987, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.FromArgb(248, 250, 252);
            txtTongTien.Font = new Font("Segoe UI", 10F);
            txtTongTien.Location = new Point(544, 33);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(249, 30);
            txtTongTien.TabIndex = 11;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGhiChu.Font = new Font("Segoe UI", 10F);
            txtGhiChu.Location = new Point(544, 69);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(427, 72);
            txtGhiChu.TabIndex = 10;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Font = new Font("Segoe UI", 10F);
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(134, 138);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(249, 30);
            dtpNgayNhap.TabIndex = 9;
            // 
            // cboNhanVien
            // 
            cboNhanVien.BackColor = Color.White;
            cboNhanVien.FlatStyle = FlatStyle.Flat;
            cboNhanVien.Font = new Font("Segoe UI", 10F);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(134, 104);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(249, 31);
            cboNhanVien.TabIndex = 8;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.BackColor = Color.White;
            cboNhaCungCap.FlatStyle = FlatStyle.Flat;
            cboNhaCungCap.Font = new Font("Segoe UI", 10F);
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(134, 58);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(249, 31);
            cboNhaCungCap.TabIndex = 7;
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.BackColor = Color.FromArgb(248, 250, 252);
            txtMaPhieuNhap.Font = new Font("Segoe UI", 10F);
            txtMaPhieuNhap.Location = new Point(134, 20);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.ReadOnly = true;
            txtMaPhieuNhap.Size = new Size(249, 30);
            txtMaPhieuNhap.TabIndex = 6;
            txtMaPhieuNhap.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(33, 37, 41);
            label6.Location = new Point(450, 72);
            label6.Name = "label6";
            label6.Size = new Size(73, 23);
            label6.TabIndex = 5;
            label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(33, 37, 41);
            label5.Location = new Point(450, 36);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(33, 37, 41);
            label4.Location = new Point(14, 138);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 3;
            label4.Text = "Ngày nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(33, 37, 41);
            label3.Location = new Point(14, 94);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(33, 37, 41);
            label2.Location = new Point(14, 58);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 1;
            label2.Text = "Nhà cung cấp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu nhập:";
            label1.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnXoaSach);
            groupBox2.Controls.Add(btnThemSach);
            groupBox2.Controls.Add(numDonGiaNhap);
            groupBox2.Controls.Add(numSoLuongNhap);
            groupBox2.Controls.Add(cboTenSach);
            groupBox2.Controls.Add(txtMaSach);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(55, 38, 210);
            groupBox2.Location = new Point(11, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(987, 105);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách nhập";
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
            btnXoaSach.Location = new Point(877, 58);
            btnXoaSach.Name = "btnXoaSach";
            btnXoaSach.Size = new Size(84, 30);
            btnXoaSach.TabIndex = 9;
            btnXoaSach.Text = "Xóa sách";
            btnXoaSach.UseVisualStyleBackColor = false;
            btnXoaSach.Click += btnXoaSach_Click;
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
            btnThemSach.Location = new Point(877, 22);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(84, 30);
            btnThemSach.TabIndex = 8;
            btnThemSach.Text = "Thêm sách";
            btnThemSach.UseVisualStyleBackColor = false;
            btnThemSach.Click += btnThemSach_Click;
            // 
            // numDonGiaNhap
            // 
            numDonGiaNhap.Font = new Font("Segoe UI", 10F);
            numDonGiaNhap.Location = new Point(604, 58);
            numDonGiaNhap.Name = "numDonGiaNhap";
            numDonGiaNhap.Size = new Size(249, 30);
            numDonGiaNhap.TabIndex = 7;
            numDonGiaNhap.ThousandsSeparator = true;
            // 
            // numSoLuongNhap
            // 
            numSoLuongNhap.Font = new Font("Segoe UI", 10F);
            numSoLuongNhap.Location = new Point(604, 22);
            numSoLuongNhap.Name = "numSoLuongNhap";
            numSoLuongNhap.Size = new Size(249, 30);
            numSoLuongNhap.TabIndex = 6;
            numSoLuongNhap.ThousandsSeparator = true;
            // 
            // cboTenSach
            // 
            cboTenSach.BackColor = Color.White;
            cboTenSach.FlatStyle = FlatStyle.Flat;
            cboTenSach.Font = new Font("Segoe UI", 10F);
            cboTenSach.FormattingEnabled = true;
            cboTenSach.Location = new Point(101, 58);
            cboTenSach.Name = "cboTenSach";
            cboTenSach.Size = new Size(249, 31);
            cboTenSach.TabIndex = 5;
            cboTenSach.SelectedIndexChanged += cboTenSach_SelectedIndexChanged;
            // 
            // txtMaSach
            // 
            txtMaSach.BackColor = Color.FromArgb(248, 250, 252);
            txtMaSach.Font = new Font("Segoe UI", 10F);
            txtMaSach.Location = new Point(101, 22);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.ReadOnly = true;
            txtMaSach.Size = new Size(249, 30);
            txtMaSach.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.FromArgb(33, 37, 41);
            label10.Location = new Point(489, 61);
            label10.Name = "label10";
            label10.Size = new Size(114, 23);
            label10.TabIndex = 3;
            label10.Text = "Đơn giá nhập";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.FromArgb(33, 37, 41);
            label9.Location = new Point(489, 25);
            label9.Name = "label9";
            label9.Size = new Size(122, 23);
            label9.TabIndex = 2;
            label9.Text = "Số lượng nhập";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(33, 37, 41);
            label8.Location = new Point(14, 61);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 1;
            label8.Text = "Tên sách:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(33, 37, 41);
            label7.Location = new Point(14, 25);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 0;
            label7.Text = "Mã sách:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(dgvChiTiet);
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(55, 38, 210);
            groupBox3.Location = new Point(11, 294);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(987, 315);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sách nhập";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.AllowUserToResizeRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.Gray;
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
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { ID, PhieuNhapID, SachID, MaSach, TenSach, SoLuongNhap, DonGiaNhap, ThanhTien });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle5;
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
            dgvChiTiet.Size = new Size(981, 286);
            dgvChiTiet.TabIndex = 0;
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
            // PhieuNhapID
            // 
            PhieuNhapID.DataPropertyName = "PhieuNhapID";
            PhieuNhapID.HeaderText = "PhieuNhapID";
            PhieuNhapID.MinimumWidth = 6;
            PhieuNhapID.Name = "PhieuNhapID";
            PhieuNhapID.ReadOnly = true;
            PhieuNhapID.Visible = false;
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
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongNhap.HeaderText = "Số lượng nhập";
            SoLuongNhap.MinimumWidth = 6;
            SoLuongNhap.Name = "SoLuongNhap";
            SoLuongNhap.ReadOnly = true;
            // 
            // DonGiaNhap
            // 
            DonGiaNhap.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            DonGiaNhap.DefaultCellStyle = dataGridViewCellStyle3;
            DonGiaNhap.HeaderText = "Đơn giá nhập";
            DonGiaNhap.MinimumWidth = 6;
            DonGiaNhap.Name = "DonGiaNhap";
            DonGiaNhap.ReadOnly = true;
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
            // btnLuuPhieuNhap
            // 
            btnLuuPhieuNhap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuuPhieuNhap.BackColor = Color.Red;
            btnLuuPhieuNhap.Cursor = Cursors.Hand;
            btnLuuPhieuNhap.FlatAppearance.BorderSize = 0;
            btnLuuPhieuNhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnLuuPhieuNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnLuuPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnLuuPhieuNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLuuPhieuNhap.ForeColor = Color.White;
            btnLuuPhieuNhap.Location = new Point(683, 615);
            btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            btnLuuPhieuNhap.Size = new Size(140, 32);
            btnLuuPhieuNhap.TabIndex = 3;
            btnLuuPhieuNhap.Text = "Lưu phiếu nhập";
            btnLuuPhieuNhap.UseVisualStyleBackColor = false;
            btnLuuPhieuNhap.Click += btnLuuPhieuNhap_Click;
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
            btnHuyBo.Location = new Point(829, 615);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(80, 32);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ";
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
            btnThoat.Location = new Point(915, 615);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 32);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmPhieuNhapChiTiet
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1008, 659);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuuPhieuNhap);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1024, 698);
            Name = "frmPhieuNhapChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu nhập chi tiết";
            Load += frmPhieuNhapChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongNhap).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTongTien;
        private TextBox txtGhiChu;
        private DateTimePicker dtpNgayNhap;
        private ComboBox cboNhanVien;
        private ComboBox cboNhaCungCap;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnXoaSach;
        private Button btnThemSach;
        private NumericUpDown numDonGiaNhap;
        private NumericUpDown numSoLuongNhap;
        private ComboBox cboTenSach;
        private TextBox txtMaSach;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox3;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PhieuNhapID;
        private DataGridViewTextBoxColumn SachID;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn DonGiaNhap;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnLuuPhieuNhap;
        private Button btnHuyBo;
        private Button btnThoat;
        private TextBox txtMaPhieuNhap;
    }
}
