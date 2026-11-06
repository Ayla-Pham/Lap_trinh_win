namespace ABC
{
    partial class XuatKho
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
            tlpThongtin = new TableLayoutPanel();
            // Control mới cho Lý do
            lblLyDo = new Label();
            txtLyDo = new TextBox();

            // Các control cũ giữ khai báo để tránh lỗi reference
            lbChonSanPham = new Label();
            txtSoLuong = new TextBox();
            lbxuatSoLuong = new Label();
            txtTimKiem = new TextBox();

            // Thay thế dgv bằng flp
            flpDanhSachSP = new FlowLayoutPanel();

            tlpall = new TableLayoutPanel();
            piclogo = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnXuat = new Button();
            btnThoat = new Button();

            tlpThongtin.SuspendLayout();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpThongtin
            // 
            tlpThongtin.ColumnCount = 2;
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            // Thêm control Lý do vào đây thay cho Search/Số lượng cũ
            tlpThongtin.Controls.Add(lblLyDo, 0, 0);
            tlpThongtin.Controls.Add(txtLyDo, 1, 0);

            // Giữ lại control cũ nhưng ẩn đi
            tlpThongtin.Controls.Add(lbChonSanPham, 0, 1);
            tlpThongtin.Controls.Add(txtSoLuong, 1, 1);

            tlpThongtin.Dock = DockStyle.Fill;
            tlpThongtin.Location = new Point(3, 106);
            tlpThongtin.Name = "tlpThongtin";
            tlpThongtin.RowCount = 2;
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpThongtin.Size = new Size(813, 73);
            tlpThongtin.TabIndex = 2;

            // 
            // lblLyDo
            // 
            lblLyDo.Anchor = AnchorStyles.Left;
            lblLyDo.AutoSize = true;
            lblLyDo.Text = "Lý do xuất kho:";
            lblLyDo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // txtLyDo
            // 
            txtLyDo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLyDo.Location = new Point(3, 3);
            txtLyDo.Size = new Size(500, 27);

            // Ẩn control cũ
            lbChonSanPham.Visible = false;
            txtSoLuong.Visible = false;
            lbxuatSoLuong.Visible = false;
            txtTimKiem.Visible = false;

            // 
            // flpDanhSachSP (Thay thế dgv)
            // 
            flpDanhSachSP.Dock = DockStyle.Fill;
            flpDanhSachSP.AutoScroll = true;
            flpDanhSachSP.BackColor = Color.White;
            flpDanhSachSP.FlowDirection = FlowDirection.TopDown;
            flpDanhSachSP.WrapContents = false;
            flpDanhSachSP.Location = new Point(3, 186);
            flpDanhSachSP.Name = "flpDanhSachSP";
            flpDanhSachSP.Size = new Size(813, 421);
            flpDanhSachSP.TabIndex = 0;

            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(piclogo, 0, 0);
            tlpall.Controls.Add(tlpThongtin, 0, 1);
            // Thay dgv bằng flp
            tlpall.Controls.Add(flpDanhSachSP, 0, 2);
            tlpall.Controls.Add(tableLayoutPanel1, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 14.651494F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 11.2375536F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 61.02418F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9283485F));
            tlpall.Size = new Size(819, 703);
            tlpall.TabIndex = 6;
            // 
            // piclogo
            // 
            piclogo.Dock = DockStyle.Fill;
            piclogo.Image = Properties.Resources.logo;
            piclogo.Location = new Point(3, 3);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(813, 97);
            piclogo.SizeMode = PictureBoxSizeMode.Zoom;
            piclogo.TabIndex = 1;
            piclogo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 154F));
            tableLayoutPanel1.Controls.Add(btnXuat, 0, 0);
            tableLayoutPanel1.Controls.Add(btnThoat, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 614);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(813, 86);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuat.Location = new Point(503, 3);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(153, 74);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất Kho";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(662, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(148, 74);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // XuatKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 703);
            Controls.Add(tlpall);
            Margin = new Padding(3, 4, 3, 4);
            Name = "XuatKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xuất kho";
            Load += XuatKho_Load;
            tlpThongtin.ResumeLayout(false);
            tlpThongtin.PerformLayout();
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpThongtin;
        private Label lbChonSanPham;
        private TextBox txtTimKiem;
        private TextBox txtSoLuong;
        private Label lbxuatSoLuong;
        private Label lblLyDo; // Mới
        private TextBox txtLyDo; // Mới
        // Đã xóa DataGridView dgvxuatkho
        private FlowLayoutPanel flpDanhSachSP; // Mới
        private TableLayoutPanel tlpall;
        private PictureBox piclogo;
        private Button btnXuat;
        private Button btnThoat;
        private TableLayoutPanel tableLayoutPanel1;
    }
}