namespace ABC
{
    partial class LichSuNhapKho
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
            tlpThongtin = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            lbTimKiem = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            label1 = new Label();
            panelNgay = new FlowLayoutPanel();
            lbDenNgay = new Label();
            dgvLichSuNhapKho = new DataGridView();
            MaNk = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            Tennhacc = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn(); // MỚI: Người nhập
            TongTien = new DataGridViewTextBoxColumn();
            chitietnhapkho = new DataGridViewButtonColumn();
            tlpend = new TableLayoutPanel();
            btnXuatExcel = new Button();
            btnThoat = new Button();
            btnLamMoi = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuNhapKho).BeginInit();
            tlpend.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpThongtin, 0, 1);
            tlpall.Controls.Add(dgvLichSuNhapKho, 0, 2);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Margin = new Padding(3, 2, 3, 2);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 32.0707054F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 32.5757561F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 16.88889F));
            tlpall.Size = new Size(880, 396);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 2);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(874, 67);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpThongtin
            // 
            tlpThongtin.AutoSize = true;
            tlpThongtin.ColumnCount = 5;
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0831232F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5138531F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.0100746F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.39295F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tlpThongtin.Controls.Add(txtTimKiem, 3, 0);
            tlpThongtin.Controls.Add(lbTimKiem, 2, 0);
            tlpThongtin.Controls.Add(dtpTuNgay, 1, 0);
            tlpThongtin.Controls.Add(dtpDenNgay, 1, 1);
            tlpThongtin.Controls.Add(label1, 0, 0);
            tlpThongtin.Controls.Add(panelNgay, 2, 1);
            tlpThongtin.Controls.Add(lbDenNgay, 0, 1);
            tlpThongtin.Dock = DockStyle.Fill;
            tlpThongtin.Location = new Point(3, 73);
            tlpThongtin.Margin = new Padding(3, 2, 3, 2);
            tlpThongtin.Name = "tlpThongtin";
            tlpThongtin.RowCount = 2;
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpThongtin.Size = new Size(874, 123);
            tlpThongtin.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Location = new Point(378, 19);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(219, 23);
            txtTimKiem.TabIndex = 1;
            // 
            // lbTimKiem
            // 
            lbTimKiem.Anchor = AnchorStyles.Right;
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(316, 23);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(56, 15);
            lbTimKiem.TabIndex = 0;
            lbTimKiem.Text = "Tìm kiếm";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpTuNgay.Location = new Point(109, 3);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(121, 23);
            dtpTuNgay.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDenNgay.Location = new Point(109, 65);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(121, 23);
            dtpDenNgay.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(35, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Từ ngày";
            // 
            // panelNgay
            // 
            panelNgay.AutoSize = true;
            panelNgay.Location = new Point(236, 65);
            panelNgay.Name = "panelNgay";
            panelNgay.Size = new Size(0, 0);
            panelNgay.TabIndex = 4;
            // 
            // lbDenNgay
            // 
            lbDenNgay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbDenNgay.AutoSize = true;
            lbDenNgay.Location = new Point(27, 62);
            lbDenNgay.Name = "lbDenNgay";
            lbDenNgay.Size = new Size(57, 15);
            lbDenNgay.TabIndex = 6;
            lbDenNgay.Text = "Đến ngày";
            // 
            // dgvLichSuNhapKho
            // 
            dgvLichSuNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSuNhapKho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLichSuNhapKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // MỚI: Đã thêm TenNhanVien
            dgvLichSuNhapKho.Columns.AddRange(new DataGridViewColumn[] { MaNk, NgayNhap, Tennhacc, TenNhanVien, TongTien, chitietnhapkho });
            dgvLichSuNhapKho.Dock = DockStyle.Fill;
            dgvLichSuNhapKho.Location = new Point(3, 200);
            dgvLichSuNhapKho.Margin = new Padding(3, 2, 3, 2);
            dgvLichSuNhapKho.Name = "dgvLichSuNhapKho";
            dgvLichSuNhapKho.ReadOnly = true;
            dgvLichSuNhapKho.RowHeadersWidth = 51;
            dgvLichSuNhapKho.Size = new Size(874, 125);
            dgvLichSuNhapKho.TabIndex = 2;
            // 
            // MaNk
            // 
            MaNk.DataPropertyName = "Mank";
            MaNk.HeaderText = "Mã phiếu nhập kho ";
            MaNk.MinimumWidth = 6;
            MaNk.Name = "MaNk";
            MaNk.ReadOnly = true;
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "Ngaynhap";
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            // 
            // Tennhacc
            // 
            Tennhacc.DataPropertyName = "TenNCC";
            Tennhacc.HeaderText = "Nhà cung cấp";
            Tennhacc.MinimumWidth = 6;
            Tennhacc.Name = "Tennhacc";
            Tennhacc.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Người nhập";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "Tongtien";
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Resizable = DataGridViewTriState.True;
            // 
            // chitietnhapkho
            // 
            chitietnhapkho.HeaderText = "Chi tiết nhập kho";
            chitietnhapkho.MinimumWidth = 6;
            chitietnhapkho.Name = "chitietnhapkho";
            chitietnhapkho.ReadOnly = true;
            chitietnhapkho.Text = "XEM";
            chitietnhapkho.UseColumnTextForButtonValue = true;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 3;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.09235F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9076519F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tlpend.Controls.Add(btnXuatExcel, 0, 0);
            tlpend.Controls.Add(btnThoat, 2, 0);
            tlpend.Controls.Add(btnLamMoi, 1, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 329);
            tlpend.Margin = new Padding(3, 2, 3, 2);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpend.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpend.Size = new Size(874, 65);
            tlpend.TabIndex = 3;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.Location = new Point(536, 2);
            btnXuatExcel.Margin = new Padding(3, 2, 3, 2);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(106, 48);
            btnXuatExcel.TabIndex = 1;
            btnXuatExcel.Text = "Xuất excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(761, 2);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(99, 48);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.Location = new Point(649, 2);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 48);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // LichSuNhapKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 396);
            Controls.Add(tlpall);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LichSuNhapKho";
            Text = "Lịch sử nhập kho";
            Load += LichSuNhapKho_Load_1;
            tlpall.ResumeLayout(false);
            tlpall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpThongtin.ResumeLayout(false);
            tlpThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuNhapKho).EndInit();
            tlpend.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpThongtin;
        private Label lbTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvLichSuNhapKho;
        private TableLayoutPanel tlpend;
        private Button btnLamMoi;
        private Button btnThoat;
        private DataGridViewTextBoxColumn MaNk;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn Tennhacc;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewButtonColumn chitietnhapkho;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private FlowLayoutPanel panelNgay;
        private Label label1;
        private Label lbDenNgay;
        private Button btnXuatExcel;
        // MỚI: Khai báo cột TenNhanVien
        private DataGridViewTextBoxColumn TenNhanVien;
    }
}