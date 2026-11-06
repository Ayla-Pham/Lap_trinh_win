using BUS;
using DAO;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ABC
{
    public partial class SuaMaGiamGia : Form
    {
        public event EventHandler VoucherUpdated;
        public SuaMaGiamGia()
        {
            InitializeComponent();
        }
        private int mavc;

        public SuaMaGiamGia(int mavc)
        {
            InitializeComponent();
            this.mavc = mavc;
        }

        private void btnSuaMaGiamGiaMua1Tang1_Click(object sender, EventArgs e)
        {
        }

        private void SuaMaGiamGia_Load(object sender, EventArgs e)
        {
            // Giới hạn phần trăm giảm
            numGiaTriGiamTheoPT.Minimum = 0;
            numGiaTriGiamTheoPT.Maximum = 100;

            // Load dữ liệu các control
            LoadLoaiMaGG();
            LoadLoaiSanPham();
            LoadSanPham();

            // Lấy thông tin mã giảm giá cần sửa
            var voucher = VoucherBUS.Instance.GetVoucherByID(mavc);
            if (voucher == null)
            {
                MessageBox.Show("Không tìm thấy mã giảm giá cần sửa.");
                this.Close();
                return;
            }

            // Gán dữ liệu lên form
            txtMaGiamGia.Text = voucher.Code;
            txtTenMaGiamGia.Text = voucher.TenMaGiamGia;
            dtpNgayBatDau.Value = voucher.Ngaybd;
            dtpNgayHetHan.Value = voucher.Ngaykt;
            txtGiaTriDonHangToiThieu.Text = voucher.DieuKien?.ToString() ?? "";
            cbbLoaiMaGiamGia.SelectedValue = voucher.Maloaivc;
            cbbLoaiSanPham.SelectedValue = voucher.Maloai ?? -1;

            // Hiển thị đúng control giá trị giảm
            if (voucher.Maloaivc == 1) // Giảm theo %
            {
                if (voucher.Giatri > numGiaTriGiamTheoPT.Maximum)
                {
                    MessageBox.Show($"Giá trị phần trăm giảm vượt quá giới hạn ({numGiaTriGiamTheoPT.Maximum}%).");
                    this.Close();
                    return;
                }

                numGiaTriGiamTheoPT.Value = voucher.Giatri;
                numGiaTriGiamTheoPT.Visible = true;
                txtGiaTriGiam.Visible = false;
            }
            else if (voucher.Maloaivc == 3) // Giảm theo giá trị thực
            {
                txtGiaTriGiam.Text = voucher.Giatri.ToString();
                txtGiaTriGiam.Visible = true;
                numGiaTriGiamTheoPT.Visible = false;
            }
            else
            {
                MessageBox.Show("Chỉ hỗ trợ sửa mã giảm giá loại phần trăm hoặc giá trị thực.");
                this.Close();
                return;
            }

            // Gán sản phẩm áp dụng (mỗi phần tử trong chiTiet là Masp)
            var chiTiet = DanhSachSanPhamBUS.Instance.GetChiTietVoucher(mavc);
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (dgvSanPham.Columns.Contains("Masp") && row.Cells["Masp"].Value != null && int.TryParse(row.Cells["Masp"].Value.ToString(), out int masp))
                {
                    if (chiTiet.Contains(masp))
                        row.Selected = true;
                }
            }

            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
            UIDataGridView.FormatDataGridView(dgvSanPham);
        }
        private void LoadLoaiMaGG()
        {
            // Chỉ lấy loại mã 1 (giảm %) và 3 (giảm theo giá trị thực)
            var dsLoai = VoucherBUS.Instance.GetVoucherTypes()
                .Where(l => l.Maloaivc == 1 || l.Maloaivc == 3)
                .ToList();

            cbbLoaiMaGiamGia.DataSource = dsLoai;
            cbbLoaiMaGiamGia.DisplayMember = "Tenloai";
            cbbLoaiMaGiamGia.ValueMember = "Maloaivc";
            cbbLoaiMaGiamGia.SelectedIndex = -1;

        }
        private void LoadLoaiSanPham()
        {
            cbbLoaiSanPham.DataSource = DanhSachSanPhamBUS.Instance.GetLoaiSanPham();
            cbbLoaiSanPham.DisplayMember = "TenLoai";
            cbbLoaiSanPham.ValueMember = "MaLoai";
            cbbLoaiSanPham.SelectedIndex = -1;
        }
        private void LoadSanPham()
        {
            dgvSanPham.DataSource = DanhSachSanPhamBUS.Instance.GetAllSanPham();

            if (dgvSanPham.Columns.Contains("Masp"))
                dgvSanPham.Columns["Masp"].HeaderText = "ID";

            if (dgvSanPham.Columns.Contains("MaSP"))
                dgvSanPham.Columns["MaSP"].HeaderText = "Mã SP";

            if (dgvSanPham.Columns.Contains("TenSP"))
                dgvSanPham.Columns["TenSP"].HeaderText = "Tên sản phẩm";

            if (dgvSanPham.Columns.Contains("GiaBan"))
                dgvSanPham.Columns["GiaBan"].HeaderText = "Giá bán";

            foreach (DataGridViewColumn col in dgvSanPham.Columns)
            {
                if (col.Name != "Masp" && col.Name != "MaSP" && col.Name != "TenSP" && col.Name != "GiaBan")
                {
                    col.Visible = false;
                }
            }
        }

        private bool KiemTraDuLieuVoucherSua(out string message, out VoucherDTO dto, out List<int> maspList)
        {
            message = "";
            dto = null;
            maspList = new List<int>();

            string code = txtMaGiamGia.Text.Trim();
            string tenMa = txtTenMaGiamGia.Text.Trim();
            DateTime ngaybd = dtpNgayBatDau.Value.Date;
            DateTime ngaykt = dtpNgayHetHan.Value.Date;

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(tenMa))
            {
                message = "Vui lòng nhập đầy đủ mã và tên mã giảm giá.";
                return false;
            }

            if (code.Length > 50)
            {
                message = "Mã giảm giá không được vượt quá 50 ký tự.";
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(code, @"^[a-zA-Z0-9]+$"))
            {
                message = "Mã giảm giá chỉ được chứa chữ và số, không có ký tự đặc biệt.";
                return false;
            }

            if (VoucherBUS.Instance.CheckCodeExists(code, mavc))
            {
                message = "Mã giảm giá đã tồn tại. Vui lòng chọn mã khác.";
                return false;
            }

            if (tenMa.Length > 100)
            {
                message = "Tên mã giảm giá không được vượt quá 100 ký tự.";
                return false;
            }

            if (ngaybd < DateTime.Today)
            {
                message = "Ngày bắt đầu không được nhỏ hơn ngày hiện tại.";
                return false;
            }

            if (ngaykt <= ngaybd)
            {
                message = "Ngày kết thúc phải sau ngày bắt đầu.";
                return false;
            }

            if (cbbLoaiMaGiamGia.SelectedIndex == -1)
            {
                message = "Vui lòng chọn loại mã giảm giá.";
                return false;
            }

            int maloaivc = Convert.ToInt32(cbbLoaiMaGiamGia.SelectedValue);
            decimal giatri = 0;

            if (maloaivc == 1)
            {
                giatri = numGiaTriGiamTheoPT.Value;
                if (giatri > numGiaTriGiamTheoPT.Maximum)
                {
                    message = $"Giá trị phần trăm giảm không được vượt quá {numGiaTriGiamTheoPT.Maximum}%. ";
                    return false;
                }
            }
            else if (maloaivc == 3)
            {
                if (!decimal.TryParse(txtGiaTriGiam.Text.Trim(), out giatri))
                {
                    message = "Giá trị giảm không hợp lệ.";
                    return false;
                }

                if (giatri <= 0)
                {
                    message = "Giá trị giảm phải lớn hơn 0.";
                    return false;
                }
            }

            decimal? dieuKien = null;
            if (!string.IsNullOrWhiteSpace(txtGiaTriDonHangToiThieu.Text))
            {
                if (!decimal.TryParse(txtGiaTriDonHangToiThieu.Text.Trim(), out decimal dk))
                {
                    message = "Giá trị đơn hàng tối thiểu không hợp lệ.";
                    return false;
                }

                if (dk <= 0)
                {
                    message = "Giá trị đơn hàng tối thiểu phải lớn hơn 0.";
                    return false;
                }

                dieuKien = dk;
            }
            foreach (DataGridViewRow row in dgvSanPham.SelectedRows)
            {
                if (dgvSanPham.Columns.Contains("Masp") && row.Cells["Masp"].Value != null && int.TryParse(row.Cells["Masp"].Value.ToString(), out int masp))
                {
                    maspList.Add(masp);
                }
            }

            dto = new VoucherDTO
            {
                Mavc = mavc,
                Code = code,
                TenMaGiamGia = tenMa,
                Giatri = giatri,
                Ngaybd = ngaybd,
                Ngaykt = ngaykt,
                DieuKien = dieuKien,
                Maloaivc = maloaivc,
                Maloai = cbbLoaiSanPham.SelectedIndex != -1 ? (int?)Convert.ToInt32(cbbLoaiSanPham.SelectedValue) : null
            };

            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuVoucherSua(out string message, out VoucherDTO dto, out List<int> maspList))
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbLoaiSanPham.SelectedIndex != -1 && dgvSanPham.SelectedRows.Count > 0)
            {
                MessageBox.Show("Bạn chỉ được chọn loại sản phẩm hoặc sản phẩm cụ thể để áp dụng mã giảm giá, không thể chọn cả hai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật voucher
            bool ok = VoucherBUS.Instance.UpdateVoucher(dto);
            bool chiTietOk = VoucherBUS.Instance.UpdateVoucherChiTiet(mavc, maspList);

            MessageBox.Show(ok && chiTietOk ? "Cập nhật thành công!" : "Cập nhật thất bại!");
            if (ok && chiTietOk)
            {
                VoucherUpdated?.Invoke(this, EventArgs.Empty); //  báo cho form cha
                this.Close();

            }

        }

        private void cbbLoaiMaGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiMaGiamGia.SelectedItem is LoaiVoucherDTO loai)
            {
                int maloaivc = loai.Maloaivc;

                if (maloaivc == 1)
                {
                    numGiaTriGiamTheoPT.Visible = true;
                    txtGiaTriGiam.Visible = false;
                }
                else if (maloaivc == 3)
                {
                    txtGiaTriGiam.Visible = true;
                    numGiaTriGiamTheoPT.Visible = false;
                }
            }

        }

        private void cbbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiSanPham.SelectedIndex != -1)
            {
                dgvSanPham.ClearSelection(); //bỏ chọn sản phẩm cụ thể
            }

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                cbbLoaiSanPham.SelectedIndex = -1; // bỏ chọn loại sản phẩm
            }
        }
    }
}
