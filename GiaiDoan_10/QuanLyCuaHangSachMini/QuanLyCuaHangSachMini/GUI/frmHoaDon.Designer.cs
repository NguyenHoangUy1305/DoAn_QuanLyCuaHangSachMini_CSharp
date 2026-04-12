namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            grpDanhSachHoaDon = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaHoaDon = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            HoVaTenKhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTienHoaDon = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            btnLapHoaDon = new Button();
            btnInHoaDon = new Button();
            btnHoanTra = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnXuat = new Button();
            grpDanhSachHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // grpDanhSachHoaDon
            // 
            grpDanhSachHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSachHoaDon.BackColor = Color.White;
            grpDanhSachHoaDon.Controls.Add(dataGridView);
            grpDanhSachHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSachHoaDon.ForeColor = Color.FromArgb(55, 38, 210);
            grpDanhSachHoaDon.Location = new Point(11, 12);
            grpDanhSachHoaDon.Name = "grpDanhSachHoaDon";
            grpDanhSachHoaDon.Size = new Size(989, 430);
            grpDanhSachHoaDon.TabIndex = 0;
            grpDanhSachHoaDon.TabStop = false;
            grpDanhSachHoaDon.Text = "Danh sách hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, MaHoaDon, HoVaTenNhanVien, HoVaTenKhachHang, NgayLap, TongTienHoaDon, XemChiTiet });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(226, 232, 240);
            dataGridView.Location = new Point(3, 26);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 32;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(983, 401);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
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
            // MaHoaDon
            // 
            MaHoaDon.DataPropertyName = "MaHoaDon";
            MaHoaDon.HeaderText = "Mã hóa đơn";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            // 
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Nhân viên";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // HoVaTenKhachHang
            // 
            HoVaTenKhachHang.DataPropertyName = "HoVaTenKhachHang";
            HoVaTenKhachHang.HeaderText = "Khách hàng";
            HoVaTenKhachHang.MinimumWidth = 6;
            HoVaTenKhachHang.Name = "HoVaTenKhachHang";
            HoVaTenKhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            NgayLap.DefaultCellStyle = dataGridViewCellStyle2;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTienHoaDon
            // 
            TongTienHoaDon.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            TongTienHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            TongTienHoaDon.HeaderText = "Tổng tiền";
            TongTienHoaDon.MinimumWidth = 6;
            TongTienHoaDon.Name = "TongTienHoaDon";
            TongTienHoaDon.ReadOnly = true;
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
            // btnLapHoaDon
            // 
            btnLapHoaDon.Anchor = AnchorStyles.Bottom;
            btnLapHoaDon.BackColor = Color.FromArgb(71, 51, 255);
            btnLapHoaDon.Cursor = Cursors.Hand;
            btnLapHoaDon.FlatAppearance.BorderSize = 0;
            btnLapHoaDon.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnLapHoaDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnLapHoaDon.FlatStyle = FlatStyle.Flat;
            btnLapHoaDon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLapHoaDon.ForeColor = Color.White;
            btnLapHoaDon.Location = new Point(69, 458);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(130, 35);
            btnLapHoaDon.TabIndex = 1;
            btnLapHoaDon.Text = "Lập hóa đơn";
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
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
            btnInHoaDon.Location = new Point(217, 458);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(120, 35);
            btnInHoaDon.TabIndex = 2;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnHoanTra
            // 
            btnHoanTra.Anchor = AnchorStyles.Bottom;
            btnHoanTra.BackColor = Color.Yellow;
            btnHoanTra.Cursor = Cursors.Hand;
            btnHoanTra.FlatAppearance.BorderSize = 0;
            btnHoanTra.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnHoanTra.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnHoanTra.FlatStyle = FlatStyle.Flat;
            btnHoanTra.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnHoanTra.ForeColor = Color.Black;
            btnHoanTra.Location = new Point(356, 458);
            btnHoanTra.Name = "btnHoanTra";
            btnHoanTra.Size = new Size(115, 35);
            btnHoanTra.TabIndex = 4;
            btnHoanTra.Text = "Hoàn trả";
            btnHoanTra.UseVisualStyleBackColor = false;
            btnHoanTra.Click += btnHoanTra_Click;
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
            btnThoat.Location = new Point(763, 458);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 35);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát ";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Bottom;
            btnTimKiem.BackColor = Color.FromArgb(71, 51, 255);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnTimKiem.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(502, 458);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(110, 35);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Bottom;
            btnXuat.BackColor = Color.FromArgb(71, 51, 255);
            btnXuat.Cursor = Cursors.Hand;
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXuat.ForeColor = Color.White;
            btnXuat.Location = new Point(631, 458);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(111, 35);
            btnXuat.TabIndex = 7;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1012, 512);
            Controls.Add(btnXuat);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThoat);
            Controls.Add(btnHoanTra);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLapHoaDon);
            Controls.Add(grpDanhSachHoaDon);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1028, 551);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa Đơn";
            Load += frmHoaDon_Load;
            grpDanhSachHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDanhSachHoaDon;
        private DataGridView dataGridView;
        private Button btnLapHoaDon;
        private Button btnInHoaDon;
        private Button btnHoanTra;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnXuat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn HoVaTenKhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTienHoaDon;
        private DataGridViewLinkColumn XemChiTiet;
    }
}
