namespace ABC
{
    partial class BANHANG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Font = new System.Drawing.Font("Segoe UI", 9F);  // phông mặc định như .NET 8, để AutoScaleMode.Font co giãn đúng
            tlpall = new TableLayoutPanel();
            picLogo = new PictureBox();
            tlpThan = new TableLayoutPanel();
            pnSanPham = new Panel();
            fLPSanPhamDaChon = new FlowLayoutPanel();
            tlpThanhToan = new TableLayoutPanel();
            cbbTimKhachHang = new ComboBox();
            pnKhachHang = new Panel();
            btnThemKhachHangMoi = new Button();
            txtTimKhachHang = new TextBox();
            btnThemMaGiamGia = new Button();
            txtTongTien = new TextBox();
            lbTongTien = new Label();
            lbThemKhachHang = new Label();
            txtMaGiamGia = new TextBox();
            pnDanhSach = new Panel();
            flpSanPham = new FlowLayoutPanel();
            tlpBoLoc = new TableLayoutPanel();
            lbTimKiem = new Label();
            txtTimKiem = new TextBox();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            btnThanhToan = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpThan.SuspendLayout();
            pnSanPham.SuspendLayout();
            tlpThanhToan.SuspendLayout();
            pnKhachHang.SuspendLayout();
            pnDanhSach.SuspendLayout();
            tlpBoLoc.SuspendLayout();
            tlpend.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpThan, 0, 1);
            tlpall.Controls.Add(tlpend, 0, 2);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 3;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2082586F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 87.79174F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tlpall.Size = new Size(1280, 872);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(1274, 93);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpThan
            // 
            tlpThan.ColumnCount = 2;
            tlpThan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.18828F));
            tlpThan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.81172F));
            tlpThan.Controls.Add(pnSanPham, 0, 0);
            tlpThan.Controls.Add(pnDanhSach, 1, 0);
            tlpThan.Dock = DockStyle.Fill;
            tlpThan.Location = new Point(3, 102);
            tlpThan.Name = "tlpThan";
            tlpThan.RowCount = 1;
            tlpThan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpThan.Size = new Size(1274, 707);
            tlpThan.TabIndex = 1;
            // 
            // pnSanPham
            // 
            pnSanPham.Controls.Add(fLPSanPhamDaChon);
            pnSanPham.Controls.Add(tlpThanhToan);
            pnSanPham.Dock = DockStyle.Fill;
            pnSanPham.Location = new Point(3, 3);
            pnSanPham.Name = "pnSanPham";
            pnSanPham.Size = new Size(480, 701);
            pnSanPham.TabIndex = 0;
            // 
            // fLPSanPhamDaChon
            // 
            fLPSanPhamDaChon.AutoScroll = true;
            fLPSanPhamDaChon.Dock = DockStyle.Fill;
            fLPSanPhamDaChon.FlowDirection = FlowDirection.TopDown;
            fLPSanPhamDaChon.Location = new Point(0, 0);
            fLPSanPhamDaChon.Name = "fLPSanPhamDaChon";
            fLPSanPhamDaChon.Size = new Size(480, 520);
            fLPSanPhamDaChon.TabIndex = 3;
            fLPSanPhamDaChon.WrapContents = false;
            // 
            // tlpThanhToan
            // 
            tlpThanhToan.ColumnCount = 2;
            tlpThanhToan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9150925F));
            tlpThanhToan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.0849075F));
            tlpThanhToan.Controls.Add(cbbTimKhachHang, 1, 1);
            tlpThanhToan.Controls.Add(pnKhachHang, 1, 0);
            tlpThanhToan.Controls.Add(btnThemMaGiamGia, 0, 3);
            tlpThanhToan.Controls.Add(txtTongTien, 1, 2);
            tlpThanhToan.Controls.Add(lbTongTien, 0, 2);
            tlpThanhToan.Controls.Add(lbThemKhachHang, 0, 0);
            tlpThanhToan.Controls.Add(txtMaGiamGia, 1, 3);
            tlpThanhToan.Dock = DockStyle.Bottom;
            tlpThanhToan.Location = new Point(0, 520);
            tlpThanhToan.Name = "tlpThanhToan";
            tlpThanhToan.RowCount = 4;
            tlpThanhToan.RowStyles.Add(new RowStyle(SizeType.Percent, 67.0454559F));
            tlpThanhToan.RowStyles.Add(new RowStyle(SizeType.Percent, 32.9545441F));
            tlpThanhToan.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpThanhToan.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tlpThanhToan.Size = new Size(480, 181);
            tlpThanhToan.TabIndex = 0;
            // 
            // cbbTimKhachHang
            // 
            cbbTimKhachHang.Anchor = AnchorStyles.Left;
            cbbTimKhachHang.FormattingEnabled = true;
            cbbTimKhachHang.Location = new Point(189, 62);
            cbbTimKhachHang.Name = "cbbTimKhachHang";
            cbbTimKhachHang.Size = new Size(150, 28);
            cbbTimKhachHang.TabIndex = 2;
            cbbTimKhachHang.DropDown += cbbTimKhachHang_DropDown;
            cbbTimKhachHang.SelectedIndexChanged += cbbTimKhachHang_SelectedIndexChanged;
            cbbTimKhachHang.SelectionChangeCommitted += cbbTimKhachHang_SelectionChangeCommitted;
            // 
            // pnKhachHang
            // 
            pnKhachHang.Anchor = AnchorStyles.Left;
            pnKhachHang.Controls.Add(btnThemKhachHangMoi);
            pnKhachHang.Controls.Add(txtTimKhachHang);
            pnKhachHang.Location = new Point(189, 3);
            pnKhachHang.Name = "pnKhachHang";
            pnKhachHang.Size = new Size(251, 53);
            pnKhachHang.TabIndex = 3;
            // 
            // btnThemKhachHangMoi
            // 
            btnThemKhachHangMoi.Anchor = AnchorStyles.Left;
            btnThemKhachHangMoi.Location = new Point(150, 1);
            btnThemKhachHangMoi.Name = "btnThemKhachHangMoi";
            btnThemKhachHangMoi.Size = new Size(101, 51);
            btnThemKhachHangMoi.TabIndex = 1;
            btnThemKhachHangMoi.Text = "Thêm mới";
            btnThemKhachHangMoi.UseVisualStyleBackColor = true;
            btnThemKhachHangMoi.Click += btnThemKhachHangMoi_Click;
            // 
            // txtTimKhachHang
            // 
            txtTimKhachHang.Anchor = AnchorStyles.Left;
            txtTimKhachHang.Location = new Point(3, 13);
            txtTimKhachHang.Name = "txtTimKhachHang";
            txtTimKhachHang.Size = new Size(147, 27);
            txtTimKhachHang.TabIndex = 0;
            txtTimKhachHang.TextChanged += txtTimKhachHang_TextChanged;
            // 
            // btnThemMaGiamGia
            // 
            btnThemMaGiamGia.Anchor = AnchorStyles.Right;
            btnThemMaGiamGia.Location = new Point(33, 126);
            btnThemMaGiamGia.Name = "btnThemMaGiamGia";
            btnThemMaGiamGia.Size = new Size(150, 52);
            btnThemMaGiamGia.TabIndex = 2;
            btnThemMaGiamGia.Text = "Mã giảm giá";
            btnThemMaGiamGia.UseVisualStyleBackColor = true;
            btnThemMaGiamGia.Click += btnThemMaGiamGia_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.Anchor = AnchorStyles.Left;
            txtTongTien.Location = new Point(189, 92);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(150, 27);
            txtTongTien.TabIndex = 1;
            // 
            // lbTongTien
            // 
            lbTongTien.Anchor = AnchorStyles.Right;
            lbTongTien.AutoSize = true;
            lbTongTien.Location = new Point(103, 95);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(80, 20);
            lbTongTien.TabIndex = 0;
            lbTongTien.Text = "Tổng cộng";
            // 
            // lbThemKhachHang
            // 
            lbThemKhachHang.Anchor = AnchorStyles.Right;
            lbThemKhachHang.AutoSize = true;
            lbThemKhachHang.Location = new Point(27, 19);
            lbThemKhachHang.Name = "lbThemKhachHang";
            lbThemKhachHang.Size = new Size(156, 20);
            lbThemKhachHang.TabIndex = 2;
            lbThemKhachHang.Text = "Tìm/Thêm khách hàng";
            // 
            // txtMaGiamGia
            // 
            txtMaGiamGia.Anchor = AnchorStyles.Left;
            txtMaGiamGia.Location = new Point(189, 138);
            txtMaGiamGia.Name = "txtMaGiamGia";
            txtMaGiamGia.ReadOnly = true;
            txtMaGiamGia.Size = new Size(150, 27);
            txtMaGiamGia.TabIndex = 4;
            // 
            // pnDanhSach
            // 
            pnDanhSach.Controls.Add(flpSanPham);
            pnDanhSach.Controls.Add(tlpBoLoc);
            pnDanhSach.Dock = DockStyle.Fill;
            pnDanhSach.Location = new Point(489, 3);
            pnDanhSach.Name = "pnDanhSach";
            pnDanhSach.Size = new Size(782, 701);
            pnDanhSach.TabIndex = 1;
            // 
            // flpSanPham
            // 
            flpSanPham.AutoScroll = true;
            flpSanPham.AutoSize = true;
            flpSanPham.Dock = DockStyle.Fill;
            flpSanPham.Location = new Point(0, 41);
            flpSanPham.Margin = new Padding(3, 4, 3, 4);
            flpSanPham.Name = "flpSanPham";
            flpSanPham.Size = new Size(782, 660);
            flpSanPham.TabIndex = 1;
            // 
            // tlpBoLoc
            // 
            tlpBoLoc.ColumnCount = 2;
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.637681F));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.144928F));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.217392F));
            tlpBoLoc.Controls.Add(lbTimKiem, 0, 0);
            tlpBoLoc.Controls.Add(txtTimKiem, 1, 0);
            tlpBoLoc.Dock = DockStyle.Top;
            tlpBoLoc.Location = new Point(0, 0);
            tlpBoLoc.Name = "tlpBoLoc";
            tlpBoLoc.RowCount = 1;
            tlpBoLoc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBoLoc.Size = new Size(782, 41);
            tlpBoLoc.TabIndex = 0;
            // 
            // lbTimKiem
            // 
            lbTimKiem.Anchor = AnchorStyles.Right;
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(103, 10);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(70, 20);
            lbTimKiem.TabIndex = 0;
            lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Location = new Point(179, 7);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(337, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 2;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.1421F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.857904F));
            tlpend.Controls.Add(btnThoat, 1, 0);
            tlpend.Controls.Add(btnThanhToan, 0, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 815);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpend.Size = new Size(1274, 54);
            tlpend.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1151, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 47);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThanhToan.Location = new Point(995, 3);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(150, 47);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "THANH TOÁN";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // BANHANG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 872);
            Controls.Add(tlpall);
            Name = "BANHANG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán hàng";
            Load += BANHANG_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpThan.ResumeLayout(false);
            pnSanPham.ResumeLayout(false);
            tlpThanhToan.ResumeLayout(false);
            tlpThanhToan.PerformLayout();
            pnKhachHang.ResumeLayout(false);
            pnKhachHang.PerformLayout();
            pnDanhSach.ResumeLayout(false);
            pnDanhSach.PerformLayout();
            tlpBoLoc.ResumeLayout(false);
            tlpBoLoc.PerformLayout();
            tlpend.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpThan;
        private Panel pnSanPham;
        private TableLayoutPanel tlpThanhToan;
        private TableLayoutPanel tlpBoLoc;
        private Label lbTimKiem;
        private TextBox txtTimKiem;
        private Button btnThanhToan;
        private Label lbThemKhachHang;
        private Panel pnKhachHang;
        private Button btnThemKhachHangMoi;
        private TextBox txtTimKhachHang;
        private Label lbTongTien;
        private TextBox txtTongTien;
        private Button btnThemMaGiamGia;
        private FlowLayoutPanel fLPSanPhamDaChon;
        private ComboBox cbbTimKhachHang;
        private TextBox txtMaGiamGia;
        private TableLayoutPanel tlpend;
        private Button btnThoat;
        private FlowLayoutPanel flpSanPham;
        private Panel pnDanhSach;
    }
}