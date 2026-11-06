namespace ABC
{
    partial class SuaTaiKhoanNhanVien
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
            lbTaiKhoan = new Label();
            lbMatKhau = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtNhapLaiMatKhau = new TextBox();
            lbNhapLaiMatKhau = new Label();
            lbLuongTheoGio = new Label();
            txtLuongTheoGio = new TextBox();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            btnQuayLai = new Button();
            btnLamMoi = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpThongtin.SuspendLayout();
            tlpend.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpThongtin, 0, 1);
            tlpall.Controls.Add(tlpend, 0, 2);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5141239F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 38.6064034F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1826744F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 31.0734463F));
            tlpall.Size = new Size(565, 489);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(559, 79);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpThongtin
            // 
            tlpThongtin.ColumnCount = 4;
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4901609F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8658314F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.9803219F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.6636848F));
            tlpThongtin.Controls.Add(lbTaiKhoan, 1, 0);
            tlpThongtin.Controls.Add(lbMatKhau, 1, 1);
            tlpThongtin.Controls.Add(txtTaiKhoan, 2, 0);
            tlpThongtin.Controls.Add(txtMatKhau, 2, 1);
            tlpThongtin.Controls.Add(txtNhapLaiMatKhau, 2, 2);
            tlpThongtin.Controls.Add(lbNhapLaiMatKhau, 1, 2);
            tlpThongtin.Controls.Add(lbLuongTheoGio, 1, 3);
            tlpThongtin.Controls.Add(txtLuongTheoGio, 2, 3);
            tlpThongtin.Dock = DockStyle.Fill;
            tlpThongtin.Location = new Point(3, 88);
            tlpThongtin.Name = "tlpThongtin";
            tlpThongtin.RowCount = 4;
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpThongtin.Size = new Size(559, 182);
            tlpThongtin.TabIndex = 1;
            // 
            // lbTaiKhoan
            // 
            lbTaiKhoan.Anchor = AnchorStyles.Right;
            lbTaiKhoan.AutoSize = true;
            lbTaiKhoan.Location = new Point(120, 12);
            lbTaiKhoan.Name = "lbTaiKhoan";
            lbTaiKhoan.Size = new Size(97, 20);
            lbTaiKhoan.TabIndex = 0;
            lbTaiKhoan.Text = "Tên tài khoản";
            // 
            // lbMatKhau
            // 
            lbMatKhau.Anchor = AnchorStyles.Right;
            lbMatKhau.AutoSize = true;
            lbMatKhau.Location = new Point(147, 57);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(70, 20);
            lbMatKhau.TabIndex = 1;
            lbMatKhau.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTaiKhoan.Location = new Point(223, 9);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(156, 27);
            txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMatKhau.Location = new Point(223, 54);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(156, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNhapLaiMatKhau.Location = new Point(223, 99);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.Size = new Size(156, 27);
            txtNhapLaiMatKhau.TabIndex = 4;
            // 
            // lbNhapLaiMatKhau
            // 
            lbNhapLaiMatKhau.Anchor = AnchorStyles.Right;
            lbNhapLaiMatKhau.AutoSize = true;
            lbNhapLaiMatKhau.Location = new Point(87, 102);
            lbNhapLaiMatKhau.Name = "lbNhapLaiMatKhau";
            lbNhapLaiMatKhau.Size = new Size(130, 20);
            lbNhapLaiMatKhau.TabIndex = 5;
            lbNhapLaiMatKhau.Text = "Nhập lại mật khẩu";
            // 
            // lbLuongTheoGio
            // 
            lbLuongTheoGio.Anchor = AnchorStyles.Right;
            lbLuongTheoGio.AutoSize = true;
            lbLuongTheoGio.Location = new Point(106, 148);
            lbLuongTheoGio.Name = "lbLuongTheoGio";
            lbLuongTheoGio.Size = new Size(111, 20);
            lbLuongTheoGio.TabIndex = 6;
            lbLuongTheoGio.Text = "Lương theo giờ";
            // 
            // txtLuongTheoGio
            // 
            txtLuongTheoGio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLuongTheoGio.Location = new Point(223, 145);
            txtLuongTheoGio.Name = "txtLuongTheoGio";
            txtLuongTheoGio.Size = new Size(156, 27);
            txtLuongTheoGio.TabIndex = 7;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 4;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6690521F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.6547413F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.2558136F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.4203949F));
            tlpend.Controls.Add(btnThoat, 3, 0);
            tlpend.Controls.Add(btnQuayLai, 2, 0);
            tlpend.Controls.Add(btnLamMoi, 1, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 276);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpend.Size = new Size(559, 58);
            tlpend.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(364, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 52);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuayLai.Location = new Point(237, 3);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(121, 52);
            btnQuayLai.TabIndex = 1;
            btnQuayLai.Text = "QUAY LẠI";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.Location = new Point(107, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(121, 52);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // SuaTaiKhoanNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 489);
            Controls.Add(tlpall);
            Name = "SuaTaiKhoanNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa tài khoản cho nhân viên";
            Load += SuaTaiKhoanNhanVien_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpThongtin.ResumeLayout(false);
            tlpThongtin.PerformLayout();
            tlpend.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpThongtin;
        private Label lbTaiKhoan;
        private Label lbMatKhau;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtNhapLaiMatKhau;
        private Label lbNhapLaiMatKhau;
        private Label lbLuongTheoGio;
        private TextBox txtLuongTheoGio;
        private TableLayoutPanel tlpend;
        private Button btnThoat;
        private Button btnQuayLai;
        private Button btnLamMoi;
    }
}