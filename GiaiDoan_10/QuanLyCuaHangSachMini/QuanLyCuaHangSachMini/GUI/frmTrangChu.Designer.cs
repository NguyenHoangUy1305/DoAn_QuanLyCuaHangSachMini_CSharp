using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangSachMini.GUI
{
    partial class frmTrangChu
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTieuDe;
        private Label lblCapNhat;
        private TableLayoutPanel tblCards;
        private Panel pnlDoanhThu;
        private Panel pnlHoaDon;
        private Panel pnlKhachHang;
        private Panel pnlSachNhap;
        private Label lblDoanhThuValue;
        private Label lblDoanhThuTitle;
        private Label lblDoanhThuChange;
        private Label lblHoaDonTitle;
        private Label lblHoaDonValue;
        private Label lblKhachHangTitle;
        private Label lblKhachHangValue;
        private Label lblSachNhapTitle;
        private Label lblSachNhapValue;

        private Panel pnlSachBanChayCard;
        private Label lblSachBanChayCardTitle;
        private Label lblSachBanChayCardValue;
        private Label lblSachBanChayCardDetail;

        private Panel pnlCanhBaoTonKhoCard;
        private Label lblCanhBaoTonKhoCardTitle;
        private Label lblCanhBaoTonKhoCardValue;
        private Label lblCanhBaoTonKhoCardDetail;

        private GroupBox grpXuHuong;
        private DataGridView dgvXuHuong7Ngay;
        private Button btnLamMoi;

        private DataGridViewTextBoxColumn colThoiGian;
        private DataGridViewTextBoxColumn colKhachHang;
        private DataGridViewTextBoxColumn colGiaTri;

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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTieuDe = new Label();
            lblCapNhat = new Label();
            tblCards = new TableLayoutPanel();
            pnlDoanhThu = new Panel();
            lblDoanhThuChange = new Label();
            lblDoanhThuValue = new Label();
            lblDoanhThuTitle = new Label();
            pnlHoaDon = new Panel();
            lblHoaDonValue = new Label();
            lblHoaDonTitle = new Label();
            pnlKhachHang = new Panel();
            lblKhachHangValue = new Label();
            lblKhachHangTitle = new Label();
            pnlSachNhap = new Panel();
            lblSachNhapValue = new Label();
            lblSachNhapTitle = new Label();
            pnlSachBanChayCard = new Panel();
            lblSachBanChayCardDetail = new Label();
            lblSachBanChayCardValue = new Label();
            lblSachBanChayCardTitle = new Label();
            pnlCanhBaoTonKhoCard = new Panel();
            lblCanhBaoTonKhoCardDetail = new Label();
            lblCanhBaoTonKhoCardValue = new Label();
            lblCanhBaoTonKhoCardTitle = new Label();
            grpXuHuong = new GroupBox();
            dgvXuHuong7Ngay = new DataGridView();
            btnLamMoi = new Button();
            colThoiGian = new DataGridViewTextBoxColumn();
            colLoaiGiaoDich = new DataGridViewTextBoxColumn();
            colMaChungTu = new DataGridViewTextBoxColumn();
            colKhachHang = new DataGridViewTextBoxColumn();
            colGiaTri = new DataGridViewTextBoxColumn();
            tblCards.SuspendLayout();
            pnlDoanhThu.SuspendLayout();
            pnlHoaDon.SuspendLayout();
            pnlKhachHang.SuspendLayout();
            pnlSachNhap.SuspendLayout();
            pnlSachBanChayCard.SuspendLayout();
            pnlCanhBaoTonKhoCard.SuspendLayout();
            grpXuHuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXuHuong7Ngay).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(55, 38, 210);
            lblTieuDe.Location = new Point(22, 18);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(201, 41);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "TỔNG QUAN";
            // 
            // lblCapNhat
            // 
            lblCapNhat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCapNhat.Font = new Font("Segoe UI", 10F);
            lblCapNhat.ForeColor = Color.FromArgb(71, 85, 105);
            lblCapNhat.Location = new Point(955, 33);
            lblCapNhat.Name = "lblCapNhat";
            lblCapNhat.Size = new Size(220, 23);
            lblCapNhat.TabIndex = 1;
            lblCapNhat.Text = "Cập nhật lúc: --";
            lblCapNhat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tblCards
            // 
            tblCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblCards.ColumnCount = 4;
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.Controls.Add(pnlDoanhThu, 0, 0);
            tblCards.Controls.Add(pnlHoaDon, 1, 0);
            tblCards.Controls.Add(pnlKhachHang, 2, 0);
            tblCards.Controls.Add(pnlSachNhap, 3, 0);
            tblCards.Location = new Point(22, 78);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 1;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCards.Size = new Size(1268, 108);
            tblCards.TabIndex = 2;
            // 
            // pnlDoanhThu
            // 
            pnlDoanhThu.BackColor = Color.FromArgb(236, 253, 245);
            pnlDoanhThu.BorderStyle = BorderStyle.FixedSingle;
            pnlDoanhThu.Controls.Add(lblDoanhThuChange);
            pnlDoanhThu.Controls.Add(lblDoanhThuValue);
            pnlDoanhThu.Controls.Add(lblDoanhThuTitle);
            pnlDoanhThu.Dock = DockStyle.Fill;
            pnlDoanhThu.Location = new Point(3, 3);
            pnlDoanhThu.Name = "pnlDoanhThu";
            pnlDoanhThu.Padding = new Padding(14);
            pnlDoanhThu.Size = new Size(311, 102);
            pnlDoanhThu.TabIndex = 0;
            // 
            // lblDoanhThuChange
            // 
            lblDoanhThuChange.Dock = DockStyle.Bottom;
            lblDoanhThuChange.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDoanhThuChange.ForeColor = Color.FromArgb(71, 85, 105);
            lblDoanhThuChange.Location = new Point(14, 66);
            lblDoanhThuChange.Name = "lblDoanhThuChange";
            lblDoanhThuChange.Size = new Size(281, 20);
            lblDoanhThuChange.TabIndex = 2;
            lblDoanhThuChange.Text = "-- so với hôm qua";
            // 
            // lblDoanhThuValue
            // 
            lblDoanhThuValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDoanhThuValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblDoanhThuValue.Location = new Point(12, 28);
            lblDoanhThuValue.Name = "lblDoanhThuValue";
            lblDoanhThuValue.Size = new Size(177, 38);
            lblDoanhThuValue.TabIndex = 1;
            lblDoanhThuValue.Text = "0 đ";
            // 
            // lblDoanhThuTitle
            // 
            lblDoanhThuTitle.AutoSize = true;
            lblDoanhThuTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDoanhThuTitle.ForeColor = Color.FromArgb(5, 150, 105);
            lblDoanhThuTitle.Location = new Point(12, 8);
            lblDoanhThuTitle.Name = "lblDoanhThuTitle";
            lblDoanhThuTitle.Size = new Size(189, 23);
            lblDoanhThuTitle.TabIndex = 0;
            lblDoanhThuTitle.Text = "Doanh thu thuần ngày";
            // 
            // pnlHoaDon
            // 
            pnlHoaDon.BackColor = Color.FromArgb(239, 246, 255);
            pnlHoaDon.BorderStyle = BorderStyle.FixedSingle;
            pnlHoaDon.Controls.Add(lblHoaDonValue);
            pnlHoaDon.Controls.Add(lblHoaDonTitle);
            pnlHoaDon.Dock = DockStyle.Fill;
            pnlHoaDon.Location = new Point(320, 3);
            pnlHoaDon.Name = "pnlHoaDon";
            pnlHoaDon.Padding = new Padding(14);
            pnlHoaDon.Size = new Size(311, 102);
            pnlHoaDon.TabIndex = 1;
            // 
            // lblHoaDonValue
            // 
            lblHoaDonValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHoaDonValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblHoaDonValue.Location = new Point(14, 33);
            lblHoaDonValue.Name = "lblHoaDonValue";
            lblHoaDonValue.Size = new Size(170, 50);
            lblHoaDonValue.TabIndex = 1;
            lblHoaDonValue.Text = "0";
            // 
            // lblHoaDonTitle
            // 
            lblHoaDonTitle.AutoSize = true;
            lblHoaDonTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHoaDonTitle.ForeColor = Color.FromArgb(37, 99, 235);
            lblHoaDonTitle.Location = new Point(14, 8);
            lblHoaDonTitle.Name = "lblHoaDonTitle";
            lblHoaDonTitle.Size = new Size(153, 23);
            lblHoaDonTitle.TabIndex = 0;
            lblHoaDonTitle.Text = "Hóa đơn hôm nay";
            // 
            // pnlKhachHang
            // 
            pnlKhachHang.BackColor = Color.FromArgb(255, 247, 237);
            pnlKhachHang.BorderStyle = BorderStyle.FixedSingle;
            pnlKhachHang.Controls.Add(lblKhachHangValue);
            pnlKhachHang.Controls.Add(lblKhachHangTitle);
            pnlKhachHang.Dock = DockStyle.Fill;
            pnlKhachHang.Location = new Point(637, 3);
            pnlKhachHang.Name = "pnlKhachHang";
            pnlKhachHang.Padding = new Padding(14);
            pnlKhachHang.Size = new Size(311, 102);
            pnlKhachHang.TabIndex = 2;
            // 
            // lblKhachHangValue
            // 
            lblKhachHangValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblKhachHangValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblKhachHangValue.Location = new Point(14, 33);
            lblKhachHangValue.Name = "lblKhachHangValue";
            lblKhachHangValue.Size = new Size(170, 50);
            lblKhachHangValue.TabIndex = 1;
            lblKhachHangValue.Text = "0";
            // 
            // lblKhachHangTitle
            // 
            lblKhachHangTitle.AutoSize = true;
            lblKhachHangTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKhachHangTitle.ForeColor = Color.FromArgb(234, 88, 12);
            lblKhachHangTitle.Location = new Point(14, 8);
            lblKhachHangTitle.Name = "lblKhachHangTitle";
            lblKhachHangTitle.Size = new Size(148, 23);
            lblKhachHangTitle.TabIndex = 0;
            lblKhachHangTitle.Text = "Tổng khách hàng";
            // 
            // pnlSachNhap
            // 
            pnlSachNhap.BackColor = Color.FromArgb(245, 243, 255);
            pnlSachNhap.BorderStyle = BorderStyle.FixedSingle;
            pnlSachNhap.Controls.Add(lblSachNhapValue);
            pnlSachNhap.Controls.Add(lblSachNhapTitle);
            pnlSachNhap.Dock = DockStyle.Fill;
            pnlSachNhap.Location = new Point(954, 3);
            pnlSachNhap.Name = "pnlSachNhap";
            pnlSachNhap.Padding = new Padding(14);
            pnlSachNhap.Size = new Size(311, 102);
            pnlSachNhap.TabIndex = 3;
            // 
            // lblSachNhapValue
            // 
            lblSachNhapValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSachNhapValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblSachNhapValue.Location = new Point(14, 33);
            lblSachNhapValue.Name = "lblSachNhapValue";
            lblSachNhapValue.Size = new Size(170, 50);
            lblSachNhapValue.TabIndex = 1;
            lblSachNhapValue.Text = "0";
            // 
            // lblSachNhapTitle
            // 
            lblSachNhapTitle.AutoSize = true;
            lblSachNhapTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSachNhapTitle.ForeColor = Color.FromArgb(109, 40, 217);
            lblSachNhapTitle.Location = new Point(14, 8);
            lblSachNhapTitle.Name = "lblSachNhapTitle";
            lblSachNhapTitle.Size = new Size(166, 23);
            lblSachNhapTitle.TabIndex = 0;
            lblSachNhapTitle.Text = "Sách nhập hôm nay";
            // 
            // pnlSachBanChayCard
            // 
            pnlSachBanChayCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSachBanChayCard.BackColor = Color.White;
            pnlSachBanChayCard.BorderStyle = BorderStyle.FixedSingle;
            pnlSachBanChayCard.Controls.Add(lblSachBanChayCardDetail);
            pnlSachBanChayCard.Controls.Add(lblSachBanChayCardValue);
            pnlSachBanChayCard.Controls.Add(lblSachBanChayCardTitle);
            pnlSachBanChayCard.Location = new Point(22, 192);
            pnlSachBanChayCard.Name = "pnlSachBanChayCard";
            pnlSachBanChayCard.Padding = new Padding(16, 12, 16, 12);
            pnlSachBanChayCard.Size = new Size(628, 184);
            pnlSachBanChayCard.TabIndex = 3;
            // 
            // lblSachBanChayCardDetail
            // 
            lblSachBanChayCardDetail.Dock = DockStyle.Bottom;
            lblSachBanChayCardDetail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSachBanChayCardDetail.ForeColor = Color.FromArgb(71, 85, 105);
            lblSachBanChayCardDetail.Location = new Point(16, 151);
            lblSachBanChayCardDetail.Name = "lblSachBanChayCardDetail";
            lblSachBanChayCardDetail.Size = new Size(594, 19);
            lblSachBanChayCardDetail.TabIndex = 2;
            lblSachBanChayCardDetail.Text = "--";
            // 
            // lblSachBanChayCardValue
            // 
            lblSachBanChayCardValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSachBanChayCardValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblSachBanChayCardValue.Location = new Point(16, 54);
            lblSachBanChayCardValue.Name = "lblSachBanChayCardValue";
            lblSachBanChayCardValue.Size = new Size(594, 64);
            lblSachBanChayCardValue.TabIndex = 1;
            lblSachBanChayCardValue.Text = "Chưa có";
            // 
            // lblSachBanChayCardTitle
            // 
            lblSachBanChayCardTitle.AutoSize = true;
            lblSachBanChayCardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSachBanChayCardTitle.ForeColor = Color.FromArgb(55, 38, 210);
            lblSachBanChayCardTitle.Location = new Point(16, 16);
            lblSachBanChayCardTitle.Name = "lblSachBanChayCardTitle";
            lblSachBanChayCardTitle.Size = new Size(229, 28);
            lblSachBanChayCardTitle.TabIndex = 0;
            lblSachBanChayCardTitle.Text = "Sách bán chạy 30 ngày";
            // 
            // pnlCanhBaoTonKhoCard
            // 
            pnlCanhBaoTonKhoCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCanhBaoTonKhoCard.BackColor = Color.White;
            pnlCanhBaoTonKhoCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCanhBaoTonKhoCard.Controls.Add(lblCanhBaoTonKhoCardDetail);
            pnlCanhBaoTonKhoCard.Controls.Add(lblCanhBaoTonKhoCardValue);
            pnlCanhBaoTonKhoCard.Controls.Add(lblCanhBaoTonKhoCardTitle);
            pnlCanhBaoTonKhoCard.Location = new Point(662, 192);
            pnlCanhBaoTonKhoCard.Name = "pnlCanhBaoTonKhoCard";
            pnlCanhBaoTonKhoCard.Padding = new Padding(16, 12, 16, 12);
            pnlCanhBaoTonKhoCard.Size = new Size(628, 184);
            pnlCanhBaoTonKhoCard.TabIndex = 4;
            // 
            // lblCanhBaoTonKhoCardDetail
            // 
            lblCanhBaoTonKhoCardDetail.Dock = DockStyle.Bottom;
            lblCanhBaoTonKhoCardDetail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCanhBaoTonKhoCardDetail.ForeColor = Color.FromArgb(71, 85, 105);
            lblCanhBaoTonKhoCardDetail.Location = new Point(16, 151);
            lblCanhBaoTonKhoCardDetail.Name = "lblCanhBaoTonKhoCardDetail";
            lblCanhBaoTonKhoCardDetail.Size = new Size(594, 19);
            lblCanhBaoTonKhoCardDetail.TabIndex = 2;
            lblCanhBaoTonKhoCardDetail.Text = "--";
            // 
            // lblCanhBaoTonKhoCardValue
            // 
            lblCanhBaoTonKhoCardValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblCanhBaoTonKhoCardValue.ForeColor = Color.FromArgb(220, 38, 38);
            lblCanhBaoTonKhoCardValue.Location = new Point(16, 50);
            lblCanhBaoTonKhoCardValue.Name = "lblCanhBaoTonKhoCardValue";
            lblCanhBaoTonKhoCardValue.Size = new Size(594, 70);
            lblCanhBaoTonKhoCardValue.TabIndex = 1;
            lblCanhBaoTonKhoCardValue.Text = "0";
            // 
            // lblCanhBaoTonKhoCardTitle
            // 
            lblCanhBaoTonKhoCardTitle.AutoSize = true;
            lblCanhBaoTonKhoCardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCanhBaoTonKhoCardTitle.ForeColor = Color.FromArgb(55, 38, 210);
            lblCanhBaoTonKhoCardTitle.Location = new Point(16, 16);
            lblCanhBaoTonKhoCardTitle.Name = "lblCanhBaoTonKhoCardTitle";
            lblCanhBaoTonKhoCardTitle.Size = new Size(228, 28);
            lblCanhBaoTonKhoCardTitle.TabIndex = 0;
            lblCanhBaoTonKhoCardTitle.Text = "Cảnh báo tồn kho thấp";
            // 
            // grpXuHuong
            // 
            grpXuHuong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpXuHuong.BackColor = Color.White;
            grpXuHuong.Controls.Add(dgvXuHuong7Ngay);
            grpXuHuong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpXuHuong.ForeColor = Color.FromArgb(55, 38, 210);
            grpXuHuong.Location = new Point(22, 382);
            grpXuHuong.Name = "grpXuHuong";
            grpXuHuong.Size = new Size(1268, 266);
            grpXuHuong.TabIndex = 5;
            grpXuHuong.TabStop = false;
            grpXuHuong.Text = "Giao dịch 7 ngày gần nhất";
            // 
            // dgvXuHuong7Ngay
            // 
            dgvXuHuong7Ngay.AllowUserToAddRows = false;
            dgvXuHuong7Ngay.AllowUserToDeleteRows = false;
            dgvXuHuong7Ngay.AllowUserToResizeRows = false;
            dgvXuHuong7Ngay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvXuHuong7Ngay.BackgroundColor = Color.White;
            dgvXuHuong7Ngay.BorderStyle = BorderStyle.None;
            dgvXuHuong7Ngay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(71, 51, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(71, 51, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvXuHuong7Ngay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvXuHuong7Ngay.ColumnHeadersHeight = 34;
            dgvXuHuong7Ngay.Columns.AddRange(new DataGridViewColumn[] { colThoiGian, colLoaiGiaoDich, colMaChungTu, colKhachHang, colGiaTri });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(55, 38, 210);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvXuHuong7Ngay.DefaultCellStyle = dataGridViewCellStyle2;
            dgvXuHuong7Ngay.Dock = DockStyle.Fill;
            dgvXuHuong7Ngay.EnableHeadersVisualStyles = false;
            dgvXuHuong7Ngay.Location = new Point(3, 26);
            dgvXuHuong7Ngay.MultiSelect = false;
            dgvXuHuong7Ngay.Name = "dgvXuHuong7Ngay";
            dgvXuHuong7Ngay.ReadOnly = true;
            dgvXuHuong7Ngay.RowHeadersVisible = false;
            dgvXuHuong7Ngay.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 250, 252);
            dgvXuHuong7Ngay.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvXuHuong7Ngay.RowTemplate.Height = 30;
            dgvXuHuong7Ngay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXuHuong7Ngay.Size = new Size(1262, 237);
            dgvXuHuong7Ngay.TabIndex = 0;
            dgvXuHuong7Ngay.CellFormatting += dgvXuHuong7Ngay_CellFormatting;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.BackColor = Color.FromArgb(71, 51, 255);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 35, 200);
            btnLamMoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 82, 255);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1179, 28);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(111, 32);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // colThoiGian
            // 
            colThoiGian.DataPropertyName = "ThoiGian";
            colThoiGian.HeaderText = "Thời Gian";
            colThoiGian.MinimumWidth = 6;
            colThoiGian.Name = "colThoiGian";
            colThoiGian.ReadOnly = true;
            // 
            // colLoaiGiaoDich
            // 
            colLoaiGiaoDich.DataPropertyName = "LoaiGiaoDich";
            colLoaiGiaoDich.HeaderText = "Loại Giao Dịch";
            colLoaiGiaoDich.MinimumWidth = 6;
            colLoaiGiaoDich.Name = "colLoaiGiaoDich";
            colLoaiGiaoDich.ReadOnly = true;
            // 
            // colMaChungTu
            // 
            colMaChungTu.DataPropertyName = "MaChungTu";
            colMaChungTu.HeaderText = "Mã chứng từ";
            colMaChungTu.MinimumWidth = 6;
            colMaChungTu.Name = "colMaChungTu";
            colMaChungTu.ReadOnly = true;
            // 
            // colKhachHang
            // 
            colKhachHang.DataPropertyName = "KhachHang";
            colKhachHang.HeaderText = "Khách Hàng";
            colKhachHang.MinimumWidth = 6;
            colKhachHang.Name = "colKhachHang";
            colKhachHang.ReadOnly = true;
            // 
            // colGiaTri
            // 
            colGiaTri.DataPropertyName = "GiaTri";
            colGiaTri.HeaderText = "Giá trị";
            colGiaTri.MinimumWidth = 6;
            colGiaTri.Name = "colGiaTri";
            colGiaTri.ReadOnly = true;
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1312, 660);
            Controls.Add(grpXuHuong);
            Controls.Add(pnlCanhBaoTonKhoCard);
            Controls.Add(pnlSachBanChayCard);
            Controls.Add(btnLamMoi);
            Controls.Add(tblCards);
            Controls.Add(lblCapNhat);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTrangChu";
            Text = "Trang chủ";
            Load += frmTrangChu_Load;
            tblCards.ResumeLayout(false);
            pnlDoanhThu.ResumeLayout(false);
            pnlDoanhThu.PerformLayout();
            pnlHoaDon.ResumeLayout(false);
            pnlHoaDon.PerformLayout();
            pnlKhachHang.ResumeLayout(false);
            pnlKhachHang.PerformLayout();
            pnlSachNhap.ResumeLayout(false);
            pnlSachNhap.PerformLayout();
            pnlSachBanChayCard.ResumeLayout(false);
            pnlSachBanChayCard.PerformLayout();
            pnlCanhBaoTonKhoCard.ResumeLayout(false);
            pnlCanhBaoTonKhoCard.PerformLayout();
            grpXuHuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvXuHuong7Ngay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn colLoaiGiaoDich;
        private DataGridViewTextBoxColumn colMaChungTu;
    }
}
