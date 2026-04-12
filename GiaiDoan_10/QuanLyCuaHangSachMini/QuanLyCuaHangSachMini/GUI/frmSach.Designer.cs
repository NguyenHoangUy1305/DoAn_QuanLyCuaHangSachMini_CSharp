namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmSach
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            txtMoTa = new TextBox();
            numGiaBan = new NumericUpDown();
            numGiaNhap = new NumericUpDown();
            numSoLuongTon = new NumericUpDown();
            txtTacGia = new TextBox();
            cboTenSach = new ComboBox();
            cboNhaXuatBan = new ComboBox();
            cboTheLoai = new ComboBox();
            txtMaSach = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvSach = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaSach = new DataGridViewTextBoxColumn();
            TenTheLoai = new DataGridViewTextBoxColumn();
            TenNhaXuatBan = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            TacGia = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongTon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(numGiaBan);
            groupBox1.Controls.Add(numGiaNhap);
            groupBox1.Controls.Add(numSoLuongTon);
            groupBox1.Controls.Add(txtTacGia);
            groupBox1.Controls.Add(cboTenSach);
            groupBox1.Controls.Add(cboNhaXuatBan);
            groupBox1.Controls.Add(cboTheLoai);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(55, 38, 210);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1240, 245);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
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
            btnXuat.Location = new Point(1120, 128);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(95, 30);
            btnXuat.TabIndex = 28;
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
            btnNhap.Location = new Point(1120, 77);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(95, 30);
            btnNhap.TabIndex = 27;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
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
            btnTimKiem.Location = new Point(1120, 26);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(95, 30);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
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
            btnThoat.Location = new Point(1019, 128);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 30);
            btnThoat.TabIndex = 25;
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
            btnHuyBo.Location = new Point(1019, 77);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(95, 30);
            btnHuyBo.TabIndex = 24;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
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
            btnLuu.Location = new Point(918, 79);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(95, 30);
            btnLuu.TabIndex = 23;
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
            btnXoa.Location = new Point(1019, 26);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 30);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
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
            btnSua.Location = new Point(918, 128);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 30);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
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
            btnThem.Location = new Point(918, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 30);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.BackColor = Color.White;
            btnDoiAnh.Cursor = Cursors.Hand;
            btnDoiAnh.FlatAppearance.BorderColor = Color.FromArgb(71, 51, 255);
            btnDoiAnh.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 255);
            btnDoiAnh.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 244, 255);
            btnDoiAnh.FlatStyle = FlatStyle.Flat;
            btnDoiAnh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDoiAnh.ForeColor = Color.FromArgb(71, 51, 255);
            btnDoiAnh.Location = new Point(772, 147);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(95, 30);
            btnDoiAnh.TabIndex = 19;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(756, 26);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(120, 102);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 18;
            picHinhAnh.TabStop = false;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 10F);
            txtMoTa.Location = new Point(466, 149);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(254, 60);
            txtMoTa.TabIndex = 17;
            // 
            // numGiaBan
            // 
            numGiaBan.Font = new Font("Segoe UI", 10F);
            numGiaBan.Location = new Point(478, 113);
            numGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaBan.Name = "numGiaBan";
            numGiaBan.Size = new Size(242, 30);
            numGiaBan.TabIndex = 16;
            numGiaBan.ThousandsSeparator = true;
            // 
            // numGiaNhap
            // 
            numGiaNhap.Font = new Font("Segoe UI", 10F);
            numGiaNhap.Location = new Point(478, 75);
            numGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaNhap.Name = "numGiaNhap";
            numGiaNhap.ReadOnly = true;
            numGiaNhap.Size = new Size(242, 30);
            numGiaNhap.TabIndex = 15;
            numGiaNhap.ThousandsSeparator = true;
            // 
            // numSoLuongTon
            // 
            numSoLuongTon.Font = new Font("Segoe UI", 10F);
            numSoLuongTon.Location = new Point(502, 38);
            numSoLuongTon.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSoLuongTon.Name = "numSoLuongTon";
            numSoLuongTon.Size = new Size(218, 30);
            numSoLuongTon.TabIndex = 14;
            numSoLuongTon.ThousandsSeparator = true;
            // 
            // txtTacGia
            // 
            txtTacGia.Font = new Font("Segoe UI", 10F);
            txtTacGia.Location = new Point(121, 182);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(280, 30);
            txtTacGia.TabIndex = 13;
            // 
            // cboTenSach
            // 
            cboTenSach.BackColor = Color.White;
            cboTenSach.FlatStyle = FlatStyle.Flat;
            cboTenSach.Font = new Font("Segoe UI", 10F);
            cboTenSach.FormattingEnabled = true;
            cboTenSach.Location = new Point(132, 146);
            cboTenSach.Name = "cboTenSach";
            cboTenSach.Size = new Size(280, 31);
            cboTenSach.TabIndex = 12;
            cboTenSach.SelectionChangeCommitted += cboTenSach_SelectionChangeCommitted;
            // 
            // cboNhaXuatBan
            // 
            cboNhaXuatBan.BackColor = Color.White;
            cboNhaXuatBan.FlatStyle = FlatStyle.Flat;
            cboNhaXuatBan.Font = new Font("Segoe UI", 10F);
            cboNhaXuatBan.FormattingEnabled = true;
            cboNhaXuatBan.Location = new Point(140, 109);
            cboNhaXuatBan.Name = "cboNhaXuatBan";
            cboNhaXuatBan.Size = new Size(280, 31);
            cboNhaXuatBan.TabIndex = 11;
            // 
            // cboTheLoai
            // 
            cboTheLoai.BackColor = Color.White;
            cboTheLoai.FlatStyle = FlatStyle.Flat;
            cboTheLoai.Font = new Font("Segoe UI", 10F);
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(132, 72);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(280, 31);
            cboTheLoai.TabIndex = 10;
            // 
            // txtMaSach
            // 
            txtMaSach.BackColor = Color.FromArgb(248, 250, 252);
            txtMaSach.Font = new Font("Segoe UI", 10F);
            txtMaSach.Location = new Point(121, 38);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(280, 30);
            txtMaSach.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.FromArgb(33, 37, 41);
            label9.Location = new Point(409, 160);
            label9.Name = "label9";
            label9.Size = new Size(59, 23);
            label9.TabIndex = 8;
            label9.Text = "Mô tả:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(33, 37, 41);
            label8.Location = new Point(409, 115);
            label8.Name = "label8";
            label8.Size = new Size(73, 23);
            label8.TabIndex = 7;
            label8.Text = "Giá bán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(33, 37, 41);
            label7.Location = new Point(407, 79);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 6;
            label7.Text = "Giá nhập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(33, 37, 41);
            label6.Location = new Point(407, 41);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 5;
            label6.Text = "Số lượng tồn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(33, 37, 41);
            label5.Location = new Point(16, 185);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 4;
            label5.Text = "Tác giả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(33, 37, 41);
            label4.Location = new Point(16, 149);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 3;
            label4.Text = "Tên sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(33, 37, 41);
            label3.Location = new Point(16, 113);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 2;
            label3.Text = "Nhà xuất bản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(33, 37, 41);
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 1;
            label2.Text = "Thể loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(77, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã sách:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgvSach);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(55, 38, 210);
            groupBox2.Location = new Point(12, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1240, 395);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sách";
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AllowUserToResizeRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.BackgroundColor = Color.Silver;
            dgvSach.BorderStyle = BorderStyle.None;
            dgvSach.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { ID, MaSach, TenTheLoai, TenNhaXuatBan, TenSach, TacGia, SoLuongTon, GiaBan, HinhAnh });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSach.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSach.Dock = DockStyle.Fill;
            dgvSach.EnableHeadersVisualStyles = false;
            dgvSach.GridColor = Color.FromArgb(226, 232, 240);
            dgvSach.Location = new Point(3, 26);
            dgvSach.MultiSelect = false;
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersVisible = false;
            dgvSach.RowHeadersWidth = 51;
            dgvSach.RowTemplate.Height = 80;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(1234, 366);
            dgvSach.TabIndex = 0;
            dgvSach.CellClick += dgvSach_CellClick;
            dgvSach.CellFormatting += dgvSach_CellFormatting;
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
            // MaSach
            // 
            MaSach.DataPropertyName = "MaSach";
            MaSach.HeaderText = "Mã sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            MaSach.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            TenTheLoai.DataPropertyName = "TenTheLoai";
            TenTheLoai.HeaderText = "Thể loại";
            TenTheLoai.MinimumWidth = 6;
            TenTheLoai.Name = "TenTheLoai";
            TenTheLoai.ReadOnly = true;
            // 
            // TenNhaXuatBan
            // 
            TenNhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            TenNhaXuatBan.HeaderText = "Nhà xuất bản";
            TenNhaXuatBan.MinimumWidth = 6;
            TenNhaXuatBan.Name = "TenNhaXuatBan";
            TenNhaXuatBan.ReadOnly = true;
            // 
            // TenSach
            // 
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            // 
            // TacGia
            // 
            TacGia.DataPropertyName = "TacGia";
            TacGia.HeaderText = "Tác giả";
            TacGia.MinimumWidth = 6;
            TacGia.Name = "TacGia";
            TacGia.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            GiaBan.DefaultCellStyle = dataGridViewCellStyle3;
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // frmSach
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1264, 670);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1280, 709);
            Name = "frmSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sách";
            Load += frmSach_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongTon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private TextBox txtMoTa;
        private NumericUpDown numGiaBan;
        private NumericUpDown numGiaNhap;
        private NumericUpDown numSoLuongTon;
        private TextBox txtTacGia;
        private ComboBox cboTenSach;
        private ComboBox cboNhaXuatBan;
        private ComboBox cboTheLoai;
        private TextBox txtMaSach;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvSach;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenTheLoai;
        private DataGridViewTextBoxColumn TenNhaXuatBan;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewImageColumn HinhAnh;
    }
}
