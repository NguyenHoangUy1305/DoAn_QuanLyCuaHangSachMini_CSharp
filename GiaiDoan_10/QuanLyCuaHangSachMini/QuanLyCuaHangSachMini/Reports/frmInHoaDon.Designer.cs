namespace QuanLyCuaHangSachMini.Reports
{
    partial class frmInHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpNoiDung;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpNoiDung = new GroupBox();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            grpNoiDung.SuspendLayout();
            SuspendLayout();
            // 
            // grpNoiDung
            // 
            grpNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpNoiDung.Controls.Add(reportViewer1);
            grpNoiDung.Location = new Point(12, 12);
            grpNoiDung.Name = "grpNoiDung";
            grpNoiDung.Size = new Size(976, 626);
            grpNoiDung.TabIndex = 0;
            grpNoiDung.TabStop = false;
            grpNoiDung.Text = "IN HÓA ĐƠN";
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(3, 23);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(970, 600);
            reportViewer1.TabIndex = 0;
            // 
            // frmInHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(grpNoiDung);
            Name = "frmInHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "In hóa đơn";
            Load += frmInHoaDon_Load;
            grpNoiDung.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}