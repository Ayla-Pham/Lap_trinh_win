namespace ABC
{
    partial class DoiMatKhauNhanVien
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
            lbTenTaiKhoan = new Label();
            lbMatKhau = new Label();
            lbMatKhauMoi = new Label();
            lbNhapLaiMatKhauMoi = new Label();
            txtTenTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtNhapLaiMatKhauMoi = new TextBox();
            tlpbutton = new TableLayoutPanel();
            btnThoat = new Button();
            btnLuu = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpThongTin.SuspendLayout();
            tlpbutton.SuspendLayout();
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
            tlpall.Margin = new Padding(3, 2, 3, 2);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 16.5618458F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 51.4218025F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 1.67714882F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 30.56872F));
            tlpall.Size = new Size(388, 316);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 2);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(382, 48);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 2;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.Controls.Add(lbTenTaiKhoan, 0, 0);
            tlpThongTin.Controls.Add(lbMatKhau, 0, 1);
            tlpThongTin.Controls.Add(lbMatKhauMoi, 0, 2);
            tlpThongTin.Controls.Add(lbNhapLaiMatKhauMoi, 0, 3);
            tlpThongTin.Controls.Add(txtTenTaiKhoan, 1, 0);
            tlpThongTin.Controls.Add(txtMatKhau, 1, 1);
            tlpThongTin.Controls.Add(txtMatKhauMoi, 1, 2);
            tlpThongTin.Controls.Add(txtNhapLaiMatKhauMoi, 1, 3);
            tlpThongTin.Controls.Add(tlpbutton, 1, 4);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(3, 54);
            tlpThongTin.Margin = new Padding(3, 2, 3, 2);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 5;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 16.1904755F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1428566F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 33.1632652F));
            tlpThongTin.Size = new Size(382, 158);
            tlpThongTin.TabIndex = 1;
            // 
            // lbTenTaiKhoan
            // 
            lbTenTaiKhoan.Anchor = AnchorStyles.Right;
            lbTenTaiKhoan.AutoSize = true;
            lbTenTaiKhoan.Location = new Point(110, 5);
            lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            lbTenTaiKhoan.Size = new Size(78, 15);
            lbTenTaiKhoan.TabIndex = 0;
            lbTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // lbMatKhau
            // 
            lbMatKhau.Anchor = AnchorStyles.Right;
            lbMatKhau.AutoSize = true;
            lbMatKhau.Location = new Point(131, 30);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(57, 15);
            lbMatKhau.TabIndex = 0;
            lbMatKhau.Text = "Mật khẩu";
            // 
            // lbMatKhauMoi
            // 
            lbMatKhauMoi.Anchor = AnchorStyles.Right;
            lbMatKhauMoi.AutoSize = true;
            lbMatKhauMoi.Location = new Point(107, 57);
            lbMatKhauMoi.Name = "lbMatKhauMoi";
            lbMatKhauMoi.Size = new Size(81, 15);
            lbMatKhauMoi.TabIndex = 0;
            lbMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lbNhapLaiMatKhauMoi
            // 
            lbNhapLaiMatKhauMoi.Anchor = AnchorStyles.Right;
            lbNhapLaiMatKhauMoi.AutoSize = true;
            lbNhapLaiMatKhauMoi.Location = new Point(60, 83);
            lbNhapLaiMatKhauMoi.Name = "lbNhapLaiMatKhauMoi";
            lbNhapLaiMatKhauMoi.Size = new Size(128, 15);
            lbNhapLaiMatKhauMoi.TabIndex = 0;
            lbNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu mới";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Anchor = AnchorStyles.Left;
            txtTenTaiKhoan.Location = new Point(194, 2);
            txtTenTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(182, 23);
            txtTenTaiKhoan.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left;
            txtMatKhau.Location = new Point(194, 27);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(182, 23);
            txtMatKhau.TabIndex = 0;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Anchor = AnchorStyles.Left;
            txtMatKhauMoi.Location = new Point(194, 53);
            txtMatKhauMoi.Margin = new Padding(3, 2, 3, 2);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(182, 23);
            txtMatKhauMoi.TabIndex = 2;
            // 
            // txtNhapLaiMatKhauMoi
            // 
            txtNhapLaiMatKhauMoi.Anchor = AnchorStyles.Left;
            txtNhapLaiMatKhauMoi.Location = new Point(194, 80);
            txtNhapLaiMatKhauMoi.Margin = new Padding(3, 2, 3, 2);
            txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            txtNhapLaiMatKhauMoi.Size = new Size(182, 23);
            txtNhapLaiMatKhauMoi.TabIndex = 3;
            // 
            // tlpbutton
            // 
            tlpbutton.ColumnCount = 2;
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpbutton.Controls.Add(btnThoat, 1, 0);
            tlpbutton.Controls.Add(btnLuu, 0, 0);
            tlpbutton.Dock = DockStyle.Fill;
            tlpbutton.Location = new Point(194, 106);
            tlpbutton.Margin = new Padding(3, 2, 3, 2);
            tlpbutton.Name = "tlpbutton";
            tlpbutton.RowCount = 1;
            tlpbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpbutton.Size = new Size(185, 50);
            tlpbutton.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(95, 2);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(87, 44);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.Location = new Point(3, 2);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 44);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click_1;
            // 
            // DoiMatKhauNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 316);
            Controls.Add(tlpall);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DoiMatKhauNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            Load += DoiMatKhauNhanVien_Load_1;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpThongTin.ResumeLayout(false);
            tlpThongTin.PerformLayout();
            tlpbutton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpThongTin;
        private Label lbTenTaiKhoan;
        private Label lbMatKhau;
        private Label lbMatKhauMoi;
        private Label lbNhapLaiMatKhauMoi;
        private TextBox txtTenTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtMatKhauMoi;
        private TextBox txtNhapLaiMatKhauMoi;
        private TableLayoutPanel tlpbutton;
        private Button btnThoat;
        private Button btnLuu;
    }
}