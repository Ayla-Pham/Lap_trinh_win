namespace ABC
{
    partial class LICHSUHOADON
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
            tlpall = new System.Windows.Forms.TableLayoutPanel();
            picLogo = new System.Windows.Forms.PictureBox();
            tlpBoLoc = new System.Windows.Forms.TableLayoutPanel();
            tlpend = new System.Windows.Forms.TableLayoutPanel();
            btnLamMoi = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();
            btnQuayLai = new System.Windows.Forms.Button();
            tabPage1 = new System.Windows.Forms.TabPage();
            tlpthongtin = new System.Windows.Forms.TableLayoutPanel();
            tlploc = new System.Windows.Forms.TableLayoutPanel();
            gbLoc = new System.Windows.Forms.GroupBox();
            cBNhanVienBan = new System.Windows.Forms.CheckBox();
            txtMaNhanVien = new System.Windows.Forms.TextBox();
            cBTuNgay = new System.Windows.Forms.CheckBox();
            cBDenNgay = new System.Windows.Forms.CheckBox();
            dTPDenNgay = new System.Windows.Forms.DateTimePicker();
            dTPTuNgay = new System.Windows.Forms.DateTimePicker();
            lbMaHoaDon = new System.Windows.Forms.Label();
            txtTimKiem = new System.Windows.Forms.TextBox();
            btnLocDuLieu = new System.Windows.Forms.Button();
            btnXuatPDF = new System.Windows.Forms.Button();
            dgvNhanVien = new System.Windows.Forms.DataGridView();
            dgvHoaDon = new System.Windows.Forms.DataGridView();
            tabLS = new System.Windows.Forms.TabControl();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpBoLoc.SuspendLayout();
            tlpend.SuspendLayout();
            tabPage1.SuspendLayout();
            tlpthongtin.SuspendLayout();
            tlploc.SuspendLayout();
            gbLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            tabLS.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpBoLoc, 0, 1);
            tlpall.Controls.Add(tlpend, 0, 2);
            tlpall.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpall.Location = new System.Drawing.Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 3;
            tlpall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.366907F));
            tlpall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.25569F));
            tlpall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.457093F));
            tlpall.Size = new System.Drawing.Size(1206, 693);
            tlpall.TabIndex = 0;
            tlpall.Paint += tlpall_Paint;
            // 
            // picLogo
            // 
            picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            picLogo.Image = global::ABC.Properties.Resources.logo;
            picLogo.Location = new System.Drawing.Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(1200, 107);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpBoLoc
            // 
            tlpBoLoc.ColumnCount = 1;
            tlpBoLoc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8132F));
            tlpBoLoc.Controls.Add(tabLS, 0, 0);
            tlpBoLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpBoLoc.Location = new System.Drawing.Point(3, 116);
            tlpBoLoc.Name = "tlpBoLoc";
            tlpBoLoc.RowCount = 2;
            tlpBoLoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.42519F));
            tlpBoLoc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.5748031F));
            tlpBoLoc.Size = new System.Drawing.Size(1200, 508);
            tlpBoLoc.TabIndex = 1;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 3;
            tlpend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            tlpend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.916667F));
            tlpend.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            tlpend.Controls.Add(btnLamMoi, 0, 0);
            tlpend.Controls.Add(btnThoat, 2, 0);
            tlpend.Controls.Add(btnQuayLai, 1, 0);
            tlpend.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpend.Location = new System.Drawing.Point(3, 630);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpend.Size = new System.Drawing.Size(1200, 60);
            tlpend.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnLamMoi.Location = new System.Drawing.Point(812, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(121, 54);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "LÀM MỚI";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new System.Drawing.Point(1070, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(126, 54);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnQuayLai.Location = new System.Drawing.Point(939, 3);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new System.Drawing.Size(125, 54);
            btnQuayLai.TabIndex = 1;
            btnQuayLai.Text = "QUAY LẠI";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tlpthongtin);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1186, 461);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lịch sử hóa đơn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlpthongtin
            // 
            tlpthongtin.ColumnCount = 1;
            tlpthongtin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpthongtin.Controls.Add(dgvHoaDon, 0, 1);
            tlpthongtin.Controls.Add(tlploc, 0, 0);
            tlpthongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpthongtin.Location = new System.Drawing.Point(3, 3);
            tlpthongtin.Name = "tlpthongtin";
            tlpthongtin.RowCount = 2;
            tlpthongtin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpthongtin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpthongtin.Size = new System.Drawing.Size(1180, 455);
            tlpthongtin.TabIndex = 0;
            // 
            // tlploc
            // 
            tlploc.ColumnCount = 2;
            tlploc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlploc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlploc.Controls.Add(dgvNhanVien, 1, 0);
            tlploc.Controls.Add(gbLoc, 0, 0);
            tlploc.Dock = System.Windows.Forms.DockStyle.Fill;
            tlploc.Location = new System.Drawing.Point(3, 3);
            tlploc.Name = "tlploc";
            tlploc.RowCount = 1;
            tlploc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlploc.Size = new System.Drawing.Size(1174, 221);
            tlploc.TabIndex = 0;
            // 
            // gbLoc
            // 
            gbLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            gbLoc.Controls.Add(btnXuatPDF);
            gbLoc.Controls.Add(btnLocDuLieu);
            gbLoc.Controls.Add(txtTimKiem);
            gbLoc.Controls.Add(lbMaHoaDon);
            gbLoc.Controls.Add(dTPTuNgay);
            gbLoc.Controls.Add(dTPDenNgay);
            gbLoc.Controls.Add(cBDenNgay);
            gbLoc.Controls.Add(cBTuNgay);
            gbLoc.Controls.Add(txtMaNhanVien);
            gbLoc.Controls.Add(cBNhanVienBan);
            gbLoc.Location = new System.Drawing.Point(3, 3);
            gbLoc.Name = "gbLoc";
            gbLoc.Size = new System.Drawing.Size(581, 215);
            gbLoc.TabIndex = 0;
            gbLoc.TabStop = false;
            gbLoc.Text = "Lọc theo";
            // 
            // cBNhanVienBan
            // 
            cBNhanVienBan.AutoSize = true;
            cBNhanVienBan.Location = new System.Drawing.Point(11, 73);
            cBNhanVienBan.Name = "cBNhanVienBan";
            cBNhanVienBan.Size = new System.Drawing.Size(126, 24);
            cBNhanVienBan.TabIndex = 0;
            cBNhanVienBan.Text = "Nhân viên bán";
            cBNhanVienBan.UseVisualStyleBackColor = true;
            cBNhanVienBan.CheckedChanged += cBNhanVienBan_CheckedChanged;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new System.Drawing.Point(143, 71);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new System.Drawing.Size(230, 27);
            txtMaNhanVien.TabIndex = 1;
            txtMaNhanVien.Text = "Nhập mã nhân viên";
            // 
            // cBTuNgay
            // 
            cBTuNgay.AutoSize = true;
            cBTuNgay.Location = new System.Drawing.Point(11, 113);
            cBTuNgay.Name = "cBTuNgay";
            cBTuNgay.Size = new System.Drawing.Size(84, 24);
            cBTuNgay.TabIndex = 2;
            cBTuNgay.Text = "Từ ngày";
            cBTuNgay.UseVisualStyleBackColor = true;
            cBTuNgay.CheckedChanged += cBTuNgay_CheckedChanged;
            // 
            // cBDenNgay
            // 
            cBDenNgay.AutoSize = true;
            cBDenNgay.Location = new System.Drawing.Point(11, 149);
            cBDenNgay.Name = "cBDenNgay";
            cBDenNgay.Size = new System.Drawing.Size(94, 24);
            cBDenNgay.TabIndex = 4;
            cBDenNgay.Text = "Đến ngày";
            cBDenNgay.UseVisualStyleBackColor = true;
            cBDenNgay.CheckedChanged += cBDenNgay_CheckedChanged;
            // 
            // dTPDenNgay
            // 
            dTPDenNgay.Location = new System.Drawing.Point(123, 147);
            dTPDenNgay.Name = "dTPDenNgay";
            dTPDenNgay.Size = new System.Drawing.Size(250, 27);
            dTPDenNgay.TabIndex = 5;
            // 
            // dTPTuNgay
            // 
            dTPTuNgay.Location = new System.Drawing.Point(123, 109);
            dTPTuNgay.Name = "dTPTuNgay";
            dTPTuNgay.Size = new System.Drawing.Size(250, 27);
            dTPTuNgay.TabIndex = 5;
            // 
            // lbMaHoaDon
            // 
            lbMaHoaDon.AutoSize = true;
            lbMaHoaDon.Location = new System.Drawing.Point(11, 35);
            lbMaHoaDon.Name = "lbMaHoaDon";
            lbMaHoaDon.Size = new System.Drawing.Size(70, 20);
            lbMaHoaDon.TabIndex = 6;
            lbMaHoaDon.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new System.Drawing.Point(87, 31);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(286, 27);
            txtTimKiem.TabIndex = 7;
            // 
            // btnLocDuLieu
            // 
            btnLocDuLieu.Location = new System.Drawing.Point(428, 31);
            btnLocDuLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLocDuLieu.Name = "btnLocDuLieu";
            btnLocDuLieu.Size = new System.Drawing.Size(124, 51);
            btnLocDuLieu.TabIndex = 8;
            btnLocDuLieu.Text = "Lọc dữ liệu";
            btnLocDuLieu.UseVisualStyleBackColor = true;
            btnLocDuLieu.Click += btnLocDuLieu_Click;
            // 
            // btnXuatPDF
            // 
            btnXuatPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnXuatPDF.Location = new System.Drawing.Point(428, 113);
            btnXuatPDF.Name = "btnXuatPDF";
            btnXuatPDF.Size = new System.Drawing.Size(124, 57);
            btnXuatPDF.TabIndex = 3;
            btnXuatPDF.Text = "XUẤT FILE PDF";
            btnXuatPDF.UseVisualStyleBackColor = true;
            btnXuatPDF.Click += btnXuatPDF_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvNhanVien.Location = new System.Drawing.Point(590, 3);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new System.Drawing.Size(581, 215);
            dgvNhanVien.TabIndex = 1;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvHoaDon.Location = new System.Drawing.Point(3, 230);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new System.Drawing.Size(1174, 222);
            dgvHoaDon.TabIndex = 2;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            dgvHoaDon.SelectionChanged += dgvHoaDon_SelectionChanged;
            // 
            // tabLS
            // 
            tabLS.Controls.Add(tabPage1);
            tabLS.Dock = System.Windows.Forms.DockStyle.Fill;
            tabLS.Location = new System.Drawing.Point(3, 3);
            tabLS.Name = "tabLS";
            tabLS.SelectedIndex = 0;
            tabLS.Size = new System.Drawing.Size(1194, 494);
            tabLS.TabIndex = 3;
            // 
            // LICHSUHOADON
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1206, 693);
            Controls.Add(tlpall);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Lịch sử hóa đơn & trả hàng";
            Load += LICHSUHOADON_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpBoLoc.ResumeLayout(false);
            tlpend.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tlpthongtin.ResumeLayout(false);
            tlploc.ResumeLayout(false);
            gbLoc.ResumeLayout(false);
            gbLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            tabLS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private System.Windows.Forms.TableLayoutPanel tlpBoLoc;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private TableLayoutPanel tlpend;
        private Button btnThoat;
        private Button btnQuayLai;
        private System.Windows.Forms.GroupBox gbLoc;
        private System.Windows.Forms.DateTimePicker dTPTuNgay;
        private System.Windows.Forms.DateTimePicker dTPDenNgay;
        private System.Windows.Forms.CheckBox cBDenNgay;
        private System.Windows.Forms.CheckBox cBTuNgay;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.CheckBox cBNhanVienBan;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbMaHoaDon;
        private Button btnLamMoi;
        private System.Windows.Forms.Button btnLocDuLieu;
        private System.Windows.Forms.Button btnXuatPDF;
        private System.Windows.Forms.TabControl tabLS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tlpthongtin;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TableLayoutPanel tlploc;
    }
}