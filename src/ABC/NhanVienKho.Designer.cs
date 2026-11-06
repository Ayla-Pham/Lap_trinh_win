namespace ABC
{
    partial class NhanVienKho
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
            picLogo = new PictureBox();
            tlpthan = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            sẢNPHẨMToolStripMenuItem = new ToolStripMenuItem();
            kHOToolStripMenuItem = new ToolStripMenuItem();
            tÀIKHOẢNToolStripMenuItem = new ToolStripMenuItem();
            xEMGIỜLÀMToolStripMenuItem = new ToolStripMenuItem();
            đỔIMẬTKHẨUToolStripMenuItem = new ToolStripMenuItem();
            tlpbutton = new TableLayoutPanel();
            btnThoat = new Button();
            btnBatDau = new Button();
            btnChamCong = new Button();
            lbTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTrangThai = new Label();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpthan.SuspendLayout();
            menuStrip1.SuspendLayout();
            tlpbutton.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpthan, 0, 1);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Margin = new Padding(3, 2, 3, 2);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 2;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 18.1981983F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 81.8018F));
            tlpall.Size = new Size(970, 416);
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
            picLogo.Size = new Size(964, 71);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // tlpthan
            // 
            tlpthan.ColumnCount = 1;
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpthan.Controls.Add(menuStrip1, 0, 0);
            tlpthan.Controls.Add(tlpbutton, 0, 1);
            tlpthan.Dock = DockStyle.Fill;
            tlpthan.Location = new Point(3, 77);
            tlpthan.Margin = new Padding(3, 2, 3, 2);
            tlpthan.Name = "tlpthan";
            tlpthan.RowCount = 3;
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 81.02679F));
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9732151F));
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpthan.Size = new Size(964, 337);
            tlpthan.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sẢNPHẨMToolStripMenuItem, kHOToolStripMenuItem, tÀIKHOẢNToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(259, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sẢNPHẨMToolStripMenuItem
            // 
            sẢNPHẨMToolStripMenuItem.Name = "sẢNPHẨMToolStripMenuItem";
            sẢNPHẨMToolStripMenuItem.Size = new Size(98, 24);
            sẢNPHẨMToolStripMenuItem.Text = "SẢN PHẨM";
            sẢNPHẨMToolStripMenuItem.Click += sẢNPHẨMToolStripMenuItem_Click;
            // 
            // kHOToolStripMenuItem
            // 
            kHOToolStripMenuItem.Name = "kHOToolStripMenuItem";
            kHOToolStripMenuItem.Size = new Size(54, 24);
            kHOToolStripMenuItem.Text = "KHO";
            kHOToolStripMenuItem.Click += kHOToolStripMenuItem_Click;
            // 
            // tÀIKHOẢNToolStripMenuItem
            // 
            tÀIKHOẢNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xEMGIỜLÀMToolStripMenuItem, đỔIMẬTKHẨUToolStripMenuItem });
            tÀIKHOẢNToolStripMenuItem.Name = "tÀIKHOẢNToolStripMenuItem";
            tÀIKHOẢNToolStripMenuItem.Size = new Size(100, 24);
            tÀIKHOẢNToolStripMenuItem.Text = "TÀI KHOẢN";
            tÀIKHOẢNToolStripMenuItem.Click += tÀIKHOẢNToolStripMenuItem_Click;
            // 
            // xEMGIỜLÀMToolStripMenuItem
            // 
            xEMGIỜLÀMToolStripMenuItem.Name = "xEMGIỜLÀMToolStripMenuItem";
            xEMGIỜLÀMToolStripMenuItem.Size = new Size(197, 26);
            xEMGIỜLÀMToolStripMenuItem.Text = "XEM GIỜ LÀM";
            xEMGIỜLÀMToolStripMenuItem.Click += xEMGIỜLÀMToolStripMenuItem_Click;
            // 
            // đỔIMẬTKHẨUToolStripMenuItem
            // 
            đỔIMẬTKHẨUToolStripMenuItem.Name = "đỔIMẬTKHẨUToolStripMenuItem";
            đỔIMẬTKHẨUToolStripMenuItem.Size = new Size(197, 26);
            đỔIMẬTKHẨUToolStripMenuItem.Text = "ĐỔI MẬT KHẨU";
            đỔIMẬTKHẨUToolStripMenuItem.Click += đỔIMẬTKHẨUToolStripMenuItem_Click;
            // 
            // tlpbutton
            // 
            tlpbutton.ColumnCount = 5;
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tlpbutton.Controls.Add(btnThoat, 4, 0);
            tlpbutton.Controls.Add(btnBatDau, 3, 0);
            tlpbutton.Controls.Add(btnChamCong, 2, 0);
            tlpbutton.Controls.Add(lbTime, 0, 0);
            tlpbutton.Controls.Add(lblTrangThai, 1, 0);
            tlpbutton.Dock = DockStyle.Fill;
            tlpbutton.Location = new Point(3, 258);
            tlpbutton.Margin = new Padding(3, 2, 3, 2);
            tlpbutton.Name = "tlpbutton";
            tlpbutton.RowCount = 1;
            tlpbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpbutton.Size = new Size(958, 56);
            tlpbutton.TabIndex = 1;
            tlpbutton.Paint += tlpbutton_Paint;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(827, 2);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 51);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(690, 2);
            btnBatDau.Margin = new Padding(3, 2, 3, 2);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(131, 51);
            btnBatDau.TabIndex = 0;
            btnBatDau.Text = "Bắt đầu làm";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // btnChamCong
            // 
            btnChamCong.Location = new Point(539, 2);
            btnChamCong.Margin = new Padding(3, 2, 3, 2);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(145, 51);
            btnChamCong.TabIndex = 0;
            btnChamCong.Text = "Chấm công";
            btnChamCong.UseVisualStyleBackColor = true;
            btnChamCong.Click += btnChamCong_Click;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Dock = DockStyle.Fill;
            lbTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTime.Location = new Point(3, 0);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(262, 56);
            lbTime.TabIndex = 1;
            lbTime.Text = "00:00:00";
            lbTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Dock = DockStyle.Fill;
            lblTrangThai.Location = new Point(271, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(262, 56);
            lblTrangThai.TabIndex = 2;
            lblTrangThai.Text = "Trạng thái";
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NhanVienKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 416);
            Controls.Add(tlpall);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "NhanVienKho";
            Text = "Nhân viên kho";
            Load += NhanVienKho_Load_1;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpthan.ResumeLayout(false);
            tlpthan.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tlpbutton.ResumeLayout(false);
            tlpbutton.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sẢNPHẨMToolStripMenuItem;
        private ToolStripMenuItem kHOToolStripMenuItem;
        private ToolStripMenuItem tÀIKHOẢNToolStripMenuItem;
        private TableLayoutPanel tlpthan;
        private TableLayoutPanel tlpbutton;
        private Button btnThoat;
        private Button btnBatDau;
        private PictureBox picLogo;
        private Button btnChamCong;
        private Label lbTime;
        private ToolStripMenuItem xEMGIỜLÀMToolStripMenuItem;
        private ToolStripMenuItem đỔIMẬTKHẨUToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private Label lblTrangThai;
    }
}