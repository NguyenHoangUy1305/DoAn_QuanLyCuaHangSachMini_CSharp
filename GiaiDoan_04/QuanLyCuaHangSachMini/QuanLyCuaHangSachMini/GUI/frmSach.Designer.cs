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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1240, 245);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1120, 146);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(95, 30);
            btnXuat.TabIndex = 28;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1120, 77);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(95, 30);
            btnNhap.TabIndex = 27;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1019, 74);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(95, 30);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1019, 144);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 30);
            btnThoat.TabIndex = 25;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1120, 26);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(95, 30);
            btnHuyBo.TabIndex = 24;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1019, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(95, 30);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(918, 74);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 30);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(918, 143);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 30);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(918, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 30);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(772, 147);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(95, 30);
            btnDoiAnh.TabIndex = 19;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
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
            txtMoTa.Location = new Point(466, 149);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(254, 60);
            txtMoTa.TabIndex = 17;
            // 
            // numGiaBan
            // 
            numGiaBan.Location = new Point(478, 113);
            numGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaBan.Name = "numGiaBan";
            numGiaBan.Size = new Size(242, 27);
            numGiaBan.TabIndex = 16;
            numGiaBan.ThousandsSeparator = true;
            // 
            // numGiaNhap
            // 
            numGiaNhap.Location = new Point(478, 75);
            numGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaNhap.Name = "numGiaNhap";
            numGiaNhap.ReadOnly = true;
            numGiaNhap.Size = new Size(242, 27);
            numGiaNhap.TabIndex = 15;
            numGiaNhap.ThousandsSeparator = true;
            // 
            // numSoLuongTon
            // 
            numSoLuongTon.Location = new Point(502, 38);
            numSoLuongTon.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numSoLuongTon.Name = "numSoLuongTon";
            numSoLuongTon.Size = new Size(218, 27);
            numSoLuongTon.TabIndex = 14;
            numSoLuongTon.ThousandsSeparator = true;
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(121, 182);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(280, 27);
            txtTacGia.TabIndex = 13;
            // 
            // cboTenSach
            // 
            cboTenSach.FormattingEnabled = true;
            cboTenSach.Location = new Point(121, 146);
            cboTenSach.Name = "cboTenSach";
            cboTenSach.Size = new Size(280, 28);
            cboTenSach.TabIndex = 12;
            cboTenSach.SelectionChangeCommitted += cboTenSach_SelectionChangeCommitted;
            // 
            // cboNhaXuatBan
            // 
            cboNhaXuatBan.FormattingEnabled = true;
            cboNhaXuatBan.Location = new Point(121, 110);
            cboNhaXuatBan.Name = "cboNhaXuatBan";
            cboNhaXuatBan.Size = new Size(280, 28);
            cboNhaXuatBan.TabIndex = 11;
            // 
            // cboTheLoai
            // 
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(121, 74);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(280, 28);
            cboTheLoai.TabIndex = 10;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(121, 38);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(280, 27);
            txtMaSach.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(409, 160);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 8;
            label9.Text = "Mô tả:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 115);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 7;
            label8.Text = "Giá bán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 79);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 6;
            label7.Text = "Giá nhập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 41);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 5;
            label6.Text = "Số lượng tồn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 185);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Tác giả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 149);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 113);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhà xuất bản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Thể loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sách:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSach);
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
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { ID, MaSach, TenTheLoai, TenNhaXuatBan, TenSach, TacGia, SoLuongTon, GiaBan, HinhAnh });
            dgvSach.Dock = DockStyle.Fill;
            dgvSach.Location = new Point(3, 23);
            dgvSach.MultiSelect = false;
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.RowHeadersVisible = false;
            dgvSach.RowTemplate.Height = 80;
            dgvSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSach.Size = new Size(1234, 369);
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
            SoLuongTon.HeaderText = "Số lượng tồn";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            SoLuongTon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            SoLuongTon.DefaultCellStyle.Format = "N0";
            SoLuongTon.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            GiaBan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GiaBan.DefaultCellStyle.Format = "N0";
            GiaBan.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 670);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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