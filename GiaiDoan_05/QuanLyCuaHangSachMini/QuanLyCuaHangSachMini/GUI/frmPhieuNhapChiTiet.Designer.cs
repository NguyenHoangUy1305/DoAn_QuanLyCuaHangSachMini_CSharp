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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtTongTien = new TextBox();
            txtGhiChu = new TextBox();
            dtpNgayNhap = new DateTimePicker();
            cboNhanVien = new ComboBox();
            cboNhaCungCap = new ComboBox();
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
            txtMaPhieuNhap = new TextBox();
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
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(987, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(544, 33);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(249, 27);
            txtTongTien.TabIndex = 11;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(544, 69);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(249, 72);
            txtGhiChu.TabIndex = 10;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(134, 138);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(249, 27);
            dtpNgayNhap.TabIndex = 9;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(134, 104);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(249, 28);
            cboNhanVien.TabIndex = 8;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(134, 58);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(249, 28);
            cboNhaCungCap.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 72);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 36);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 138);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 94);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 58);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhà cung cấp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu nhập:";
            label1.Visible = false;
            // 
            // groupBox2
            // 
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
            groupBox2.Location = new Point(11, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(987, 105);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách nhập";
            // 
            // btnXoaSach
            // 
            btnXoaSach.ForeColor = Color.Red;
            btnXoaSach.Location = new Point(877, 58);
            btnXoaSach.Name = "btnXoaSach";
            btnXoaSach.Size = new Size(84, 30);
            btnXoaSach.TabIndex = 9;
            btnXoaSach.Text = "Xóa sách";
            btnXoaSach.UseVisualStyleBackColor = true;
            btnXoaSach.Click += btnXoaSach_Click;
            // 
            // btnThemSach
            // 
            btnThemSach.Location = new Point(877, 22);
            btnThemSach.Name = "btnThemSach";
            btnThemSach.Size = new Size(84, 30);
            btnThemSach.TabIndex = 8;
            btnThemSach.Text = "Thêm sách";
            btnThemSach.UseVisualStyleBackColor = true;
            btnThemSach.Click += btnThemSach_Click;
            // 
            // numDonGiaNhap
            // 
            numDonGiaNhap.Location = new Point(604, 58);
            numDonGiaNhap.Name = "numDonGiaNhap";
            numDonGiaNhap.Size = new Size(249, 27);
            numDonGiaNhap.TabIndex = 7;
            numDonGiaNhap.ThousandsSeparator = true;
            // 
            // numSoLuongNhap
            // 
            numSoLuongNhap.Location = new Point(604, 22);
            numSoLuongNhap.Name = "numSoLuongNhap";
            numSoLuongNhap.Size = new Size(249, 27);
            numSoLuongNhap.TabIndex = 6;
            numSoLuongNhap.ThousandsSeparator = true;
            // 
            // cboTenSach
            // 
            cboTenSach.FormattingEnabled = true;
            cboTenSach.Location = new Point(101, 58);
            cboTenSach.Name = "cboTenSach";
            cboTenSach.Size = new Size(249, 28);
            cboTenSach.TabIndex = 5;
            cboTenSach.SelectedIndexChanged += cboTenSach_SelectedIndexChanged;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(101, 22);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.ReadOnly = true;
            txtMaSach.Size = new Size(249, 27);
            txtMaSach.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(489, 61);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 3;
            label10.Text = "Đơn giá nhập";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(489, 25);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 2;
            label9.Text = "Số lượng nhập";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 61);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 1;
            label8.Text = "Tên sách:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 25);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 0;
            label7.Text = "Mã sách:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvChiTiet);
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
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { ID, PhieuNhapID, SachID, MaSach, TenSach, SoLuongNhap, DonGiaNhap, ThanhTien });
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.Location = new Point(3, 23);
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(981, 289);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle4;
            SoLuongNhap.HeaderText = "Số lượng nhập";
            SoLuongNhap.MinimumWidth = 6;
            SoLuongNhap.Name = "SoLuongNhap";
            SoLuongNhap.ReadOnly = true;
            // 
            // DonGiaNhap
            // 
            DonGiaNhap.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            DonGiaNhap.DefaultCellStyle = dataGridViewCellStyle5;
            DonGiaNhap.HeaderText = "Đơn giá nhập";
            DonGiaNhap.MinimumWidth = 6;
            DonGiaNhap.Name = "DonGiaNhap";
            DonGiaNhap.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Blue;
            dataGridViewCellStyle6.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // btnLuuPhieuNhap
            // 
            btnLuuPhieuNhap.Location = new Point(717, 615);
            btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            btnLuuPhieuNhap.Size = new Size(107, 32);
            btnLuuPhieuNhap.TabIndex = 3;
            btnLuuPhieuNhap.Text = "Lưu phiếu nhập";
            btnLuuPhieuNhap.UseVisualStyleBackColor = true;
            btnLuuPhieuNhap.Click += btnLuuPhieuNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(829, 615);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(80, 32);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(915, 615);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 32);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.Location = new Point(134, 20);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.ReadOnly = true;
            txtMaPhieuNhap.Size = new Size(249, 27);
            txtMaPhieuNhap.TabIndex = 6;
            txtMaPhieuNhap.Visible = false;
            // 
            // frmPhieuNhapChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 659);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuuPhieuNhap);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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