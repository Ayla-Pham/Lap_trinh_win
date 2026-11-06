namespace ABC
{
    partial class DoiMatKhauQuanLi
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
            lbNhapTenTaiKhoan = new Label();
            lbMatKhau = new Label();
            lbNhapMatKhauMoi = new Label();
            lbNhapLaiMatKhauMoi = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtNhapLaiMatKhauMoi = new TextBox();
            btnLuu = new Button();
            btnThoat = new Button();
            btnLamMoi = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpthongtin.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpthongtin, 0, 1);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Margin = new Padding(3, 2, 3, 2);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 3;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4533014F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7647057F));
            tlpall.Size = new Size(487, 319);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 2);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(481, 35);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpthongtin
            // 
            tlpthongtin.ColumnCount = 4;
            tlpthongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.170599F));
            tlpthongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6715069F));
            tlpthongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7531776F));
            tlpthongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.7676945F));
            tlpthongtin.Controls.Add(lbNhapTenTaiKhoan, 1, 0);
            tlpthongtin.Controls.Add(lbMatKhau, 1, 1);
            tlpthongtin.Controls.Add(lbNhapMatKhauMoi, 1, 2);
            tlpthongtin.Controls.Add(lbNhapLaiMatKhauMoi, 1, 3);
            tlpthongtin.Controls.Add(txtTaiKhoan, 2, 0);
            tlpthongtin.Controls.Add(txtMatKhau, 2, 1);
            tlpthongtin.Controls.Add(txtMatKhauMoi, 2, 2);
            tlpthongtin.Controls.Add(txtNhapLaiMatKhauMoi, 2, 3);
            tlpthongtin.Controls.Add(btnLuu, 1, 4);
            tlpthongtin.Controls.Add(btnThoat, 3, 4);
            tlpthongtin.Controls.Add(btnLamMoi, 2, 4);
            tlpthongtin.Dock = DockStyle.Fill;
            tlpthongtin.Location = new Point(3, 41);
            tlpthongtin.Margin = new Padding(3, 2, 3, 2);
            tlpthongtin.Name = "tlpthongtin";
            tlpthongtin.RowCount = 5;
            tlpthongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 16.35514F));
            tlpthongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 17.75701F));
            tlpthongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 17.12963F));
            tlpthongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9814816F));
            tlpthongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 29.62963F));
            tlpthongtin.Size = new Size(481, 161);
            tlpthongtin.TabIndex = 1;
            // 
            // lbNhapTenTaiKhoan
            // 
            lbNhapTenTaiKhoan.Anchor = AnchorStyles.Right;
            lbNhapTenTaiKhoan.AutoSize = true;
            lbNhapTenTaiKhoan.Location = new Point(94, 5);
            lbNhapTenTaiKhoan.Name = "lbNhapTenTaiKhoan";
            lbNhapTenTaiKhoan.Size = new Size(78, 15);
            lbNhapTenTaiKhoan.TabIndex = 0;
            lbNhapTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // lbMatKhau
            // 
            lbMatKhau.Anchor = AnchorStyles.Right;
            lbMatKhau.AutoSize = true;
            lbMatKhau.Location = new Point(115, 32);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(57, 15);
            lbMatKhau.TabIndex = 1;
            lbMatKhau.Text = "Mật khẩu";
            // 
            // lbNhapMatKhauMoi
            // 
            lbNhapMatKhauMoi.Anchor = AnchorStyles.Right;
            lbNhapMatKhauMoi.AutoSize = true;
            lbNhapMatKhauMoi.Location = new Point(59, 60);
            lbNhapMatKhauMoi.Name = "lbNhapMatKhauMoi";
            lbNhapMatKhauMoi.Size = new Size(113, 15);
            lbNhapMatKhauMoi.TabIndex = 2;
            lbNhapMatKhauMoi.Text = "Nhập mật khẩu mới";
            // 
            // lbNhapLaiMatKhauMoi
            // 
            lbNhapLaiMatKhauMoi.Anchor = AnchorStyles.Right;
            lbNhapLaiMatKhauMoi.AutoSize = true;
            lbNhapLaiMatKhauMoi.Location = new Point(44, 88);
            lbNhapLaiMatKhauMoi.Name = "lbNhapLaiMatKhauMoi";
            lbNhapLaiMatKhauMoi.Size = new Size(128, 15);
            lbNhapLaiMatKhauMoi.TabIndex = 3;
            lbNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu mới";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTaiKhoan.Location = new Point(178, 2);
            txtTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(165, 23);
            txtTaiKhoan.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhau.Location = new Point(178, 28);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(165, 23);
            txtMatKhau.TabIndex = 0;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhauMoi.Location = new Point(178, 56);
            txtMatKhauMoi.Margin = new Padding(3, 2, 3, 2);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(165, 23);
            txtMatKhauMoi.TabIndex = 1;
            // 
            // txtNhapLaiMatKhauMoi
            // 
            txtNhapLaiMatKhauMoi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNhapLaiMatKhauMoi.Location = new Point(178, 84);
            txtNhapLaiMatKhauMoi.Margin = new Padding(3, 2, 3, 2);
            txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            txtNhapLaiMatKhauMoi.Size = new Size(165, 23);
            txtNhapLaiMatKhauMoi.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.Location = new Point(75, 113);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(97, 44);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(349, 113);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 44);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.Location = new Point(237, 113);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 44);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // DoiMatKhauQuanLi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 319);
            Controls.Add(tlpall);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DoiMatKhauQuanLi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            Load += DoiMatKhauQuanLi_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpthongtin.ResumeLayout(false);
            tlpthongtin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpthongtin;
        private Label lbNhapTenTaiKhoan;
        private Label lbMatKhau;
        private Label lbNhapMatKhauMoi;
        private Label lbNhapLaiMatKhauMoi;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtMatKhauMoi;
        private TextBox txtNhapLaiMatKhauMoi;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnLamMoi;
    }
}