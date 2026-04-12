using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmThongKeSach
    {
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1200, 700);
            reportViewer1.TabIndex = 0;
            // 
            // frmThongKeSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(reportViewer1);
            Name = "frmThongKeSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê sách";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeSach_Load;
            ResumeLayout(false);
        }
    }
}