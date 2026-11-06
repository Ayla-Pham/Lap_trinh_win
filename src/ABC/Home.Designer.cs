namespace ABC
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Font = new System.Drawing.Font("Segoe UI", 9F);  // phông mặc định như .NET 8, để AutoScaleMode.Font co giãn đúng
            tlpHome = new TableLayoutPanel();
            picLogo = new PictureBox();
            lbChaoMung = new Label();
            btnDangNhapQuanLi = new Button();
            btnDangNhapNhanVien = new Button();
            tlpbutton = new TableLayoutPanel();
            btnThoat = new Button();
            tlpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpbutton.SuspendLayout();
            SuspendLayout();
            // 
            // tlpHome
            // 
            tlpHome.ColumnCount = 1;
            tlpHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHome.Controls.Add(picLogo, 0, 0);
            tlpHome.Controls.Add(lbChaoMung, 0, 1);
            tlpHome.Controls.Add(btnDangNhapQuanLi, 0, 2);
            tlpHome.Controls.Add(btnDangNhapNhanVien, 0, 3);
            tlpHome.Controls.Add(tlpbutton, 0, 4);
            tlpHome.Dock = DockStyle.Top;
            tlpHome.Location = new Point(0, 0);
            tlpHome.Name = "tlpHome";
            tlpHome.RowCount = 5;
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpHome.Size = new Size(800, 450);
            tlpHome.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(794, 84);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lbChaoMung
            // 
            lbChaoMung.AutoSize = true;
            lbChaoMung.Dock = DockStyle.Fill;
            lbChaoMung.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbChaoMung.Location = new Point(3, 90);
            lbChaoMung.Name = "lbChaoMung";
            lbChaoMung.Size = new Size(794, 90);
            lbChaoMung.TabIndex = 1;
            lbChaoMung.Text = "CHÀO MỪNG ĐẾN VỚI ABC!";
            lbChaoMung.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDangNhapQuanLi
            // 
            btnDangNhapQuanLi.Anchor = AnchorStyles.Top;
            btnDangNhapQuanLi.Location = new Point(249, 183);
            btnDangNhapQuanLi.Name = "btnDangNhapQuanLi";
            btnDangNhapQuanLi.Size = new Size(301, 84);
            btnDangNhapQuanLi.TabIndex = 2;
            btnDangNhapQuanLi.Text = "Đăng Nhập Quản Lí";
            btnDangNhapQuanLi.UseVisualStyleBackColor = true;
            btnDangNhapQuanLi.Click += btnDangNhapQuanLi_Click;
            // 
            // btnDangNhapNhanVien
            // 
            btnDangNhapNhanVien.Anchor = AnchorStyles.Top;
            btnDangNhapNhanVien.Location = new Point(249, 273);
            btnDangNhapNhanVien.Name = "btnDangNhapNhanVien";
            btnDangNhapNhanVien.Size = new Size(301, 84);
            btnDangNhapNhanVien.TabIndex = 3;
            btnDangNhapNhanVien.Text = "Đăng Nhập Nhân Viên";
            btnDangNhapNhanVien.UseVisualStyleBackColor = true;
            btnDangNhapNhanVien.Click += btnDangNhapNhanVien_Click;
            // 
            // tlpbutton
            // 
            tlpbutton.ColumnCount = 3;
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.2342567F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.2796F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.3602F));
            tlpbutton.Controls.Add(btnThoat, 1, 0);
            tlpbutton.Dock = DockStyle.Fill;
            tlpbutton.Location = new Point(3, 363);
            tlpbutton.Name = "tlpbutton";
            tlpbutton.RowCount = 1;
            tlpbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpbutton.Size = new Size(794, 84);
            tlpbutton.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThoat.Location = new Point(397, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(144, 78);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpHome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang đăng nhập";
            Load += Home_Load;
            tlpHome.ResumeLayout(false);
            tlpHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpbutton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpHome;
        private PictureBox picLogo;
        private Label lbChaoMung;
        private Button btnDangNhapQuanLi;
        private Button btnDangNhapNhanVien;
        private TableLayoutPanel tlpbutton;
        private Button btnThoat;
    }
}
