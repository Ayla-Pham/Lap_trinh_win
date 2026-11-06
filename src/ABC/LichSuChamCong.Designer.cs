namespace ABC
{
    partial class LichSuChamCong
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
            piclogo = new PictureBox();
            tlpBoLoc = new TableLayoutPanel();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            txtTimKiem = new TextBox();
            pictimkiem = new PictureBox();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            dgvLSChamCong = new DataGridView();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            tlpBoLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictimkiem).BeginInit();
            tlpend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLSChamCong).BeginInit();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(piclogo, 0, 0);
            tlpall.Controls.Add(tlpBoLoc, 0, 1);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Controls.Add(dgvLSChamCong, 0, 2);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Margin = new Padding(3, 2, 3, 2);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4410057F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7620888F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6769829F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 14.50677F));
            tlpall.Size = new Size(700, 388);
            tlpall.TabIndex = 0;
            // 
            // piclogo
            // 
            piclogo.Dock = DockStyle.Fill;
            piclogo.Image = Properties.Resources.logo;
            piclogo.Location = new Point(3, 2);
            piclogo.Margin = new Padding(3, 2, 3, 2);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(694, 59);
            piclogo.SizeMode = PictureBoxSizeMode.Zoom;
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // tlpBoLoc
            // 
            tlpBoLoc.ColumnCount = 2;
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBoLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBoLoc.Controls.Add(dtpTuNgay, 1, 0);
            tlpBoLoc.Controls.Add(dtpDenNgay, 1, 1);
            tlpBoLoc.Controls.Add(txtTimKiem, 0, 1);
            tlpBoLoc.Controls.Add(pictimkiem, 0, 0);
            tlpBoLoc.Dock = DockStyle.Fill;
            tlpBoLoc.Location = new Point(3, 65);
            tlpBoLoc.Margin = new Padding(3, 2, 3, 2);
            tlpBoLoc.Name = "tlpBoLoc";
            tlpBoLoc.RowCount = 2;
            tlpBoLoc.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBoLoc.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBoLoc.Size = new Size(694, 68);
            tlpBoLoc.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Anchor = AnchorStyles.Left;
            dtpTuNgay.Location = new Point(350, 5);
            dtpTuNgay.Margin = new Padding(3, 2, 3, 2);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(219, 23);
            dtpTuNgay.TabIndex = 0;
            dtpTuNgay.ValueChanged += dtpTuNgay_ValueChanged;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.Left;
            dtpDenNgay.Location = new Point(350, 39);
            dtpDenNgay.Margin = new Padding(3, 2, 3, 2);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(219, 23);
            dtpDenNgay.TabIndex = 0;
            dtpDenNgay.ValueChanged += dtpDenNgay_ValueChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Right;
            txtTimKiem.Location = new Point(234, 36);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(110, 23);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // pictimkiem
            // 
            pictimkiem.Anchor = AnchorStyles.Right;
            pictimkiem.Image = Properties.Resources.search;
            pictimkiem.Location = new Point(321, 2);
            pictimkiem.Margin = new Padding(3, 2, 3, 2);
            pictimkiem.Name = "pictimkiem";
            pictimkiem.Size = new Size(23, 29);
            pictimkiem.SizeMode = PictureBoxSizeMode.Zoom;
            pictimkiem.TabIndex = 2;
            pictimkiem.TabStop = false;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 2;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.75315F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.246851F));
            tlpend.Controls.Add(btnThoat, 1, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 332);
            tlpend.Margin = new Padding(3, 2, 3, 2);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpend.Size = new Size(694, 54);
            tlpend.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(584, 2);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 49);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvLSChamCong
            // 
            dgvLSChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLSChamCong.Dock = DockStyle.Fill;
            dgvLSChamCong.Location = new Point(3, 137);
            dgvLSChamCong.Margin = new Padding(3, 2, 3, 2);
            dgvLSChamCong.Name = "dgvLSChamCong";
            dgvLSChamCong.RowHeadersWidth = 51;
            dgvLSChamCong.Size = new Size(694, 191);
            dgvLSChamCong.TabIndex = 2;
            // 
            // LichSuChamCong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 388);
            Controls.Add(tlpall);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LichSuChamCong";
            Text = "Lịch sử chấm công";
            Load += LichSuChamCong_Load;
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            tlpBoLoc.ResumeLayout(false);
            tlpBoLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictimkiem).EndInit();
            tlpend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLSChamCong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpall;
        private PictureBox piclogo;
        private TableLayoutPanel tlpBoLoc;
        private TableLayoutPanel tlpend;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private TextBox txtTimKiem;
        private Button btnThoat;
        private DataGridView dgvLSChamCong;
        private PictureBox pictimkiem;
    }
}