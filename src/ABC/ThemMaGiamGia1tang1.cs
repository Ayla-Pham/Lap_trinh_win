using BUS;
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

namespace ABC
{
    public partial class ThemMaGiamGia1tang1 : Form
    {
        public ThemMaGiamGia1tang1()
        {
            InitializeComponent();
        }
        public event EventHandler VoucherUpdated;

        private void LoadSanPhamTang()
        {
            dgvSanPham.DataSource = Voucher1tang1BUS.Instance.TimSanPhamTang("");
            if (dgvSanPham.Columns.Contains("Masp"))
                dgvSanPham.Columns["Masp"].HeaderText = "Mã sản phẩm";
            if (dgvSanPham.Columns.Contains("Tensp"))
                dgvSanPham.Columns["Tensp"].HeaderText = "Tên sản phẩm";
        }

        private void ThemMaGiamGia1tang1_Load(object sender, EventArgs e)
        {
            // Load loại mã
            cbbLoaiMa.Items.Add("Mua 1 tặng 1 cùng dòng");
            cbbLoaiMa.Items.Add("Mua 1 tặng 1 bất kỳ");
            cbbLoaiMa.SelectedIndex = 0;

            // Load loại sản phẩm mua
            var dsLoaiSP = DanhSachSanPhamBUS.Instance.GetLoaiSanPham();
            cbbSanPhamMua.DisplayMember = "TenLoai";
            cbbSanPhamMua.ValueMember = "MaLoai";
            cbbSanPhamMua.DataSource = dsLoaiSP;
            cbbLoaiMa_SelectedIndexChanged(null, null);

            // Format giao diện
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
            UIDataGridView.FormatDataGridView(dgvSanPham);

            if (dgvSanPham.Columns.Contains("Masp"))
                dgvSanPham.Columns["Masp"].HeaderText = "Mã sản phẩm";

            if (dgvSanPham.Columns.Contains("Tensp"))
                dgvSanPham.Columns["Tensp"].HeaderText = "Tên sản phẩm";

            // do not try to access 'kichco' column — it no longer exists
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvSanPham.DataSource = Voucher1tang1BUS.Instance.TimSanPhamTang(keyword);
        }

        private void cbbLoaiMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int loaiVC = cbbLoaiMa.SelectedIndex == 0 ? 2 : 4;

            if (loaiVC == 2) // Mua 1 tặng 1 cùng dòng
            {
                if (cbbSanPhamMua.SelectedValue != null && int.TryParse(cbbSanPhamMua.SelectedValue.ToString(), out int maloai))
                {
                    dgvSanPham.DataSource = Voucher1tang1BUS.Instance.TimSanPhamTangTheoLoai(maloai);
                    if (dgvSanPham.Columns.Contains("Maloai"))
                    {
                        dgvSanPham.Columns["Maloai"].Visible = false;
                    }
                }
                else
                {
                    dgvSanPham.DataSource = null;
                    return;
                }
            }
            else // Mua 1 tặng 1 bất kỳ
            {
                LoadSanPhamTang();
            }

            dgvSanPham.Enabled = true;
        }

        private bool KiemTraDuLieuVoucher1Tang1(
            out string ma,
            out string ten,
            out int maloai,
            out int loaiVC,
            out DateTime ngaybd,
            out DateTime ngaykt,
            out decimal dieuKien,
            out List<int> dsTang,
            out string message)
        {
            ma = txtMaGG.Text.Trim();
            ten = txtTenMaGiamGia.Text.Trim();
            ngaybd = dTPBatDau.Value.Date;
            ngaykt = dTPHetHan.Value.Date;
            maloai = cbbSanPhamMua.SelectedValue != null ? Convert.ToInt32(cbbSanPhamMua.SelectedValue) : -1;
            loaiVC = cbbLoaiMa.SelectedIndex == 0 ? 2 : 4;
            dieuKien = 0;
            dsTang = new List<int>();
            message = "";

            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            {
                message = "Vui lòng nhập đầy đủ mã và tên mã giảm giá.";
                return false;
            }

            if (ma.Length > 20 || !System.Text.RegularExpressions.Regex.IsMatch(ma, @"^[a-zA-Z0-9]+$"))
            {
                message = "Mã giảm giá không hợp lệ. Chỉ chứa chữ và số, tối đa 20 ký tự.";
                return false;
            }

            if (Voucher1tang1BUS.Instance.CheckCodeExists(ma))
            {
                message = "Mã giảm giá đã tồn tại. Vui lòng chọn mã khác.";
                return false;
            }

            if (ten.Length > 100)
            {
                message = "Tên mã giảm giá không được vượt quá 100 ký tự.";
                return false;
            }

            if (ngaybd < DateTime.Today || ngaykt < ngaybd)
            {
                message = "Ngày bắt đầu và kết thúc không hợp lệ.";
                return false;
            }

            string input = txtGiaTriToiThieu.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                if (!decimal.TryParse(input, out dieuKien))
                {
                    message = "Giá trị tối thiểu không hợp lệ.";
                    return false;
                }

                if (dieuKien <= 0)
                {
                    message = "Giá trị tối thiểu phải lớn hơn 0.";
                    return false;
                }
            }

            if (dgvSanPham.SelectedRows.Count == 0)
            {
                message = "Vui lòng chọn ít nhất một sản phẩm tặng.";
                return false;
            }

            foreach (DataGridViewRow row in dgvSanPham.SelectedRows)
            {
                string masp = row.Cells["Masp"].Value?.ToString();

                if (string.IsNullOrEmpty(masp))
                {
                    message = "Thiếu thông tin mã sản phẩm tặng.";
                    return false;
                }

                if (loaiVC == 2)
                {
                    if (!dgvSanPham.Columns.Contains("Maloai") || row.Cells["Maloai"].Value == null)
                    {
                        message = $"Thiếu thông tin loại sản phẩm cho '{masp}'.";
                        return false;
                    }

                    int maloaiSP = Convert.ToInt32(row.Cells["Maloai"].Value);
                    if (maloaiSP != maloai)
                    {
                        message = $"Sản phẩm tặng '{masp}' không cùng dòng với sản phẩm mua.";
                        return false;
                    }
                }

                // Resolve Masp (numeric id) from MaSP string and validate existence
                int maspId = Voucher1tang1DAO.Instance.GetMasp(masp);
                if (maspId <= 0)
                {
                    message = $"Không tìm thấy sản phẩm tặng '{masp}' trong hệ thống.";
                    return false;
                }

                dsTang.Add(maspId);
            }

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuVoucher1Tang1(
            out string ma,
            out string ten,
            out int maloai,
            out int loaiVC,
            out DateTime ngaybd,
            out DateTime ngaykt,
            out decimal dieuKien,
            out List<int> dsTang,
            out string message))
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool ok = Voucher1tang1BUS.Instance.ThemVoucher(ma, ten, loaiVC, maloai, dieuKien, ngaybd, ngaykt, dsTang);

                if (ok)
                {
                    MessageBox.Show("Thêm mã giảm giá thành công!");
                    VoucherUpdated?.Invoke(this, EventArgs.Empty); //  báo cho form cha
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại! Có thể do lỗi khi thêm sản phẩm tặng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtGiaTriToiThieu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbbSanPhamMua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiMa.SelectedIndex == 0) // Nếu đang chọn loại 2
            {
                if (cbbSanPhamMua.SelectedValue != null && int.TryParse(cbbSanPhamMua.SelectedValue.ToString(), out int maloai))
                {
                    dgvSanPham.DataSource = Voucher1tang1BUS.Instance.TimSanPhamTangTheoLoai(maloai);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
