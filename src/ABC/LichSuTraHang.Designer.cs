namespace ABC
{
    partial class LichSuTraHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSachTraHang;
        private System.Windows.Forms.DataGridView dgvChiTietTraHang;

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
            tlpMain = new System.Windows.Forms.TableLayoutPanel();
            lblTimKiem = new System.Windows.Forms.Label();
            txtTimKiem = new System.Windows.Forms.TextBox();
            dgvDanhSachTraHang = new System.Windows.Forms.DataGridView();
            dgvChiTietTraHang = new System.Windows.Forms.DataGridView();
            tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTraHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietTraHang).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMain.Controls.Add(lblTimKiem, 0, 0);
            tlpMain.Controls.Add(txtTimKiem, 0, 1);
            tlpMain.Controls.Add(dgvDanhSachTraHang, 0, 2);
            tlpMain.Controls.Add(dgvChiTietTraHang, 0, 3);
            tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMain.Location = new System.Drawing.Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpMain.Size = new System.Drawing.Size(800, 450);
            tlpMain.TabIndex = 0;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTimKiem.Location = new System.Drawing.Point(3, 0);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new System.Drawing.Size(794, 25);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm theo mã trả hàng / nhân viên / khách hàng:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTimKiem.Location = new System.Drawing.Point(3, 28);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(794, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // dgvDanhSachTraHang
            // 
            dgvDanhSachTraHang.AllowUserToAddRows = false;
            dgvDanhSachTraHang.AllowUserToDeleteRows = false;
            dgvDanhSachTraHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachTraHang.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDanhSachTraHang.Location = new System.Drawing.Point(3, 58);
            dgvDanhSachTraHang.MultiSelect = false;
            dgvDanhSachTraHang.Name = "dgvDanhSachTraHang";
            dgvDanhSachTraHang.ReadOnly = true;
            dgvDanhSachTraHang.RowHeadersWidth = 51;
            dgvDanhSachTraHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachTraHang.Size = new System.Drawing.Size(794, 191);
            dgvDanhSachTraHang.TabIndex = 2;
            // 
            // dgvChiTietTraHang
            // 
            dgvChiTietTraHang.AllowUserToAddRows = false;
            dgvChiTietTraHang.AllowUserToDeleteRows = false;
            dgvChiTietTraHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietTraHang.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvChiTietTraHang.Location = new System.Drawing.Point(3, 255);
            dgvChiTietTraHang.MultiSelect = false;
            dgvChiTietTraHang.Name = "dgvChiTietTraHang";
            dgvChiTietTraHang.ReadOnly = true;
            dgvChiTietTraHang.RowHeadersWidth = 51;
            dgvChiTietTraHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietTraHang.Size = new System.Drawing.Size(794, 192);
            dgvChiTietTraHang.TabIndex = 3;
            // 
            // LichSuTraHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tlpMain);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Text = "Lịch Sử Trả Hàng";
            Load += LichSuTraHang_Load;
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachTraHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietTraHang).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
