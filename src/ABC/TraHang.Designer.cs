namespace ABC
{
    partial class TraHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Font = new System.Drawing.Font("Segoe UI", 9F);  // phông mặc định như .NET 8, để AutoScaleMode.Font co giãn đúng
            tlpAll = new TableLayoutPanel();
            picLogo = new PictureBox();
            tlpContent = new TableLayoutPanel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            dgvHoaDon = new DataGridView();
            lblLyDo = new Label();
            txtLyDo = new TextBox();
            btnTraHang = new Button();
            btnTimKiem = new Button();
            tlpAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // tlpAll
            // 
            tlpAll.ColumnCount = 1;
            tlpAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAll.Controls.Add(picLogo, 0, 0);
            tlpAll.Controls.Add(tlpContent, 0, 1);
            tlpAll.Dock = DockStyle.Fill;
            tlpAll.Location = new Point(0, 0);
            tlpAll.Name = "tlpAll";
            tlpAll.RowCount = 2;
            tlpAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpAll.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAll.Size = new Size(984, 441);
            tlpAll.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(978, 54);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 2;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpContent.Controls.Add(lblTimKiem, 0, 0);
            tlpContent.Controls.Add(txtTimKiem, 0, 1);
            tlpContent.Controls.Add(dgvHoaDon, 0, 2);
            tlpContent.Controls.Add(lblLyDo, 1, 0);
            tlpContent.Controls.Add(txtLyDo, 1, 1);
            tlpContent.Controls.Add(btnTraHang, 1, 4);
            tlpContent.Controls.Add(btnTimKiem, 0, 4);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(3, 63);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 5;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 500F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpContent.Size = new Size(978, 375);
            tlpContent.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.Dock = DockStyle.Fill;
            lblTimKiem.Location = new Point(3, 0);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(580, 30);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm hóa đơn:";
            lblTimKiem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Fill;
            txtTimKiem.Location = new Point(3, 33);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(580, 23);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(3, 63);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(580, 244);
            dgvHoaDon.TabIndex = 2;
            // 
            // lblLyDo
            // 
            lblLyDo.Dock = DockStyle.Fill;
            lblLyDo.Location = new Point(589, 0);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new Size(386, 30);
            lblLyDo.TabIndex = 3;
            lblLyDo.Text = "Lý do trả hàng:";
            lblLyDo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLyDo
            // 
            txtLyDo.Dock = DockStyle.Fill;
            txtLyDo.Location = new Point(589, 33);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            tlpContent.SetRowSpan(txtLyDo, 3);
            txtLyDo.Size = new Size(386, 299);
            txtLyDo.TabIndex = 4;
            // 
            // btnTraHang
            // 
            btnTraHang.BackColor = Color.LightCoral;
            btnTraHang.Dock = DockStyle.Fill;
            btnTraHang.Location = new Point(589, 338);
            btnTraHang.Name = "btnTraHang";
            btnTraHang.Size = new Size(386, 34);
            btnTraHang.TabIndex = 5;
            btnTraHang.Text = "Thực hiện trả hàng";
            btnTraHang.UseVisualStyleBackColor = false;
            btnTraHang.Click += btnTraHang_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Dock = DockStyle.Fill;
            btnTimKiem.Location = new Point(3, 338);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(580, 34);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // TraHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 441);
            Controls.Add(tlpAll);
            Name = "TraHang";
            Text = "Trả Hàng";
            tlpAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpContent.ResumeLayout(false);
            tlpContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpAll;
        private PictureBox picLogo;
        private TableLayoutPanel tlpContent;
        private DataGridView dgvHoaDon;
        private Label lblLyDo;
        private TextBox txtLyDo;
        private Button btnTraHang;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
    }
}
