namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmNhatKyHeThong
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBox1;
        private Label lblTuNgay;
        private Label lblDenNgay;
        private Label lblTuKhoa;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private TextBox txtTuKhoa;
        private Button btnLoc;
        private Button btnTaiLai;
        private Button btnDong;
        private DataGridView dgvNhatKy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblTuNgay = new Label();
            lblDenNgay = new Label();
            lblTuKhoa = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            txtTuKhoa = new TextBox();
            btnLoc = new Button();
            btnTaiLai = new Button();
            btnDong = new Button();
            dgvNhatKy = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhatKy).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTuNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(lblDenNgay);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(lblTuKhoa);
            groupBox1.Controls.Add(txtTuKhoa);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(btnTaiLai);
            groupBox1.Controls.Add(btnDong);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1260, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm nhật ký";
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Location = new Point(18, 40);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(56, 20);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(80, 35);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(130, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new Point(230, 40);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(67, 20);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(303, 35);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(130, 27);
            dtpDenNgay.TabIndex = 3;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Location = new Point(455, 40);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(61, 20);
            lblTuKhoa.TabIndex = 4;
            lblTuKhoa.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(522, 35);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(300, 27);
            txtTuKhoa.TabIndex = 5;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(850, 33);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(110, 31);
            btnLoc.TabIndex = 6;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(975, 33);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(110, 31);
            btnTaiLai.TabIndex = 7;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(1100, 33);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(110, 31);
            btnDong.TabIndex = 8;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // dgvNhatKy
            // 
            dgvNhatKy.AllowUserToAddRows = false;
            dgvNhatKy.AllowUserToDeleteRows = false;
            dgvNhatKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhatKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhatKy.Location = new Point(12, 110);
            dgvNhatKy.Name = "dgvNhatKy";
            dgvNhatKy.ReadOnly = true;
            dgvNhatKy.RowHeadersWidth = 51;
            dgvNhatKy.RowTemplate.Height = 29;
            dgvNhatKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhatKy.Size = new Size(1260, 560);
            dgvNhatKy.TabIndex = 1;
            // 
            // frmNhatKyHeThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 682);
            Controls.Add(dgvNhatKy);
            Controls.Add(groupBox1);
            Name = "frmNhatKyHeThong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhật ký hệ thống";
            Load += frmNhatKyHeThong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhatKy).EndInit();
            ResumeLayout(false);
        }
    }
}