namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmTheLoai
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grpThongTinTheLoai = new GroupBox();
            txtMoTa = new TextBox();
            lblMoTa = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboTenTheLoai = new ComboBox();
            txtMaTheLoai = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpDanhSachTheLoai = new GroupBox();
            dgvTheLoai = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaTheLoai = new DataGridViewTextBoxColumn();
            TenTheLoai = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            grpThongTinTheLoai.SuspendLayout();
            grpDanhSachTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            SuspendLayout();
            // 
            // grpThongTinTheLoai
            // 
            grpThongTinTheLoai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTinTheLoai.BackColor = Color.White;
            grpThongTinTheLoai.Controls.Add(txtMoTa);
            grpThongTinTheLoai.Controls.Add(lblMoTa);
            grpThongTinTheLoai.Controls.Add(btnXuat);
            grpThongTinTheLoai.Controls.Add(btnNhap);
            grpThongTinTheLoai.Controls.Add(btnTimKiem);
            grpThongTinTheLoai.Controls.Add(btnThoat);
            grpThongTinTheLoai.Controls.Add(btnHuyBo);
            grpThongTinTheLoai.Controls.Add(btnLuu);
            grpThongTinTheLoai.Controls.Add(btnXoa);
            grpThongTinTheLoai.Controls.Add(btnSua);
            grpThongTinTheLoai.Controls.Add(btnThem);
            grpThongTinTheLoai.Controls.Add(cboTenTheLoai);
            grpThongTinTheLoai.Controls.Add(txtMaTheLoai);
            grpThongTinTheLoai.Controls.Add(label2);
            grpThongTinTheLoai.Controls.Add(label1);
            grpThongTinTheLoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTinTheLoai.ForeColor = Color.FromArgb(55, 38, 210);
            grpThongTinTheLoai.Location = new Point(12, 12);
            grpThongTinTheLoai.Name = "grpThongTinTheLoai";
            grpThongTinTheLoai.Size = new Size(860, 178);
            grpThongTinTheLoai.TabIndex = 0;
            grpThongTinTheLoai.TabStop = false;
            grpThongTinTheLoai.Text = "Thông tin thể loại";
            // 
            // txtMoTa
            // 
            txtMoTa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMoTa.Location = new Point(121, 99);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(256, 30);
            txtMoTa.TabIndex = 4;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 10F);
            lblMoTa.ForeColor = Color.FromArgb(33, 37, 41);
            lblMoTa.Location = new Point(16, 102);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(59, 23);
            lblMoTa.TabIndex = 13;
            lblMoTa.Text = "Mô tả:";
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
            btnXuat.Location = new Point(750, 95);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(104, 34);
            btnXuat.TabIndex = 12;
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
            btnNhap.Location = new Point(748, 55);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(106, 34);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(71, 51, 255);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnTimKiem.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(383, 66);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(95, 28);
            btnTimKiem.TabIndex = 10;
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
            btnThoat.Location = new Point(639, 55);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 34);
            btnThoat.TabIndex = 9;
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
            btnHuyBo.Location = new Point(639, 95);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(98, 34);
            btnHuyBo.TabIndex = 8;
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
            btnLuu.Location = new Point(527, 55);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(98, 34);
            btnLuu.TabIndex = 7;
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
            btnXoa.Location = new Point(639, 15);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 34);
            btnXoa.TabIndex = 6;
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
            btnSua.Location = new Point(527, 95);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 34);
            btnSua.TabIndex = 5;
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
            btnThem.Location = new Point(527, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 34);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cboTenTheLoai
            // 
            cboTenTheLoai.BackColor = Color.White;
            cboTenTheLoai.FlatStyle = FlatStyle.Flat;
            cboTenTheLoai.Font = new Font("Segoe UI", 10F);
            cboTenTheLoai.FormattingEnabled = true;
            cboTenTheLoai.Location = new Point(121, 63);
            cboTenTheLoai.Name = "cboTenTheLoai";
            cboTenTheLoai.Size = new Size(256, 31);
            cboTenTheLoai.TabIndex = 3;
            // 
            // txtMaTheLoai
            // 
            txtMaTheLoai.BackColor = Color.FromArgb(248, 250, 252);
            txtMaTheLoai.Font = new Font("Segoe UI", 10F);
            txtMaTheLoai.Location = new Point(121, 27);
            txtMaTheLoai.Name = "txtMaTheLoai";
            txtMaTheLoai.ReadOnly = true;
            txtMaTheLoai.Size = new Size(256, 30);
            txtMaTheLoai.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(33, 37, 41);
            label2.Location = new Point(16, 66);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 0;
            label2.Text = "Tên thể loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã thể loại:";
            // 
            // grpDanhSachTheLoai
            // 
            grpDanhSachTheLoai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDanhSachTheLoai.BackColor = Color.White;
            grpDanhSachTheLoai.Controls.Add(dgvTheLoai);
            grpDanhSachTheLoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSachTheLoai.ForeColor = Color.FromArgb(55, 38, 210);
            grpDanhSachTheLoai.Location = new Point(12, 188);
            grpDanhSachTheLoai.Name = "grpDanhSachTheLoai";
            grpDanhSachTheLoai.Size = new Size(860, 300);
            grpDanhSachTheLoai.TabIndex = 1;
            grpDanhSachTheLoai.TabStop = false;
            grpDanhSachTheLoai.Text = "Danh sách thể loại";
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.AllowUserToAddRows = false;
            dgvTheLoai.AllowUserToDeleteRows = false;
            dgvTheLoai.AllowUserToResizeRows = false;
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoai.BackgroundColor = Color.Silver;
            dgvTheLoai.BorderStyle = BorderStyle.None;
            dgvTheLoai.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Columns.AddRange(new DataGridViewColumn[] { ID, MaTheLoai, TenTheLoai, MoTa });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTheLoai.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTheLoai.Dock = DockStyle.Fill;
            dgvTheLoai.EnableHeadersVisualStyles = false;
            dgvTheLoai.GridColor = Color.White;
            dgvTheLoai.Location = new Point(3, 26);
            dgvTheLoai.MultiSelect = false;
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.ReadOnly = true;
            dgvTheLoai.RowHeadersVisible = false;
            dgvTheLoai.RowHeadersWidth = 51;
            dgvTheLoai.RowTemplate.Height = 32;
            dgvTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoai.Size = new Size(854, 271);
            dgvTheLoai.TabIndex = 0;
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
            // MaTheLoai
            // 
            MaTheLoai.DataPropertyName = "MaTheLoai";
            MaTheLoai.HeaderText = "Mã thể loại";
            MaTheLoai.MinimumWidth = 6;
            MaTheLoai.Name = "MaTheLoai";
            MaTheLoai.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            TenTheLoai.DataPropertyName = "TenTheLoai";
            TenTheLoai.HeaderText = "Tên thể loại";
            TenTheLoai.MinimumWidth = 6;
            TenTheLoai.Name = "TenTheLoai";
            TenTheLoai.ReadOnly = true;
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô tả";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            // 
            // frmTheLoai
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(884, 500);
            Controls.Add(grpDanhSachTheLoai);
            Controls.Add(grpThongTinTheLoai);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(900, 540);
            Name = "frmTheLoai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thể loại";
            Load += frmTheLoai_Load;
            grpThongTinTheLoai.ResumeLayout(false);
            grpThongTinTheLoai.PerformLayout();
            grpDanhSachTheLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTinTheLoai;
        private GroupBox grpDanhSachTheLoai;
        private Label label1;
        private Label label2;
        private Label lblMoTa;
        private TextBox txtMaTheLoai;
        private ComboBox cboTenTheLoai;
        private TextBox txtMoTa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnNhap;
        private Button btnXuat;
        private DataGridView dgvTheLoai;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaTheLoai;
        private DataGridViewTextBoxColumn TenTheLoai;
        private DataGridViewTextBoxColumn MoTa;
    }
}
