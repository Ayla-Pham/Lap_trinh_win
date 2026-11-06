namespace ABC
{
    partial class XemSanPhamNhanVien
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
            tlpTimKiem = new TableLayoutPanel();
            lbTimKiem = new Label();
            txtTimKiem = new TextBox();
            dgvSanPham = new DataGridView();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            tlpend.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpTimKiem, 0, 1);
            tlpall.Controls.Add(dgvSanPham, 0, 2);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 18.2222214F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 9.333333F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 58.3505173F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2268038F));
            tlpall.Size = new Size(800, 485);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(794, 82);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpTimKiem
            // 
            tlpTimKiem.ColumnCount = 2;
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.352644F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.6473541F));
            tlpTimKiem.Controls.Add(lbTimKiem, 0, 0);
            tlpTimKiem.Controls.Add(txtTimKiem, 1, 0);
            tlpTimKiem.Dock = DockStyle.Fill;
            tlpTimKiem.Location = new Point(3, 91);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowCount = 1;
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTimKiem.Size = new Size(794, 39);
            tlpTimKiem.TabIndex = 1;
            tlpTimKiem.Paint += tlpTimKiem_Paint;
            // 
            // lbTimKiem
            // 
            lbTimKiem.Anchor = AnchorStyles.Right;
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(168, 9);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(70, 20);
            lbTimKiem.TabIndex = 0;
            lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Location = new Point(244, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(358, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvSanPham
            // 
            dgvSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(3, 136);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(794, 276);
            dgvSanPham.TabIndex = 2;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 4;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.Controls.Add(btnThoat, 3, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 418);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpend.Size = new Size(794, 64);
            tlpend.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(597, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(127, 58);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // XemSanPhamNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(tlpall);
            Name = "XemSanPhamNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xem sản phẩm";
            Load += XemSanPhamNhanVien_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            tlpend.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpTimKiem;
        private Label lbTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvSanPham;
        private TableLayoutPanel tlpend;
        private Button btnThoat;
    }
}