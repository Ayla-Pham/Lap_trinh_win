namespace ABC
{
    partial class SuaSanPham
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
            tlpAll = new TableLayoutPanel();
            picLogo = new PictureBox();
            tlpThongtin = new TableLayoutPanel();
            txtSoLuongCanhBao = new TextBox();
            label1 = new Label();
            lbMa = new Label();
            lbTen = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            lbLoai = new Label();
            cbbLoaiSanPham = new ComboBox();
            tlpSize = new TableLayoutPanel();
            lbGia = new Label();
            lbSuaAnh = new Label();
            tlpSuaMoTa = new TableLayoutPanel();
            btnSuaAnh = new Button();
            picAnhSua = new PictureBox();
            tlpEnd = new TableLayoutPanel();
            btnThoat = new Button();
            btnLuu = new Button();
            txtGia = new TextBox();
            tlpAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpThongtin.SuspendLayout();
            tlpSize.SuspendLayout();
            tlpSuaMoTa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhSua).BeginInit();
            tlpEnd.SuspendLayout();
            SuspendLayout();
            // 
            // tlpAll
            // 
            tlpAll.ColumnCount = 1;
            tlpAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAll.Controls.Add(picLogo, 0, 0);
            tlpAll.Controls.Add(tlpThongtin, 0, 1);
            tlpAll.Controls.Add(tlpSize, 0, 2);
            tlpAll.Controls.Add(tlpEnd, 0, 3);
            tlpAll.Dock = DockStyle.Fill;
            tlpAll.Location = new Point(0, 0);
            tlpAll.Name = "tlpAll";
            tlpAll.RowCount = 4;
            tlpAll.RowStyles.Add(new RowStyle(SizeType.Percent, 16.9230766F));
            tlpAll.RowStyles.Add(new RowStyle(SizeType.Percent, 18.434782F));
            tlpAll.RowStyles.Add(new RowStyle(SizeType.Percent, 51.1304359F));
            tlpAll.RowStyles.Add(new RowStyle(SizeType.Percent, 13.391304F));
            tlpAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAll.Size = new Size(816, 575);
            tlpAll.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(810, 91);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpThongtin
            // 
            tlpThongtin.ColumnCount = 4;
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6109257F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.9587517F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5128212F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.14047F));
            tlpThongtin.Controls.Add(txtSoLuongCanhBao, 3, 1);
            tlpThongtin.Controls.Add(label1, 2, 1);
            tlpThongtin.Controls.Add(lbMa, 0, 0);
            tlpThongtin.Controls.Add(lbTen, 0, 1);
            tlpThongtin.Controls.Add(txtMa, 1, 0);
            tlpThongtin.Controls.Add(txtTen, 1, 1);
            tlpThongtin.Controls.Add(lbLoai, 2, 0);
            tlpThongtin.Controls.Add(cbbLoaiSanPham, 3, 0);
            tlpThongtin.Dock = DockStyle.Fill;
            tlpThongtin.Location = new Point(3, 100);
            tlpThongtin.Name = "tlpThongtin";
            tlpThongtin.RowCount = 2;
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 47.5609741F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 52.4390259F));
            tlpThongtin.Size = new Size(810, 100);
            tlpThongtin.TabIndex = 1;
            // 
            // txtSoLuongCanhBao
            // 
            txtSoLuongCanhBao.Anchor = AnchorStyles.Left;
            txtSoLuongCanhBao.Location = new Point(471, 60);
            txtSoLuongCanhBao.Name = "txtSoLuongCanhBao";
            txtSoLuongCanhBao.Size = new Size(261, 27);
            txtSoLuongCanhBao.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(331, 47);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 7;
            label1.Text = "Số lượng cảnh báo";
            // 
            // lbMa
            // 
            lbMa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbMa.AutoSize = true;
            lbMa.Location = new Point(33, 0);
            lbMa.Name = "lbMa";
            lbMa.Size = new Size(98, 20);
            lbMa.TabIndex = 1;
            lbMa.Text = "Mã sản phẩm";
            // 
            // lbTen
            // 
            lbTen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTen.AutoSize = true;
            lbTen.Location = new Point(31, 47);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(100, 20);
            lbTen.TabIndex = 2;
            lbTen.Text = "Tên sản phẩm";
            // 
            // txtMa
            // 
            txtMa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMa.Location = new Point(137, 3);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(163, 27);
            txtMa.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTen.Location = new Point(137, 50);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(163, 27);
            txtTen.TabIndex = 3;
            // 
            // lbLoai
            // 
            lbLoai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbLoai.AutoSize = true;
            lbLoai.Location = new Point(360, 0);
            lbLoai.Name = "lbLoai";
            lbLoai.Size = new Size(105, 20);
            lbLoai.TabIndex = 4;
            lbLoai.Text = "Loại sản phẩm";
            // 
            // cbbLoaiSanPham
            // 
            cbbLoaiSanPham.FormattingEnabled = true;
            cbbLoaiSanPham.Location = new Point(471, 3);
            cbbLoaiSanPham.Name = "cbbLoaiSanPham";
            cbbLoaiSanPham.Size = new Size(261, 28);
            cbbLoaiSanPham.TabIndex = 5;
            // 
            // tlpSize
            // 
            tlpSize.ColumnCount = 2;
            tlpSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSize.Controls.Add(lbGia, 0, 0);
            tlpSize.Controls.Add(lbSuaAnh, 0, 1);
            tlpSize.Controls.Add(tlpSuaMoTa, 1, 1);
            tlpSize.Controls.Add(txtGia, 1, 0);
            tlpSize.Dock = DockStyle.Fill;
            tlpSize.Location = new Point(3, 206);
            tlpSize.Name = "tlpSize";
            tlpSize.RowCount = 2;
            tlpSize.RowStyles.Add(new RowStyle(SizeType.Percent, 26.3843651F));
            tlpSize.RowStyles.Add(new RowStyle(SizeType.Percent, 73.61564F));
            tlpSize.Size = new Size(810, 288);
            tlpSize.TabIndex = 2;
            // 
            // lbGia
            // 
            lbGia.Anchor = AnchorStyles.Right;
            lbGia.AutoSize = true;
            lbGia.Location = new Point(247, 27);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(155, 20);
            lbGia.TabIndex = 0;
            lbGia.Text = "Sửa giá cho sản phẩm";
            // 
            // lbSuaAnh
            // 
            lbSuaAnh.Anchor = AnchorStyles.Right;
            lbSuaAnh.AutoSize = true;
            lbSuaAnh.Location = new Point(260, 171);
            lbSuaAnh.Name = "lbSuaAnh";
            lbSuaAnh.Size = new Size(142, 20);
            lbSuaAnh.TabIndex = 1;
            lbSuaAnh.Text = "Mô tả ảnh minh họa";
            // 
            // tlpSuaMoTa
            // 
            tlpSuaMoTa.ColumnCount = 2;
            tlpSuaMoTa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSuaMoTa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSuaMoTa.Controls.Add(btnSuaAnh, 1, 0);
            tlpSuaMoTa.Controls.Add(picAnhSua, 0, 0);
            tlpSuaMoTa.Dock = DockStyle.Fill;
            tlpSuaMoTa.Location = new Point(408, 78);
            tlpSuaMoTa.Name = "tlpSuaMoTa";
            tlpSuaMoTa.RowCount = 1;
            tlpSuaMoTa.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSuaMoTa.Size = new Size(399, 207);
            tlpSuaMoTa.TabIndex = 3;
            // 
            // btnSuaAnh
            // 
            btnSuaAnh.Anchor = AnchorStyles.Left;
            btnSuaAnh.Location = new Point(202, 67);
            btnSuaAnh.Name = "btnSuaAnh";
            btnSuaAnh.Size = new Size(142, 73);
            btnSuaAnh.TabIndex = 1;
            btnSuaAnh.Text = "Chọn ảnh khác";
            btnSuaAnh.UseVisualStyleBackColor = true;
            btnSuaAnh.Click += btnSuaAnh_Click;
            // 
            // picAnhSua
            // 
            picAnhSua.Anchor = AnchorStyles.Left;
            picAnhSua.Location = new Point(3, 3);
            picAnhSua.Name = "picAnhSua";
            picAnhSua.Size = new Size(193, 201);
            picAnhSua.SizeMode = PictureBoxSizeMode.Zoom;
            picAnhSua.TabIndex = 0;
            picAnhSua.TabStop = false;
            // 
            // tlpEnd
            // 
            tlpEnd.ColumnCount = 2;
            tlpEnd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.18519F));
            tlpEnd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.8148146F));
            tlpEnd.Controls.Add(btnThoat, 1, 0);
            tlpEnd.Controls.Add(btnLuu, 0, 0);
            tlpEnd.Dock = DockStyle.Fill;
            tlpEnd.Location = new Point(3, 500);
            tlpEnd.Name = "tlpEnd";
            tlpEnd.RowCount = 1;
            tlpEnd.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpEnd.Size = new Size(810, 72);
            tlpEnd.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(693, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 66);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.Location = new Point(581, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(106, 66);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtGia
            // 
            txtGia.Anchor = AnchorStyles.Left;
            txtGia.Location = new Point(408, 24);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(196, 27);
            txtGia.TabIndex = 4;
            // 
            // SuaSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 575);
            Controls.Add(tlpAll);
            Name = "SuaSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa thông tin sản phẩm";
            Load += SuaSanPham_Load;
            tlpAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpThongtin.ResumeLayout(false);
            tlpThongtin.PerformLayout();
            tlpSize.ResumeLayout(false);
            tlpSize.PerformLayout();
            tlpSuaMoTa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAnhSua).EndInit();
            tlpEnd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpAll;
        private PictureBox picLogo;
        private TableLayoutPanel tlpThongtin;
        private Label lbMa;
        private Label lbTen;
        private TextBox txtMa;
        private TextBox txtTen;
        private Label lbLoai;
        private ComboBox cbbLoaiSanPham;
        private TableLayoutPanel tlpSize;
        private Label lbGia;
        private Label lbSuaAnh;
        private TableLayoutPanel tlpSuaMoTa;
        private PictureBox picAnhSua;
        private Button btnSuaAnh;
        private TableLayoutPanel tlpEnd;
        private Button btnThoat;
        private Button btnLuu;
        private Label label1;
        private TextBox txtSoLuongCanhBao;
        private TextBox txtGia;
    }
}