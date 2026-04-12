namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmThongKeDoanhThu
    {
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label lblTuNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnLocKetQua;
        private Button btnHienTatCa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            lblTuNgay = new Label();
            lblDenNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnLocKetQua = new Button();
            btnHienTatCa = new Button();
            SuspendLayout();
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Location = new Point(20, 18);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(61, 20);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(87, 14);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31);
            dtpTuNgay.MinDate = new DateTime(2020, 1, 1);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(130, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new Point(240, 18);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(70, 20);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(316, 14);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31);
            dtpDenNgay.MinDate = new DateTime(2020, 1, 1);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(130, 27);
            dtpDenNgay.TabIndex = 3;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(465, 12);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(110, 30);
            btnLocKetQua.TabIndex = 4;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(585, 12);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(110, 30);
            btnHienTatCa.TabIndex = 5;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(12, 55);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1260, 640);
            reportViewer1.TabIndex = 6;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 707);
            Controls.Add(reportViewer1);
            Controls.Add(btnHienTatCa);
            Controls.Add(btnLocKetQua);
            Controls.Add(dtpDenNgay);
            Controls.Add(lblDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(lblTuNgay);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeDoanhThu_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}