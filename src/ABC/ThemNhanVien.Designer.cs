namespace ABC
{
    partial class ThemNhanVien
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
            lbMaNhanVien = new Label();
            lbTenNhanVien = new Label();
            lbSoDienThoai = new Label();
            lbDiaChi = new Label();
            lbTaiKhoan = new Label();
            lbMatKhau = new Label();
            lbNhapLaiMatKhau = new Label();
            lbViTri = new Label();
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtTenTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtNhapLaiMatKhau = new TextBox();
            cbbViTri = new ComboBox();
            tlpDuoi = new TableLayoutPanel();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbLuongTheoGio = new Label();
            txtLuongTheoGio = new TextBox();
            lbNgaySinh = new Label();
            dTPNgaySinh = new DateTimePicker();
            lbChonNganHang = new Label();
            cbbNganHang = new ComboBox();
            lbSoTaiKhoan = new Label();
            txtSoTaiKhoan = new TextBox();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnThem = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpThongTin.SuspendLayout();
            tlpDuoi.SuspendLayout();
            tlpend.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpThongTin, 0, 1);
            tlpall.Controls.Add(tlpDuoi, 0, 2);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Margin = new Padding(3, 2, 3, 2);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5046558F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 38.6609077F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 30.0215988F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 13.780261F));
            tlpall.Size = new Size(648, 347);
            tlpall.TabIndex = 0;
            tlpall.Paint += tlpall_Paint;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 2);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(642, 56);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 4;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9233627F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.138443F));
            tlpThongTin.Controls.Add(lbMaNhanVien, 0, 0);
            tlpThongTin.Controls.Add(lbTenNhanVien, 0, 1);
            tlpThongTin.Controls.Add(lbSoDienThoai, 0, 2);
            tlpThongTin.Controls.Add(lbDiaChi, 0, 3);
            tlpThongTin.Controls.Add(lbTaiKhoan, 2, 0);
            tlpThongTin.Controls.Add(lbMatKhau, 2, 1);
            tlpThongTin.Controls.Add(lbNhapLaiMatKhau, 2, 2);
            tlpThongTin.Controls.Add(lbViTri, 2, 3);
            tlpThongTin.Controls.Add(txtMaNhanVien, 1, 0);
            tlpThongTin.Controls.Add(txtTenNhanVien, 1, 1);
            tlpThongTin.Controls.Add(txtSoDienThoai, 1, 2);
            tlpThongTin.Controls.Add(txtDiaChi, 1, 3);
            tlpThongTin.Controls.Add(txtTenTaiKhoan, 3, 0);
            tlpThongTin.Controls.Add(txtMatKhau, 3, 1);
            tlpThongTin.Controls.Add(txtNhapLaiMatKhau, 3, 2);
            tlpThongTin.Controls.Add(cbbViTri, 3, 3);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(3, 62);
            tlpThongTin.Margin = new Padding(3, 2, 3, 2);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 4;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpThongTin.Size = new Size(642, 130);
            tlpThongTin.TabIndex = 1;
            // 
            // lbMaNhanVien
            // 
            lbMaNhanVien.Anchor = AnchorStyles.Right;
            lbMaNhanVien.AutoSize = true;
            lbMaNhanVien.Location = new Point(78, 8);
            lbMaNhanVien.Name = "lbMaNhanVien";
            lbMaNhanVien.Size = new Size(79, 15);
            lbMaNhanVien.TabIndex = 0;
            lbMaNhanVien.Text = "Mã nhân viên";
            // 
            // lbTenNhanVien
            // 
            lbTenNhanVien.Anchor = AnchorStyles.Right;
            lbTenNhanVien.AutoSize = true;
            lbTenNhanVien.Location = new Point(76, 40);
            lbTenNhanVien.Name = "lbTenNhanVien";
            lbTenNhanVien.Size = new Size(81, 15);
            lbTenNhanVien.TabIndex = 1;
            lbTenNhanVien.Text = "Tên nhân viên";
            // 
            // lbSoDienThoai
            // 
            lbSoDienThoai.Anchor = AnchorStyles.Right;
            lbSoDienThoai.AutoSize = true;
            lbSoDienThoai.Location = new Point(81, 72);
            lbSoDienThoai.Name = "lbSoDienThoai";
            lbSoDienThoai.Size = new Size(76, 15);
            lbSoDienThoai.TabIndex = 2;
            lbSoDienThoai.Text = "Số điện thoại";
            // 
            // lbDiaChi
            // 
            lbDiaChi.Anchor = AnchorStyles.Right;
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(114, 105);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(43, 15);
            lbDiaChi.TabIndex = 3;
            lbDiaChi.Text = "Địa chỉ";
            // 
            // lbTaiKhoan
            // 
            lbTaiKhoan.Anchor = AnchorStyles.Right;
            lbTaiKhoan.AutoSize = true;
            lbTaiKhoan.Location = new Point(353, 8);
            lbTaiKhoan.Name = "lbTaiKhoan";
            lbTaiKhoan.Size = new Size(78, 15);
            lbTaiKhoan.TabIndex = 4;
            lbTaiKhoan.Text = "Tên tài khoản";
            // 
            // lbMatKhau
            // 
            lbMatKhau.Anchor = AnchorStyles.Right;
            lbMatKhau.AutoSize = true;
            lbMatKhau.Location = new Point(374, 40);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(57, 15);
            lbMatKhau.TabIndex = 5;
            lbMatKhau.Text = "Mật khẩu";
            // 
            // lbNhapLaiMatKhau
            // 
            lbNhapLaiMatKhau.Anchor = AnchorStyles.Right;
            lbNhapLaiMatKhau.AutoSize = true;
            lbNhapLaiMatKhau.Location = new Point(327, 72);
            lbNhapLaiMatKhau.Name = "lbNhapLaiMatKhau";
            lbNhapLaiMatKhau.Size = new Size(104, 15);
            lbNhapLaiMatKhau.TabIndex = 7;
            lbNhapLaiMatKhau.Text = "Nhập lại mật khẩu";
            // 
            // lbViTri
            // 
            lbViTri.Anchor = AnchorStyles.Right;
            lbViTri.AutoSize = true;
            lbViTri.Location = new Point(400, 105);
            lbViTri.Name = "lbViTri";
            lbViTri.Size = new Size(31, 15);
            lbViTri.TabIndex = 6;
            lbViTri.Text = "Vị trí";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Anchor = AnchorStyles.Left;
            txtMaNhanVien.Location = new Point(163, 4);
            txtMaNhanVien.Margin = new Padding(3, 2, 3, 2);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(154, 23);
            txtMaNhanVien.TabIndex = 8;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Anchor = AnchorStyles.Left;
            txtTenNhanVien.Location = new Point(163, 36);
            txtTenNhanVien.Margin = new Padding(3, 2, 3, 2);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(154, 23);
            txtTenNhanVien.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Anchor = AnchorStyles.Left;
            txtSoDienThoai.Location = new Point(163, 68);
            txtSoDienThoai.Margin = new Padding(3, 2, 3, 2);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(154, 23);
            txtSoDienThoai.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Left;
            txtDiaChi.Location = new Point(163, 101);
            txtDiaChi.Margin = new Padding(3, 2, 3, 2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(154, 23);
            txtDiaChi.TabIndex = 8;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Anchor = AnchorStyles.Left;
            txtTenTaiKhoan.Location = new Point(437, 4);
            txtTenTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(173, 23);
            txtTenTaiKhoan.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left;
            txtMatKhau.Location = new Point(437, 36);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(173, 23);
            txtMatKhau.TabIndex = 9;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Anchor = AnchorStyles.Left;
            txtNhapLaiMatKhau.Location = new Point(437, 68);
            txtNhapLaiMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.Size = new Size(173, 23);
            txtNhapLaiMatKhau.TabIndex = 9;
            // 
            // cbbViTri
            // 
            cbbViTri.Anchor = AnchorStyles.Left;
            cbbViTri.FormattingEnabled = true;
            cbbViTri.Location = new Point(437, 101);
            cbbViTri.Margin = new Padding(3, 2, 3, 2);
            cbbViTri.Name = "cbbViTri";
            cbbViTri.Size = new Size(173, 23);
            cbbViTri.TabIndex = 10;
            // 
            // tlpDuoi
            // 
            tlpDuoi.ColumnCount = 4;
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9845581F));
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9845581F));
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9122925F));
            tlpDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.11859F));
            tlpDuoi.Controls.Add(lbEmail, 0, 0);
            tlpDuoi.Controls.Add(txtEmail, 1, 0);
            tlpDuoi.Controls.Add(lbLuongTheoGio, 2, 0);
            tlpDuoi.Controls.Add(txtLuongTheoGio, 3, 0);
            tlpDuoi.Controls.Add(lbNgaySinh, 0, 1);
            tlpDuoi.Controls.Add(dTPNgaySinh, 1, 1);
            tlpDuoi.Controls.Add(lbChonNganHang, 2, 1);
            tlpDuoi.Controls.Add(cbbNganHang, 3, 1);
            tlpDuoi.Controls.Add(lbSoTaiKhoan, 2, 2);
            tlpDuoi.Controls.Add(txtSoTaiKhoan, 3, 2);
            tlpDuoi.Dock = DockStyle.Fill;
            tlpDuoi.Location = new Point(3, 196);
            tlpDuoi.Margin = new Padding(3, 2, 3, 2);
            tlpDuoi.Name = "tlpDuoi";
            tlpDuoi.RowCount = 3;
            tlpDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 29.49853F));
            tlpDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 37.16814F));
            tlpDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpDuoi.Size = new Size(642, 100);
            tlpDuoi.TabIndex = 2;
            // 
            // lbEmail
            // 
            lbEmail.Anchor = AnchorStyles.Right;
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(121, 7);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left;
            txtEmail.Location = new Point(163, 3);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 1;
            // 
            // lbLuongTheoGio
            // 
            lbLuongTheoGio.Anchor = AnchorStyles.Right;
            lbLuongTheoGio.AutoSize = true;
            lbLuongTheoGio.Location = new Point(343, 7);
            lbLuongTheoGio.Name = "lbLuongTheoGio";
            lbLuongTheoGio.Size = new Size(88, 15);
            lbLuongTheoGio.TabIndex = 2;
            lbLuongTheoGio.Text = "Lương theo giờ";
            // 
            // txtLuongTheoGio
            // 
            txtLuongTheoGio.Anchor = AnchorStyles.Left;
            txtLuongTheoGio.Location = new Point(437, 3);
            txtLuongTheoGio.Margin = new Padding(3, 2, 3, 2);
            txtLuongTheoGio.Name = "txtLuongTheoGio";
            txtLuongTheoGio.Size = new Size(173, 23);
            txtLuongTheoGio.TabIndex = 3;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.Anchor = AnchorStyles.Right;
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Location = new Point(97, 40);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(60, 15);
            lbNgaySinh.TabIndex = 4;
            lbNgaySinh.Text = "Ngày sinh";
            // 
            // dTPNgaySinh
            // 
            dTPNgaySinh.Anchor = AnchorStyles.Left;
            dTPNgaySinh.Location = new Point(163, 36);
            dTPNgaySinh.Margin = new Padding(3, 2, 3, 2);
            dTPNgaySinh.Name = "dTPNgaySinh";
            dTPNgaySinh.Size = new Size(154, 23);
            dTPNgaySinh.TabIndex = 5;
            // 
            // lbChonNganHang
            // 
            lbChonNganHang.Anchor = AnchorStyles.Right;
            lbChonNganHang.AutoSize = true;
            lbChonNganHang.Location = new Point(365, 40);
            lbChonNganHang.Name = "lbChonNganHang";
            lbChonNganHang.Size = new Size(66, 15);
            lbChonNganHang.TabIndex = 6;
            lbChonNganHang.Text = "Ngân hàng";
            // 
            // cbbNganHang
            // 
            cbbNganHang.Anchor = AnchorStyles.Left;
            cbbNganHang.FormattingEnabled = true;
            cbbNganHang.Location = new Point(437, 36);
            cbbNganHang.Margin = new Padding(3, 2, 3, 2);
            cbbNganHang.Name = "cbbNganHang";
            cbbNganHang.Size = new Size(173, 23);
            cbbNganHang.TabIndex = 7;
            // 
            // lbSoTaiKhoan
            // 
            lbSoTaiKhoan.Anchor = AnchorStyles.Right;
            lbSoTaiKhoan.AutoSize = true;
            lbSoTaiKhoan.Location = new Point(334, 68);
            lbSoTaiKhoan.Name = "lbSoTaiKhoan";
            lbSoTaiKhoan.Size = new Size(97, 30);
            lbSoTaiKhoan.TabIndex = 8;
            lbSoTaiKhoan.Text = "Số tài khoản/Mã thẻ";
            // 
            // txtSoTaiKhoan
            // 
            txtSoTaiKhoan.Anchor = AnchorStyles.Left;
            txtSoTaiKhoan.Location = new Point(437, 71);
            txtSoTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.Size = new Size(173, 23);
            txtSoTaiKhoan.TabIndex = 9;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 4;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.4091454F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.44005F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9344864F));
            tlpend.Controls.Add(btnThoat, 3, 0);
            tlpend.Controls.Add(btnLamMoi, 2, 0);
            tlpend.Controls.Add(btnThem, 1, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 300);
            tlpend.Margin = new Padding(3, 2, 3, 2);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpend.Size = new Size(642, 45);
            tlpend.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(534, 2);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 39);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.Location = new Point(429, 2);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(99, 39);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(319, 2);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 39);
            btnThem.TabIndex = 1;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // ThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 347);
            Controls.Add(tlpall);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThemNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm nhân viên";
            Load += ThemNhanVien_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpThongTin.ResumeLayout(false);
            tlpThongTin.PerformLayout();
            tlpDuoi.ResumeLayout(false);
            tlpDuoi.PerformLayout();
            tlpend.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpThongTin;
        private Label lbMaNhanVien;
        private Label lbTenNhanVien;
        private Label lbSoDienThoai;
        private Label lbDiaChi;
        private Label lbTaiKhoan;
        private Label lbMatKhau;
        private Label lbNhapLaiMatKhau;
        private Label lbViTri;
        private TextBox txtMaNhanVien;
        private TextBox txtTenNhanVien;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtNhapLaiMatKhau;
        private ComboBox cbbViTri;
        private TableLayoutPanel tlpDuoi;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label lbLuongTheoGio;
        private TextBox txtLuongTheoGio;
        private TableLayoutPanel tlpend;
        private Button btnThoat;
        private Button btnLamMoi;
        private Label lbNgaySinh;
        private DateTimePicker dTPNgaySinh;
        private Button btnThem;
        private Label lbChonNganHang;
        private ComboBox cbbNganHang;
        private Label lbSoTaiKhoan;
        private TextBox txtSoTaiKhoan;
    }
}