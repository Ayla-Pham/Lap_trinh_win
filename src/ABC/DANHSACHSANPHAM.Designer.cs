namespace ABC
{
    partial class DANHSACHSANPHAM
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
            tlpDSSP = new TableLayoutPanel();
            picLogo = new PictureBox();
            pndgv = new Panel();
            dgvDanhSachSanPham = new DataGridView();
            pnButton = new Panel();
            btnXuatPDF = new Button();
            btnQuayLai = new Button();
            btnThoat = new Button();
            tlpTimKiem = new TableLayoutPanel();
            btnXoa = new Button();
            btnAnHien = new Button();
            btnTim = new Button();
            txtTimKiem = new TextBox();
            cbbLoaiTimKiem = new ComboBox();
            btnThemSanPham = new Button();
            btnSua = new Button();
            picTimKiem = new PictureBox();
            tlpDSSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pndgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).BeginInit();
            pnButton.SuspendLayout();
            tlpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            SuspendLayout();
            // 
            // tlpDSSP
            // 
            tlpDSSP.ColumnCount = 1;
            tlpDSSP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDSSP.Controls.Add(picLogo, 0, 0);
            tlpDSSP.Controls.Add(pndgv, 0, 2);
            tlpDSSP.Controls.Add(pnButton, 0, 3);
            tlpDSSP.Controls.Add(tlpTimKiem, 0, 1);
            tlpDSSP.Dock = DockStyle.Fill;
            tlpDSSP.Location = new Point(0, 0);
            tlpDSSP.Name = "tlpDSSP";
            tlpDSSP.RowCount = 4;
            tlpDSSP.RowStyles.Add(new RowStyle(SizeType.Percent, 19.1413231F));
            tlpDSSP.RowStyles.Add(new RowStyle(SizeType.Percent, 20.035778F));
            tlpDSSP.RowStyles.Add(new RowStyle(SizeType.Percent, 49.7316628F));
            tlpDSSP.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9974051F));
            tlpDSSP.Size = new Size(804, 602);
            tlpDSSP.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Top;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(798, 101);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pndgv
            // 
            pndgv.Controls.Add(dgvDanhSachSanPham);
            pndgv.Dock = DockStyle.Fill;
            pndgv.Location = new Point(3, 238);
            pndgv.Name = "pndgv";
            pndgv.Size = new Size(798, 293);
            pndgv.TabIndex = 4;
            // 
            // dgvDanhSachSanPham
            // 
            dgvDanhSachSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSanPham.Location = new Point(0, 3);
            dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            dgvDanhSachSanPham.RowHeadersWidth = 51;
            dgvDanhSachSanPham.Size = new Size(798, 290);
            dgvDanhSachSanPham.TabIndex = 0;
            dgvDanhSachSanPham.RowPostPaint += dgvDanhSachSanPham_RowPostPaint;
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnXuatPDF);
            pnButton.Controls.Add(btnQuayLai);
            pnButton.Controls.Add(btnThoat);
            pnButton.Dock = DockStyle.Fill;
            pnButton.Location = new Point(3, 537);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(798, 62);
            pnButton.TabIndex = 5;
            // 
            // btnXuatPDF
            // 
            btnXuatPDF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnXuatPDF.BackColor = Color.DarkRed;
            btnXuatPDF.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatPDF.ForeColor = Color.White;
            btnXuatPDF.Location = new Point(439, 0);
            btnXuatPDF.Name = "btnXuatPDF";
            btnXuatPDF.Size = new Size(113, 60);
            btnXuatPDF.TabIndex = 2;
            btnXuatPDF.Text = "XUẤT FILE PDF";
            btnXuatPDF.UseVisualStyleBackColor = false;
            btnXuatPDF.Click += btnXuatPDF_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnQuayLai.BackColor = Color.DarkRed;
            btnQuayLai.Image = Properties.Resources.back;
            btnQuayLai.Location = new Point(559, 0);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(113, 60);
            btnQuayLai.TabIndex = 1;
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnThoat.BackColor = Color.DarkRed;
            btnThoat.Image = Properties.Resources.exit;
            btnThoat.Location = new Point(678, 0);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 60);
            btnThoat.TabIndex = 0;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // tlpTimKiem
            // 
            tlpTimKiem.ColumnCount = 4;
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.4030228F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4710331F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTimKiem.Controls.Add(btnXoa, 1, 1);
            tlpTimKiem.Controls.Add(btnAnHien, 0, 1);
            tlpTimKiem.Controls.Add(btnTim, 3, 0);
            tlpTimKiem.Controls.Add(txtTimKiem, 2, 0);
            tlpTimKiem.Controls.Add(cbbLoaiTimKiem, 1, 0);
            tlpTimKiem.Controls.Add(btnThemSanPham, 3, 1);
            tlpTimKiem.Controls.Add(btnSua, 2, 1);
            tlpTimKiem.Controls.Add(picTimKiem, 0, 0);
            tlpTimKiem.Dock = DockStyle.Fill;
            tlpTimKiem.Location = new Point(3, 118);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowCount = 2;
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 38.5964928F));
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 61.4035072F));
            tlpTimKiem.Size = new Size(798, 114);
            tlpTimKiem.TabIndex = 6;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Right;
            btnXoa.BackColor = Color.DarkRed;
            btnXoa.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(209, 47);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 64);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnAnHien
            // 
            btnAnHien.Anchor = AnchorStyles.Right;
            btnAnHien.BackColor = Color.White;
            btnAnHien.Image = Properties.Resources.eye;
            btnAnHien.Location = new Point(146, 55);
            btnAnHien.Name = "btnAnHien";
            btnAnHien.Size = new Size(50, 47);
            btnAnHien.TabIndex = 6;
            btnAnHien.UseVisualStyleBackColor = false;
            btnAnHien.Click += btnAnHien_Click;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Left;
            btnTim.Image = Properties.Resources.search;
            btnTim.Location = new Point(600, 3);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 38);
            btnTim.TabIndex = 2;
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Location = new Point(365, 8);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(229, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // cbbLoaiTimKiem
            // 
            cbbLoaiTimKiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbbLoaiTimKiem.FormattingEnabled = true;
            cbbLoaiTimKiem.Location = new Point(202, 8);
            cbbLoaiTimKiem.Name = "cbbLoaiTimKiem";
            cbbLoaiTimKiem.Size = new Size(157, 28);
            cbbLoaiTimKiem.TabIndex = 0;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Anchor = AnchorStyles.Left;
            btnThemSanPham.BackColor = Color.DarkRed;
            btnThemSanPham.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemSanPham.ForeColor = Color.White;
            btnThemSanPham.Location = new Point(600, 47);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(189, 64);
            btnThemSanPham.TabIndex = 4;
            btnThemSanPham.Text = "THÊM SẢN PHẨM";
            btnThemSanPham.UseVisualStyleBackColor = false;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Right;
            btnSua.BackColor = Color.DarkRed;
            btnSua.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(405, 47);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(189, 64);
            btnSua.TabIndex = 5;
            btnSua.Text = "SỬA SẢN PHẨM";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // picTimKiem
            // 
            picTimKiem.Anchor = AnchorStyles.Right;
            picTimKiem.Image = Properties.Resources.search;
            picTimKiem.Location = new Point(169, 3);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(27, 38);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 8;
            picTimKiem.TabStop = false;
            // 
            // DANHSACHSANPHAM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 602);
            Controls.Add(tlpDSSP);
            Name = "DANHSACHSANPHAM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí sản phẩm";
            Load += DANHSACHSANPHAM_Load;
            tlpDSSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pndgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).EndInit();
            pnButton.ResumeLayout(false);
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpDSSP;
        private PictureBox picLogo;
        private Panel pndgv;
        private DataGridView dgvDanhSachSanPham;
        private Panel pnButton;
        private Button btnQuayLai;
        private Button btnThoat;
        private TableLayoutPanel tlpTimKiem;
        private ComboBox cbbLoaiTimKiem;
        private TextBox txtTimKiem;
        private Button btnTim;
        private Button btnThemSanPham;
        private Button btnSua;
        private Button btnXoa;
        private Button btnAnHien;
        private Button btnXuatPDF;
        private PictureBox picTimKiem;
    }
}