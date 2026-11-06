namespace ABC
{
    partial class QuanLiKhachHang
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
            tlpBoLoc = new TableLayoutPanel();
            lbTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnThemKhachHang = new Button();
            btnSuaKhachHang = new Button();
            dgvKhachHang = new DataGridView();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpBoLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            tlpend.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpBoLoc, 0, 1);
            tlpall.Controls.Add(dgvKhachHang, 0, 2);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Margin = new Padding(3, 2, 3, 2);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 15.92233F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 19.61165F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 53.00971F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 11.84466F));
            tlpall.Size = new Size(700, 386);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 2);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(694, 57);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpBoLoc
            // 
            tlpBoLoc.ColumnCount = 4;
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBoLoc.Controls.Add(lbTimKiem, 1, 0);
            tlpBoLoc.Controls.Add(txtTimKiem, 2, 0);
            tlpBoLoc.Controls.Add(btnThemKhachHang, 3, 1);
            tlpBoLoc.Controls.Add(btnSuaKhachHang, 2, 1);
            tlpBoLoc.Dock = DockStyle.Fill;
            tlpBoLoc.Location = new Point(3, 63);
            tlpBoLoc.Margin = new Padding(3, 2, 3, 2);
            tlpBoLoc.Name = "tlpBoLoc";
            tlpBoLoc.RowCount = 2;
            tlpBoLoc.RowStyles.Add(new RowStyle(SizeType.Percent, 34.3434334F));
            tlpBoLoc.RowStyles.Add(new RowStyle(SizeType.Percent, 65.65656F));
            tlpBoLoc.Size = new Size(694, 71);
            tlpBoLoc.TabIndex = 1;
            // 
            // lbTimKiem
            // 
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(176, 0);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(57, 15);
            lbTimKiem.TabIndex = 0;
            lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(349, 2);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(167, 23);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.Location = new Point(522, 26);
            btnThemKhachHang.Margin = new Padding(3, 2, 3, 2);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(169, 42);
            btnThemKhachHang.TabIndex = 2;
            btnThemKhachHang.Text = "Thêm khách hàng";
            btnThemKhachHang.UseVisualStyleBackColor = true;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // btnSuaKhachHang
            // 
            btnSuaKhachHang.Location = new Point(349, 26);
            btnSuaKhachHang.Margin = new Padding(3, 2, 3, 2);
            btnSuaKhachHang.Name = "btnSuaKhachHang";
            btnSuaKhachHang.Size = new Size(167, 42);
            btnSuaKhachHang.TabIndex = 3;
            btnSuaKhachHang.Text = "Sửa thông tin";
            btnSuaKhachHang.UseVisualStyleBackColor = true;
            btnSuaKhachHang.Click += btnSuaKhachHang_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(3, 138);
            dgvKhachHang.Margin = new Padding(3, 2, 3, 2);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(694, 199);
            dgvKhachHang.TabIndex = 2;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            dgvKhachHang.RowHeaderMouseClick += dgvKhachHang_RowHeaderMouseClick;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 3;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.62469F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6246853F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6246853F));
            tlpend.Controls.Add(btnThoat, 2, 0);
            tlpend.Controls.Add(btnXoa, 1, 0);
            tlpend.Controls.Add(btnLamMoi, 0, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 341);
            tlpend.Margin = new Padding(3, 2, 3, 2);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpend.Size = new Size(694, 43);
            tlpend.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(580, 2);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(111, 38);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(465, 2);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 38);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.Location = new Point(345, 2);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(114, 38);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // QuanLiKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 386);
            Controls.Add(tlpall);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuanLiKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí khách hàng";
            Load += QuanLiKhachHang_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpBoLoc.ResumeLayout(false);
            tlpBoLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            tlpend.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpBoLoc;
        private Label lbTimKiem;
        private TextBox txtTimKiem;
        private Button btnThemKhachHang;
        private Button btnSuaKhachHang;
        private DataGridView dgvKhachHang;
        private TableLayoutPanel tlpend;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLamMoi;
    }
}