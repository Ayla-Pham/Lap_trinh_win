namespace ABC
{
    partial class ChiTietHoaDon
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
            dgvChiTiet = new DataGridView();
            btnThoat = new Button();
            dgvThongTinChung = new DataGridView();
            btnXuatPDF = new Button();
            tlpall = new TableLayoutPanel();
            picLogo = new PictureBox();
            tlpdgv = new TableLayoutPanel();
            tlpbutton = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinChung).BeginInit();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpdgv.SuspendLayout();
            tlpbutton.SuspendLayout();
            SuspendLayout();
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.Location = new Point(3, 4);
            dgvChiTiet.Margin = new Padding(3, 4, 3, 4);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.Size = new Size(586, 419);
            dgvChiTiet.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThoat.Location = new Point(1044, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 62);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvThongTinChung
            // 
            dgvThongTinChung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTinChung.Dock = DockStyle.Fill;
            dgvThongTinChung.Location = new Point(595, 4);
            dgvThongTinChung.Margin = new Padding(3, 4, 3, 4);
            dgvThongTinChung.Name = "dgvThongTinChung";
            dgvThongTinChung.RowHeadersWidth = 51;
            dgvThongTinChung.Size = new Size(586, 419);
            dgvThongTinChung.TabIndex = 2;
            // 
            // btnXuatPDF
            // 
            btnXuatPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXuatPDF.Location = new Point(881, 3);
            btnXuatPDF.Name = "btnXuatPDF";
            btnXuatPDF.Size = new Size(157, 62);
            btnXuatPDF.TabIndex = 3;
            btnXuatPDF.Text = "XUẤT PDF";
            btnXuatPDF.UseVisualStyleBackColor = true;
            btnXuatPDF.Click += btnXuatPDF_Click;
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpdgv, 0, 1);
            tlpall.Controls.Add(tlpbutton, 0, 2);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 3;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6806087F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 82.31939F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tlpall.Size = new Size(1190, 600);
            tlpall.TabIndex = 4;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(1184, 87);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpdgv
            // 
            tlpdgv.ColumnCount = 2;
            tlpdgv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpdgv.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpdgv.Controls.Add(dgvThongTinChung, 1, 0);
            tlpdgv.Controls.Add(dgvChiTiet, 0, 0);
            tlpdgv.Dock = DockStyle.Fill;
            tlpdgv.Location = new Point(3, 96);
            tlpdgv.Name = "tlpdgv";
            tlpdgv.RowCount = 1;
            tlpdgv.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpdgv.Size = new Size(1184, 427);
            tlpdgv.TabIndex = 1;
            // 
            // tlpbutton
            // 
            tlpbutton.ColumnCount = 2;
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.9222946F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0777025F));
            tlpbutton.Controls.Add(btnThoat, 1, 0);
            tlpbutton.Controls.Add(btnXuatPDF, 0, 0);
            tlpbutton.Dock = DockStyle.Fill;
            tlpbutton.Location = new Point(3, 529);
            tlpbutton.Name = "tlpbutton";
            tlpbutton.RowCount = 1;
            tlpbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpbutton.Size = new Size(1184, 68);
            tlpbutton.TabIndex = 2;
            // 
            // ChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 600);
            Controls.Add(tlpall);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChiTietHoaDon";
            Text = "ChiTietHoaDon";
            Load += ChiTietHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongTinChung).EndInit();
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpdgv.ResumeLayout(false);
            tlpbutton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvChiTiet;
        private Button btnThoat;
        private DataGridView dgvThongTinChung;
        private Button btnXuatPDF;
        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpdgv;
        private TableLayoutPanel tlpbutton;
    }
}