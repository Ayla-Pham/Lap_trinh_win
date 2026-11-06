namespace ABC
{
    partial class ThemKhachHang
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
            tlpThongTin = new TableLayoutPanel();
            lbTenKhachHang = new Label();
            lbSoDienThoai = new Label();
            lbTichDiem = new Label();
            btnLuu = new Button();
            btnThoat = new Button();
            txtTenKH = new TextBox();
            txtTichDiem = new TextBox();
            txtSDT = new TextBox();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpThongTin, 0, 1);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 3;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7009344F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 57.0637131F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 27.4238224F));
            tlpall.Size = new Size(464, 361);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(458, 50);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 4;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.502183F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.38428F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.66812F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4454145F));
            tlpThongTin.Controls.Add(lbTenKhachHang, 1, 0);
            tlpThongTin.Controls.Add(lbSoDienThoai, 1, 1);
            tlpThongTin.Controls.Add(lbTichDiem, 1, 2);
            tlpThongTin.Controls.Add(btnLuu, 1, 3);
            tlpThongTin.Controls.Add(btnThoat, 2, 3);
            tlpThongTin.Controls.Add(txtTenKH, 2, 0);
            tlpThongTin.Controls.Add(txtTichDiem, 2, 2);
            tlpThongTin.Controls.Add(txtSDT, 2, 1);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(3, 59);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 4;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1105518F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1105518F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 31.65829F));
            tlpThongTin.Size = new Size(458, 199);
            tlpThongTin.TabIndex = 1;
            // 
            // lbTenKhachHang
            // 
            lbTenKhachHang.Anchor = AnchorStyles.Right;
            lbTenKhachHang.AutoSize = true;
            lbTenKhachHang.Location = new Point(87, 14);
            lbTenKhachHang.Name = "lbTenKhachHang";
            lbTenKhachHang.Size = new Size(111, 20);
            lbTenKhachHang.TabIndex = 0;
            lbTenKhachHang.Text = "Tên khách hàng";
            // 
            // lbSoDienThoai
            // 
            lbSoDienThoai.Anchor = AnchorStyles.Right;
            lbSoDienThoai.AutoSize = true;
            lbSoDienThoai.Location = new Point(101, 60);
            lbSoDienThoai.Name = "lbSoDienThoai";
            lbSoDienThoai.Size = new Size(97, 20);
            lbSoDienThoai.TabIndex = 0;
            lbSoDienThoai.Text = "Số điện thoại";
            // 
            // lbTichDiem
            // 
            lbTichDiem.Anchor = AnchorStyles.Right;
            lbTichDiem.AutoSize = true;
            lbTichDiem.Location = new Point(124, 103);
            lbTichDiem.Name = "lbTichDiem";
            lbTichDiem.Size = new Size(74, 20);
            lbTichDiem.TabIndex = 0;
            lbTichDiem.Text = "Tích điểm";
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.Location = new Point(86, 138);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 56);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(204, 138);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(122, 58);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.Left;
            txtTenKH.Location = new Point(204, 11);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(194, 27);
            txtTenKH.TabIndex = 2;
            // 
            // txtTichDiem
            // 
            txtTichDiem.Anchor = AnchorStyles.Left;
            txtTichDiem.Location = new Point(204, 100);
            txtTichDiem.Name = "txtTichDiem";
            txtTichDiem.Size = new Size(194, 27);
            txtTichDiem.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Left;
            txtSDT.Location = new Point(204, 57);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 27);
            txtSDT.TabIndex = 2;
            // 
            // ThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 361);
            Controls.Add(tlpall);
            Name = "ThemKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm khách hàng";
            Load += ThemKhachHang_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpThongTin.ResumeLayout(false);
            tlpThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpThongTin;
        private Label lbTenKhachHang;
        private Label lbSoDienThoai;
        private Label lbTichDiem;
        private Button btnLuu;
        private Button btnThoat;
        private TextBox txtTenKH;
        private TextBox txtTichDiem;
        private TextBox txtSDT;
    }
}