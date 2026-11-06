using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class QuanLiMAGIAMGIA : Form
    {
        public string MaGiamGiaDuocChon { get; private set; }
        private bool isChonMa = false;
        private string maND;
        public QuanLiMAGIAMGIA()
        {
            InitializeComponent();
            this.isChonMa = false;
            this.maND = CurrentUser.Manv ?? "";

        }
        public QuanLiMAGIAMGIA(bool chonMa, string maND)
        {
            InitializeComponent();
            this.isChonMa = chonMa;
            this.maND = maND ?? "";

        }
        void SetColumnHeader(string columnName, string headerText)
        {
            if (dgvMaGiamGia.Columns.Contains(columnName))
            {
                dgvMaGiamGia.Columns[columnName].HeaderText = headerText;
            }
        }
        private List<VoucherHienThiDTO> dsVoucher = new List<VoucherHienThiDTO>();

        public void LoadVouchers()
        {

            dsVoucher = VoucherBUS.Instance.GetAllVouchersWithJoin();
            dgvMaGiamGia.DataSource = dsVoucher;
            SetAllColumnHeaders();
        }
        private void LoadVoucherTypes()
        {
            cbbLoaiVoucher.DataSource = VoucherBUS.Instance.GetVoucherTypes();
            cbbLoaiVoucher.DisplayMember = "Tenloai";
            cbbLoaiVoucher.ValueMember = "Maloaivc";
            cbbLoaiVoucher.SelectedIndex = -1;
        }

        private void btnThemMaGiamGia_Click(object sender, EventArgs e)
        {
            ThemMaGiamGia form = new ThemMaGiamGia();
            form.VoucherUpdated += (s, e) => LoadVouchers(); // ✅ gắn sự kiện
            form.ShowDialog();

        }

        private void QuanLiMAGIAMGIA_Load(object sender, EventArgs e)
        {
            LoadVoucherTypes();
            LoadVouchers();
            UIDataGridView.FormatDataGridView(dgvMaGiamGia);
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
            btnApDung.Visible = isChonMa;
            if (!string.IsNullOrEmpty(maND) && maND.StartsWith("NV"))
            {
                btnThemMaGiamGia.Visible = false;
                btnSuaMaGiamGia.Visible = false;
                btnSuaMaGiamGia1tang1.Visible = false;
                btnXoa.Visible = false;
            }

        }

        private void btnSuaMaGiamGia_Click(object sender, EventArgs e)
        {
            if (dgvMaGiamGia.SelectedRows.Count > 0)
            {
                int mavc = Convert.ToInt32(dgvMaGiamGia.SelectedRows[0].Cells["Mavc"].Value);
                int maloaivc = Convert.ToInt32(dgvMaGiamGia.SelectedRows[0].Cells["Maloaivc"].Value);

                if (maloaivc == 1 || maloaivc == 3)
                {
                    SuaMaGiamGia form = new SuaMaGiamGia(mavc);
                    form.VoucherUpdated += (s, e) => LoadVouchers(); //  gắn sự kiện
                    form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Mã này không phải loại 'Giảm theo %' hoặc 'Giảm theo giá trị thực'.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã cần sửa.");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvMaGiamGia.DataSource = dsVoucher
                .Where(v => v.Code.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

        }

        private void dgvMaGiamGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetAllColumnHeaders()
        {
            SetColumnHeader("Mavc", "Id");
            SetColumnHeader("Code", "Mã giảm giá");
            SetColumnHeader("TenMaGiamGia", "Tên mã giảm giá");
            SetColumnHeader("Giatri", "Giá trị giảm");
            SetColumnHeader("Ngaybd", "Ngày bắt đầu");
            SetColumnHeader("Ngaykt", "Ngày kết thúc");
            SetColumnHeader("DieuKien", "Đơn tối thiểu");
            SetColumnHeader("Maloaivc", "Loại mã");
            SetColumnHeader("Maloai", "Mã loại sản phẩm mua");
            SetColumnHeader("TenLoaiVouCher", "Tên loại mã giảm giá");
            SetColumnHeader("TenLoaiSanPhamApDung", "Loại Sản phẩm áp dụng");
            SetColumnHeader("TenLoaiSanPhamTang", "Loại Sản phẩm tặng");
            SetColumnHeader("SanPhamApDung", "Sản phẩm áp dụng");
            SetColumnHeader("SanPhamTang", "Sản phẩm tặng");
        }
        private void cbbLoaiVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiVoucher.SelectedIndex != -1)
            {
                int maloaivc = ((LoaiVoucherDTO)cbbLoaiVoucher.SelectedItem).Maloaivc;
                dsVoucher = VoucherBUS.Instance.GetVouchersByTypeWithJoin(maloaivc);
                dgvMaGiamGia.DataSource = dsVoucher;

                SetAllColumnHeaders(); // cập nhật lại tiêu đề cột
            }

        }

        private void tlpall_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMaGiamGia.SelectedRows.Count > 0)
            {
                int mavc = Convert.ToInt32(dgvMaGiamGia.SelectedRows[0].Cells["Mavc"].Value);
                string code = dgvMaGiamGia.SelectedRows[0].Cells["Code"].Value.ToString();

                var confirm = MessageBox.Show($"Bạn có chắc muốn xóa mã giảm giá '{code}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    bool success = VoucherBUS.Instance.DeleteVoucher(mavc);
                    MessageBox.Show(success ? "Xóa thành công!" : "Xóa thất bại!");
                    if (success) LoadVouchers();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã giảm giá cần xóa.");
            }

        }

        private void btnSuaMaGiamGia1tang1_Click(object sender, EventArgs e)
        {
            if (dgvMaGiamGia.SelectedRows.Count > 0)
            {
                int mavc = Convert.ToInt32(dgvMaGiamGia.SelectedRows[0].Cells["Mavc"].Value);
                int maloaivc = Convert.ToInt32(dgvMaGiamGia.SelectedRows[0].Cells["Maloaivc"].Value);

                if (maloaivc == 2 || maloaivc == 4)
                {
                    SuaMaGiamGiaMua1Tang1 form = new SuaMaGiamGiaMua1Tang1(mavc);
                    form.VoucherUpdated += (s, e) => LoadVouchers(); //  gắn sự kiện
                    form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Mã này không phải loại mua 1 tặng 1.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã cần sửa.");
            }

        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            if (dgvMaGiamGia.CurrentRow != null)
            {
                MaGiamGiaDuocChon = dgvMaGiamGia.CurrentRow.Cells["code"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mã giảm giá để áp dụng.");
            }

        }
    }
}
