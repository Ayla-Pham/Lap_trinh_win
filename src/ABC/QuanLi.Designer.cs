namespace ABC
{
    partial class QuanLi
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
            menuQuanLi = new MenuStrip();
            hỆTHỐNGToolStripMenuItem = new ToolStripMenuItem();
            dANHSÁCHNHÂNVIÊNToolStripMenuItem = new ToolStripMenuItem();
            sẢNPHẨMToolStripMenuItem = new ToolStripMenuItem();
            dANHSÁCHSẢNPHẨMToolStripMenuItem = new ToolStripMenuItem();
            mÃGIẢMGIÁToolStripMenuItem = new ToolStripMenuItem();
            dANHSÁCHMÃGIẢMGIÁToolStripMenuItem = new ToolStripMenuItem();
            kHÁCHHÀNGToolStripMenuItem = new ToolStripMenuItem();
            quảnLíKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            bÁNHÀNGToolStripMenuItem = new ToolStripMenuItem();
            tHỐNGKÊToolStripMenuItem = new ToolStripMenuItem();
            báoCáoDoanhThuToolStripMenuItem = new ToolStripMenuItem();
            lịchSửHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            lịchSửNhậpKhoToolStripMenuItem = new ToolStripMenuItem();
            lịchSửChấmCôngToolStripMenuItem = new ToolStripMenuItem();
            lịchSửTrảHàngToolStripMenuItem = new ToolStripMenuItem();
            kHOToolStripMenuItem = new ToolStripMenuItem();
            xEMKHOToolStripMenuItem = new ToolStripMenuItem();
            tÀIKHOẢNToolStripMenuItem = new ToolStripMenuItem();
            đỔIMẬTKHẨUToolStripMenuItem = new ToolStripMenuItem();
            đĂNGXUẤTToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            chiTiếtTrảHàngToolStripMenuItem = new ToolStripMenuItem();
            tlpthan = new TableLayoutPanel();
            picLogo = new PictureBox();
            bThoiGian = new Label();
            tlpbutton = new TableLayoutPanel();
            btnThoat = new Button();
            lblWelcome = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lịchSửXuấtKhoToolStripMenuItem = new ToolStripMenuItem();
            menuQuanLi.SuspendLayout();
            tlpthan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpbutton.SuspendLayout();
            SuspendLayout();
            // 
            // menuQuanLi
            // 
            menuQuanLi.AutoSize = false;
            menuQuanLi.ImageScalingSize = new Size(20, 20);
            menuQuanLi.Items.AddRange(new ToolStripItem[] { hỆTHỐNGToolStripMenuItem, sẢNPHẨMToolStripMenuItem, mÃGIẢMGIÁToolStripMenuItem, kHÁCHHÀNGToolStripMenuItem, bÁNHÀNGToolStripMenuItem, tHỐNGKÊToolStripMenuItem, kHOToolStripMenuItem, tÀIKHOẢNToolStripMenuItem, toolStripMenuItem1 });
            menuQuanLi.Location = new Point(0, 0);
            menuQuanLi.Name = "menuQuanLi";
            menuQuanLi.Padding = new Padding(5, 2, 0, 2);
            menuQuanLi.Size = new Size(725, 21);
            menuQuanLi.TabIndex = 0;
            menuQuanLi.Text = "menuStrip1";
            // 
            // hỆTHỐNGToolStripMenuItem
            // 
            hỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dANHSÁCHNHÂNVIÊNToolStripMenuItem });
            hỆTHỐNGToolStripMenuItem.Name = "hỆTHỐNGToolStripMenuItem";
            hỆTHỐNGToolStripMenuItem.Size = new Size(82, 17);
            hỆTHỐNGToolStripMenuItem.Text = "NHÂN VIÊN";
            // 
            // dANHSÁCHNHÂNVIÊNToolStripMenuItem
            // 
            dANHSÁCHNHÂNVIÊNToolStripMenuItem.Name = "dANHSÁCHNHÂNVIÊNToolStripMenuItem";
            dANHSÁCHNHÂNVIÊNToolStripMenuItem.Size = new Size(208, 22);
            dANHSÁCHNHÂNVIÊNToolStripMenuItem.Text = "DANH SÁCH NHÂN VIÊN";
            dANHSÁCHNHÂNVIÊNToolStripMenuItem.Click += dANHSÁCHNHÂNVIÊNToolStripMenuItem_Click;
            // 
            // sẢNPHẨMToolStripMenuItem
            // 
            sẢNPHẨMToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dANHSÁCHSẢNPHẨMToolStripMenuItem });
            sẢNPHẨMToolStripMenuItem.Name = "sẢNPHẨMToolStripMenuItem";
            sẢNPHẨMToolStripMenuItem.Size = new Size(80, 17);
            sẢNPHẨMToolStripMenuItem.Text = "SẢN PHẨM";
            // 
            // dANHSÁCHSẢNPHẨMToolStripMenuItem
            // 
            dANHSÁCHSẢNPHẨMToolStripMenuItem.Name = "dANHSÁCHSẢNPHẨMToolStripMenuItem";
            dANHSÁCHSẢNPHẨMToolStripMenuItem.Size = new Size(184, 22);
            dANHSÁCHSẢNPHẨMToolStripMenuItem.Text = "QUẢN LÍ SẢN PHẨM";
            dANHSÁCHSẢNPHẨMToolStripMenuItem.Click += dANHSÁCHSẢNPHẨMToolStripMenuItem_Click;
            // 
            // mÃGIẢMGIÁToolStripMenuItem
            // 
            mÃGIẢMGIÁToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dANHSÁCHMÃGIẢMGIÁToolStripMenuItem });
            mÃGIẢMGIÁToolStripMenuItem.Name = "mÃGIẢMGIÁToolStripMenuItem";
            mÃGIẢMGIÁToolStripMenuItem.Size = new Size(93, 17);
            mÃGIẢMGIÁToolStripMenuItem.Text = "MÃ GIẢM GIÁ";
            mÃGIẢMGIÁToolStripMenuItem.Click += mÃGIẢMGIÁToolStripMenuItem_Click;
            // 
            // dANHSÁCHMÃGIẢMGIÁToolStripMenuItem
            // 
            dANHSÁCHMÃGIẢMGIÁToolStripMenuItem.Name = "dANHSÁCHMÃGIẢMGIÁToolStripMenuItem";
            dANHSÁCHMÃGIẢMGIÁToolStripMenuItem.Size = new Size(197, 22);
            dANHSÁCHMÃGIẢMGIÁToolStripMenuItem.Text = "QUẢN LÍ MÃ GIẢM GIÁ";
            dANHSÁCHMÃGIẢMGIÁToolStripMenuItem.Click += dANHSÁCHMÃGIẢMGIÁToolStripMenuItem_Click;
            // 
            // kHÁCHHÀNGToolStripMenuItem
            // 
            kHÁCHHÀNGToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLíKháchHàngToolStripMenuItem });
            kHÁCHHÀNGToolStripMenuItem.Name = "kHÁCHHÀNGToolStripMenuItem";
            kHÁCHHÀNGToolStripMenuItem.Size = new Size(97, 17);
            kHÁCHHÀNGToolStripMenuItem.Text = "KHÁCH HÀNG";
            // 
            // quảnLíKháchHàngToolStripMenuItem
            // 
            quảnLíKháchHàngToolStripMenuItem.Name = "quảnLíKháchHàngToolStripMenuItem";
            quảnLíKháchHàngToolStripMenuItem.Size = new Size(177, 22);
            quảnLíKháchHàngToolStripMenuItem.Text = "Quản lí khách hàng";
            quảnLíKháchHàngToolStripMenuItem.Click += quảnLíKháchHàngToolStripMenuItem_Click;
            // 
            // bÁNHÀNGToolStripMenuItem
            // 
            bÁNHÀNGToolStripMenuItem.Name = "bÁNHÀNGToolStripMenuItem";
            bÁNHÀNGToolStripMenuItem.Size = new Size(80, 17);
            bÁNHÀNGToolStripMenuItem.Text = "BÁN HÀNG";
            bÁNHÀNGToolStripMenuItem.Click += bÁNHÀNGToolStripMenuItem_Click;
            // 
            // tHỐNGKÊToolStripMenuItem
            // 
            tHỐNGKÊToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { báoCáoDoanhThuToolStripMenuItem, lịchSửHóaĐơnToolStripMenuItem, lịchSửNhậpKhoToolStripMenuItem, lịchSửChấmCôngToolStripMenuItem, lịchSửTrảHàngToolStripMenuItem, lịchSửXuấtKhoToolStripMenuItem });
            tHỐNGKÊToolStripMenuItem.Name = "tHỐNGKÊToolStripMenuItem";
            tHỐNGKÊToolStripMenuItem.Size = new Size(76, 17);
            tHỐNGKÊToolStripMenuItem.Text = "THỐNG KÊ";
            // 
            // báoCáoDoanhThuToolStripMenuItem
            // 
            báoCáoDoanhThuToolStripMenuItem.Name = "báoCáoDoanhThuToolStripMenuItem";
            báoCáoDoanhThuToolStripMenuItem.Size = new Size(180, 22);
            báoCáoDoanhThuToolStripMenuItem.Text = "Báo cáo doanh thu";
            báoCáoDoanhThuToolStripMenuItem.Click += báoCáoDoanhThuToolStripMenuItem_Click;
            // 
            // lịchSửHóaĐơnToolStripMenuItem
            // 
            lịchSửHóaĐơnToolStripMenuItem.Name = "lịchSửHóaĐơnToolStripMenuItem";
            lịchSửHóaĐơnToolStripMenuItem.Size = new Size(180, 22);
            lịchSửHóaĐơnToolStripMenuItem.Text = "Lịch sử hóa đơn";
            lịchSửHóaĐơnToolStripMenuItem.Click += lịchSửHóaĐơnToolStripMenuItem_Click;
            // 
            // lịchSửNhậpKhoToolStripMenuItem
            // 
            lịchSửNhậpKhoToolStripMenuItem.Name = "lịchSửNhậpKhoToolStripMenuItem";
            lịchSửNhậpKhoToolStripMenuItem.Size = new Size(180, 22);
            lịchSửNhậpKhoToolStripMenuItem.Text = "Lịch sử nhập kho";
            lịchSửNhậpKhoToolStripMenuItem.Click += lịchSửNhậpKhoToolStripMenuItem_Click;
            // 
            // lịchSửChấmCôngToolStripMenuItem
            // 
            lịchSửChấmCôngToolStripMenuItem.Name = "lịchSửChấmCôngToolStripMenuItem";
            lịchSửChấmCôngToolStripMenuItem.Size = new Size(180, 22);
            lịchSửChấmCôngToolStripMenuItem.Text = "Lịch sử chấm công";
            lịchSửChấmCôngToolStripMenuItem.Click += lịchSửChấmCôngToolStripMenuItem_Click;
            // 
            // lịchSửTrảHàngToolStripMenuItem
            // 
            lịchSửTrảHàngToolStripMenuItem.Name = "lịchSửTrảHàngToolStripMenuItem";
            lịchSửTrảHàngToolStripMenuItem.Size = new Size(180, 22);
            lịchSửTrảHàngToolStripMenuItem.Text = "Lịch sử trả hàng";
            lịchSửTrảHàngToolStripMenuItem.Click += lịchSửTrảHàngToolStripMenuItem_Click;
            // 
            // kHOToolStripMenuItem
            // 
            kHOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xEMKHOToolStripMenuItem });
            kHOToolStripMenuItem.Name = "kHOToolStripMenuItem";
            kHOToolStripMenuItem.Size = new Size(44, 17);
            kHOToolStripMenuItem.Text = "KHO";
            // 
            // xEMKHOToolStripMenuItem
            // 
            xEMKHOToolStripMenuItem.Name = "xEMKHOToolStripMenuItem";
            xEMKHOToolStripMenuItem.Size = new Size(148, 22);
            xEMKHOToolStripMenuItem.Text = "QUẢN LÍ KHO";
            xEMKHOToolStripMenuItem.Click += xEMKHOToolStripMenuItem_Click;
            // 
            // tÀIKHOẢNToolStripMenuItem
            // 
            tÀIKHOẢNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đỔIMẬTKHẨUToolStripMenuItem, đĂNGXUẤTToolStripMenuItem });
            tÀIKHOẢNToolStripMenuItem.Name = "tÀIKHOẢNToolStripMenuItem";
            tÀIKHOẢNToolStripMenuItem.Size = new Size(80, 17);
            tÀIKHOẢNToolStripMenuItem.Text = "TÀI KHOẢN";
            // 
            // đỔIMẬTKHẨUToolStripMenuItem
            // 
            đỔIMẬTKHẨUToolStripMenuItem.Name = "đỔIMẬTKHẨUToolStripMenuItem";
            đỔIMẬTKHẨUToolStripMenuItem.Size = new Size(157, 22);
            đỔIMẬTKHẨUToolStripMenuItem.Text = "ĐỔI MẬT KHẨU";
            đỔIMẬTKHẨUToolStripMenuItem.Click += đỔIMẬTKHẨUToolStripMenuItem_Click;
            // 
            // đĂNGXUẤTToolStripMenuItem
            // 
            đĂNGXUẤTToolStripMenuItem.Name = "đĂNGXUẤTToolStripMenuItem";
            đĂNGXUẤTToolStripMenuItem.Size = new Size(157, 22);
            đĂNGXUẤTToolStripMenuItem.Text = "ĐĂNG XUẤT";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { chiTiếtTrảHàngToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(77, 17);
            toolStripMenuItem1.Text = "TRẢ HÀNG";
            // 
            // chiTiếtTrảHàngToolStripMenuItem
            // 
            chiTiếtTrảHàngToolStripMenuItem.Name = "chiTiếtTrảHàngToolStripMenuItem";
            chiTiếtTrảHàngToolStripMenuItem.Size = new Size(183, 22);
            chiTiếtTrảHàngToolStripMenuItem.Text = "CHI TIẾT MẶT HÀNG";
            chiTiếtTrảHàngToolStripMenuItem.Click += chiTiếtTrảHàngToolStripMenuItem_Click;
            // 
            // tlpthan
            // 
            tlpthan.ColumnCount = 3;
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpthan.Controls.Add(picLogo, 1, 1);
            tlpthan.Controls.Add(bThoiGian, 0, 2);
            tlpthan.Controls.Add(tlpbutton, 2, 2);
            tlpthan.Controls.Add(lblWelcome, 1, 0);
            tlpthan.Dock = DockStyle.Fill;
            tlpthan.Location = new Point(0, 21);
            tlpthan.Margin = new Padding(3, 2, 3, 2);
            tlpthan.Name = "tlpthan";
            tlpthan.RowCount = 3;
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpthan.Size = new Size(725, 317);
            tlpthan.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(244, 107);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(235, 101);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // bThoiGian
            // 
            bThoiGian.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bThoiGian.AutoSize = true;
            bThoiGian.Location = new Point(3, 302);
            bThoiGian.Name = "bThoiGian";
            bThoiGian.Size = new Size(145, 15);
            bThoiGian.TabIndex = 1;
            bThoiGian.Text = "Thời gian sẽ hiển thị ở đây";
            bThoiGian.TextAlign = ContentAlignment.MiddleCenter;
            bThoiGian.Click += bThoiGian_Click;
            // 
            // tlpbutton
            // 
            tlpbutton.ColumnCount = 2;
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpbutton.Controls.Add(btnThoat, 1, 1);
            tlpbutton.Dock = DockStyle.Fill;
            tlpbutton.Location = new Point(485, 212);
            tlpbutton.Margin = new Padding(3, 2, 3, 2);
            tlpbutton.Name = "tlpbutton";
            tlpbutton.RowCount = 2;
            tlpbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpbutton.Size = new Size(237, 103);
            tlpbutton.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(121, 53);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(113, 46);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(244, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(235, 105);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Wcome";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lịchSửXuấtKhoToolStripMenuItem
            // 
            lịchSửXuấtKhoToolStripMenuItem.Name = "lịchSửXuấtKhoToolStripMenuItem";
            lịchSửXuấtKhoToolStripMenuItem.Size = new Size(180, 22);
            lịchSửXuấtKhoToolStripMenuItem.Text = "Lịch sử xuất kho";
            lịchSửXuấtKhoToolStripMenuItem.Click += lịchSửXuấtKhoToolStripMenuItem_Click;
            // 
            // QuanLi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 338);
            Controls.Add(tlpthan);
            Controls.Add(menuQuanLi);
            MainMenuStrip = menuQuanLi;
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuanLi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí";
            Load += QuanLi_Load;
            menuQuanLi.ResumeLayout(false);
            menuQuanLi.PerformLayout();
            tlpthan.ResumeLayout(false);
            tlpthan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpbutton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuQuanLi;
        private ToolStripMenuItem hỆTHỐNGToolStripMenuItem;
        private ToolStripMenuItem sẢNPHẨMToolStripMenuItem;
        private ToolStripMenuItem tÀIKHOẢNToolStripMenuItem;
        private ToolStripMenuItem dANHSÁCHNHÂNVIÊNToolStripMenuItem;
        private ToolStripMenuItem dANHSÁCHSẢNPHẨMToolStripMenuItem;
        private ToolStripMenuItem đỔIMẬTKHẨUToolStripMenuItem;
        private ToolStripMenuItem đĂNGXUẤTToolStripMenuItem;
        private ToolStripMenuItem mÃGIẢMGIÁToolStripMenuItem;
        private ToolStripMenuItem dANHSÁCHMÃGIẢMGIÁToolStripMenuItem;
        private ToolStripMenuItem kHOToolStripMenuItem;
        private ToolStripMenuItem xEMKHOToolStripMenuItem;
        private ToolStripMenuItem bÁNHÀNGToolStripMenuItem;
        private ToolStripMenuItem tHỐNGKÊToolStripMenuItem;
        private ToolStripMenuItem kHÁCHHÀNGToolStripMenuItem;
        private ToolStripMenuItem báoCáoDoanhThuToolStripMenuItem;
        private ToolStripMenuItem lịchSửHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem quảnLíKháchHàngToolStripMenuItem;
        private TableLayoutPanel tlpthan;
        private PictureBox picLogo;
        private Label bThoiGian;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tlpbutton;
        private Button btnThoat;
        private ToolStripMenuItem lịchSửNhậpKhoToolStripMenuItem;
        private Label lblWelcome;
        private ToolStripMenuItem lịchSửChấmCôngToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem chiTiếtTrảHàngToolStripMenuItem;
        private ToolStripMenuItem lịchSửTrảHàngToolStripMenuItem;
        private ToolStripMenuItem lịchSửXuấtKhoToolStripMenuItem;
    }
}