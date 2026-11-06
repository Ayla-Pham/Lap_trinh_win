namespace ABC
{
    partial class SuaMaGiamGia
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
            tlpTren = new TableLayoutPanel();
            lbChonLoaiMaGiamGia = new Label();
            lbGiaTriGiam = new Label();
            lbTenMaGiamGia = new Label();
            lbMaGiamGia = new Label();
            cbbLoaiMaGiamGia = new ComboBox();
            txtMaGiamGia = new TextBox();
            txtTenMaGiamGia = new TextBox();
            txtGiaTriGiam = new TextBox();
            tlpDuoi = new TableLayoutPanel();
            lbGiaTriGiamTheoPT = new Label();
            lbGiaTriDonHangToiThieu = new Label();
            lbNgayBatDau = new Label();
            lbNgayKetTHuc = new Label();
            numGiaTriGiamTheoPT = new NumericUpDown();
            txtGiaTriDonHangToiThieu = new TextBox();
            dtpNgayBatDau = new DateTimePicker();
            dtpNgayHetHan = new DateTimePicker();
            tlpend = new TableLayoutPanel();
            lbLoaiSanPham = new Label();
            lbTimKiem = new Label();
            lbGiamGiaTheoTungSanPham = new Label();
            dgvSanPham = new DataGridView();
            cbbLoaiSanPham = new ComboBox();
            txtTimKiem = new TextBox();
            tlpbutton = new TableLayoutPanel();
            btnThoat = new Button();
            btnLuu = new Button();
            btnLamMoi = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpTren.SuspendLayout();
            tlpDuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGiaTriGiamTheoPT).BeginInit();
            tlpend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            tlpbutton.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpTren, 0, 1);
            tlpall.Controls.Add(tlpDuoi, 0, 2);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0649815F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 16.2454872F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8700352F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 49.8194962F));
            tlpall.Size = new Size(825, 554);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(819, 83);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpTren
            // 
            tlpTren.ColumnCount = 4;
            tlpTren.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTren.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4896221F));
            tlpTren.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.094017F));
            tlpTren.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.3858376F));
            tlpTren.Controls.Add(lbChonLoaiMaGiamGia, 0, 0);
            tlpTren.Controls.Add(lbGiaTriGiam, 0, 1);
            tlpTren.Controls.Add(lbTenMaGiamGia, 2, 1);
            tlpTren.Controls.Add(lbMaGiamGia, 2, 0);
            tlpTren.Controls.Add(cbbLoaiMaGiamGia, 1, 0);
            tlpTren.Controls.Add(txtMaGiamGia, 3, 0);
            tlpTren.Controls.Add(txtTenMaGiamGia, 3, 1);
            tlpTren.Controls.Add(txtGiaTriGiam, 1, 1);
            tlpTren.Dock = DockStyle.Fill;
            tlpTren.Location = new Point(3, 92);
            tlpTren.Name = "tlpTren";
            tlpTren.RowCount = 2;
            tlpTren.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTren.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTren.Size = new Size(819, 84);
            tlpTren.TabIndex = 1;
            // 
            // lbChonLoaiMaGiamGia
            // 
            lbChonLoaiMaGiamGia.Anchor = AnchorStyles.Right;
            lbChonLoaiMaGiamGia.AutoSize = true;
            lbChonLoaiMaGiamGia.Location = new Point(41, 11);
            lbChonLoaiMaGiamGia.Name = "lbChonLoaiMaGiamGia";
            lbChonLoaiMaGiamGia.Size = new Size(160, 20);
            lbChonLoaiMaGiamGia.TabIndex = 0;
            lbChonLoaiMaGiamGia.Text = "Chọn loại mã giảm giá";
            // 
            // lbGiaTriGiam
            // 
            lbGiaTriGiam.Anchor = AnchorStyles.Right;
            lbGiaTriGiam.AutoSize = true;
            lbGiaTriGiam.Location = new Point(114, 53);
            lbGiaTriGiam.Name = "lbGiaTriGiam";
            lbGiaTriGiam.Size = new Size(87, 20);
            lbGiaTriGiam.TabIndex = 0;
            lbGiaTriGiam.Text = "Giá trị giảm";
            // 
            // lbTenMaGiamGia
            // 
            lbTenMaGiamGia.Anchor = AnchorStyles.Right;
            lbTenMaGiamGia.AutoSize = true;
            lbTenMaGiamGia.Location = new Point(397, 53);
            lbTenMaGiamGia.Name = "lbTenMaGiamGia";
            lbTenMaGiamGia.Size = new Size(120, 20);
            lbTenMaGiamGia.TabIndex = 1;
            lbTenMaGiamGia.Text = "Tên mã giảm giá";
            // 
            // lbMaGiamGia
            // 
            lbMaGiamGia.Anchor = AnchorStyles.Right;
            lbMaGiamGia.AutoSize = true;
            lbMaGiamGia.Location = new Point(424, 11);
            lbMaGiamGia.Name = "lbMaGiamGia";
            lbMaGiamGia.Size = new Size(93, 20);
            lbMaGiamGia.TabIndex = 1;
            lbMaGiamGia.Text = "Mã giảm giá";
            // 
            // cbbLoaiMaGiamGia
            // 
            cbbLoaiMaGiamGia.Anchor = AnchorStyles.Left;
            cbbLoaiMaGiamGia.FormattingEnabled = true;
            cbbLoaiMaGiamGia.Location = new Point(207, 7);
            cbbLoaiMaGiamGia.Name = "cbbLoaiMaGiamGia";
            cbbLoaiMaGiamGia.Size = new Size(170, 28);
            cbbLoaiMaGiamGia.TabIndex = 2;
            cbbLoaiMaGiamGia.SelectedIndexChanged += cbbLoaiMaGiamGia_SelectedIndexChanged;
            // 
            // txtMaGiamGia
            // 
            txtMaGiamGia.Anchor = AnchorStyles.Left;
            txtMaGiamGia.Location = new Point(523, 7);
            txtMaGiamGia.Name = "txtMaGiamGia";
            txtMaGiamGia.Size = new Size(251, 27);
            txtMaGiamGia.TabIndex = 3;
            // 
            // txtTenMaGiamGia
            // 
            txtTenMaGiamGia.Anchor = AnchorStyles.Left;
            txtTenMaGiamGia.Location = new Point(523, 49);
            txtTenMaGiamGia.Name = "txtTenMaGiamGia";
            txtTenMaGiamGia.Size = new Size(251, 27);
            txtTenMaGiamGia.TabIndex = 3;
            // 
            // txtGiaTriGiam
            // 
            txtGiaTriGiam.Anchor = AnchorStyles.Left;
            txtGiaTriGiam.Location = new Point(207, 49);
            txtGiaTriGiam.Name = "txtGiaTriGiam";
            txtGiaTriGiam.Size = new Size(170, 27);
            txtGiaTriGiam.TabIndex = 3;
            // 
            // tlpDuoi
            // 
            tlpDuoi.ColumnCount = 4;
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4896221F));
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2161179F));
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2637367F));
            tlpDuoi.Controls.Add(lbGiaTriGiamTheoPT, 0, 0);
            tlpDuoi.Controls.Add(lbGiaTriDonHangToiThieu, 0, 1);
            tlpDuoi.Controls.Add(lbNgayBatDau, 2, 0);
            tlpDuoi.Controls.Add(lbNgayKetTHuc, 2, 1);
            tlpDuoi.Controls.Add(numGiaTriGiamTheoPT, 1, 0);
            tlpDuoi.Controls.Add(txtGiaTriDonHangToiThieu, 1, 1);
            tlpDuoi.Controls.Add(dtpNgayBatDau, 3, 0);
            tlpDuoi.Controls.Add(dtpNgayHetHan, 3, 1);
            tlpDuoi.Dock = DockStyle.Fill;
            tlpDuoi.Location = new Point(3, 182);
            tlpDuoi.Name = "tlpDuoi";
            tlpDuoi.RowCount = 2;
            tlpDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDuoi.Size = new Size(819, 92);
            tlpDuoi.TabIndex = 2;
            // 
            // lbGiaTriGiamTheoPT
            // 
            lbGiaTriGiamTheoPT.Anchor = AnchorStyles.Right;
            lbGiaTriGiamTheoPT.AutoSize = true;
            lbGiaTriGiamTheoPT.Location = new Point(54, 13);
            lbGiaTriGiamTheoPT.Name = "lbGiaTriGiamTheoPT";
            lbGiaTriGiamTheoPT.Size = new Size(147, 20);
            lbGiaTriGiamTheoPT.TabIndex = 0;
            lbGiaTriGiamTheoPT.Text = "Giá trị giảm (theo %)";
            // 
            // lbGiaTriDonHangToiThieu
            // 
            lbGiaTriDonHangToiThieu.Anchor = AnchorStyles.Right;
            lbGiaTriDonHangToiThieu.AutoSize = true;
            lbGiaTriDonHangToiThieu.Location = new Point(22, 49);
            lbGiaTriDonHangToiThieu.Name = "lbGiaTriDonHangToiThieu";
            lbGiaTriDonHangToiThieu.Size = new Size(179, 40);
            lbGiaTriDonHangToiThieu.TabIndex = 0;
            lbGiaTriDonHangToiThieu.Text = "Giá trị đơn hàng tối thiểu (nếu có)";
            // 
            // lbNgayBatDau
            // 
            lbNgayBatDau.Anchor = AnchorStyles.Right;
            lbNgayBatDau.AutoSize = true;
            lbNgayBatDau.Location = new Point(419, 13);
            lbNgayBatDau.Name = "lbNgayBatDau";
            lbNgayBatDau.Size = new Size(99, 20);
            lbNgayBatDau.TabIndex = 1;
            lbNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // lbNgayKetTHuc
            // 
            lbNgayKetTHuc.Anchor = AnchorStyles.Right;
            lbNgayKetTHuc.AutoSize = true;
            lbNgayKetTHuc.Location = new Point(421, 59);
            lbNgayKetTHuc.Name = "lbNgayKetTHuc";
            lbNgayKetTHuc.Size = new Size(97, 20);
            lbNgayKetTHuc.TabIndex = 1;
            lbNgayKetTHuc.Text = "Ngày hết hạn";
            // 
            // numGiaTriGiamTheoPT
            // 
            numGiaTriGiamTheoPT.Anchor = AnchorStyles.Left;
            numGiaTriGiamTheoPT.Location = new Point(207, 9);
            numGiaTriGiamTheoPT.Name = "numGiaTriGiamTheoPT";
            numGiaTriGiamTheoPT.Size = new Size(170, 27);
            numGiaTriGiamTheoPT.TabIndex = 2;
            // 
            // txtGiaTriDonHangToiThieu
            // 
            txtGiaTriDonHangToiThieu.Anchor = AnchorStyles.Left;
            txtGiaTriDonHangToiThieu.Location = new Point(207, 55);
            txtGiaTriDonHangToiThieu.Name = "txtGiaTriDonHangToiThieu";
            txtGiaTriDonHangToiThieu.Size = new Size(170, 27);
            txtGiaTriDonHangToiThieu.TabIndex = 3;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Anchor = AnchorStyles.Left;
            dtpNgayBatDau.Location = new Point(524, 9);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(250, 27);
            dtpNgayBatDau.TabIndex = 4;
            // 
            // dtpNgayHetHan
            // 
            dtpNgayHetHan.Anchor = AnchorStyles.Left;
            dtpNgayHetHan.Location = new Point(524, 55);
            dtpNgayHetHan.Name = "dtpNgayHetHan";
            dtpNgayHetHan.Size = new Size(250, 27);
            dtpNgayHetHan.TabIndex = 4;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 4;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3675213F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3382168F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2637367F));
            tlpend.Controls.Add(lbLoaiSanPham, 0, 0);
            tlpend.Controls.Add(lbTimKiem, 2, 0);
            tlpend.Controls.Add(lbGiamGiaTheoTungSanPham, 0, 1);
            tlpend.Controls.Add(dgvSanPham, 1, 1);
            tlpend.Controls.Add(cbbLoaiSanPham, 1, 0);
            tlpend.Controls.Add(txtTimKiem, 2, 1);
            tlpend.Controls.Add(tlpbutton, 3, 1);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 280);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 2;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 25.09225F));
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 74.9077454F));
            tlpend.Size = new Size(819, 271);
            tlpend.TabIndex = 3;
            // 
            // lbLoaiSanPham
            // 
            lbLoaiSanPham.Anchor = AnchorStyles.Right;
            lbLoaiSanPham.AutoSize = true;
            lbLoaiSanPham.Location = new Point(61, 24);
            lbLoaiSanPham.Name = "lbLoaiSanPham";
            lbLoaiSanPham.Size = new Size(140, 20);
            lbLoaiSanPham.TabIndex = 0;
            lbLoaiSanPham.Text = "Chọn loại sản phẩm";
            // 
            // lbTimKiem
            // 
            lbTimKiem.Anchor = AnchorStyles.Bottom;
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(415, 48);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(70, 20);
            lbTimKiem.TabIndex = 1;
            lbTimKiem.Text = "Tìm kiếm";
            // 
            // lbGiamGiaTheoTungSanPham
            // 
            lbGiamGiaTheoTungSanPham.Anchor = AnchorStyles.Right;
            lbGiamGiaTheoTungSanPham.AutoSize = true;
            lbGiamGiaTheoTungSanPham.Location = new Point(5, 149);
            lbGiamGiaTheoTungSanPham.Name = "lbGiamGiaTheoTungSanPham";
            lbGiamGiaTheoTungSanPham.Size = new Size(196, 40);
            lbGiamGiaTheoTungSanPham.TabIndex = 3;
            lbGiamGiaTheoTungSanPham.Text = "Giảm giá cho một sản phẩm (nếu có)";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(207, 71);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(169, 197);
            dgvSanPham.TabIndex = 4;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
            // 
            // cbbLoaiSanPham
            // 
            cbbLoaiSanPham.Anchor = AnchorStyles.Left;
            cbbLoaiSanPham.FormattingEnabled = true;
            cbbLoaiSanPham.Location = new Point(207, 20);
            cbbLoaiSanPham.Name = "cbbLoaiSanPham";
            cbbLoaiSanPham.Size = new Size(169, 28);
            cbbLoaiSanPham.TabIndex = 6;
            cbbLoaiSanPham.SelectedIndexChanged += cbbLoaiSanPham_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Location = new Point(382, 71);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(136, 27);
            txtTimKiem.TabIndex = 7;
            // 
            // tlpbutton
            // 
            tlpbutton.ColumnCount = 2;
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpbutton.Controls.Add(btnThoat, 1, 0);
            tlpbutton.Controls.Add(btnLuu, 0, 0);
            tlpbutton.Controls.Add(btnLamMoi, 0, 1);
            tlpbutton.Dock = DockStyle.Top;
            tlpbutton.Location = new Point(524, 71);
            tlpbutton.Name = "tlpbutton";
            tlpbutton.RowCount = 2;
            tlpbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpbutton.Size = new Size(292, 125);
            tlpbutton.TabIndex = 8;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(149, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(140, 56);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(3, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(140, 56);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(3, 65);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(140, 57);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // SuaMaGiamGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 554);
            Controls.Add(tlpall);
            Name = "SuaMaGiamGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa mã giảm giá";
            Load += SuaMaGiamGia_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpTren.ResumeLayout(false);
            tlpTren.PerformLayout();
            tlpDuoi.ResumeLayout(false);
            tlpDuoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGiaTriGiamTheoPT).EndInit();
            tlpend.ResumeLayout(false);
            tlpend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            tlpbutton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpTren;
        private TableLayoutPanel tlpDuoi;
        private TableLayoutPanel tlpend;
        private Label lbChonLoaiMaGiamGia;
        private Label lbGiaTriGiam;
        private Label lbTenMaGiamGia;
        private Label lbMaGiamGia;
        private Label lbGiaTriGiamTheoPT;
        private Label lbGiaTriDonHangToiThieu;
        private Label lbNgayBatDau;
        private Label lbNgayKetTHuc;
        private Label lbLoaiSanPham;
        private Label lbTimKiem;
        private Label lbGiamGiaTheoTungSanPham;
        private DataGridView dgvSanPham;
        private ComboBox cbbLoaiMaGiamGia;
        private TextBox txtMaGiamGia;
        private TextBox txtTenMaGiamGia;
        private TextBox txtGiaTriGiam;
        private NumericUpDown numGiaTriGiamTheoPT;
        private TextBox txtGiaTriDonHangToiThieu;
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtpNgayHetHan;
        private ComboBox cbbLoaiSanPham;
        private TextBox txtTimKiem;
        private TableLayoutPanel tlpbutton;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnLamMoi;
    }
}