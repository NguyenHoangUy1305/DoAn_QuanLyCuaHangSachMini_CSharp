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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtGhiChuHoaDon = new TextBox();
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
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(lblGhiChu);
            groupBox1.Controls.Add(lblKhachHang);
            groupBox1.Controls.Add(lblNhanVien);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(871, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(100, 78);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(752, 27);
            txtGhiChuHoaDon.TabIndex = 5;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(511, 37);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(362, 28);
            cboKhachHang.TabIndex = 3;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(119, 37);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(269, 28);
            cboNhanVien.TabIndex = 1;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(15, 81);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(81, 20);
            lblGhiChu.TabIndex = 4;
            lblGhiChu.Text = "Ghi chú (*):";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Location = new Point(396, 37);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(109, 20);
            lblKhachHang.TabIndex = 2;
            lblKhachHang.Text = "Khách hàng (*):";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(15, 37);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(98, 20);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "Nhân viên (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(cboSach);
            groupBox2.Controls.Add(lblSoLuongBan);
            groupBox2.Controls.Add(lblDonGiaBan);
            groupBox2.Controls.Add(lblSach);
            groupBox2.Location = new Point(11, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(871, 95);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(780, 38);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(73, 35);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(652, 38);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(114, 35);
            btnXacNhanBan.TabIndex = 6;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(484, 42);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(133, 27);
            numSoLuongBan.TabIndex = 5;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(286, 42);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(151, 27);
            numDonGiaBan.TabIndex = 3;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // cboSach
            // 
            cboSach.FormattingEnabled = true;
            cboSach.Location = new Point(70, 41);
            cboSach.Name = "cboSach";
            cboSach.Size = new Size(175, 28);
            cboSach.TabIndex = 1;
            cboSach.SelectionChangeCommitted += cboSach_SelectionChangeCommitted;
            // 
            // lblSoLuongBan
            // 
            lblSoLuongBan.AutoSize = true;
            lblSoLuongBan.Location = new Point(443, 45);
            lblSoLuongBan.Name = "lblSoLuongBan";
            lblSoLuongBan.Size = new Size(47, 20);
            lblSoLuongBan.TabIndex = 4;
            lblSoLuongBan.Text = "SL (*):";
            // 
            // lblDonGiaBan
            // 
            lblDonGiaBan.AutoSize = true;
            lblDonGiaBan.Location = new Point(250, 45);
            lblDonGiaBan.Name = "lblDonGiaBan";
            lblDonGiaBan.Size = new Size(34, 20);
            lblDonGiaBan.TabIndex = 2;
            lblDonGiaBan.Text = "Giá:";
            // 
            // lblSach
            // 
            lblSach.AutoSize = true;
            lblSach.Location = new Point(15, 45);
            lblSach.Name = "lblSach";
            lblSach.Size = new Size(63, 20);
            lblSach.TabIndex = 0;
            lblSach.Text = "Sách (*):";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SachID, TenSach, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Location = new Point(11, 249);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            DonGiaBan.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Location = new Point(274, 536);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(107, 35);
            btnLuuHoaDon.TabIndex = 3;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(395, 536);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(98, 35);
            btnInHoaDon.TabIndex = 4;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(507, 536);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(84, 35);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 590);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(dataGridView);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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