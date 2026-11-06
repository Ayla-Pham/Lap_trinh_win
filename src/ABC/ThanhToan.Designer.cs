namespace ABC
{
    partial class ThanhToan
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
            tLPall = new TableLayoutPanel();
            picLogo = new PictureBox();
            tlpthan = new TableLayoutPanel();
            pnThanhToan = new Panel();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            btnThanhtoan = new Button();
            lblSDT = new Label();
            tlpThoiTIen = new TableLayoutPanel();
            lbTienKhachDua = new Label();
            lbTienTraLai = new Label();
            txtTienKhachDua = new TextBox();
            txtTienTraLai = new TextBox();
            lblCanhBao = new Label();
            lblTenKhachHang = new Label();
            lbTongTien = new Label();
            flpSanPham = new FlowLayoutPanel();
            tLPall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpthan.SuspendLayout();
            pnThanhToan.SuspendLayout();
            tlpend.SuspendLayout();
            tlpThoiTIen.SuspendLayout();
            SuspendLayout();
            // 
            // tLPall
            // 
            tLPall.ColumnCount = 1;
            tLPall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tLPall.Controls.Add(picLogo, 0, 0);
            tLPall.Controls.Add(tlpthan, 0, 1);
            tLPall.Dock = DockStyle.Fill;
            tLPall.Location = new Point(0, 0);
            tLPall.Name = "tLPall";
            tLPall.RowCount = 2;
            tLPall.RowStyles.Add(new RowStyle(SizeType.Percent, 14.821764F));
            tLPall.RowStyles.Add(new RowStyle(SizeType.Percent, 85.17824F));
            tLPall.Size = new Size(800, 533);
            tLPall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(794, 73);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpthan
            // 
            tlpthan.ColumnCount = 2;
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.576828F));
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.423172F));
            tlpthan.Controls.Add(pnThanhToan, 1, 0);
            tlpthan.Controls.Add(flpSanPham, 0, 0);
            tlpthan.Dock = DockStyle.Fill;
            tlpthan.Location = new Point(3, 82);
            tlpthan.Name = "tlpthan";
            tlpthan.RowCount = 1;
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpthan.Size = new Size(794, 448);
            tlpthan.TabIndex = 1;
            // 
            // pnThanhToan
            // 
            pnThanhToan.Controls.Add(tlpend);
            pnThanhToan.Controls.Add(tlpThoiTIen);
            pnThanhToan.Controls.Add(lbTongTien);
            pnThanhToan.Dock = DockStyle.Fill;
            pnThanhToan.Location = new Point(349, 3);
            pnThanhToan.Name = "pnThanhToan";
            pnThanhToan.Size = new Size(442, 442);
            pnThanhToan.TabIndex = 0;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 2;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.68326F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.3167419F));
            tlpend.Controls.Add(btnThoat, 1, 1);
            tlpend.Controls.Add(btnThanhtoan, 0, 1);
            tlpend.Controls.Add(lblSDT, 0, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(0, 173);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 2;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 70.95238F));
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 29.0476189F));
            tlpend.Size = new Size(442, 269);
            tlpend.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(311, 193);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 56);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThanhtoan
            // 
            btnThanhtoan.Location = new Point(3, 193);
            btnThanhtoan.Name = "btnThanhtoan";
            btnThanhtoan.Size = new Size(157, 60);
            btnThanhtoan.TabIndex = 2;
            btnThanhtoan.Text = "THANH TOÁN";
            btnThanhtoan.UseVisualStyleBackColor = true;
            btnThanhtoan.Click += btnThanhtoan_Click;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(3, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(97, 20);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại";
            // 
            // tlpThoiTIen
            // 
            tlpThoiTIen.ColumnCount = 2;
            tlpThoiTIen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.22172F));
            tlpThoiTIen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.77828F));
            tlpThoiTIen.Controls.Add(lbTienKhachDua, 0, 0);
            tlpThoiTIen.Controls.Add(lbTienTraLai, 0, 1);
            tlpThoiTIen.Controls.Add(txtTienKhachDua, 1, 0);
            tlpThoiTIen.Controls.Add(txtTienTraLai, 1, 1);
            tlpThoiTIen.Controls.Add(lblCanhBao, 1, 2);
            tlpThoiTIen.Controls.Add(lblTenKhachHang, 0, 2);
            tlpThoiTIen.Dock = DockStyle.Top;
            tlpThoiTIen.Location = new Point(0, 57);
            tlpThoiTIen.Name = "tlpThoiTIen";
            tlpThoiTIen.RowCount = 3;
            tlpThoiTIen.RowStyles.Add(new RowStyle(SizeType.Percent, 38.94737F));
            tlpThoiTIen.RowStyles.Add(new RowStyle(SizeType.Percent, 34.4827576F));
            tlpThoiTIen.RowStyles.Add(new RowStyle(SizeType.Percent, 26.7241383F));
            tlpThoiTIen.Size = new Size(442, 116);
            tlpThoiTIen.TabIndex = 1;
            // 
            // lbTienKhachDua
            // 
            lbTienKhachDua.Anchor = AnchorStyles.Right;
            lbTienKhachDua.AutoSize = true;
            lbTienKhachDua.Location = new Point(26, 12);
            lbTienKhachDua.Name = "lbTienKhachDua";
            lbTienKhachDua.Size = new Size(109, 20);
            lbTienKhachDua.TabIndex = 0;
            lbTienKhachDua.Text = "Tiền khách đưa";
            // 
            // lbTienTraLai
            // 
            lbTienTraLai.Anchor = AnchorStyles.Right;
            lbTienTraLai.AutoSize = true;
            lbTienTraLai.Location = new Point(56, 54);
            lbTienTraLai.Name = "lbTienTraLai";
            lbTienTraLai.Size = new Size(79, 20);
            lbTienTraLai.TabIndex = 1;
            lbTienTraLai.Text = "Tiền trả lại";
            // 
            // txtTienKhachDua
            // 
            txtTienKhachDua.Anchor = AnchorStyles.Left;
            txtTienKhachDua.Location = new Point(141, 9);
            txtTienKhachDua.Name = "txtTienKhachDua";
            txtTienKhachDua.Size = new Size(298, 27);
            txtTienKhachDua.TabIndex = 3;
            txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;
            txtTienKhachDua.KeyPress += txtTienKhachDua_KeyPress;
            txtTienKhachDua.Leave += txtTienKhachDua_Leave;
            // 
            // txtTienTraLai
            // 
            txtTienTraLai.Anchor = AnchorStyles.Left;
            txtTienTraLai.Location = new Point(141, 51);
            txtTienTraLai.Name = "txtTienTraLai";
            txtTienTraLai.ReadOnly = true;
            txtTienTraLai.Size = new Size(298, 27);
            txtTienTraLai.TabIndex = 3;
            // 
            // lblCanhBao
            // 
            lblCanhBao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCanhBao.AutoSize = true;
            lblCanhBao.ForeColor = Color.Red;
            lblCanhBao.Location = new Point(141, 84);
            lblCanhBao.Name = "lblCanhBao";
            lblCanhBao.Size = new Size(298, 20);
            lblCanhBao.TabIndex = 4;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Location = new Point(3, 84);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(111, 20);
            lblTenKhachHang.TabIndex = 5;
            lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // lbTongTien
            // 
            lbTongTien.Dock = DockStyle.Top;
            lbTongTien.Location = new Point(0, 0);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(442, 57);
            lbTongTien.TabIndex = 0;
            lbTongTien.Text = "TỔNG TIỀN";
            lbTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpSanPham
            // 
            flpSanPham.AutoScroll = true;
            flpSanPham.Dock = DockStyle.Top;
            flpSanPham.Location = new Point(3, 3);
            flpSanPham.Name = "flpSanPham";
            flpSanPham.Size = new Size(340, 442);
            flpSanPham.TabIndex = 1;
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(tLPall);
            Name = "ThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh toán";
            Load += ThanhToan_Load;
            tLPall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpthan.ResumeLayout(false);
            pnThanhToan.ResumeLayout(false);
            tlpend.ResumeLayout(false);
            tlpend.PerformLayout();
            tlpThoiTIen.ResumeLayout(false);
            tlpThoiTIen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tLPall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpthan;
        private Panel pnThanhToan;
        private TableLayoutPanel tlpThoiTIen;
        private Label lbTongTien;
        private Label lbTienKhachDua;
        private Label lbTienTraLai;
        private Button btnThanhtoan;
        private FlowLayoutPanel flpSanPham;
        private TableLayoutPanel tlpend;
        private Button btnThoat;
        private TextBox txtTienKhachDua;
        private TextBox txtTienTraLai;
        private Label lblCanhBao;
        private Label lblSDT;
        private Label lblTenKhachHang;
    }
}