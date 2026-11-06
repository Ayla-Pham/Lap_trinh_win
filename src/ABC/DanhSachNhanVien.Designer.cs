namespace ABC
{
    partial class DanhSachNhanVien
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
            lbLocTheo = new Label();
            cbbLoaiNhanVien = new ComboBox();
            btnThemNhanVien = new Button();
            btnSuaNhanVien = new Button();
            dgvNhanVien = new DataGridView();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            tlpend.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpTimKiem, 0, 1);
            tlpall.Controls.Add(dgvNhanVien, 0, 2);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 17.81076F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 19.48052F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 50.2782936F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8014841F));
            tlpall.Size = new Size(1263, 601);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(1257, 100);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpTimKiem
            // 
            tlpTimKiem.ColumnCount = 5;
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2810459F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.2679729F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.87039F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.6059017F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tlpTimKiem.Controls.Add(lbTimKiem, 0, 0);
            tlpTimKiem.Controls.Add(txtTimKiem, 1, 0);
            tlpTimKiem.Controls.Add(lbLocTheo, 2, 0);
            tlpTimKiem.Controls.Add(cbbLoaiNhanVien, 3, 0);
            tlpTimKiem.Controls.Add(btnThemNhanVien, 4, 1);
            tlpTimKiem.Controls.Add(btnSuaNhanVien, 3, 1);
            tlpTimKiem.Dock = DockStyle.Fill;
            tlpTimKiem.Location = new Point(3, 109);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowCount = 2;
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7142868F));
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 64.28571F));
            tlpTimKiem.Size = new Size(1257, 110);
            tlpTimKiem.TabIndex = 1;
            tlpTimKiem.Paint += tlpTimKiem_Paint;
            // 
            // lbTimKiem
            // 
            lbTimKiem.Anchor = AnchorStyles.Right;
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(136, 9);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(70, 20);
            lbTimKiem.TabIndex = 0;
            lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Location = new Point(212, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(300, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lbLocTheo
            // 
            lbLocTheo.Anchor = AnchorStyles.Right;
            lbLocTheo.AutoSize = true;
            lbLocTheo.Location = new Point(737, 9);
            lbLocTheo.Name = "lbLocTheo";
            lbLocTheo.Size = new Size(66, 20);
            lbLocTheo.TabIndex = 4;
            lbLocTheo.Text = "Lọc theo";
            // 
            // cbbLoaiNhanVien
            // 
            cbbLoaiNhanVien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbbLoaiNhanVien.FormattingEnabled = true;
            cbbLoaiNhanVien.Location = new Point(809, 5);
            cbbLoaiNhanVien.Name = "cbbLoaiNhanVien";
            cbbLoaiNhanVien.Size = new Size(272, 28);
            cbbLoaiNhanVien.TabIndex = 5;
            cbbLoaiNhanVien.SelectedIndexChanged += cbbLoaiNhanVien_SelectedIndexChanged;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.Location = new Point(1087, 42);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new Size(165, 65);
            btnThemNhanVien.TabIndex = 2;
            btnThemNhanVien.Text = "Thêm nhân viên mới";
            btnThemNhanVien.UseVisualStyleBackColor = true;
            btnThemNhanVien.Click += btnThemNhanVien_Click;
            // 
            // btnSuaNhanVien
            // 
            btnSuaNhanVien.Location = new Point(809, 42);
            btnSuaNhanVien.Name = "btnSuaNhanVien";
            btnSuaNhanVien.Size = new Size(143, 65);
            btnSuaNhanVien.TabIndex = 3;
            btnSuaNhanVien.Text = "Sửa thông tin";
            btnSuaNhanVien.UseVisualStyleBackColor = true;
            btnSuaNhanVien.Click += btnSuaNhanVien_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 225);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(1257, 295);
            dgvNhanVien.TabIndex = 2;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 3;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.3611755F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.97852F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.5807476F));
            tlpend.Controls.Add(btnThoat, 2, 0);
            tlpend.Controls.Add(btnLamMoi, 0, 0);
            tlpend.Controls.Add(btnXoa, 1, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 526);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpend.Size = new Size(1257, 72);
            tlpend.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1126, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 66);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.Location = new Point(853, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(129, 66);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(988, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(132, 66);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // DanhSachNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 601);
            Controls.Add(tlpall);
            Name = "DanhSachNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí nhân viên";
            Load += DanhSachNhanVien_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            tlpend.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpTimKiem;
        private Label lbTimKiem;
        private TextBox txtTimKiem;
        private Button btnThemNhanVien;
        private Button btnSuaNhanVien;
        private Label lbLocTheo;
        private ComboBox cbbLoaiNhanVien;
        private DataGridView dgvNhanVien;
        private TableLayoutPanel tlpend;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnXoa;
    }
}