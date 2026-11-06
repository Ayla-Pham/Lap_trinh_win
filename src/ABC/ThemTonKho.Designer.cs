namespace ABC
{
    partial class ThemTonKho
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
            tlpend = new TableLayoutPanel();
            btnThem = new Button();
            btnThoat = new Button();
            picLogo = new PictureBox();
            tlpall = new TableLayoutPanel();
            flpDanhSachSP = new FlowLayoutPanel();
            tlpThongtin = new TableLayoutPanel();
            lbChonNhaCungCap = new Label();
            cbbNhaCungCap = new ComboBox();
            lbltongtien = new Label();
            texttongtien = new TextBox();
            lbChonSanPham = new Label();
            txtTimKiem = new TextBox();
            lbNhapSoLuong = new Label();
            txtSoLuong = new TextBox();
            lbGiaNhap = new Label();
            txtGiaNhap = new TextBox();
            tlpend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpall.SuspendLayout();
            tlpThongtin.SuspendLayout();
            SuspendLayout();
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 3;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.85787F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8934F));
            tlpend.Controls.Add(btnThem, 1, 0);
            tlpend.Controls.Add(btnThoat, 2, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 469);
            tlpend.Margin = new Padding(3, 2, 3, 2);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpend.Size = new Size(710, 56);
            tlpend.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(469, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 39);
            btnThem.TabIndex = 1;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(585, 2);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 39);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 2);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(710, 83);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(flpDanhSachSP, 0, 2);
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpThongtin, 0, 1);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Margin = new Padding(3, 2, 3, 2);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 16.5384617F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tlpall.Size = new Size(716, 527);
            tlpall.TabIndex = 0;
            // 
            // flpDanhSachSP
            // 
            flpDanhSachSP.AutoScroll = true;
            flpDanhSachSP.BackColor = Color.White;
            flpDanhSachSP.Dock = DockStyle.Fill;
            flpDanhSachSP.FlowDirection = FlowDirection.TopDown;
            flpDanhSachSP.Location = new Point(3, 194);
            flpDanhSachSP.Margin = new Padding(3, 2, 3, 2);
            flpDanhSachSP.Name = "flpDanhSachSP";
            flpDanhSachSP.Size = new Size(710, 271);
            flpDanhSachSP.TabIndex = 4;
            flpDanhSachSP.WrapContents = false;
            // 
            // tlpThongtin
            // 
            tlpThongtin.ColumnCount = 2;
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongtin.Controls.Add(lbChonNhaCungCap, 0, 0);
            tlpThongtin.Controls.Add(cbbNhaCungCap, 0, 1);
            tlpThongtin.Controls.Add(lbltongtien, 1, 0);
            tlpThongtin.Controls.Add(texttongtien, 1, 1);
            tlpThongtin.Controls.Add(lbChonSanPham, 0, 2);
            tlpThongtin.Controls.Add(txtTimKiem, 0, 3);
            tlpThongtin.Controls.Add(lbNhapSoLuong, 1, 2);
            tlpThongtin.Controls.Add(txtSoLuong, 1, 3);
            tlpThongtin.Controls.Add(lbGiaNhap, 1, 4);
            tlpThongtin.Controls.Add(txtGiaNhap, 1, 5);
            tlpThongtin.Dock = DockStyle.Fill;
            tlpThongtin.Location = new Point(3, 89);
            tlpThongtin.Margin = new Padding(3, 2, 3, 2);
            tlpThongtin.Name = "tlpThongtin";
            tlpThongtin.RowCount = 6;
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpThongtin.Size = new Size(710, 101);
            tlpThongtin.TabIndex = 1;
            // 
            // lbChonNhaCungCap
            // 
            lbChonNhaCungCap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbChonNhaCungCap.AutoSize = true;
            lbChonNhaCungCap.Location = new Point(3, 15);
            lbChonNhaCungCap.Name = "lbChonNhaCungCap";
            lbChonNhaCungCap.Size = new Size(111, 15);
            lbChonNhaCungCap.TabIndex = 0;
            lbChonNhaCungCap.Text = "Chọn nhà cung cấp";
            // 
            // cbbNhaCungCap
            // 
            cbbNhaCungCap.FormattingEnabled = true;
            cbbNhaCungCap.Location = new Point(3, 32);
            cbbNhaCungCap.Margin = new Padding(3, 2, 3, 2);
            cbbNhaCungCap.Name = "cbbNhaCungCap";
            cbbNhaCungCap.Size = new Size(333, 23);
            cbbNhaCungCap.TabIndex = 1;
            // 
            // lbltongtien
            // 
            lbltongtien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbltongtien.AutoSize = true;
            lbltongtien.Location = new Point(358, 15);
            lbltongtien.Name = "lbltongtien";
            lbltongtien.Size = new Size(57, 15);
            lbltongtien.TabIndex = 9;
            lbltongtien.Text = "Tổng tiền";
            lbltongtien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // texttongtien
            // 
            texttongtien.Location = new Point(358, 32);
            texttongtien.Margin = new Padding(3, 2, 3, 2);
            texttongtien.Name = "texttongtien";
            texttongtien.ReadOnly = true;
            texttongtien.Size = new Size(333, 23);
            texttongtien.TabIndex = 13;
            // 
            // lbChonSanPham
            // 
            lbChonSanPham.Location = new Point(3, 100);
            lbChonSanPham.Name = "lbChonSanPham";
            lbChonSanPham.Size = new Size(88, 1);
            lbChonSanPham.TabIndex = 14;
            lbChonSanPham.Visible = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(3, 102);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(88, 23);
            txtTimKiem.TabIndex = 15;
            txtTimKiem.Visible = false;
            // 
            // lbNhapSoLuong
            // 
            lbNhapSoLuong.Location = new Point(358, 100);
            lbNhapSoLuong.Name = "lbNhapSoLuong";
            lbNhapSoLuong.Size = new Size(88, 1);
            lbNhapSoLuong.TabIndex = 16;
            lbNhapSoLuong.Visible = false;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(358, 102);
            txtSoLuong.Margin = new Padding(3, 2, 3, 2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(88, 23);
            txtSoLuong.TabIndex = 17;
            txtSoLuong.Visible = false;
            // 
            // lbGiaNhap
            // 
            lbGiaNhap.Location = new Point(358, 100);
            lbGiaNhap.Name = "lbGiaNhap";
            lbGiaNhap.Size = new Size(88, 1);
            lbGiaNhap.TabIndex = 18;
            lbGiaNhap.Visible = false;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(358, 102);
            txtGiaNhap.Margin = new Padding(3, 2, 3, 2);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(88, 23);
            txtGiaNhap.TabIndex = 19;
            txtGiaNhap.Visible = false;
            // 
            // ThemTonKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 527);
            Controls.Add(tlpall);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThemTonKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm tồn kho";
            tlpend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpall.ResumeLayout(false);
            tlpThongtin.ResumeLayout(false);
            tlpThongtin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpend;
        private Button btnThoat;
        private Button btnThem;
        private PictureBox picLogo;
        private TableLayoutPanel tlpall;
        // private DataGridView dgvThemkho; // Đã xóa
        private FlowLayoutPanel flpDanhSachSP; // Đã thêm
        private TableLayoutPanel tlpThongtin;
        private Label lbChonNhaCungCap;
        private Label lbChonSanPham;
        private TextBox txtTimKiem;
        private TextBox txtSoLuong;
        private Label lbGiaNhap;
        private ComboBox cbbNhaCungCap;
        private Label lbNhapSoLuong;
        private TextBox txtGiaNhap;
        private Label lbltongtien;
        private TextBox texttongtien;
    }
}