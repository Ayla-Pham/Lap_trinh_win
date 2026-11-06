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


namespace ABC
{
    public partial class LichSuTraHang : Form
    {
        private readonly TraHangBUS traHangBUS = new TraHangBUS();

        public LichSuTraHang()
        {
            InitializeComponent();
            LoadDanhSachTraHang();
            dgvDanhSachTraHang.SelectionChanged += DgvDanhSachTraHang_SelectionChanged;
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachTraHang(txtTimKiem.Text.Trim());
        }

        private void DgvDanhSachTraHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachTraHang.SelectedRows.Count > 0)
            {
                int matra = Convert.ToInt32(dgvDanhSachTraHang.SelectedRows[0].Cells["Matra"].Value);
                LoadChiTietTraHang(matra);
            }
            else
            {
                dgvChiTietTraHang.DataSource = null;
            }
        }

        private void LoadDanhSachTraHang(string tuKhoa = "")
        {
            dgvDanhSachTraHang.DataSource = traHangBUS.GetDanhSachPhieuTra(tuKhoa);

            // Tùy chỉnh hiển thị
            dgvDanhSachTraHang.Columns["Matra"].HeaderText = "Mã Trả";
            dgvDanhSachTraHang.Columns["Ngaytra"].HeaderText = "Ngày Trả";
            dgvDanhSachTraHang.Columns["TenNhanVien"].HeaderText = "Nhân Viên";
            dgvDanhSachTraHang.Columns["Makh"].Visible = false;
            dgvDanhSachTraHang.Columns["Tenkh"].HeaderText = "Khách Hàng";
            dgvDanhSachTraHang.Columns["Lydotra"].HeaderText = "Lý Do Trả";
            dgvDanhSachTraHang.Columns["TongTien"].HeaderText = "Tổng Tiền HD";
        }

        private void LoadChiTietTraHang(int matra)
        {
            dgvChiTietTraHang.DataSource = traHangBUS.GetChiTietPhieuTra(matra);

            dgvChiTietTraHang.Columns["Masp"].HeaderText = "Mã SP";
            dgvChiTietTraHang.Columns["Tensp"].HeaderText = "Tên SP";
            dgvChiTietTraHang.Columns["Soluong"].HeaderText = "Số Lượng";
            dgvChiTietTraHang.Columns["Dongia"].HeaderText = "Đơn Giá";
            dgvChiTietTraHang.Columns["ThanhTien"].HeaderText = "Thành Tiền";
        }

        private void LichSuTraHang_Load(object sender, EventArgs e)
        {
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
            UIDataGridView.FormatDataGridView(dgvChiTietTraHang);
            UIDataGridView.FormatDataGridView(dgvDanhSachTraHang);
        }
    }
}
