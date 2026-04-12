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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
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
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dgvPhieuNhap);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(55, 38, 210);
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
            dgvPhieuNhap.AllowUserToResizeRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.BackgroundColor = Color.Gray;
            dgvPhieuNhap.BorderStyle = BorderStyle.None;
            dgvPhieuNhap.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle13.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { ID, MaPhieuNhap, TenNhaCungCap, HoVaTenNhanVien, NgayNhap, TongTienPhieuNhap, XemChiTiet });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle16;
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.EnableHeadersVisualStyles = false;
            dgvPhieuNhap.GridColor = Color.FromArgb(226, 232, 240);
            dgvPhieuNhap.Location = new Point(3, 26);
            dgvPhieuNhap.MultiSelect = false;
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.RowTemplate.Height = 32;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.Size = new Size(883, 401);
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
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "dd/MM/yyyy";
            NgayNhap.DefaultCellStyle = dataGridViewCellStyle14;
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // TongTienPhieuNhap
            // 
            TongTienPhieuNhap.DataPropertyName = "TongTienPhieuNhap";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = Color.Blue;
            dataGridViewCellStyle15.Format = "N0";
            TongTienPhieuNhap.DefaultCellStyle = dataGridViewCellStyle15;
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
            // 
            // btnLapPhieuNhap
            // 
            btnLapPhieuNhap.Anchor = AnchorStyles.Bottom;
            btnLapPhieuNhap.BackColor = Color.Red;
            btnLapPhieuNhap.Cursor = Cursors.Hand;
            btnLapPhieuNhap.FlatAppearance.BorderSize = 0;
            btnLapPhieuNhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnLapPhieuNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnLapPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnLapPhieuNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLapPhieuNhap.ForeColor = Color.White;
            btnLapPhieuNhap.Location = new Point(121, 458);
            btnLapPhieuNhap.Name = "btnLapPhieuNhap";
            btnLapPhieuNhap.Size = new Size(165, 35);
            btnLapPhieuNhap.TabIndex = 1;
            btnLapPhieuNhap.Text = "Lập phiếu nhập...";
            btnLapPhieuNhap.UseVisualStyleBackColor = false;
            btnLapPhieuNhap.Click += btnLapPhieuNhap_Click;
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Anchor = AnchorStyles.Bottom;
            btnInPhieuNhap.BackColor = Color.Yellow;
            btnInPhieuNhap.Cursor = Cursors.Hand;
            btnInPhieuNhap.FlatAppearance.BorderSize = 0;
            btnInPhieuNhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnInPhieuNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnInPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnInPhieuNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnInPhieuNhap.ForeColor = Color.Black;
            btnInPhieuNhap.Location = new Point(292, 458);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(140, 35);
            btnInPhieuNhap.TabIndex = 2;
            btnInPhieuNhap.Text = "In phiếu nhập...";
            btnInPhieuNhap.UseVisualStyleBackColor = false;
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // btnXoaPhieuNhap
            // 
            btnXoaPhieuNhap.Anchor = AnchorStyles.Bottom;
            btnXoaPhieuNhap.BackColor = Color.Red;
            btnXoaPhieuNhap.Cursor = Cursors.Hand;
            btnXoaPhieuNhap.FlatAppearance.BorderSize = 0;
            btnXoaPhieuNhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 25, 40);
            btnXoaPhieuNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            btnXoaPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnXoaPhieuNhap.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXoaPhieuNhap.ForeColor = Color.White;
            btnXoaPhieuNhap.Location = new Point(448, 458);
            btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            btnXoaPhieuNhap.Size = new Size(80, 35);
            btnXoaPhieuNhap.TabIndex = 3;
            btnXoaPhieuNhap.Text = "Xóa";
            btnXoaPhieuNhap.UseVisualStyleBackColor = false;
            btnXoaPhieuNhap.Click += btnXoaPhieuNhap_Click;
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
            btnThoat.Location = new Point(551, 458);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 35);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(910, 512);
            Controls.Add(btnThoat);
            Controls.Add(btnXoaPhieuNhap);
            Controls.Add(btnInPhieuNhap);
            Controls.Add(btnLapPhieuNhap);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(926, 551);
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
