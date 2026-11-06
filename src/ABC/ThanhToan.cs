using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class ThanhToan : Form
    {
        private List<DanhSachSanPhamDTO> danhSachMua;
        private string maND;
        private int? maKH;
        private KetQuaGiamGiaDTO ketQua;
        private decimal tongTienGoc;
        private decimal tongTienSauGiam;
        public void SetMaKH(int? maKH)
        {
            this.maKH = maKH;
        }
        private int? maVoucherId; // kiểu int? — đúng để truyền vào DB
        private string maVoucherCode; // kiểu string — dùng để hiển thị
        public string SoDienThoai { get; set; } = "";
        public string TenKhachHang { get; set; } = "Khách lẻ";
        public ThanhToan(List<DanhSachSanPhamDTO> danhSach, string maND, int? maKH, int? maVoucherId, string maVoucherCode, KetQuaGiamGiaDTO ketQua)
        {
            InitializeComponent();
            this.danhSachMua = danhSach;
            this.maND = maND;
            this.maKH = maKH;
            this.maVoucherId = maVoucherId;
            this.maVoucherCode = maVoucherCode;
            this.ketQua = ketQua;
        }
        private void HienThiSanPham()
        {
            flpSanPham.Controls.Clear();
            flpSanPham.AutoScroll = true;

            foreach (var sp in danhSachMua)
            {
                Panel panel = new Panel
                {
                    Width = 250,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    BackColor = sp.LaSanPhamTang ? Color.LightYellow : Color.WhiteSmoke
                };

                int xLeft = 110;

                // Ảnh sản phẩm
                PictureBox pic = new PictureBox
                {
                    Width = 80,
                    Height = 80,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10, 10)
                };

                pic.Image = ImageHelper.LoadImage(sp.DuongDanAnh);
                panel.Controls.Add(pic);

                // Tên sản phẩm (no size)
                Label lblTen = new Label
                {
                    Text = sp.LaSanPhamTang ? $"🎁 {sp.TenSP}" : $"{sp.TenSP}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    MaximumSize = new Size(140, 0),
                    AutoSize = true,
                    Location = new Point(xLeft, 10)
                };
                panel.Controls.Add(lblTen);

                int yOffset = lblTen.Bottom + 5;

                // Đơn giá (giá gốc)
                Label lblGia = new Label
                {
                    Text = sp.LaSanPhamTang ? "Đơn giá: Tặng" : "Đơn giá: " + sp.GiaGoc.ToString("N0") + " đ",
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(xLeft, yOffset)
                };
                panel.Controls.Add(lblGia);
                yOffset = lblGia.Bottom + 5;

                // Số lượng
                Label lblSL = new Label
                {
                    Text = "Số lượng: " + sp.SoLuong,
                    Font = new Font("Segoe UI", 9),
                    AutoSize = true,
                    Location = new Point(xLeft, yOffset)
                };
                panel.Controls.Add(lblSL);
                yOffset = lblSL.Bottom + 5;

                // Tổng tiền sau giảm
                decimal thanhTienSauGiam = sp.GiaGoc * sp.SoLuong - sp.TienGiam;
                Label lblTong = new Label
                {
                    Text = sp.LaSanPhamTang
                        ? "Tổng: 0 đ (Tặng)"
                        : "Tổng: " + thanhTienSauGiam.ToString("N0") + " đ",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(xLeft, yOffset)
                };
                panel.Controls.Add(lblTong);
                yOffset = lblTong.Bottom + 5;

                // Ghi chú giảm giá nếu có
                if (sp.TienGiam > 0)
                {
                    Label lblGhiChu = new Label
                    {
                        Text = $"Áp dụng mã {maVoucherCode} (-{sp.TienGiam:N0} đ)",
                        Font = new Font("Segoe UI", 8, FontStyle.Italic),
                        ForeColor = Color.DarkGreen,
                        AutoSize = true,
                        MaximumSize = new Size(120, 0),
                        Location = new Point(xLeft, yOffset)
                    };
                    panel.Controls.Add(lblGhiChu);
                    yOffset = lblGhiChu.Bottom + 5;
                }

                panel.Height = Math.Max(pic.Bottom + 10, yOffset + 10);

                ToolTip tooltip = new ToolTip();
                tooltip.SetToolTip(panel, sp.LaSanPhamTang
                    ? $"🎁 Sản phẩm tặng\nTên: {sp.TenSP}"
                    : $"Tên: {sp.TenSP}\nGiá gốc: {sp.GiaGoc:N0} đ\nSố lượng: {sp.SoLuong}");
                panel.Tag = sp;
                flpSanPham.Controls.Add(panel);
            }
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);

            foreach (var sp in danhSachMua)
            {
                // match by MaSP (string) — no IdKcsp
                var spGiam = ketQua?.SanPhamDuocGiam?.FirstOrDefault(x => x.MaSP == sp.MaSP);
                sp.TienGiam = spGiam?.TienGiam ?? 0;
                sp.GiaBan = sp.GiaGoc;
            }

            HienThiSanPham();

            tongTienGoc = danhSachMua
                .Where(sp => !sp.LaSanPhamTang)
                .Sum(sp => sp.GiaGoc * sp.SoLuong);

            tongTienSauGiam = danhSachMua
                .Where(sp => !sp.LaSanPhamTang)
                .Sum(sp => sp.GiaGoc * sp.SoLuong - sp.TienGiam);

            lbTongTien.Text = tongTienSauGiam.ToString("N0") + " đ";
            lblTenKhachHang.Text = TenKhachHang;
            lblSDT.Text = SoDienThoai;
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            string raw = txtTienKhachDua.Text.Replace(",", "").Trim();

            if (decimal.TryParse(raw, out decimal tienKhach))
            {
                decimal tongTien = new BanHangBUS().TinhTongTien(danhSachMua);
                decimal tienTraLai = tienKhach - tongTienSauGiam;

                txtTienTraLai.Text = tienTraLai >= 0 ? tienTraLai.ToString("N0") : "0";

                // ✅ Hiện cảnh báo nếu không đủ tiền
                if (tienTraLai < 0)
                {
                    lblCanhBao.Text = "⚠️ Tiền khách đưa không đủ!";
                    lblCanhBao.ForeColor = Color.Red;
                }
                else
                {
                    lblCanhBao.Text = "";
                }
            }
            else
            {
                txtTienTraLai.Text = "0";
                lblCanhBao.Text = "";
            }

        }

        private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép số và phím điều khiển (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // chặn ký tự không hợp lệ
            }

        }

        private void txtTienKhachDua_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTienKhachDua.Text.Replace(",", "").Trim(), out decimal value))
            {
                txtTienKhachDua.Text = value.ToString("N0"); // định dạng kiểu 1,000,000
            }

        }
        private bool KiemTraTienKhachDua(out decimal tienKhach)
        {
            tienKhach = 0;
            string raw = txtTienKhachDua.Text.Replace(",", "").Trim();

            if (!decimal.TryParse(raw, out tienKhach))
            {
                MessageBox.Show("Vui lòng nhập số tiền khách đưa hợp lệ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tienKhach < tongTienSauGiam)
            {
                MessageBox.Show($"❌ Tiền khách đưa không đủ để thanh toán.\nTổng tiền: {tongTienSauGiam:N0} đ\nKhách đưa: {tienKhach:N0} đ", "Thiếu tiền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void InHoaDon(int mahd, List<BanHangDTO> danhSach, string maND, int? maVoucher, decimal tienKhach)
        {
            string tenNV = NhanVienBUS.GetTenNguoiDung(maND);
            var ngayLap = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===== HÓA ĐƠN BÁN HÀNG =====");
            sb.AppendLine($"Mã hóa đơn: {mahd}");
            sb.AppendLine($"Nhân viên lập: {tenNV}");
            sb.AppendLine($"Thời gian: {ngayLap:dd/MM/yyyy HH:mm}");
            sb.AppendLine("");
            sb.AppendLine($"Khách hàng: {TenKhachHang}");
            sb.AppendLine($"SĐT: {SoDienThoai}");
            sb.AppendLine("Sản phẩm:");
            foreach (var sp in danhSach.Where(sp => !sp.LaSanPhamTang))
            {
                sb.AppendLine($"- {sp.TenSP} | SL: {sp.SoLuong} | Đơn giá: {sp.GiaBan:N0} đ");
            }

            if (maVoucher.HasValue)
            {
                sb.AppendLine("");
                sb.AppendLine($"Áp dụng mã giảm giá: {maVoucher.Value}");
            }

            decimal tongTien = danhSach.Where(sp => !sp.LaSanPhamTang).Sum(sp => sp.SoLuong * sp.GiaBan);
            sb.AppendLine("");
            sb.AppendLine($"Tổng tiền: {tongTienSauGiam:N0} đ");
            decimal tienTraLai = tienKhach - tongTienSauGiam;
            sb.AppendLine($"Tiền khách đưa: {tienKhach:N0} đ");
            sb.AppendLine($"Tiền trả lại: {tienTraLai:N0} đ");
            MessageBox.Show(sb.ToString(), "HÓA ĐƠN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool XacNhanThanhToan(List<BanHangDTO> danhSachBanHang, BanHangBUS bus)
        {
            StringBuilder xacNhan = new StringBuilder();
            xacNhan.AppendLine("Bạn có chắc muốn thanh toán đơn hàng sau?");
            xacNhan.AppendLine("──────────────────────────────");

            foreach (var sp in danhSachBanHang.Where(sp => !sp.LaSanPhamTang))
            {
                decimal thanhTien = sp.GiaGoc * sp.SoLuong - sp.TienGiam;
                string dong = $"- {sp.TenSP} | SL: {sp.SoLuong} | Đơn giá: {sp.GiaGoc:N0} đ";

                if (sp.TienGiam > 0)
                {
                    dong += $" | Giảm: -{sp.TienGiam:N0} đ";
                }

                dong += $" | Thành tiền: {thanhTien:N0} đ";
                xacNhan.AppendLine(dong);
            }

            decimal tongTien = danhSachBanHang
                .Where(sp => !sp.LaSanPhamTang)
                .Sum(sp => sp.GiaGoc * sp.SoLuong - sp.TienGiam);

            xacNhan.AppendLine("──────────────────────────────");
            xacNhan.AppendLine($"Tổng tiền: {tongTien:N0} đ");

            var result = MessageBox.Show(xacNhan.ToString(), "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (danhSachMua == null || danhSachMua.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để thanh toán.");
                return;
            }

            if (!KiemTraTienKhachDua(out decimal tienKhach))
            {
                MessageBox.Show("Khách chưa đưa đủ tiền.");
                return;
            }

            var bus = new BanHangBUS();

            foreach (var sp in danhSachMua)
            {
                var spGiam = ketQua?.SanPhamDuocGiam?.FirstOrDefault(x => x.MaSP == sp.MaSP);
                sp.TienGiam = spGiam?.TienGiam ?? 0;
                sp.GiaBan = sp.GiaGoc; // giữ nguyên giá gốc
            }

            var danhSachBanHang = bus.ChuyenDoiDanhSachBanHang(danhSachMua, ketQua);

            foreach (var sp in danhSachBanHang)
            {
                sp.GiaBan = sp.GiaGoc; // không thay đổi đơn giá
            }

            if (ketQua?.SanPhamTang?.Count > 0)
            {
                var sanPhamTangGop = ketQua.SanPhamTang
                    .GroupBy(sp => sp.MaSP)
                    .Select(g => new BanHangDTO
                    {
                        MaSP = g.Key,
                        Masp = int.TryParse(g.Key, out int id) ? id : DanhSachSanPhamBUS.Instance.GetMasp(g.Key),
                        TenSP = g.First().TenSP,
                        LaSanPhamTang = true,
                        SoLuong = 1,
                        GiaBan = 0,
                        GiaGoc = 0,
                        TienGiam = 0,
                        Maloai = g.First().Maloai,
                        MaSanPhamGoc = g.First().MaSanPhamGoc,
                        SoLuongTon = g.First().SoLuongTon,
                        DuongDanAnh = g.First().DuongDanAnh,
                        TenLoai = g.First().TenLoai,
                        TrangThaiText = g.First().TrangThaiText
                    }).ToList();

                danhSachBanHang.AddRange(sanPhamTangGop);
            }

            foreach (var sp in danhSachBanHang)
            {
                int tonKho = sp.SoLuongTon; // use cached SoLuongTon
                int soLuongThucTe = sp.LaSanPhamTang ? 1 : sp.SoLuong;
                if (tonKho < soLuongThucTe)
                {
                    MessageBox.Show($"❌ {sp.TenSP} không đủ tồn kho.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!XacNhanThanhToan(danhSachBanHang, bus)) return;

            int mahd = bus.XuatHoaDon(maKH, maND, danhSachBanHang, maVoucherId);
            MessageBox.Show($"✅ Thanh toán thành công. Mã hóa đơn: {mahd}");

            if (MessageBox.Show("Bạn có muốn in hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                decimal tongTienGoc = danhSachBanHang.Where(sp => !sp.LaSanPhamTang).Sum(sp => sp.GiaGoc * sp.SoLuong);
                decimal tongTienSauGiam = tongTienGoc - (ketQua?.TienGiam ?? 0);

                var hoaDonDTO = new HoaDonDTO
                {
                    MaHD = mahd,
                    NgayLap = DateTime.Now,
                    TenKH = maKH.HasValue ? KhachHangBUS.GetTenKhachHang(maKH.Value) : "Khách lẻ",
                    SDTKH = maKH.HasValue ? KhachHangBUS.GetSDTKhachHang(maKH.Value) : "",
                    TenNhanVien = NhanVienBUS.GetTenNguoiDung(maND),
                    TongTienGoc = tongTienGoc,
                    TienGiam = ketQua?.TienGiam ?? 0,
                    TongTien = tongTienSauGiam,
                    MaVoucher = maVoucherCode,
                    PhanTramGiam = ketQua?.LoaiVC == 1 ? (int?)ketQua.GiaTri : null,
                    LoaiVoucher = ketQua?.LoaiVC ?? 0,
                    SanPhamTang = ketQua?.SanPhamTang?.Select(sp => new DanhSachSanPhamDTO
                    {
                        TenSP = sp.TenSP,
                        SoLuong = 1
                    }).ToList() ?? new List<DanhSachSanPhamDTO>(),
                    SanPhamDuocGiam = ketQua?.SanPhamDuocGiam ?? new List<DanhSachSanPhamDTO>()
                };

                var danhSachSP_InPDF = danhSachBanHang
                    .Where(sp => !sp.LaSanPhamTang)
                    .Select(sp => new DanhSachSanPhamDTO
                    {
                        Masp = sp.Masp,
                        MaSP = sp.MaSP,
                        TenSP = sp.TenSP,
                        SoLuong = sp.SoLuong,
                        GiaGoc = sp.GiaGoc,
                        GiaBan = sp.GiaGoc, // giữ nguyên giá gốc
                        TienGiam = sp.TienGiam,
                        LaSanPhamTang = false,
                        Maloai = sp.Maloai,
                        MaSanPhamGoc = sp.MaSanPhamGoc,
                        SoLuongTon = sp.SoLuongTon,
                        DuongDanAnh = sp.DuongDanAnh,
                        TenLoai = sp.TenLoai,
                        TrangThaiText = sp.TrangThaiText
                    }).ToList();

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    FileName = $"HoaDon_{mahd}.pdf"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bus.XuatHoaDonPDF(hoaDonDTO, danhSachSP_InPDF, sfd.FileName);
                    MessageBox.Show("✅ Hóa đơn PDF đã được xuất thành công!");
                }
            }

            var danhSachCapNhat = danhSachBanHang
                .GroupBy(sp => new { sp.Masp, sp.LaSanPhamTang })
                .Select(g => new DanhSachSanPhamDTO
                {
                    Masp = g.Key.Masp,
                    TenSP = g.First().TenSP,
                    LaSanPhamTang = g.Key.LaSanPhamTang,
                    SoLuong = g.Key.LaSanPhamTang ? 1 : g.Sum(x => x.SoLuong)
                }).ToList();

            BanHangBUS.CapNhatTonKhoSauThanhToan(danhSachCapNhat);

            var formBanHang = Application.OpenForms["BANHANG"] as BANHANG;
            formBanHang?.CapNhatGiaoDienSauThanhToan();

            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
