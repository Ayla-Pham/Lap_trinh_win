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
    public partial class ThemMaGiamGia : Form
    {
        public ThemMaGiamGia()
        {
            InitializeComponent();
        }
        public event EventHandler VoucherUpdated;
        private void btnThemMaGiamGia1tang1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemMaGiamGia1tang1 themMaGiamGia1Tang1 = new ThemMaGiamGia1tang1();
            DialogResult result = themMaGiamGia1Tang1.ShowDialog(); //khai báo biến result
            this.Show();

            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void ThemMaGiamGia_Load(object sender, EventArgs e)
        {
            LoadLoaiMaGG();
            LoadLoaiSanPham();
            LoadSanPham();
            // Mặc định chọn loại giảm theo giá trị thực
            cbbLoaiMaGG.SelectedValue = 3; // Giả sử 3 là "Giảm theo giá trị thực"
            UpdateInputVisibility();
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
            UIDataGridView.FormatDataGridView(dgvSanPham);
            numGiamPhanTram.Minimum = 1;
            numGiamPhanTram.Maximum = 100;

        }
        private void LoadLoaiMaGG()
        {
            // Chỉ lấy loại mã 1 (giảm %) và 3 (giảm theo giá trị thực)
            var dsLoai = VoucherBUS.Instance.GetVoucherTypes()
                .Where(l => l.Maloaivc == 1 || l.Maloaivc == 3)
                .ToList();

            cbbLoaiMaGG.DataSource = dsLoai;
            cbbLoaiMaGG.DisplayMember = "Tenloai";
            cbbLoaiMaGG.ValueMember = "Maloaivc";
            cbbLoaiMaGG.SelectedIndex = -1;

        }
        private void UpdateInputVisibility()
        {
            if (cbbLoaiMaGG.SelectedItem is LoaiVoucherDTO loai)
            {
                int maloaivc = loai.Maloaivc;
                // 1 = Giảm %, 3 = Giảm theo giá trị thực
                txtGiaTriGiam.Enabled = (maloaivc == 3);
                numGiamPhanTram.Enabled = (maloaivc == 1);
            }
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

            // Use product-level Masp column and hide size related columns
            if (dgvSanPham.Columns.Contains("Masp"))
                dgvSanPham.Columns["Masp"].HeaderText = "ID";
            if (dgvSanPham.Columns.Contains("TenSP"))
                dgvSanPham.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            if (dgvSanPham.Columns.Contains("GiaBan"))
                dgvSanPham.Columns["GiaBan"].HeaderText = "Giá bán";

            foreach (DataGridViewColumn col in dgvSanPham.Columns)
            {
                if (col.Name != "Masp" && col.Name != "TenSP" && col.Name != "GiaBan")
                {
                    col.Visible = false;
                }
            }
        }

        private void cbbLoaiMaGG_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInputVisibility();

        }
        private bool KiemTraDuLieuMaGiamGia(out string message, out decimal giatri)
        {
            message = "";
            giatri = 0;

            string code = txtMaGiamGia.Text.Trim();
            string ten = txtTenMa.Text.Trim();

            if (string.IsNullOrWhiteSpace(code))
            {
                message = "Vui lòng nhập mã giảm giá.";
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

            if (VoucherBUS.Instance.CheckCodeExists(code))
            {
                message = "Mã giảm giá đã tồn tại. Vui lòng chọn mã khác.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(ten))
            {
                message = "Vui lòng nhập tên mã giảm giá.";
                return false;
            }

            if (ten.Length > 100)
            {
                message = "Tên mã giảm giá không được vượt quá 100 ký tự.";
                return false;
            }

            if (cbbLoaiMaGG.SelectedIndex == -1)
            {
                message = "Vui lòng chọn loại mã giảm giá.";
                return false;
            }

            int maloaivc = Convert.ToInt32(cbbLoaiMaGG.SelectedValue);
            if (maloaivc == 1)
            {
                giatri = numGiamPhanTram.Value;
                if (giatri < 1 || giatri > 100)
                {
                    message = "Giá trị phần trăm giảm phải từ 1 đến 100.";
                    return false;
                }
            }
            else if (maloaivc == 3)
            {
                if (!decimal.TryParse(txtGiaTriGiam.Text, out giatri))
                {
                    message = "Giá trị giảm không hợp lệ. Vui lòng nhập số.";
                    return false;
                }

                if (giatri <= 0)
                {
                    message = "Giá trị giảm phải lớn hơn 0.";
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtGiaTriDonToiThieu.Text))
            {
                if (!decimal.TryParse(txtGiaTriDonToiThieu.Text, out decimal giaTriDonToiThieu))
                {
                    message = "Giá trị đơn tối thiểu không hợp lệ. Vui lòng nhập số.";
                    return false;
                }

                if (giaTriDonToiThieu <= 0)
                {
                    message = "Giá trị đơn tối thiểu phải lớn hơn 0.";
                    return false;
                }
            }

            if (dTPBatDau.Value.Date < DateTime.Today)
            {
                message = "Ngày bắt đầu không được nhỏ hơn ngày hiện tại.";
                return false;
            }

            if (dTPHetHan.Value.Date < dTPBatDau.Value.Date)
            {
                message = "Ngày kết thúc phải sau ngày bắt đầu.";
                return false;
            }

            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuMaGiamGia(out string message, out decimal giatri))
            {
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra: không được chọn cả loại sản phẩm và sản phẩm cụ thể
            if (cbbLoaiSanPham.SelectedIndex != -1 && dgvSanPham.SelectedRows.Count > 0)
            {
                MessageBox.Show("Bạn chỉ được chọn loại sản phẩm hoặc sản phẩm cụ thể để áp dụng mã giảm giá, không thể chọn cả hai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string code = txtMaGiamGia.Text.Trim();
            string ten = txtTenMa.Text.Trim();
            int maloaivc = Convert.ToInt32(cbbLoaiMaGG.SelectedValue);

            decimal? dieuKien = null;
            if (decimal.TryParse(txtGiaTriDonToiThieu.Text, out decimal dk))
                dieuKien = dk;

            DateTime ngaybd = dTPBatDau.Value.Date;
            DateTime ngaykt = dTPHetHan.Value.Date;

            // Nếu chọn loại sản phẩm → gán vào voucher
            int? maloai = cbbLoaiSanPham.SelectedIndex != -1 ? Convert.ToInt32(cbbLoaiSanPham.SelectedValue) : null;

            VoucherDTO voucher = new VoucherDTO(0, code, ten, giatri, ngaybd, ngaykt, dieuKien, maloaivc, maloai);

            try
            {
                int mavc = VoucherBUS.Instance.AddVoucherAndGetID(voucher);

                if (mavc > 0)
                {
                    // Nếu chọn sản phẩm cụ thể → thêm vào VOUCHER_SANPHAM by Masp
                    if (dgvSanPham.SelectedRows.Count > 0)
                    {
                        if (dgvSanPham.SelectedRows[0].Cells["Masp"].Value != null)
                        {
                            int masp = Convert.ToInt32(dgvSanPham.SelectedRows[0].Cells["Masp"].Value);
                            bool added = VoucherBUS.Instance.AddVoucherChiTiet(mavc, masp);
                            MessageBox.Show("Mã sản phẩm chọn: " + masp);
                            if (!added)
                            {
                                MessageBox.Show("Không thể liên kết mã với sản phẩm đã chọn.");
                            }
                        }
                    }

                    MessageBox.Show("Thêm mã giảm giá thành công!");
                    VoucherUpdated?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Có thể mã đã tồn tại hoặc dữ liệu không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }

        }

        private void txtGiaTriGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtGiaTriDonToiThieu_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtGiaTriGiam_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txtGiaTriDonToiThieu_Validating(object sender, CancelEventArgs e)
        {
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
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                cbbLoaiSanPham.SelectedIndex = -1; //bỏ chọn loại sản phẩm
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
