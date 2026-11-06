namespace ABC
{
    partial class NHANVIEN
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
            components = new System.ComponentModel.Container();
            tlpall = new TableLayoutPanel();
            lblWelcome = new Label();
            picLogo = new PictureBox();
            menuStrip1 = new MenuStrip();
            bÁNHÀNGToolStripMenuItem = new ToolStripMenuItem();
            sẢNPHẨMToolStripMenuItem = new ToolStripMenuItem();
            tÀIKHOẢNToolStripMenuItem = new ToolStripMenuItem();
            đỔIMẬTKHẨToolStripMenuItem = new ToolStripMenuItem();
            đỔIMẬTKHẨUToolStripMenuItem = new ToolStripMenuItem();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            btnBatDau = new Button();
            btnChamCong = new Button();
            lbThoiGian = new Label();
            lblTrangThai = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tRẢHÀNGToolStripMenuItem = new ToolStripMenuItem();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            menuStrip1.SuspendLayout();
            tlpend.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(lblWelcome, 0, 4);
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(menuStrip1, 0, 1);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Controls.Add(lblTrangThai, 0, 2);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9171267F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 8.441559F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 59.52381F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0995674F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpall.Size = new Size(800, 462);
            tlpall.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(3, 440);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(71, 20);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "Welcome";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(794, 59);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { bÁNHÀNGToolStripMenuItem, sẢNPHẨMToolStripMenuItem, tÀIKHOẢNToolStripMenuItem, tRẢHÀNGToolStripMenuItem });
            menuStrip1.Location = new Point(0, 65);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // bÁNHÀNGToolStripMenuItem
            // 
            bÁNHÀNGToolStripMenuItem.Name = "bÁNHÀNGToolStripMenuItem";
            bÁNHÀNGToolStripMenuItem.Size = new Size(99, 24);
            bÁNHÀNGToolStripMenuItem.Text = "BÁN HÀNG";
            bÁNHÀNGToolStripMenuItem.Click += bÁNHÀNGToolStripMenuItem_Click;
            // 
            // sẢNPHẨMToolStripMenuItem
            // 
            sẢNPHẨMToolStripMenuItem.Name = "sẢNPHẨMToolStripMenuItem";
            sẢNPHẨMToolStripMenuItem.Size = new Size(98, 24);
            sẢNPHẨMToolStripMenuItem.Text = "SẢN PHẨM";
            sẢNPHẨMToolStripMenuItem.Click += sẢNPHẨMToolStripMenuItem_Click;
            // 
            // tÀIKHOẢNToolStripMenuItem
            // 
            tÀIKHOẢNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đỔIMẬTKHẨToolStripMenuItem, đỔIMẬTKHẨUToolStripMenuItem });
            tÀIKHOẢNToolStripMenuItem.Name = "tÀIKHOẢNToolStripMenuItem";
            tÀIKHOẢNToolStripMenuItem.Size = new Size(100, 24);
            tÀIKHOẢNToolStripMenuItem.Text = "TÀI KHOẢN";
            // 
            // đỔIMẬTKHẨToolStripMenuItem
            // 
            đỔIMẬTKHẨToolStripMenuItem.Name = "đỔIMẬTKHẨToolStripMenuItem";
            đỔIMẬTKHẨToolStripMenuItem.Size = new Size(219, 26);
            đỔIMẬTKHẨToolStripMenuItem.Text = "XEM GIỜ LÀM VIỆC";
            đỔIMẬTKHẨToolStripMenuItem.Click += đỔIMẬTKHẨToolStripMenuItem_Click;
            // 
            // đỔIMẬTKHẨUToolStripMenuItem
            // 
            đỔIMẬTKHẨUToolStripMenuItem.Name = "đỔIMẬTKHẨUToolStripMenuItem";
            đỔIMẬTKHẨUToolStripMenuItem.Size = new Size(219, 26);
            đỔIMẬTKHẨUToolStripMenuItem.Text = "ĐỔI MẬT KHẨU";
            đỔIMẬTKHẨUToolStripMenuItem.Click += đỔIMẬTKHẨUToolStripMenuItem_Click;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 4;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.Controls.Add(btnThoat, 3, 0);
            tlpend.Controls.Add(btnBatDau, 2, 0);
            tlpend.Controls.Add(btnChamCong, 1, 0);
            tlpend.Controls.Add(lbThoiGian, 0, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 368);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpend.Size = new Size(794, 69);
            tlpend.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(597, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(194, 63);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(399, 3);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(192, 63);
            btnBatDau.TabIndex = 1;
            btnBatDau.Text = "BẮT ĐẦU LÀM";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // btnChamCong
            // 
            btnChamCong.Location = new Point(201, 3);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(192, 63);
            btnChamCong.TabIndex = 0;
            btnChamCong.Text = "CHẤM CÔNG";
            btnChamCong.UseVisualStyleBackColor = true;
            btnChamCong.Click += btnChamCong_Click;
            // 
            // lbThoiGian
            // 
            lbThoiGian.AutoSize = true;
            lbThoiGian.Dock = DockStyle.Fill;
            lbThoiGian.Location = new Point(3, 0);
            lbThoiGian.Name = "lbThoiGian";
            lbThoiGian.Size = new Size(192, 69);
            lbThoiGian.TabIndex = 2;
            lbThoiGian.Text = "Hiển thị giờ ở đây";
            lbThoiGian.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(3, 102);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(75, 20);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Trạng thái";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // tRẢHÀNGToolStripMenuItem
            // 
            tRẢHÀNGToolStripMenuItem.Name = "tRẢHÀNGToolStripMenuItem";
            tRẢHÀNGToolStripMenuItem.Size = new Size(96, 24);
            tRẢHÀNGToolStripMenuItem.Text = "TRẢ HÀNG";
            tRẢHÀNGToolStripMenuItem.Click += tRẢHÀNGToolStripMenuItem_Click;
            // 
            // NHANVIEN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(tlpall);
            MainMenuStrip = menuStrip1;
            Name = "NHANVIEN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += NHANVIEN_Load;
            tlpall.ResumeLayout(false);
            tlpall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tlpend.ResumeLayout(false);
            tlpend.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bÁNHÀNGToolStripMenuItem;
        private ToolStripMenuItem sẢNPHẨMToolStripMenuItem;
        private ToolStripMenuItem tÀIKHOẢNToolStripMenuItem;
        private TableLayoutPanel tlpend;
        private Button btnThoat;
        private Button btnChamCong;
        private ToolStripMenuItem đỔIMẬTKHẨToolStripMenuItem;
        private ToolStripMenuItem đỔIMẬTKHẨUToolStripMenuItem;
        private Button btnBatDau;
        private Label lbThoiGian;
        private System.Windows.Forms.Timer timer1;
        private Label lblTrangThai;
        private Label lblWelcome;
        private ToolStripMenuItem tRẢHÀNGToolStripMenuItem;
    }
}