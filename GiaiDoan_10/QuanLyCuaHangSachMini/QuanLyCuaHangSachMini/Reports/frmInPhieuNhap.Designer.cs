namespace QuanLyCuaHangSachMini.Reports
{
    partial class frmInPhieuNhap
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
            grpNoiDung.Size = new Size(1076, 676);
            grpNoiDung.TabIndex = 0;
            grpNoiDung.TabStop = false;
            grpNoiDung.Text = "IN PHIẾU NHẬP";
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(3, 23);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1070, 650);
            reportViewer1.TabIndex = 0;
            // 
            // frmInPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(grpNoiDung);
            Name = "frmInPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "In phiếu nhập";
            Load += frmInPhieuNhap_Load;
            grpNoiDung.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}