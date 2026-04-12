namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmThongKeDoanhThu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpBocLoc;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnLocKetQua;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.GroupBox grpBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpBocLoc = new GroupBox();
            lblTuNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpDenNgay = new DateTimePicker();
            btnLocKetQua = new Button();
            btnHienTatCa = new Button();
            grpBaoCao = new GroupBox();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            grpBocLoc.SuspendLayout();
            grpBaoCao.SuspendLayout();
            SuspendLayout();
            // 
            // grpBocLoc
            // 
            grpBocLoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBocLoc.Controls.Add(lblTuNgay);
            grpBocLoc.Controls.Add(dtpTuNgay);
            grpBocLoc.Controls.Add(lblDenNgay);
            grpBocLoc.Controls.Add(dtpDenNgay);
            grpBocLoc.Controls.Add(btnLocKetQua);
            grpBocLoc.Controls.Add(btnHienTatCa);
            grpBocLoc.Location = new Point(12, 12);
            grpBocLoc.Name = "grpBocLoc";
            grpBocLoc.Size = new Size(1260, 92);
            grpBocLoc.TabIndex = 0;
            grpBocLoc.TabStop = false;
            grpBocLoc.Text = "BỘ LỌC DOANH THU";
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Location = new Point(19, 43);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(62, 20);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(100, 40);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(130, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new Point(256, 43);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(72, 20);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(344, 40);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(130, 27);
            dtpDenNgay.TabIndex = 3;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(510, 38);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(110, 32);
            btnLocKetQua.TabIndex = 4;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(636, 38);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(110, 32);
            btnHienTatCa.TabIndex = 5;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // grpBaoCao
            // 
            grpBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBaoCao.Controls.Add(reportViewer1);
            grpBaoCao.Location = new Point(12, 110);
            grpBaoCao.Name = "grpBaoCao";
            grpBaoCao.Size = new Size(1260, 585);
            grpBaoCao.TabIndex = 1;
            grpBaoCao.TabStop = false;
            grpBaoCao.Text = "BÁO CÁO DOANH THU";
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(3, 23);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1254, 559);
            reportViewer1.TabIndex = 0;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 707);
            Controls.Add(grpBaoCao);
            Controls.Add(grpBocLoc);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeDoanhThu_Load;
            grpBocLoc.ResumeLayout(false);
            grpBocLoc.PerformLayout();
            grpBaoCao.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}