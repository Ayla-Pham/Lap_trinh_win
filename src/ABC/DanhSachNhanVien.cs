using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace ABC
{
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
            this.Load += DanhSachNhanVien_Load;

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            cbbLoaiNhanVien.SelectedIndexChanged += cbbLoaiNhanVien_SelectedIndexChanged;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {

            ThemNhanVien themNhanVien = new ThemNhanVien();
            if (themNhanVien.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachNhanVien();
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // C#
            var row = dgvNhanVien.SelectedRows[0];
            string idCol = dgvNhanVien.Columns.Contains("Manv") ? "Manv"
                           : dgvNhanVien.Columns.Contains("Mand") ? "Mand"
                           : dgvNhanVien.Columns.Cast<DataGridViewColumn>().First().Name;
            string maNhanVien = row.Cells[idCol].Value?.ToString() ?? string.Empty;

            // Option B: use DataRowView to read by DataTable column names
            var drv = dgvNhanVien.SelectedRows[0].DataBoundItem as DataRowView;
            string ma = null;
            if (drv != null)
            {
                if (drv.DataView.Table.Columns.Contains("Manv")) ma = drv["Manv"]?.ToString();
                else if (drv.DataView.Table.Columns.Contains("Mand")) ma = drv["Mand"]?.ToString();
                else ma = drv.Row.ItemArray.FirstOrDefault()?.ToString();
            }

            SuaNhanVien suaNhanVien = new SuaNhanVien(maNhanVien);
            if (suaNhanVien.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachNhanVien();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            KhoiTaoComboBoxLoc();
            LoadDanhSachNhanVien();
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
            UIDataGridView.FormatDataGridView(dgvNhanVien);
        }
        private void KhoiTaoComboBoxLoc()
        {
            cbbLoaiNhanVien.Items.Clear();
            cbbLoaiNhanVien.Items.AddRange(new object[] { "Tất cả", "Admin", "NhanVien" });
            cbbLoaiNhanVien.SelectedIndex = 0;
        }

        private void LoadDanhSachNhanVien()
        {
            try
            {
                dgvNhanVien.DataSource = NhanVienBUS.LayDanhSachNhanVien();

                if (dgvNhanVien.Columns.Contains("Manv"))
                    dgvNhanVien.Columns["Manv"].HeaderText = "Mã nhân viên";
                if (dgvNhanVien.Columns.Contains("Tk"))
                    dgvNhanVien.Columns["Tk"].HeaderText = "Tài khoản";
                if (dgvNhanVien.Columns.Contains("Mk"))
                    dgvNhanVien.Columns["Mk"].HeaderText = "Mật khẩu";
                if (dgvNhanVien.Columns.Contains("Vitri"))
                    dgvNhanVien.Columns["Vitri"].HeaderText = "Vị trí";
                if (dgvNhanVien.Columns.Contains("Hoten"))
                    dgvNhanVien.Columns["Hoten"].HeaderText = "Họ tên";
                if (dgvNhanVien.Columns.Contains("Sdt"))
                    dgvNhanVien.Columns["Sdt"].HeaderText = "Số điện thoại";
                if (dgvNhanVien.Columns.Contains("Email"))
                    dgvNhanVien.Columns["Email"].HeaderText = "Email";
                if (dgvNhanVien.Columns.Contains("Ngsinh"))
                    dgvNhanVien.Columns["Ngsinh"].HeaderText = "Ngày sinh";
                if (dgvNhanVien.Columns.Contains("Diachi"))
                    dgvNhanVien.Columns["Diachi"].HeaderText = "Địa chỉ";
                if (dgvNhanVien.Columns.Contains("Luong"))
                    dgvNhanVien.Columns["Luong"].HeaderText = "Lương theo giờ";
                if (dgvNhanVien.Columns.Contains("Bank"))
                    dgvNhanVien.Columns["Bank"].HeaderText = "Bank";
                if (dgvNhanVien.Columns.Contains("Stk"))
                    dgvNhanVien.Columns["Stk"].HeaderText = "Số tài khoản";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThucHienTimKiemVaLoc()
        {
            string keyword = txtTimKiem.Text.Trim();
            string tieuChiLoc = cbbLoaiNhanVien.SelectedItem?.ToString();

            try
            {
                List<NhanVienGridDTO> dsKetQua = !string.IsNullOrEmpty(keyword)
                    ? NhanVienBUS.TimKiemNhanVien(keyword)
                    : NhanVienBUS.LayDanhSachNhanVien();

                if (tieuChiLoc != "Tất cả")
                    dsKetQua = dsKetQua.Where(nv => nv.Vitri == tieuChiLoc).ToList();

                dgvNhanVien.DataSource = dsKetQua;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện tìm kiếm/lọc: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiemVaLoc();
        }

        private void cbbLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThucHienTimKiemVaLoc();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cbbLoaiNhanVien.SelectedIndex = 0;
            LoadDanhSachNhanVien();
        }

        private void tlpTimKiem_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ThucHienXoaNhanVien(string maNhanVienCanXoa)
        {
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên có Mã NV: {maNhanVienCanXoa}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (NhanVienBUS.XoaNV(maNhanVienCanXoa))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại. Vui lòng kiểm tra ràng buộc hoặc kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var maNhanVienCell = dgvNhanVien.SelectedRows[0].Cells["Manv"];

            if (maNhanVienCell == null || maNhanVienCell.Value == null)
            {
                MessageBox.Show("Không tìm thấy Mã nhân viên để xóa. Vui lòng kiểm tra lại cấu trúc cột.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maNhanVienCanXoa = maNhanVienCell.Value.ToString();
            ThucHienXoaNhanVien(maNhanVienCanXoa);
        }
    }
}
