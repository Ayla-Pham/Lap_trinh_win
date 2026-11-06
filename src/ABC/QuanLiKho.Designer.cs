namespace ABC
{
    partial class QuanLiKho
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tlpall = new TableLayoutPanel();
            picLogo = new PictureBox();
            tlpBoLoc = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            lbTimKiem = new Label();
            btnThemKho = new Button();
            btnXuatkho = new Button();
            dgvKho = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            tlpend = new TableLayoutPanel();
            btnThoat = new Button();
            btnLamMoi = new Button();
            button1 = new Button();
            tlpall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpBoLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            tlpend.SuspendLayout();
            SuspendLayout();
            // 
            // tlpall
            // 
            tlpall.ColumnCount = 1;
            tlpall.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpall.Controls.Add(picLogo, 0, 0);
            tlpall.Controls.Add(tlpBoLoc, 0, 1);
            tlpall.Controls.Add(dgvKho, 0, 2);
            tlpall.Controls.Add(tlpend, 0, 3);
            tlpall.Dock = DockStyle.Fill;
            tlpall.Location = new Point(0, 0);
            tlpall.Margin = new Padding(3, 2, 3, 2);
            tlpall.Name = "tlpall";
            tlpall.RowCount = 4;
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 17.55556F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 22.44444F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 46.44444F));
            tlpall.RowStyles.Add(new RowStyle(SizeType.Percent, 13.33333F));
            tlpall.Size = new Size(700, 338);
            tlpall.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(3, 2);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(694, 55);
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
            tlpBoLoc.Controls.Add(txtTimKiem, 2, 0);
            tlpBoLoc.Controls.Add(lbTimKiem, 1, 0);
            tlpBoLoc.Controls.Add(btnThemKho, 3, 1);
            tlpBoLoc.Controls.Add(btnXuatkho, 2, 1);
            tlpBoLoc.Dock = DockStyle.Fill;
            tlpBoLoc.Location = new Point(3, 61);
            tlpBoLoc.Margin = new Padding(3, 2, 3, 2);
            tlpBoLoc.Name = "tlpBoLoc";
            tlpBoLoc.RowCount = 2;
            tlpBoLoc.RowStyles.Add(new RowStyle(SizeType.Percent, 34.73684F));
            tlpBoLoc.RowStyles.Add(new RowStyle(SizeType.Percent, 65.26316F));
            tlpBoLoc.Size = new Size(694, 72);
            tlpBoLoc.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Location = new Point(349, 2);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(167, 23);
            txtTimKiem.TabIndex = 0;
            // 
            // lbTimKiem
            // 
            lbTimKiem.Anchor = AnchorStyles.Right;
            lbTimKiem.AutoSize = true;
            lbTimKiem.Location = new Point(286, 5);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(57, 15);
            lbTimKiem.TabIndex = 1;
            lbTimKiem.Text = "Tìm kiếm";
            // 
            // btnThemKho
            // 
            btnThemKho.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThemKho.BackColor = Color.DarkRed;
            btnThemKho.Location = new Point(522, 28);
            btnThemKho.Margin = new Padding(3, 2, 3, 2);
            btnThemKho.Name = "btnThemKho";
            btnThemKho.Size = new Size(128, 42);
            btnThemKho.TabIndex = 2;
            btnThemKho.Text = "Thêm tồn kho";
            btnThemKho.UseVisualStyleBackColor = false;
            btnThemKho.Click += btnNhapKho_Click;
            // 
            // btnXuatkho
            // 
            btnXuatkho.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXuatkho.BackColor = Color.DarkRed;
            btnXuatkho.Location = new Point(349, 28);
            btnXuatkho.Margin = new Padding(3, 2, 3, 2);
            btnXuatkho.Name = "btnXuatkho";
            btnXuatkho.Size = new Size(128, 42);
            btnXuatkho.TabIndex = 3;
            btnXuatkho.Text = "Xuất kho";
            btnXuatkho.UseVisualStyleBackColor = false;
            btnXuatkho.Click += btnXuatKho_Click;
            // 
            // dgvKho
            // 
            dgvKho.AllowUserToAddRows = false;
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, SoLuong, GiaBan });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvKho.DefaultCellStyle = dataGridViewCellStyle1;
            dgvKho.Dock = DockStyle.Fill;
            dgvKho.Location = new Point(3, 137);
            dgvKho.Margin = new Padding(3, 2, 3, 2);
            dgvKho.Name = "dgvKho";
            dgvKho.ReadOnly = true;
            dgvKho.RowHeadersWidth = 51;
            dgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKho.Size = new Size(694, 153);
            dgvKho.TabIndex = 2;
            // 
            // MaSP
            // 
            MaSP.DataPropertyName = "MaSP";
            MaSP.HeaderText = "Mã sản phẩm";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "TenSP";
            TenSP.HeaderText = "Tên sản phẩm";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            TenSP.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuongTon";
            SoLuong.HeaderText = "Tồn kho";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // tlpend
            // 
            tlpend.ColumnCount = 4;
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.39798F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.47607F));
            tlpend.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpend.Controls.Add(btnThoat, 3, 0);
            tlpend.Controls.Add(btnLamMoi, 1, 0);
            tlpend.Controls.Add(button1, 2, 0);
            tlpend.Dock = DockStyle.Fill;
            tlpend.Location = new Point(3, 294);
            tlpend.Margin = new Padding(3, 2, 3, 2);
            tlpend.Name = "tlpend";
            tlpend.RowCount = 1;
            tlpend.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpend.Size = new Size(694, 42);
            tlpend.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DarkRed;
            btnThoat.Image = Properties.Resources.exit;
            btnThoat.Location = new Point(521, 2);
            btnThoat.Margin = new Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 37);
            btnThoat.TabIndex = 0;
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.BackColor = Color.DarkRed;
            btnLamMoi.Image = Properties.Resources.back;
            btnLamMoi.Location = new Point(335, 2);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(87, 37);
            btnLamMoi.TabIndex = 0;
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Image = Properties.Resources.refresh;
            button1.Location = new Point(428, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(87, 38);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLamMoi_Click;
            // 
            // QuanLiKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tlpall);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuanLiKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí kho";
            tlpall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpBoLoc.ResumeLayout(false);
            tlpBoLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            tlpend.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpall;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TableLayoutPanel tlpBoLoc;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.Button btnThemKho;
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.TableLayoutPanel tlpend;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private Button button1;
    }
}