namespace ABC
{
    partial class SuaNhanVien
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
            lbEmail = new Label();
            lbTenTaiKhoan = new Label();
            lbMatKhau = new Label();
            lbViTri = new Label();
            lbLuongTheoGio = new Label();
            txtSoDienThoai = new TextBox();
            txtEmail = new TextBox();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            txtTenTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtLuongTheoGio = new TextBox();
            cbbViTri = new ComboBox();
            lbNgaySinh = new Label();
            dTPNgaySinh = new DateTimePicker();
            txtSTK = new TextBox();
            cbbNganHang = new ComboBox();
            lbNganHang = new Label();
            lbChonNganHang = new Label();
            tlpbutton = new TableLayoutPanel();
            btnThoat = new Button();
            btnLamMoi = new Button();
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
            tlpall.Controls.Add(tlpbutton, 0, 2);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 16.2222214F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 55.77778F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 5.55555534F));
            tlpall.Size = new Size(800, 451);
            tlpall.TabIndex = 0;
            tlpall.Paint += tlpall_Paint;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(794, 67);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 4;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9685535F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8110828F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7430735F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.760704F));
            tlpThongTin.Controls.Add(lbMaNhanVien, 0, 0);
            tlpThongTin.Controls.Add(lbTenNhanVien, 0, 1);
            tlpThongTin.Controls.Add(lbSoDienThoai, 0, 2);
            tlpThongTin.Controls.Add(lbEmail, 0, 3);
            tlpThongTin.Controls.Add(lbTenTaiKhoan, 2, 0);
            tlpThongTin.Controls.Add(lbMatKhau, 2, 1);
            tlpThongTin.Controls.Add(lbViTri, 2, 2);
            tlpThongTin.Controls.Add(lbLuongTheoGio, 2, 3);
            tlpThongTin.Controls.Add(txtSoDienThoai, 1, 2);
            tlpThongTin.Controls.Add(txtEmail, 1, 3);
            tlpThongTin.Controls.Add(txtTenNhanVien, 1, 1);
            tlpThongTin.Controls.Add(txtMaNhanVien, 1, 0);
            tlpThongTin.Controls.Add(txtTenTaiKhoan, 3, 0);
            tlpThongTin.Controls.Add(txtMatKhau, 3, 1);
            tlpThongTin.Controls.Add(txtLuongTheoGio, 3, 3);
            tlpThongTin.Controls.Add(cbbViTri, 3, 2);
            tlpThongTin.Controls.Add(lbNgaySinh, 0, 4);
            tlpThongTin.Controls.Add(dTPNgaySinh, 1, 4);
            tlpThongTin.Controls.Add(txtSTK, 3, 5);
            tlpThongTin.Controls.Add(cbbNganHang, 3, 4);
            tlpThongTin.Controls.Add(lbNganHang, 2, 5);
            tlpThongTin.Controls.Add(lbChonNganHang, 2, 4);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(3, 76);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 6;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 14.6153851F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 16.9230766F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6923084F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0873356F));
            tlpThongTin.Size = new Size(794, 246);
            tlpThongTin.TabIndex = 1;
            // 
            // lbMaNhanVien
            // 
            lbMaNhanVien.Anchor = AnchorStyles.Right;
            lbMaNhanVien.AutoSize = true;
            lbMaNhanVien.Location = new Point(97, 8);
            lbMaNhanVien.Name = "lbMaNhanVien";
            lbMaNhanVien.Size = new Size(97, 20);
            lbMaNhanVien.TabIndex = 0;
            lbMaNhanVien.Text = "Mã nhân viên";
            // 
            // lbTenNhanVien
            // 
            lbTenNhanVien.Anchor = AnchorStyles.Right;
            lbTenNhanVien.AutoSize = true;
            lbTenNhanVien.Location = new Point(95, 45);
            lbTenNhanVien.Name = "lbTenNhanVien";
            lbTenNhanVien.Size = new Size(99, 20);
            lbTenNhanVien.TabIndex = 0;
            lbTenNhanVien.Text = "Tên nhân viên";
            // 
            // lbSoDienThoai
            // 
            lbSoDienThoai.Anchor = AnchorStyles.Right;
            lbSoDienThoai.AutoSize = true;
            lbSoDienThoai.Location = new Point(97, 82);
            lbSoDienThoai.Name = "lbSoDienThoai";
            lbSoDienThoai.Size = new Size(97, 20);
            lbSoDienThoai.TabIndex = 0;
            lbSoDienThoai.Text = "Số điện thoại";
            // 
            // lbEmail
            // 
            lbEmail.Anchor = AnchorStyles.Right;
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(148, 120);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // lbTenTaiKhoan
            // 
            lbTenTaiKhoan.Anchor = AnchorStyles.Right;
            lbTenTaiKhoan.AutoSize = true;
            lbTenTaiKhoan.Location = new Point(417, 8);
            lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            lbTenTaiKhoan.Size = new Size(97, 20);
            lbTenTaiKhoan.TabIndex = 1;
            lbTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // lbMatKhau
            // 
            lbMatKhau.Anchor = AnchorStyles.Right;
            lbMatKhau.AutoSize = true;
            lbMatKhau.Location = new Point(444, 45);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(70, 20);
            lbMatKhau.TabIndex = 1;
            lbMatKhau.Text = "Mật khẩu";
            // 
            // lbViTri
            // 
            lbViTri.Anchor = AnchorStyles.Right;
            lbViTri.AutoSize = true;
            lbViTri.Location = new Point(474, 82);
            lbViTri.Name = "lbViTri";
            lbViTri.Size = new Size(40, 20);
            lbViTri.TabIndex = 1;
            lbViTri.Text = "Vị trí";
            // 
            // lbLuongTheoGio
            // 
            lbLuongTheoGio.Anchor = AnchorStyles.Right;
            lbLuongTheoGio.AutoSize = true;
            lbLuongTheoGio.Location = new Point(403, 120);
            lbLuongTheoGio.Name = "lbLuongTheoGio";
            lbLuongTheoGio.Size = new Size(111, 20);
            lbLuongTheoGio.TabIndex = 1;
            lbLuongTheoGio.Text = "Lương theo giờ";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Anchor = AnchorStyles.Left;
            txtSoDienThoai.Location = new Point(200, 78);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(188, 27);
            txtSoDienThoai.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left;
            txtEmail.Location = new Point(200, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Anchor = AnchorStyles.Left;
            txtTenNhanVien.Location = new Point(200, 42);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(188, 27);
            txtTenNhanVien.TabIndex = 2;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Anchor = AnchorStyles.Left;
            txtMaNhanVien.Location = new Point(200, 5);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(188, 27);
            txtMaNhanVien.TabIndex = 2;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Anchor = AnchorStyles.Left;
            txtTenTaiKhoan.Location = new Point(520, 5);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(197, 27);
            txtTenTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Anchor = AnchorStyles.Left;
            txtMatKhau.Location = new Point(520, 42);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(197, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtLuongTheoGio
            // 
            txtLuongTheoGio.Anchor = AnchorStyles.Left;
            txtLuongTheoGio.Location = new Point(520, 117);
            txtLuongTheoGio.Name = "txtLuongTheoGio";
            txtLuongTheoGio.Size = new Size(197, 27);
            txtLuongTheoGio.TabIndex = 3;
            // 
            // cbbViTri
            // 
            cbbViTri.Anchor = AnchorStyles.Left;
            cbbViTri.FormattingEnabled = true;
            cbbViTri.Location = new Point(520, 78);
            cbbViTri.Name = "cbbViTri";
            cbbViTri.Size = new Size(197, 28);
            cbbViTri.TabIndex = 4;
            cbbViTri.SelectedIndexChanged += cbbViTri_SelectedIndexChanged;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.Anchor = AnchorStyles.Right;
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Location = new Point(120, 162);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(74, 20);
            lbNgaySinh.TabIndex = 5;
            lbNgaySinh.Text = "Ngày sinh";
            // 
            // dTPNgaySinh
            // 
            dTPNgaySinh.Anchor = AnchorStyles.Left;
            dTPNgaySinh.Location = new Point(200, 159);
            dTPNgaySinh.Name = "dTPNgaySinh";
            dTPNgaySinh.Size = new Size(188, 27);
            dTPNgaySinh.TabIndex = 6;
            // 
            // txtSTK
            // 
            txtSTK.Anchor = AnchorStyles.Left;
            txtSTK.Location = new Point(520, 206);
            txtSTK.Name = "txtSTK";
            txtSTK.Size = new Size(197, 27);
            txtSTK.TabIndex = 8;
            // 
            // cbbNganHang
            // 
            cbbNganHang.Anchor = AnchorStyles.Left;
            cbbNganHang.FormattingEnabled = true;
            cbbNganHang.Location = new Point(520, 158);
            cbbNganHang.Name = "cbbNganHang";
            cbbNganHang.Size = new Size(197, 28);
            cbbNganHang.TabIndex = 10;
            cbbNganHang.SelectedIndexChanged += cbbNganHang_SelectedIndexChanged;
            // 
            // lbNganHang
            // 
            lbNganHang.Anchor = AnchorStyles.Right;
            lbNganHang.AutoSize = true;
            lbNganHang.Location = new Point(396, 200);
            lbNganHang.Name = "lbNganHang";
            lbNganHang.Size = new Size(118, 40);
            lbNganHang.TabIndex = 7;
            lbNganHang.Text = "Số tài khoản/Mã thẻ";
            // 
            // lbChonNganHang
            // 
            lbChonNganHang.Anchor = AnchorStyles.Right;
            lbChonNganHang.AutoSize = true;
            lbChonNganHang.Location = new Point(432, 162);
            lbChonNganHang.Name = "lbChonNganHang";
            lbChonNganHang.Size = new Size(82, 20);
            lbChonNganHang.TabIndex = 9;
            lbChonNganHang.Text = "Ngân hàng";
            // 
            // tlpbutton
            // 
            tlpbutton.ColumnCount = 4;
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.5163727F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.3576822F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpbutton.Controls.Add(btnThoat, 3, 0);
            tlpbutton.Controls.Add(btnLamMoi, 2, 0);
            tlpbutton.Controls.Add(btnLuu, 1, 0);
            tlpbutton.Dock = DockStyle.Fill;
            tlpbutton.Location = new Point(3, 328);
            tlpbutton.Name = "tlpbutton";
            tlpbutton.RowCount = 1;
            tlpbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpbutton.Size = new Size(794, 94);
            tlpbutton.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(597, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(113, 58);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.Location = new Point(485, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 58);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.Location = new Point(368, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(109, 58);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // SuaNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(tlpall);
            Name = "SuaNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa thông tin nhân viên";
            Load += SuaNhanVien_Load;
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
        private Label lbMaNhanVien;
        private Label lbTenNhanVien;
        private Label lbSoDienThoai;
        private Label lbEmail;
        private Label lbTenTaiKhoan;
        private Label lbMatKhau;
        private Label lbViTri;
        private Label lbLuongTheoGio;
        private TextBox txtSoDienThoai;
        private TextBox txtEmail;
        private TextBox txtTenNhanVien;
        private TextBox txtMaNhanVien;
        private TextBox txtTenTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtLuongTheoGio;
        private ComboBox cbbViTri;
        private Label lbNgaySinh;
        private DateTimePicker dTPNgaySinh;
        private TableLayoutPanel tlpbutton;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnLuu;
        private Label lbNganHang;
        private TextBox txtSTK;
        private Label lbChonNganHang;
        private ComboBox cbbNganHang;
    }
}