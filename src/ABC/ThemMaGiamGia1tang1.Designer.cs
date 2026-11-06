namespace ABC
{
    partial class ThemMaGiamGia1tang1
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
            tlpThongtin = new TableLayoutPanel();
            lbMaGiamGia = new Label();
            txtMaGG = new TextBox();
            lbTenMa = new Label();
            lbChonLoaiMaGiamGia = new Label();
            lbTimKiem = new Label();
            txtTimKiem = new TextBox();
            txtTenMaGiamGia = new TextBox();
            cbbLoaiMa = new ComboBox();
            tlpthan = new TableLayoutPanel();
            tlpDate = new TableLayoutPanel();
            lbNgayBatDau = new Label();
            lbNgayHetHan = new Label();
            dTPBatDau = new DateTimePicker();
            dTPHetHan = new DateTimePicker();
            dgvSanPham = new DataGridView();
            tlpThaoTac = new TableLayoutPanel();
            lbHoaDon = new Label();
            txtGiaTriToiThieu = new TextBox();
            btnChon = new Button();
            lbChonSanPhamMua = new Label();
            cbbSanPhamMua = new ComboBox();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            btnLuu = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpThongtin.SuspendLayout();
            tlpthan.SuspendLayout();
            tlpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            tlpThaoTac.SuspendLayout();
            tlpend.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpThongtin, 0, 1);
            tlpall.Controls.Add(tlpthan, 0, 2);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 37.11111F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 17.333334F));
            tlpall.Size = new Size(800, 450);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(794, 83);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpThongtin
            // 
            tlpThongtin.ColumnCount = 4;
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.662468F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6246853F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.6498756F));
            tlpThongtin.Controls.Add(lbMaGiamGia, 0, 0);
            tlpThongtin.Controls.Add(txtMaGG, 1, 0);
            tlpThongtin.Controls.Add(lbTenMa, 0, 1);
            tlpThongtin.Controls.Add(lbChonLoaiMaGiamGia, 2, 0);
            tlpThongtin.Controls.Add(lbTimKiem, 2, 1);
            tlpThongtin.Controls.Add(txtTimKiem, 3, 1);
            tlpThongtin.Controls.Add(txtTenMaGiamGia, 1, 1);
            tlpThongtin.Controls.Add(cbbLoaiMa, 3, 0);
            tlpThongtin.Dock = DockStyle.Fill;
            tlpThongtin.Location = new Point(3, 92);
            tlpThongtin.Name = "tlpThongtin";
            tlpThongtin.RowCount = 2;
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpThongtin.Size = new Size(794, 110);
            tlpThongtin.TabIndex = 1;
            // 
            // lbMaGiamGia
            // 
            lbMaGiamGia.Anchor = AnchorStyles.Right;
            lbMaGiamGia.AutoSize = true;
            lbMaGiamGia.Location = new Point(102, 17);
            lbMaGiamGia.Name = "lbMaGiamGia";
            lbMaGiamGia.Size = new Size(93, 20);
            lbMaGiamGia.TabIndex = 0;
            lbMaGiamGia.Text = "Mã giảm giá";
            // 
            // txtMaGG
            // 
            txtMaGG.Anchor = AnchorStyles.Left;
            txtMaGG.Location = new Point(201, 14);
            txtMaGG.Name = "txtMaGG";
            txtMaGG.Size = new Size(166, 27);
            txtMaGG.TabIndex = 1;
            // 
            // lbTenMa
            // 
            lbTenMa.Anchor = AnchorStyles.Right;
            lbTenMa.AutoSize = true;
            lbTenMa.Location = new Point(75, 72);
            lbTenMa.Name = "lbTenMa";
            lbTenMa.Size = new Size(120, 20);
            lbTenMa.TabIndex = 2;
            lbTenMa.Text = "Tên mã giảm giá";
            // 
            // lbChonLoaiMaGiamGia
            // 
            lbChonLoaiMaGiamGia.Anchor = AnchorStyles.Right;
            lbChonLoaiMaGiamGia.AutoSize = true;
            lbChonLoaiMaGiamGia.Location = new Point(402, 17);
            lbChonLoaiMaGiamGia.Name = "lbChonLoaiMaGiamGia";
            lbChonLoaiMaGiamGia.Size = new Size(97, 20);
            lbChonLoaiMaGiamGia.TabIndex = 3;
            lbChonLoaiMaGiamGia.Text = "Chọn loại mã";
            // 
            // lbTimKiem
            // 
            lbTimKiem.Anchor = AnchorStyles.Right;
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(429, 72);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(70, 20);
            lbTimKiem.TabIndex = 4;
            lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Location = new Point(505, 69);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(177, 27);
            txtTimKiem.TabIndex = 5;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // txtTenMaGiamGia
            // 
            txtTenMaGiamGia.Anchor = AnchorStyles.Left;
            txtTenMaGiamGia.Location = new Point(201, 69);
            txtTenMaGiamGia.Name = "txtTenMaGiamGia";
            txtTenMaGiamGia.Size = new Size(166, 27);
            txtTenMaGiamGia.TabIndex = 6;
            // 
            // cbbLoaiMa
            // 
            cbbLoaiMa.Anchor = AnchorStyles.Left;
            cbbLoaiMa.FormattingEnabled = true;
            cbbLoaiMa.Location = new Point(505, 13);
            cbbLoaiMa.Name = "cbbLoaiMa";
            cbbLoaiMa.Size = new Size(177, 28);
            cbbLoaiMa.TabIndex = 7;
            cbbLoaiMa.SelectedIndexChanged += cbbLoaiMa_SelectedIndexChanged;
            // 
            // tlpthan
            // 
            tlpthan.ColumnCount = 3;
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpthan.Controls.Add(tlpDate, 2, 0);
            tlpthan.Controls.Add(dgvSanPham, 1, 0);
            tlpthan.Controls.Add(tlpThaoTac, 0, 0);
            tlpthan.Dock = DockStyle.Fill;
            tlpthan.Location = new Point(3, 208);
            tlpthan.Name = "tlpthan";
            tlpthan.RowCount = 1;
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpthan.Size = new Size(794, 160);
            tlpthan.TabIndex = 2;
            // 
            // tlpDate
            // 
            tlpDate.ColumnCount = 2;
            tlpDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpDate.Controls.Add(lbNgayBatDau, 0, 0);
            tlpDate.Controls.Add(lbNgayHetHan, 0, 1);
            tlpDate.Controls.Add(dTPBatDau, 1, 0);
            tlpDate.Controls.Add(dTPHetHan, 1, 1);
            tlpDate.Dock = DockStyle.Fill;
            tlpDate.Location = new Point(531, 3);
            tlpDate.Name = "tlpDate";
            tlpDate.RowCount = 2;
            tlpDate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDate.Size = new Size(260, 154);
            tlpDate.TabIndex = 0;
            // 
            // lbNgayBatDau
            // 
            lbNgayBatDau.Anchor = AnchorStyles.Right;
            lbNgayBatDau.AutoSize = true;
            lbNgayBatDau.Location = new Point(15, 28);
            lbNgayBatDau.Name = "lbNgayBatDau";
            lbNgayBatDau.Size = new Size(60, 20);
            lbNgayBatDau.TabIndex = 0;
            lbNgayBatDau.Text = "Bắt đầu";
            // 
            // lbNgayHetHan
            // 
            lbNgayHetHan.Anchor = AnchorStyles.Right;
            lbNgayHetHan.AutoSize = true;
            lbNgayHetHan.Location = new Point(14, 105);
            lbNgayHetHan.Name = "lbNgayHetHan";
            lbNgayHetHan.Size = new Size(61, 20);
            lbNgayHetHan.TabIndex = 0;
            lbNgayHetHan.Text = "Hết hạn";
            // 
            // dTPBatDau
            // 
            dTPBatDau.Anchor = AnchorStyles.Left;
            dTPBatDau.Location = new Point(81, 25);
            dTPBatDau.Name = "dTPBatDau";
            dTPBatDau.Size = new Size(176, 27);
            dTPBatDau.TabIndex = 1;
            // 
            // dTPHetHan
            // 
            dTPHetHan.Anchor = AnchorStyles.Left;
            dTPHetHan.Location = new Point(81, 102);
            dTPHetHan.Name = "dTPHetHan";
            dTPHetHan.Size = new Size(176, 27);
            dTPHetHan.TabIndex = 1;
            // 
            // dgvSanPham
            // 
            dgvSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(267, 3);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(258, 154);
            dgvSanPham.TabIndex = 1;
            // 
            // tlpThaoTac
            // 
            tlpThaoTac.ColumnCount = 2;
            tlpThaoTac.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThaoTac.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThaoTac.Controls.Add(lbHoaDon, 0, 0);
            tlpThaoTac.Controls.Add(txtGiaTriToiThieu, 1, 0);
            tlpThaoTac.Controls.Add(btnChon, 1, 2);
            tlpThaoTac.Controls.Add(lbChonSanPhamMua, 0, 1);
            tlpThaoTac.Controls.Add(cbbSanPhamMua, 1, 1);
            tlpThaoTac.Dock = DockStyle.Fill;
            tlpThaoTac.Location = new Point(3, 3);
            tlpThaoTac.Name = "tlpThaoTac";
            tlpThaoTac.RowCount = 3;
            tlpThaoTac.RowStyles.Add(new RowStyle(SizeType.Percent, 33.7748337F));
            tlpThaoTac.RowStyles.Add(new RowStyle(SizeType.Percent, 32.4503326F));
            tlpThaoTac.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpThaoTac.Size = new Size(258, 154);
            tlpThaoTac.TabIndex = 2;
            // 
            // lbHoaDon
            // 
            lbHoaDon.Anchor = AnchorStyles.Right;
            lbHoaDon.AutoSize = true;
            lbHoaDon.Location = new Point(26, 6);
            lbHoaDon.Name = "lbHoaDon";
            lbHoaDon.Size = new Size(100, 40);
            lbHoaDon.TabIndex = 0;
            lbHoaDon.Text = "Hóa đơn tối thiểu (nếu có)";
            // 
            // txtGiaTriToiThieu
            // 
            txtGiaTriToiThieu.Anchor = AnchorStyles.Left;
            txtGiaTriToiThieu.Location = new Point(132, 12);
            txtGiaTriToiThieu.Name = "txtGiaTriToiThieu";
            txtGiaTriToiThieu.Size = new Size(123, 27);
            txtGiaTriToiThieu.TabIndex = 1;
            txtGiaTriToiThieu.KeyPress += txtGiaTriToiThieu_KeyPress;
            // 
            // btnChon
            // 
            btnChon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChon.Location = new Point(132, 105);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(123, 40);
            btnChon.TabIndex = 4;
            btnChon.Text = "CHỌN";
            btnChon.UseVisualStyleBackColor = true;
            // 
            // lbChonSanPhamMua
            // 
            lbChonSanPhamMua.Anchor = AnchorStyles.Right;
            lbChonSanPhamMua.AutoSize = true;
            lbChonSanPhamMua.Location = new Point(18, 67);
            lbChonSanPhamMua.Name = "lbChonSanPhamMua";
            lbChonSanPhamMua.Size = new Size(108, 20);
            lbChonSanPhamMua.TabIndex = 5;
            lbChonSanPhamMua.Text = "Sản phẩm mua";
            // 
            // cbbSanPhamMua
            // 
            cbbSanPhamMua.Anchor = AnchorStyles.Left;
            cbbSanPhamMua.FormattingEnabled = true;
            cbbSanPhamMua.Location = new Point(132, 63);
            cbbSanPhamMua.Name = "cbbSanPhamMua";
            cbbSanPhamMua.Size = new Size(123, 28);
            cbbSanPhamMua.TabIndex = 6;
            cbbSanPhamMua.SelectedIndexChanged += cbbSanPhamMua_SelectedIndexChanged;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 3;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.6861343F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.31387F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tlpend.Controls.Add(btnThoat, 2, 0);
            tlpend.Controls.Add(btnLuu, 1, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 374);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpend.Size = new Size(794, 73);
            tlpend.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(659, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(126, 66);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.Location = new Point(519, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(134, 66);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // ThemMaGiamGia1tang1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpall);
            Name = "ThemMaGiamGia1tang1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mã giảm giá mua 1 tặng 1";
            Load += ThemMaGiamGia1tang1_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpThongtin.ResumeLayout(false);
            tlpThongtin.PerformLayout();
            tlpthan.ResumeLayout(false);
            tlpDate.ResumeLayout(false);
            tlpDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            tlpThaoTac.ResumeLayout(false);
            tlpThaoTac.PerformLayout();
            tlpend.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpThongtin;
        private Label lbMaGiamGia;
        private TextBox txtMaGG;
        private Label lbTenMa;
        private Label lbChonLoaiMaGiamGia;
        private Label lbTimKiem;
        private TextBox txtTimKiem;
        private TextBox txtTenMaGiamGia;
        private ComboBox cbbLoaiMa;
        private TableLayoutPanel tlpthan;
        private TableLayoutPanel tlpDate;
        private Label lbNgayBatDau;
        private Label lbNgayHetHan;
        private DateTimePicker dTPBatDau;
        private DateTimePicker dTPHetHan;
        private DataGridView dgvSanPham;
        private TableLayoutPanel tlpThaoTac;
        private Label lbHoaDon;
        private TextBox txtGiaTriToiThieu;
        private Button btnChon;
        private Label lbChonSanPhamMua;
        private ComboBox cbbSanPhamMua;
        private TableLayoutPanel tlpend;
        private Button btnThoat;
        private Button btnLuu;
    }
}