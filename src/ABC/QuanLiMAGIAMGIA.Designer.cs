namespace ABC
{
    partial class QuanLiMAGIAMGIA
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
            tlpChucnang = new TableLayoutPanel();
            lbTimKiem = new Label();
            txtTimKiem = new TextBox();
            cbbLoaiVoucher = new ComboBox();
            btnThemMaGiamGia = new Button();
            btnSuaMaGiamGia = new Button();
            btnSuaMaGiamGia1tang1 = new Button();
            dgvMaGiamGia = new DataGridView();
            tlpDuoi = new TableLayoutPanel();
            btnThoat = new Button();
            btnXoa = new Button();
            btnApDung = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpChucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaGiamGia).BeginInit();
            tlpDuoi.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpChucnang, 0, 1);
            tlpall.Controls.Add(dgvMaGiamGia, 0, 2);
            tlpall.Controls.Add(tlpDuoi, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9944134F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 19.1806335F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 51.5828667F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0558662F));
            tlpall.Size = new Size(854, 559);
            tlpall.TabIndex = 0;
            tlpall.Paint += tlpall_Paint;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(848, 100);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpChucnang
            // 
            tlpChucnang.ColumnCount = 4;
            tlpChucnang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tlpChucnang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.8301888F));
            tlpChucnang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.287735F));
            tlpChucnang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.59434F));
            tlpChucnang.Controls.Add(lbTimKiem, 0, 0);
            tlpChucnang.Controls.Add(txtTimKiem, 2, 0);
            tlpChucnang.Controls.Add(cbbLoaiVoucher, 1, 0);
            tlpChucnang.Controls.Add(btnThemMaGiamGia, 3, 1);
            tlpChucnang.Controls.Add(btnSuaMaGiamGia, 2, 1);
            tlpChucnang.Controls.Add(btnSuaMaGiamGia1tang1, 1, 1);
            tlpChucnang.Dock = DockStyle.Fill;
            tlpChucnang.Location = new Point(3, 109);
            tlpChucnang.Name = "tlpChucnang";
            tlpChucnang.RowCount = 2;
            tlpChucnang.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpChucnang.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpChucnang.Size = new Size(848, 101);
            tlpChucnang.TabIndex = 1;
            // 
            // lbTimKiem
            // 
            lbTimKiem.Anchor = AnchorStyles.Right;
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(81, 15);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(104, 20);
            lbTimKiem.TabIndex = 0;
            lbTimKiem.Text = "Tìm kiếm theo";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Location = new Point(427, 11);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(183, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // cbbLoaiVoucher
            // 
            cbbLoaiVoucher.Anchor = AnchorStyles.Right;
            cbbLoaiVoucher.FormattingEnabled = true;
            cbbLoaiVoucher.Location = new Point(239, 11);
            cbbLoaiVoucher.Name = "cbbLoaiVoucher";
            cbbLoaiVoucher.Size = new Size(182, 28);
            cbbLoaiVoucher.TabIndex = 2;
            cbbLoaiVoucher.SelectedIndexChanged += cbbLoaiVoucher_SelectedIndexChanged;
            // 
            // btnThemMaGiamGia
            // 
            btnThemMaGiamGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemMaGiamGia.Location = new Point(616, 53);
            btnThemMaGiamGia.Name = "btnThemMaGiamGia";
            btnThemMaGiamGia.Size = new Size(186, 45);
            btnThemMaGiamGia.TabIndex = 4;
            btnThemMaGiamGia.Text = "Thêm mã giảm giá";
            btnThemMaGiamGia.UseVisualStyleBackColor = true;
            btnThemMaGiamGia.Click += btnThemMaGiamGia_Click;
            // 
            // btnSuaMaGiamGia
            // 
            btnSuaMaGiamGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSuaMaGiamGia.Location = new Point(428, 53);
            btnSuaMaGiamGia.Name = "btnSuaMaGiamGia";
            btnSuaMaGiamGia.Size = new Size(182, 45);
            btnSuaMaGiamGia.TabIndex = 5;
            btnSuaMaGiamGia.Text = "Sửa mã giảm giá";
            btnSuaMaGiamGia.UseVisualStyleBackColor = true;
            btnSuaMaGiamGia.Click += btnSuaMaGiamGia_Click;
            // 
            // btnSuaMaGiamGia1tang1
            // 
            btnSuaMaGiamGia1tang1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSuaMaGiamGia1tang1.Location = new Point(213, 53);
            btnSuaMaGiamGia1tang1.Name = "btnSuaMaGiamGia1tang1";
            btnSuaMaGiamGia1tang1.Size = new Size(208, 45);
            btnSuaMaGiamGia1tang1.TabIndex = 6;
            btnSuaMaGiamGia1tang1.Text = "Sửa mã giảm giá 1 tặng 1";
            btnSuaMaGiamGia1tang1.UseVisualStyleBackColor = true;
            btnSuaMaGiamGia1tang1.Click += btnSuaMaGiamGia1tang1_Click;
            // 
            // dgvMaGiamGia
            // 
            dgvMaGiamGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaGiamGia.Dock = DockStyle.Fill;
            dgvMaGiamGia.Location = new Point(3, 216);
            dgvMaGiamGia.Name = "dgvMaGiamGia";
            dgvMaGiamGia.RowHeadersWidth = 51;
            dgvMaGiamGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaGiamGia.Size = new Size(848, 282);
            dgvMaGiamGia.TabIndex = 2;
            dgvMaGiamGia.CellContentClick += dgvMaGiamGia_CellContentClick;
            // 
            // tlpDuoi
            // 
            tlpDuoi.ColumnCount = 3;
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.20617F));
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.793829F));
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tlpDuoi.Controls.Add(btnThoat, 2, 0);
            tlpDuoi.Controls.Add(btnXoa, 1, 0);
            tlpDuoi.Controls.Add(btnApDung, 0, 0);
            tlpDuoi.Dock = DockStyle.Fill;
            tlpDuoi.Location = new Point(3, 504);
            tlpDuoi.Name = "tlpDuoi";
            tlpDuoi.RowCount = 1;
            tlpDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDuoi.Size = new Size(848, 52);
            tlpDuoi.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(716, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 46);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.Location = new Point(583, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(127, 46);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnApDung
            // 
            btnApDung.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApDung.Location = new Point(447, 3);
            btnApDung.Name = "btnApDung";
            btnApDung.Size = new Size(129, 46);
            btnApDung.TabIndex = 7;
            btnApDung.Text = "ÁP DỤNG";
            btnApDung.UseVisualStyleBackColor = true;
            btnApDung.Click += btnApDung_Click;
            // 
            // QuanLiMAGIAMGIA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 559);
            Controls.Add(tlpall);
            Name = "QuanLiMAGIAMGIA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí mã giảm giá";
            Load += QuanLiMAGIAMGIA_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpChucnang.ResumeLayout(false);
            tlpChucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaGiamGia).EndInit();
            tlpDuoi.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpChucnang;
        private Label lbTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cbbLoaiVoucher;
        private Button btnThemMaGiamGia;
        private DataGridView dgvMaGiamGia;
        private TableLayoutPanel tlpDuoi;
        private Button btnThoat;
        private Button btnSuaMaGiamGia;
        private Button btnXoa;
        private Button btnSuaMaGiamGia1tang1;
        private Button btnApDung;
    }
}