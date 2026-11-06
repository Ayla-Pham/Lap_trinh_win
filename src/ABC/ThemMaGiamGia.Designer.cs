namespace ABC
{
    partial class ThemMaGiamGia
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
            tlpthongtin = new TableLayoutPanel();
            lbLoaiMa = new Label();
            cbbLoaiMaGG = new ComboBox();
            lbMaGiamGia = new Label();
            lbTenMa = new Label();
            txtMaGiamGia = new TextBox();
            txtTenMa = new TextBox();
            lbGiaTri = new Label();
            txtGiaTriGiam = new TextBox();
            tlpDate = new TableLayoutPanel();
            lbGiaTriPhanTram = new Label();
            numGiamPhanTram = new NumericUpDown();
            lbGiaTriToiThieu = new Label();
            txtGiaTriDonToiThieu = new TextBox();
            lbNgayBatDau = new Label();
            lbNgayHetHan = new Label();
            dTPBatDau = new DateTimePicker();
            dTPHetHan = new DateTimePicker();
            tlpduoi = new TableLayoutPanel();
            btnThemMaGiamGia1tang1 = new Button();
            tlpButton = new TableLayoutPanel();
            btnThoat = new Button();
            btnLuu = new Button();
            lbChonDongSanPham = new Label();
            cbbLoaiSanPham = new ComboBox();
            lbChonSanPham = new Label();
            dgvSanPham = new DataGridView();
            txtTimkiem = new TextBox();
            lbTimKiem = new Label();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpthongtin.SuspendLayout();
            tlpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGiamPhanTram).BeginInit();
            tlpduoi.SuspendLayout();
            tlpButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpthongtin, 0, 1);
            tlpall.Controls.Add(tlpDate, 0, 2);
            tlpall.Controls.Add(tlpduoi, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 19.7530861F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8730154F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8712521F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 45.85538F));
            tlpall.Size = new Size(844, 547);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(838, 101);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpthongtin
            // 
            tlpthongtin.ColumnCount = 4;
            tlpthongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9403343F));
            tlpthongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.24105F));
            tlpthongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1097851F));
            tlpthongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.70883F));
            tlpthongtin.Controls.Add(lbLoaiMa, 0, 0);
            tlpthongtin.Controls.Add(cbbLoaiMaGG, 1, 0);
            tlpthongtin.Controls.Add(lbMaGiamGia, 2, 0);
            tlpthongtin.Controls.Add(lbTenMa, 2, 1);
            tlpthongtin.Controls.Add(txtMaGiamGia, 3, 0);
            tlpthongtin.Controls.Add(txtTenMa, 3, 1);
            tlpthongtin.Controls.Add(lbGiaTri, 0, 1);
            tlpthongtin.Controls.Add(txtGiaTriGiam, 1, 1);
            tlpthongtin.Dock = DockStyle.Fill;
            tlpthongtin.Location = new Point(3, 110);
            tlpthongtin.Name = "tlpthongtin";
            tlpthongtin.RowCount = 2;
            tlpthongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpthongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpthongtin.Size = new Size(838, 80);
            tlpthongtin.TabIndex = 1;
            // 
            // lbLoaiMa
            // 
            lbLoaiMa.Anchor = AnchorStyles.Right;
            lbLoaiMa.AutoSize = true;
            lbLoaiMa.Location = new Point(46, 10);
            lbLoaiMa.Name = "lbLoaiMa";
            lbLoaiMa.Size = new Size(160, 20);
            lbLoaiMa.TabIndex = 0;
            lbLoaiMa.Text = "Chọn loại mã giảm giá";
            // 
            // cbbLoaiMaGG
            // 
            cbbLoaiMaGG.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbbLoaiMaGG.FormattingEnabled = true;
            cbbLoaiMaGG.Location = new Point(212, 6);
            cbbLoaiMaGG.Name = "cbbLoaiMaGG";
            cbbLoaiMaGG.Size = new Size(172, 28);
            cbbLoaiMaGG.TabIndex = 1;
            cbbLoaiMaGG.SelectedIndexChanged += cbbLoaiMaGG_SelectedIndexChanged;
            // 
            // lbMaGiamGia
            // 
            lbMaGiamGia.Anchor = AnchorStyles.Right;
            lbMaGiamGia.AutoSize = true;
            lbMaGiamGia.Location = new Point(424, 10);
            lbMaGiamGia.Name = "lbMaGiamGia";
            lbMaGiamGia.Size = new Size(95, 20);
            lbMaGiamGia.TabIndex = 2;
            lbMaGiamGia.Text = "Mã Giảm Giá";
            // 
            // lbTenMa
            // 
            lbTenMa.Anchor = AnchorStyles.Right;
            lbTenMa.AutoSize = true;
            lbTenMa.Location = new Point(397, 50);
            lbTenMa.Name = "lbTenMa";
            lbTenMa.Size = new Size(122, 20);
            lbTenMa.TabIndex = 3;
            lbTenMa.Text = "Tên Mã Giảm Giá";
            // 
            // txtMaGiamGia
            // 
            txtMaGiamGia.Anchor = AnchorStyles.Left;
            txtMaGiamGia.Location = new Point(525, 6);
            txtMaGiamGia.Name = "txtMaGiamGia";
            txtMaGiamGia.Size = new Size(213, 27);
            txtMaGiamGia.TabIndex = 4;
            // 
            // txtTenMa
            // 
            txtTenMa.Anchor = AnchorStyles.Left;
            txtTenMa.Location = new Point(525, 46);
            txtTenMa.Name = "txtTenMa";
            txtTenMa.Size = new Size(213, 27);
            txtTenMa.TabIndex = 4;
            // 
            // lbGiaTri
            // 
            lbGiaTri.Anchor = AnchorStyles.Right;
            lbGiaTri.AutoSize = true;
            lbGiaTri.Location = new Point(119, 50);
            lbGiaTri.Name = "lbGiaTri";
            lbGiaTri.Size = new Size(87, 20);
            lbGiaTri.TabIndex = 5;
            lbGiaTri.Text = "Giá trị giảm";
            // 
            // txtGiaTriGiam
            // 
            txtGiaTriGiam.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtGiaTriGiam.Location = new Point(212, 46);
            txtGiaTriGiam.Name = "txtGiaTriGiam";
            txtGiaTriGiam.Size = new Size(172, 27);
            txtGiaTriGiam.TabIndex = 6;
            txtGiaTriGiam.KeyPress += txtGiaTriGiam_KeyPress;
            txtGiaTriGiam.Validating += txtGiaTriGiam_Validating;
            // 
            // tlpDate
            // 
            tlpDate.ColumnCount = 4;
            tlpDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9403343F));
            tlpDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3603821F));
            tlpDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.9904537F));
            tlpDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.70883F));
            tlpDate.Controls.Add(lbGiaTriPhanTram, 0, 0);
            tlpDate.Controls.Add(numGiamPhanTram, 1, 0);
            tlpDate.Controls.Add(lbGiaTriToiThieu, 0, 1);
            tlpDate.Controls.Add(txtGiaTriDonToiThieu, 1, 1);
            tlpDate.Controls.Add(lbNgayBatDau, 2, 0);
            tlpDate.Controls.Add(lbNgayHetHan, 2, 1);
            tlpDate.Controls.Add(dTPBatDau, 3, 0);
            tlpDate.Controls.Add(dTPHetHan, 3, 1);
            tlpDate.Dock = DockStyle.Fill;
            tlpDate.Location = new Point(3, 196);
            tlpDate.Name = "tlpDate";
            tlpDate.RowCount = 2;
            tlpDate.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            tlpDate.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tlpDate.Size = new Size(838, 96);
            tlpDate.TabIndex = 2;
            // 
            // lbGiaTriPhanTram
            // 
            lbGiaTriPhanTram.Anchor = AnchorStyles.Right;
            lbGiaTriPhanTram.AutoSize = true;
            lbGiaTriPhanTram.Location = new Point(56, 13);
            lbGiaTriPhanTram.Name = "lbGiaTriPhanTram";
            lbGiaTriPhanTram.Size = new Size(150, 20);
            lbGiaTriPhanTram.TabIndex = 0;
            lbGiaTriPhanTram.Text = "Giá trị giảm (Theo %)";
            // 
            // numGiamPhanTram
            // 
            numGiamPhanTram.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numGiamPhanTram.Location = new Point(212, 9);
            numGiamPhanTram.Name = "numGiamPhanTram";
            numGiamPhanTram.Size = new Size(173, 27);
            numGiamPhanTram.TabIndex = 1;
            // 
            // lbGiaTriToiThieu
            // 
            lbGiaTriToiThieu.Anchor = AnchorStyles.Right;
            lbGiaTriToiThieu.AutoSize = true;
            lbGiaTriToiThieu.Location = new Point(27, 51);
            lbGiaTriToiThieu.Name = "lbGiaTriToiThieu";
            lbGiaTriToiThieu.Size = new Size(179, 40);
            lbGiaTriToiThieu.TabIndex = 2;
            lbGiaTriToiThieu.Text = "Giá trị đơn hàng tối thiểu (nếu có)";
            // 
            // txtGiaTriDonToiThieu
            // 
            txtGiaTriDonToiThieu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtGiaTriDonToiThieu.Location = new Point(212, 57);
            txtGiaTriDonToiThieu.Name = "txtGiaTriDonToiThieu";
            txtGiaTriDonToiThieu.Size = new Size(173, 27);
            txtGiaTriDonToiThieu.TabIndex = 3;
            txtGiaTriDonToiThieu.KeyPress += txtGiaTriDonToiThieu_KeyPress;
            txtGiaTriDonToiThieu.Validating += txtGiaTriDonToiThieu_Validating;
            // 
            // lbNgayBatDau
            // 
            lbNgayBatDau.Anchor = AnchorStyles.Right;
            lbNgayBatDau.AutoSize = true;
            lbNgayBatDau.Location = new Point(420, 13);
            lbNgayBatDau.Name = "lbNgayBatDau";
            lbNgayBatDau.Size = new Size(99, 20);
            lbNgayBatDau.TabIndex = 4;
            lbNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // lbNgayHetHan
            // 
            lbNgayHetHan.Anchor = AnchorStyles.Right;
            lbNgayHetHan.AutoSize = true;
            lbNgayHetHan.Location = new Point(422, 61);
            lbNgayHetHan.Name = "lbNgayHetHan";
            lbNgayHetHan.Size = new Size(97, 20);
            lbNgayHetHan.TabIndex = 4;
            lbNgayHetHan.Text = "Ngày hết hạn";
            // 
            // dTPBatDau
            // 
            dTPBatDau.Anchor = AnchorStyles.Left;
            dTPBatDau.Location = new Point(525, 9);
            dTPBatDau.Name = "dTPBatDau";
            dTPBatDau.Size = new Size(249, 27);
            dTPBatDau.TabIndex = 5;
            // 
            // dTPHetHan
            // 
            dTPHetHan.Anchor = AnchorStyles.Left;
            dTPHetHan.Location = new Point(525, 57);
            dTPHetHan.Name = "dTPHetHan";
            dTPHetHan.Size = new Size(249, 27);
            dTPHetHan.TabIndex = 5;
            // 
            // tlpduoi
            // 
            tlpduoi.ColumnCount = 4;
            tlpduoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9403343F));
            tlpduoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.24105F));
            tlpduoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1097851F));
            tlpduoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.70883F));
            tlpduoi.Controls.Add(btnThemMaGiamGia1tang1, 3, 0);
            tlpduoi.Controls.Add(tlpButton, 3, 1);
            tlpduoi.Controls.Add(lbChonDongSanPham, 0, 0);
            tlpduoi.Controls.Add(cbbLoaiSanPham, 1, 0);
            tlpduoi.Controls.Add(lbChonSanPham, 0, 1);
            tlpduoi.Controls.Add(dgvSanPham, 1, 1);
            tlpduoi.Controls.Add(txtTimkiem, 2, 1);
            tlpduoi.Controls.Add(lbTimKiem, 2, 0);
            tlpduoi.Dock = DockStyle.Fill;
            tlpduoi.Location = new Point(3, 298);
            tlpduoi.Name = "tlpduoi";
            tlpduoi.RowCount = 2;
            tlpduoi.RowStyles.Add(new RowStyle(SizeType.Percent, 26.666666F));
            tlpduoi.RowStyles.Add(new RowStyle(SizeType.Percent, 73.3333359F));
            tlpduoi.Size = new Size(838, 246);
            tlpduoi.TabIndex = 3;
            // 
            // btnThemMaGiamGia1tang1
            // 
            btnThemMaGiamGia1tang1.Location = new Point(525, 3);
            btnThemMaGiamGia1tang1.Name = "btnThemMaGiamGia1tang1";
            btnThemMaGiamGia1tang1.Size = new Size(249, 59);
            btnThemMaGiamGia1tang1.TabIndex = 0;
            btnThemMaGiamGia1tang1.Text = "Thêm mã giảm giá mua 1 tặng 1";
            btnThemMaGiamGia1tang1.UseVisualStyleBackColor = true;
            btnThemMaGiamGia1tang1.Click += btnThemMaGiamGia1tang1_Click;
            // 
            // tlpButton
            // 
            tlpButton.ColumnCount = 2;
            tlpButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.3225822F));
            tlpButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.6774178F));
            tlpButton.Controls.Add(btnThoat, 1, 0);
            tlpButton.Controls.Add(btnLuu, 0, 0);
            tlpButton.Dock = DockStyle.Fill;
            tlpButton.Location = new Point(525, 68);
            tlpButton.Name = "tlpButton";
            tlpButton.RowCount = 1;
            tlpButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpButton.Size = new Size(310, 175);
            tlpButton.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(128, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(121, 57);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.Location = new Point(3, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(119, 57);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "THÊM";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // lbChonDongSanPham
            // 
            lbChonDongSanPham.Anchor = AnchorStyles.Right;
            lbChonDongSanPham.AutoSize = true;
            lbChonDongSanPham.Location = new Point(34, 12);
            lbChonDongSanPham.Name = "lbChonDongSanPham";
            lbChonDongSanPham.Size = new Size(172, 40);
            lbChonDongSanPham.TabIndex = 2;
            lbChonDongSanPham.Text = "Giảm giá theo dòng sản phẩm (nếu có)";
            // 
            // cbbLoaiSanPham
            // 
            cbbLoaiSanPham.Anchor = AnchorStyles.Left;
            cbbLoaiSanPham.FormattingEnabled = true;
            cbbLoaiSanPham.Location = new Point(212, 18);
            cbbLoaiSanPham.Name = "cbbLoaiSanPham";
            cbbLoaiSanPham.Size = new Size(172, 28);
            cbbLoaiSanPham.TabIndex = 3;
            cbbLoaiSanPham.SelectedIndexChanged += cbbLoaiSanPham_SelectedIndexChanged;
            // 
            // lbChonSanPham
            // 
            lbChonSanPham.Anchor = AnchorStyles.Right;
            lbChonSanPham.AutoSize = true;
            lbChonSanPham.Location = new Point(38, 135);
            lbChonSanPham.Name = "lbChonSanPham";
            lbChonSanPham.Size = new Size(168, 40);
            lbChonSanPham.TabIndex = 4;
            lbChonSanPham.Text = "Giảm giá theo từng sản phẩm (nếu có)";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Top;
            dgvSanPham.Location = new Point(212, 68);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(172, 175);
            dgvSanPham.TabIndex = 5;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Anchor = AnchorStyles.Top;
            txtTimkiem.Location = new Point(390, 68);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(129, 27);
            txtTimkiem.TabIndex = 6;
            // 
            // lbTimKiem
            // 
            lbTimKiem.Anchor = AnchorStyles.Bottom;
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(419, 45);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(70, 20);
            lbTimKiem.TabIndex = 7;
            lbTimKiem.Text = "Tìm kiếm";
            // 
            // ThemMaGiamGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 547);
            Controls.Add(tlpall);
            Name = "ThemMaGiamGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm mã giảm giá";
            Load += ThemMaGiamGia_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpthongtin.ResumeLayout(false);
            tlpthongtin.PerformLayout();
            tlpDate.ResumeLayout(false);
            tlpDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGiamPhanTram).EndInit();
            tlpduoi.ResumeLayout(false);
            tlpduoi.PerformLayout();
            tlpButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpthongtin;
        private Label lbLoaiMa;
        private ComboBox cbbLoaiMaGG;
        private Label lbMaGiamGia;
        private Label lbTenMa;
        private TextBox txtMaGiamGia;
        private TextBox txtTenMa;
        private Label lbGiaTri;
        private TableLayoutPanel tlpDate;
        private TextBox txtGiaTriGiam;
        private Label lbGiaTriPhanTram;
        private NumericUpDown numGiamPhanTram;
        private Label lbGiaTriToiThieu;
        private TextBox txtGiaTriDonToiThieu;
        private Label lbNgayBatDau;
        private Label lbNgayHetHan;
        private DateTimePicker dTPBatDau;
        private DateTimePicker dTPHetHan;
        private TableLayoutPanel tlpduoi;
        private Button btnThemMaGiamGia1tang1;
        private TableLayoutPanel tlpButton;
        private Button btnThoat;
        private Button btnLuu;
        private Label lbChonDongSanPham;
        private ComboBox cbbLoaiSanPham;
        private Label lbChonSanPham;
        private DataGridView dgvSanPham;
        private TextBox txtTimkiem;
        private Label lbTimKiem;
    }
}