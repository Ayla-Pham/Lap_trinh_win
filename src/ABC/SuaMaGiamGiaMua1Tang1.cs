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
    public partial class SuaMaGiamGiaMua1Tang1 : Form
    {
        public event EventHandler VoucherUpdated;
        public SuaMaGiamGiaMua1Tang1()
        {
            InitializeComponent();
        }
        private int mavc;

        public SuaMaGiamGiaMua1Tang1(int mavc)
        {
            InitializeComponent();
            this.mavc = mavc;
        }
        private void LoadSanPhamTang()
        {
            dgvSanPhamTang.DataSource = Voucher1tang1BUS.Instance.TimSanPhamTang("");
            if (dgvSanPhamTang.Columns.Contains("Masp"))
                dgvSanPhamTang.Columns["Masp"].HeaderText = "Mã sản phẩm";

            if (dgvSanPhamTang.Columns.Contains("Tensp"))
                dgvSanPhamTang.Columns["Tensp"].HeaderText = "Tên sản phẩm";

            // Kích cỡ (kichco) removed from model — do not refer to it anymore.
        }
        private void LoadLoaiMaGiamGia1Tang1()
        {
            cbbLoaiMaGiamGia.Items.Clear();
            cbbLoaiMaGiamGia.Items.Add("Mua 1 tặng 1 cùng dòng"); // Maloaivc = 2
            cbbLoaiMaGiamGia.Items.Add("Mua 1 tặng 1 bất kỳ");    // Maloaivc = 4
            cbbLoaiMaGiamGia.SelectedIndex = -1;
        }
        private void LoadLoaiSanPhamMua()
        {
            var dsLoaiSP = DanhSachSanPhamBUS.Instance.GetLoaiSanPham();
            cbbSanPhamMua.DataSource = dsLoaiSP;
            cbbSanPhamMua.DisplayMember = "TenLoai";
            cbbSanPhamMua.ValueMember = "MaLoai";
            cbbSanPhamMua.SelectedIndex = -1;
        }
        private void SuaMaGiamGiaMua1Tang1_Load(object sender, EventArgs e)
        {
            LoadLoaiMaGiamGia1Tang1();
            LoadLoaiSanPhamMua();
            LoadSanPhamTang();


            // Load dữ liệu voucher
            var row = Voucher1tang1BUS.Instance.GetVoucherByID(mavc);
            if (row != null)
            {
                txtMaGiamGia.Text = row.Code;
                txtTenMaGiamGia.Text = row.TenMaGiamGia ?? "";
                txtHoaDonToiThieu.Text = row.DieuKien?.ToString() ?? "";
                cbbSanPhamMua.SelectedValue = row.Maloai ?? -1;

                int loaiVC = row.Maloaivc;
                cbbLoaiMaGiamGia.SelectedIndex = (loaiVC == 2) ? 0 : 1;

                // Nếu là loại 4 thì load sản phẩm tặng đã chọn (match by masp only; sizes removed)
                if (loaiVC == 4)
                {
                    var dsTang = Voucher1tang1BUS.Instance.GetSanPhamTangByVoucher(mavc);

                    // Tập mã sản phẩm đã được chọn cho voucher
                    var maspSet = new HashSet<string>(
                        dsTang.Select(d => d.Masp.ToString()),
                        StringComparer.OrdinalIgnoreCase);

                    foreach (DataGridViewRow r in dgvSanPhamTang.Rows)
                    {
                        string masp = r.Cells["Masp"].Value?.ToString() ?? "";
                        if (!string.IsNullOrEmpty(masp) && maspSet.Contains(masp))
                        {
                            r.Selected = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã giảm giá cần sửa.");
                this.Close();
            }
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
            UIDataGridView.FormatDataGridView(dgvSanPhamTang);
        }
        private bool KiemTraDuLieuSuaVoucher1Tang1(
            out string message,
            out string code,
            out string ten,
            out int loaiVC,
            out int maloai,
            out decimal dieuKien,
            out List<int> dsTang)
        {
            message = "";
            code = txtMaGiamGia.Text.Trim();
            ten = txtTenMaGiamGia.Text.Trim();
            dsTang = new List<int>();
            loaiVC = 0;
            maloai = 0;
            dieuKien = 0;

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(ten))
            {
                message = "Vui lòng nhập đầy đủ mã và tên mã giảm giá.";
                return false;
            }

            if (code.Length > 50 || !System.Text.RegularExpressions.Regex.IsMatch(code, @"^[a-zA-Z0-9]+$"))
            {
                message = "Mã giảm giá không hợp lệ. Chỉ chứa chữ và số, tối đa 50 ký tự.";
                return false;
            }
            if (Voucher1tang1BUS.Instance.CheckCodeExists(code, mavc))
            {
                message = "Mã giảm giá đã tồn tại. Vui lòng chọn mã khác.";
                return false;
            }

            if (ten.Length > 100)
            {
                message = "Tên mã giảm giá không được vượt quá 100 ký tự.";
                return false;
            }

            if (cbbLoaiMaGiamGia.SelectedIndex == -1 || cbbSanPhamMua.SelectedIndex == -1)
            {
                message = "Vui lòng chọn loại mã và loại sản phẩm mua.";
                return false;
            }

            loaiVC = cbbLoaiMaGiamGia.SelectedIndex == 0 ? 2 : 4;
            maloai = Convert.ToInt32(cbbSanPhamMua.SelectedValue);

            if (!decimal.TryParse(txtHoaDonToiThieu.Text.Trim(), out dieuKien))
            {
                message = "Giá trị hóa đơn tối thiểu không hợp lệ.";
                return false;
            }

            if (dieuKien <= 0)
            {
                message = "Giá trị hóa đơn tối thiểu phải lớn hơn 0.";
                return false;
            }
            DateTime ngaybd = DateTime.Today;
            DateTime ngaykt = DateTime.Today;

            if (dtpNgayBatDau.Value.Date < DateTime.Today)
            {
                message = "Ngày bắt đầu không được nhỏ hơn ngày hiện tại.";
                return false;
            }

            if (dtpNgayHetHan.Value.Date <= dtpNgayBatDau.Value.Date)
            {
                message = "Ngày kết thúc phải sau ngày bắt đầu.";
                return false;
            }

            // SelectedRows may include multiple; sizes removed so match by masp -> resolve to numeric Masp
            foreach (DataGridViewRow row in dgvSanPhamTang.SelectedRows)
            {
                string masp = row.Cells["Masp"].Value?.ToString();

                if (string.IsNullOrEmpty(masp))
                {
                    message = "Thiếu thông tin sản phẩm tặng.";
                    return false;
                }

                if (loaiVC == 2)
                {
                    if (!dgvSanPhamTang.Columns.Contains("Maloai") || row.Cells["Maloai"].Value == null)
                    {
                        message = $"Thiếu thông tin loại sản phẩm cho '{masp}'.";
                        return false;
                    }

                    int maloaiSP = Convert.ToInt32(row.Cells["Maloai"].Value);
                    if (maloaiSP != maloai)
                    {
                        message = $"Sản phẩm tặng '{masp}' không cùng dòng với sản phẩm mua đã chọn.";
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

            if (dsTang.Count == 0)
            {
                message = "Vui lòng chọn ít nhất một sản phẩm tặng.";
                return false;
            }

            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuSuaVoucher1Tang1(
            out string message,
            out string code,
            out string ten,
            out int loaiVC,
            out int maloai,
            out decimal dieuKien,
            out List<int> dsTang))
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool ok = Voucher1tang1BUS.Instance.CapNhatVoucher(mavc, code, ten, loaiVC, maloai, dieuKien, dsTang);
                MessageBox.Show(ok ? "Cập nhật mã giảm giá thành công!" : "Cập nhật thất bại!");
                if (ok)
                {
                    VoucherUpdated?.Invoke(this, EventArgs.Empty); // ✅ báo cho form cha
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void cbbLoaiMaGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
