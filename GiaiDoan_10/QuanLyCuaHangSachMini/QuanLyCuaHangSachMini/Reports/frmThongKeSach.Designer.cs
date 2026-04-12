namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmThongKeSach
    {
        private System.ComponentModel.IContainer components = null;
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
            grpBaoCao = new GroupBox();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            grpBaoCao.SuspendLayout();
            SuspendLayout();
            // 
            // grpBaoCao
            // 
            grpBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBaoCao.Controls.Add(reportViewer1);
            grpBaoCao.Location = new Point(12, 12);
            grpBaoCao.Name = "grpBaoCao";
            grpBaoCao.Size = new Size(1176, 676);
            grpBaoCao.TabIndex = 0;
            grpBaoCao.TabStop = false;
            grpBaoCao.Text = "BÁO CÁO THỐNG KÊ SÁCH";
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(3, 23);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1170, 650);
            reportViewer1.TabIndex = 0;
            // 
            // frmThongKeSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(grpBaoCao);
            Name = "frmThongKeSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê sách";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeSach_Load;
            grpBaoCao.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}