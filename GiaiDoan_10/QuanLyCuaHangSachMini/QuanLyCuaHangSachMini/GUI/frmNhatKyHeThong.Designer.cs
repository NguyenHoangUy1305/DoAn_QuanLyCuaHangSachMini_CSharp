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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            lblTuNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpDenNgay = new DateTimePicker();
            lblTuKhoa = new Label();
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
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(lblTuNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(lblDenNgay);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(lblTuKhoa);
            groupBox1.Controls.Add(txtTuKhoa);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(btnTaiLai);
            groupBox1.Controls.Add(btnDong);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(55, 38, 210);
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
            lblTuNgay.Font = new Font("Segoe UI", 10F);
            lblTuNgay.ForeColor = Color.FromArgb(33, 37, 41);
            lblTuNgay.Location = new Point(18, 40);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(71, 23);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Font = new Font("Segoe UI", 10F);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(95, 35);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(130, 30);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Segoe UI", 10F);
            lblDenNgay.ForeColor = Color.FromArgb(33, 37, 41);
            lblDenNgay.Location = new Point(230, 40);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(83, 23);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Font = new Font("Segoe UI", 10F);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(319, 35);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(130, 30);
            dtpDenNgay.TabIndex = 3;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Font = new Font("Segoe UI", 10F);
            lblTuKhoa.ForeColor = Color.FromArgb(33, 37, 41);
            lblTuKhoa.Location = new Point(455, 40);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(71, 23);
            lblTuKhoa.TabIndex = 4;
            lblTuKhoa.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTuKhoa.Font = new Font("Segoe UI", 10F);
            txtTuKhoa.Location = new Point(522, 35);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(300, 30);
            txtTuKhoa.TabIndex = 5;
            // 
            // btnLoc
            // 
            btnLoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoc.BackColor = Color.FromArgb(71, 51, 255);
            btnLoc.Cursor = Cursors.Hand;
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnLoc.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLoc.ForeColor = Color.White;
            btnLoc.Location = new Point(850, 33);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(110, 31);
            btnLoc.TabIndex = 6;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTaiLai.BackColor = Color.FromArgb(71, 51, 255);
            btnTaiLai.Cursor = Cursors.Hand;
            btnTaiLai.FlatAppearance.BorderSize = 0;
            btnTaiLai.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnTaiLai.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnTaiLai.FlatStyle = FlatStyle.Flat;
            btnTaiLai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTaiLai.ForeColor = Color.White;
            btnTaiLai.Location = new Point(975, 33);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(110, 31);
            btnTaiLai.TabIndex = 7;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDong.BackColor = Color.White;
            btnDong.Cursor = Cursors.Hand;
            btnDong.FlatAppearance.BorderColor = Color.FromArgb(71, 51, 255);
            btnDong.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 255);
            btnDong.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 244, 255);
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDong.ForeColor = Color.FromArgb(71, 51, 255);
            btnDong.Location = new Point(1100, 33);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(110, 31);
            btnDong.TabIndex = 8;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // dgvNhatKy
            // 
            dgvNhatKy.AllowUserToAddRows = false;
            dgvNhatKy.AllowUserToDeleteRows = false;
            dgvNhatKy.AllowUserToResizeRows = false;
            dgvNhatKy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhatKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhatKy.BackgroundColor = Color.Gray;
            dgvNhatKy.BorderStyle = BorderStyle.None;
            dgvNhatKy.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhatKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhatKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 232, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNhatKy.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhatKy.EnableHeadersVisualStyles = false;
            dgvNhatKy.GridColor = Color.FromArgb(226, 232, 240);
            dgvNhatKy.Location = new Point(12, 110);
            dgvNhatKy.Name = "dgvNhatKy";
            dgvNhatKy.ReadOnly = true;
            dgvNhatKy.RowHeadersVisible = false;
            dgvNhatKy.RowHeadersWidth = 51;
            dgvNhatKy.RowTemplate.Height = 32;
            dgvNhatKy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhatKy.Size = new Size(1260, 560);
            dgvNhatKy.TabIndex = 1;
            // 
            // frmNhatKyHeThong
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1284, 682);
            Controls.Add(dgvNhatKy);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1300, 721);
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
