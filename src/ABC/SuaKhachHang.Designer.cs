namespace ABC
{
    partial class SuaKhachHang
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
            lbTenKhachHang = new Label();
            lbSoDienThoai = new Label();
            lbTichDiem = new Label();
            txtTenKhachHang = new TextBox();
            txtSoDienThoai = new TextBox();
            txtTichDiem = new TextBox();
            tlpButton = new TableLayoutPanel();
            btnThoat = new Button();
            btnLuu = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpThongtin.SuspendLayout();
            tlpButton.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpThongtin, 0, 1);
            tlpall.Controls.Add(tlpButton, 0, 2);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 17.75148F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 41.42012F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1893482F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6390533F));
            tlpall.Size = new Size(385, 338);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(379, 54);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpThongtin
            // 
            tlpThongtin.ColumnCount = 2;
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.59103F));
            tlpThongtin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.40897F));
            tlpThongtin.Controls.Add(lbTenKhachHang, 0, 0);
            tlpThongtin.Controls.Add(lbSoDienThoai, 0, 1);
            tlpThongtin.Controls.Add(lbTichDiem, 0, 2);
            tlpThongtin.Controls.Add(txtTenKhachHang, 1, 0);
            tlpThongtin.Controls.Add(txtSoDienThoai, 1, 1);
            tlpThongtin.Controls.Add(txtTichDiem, 1, 2);
            tlpThongtin.Dock = DockStyle.Fill;
            tlpThongtin.Location = new Point(3, 63);
            tlpThongtin.Name = "tlpThongtin";
            tlpThongtin.RowCount = 3;
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpThongtin.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpThongtin.Size = new Size(379, 134);
            tlpThongtin.TabIndex = 1;
            // 
            // lbTenKhachHang
            // 
            lbTenKhachHang.Anchor = AnchorStyles.Right;
            lbTenKhachHang.AutoSize = true;
            lbTenKhachHang.Location = new Point(55, 12);
            lbTenKhachHang.Name = "lbTenKhachHang";
            lbTenKhachHang.Size = new Size(111, 20);
            lbTenKhachHang.TabIndex = 0;
            lbTenKhachHang.Text = "Tên khách hàng";
            // 
            // lbSoDienThoai
            // 
            lbSoDienThoai.Anchor = AnchorStyles.Right;
            lbSoDienThoai.AutoSize = true;
            lbSoDienThoai.Location = new Point(69, 56);
            lbSoDienThoai.Name = "lbSoDienThoai";
            lbSoDienThoai.Size = new Size(97, 20);
            lbSoDienThoai.TabIndex = 1;
            lbSoDienThoai.Text = "Số điện thoại";
            // 
            // lbTichDiem
            // 
            lbTichDiem.Anchor = AnchorStyles.Right;
            lbTichDiem.AutoSize = true;
            lbTichDiem.Location = new Point(92, 101);
            lbTichDiem.Name = "lbTichDiem";
            lbTichDiem.Size = new Size(74, 20);
            lbTichDiem.TabIndex = 2;
            lbTichDiem.Text = "Tích điểm";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Anchor = AnchorStyles.Left;
            txtTenKhachHang.Location = new Point(172, 8);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(204, 27);
            txtTenKhachHang.TabIndex = 3;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Anchor = AnchorStyles.Left;
            txtSoDienThoai.Location = new Point(172, 52);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(204, 27);
            txtSoDienThoai.TabIndex = 3;
            // 
            // txtTichDiem
            // 
            txtTichDiem.Anchor = AnchorStyles.Left;
            txtTichDiem.Location = new Point(172, 97);
            txtTichDiem.Name = "txtTichDiem";
            txtTichDiem.Size = new Size(204, 27);
            txtTichDiem.TabIndex = 3;
            // 
            // tlpButton
            // 
            tlpButton.ColumnCount = 2;
            tlpButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButton.Controls.Add(btnThoat, 1, 0);
            tlpButton.Controls.Add(btnLuu, 0, 0);
            tlpButton.Dock = DockStyle.Fill;
            tlpButton.Location = new Point(3, 203);
            tlpButton.Name = "tlpButton";
            tlpButton.RowCount = 1;
            tlpButton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpButton.Size = new Size(379, 68);
            tlpButton.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(192, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(115, 62);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.Location = new Point(72, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 62);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // SuaKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 338);
            Controls.Add(tlpall);
            Name = "SuaKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa khách hàng";
            Load += SuaKhachHang_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpThongtin.ResumeLayout(false);
            tlpThongtin.PerformLayout();
            tlpButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox picLogo;
        private TableLayoutPanel tlpThongtin;
        private Label lbTenKhachHang;
        private Label lbSoDienThoai;
        private Label lbTichDiem;
        private TextBox txtTenKhachHang;
        private TextBox txtSoDienThoai;
        private TextBox txtTichDiem;
        private TableLayoutPanel tlpButton;
        private Button btnThoat;
        private Button btnLuu;
    }
}