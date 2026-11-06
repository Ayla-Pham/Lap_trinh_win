using System;
using System.Data;
using System.Windows.Forms;
using BUS;

namespace ABC
{
    public partial class TraHang : Form
    {
        private readonly TraHangBUS traHangBUS = new TraHangBUS();

        public TraHang()
        {
            InitializeComponent();
            LoadHoaDon(); // Load danh sách hóa đơn khi mở form
        }

        // Load danh sách hóa đơn
        private void LoadHoaDon(string tuKhoa = "")
        {
            dgvHoaDon.DataSource = traHangBUS.GetDanhSachHoaDon(tuKhoa);
        }

        // Khi chọn 1 hóa đơn
        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            // Chi tiết hóa đơn / trả hàng hiện chưa hiển thị trên giao diện
        }

        // Tìm kiếm hóa đơn
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadHoaDon(txtTimKiem.Text.Trim());
        }

        // Thực hiện trả hàng
        private void btnTraHang_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để trả hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int mahd = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells["Mahd"].Value);
            string lyDo = txtLyDo.Text.Trim();
            string manv = "NV01"; // Có thể lấy từ login hiện tại

            if (string.IsNullOrEmpty(lyDo))
            {
                MessageBox.Show("Vui lòng nhập lý do trả hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                traHangBUS.TraToanBoHoaDon(mahd, manv, lyDo);
                MessageBox.Show("Trả hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadHoaDon();
                txtLyDo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) { }
        private void dgvChiTietTraHang_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblLyDo_Click(object sender, EventArgs e) { }
        private void txtLyDo_TextChanged(object sender, EventArgs e) { }

        private void tlpContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
