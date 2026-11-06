using DAO;
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
    public partial class XemSanPhamNhanVien : Form
    {
        private List<SanPhamXemDTO> dsSanPham = new List<SanPhamXemDTO>();

        public XemSanPhamNhanVien()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvSanPham.DataSource = dsSanPham
                .Where(sp => sp.TenSP.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                          || sp.MaSP.ToString().Contains(keyword))
                .ToList();

        }

        private void XemSanPhamNhanVien_Load(object sender, EventArgs e)
        {
            dsSanPham = DanhSachSanPhamBUS.Instance.GetSanPhamWithVoucher();
            dgvSanPham.DataSource = dsSanPham;
            SetupDataGridView();
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
            UIDataGridView.FormatDataGridView(dgvSanPham);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetupDataGridView()
        {
            var columns = dgvSanPham.Columns;

            // Đổi tên hiển thị cột sang tiếng Việt
            if (columns.Contains("MaSP"))
                columns["MaSP"].HeaderText = "Mã sản phẩm";
            if (columns.Contains("TenSP"))
                columns["TenSP"].HeaderText = "Tên sản phẩm";
            if (columns.Contains("TenLoai"))
                columns["TenLoai"].HeaderText = "Loại";
            if (columns.Contains("GiaBan"))
                columns["GiaBan"].HeaderText = "Giá bán";
            if (columns.Contains("SoLuongTon"))
                columns["SoLuongTon"].HeaderText = "Tồn kho";
            if (columns.Contains("TrangThai"))
                columns["TrangThai"].HeaderText = "Trạng thái";
            if (columns.Contains("CanhBaoTon"))
                columns["CanhBaoTon"].HeaderText = "Cảnh báo tồn kho";
            if (columns.Contains("Maloai"))
                columns["Maloai"].HeaderText = "Mã loại";

            // Ẩn cột hình ảnh đường dẫn
            if (columns.Contains("DuongDanAnh"))
                columns["DuongDanAnh"].Visible = false;
        }
        private void tlpTimKiem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
