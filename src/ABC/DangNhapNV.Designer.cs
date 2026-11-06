namespace ABC
{
    partial class DangNhapNV
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
            tlpthan = new TableLayoutPanel();
            lbusername = new Label();
            lbpassword = new Label();
            tlppass = new TableLayoutPanel();
            btnPassword = new Button();
            txtpasswordnv = new TextBox();
            tlpusername = new TableLayoutPanel();
            txtusernv = new TextBox();
            tlpbutton = new TableLayoutPanel();
            btnlogin = new Button();
            btnexit = new Button();
            tlpfrmDNADMIN = new TableLayoutPanel();
            lblognhanvien = new Label();
            pictureBox1 = new PictureBox();
            tlpthan.SuspendLayout();
            tlppass.SuspendLayout();
            tlpusername.SuspendLayout();
            tlpbutton.SuspendLayout();
            tlpfrmDNADMIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tlpthan
            // 
            tlpthan.ColumnCount = 2;
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.91688F));
            tlpthan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.0831223F));
            tlpthan.Controls.Add(lbusername, 0, 0);
            tlpthan.Controls.Add(lbpassword, 0, 1);
            tlpthan.Controls.Add(tlppass, 1, 1);
            tlpthan.Controls.Add(tlpusername, 1, 0);
            tlpthan.Controls.Add(tlpbutton, 1, 2);
            tlpthan.Dock = DockStyle.Fill;
            tlpthan.Location = new Point(3, 117);
            tlpthan.Name = "tlpthan";
            tlpthan.RowCount = 4;
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpthan.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpthan.Size = new Size(794, 330);
            tlpthan.TabIndex = 2;
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Dock = DockStyle.Right;
            lbusername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbusername.Location = new Point(194, 0);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(112, 66);
            lbusername.TabIndex = 0;
            lbusername.Text = "Tên đăng nhập";
            lbusername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Dock = DockStyle.Right;
            lbpassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbpassword.Location = new Point(231, 66);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(75, 66);
            lbpassword.TabIndex = 3;
            lbpassword.Text = "Mật khẩu";
            lbpassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlppass
            // 
            tlppass.ColumnCount = 2;
            tlppass.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.3783226F));
            tlppass.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.62167F));
            tlppass.Controls.Add(btnPassword, 1, 0);
            tlppass.Controls.Add(txtpasswordnv, 0, 0);
            tlppass.Dock = DockStyle.Fill;
            tlppass.Location = new Point(312, 69);
            tlppass.Name = "tlppass";
            tlppass.RowCount = 1;
            tlppass.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlppass.Size = new Size(479, 60);
            tlppass.TabIndex = 7;
            // 
            // btnPassword
            // 
            btnPassword.Anchor = AnchorStyles.Left;
            btnPassword.Image = Properties.Resources.eye;
            btnPassword.Location = new Point(172, 12);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(60, 35);
            btnPassword.TabIndex = 6;
            btnPassword.UseVisualStyleBackColor = true;
            btnPassword.Click += btnPassword_Click_1;
            // 
            // txtpasswordnv
            // 
            txtpasswordnv.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtpasswordnv.Location = new Point(3, 16);
            txtpasswordnv.Name = "txtpasswordnv";
            txtpasswordnv.PasswordChar = '*';
            txtpasswordnv.Size = new Size(163, 27);
            txtpasswordnv.TabIndex = 4;
            txtpasswordnv.Text = "Nv!12345";
            // 
            // tlpusername
            // 
            tlpusername.ColumnCount = 2;
            tlpusername.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.3783226F));
            tlpusername.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.62167F));
            tlpusername.Controls.Add(txtusernv, 0, 0);
            tlpusername.Dock = DockStyle.Fill;
            tlpusername.Location = new Point(312, 3);
            tlpusername.Name = "tlpusername";
            tlpusername.RowCount = 1;
            tlpusername.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpusername.Size = new Size(479, 60);
            tlpusername.TabIndex = 8;
            // 
            // txtusernv
            // 
            txtusernv.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtusernv.Location = new Point(3, 16);
            txtusernv.Name = "txtusernv";
            txtusernv.Size = new Size(163, 27);
            txtusernv.TabIndex = 1;
            txtusernv.Text = "nv_phuc";
            // 
            // tlpbutton
            // 
            tlpbutton.ColumnCount = 2;
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.3783226F));
            tlpbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.62167F));
            tlpbutton.Controls.Add(btnlogin, 0, 0);
            tlpbutton.Controls.Add(btnexit, 1, 0);
            tlpbutton.Dock = DockStyle.Fill;
            tlpbutton.Location = new Point(312, 135);
            tlpbutton.Name = "tlpbutton";
            tlpbutton.RowCount = 1;
            tlpbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpbutton.Size = new Size(479, 76);
            tlpbutton.TabIndex = 9;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.DarkRed;
            btnlogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Image = Properties.Resources.login;
            btnlogin.Location = new Point(3, 3);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(112, 70);
            btnlogin.TabIndex = 0;
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.DarkRed;
            btnexit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.White;
            btnexit.Image = Properties.Resources.exit;
            btnexit.Location = new Point(172, 3);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(112, 70);
            btnexit.TabIndex = 0;
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // tlpfrmDNADMIN
            // 
            tlpfrmDNADMIN.ColumnCount = 1;
            tlpfrmDNADMIN.ColumnStyles.Add(new ColumnStyle());
            tlpfrmDNADMIN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpfrmDNADMIN.Controls.Add(lblognhanvien, 0, 1);
            tlpfrmDNADMIN.Controls.Add(tlpthan, 0, 2);
            tlpfrmDNADMIN.Controls.Add(pictureBox1, 0, 0);
            tlpfrmDNADMIN.Dock = DockStyle.Fill;
            tlpfrmDNADMIN.Location = new Point(0, 0);
            tlpfrmDNADMIN.Name = "tlpfrmDNADMIN";
            tlpfrmDNADMIN.RowCount = 3;
            tlpfrmDNADMIN.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6297112F));
            tlpfrmDNADMIN.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlpfrmDNADMIN.RowStyles.Add(new RowStyle(SizeType.Percent, 74.27938F));
            tlpfrmDNADMIN.Size = new Size(800, 450);
            tlpfrmDNADMIN.TabIndex = 1;
            // 
            // lblognhanvien
            // 
            lblognhanvien.AutoSize = true;
            lblognhanvien.Dock = DockStyle.Fill;
            lblognhanvien.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblognhanvien.Location = new Point(3, 74);
            lblognhanvien.Name = "lblognhanvien";
            lblognhanvien.Size = new Size(794, 40);
            lblognhanvien.TabIndex = 1;
            lblognhanvien.Text = "ĐĂNG NHẬP NHÂN VIÊN";
            lblognhanvien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // DangNhapNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpfrmDNADMIN);
            Name = "DangNhapNV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhapNV";
            Load += DangNhapNV_Load;
            tlpthan.ResumeLayout(false);
            tlpthan.PerformLayout();
            tlppass.ResumeLayout(false);
            tlppass.PerformLayout();
            tlpusername.ResumeLayout(false);
            tlpusername.PerformLayout();
            tlpbutton.ResumeLayout(false);
            tlpfrmDNADMIN.ResumeLayout(false);
            tlpfrmDNADMIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpthan;
        private Label lbusername;
        private TextBox txtusernv;
        private TextBox txtpasswordnv;
        private Label lbpassword;
        private Button btnlogin;
        private Button btnexit;
        private TableLayoutPanel tlpfrmDNADMIN;
        private Label lblognhanvien;
        private Button btnPassword;
        private TableLayoutPanel tlppass;
        private TableLayoutPanel tlpusername;
        private TableLayoutPanel tlpbutton;
        private PictureBox pictureBox1;
    }
}