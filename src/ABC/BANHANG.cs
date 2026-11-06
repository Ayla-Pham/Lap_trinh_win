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
using BUS;
using DAO;
using System.IO;

namespace ABC
{
    public partial class BANHANG : Form
    {
        private DanhSachSanPhamBUS sanPhamBUS = new DanhSachSanPhamBUS();
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        private BanHangBUS banHangBUS = new BanHangBUS();

        private List<DanhSachSanPhamDTO> danhSachDaChon = new List<DanhSachSanPhamDTO>();
        private string maND;

        private int? maKH; // gán khi chọn khách hàng

        // Mã giảm giá
        private int? maVoucherId; // ID mã giảm giá (dùng để lưu vào DB)
        private string maVoucherCode; // Mã giảm giá dạng chuỗi (hiển thị trong hóa đơn)
        private KetQuaGiamGiaDTO ketQuaGiamGia; // Kết quả áp dụng mã: tiền giảm, sản phẩm tặng, loại mã
        public BANHANG()
        {
            InitializeComponent();
            maND = CurrentUser.Manv;
        }

        private void btnThemKhachHangMoi_Click(object sender, EventArgs e)
        {
            ThemKhachHang themKhachHang = new ThemKhachHang();
            themKhachHang.ShowDialog();
            this.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var danhSachMua = LaySanPhamTuGiaoDien();
            if (danhSachMua == null || danhSachMua.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(maND))
            {
                MessageBox.Show("Không xác định được nhân viên. Vui lòng đăng nhập lại.");
                return;
            }

            var formTT = new ThanhToan(danhSachMua, maND, maKH, maVoucherId, maVoucherCode, ketQuaGiamGia);
            formTT.SetMaKH(maKH);
            formTT.SoDienThoai = txtTimKhachHang.Text;
            formTT.TenKhachHang = KhachHangBUS.LayTenKhachHangTheoSDT(txtTimKhachHang.Text);
            formTT.Show();
        }

        private void BANHANG_Load(object sender, EventArgs e)
        {
            UIButton.ReplaceStandardButtonsWithIcons(this, Properties.Resources.exit, Properties.Resources.delete, Properties.Resources.refresh, Properties.Resources.done);
            UIText.ApplyButtonTextStyle(this);
            LoadSanPham();

            maND = CurrentUser.Manv;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadSanPham();
            }
            else
            {
                LoadSanPham("TenSP", keyword);
            }
        }

        private void LoadSanPham(string searchType = null, string searchTerm = null)
        {
            try
            {
                flpSanPham.Controls.Clear();

                var danhSach = sanPhamBUS.SearchSanPham(searchType, searchTerm);

                var nhomSanPham = danhSach
                    .GroupBy(sp => new { sp.TenSP, sp.DuongDanAnh })
                    .ToList();

                string rootPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\.."));

                foreach (var group in nhomSanPham)
                {
                    var spDauTien = group.First();

                    Panel p = new Panel
                    {
                        Size = new Size(300, 240),
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.White
                    };

                    bool hetHang = spDauTien.SoLuongTon == 0;

                    if (hetHang)
                        p.BackColor = Color.LightGray;

                    PictureBox pic = new PictureBox
                    {
                        Size = new Size(160, 120),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(10, 10),
                        Cursor = Cursors.Hand
                    };

                    pic.Image = ImageHelper.LoadImage(spDauTien.DuongDanAnh);

                    Label lblTen = new Label
                    {
                        Text = spDauTien.TenSP,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        Location = new Point(10, 135),
                        Size = new Size(160, 20)
                    };

                    FlowLayoutPanel pnlSizes = new FlowLayoutPanel
                    {
                        Location = new Point(5, 160),
                        AutoSize = true,
                        AutoSizeMode = AutoSizeMode.GrowAndShrink,
                        FlowDirection = FlowDirection.LeftToRight,
                        WrapContents = true,
                        Margin = new Padding(0)
                    };

                    // Product-level UI: single button per product
                    foreach (var sp in group)
                    {
                        Button btn = new Button
                        {
                            Text = $"{sp.GiaBan:N0}đ",
                            AutoSize = true,
                            AutoSizeMode = AutoSizeMode.GrowAndShrink,
                            Height = 25,
                            Font = new Font("Segoe UI", 8, FontStyle.Regular),
                            Tag = sp,
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.Beige,
                            Margin = new Padding(3)
                        };

                        btn.FlatAppearance.BorderSize = 1;
                        btn.Click += (s, e) => XuLyChonSanPham(ConvertToBanHangDTO(sp));

                        pnlSizes.Controls.Add(btn);
                    }

                    p.Controls.Add(pic);
                    p.Controls.Add(lblTen);
                    p.Controls.Add(pnlSizes);

                    flpSanPham.Controls.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private BanHangDTO ConvertToBanHangDTO(DanhSachSanPhamDTO dto)
        {
            return new BanHangDTO
            {
                MaSP = dto.MaSP,
                TenSP = dto.TenSP,
                Maloai = dto.Maloai,
                TenLoai = dto.TenLoai,
                GiaBan = dto.GiaBan,
                GiaGoc = dto.GiaGoc,
                SoLuong = dto.SoLuong,
                SoLuongTon = dto.SoLuongTon,
                DuongDanAnh = dto.DuongDanAnh,
                TrangThaiText = dto.TrangThaiText,
                LaSanPhamTang = dto.LaSanPhamTang,
                MaSanPhamGoc = dto.MaSanPhamGoc,
                TienGiam = dto.TienGiam
            };
        }
        private void XuLyChonSanPham(BanHangDTO sp)
        {
            // ✅ Nếu đã áp mã giảm giá thì reset khi thêm sản phẩm mới
            if (!string.IsNullOrEmpty(maVoucherCode))
            {
                txtMaGiamGia.Text = "";
                maVoucherId = null;
                maVoucherCode = "";
                ketQuaGiamGia = new KetQuaGiamGiaDTO();

                // Xóa sản phẩm tặng khỏi giao diện
                XoaSanPhamTang();

                // Khôi phục giá gốc cho các sản phẩm đã chọn
                foreach (Control ctrl in fLPSanPhamDaChon.Controls)
                {
                    if (ctrl.Tag is DanhSachSanPhamDTO dto && !dto.LaSanPhamTang)
                    {
                        dto.GiaBan = dto.GiaGoc;
                        dto.TienGiam = 0;
                    }
                }

                CapNhatTongTien();
            }
            sp.GiaGoc = sp.GiaBan; //lưu giá gốc ban đầu
            if (sp.SoLuongTon == 0)
            {
                MessageBox.Show("❌ Sản phẩm đã hết hàng. Không thể mua.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sp.TrangThaiText == "Ngừng bán")
            {
                MessageBox.Show("❌ Sản phẩm đang ngừng bán. Không thể mua.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Nhập số lượng cho {sp.TenSP}:",
                "Chọn số lượng",
                "1"
            );

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            if (!int.TryParse(input, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (soLuong > sp.SoLuongTon)
            {
                MessageBox.Show("Số lượng vượt quá tồn kho!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sp.SoLuong = soLuong;
            ThemSanPhamVaoFlow(sp, soLuong);
            CapNhatTongTien();
        }

        private void ThemSanPhamVaoFlow(BanHangDTO sp, int soLuong)
        {
            foreach (Control ctrl in fLPSanPhamDaChon.Controls)
            {
                if (ctrl is Panel existingPanel && existingPanel.Tag is BanHangDTO existingSp)
                {
                    // Compare only by product (no size)
                    if (existingSp.MaSP == sp.MaSP)
                    {
                        Label lblSL = existingPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Số lượng:"));
                        Label lblTong = existingPanel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.StartsWith("Tổng:"));

                        if (lblSL != null && lblTong != null)
                        {
                            int oldSL = int.Parse(lblSL.Text.Replace("Số lượng:", "").Trim());
                            int newSL = oldSL + soLuong;
                            lblSL.Text = $"Số lượng: {newSL}";
                            lblTong.Text = $"Tổng: {(existingSp.GiaBan * newSL):N0} đ";

                            existingSp.SoLuong = newSL; // ✅ Cập nhật lại số lượng trong Tag
                            existingPanel.BackColor = Color.LightGreen;
                            CapNhatTongTien();
                            return;
                        }
                    }
                }
            }

            // Tạo panel mới
            sp.SoLuong = soLuong;

            // Resolve numeric Masp (product id) from MaSP string if necessary.
            sp.Masp = DanhSachSanPhamBUS.Instance.GetMasp(sp.MaSP);

            sp.LaSanPhamTang = false;
            if (sp.Masp == 0)
            {
                MessageBox.Show($"Không tìm thấy mã sản phẩm cho {sp.TenSP}", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Panel newPanel = new Panel
            {
                Width = 280,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5),
                BackColor = Color.WhiteSmoke,
                Tag = sp // Gán đối tượng có số lượng vào Tag
            };

            PictureBox pic = new PictureBox
            {
                Width = 80,
                Height = 80,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(10, 10)
            };

            pic.Image = ImageHelper.LoadImage(sp.DuongDanAnh);

            Label lblTen = new Label
            {
                Text = $"{sp.TenSP}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(100, 10),
                MaximumSize = new Size(140, 0),
                AutoSize = true
            };

            Label lblGia = new Label
            {
                Text = "Đơn giá: " + sp.GiaBan.ToString("N0") + " đ",
                Location = new Point(100, 35),
                AutoSize = true
            };

            Label lblSLMoi = new Label
            {
                Text = "Số lượng: " + sp.SoLuong,
                Location = new Point(100, 55),
                AutoSize = true
            };

            Label lblTongMoi = new Label
            {
                Text = "Tổng: " + (sp.GiaBan * sp.SoLuong).ToString("N0") + " đ",
                Location = new Point(100, 75),
                AutoSize = true
            };

            Button btnXoa = new Button
            {
                Text = "X",
                Size = new Size(25, 25),
                Location = new Point(newPanel.Width - 30, 5),
                BackColor = Color.LightCoral,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.Click += (s, e) =>
            {
                fLPSanPhamDaChon.Controls.Remove(newPanel);

                //Lấy mã sản phẩm gốc từ panel vừa xóa
                string maSanPhamGoc = null;

                if (newPanel.Tag is BanHangDTO spGoc)
                {
                    maSanPhamGoc = spGoc.MaSP;
                }
                else if (newPanel.Tag is DanhSachSanPhamDTO spGocDTO)
                {
                    maSanPhamGoc = spGocDTO.MaSP;
                }

                if (!string.IsNullOrEmpty(maSanPhamGoc))
                {
                    //Xóa tất cả sản phẩm tặng có MaSanPhamGoc trùng
                    var panelsToRemove = fLPSanPhamDaChon.Controls.OfType<Panel>()
                        .Where(p =>
                        {
                            if (p.Tag is DanhSachSanPhamDTO spTang)
                            {
                                return spTang.LaSanPhamTang && spTang.MaSanPhamGoc == maSanPhamGoc;
                            }
                            return false;
                        }).ToList();

                    foreach (var p in panelsToRemove)
                    {
                        fLPSanPhamDaChon.Controls.Remove(p);
                        p.Dispose();
                    }
                }
                //Kiểm tra nếu không còn sản phẩm mua nào thì reset mã giảm giá
                var danhSachSauXoa = LaySanPhamTuGiaoDien();
                bool conSanPhamMua = danhSachSauXoa.Any(sp => !sp.LaSanPhamTang);

                if (!conSanPhamMua)
                {
                    txtMaGiamGia.Text = "";
                    maVoucherId = null;
                    maVoucherCode = "";
                    ketQuaGiamGia = new KetQuaGiamGiaDTO();
                }

                CapNhatTongTien();
            };

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(newPanel, $"Tên: {sp.TenSP}\nGiá: {sp.GiaBan:N0} đ");

            newPanel.Controls.Add(pic);
            newPanel.Controls.Add(lblTen);
            newPanel.Controls.Add(lblGia);
            newPanel.Controls.Add(lblSLMoi);
            newPanel.Controls.Add(lblTongMoi);
            newPanel.Controls.Add(btnXoa);
            btnXoa.BringToFront();
            fLPSanPhamDaChon.Controls.Add(newPanel);
            CapNhatTongTien();
        }

        private DanhSachSanPhamDTO TaoDTOTuRow(DataGridViewRow row)
        {
            var dto = new DanhSachSanPhamDTO
            {
                MaSP = row.Cells["MaSP"].Value.ToString(),
                TenSP = row.Cells["TenSP"].Value.ToString(),
                Maloai = Convert.ToInt32(row.Cells["Maloai"].Value),
                TenLoai = row.Cells["TenLoai"].Value.ToString(),
                GiaBan = Convert.ToDecimal(row.Cells["GiaBan"].Value),
                SoLuongTon = Convert.ToInt32(row.Cells["SoLuongTon"].Value),
                TrangThaiText = row.Cells["TrangThaiText"].Value.ToString(),
                DuongDanAnh = row.Cells["DuongDanAnh"].Value?.ToString(),
                LaSanPhamTang = false
            };

            // No IdKcsp mapping here anymore; keep MaSP and let BUS/DAO resolve numeric id when needed.
            return dto;
        }
        private int LaySoLuongTuNguoiDung()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng cần mua:", "Chọn số lượng", "1");
            return int.TryParse(input, out int soLuong) ? soLuong : -1;
        }


        private void cbbTimKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private List<DanhSachSanPhamDTO> LaySanPhamTuGiaoDien()
        {
            return fLPSanPhamDaChon.Controls
                .OfType<Panel>()
                .Select(p => p.Tag)
                .Where(tag => tag is BanHangDTO || tag is DanhSachSanPhamDTO)
                .Select(tag =>
                {
                    if (tag is BanHangDTO sp)
                    {
                        return new DanhSachSanPhamDTO
                        {
                            // Do not set IdKcsp here — keep MaSP and other fields
                            MaSP = sp.MaSP,
                            TenSP = sp.TenSP,
                            // no size
                            SoLuong = sp.SoLuong,
                            GiaBan = sp.GiaBan,
                            GiaGoc = sp.GiaGoc,
                            TienGiam = sp.TienGiam,
                            SoLuongTon = sp.SoLuongTon,
                            DuongDanAnh = sp.DuongDanAnh,
                            Maloai = sp.Maloai,
                            TenLoai = sp.TenLoai,
                            TrangThaiText = sp.TrangThaiText,
                            LaSanPhamTang = sp.LaSanPhamTang,
                            MaSanPhamGoc = sp.MaSanPhamGoc
                        };
                    }
                    else
                    {
                        return (DanhSachSanPhamDTO)tag;
                    }
                })
                .Where(sp => sp != null && !string.IsNullOrEmpty(sp.MaSP)) // validate by MaSP
                .ToList();
        }

        private bool SanPhamTangDaTonTai(BanHangDTO spTang)
        {
            return fLPSanPhamDaChon.Controls.OfType<Panel>()
                .Any(p => p.Tag is DanhSachSanPhamDTO spCheck &&
                          spCheck.MaSP == spTang.MaSP &&
                          spCheck.LaSanPhamTang &&
                          spCheck.MaSanPhamGoc == spTang.MaSanPhamGoc);
        }

        private void HienThiSanPhamTang(List<BanHangDTO> danhSachTang)
        {
            foreach (var spTang in danhSachTang)
            {
                if (SanPhamTangDaTonTai(spTang)) continue;

                var spConverted = new DanhSachSanPhamDTO
                {
                    MaSP = spTang.MaSP,
                    TenSP = spTang.TenSP,
                    DuongDanAnh = spTang.DuongDanAnh,
                    // no size
                    TenLoai = spTang.TenLoai,
                    GiaBan = 0,
                    SoLuongTon = spTang.SoLuongTon,
                    TrangThaiText = spTang.TrangThaiText,
                    LaSanPhamTang = true,
                    MaSanPhamGoc = spTang.MaSanPhamGoc,
                    SoLuong = 1
                };

                // Validate product exists by resolving numeric id locally (do not store IdKcsp)
                int maspId = DanhSachSanPhamBUS.Instance.GetMasp(spConverted.MaSP);
                if (maspId == 0)
                {
                    MessageBox.Show($"Không tìm thấy mã sản phẩm cho {spConverted.TenSP}", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                ThemSanPhamTangVaoFlow(spConverted);
            }
        }
        private void ThemSanPhamTangVaoFlow(DanhSachSanPhamDTO sp)
        {
            Panel panel = new Panel
            {
                Width = 250,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5),
                BackColor = Color.LightYellow
            };
            PictureBox pic = new PictureBox
            {
                Width = 80,
                Height = 80,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(10, 10)
            };

            pic.Image = ImageHelper.LoadImage(sp.DuongDanAnh);

            Label lblTen = new Label
            {
                Text = $"{sp.TenSP} (Tặng)",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(100, 10),
                MaximumSize = new Size(140, 0), //chiều rộng cố định, chiều cao tự động
                AutoSize = true
            };

            Label lblGia = new Label
            {
                Text = "Đơn giá: 0 đ",
                Location = new Point(100, 35),
                AutoSize = true
            };

            Label lblSL = new Label
            {
                Text = "Số lượng: 1",
                Location = new Point(100, 55),
                AutoSize = true
            };

            Label lblTong = new Label
            {
                Text = "Tổng: 0 đ",
                Location = new Point(100, 75),
                AutoSize = true
            };

            panel.Controls.Add(pic);
            panel.Controls.Add(lblTen);
            panel.Controls.Add(lblGia);
            panel.Controls.Add(lblSL);
            panel.Controls.Add(lblTong);

            // Validate existence (do not set IdKcsp)
            int maspId = DanhSachSanPhamBUS.Instance.GetMasp(sp.MaSP);
            if (maspId == 0)
            {
                MessageBox.Show($"Không tìm thấy mã sản phẩm cho {sp.TenSP}", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sp.LaSanPhamTang = true;
            panel.Tag = sp;

            fLPSanPhamDaChon.Controls.Add(panel);
            CapNhatTongTien();

        }
        private void CapNhatTongTien()
        {
            var danhSachDaChon = LaySanPhamTuGiaoDien()
                .Where(sp => !string.IsNullOrEmpty(sp.MaSP)) // only valid products
                .ToList();

            var bus = new BanHangBUS();
            decimal tong = bus.TinhTongTien(danhSachDaChon);
            txtTongTien.Text = tong.ToString("N0") + " đ";
        }
        private void btnThemMaGiamGia_Click(object sender, EventArgs e)
        {
            {
                // Xóa sản phẩm tặng cũ khỏi danh sách
                danhSachDaChon.RemoveAll(sp => sp.LaSanPhamTang);
                XoaSanPhamTang();

                QuanLiMAGIAMGIA formMaGiam = new QuanLiMAGIAMGIA(true, maND);
                if (formMaGiam.ShowDialog() != DialogResult.OK) return;

                string code = formMaGiam.MaGiamGiaDuocChon;
                this.maVoucherCode = code;
                this.maVoucherId = VoucherBUS.GetIdFromCode(code);

                var danhSachMua = LaySanPhamTuGiaoDien();
                ketQuaGiamGia = banHangBUS.ApDungMaGiamGia(code, danhSachMua);

                if (!string.IsNullOrEmpty(ketQuaGiamGia.Loi))
                {
                    MessageBox.Show(ketQuaGiamGia.Loi, "Lỗi áp dụng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra sản phẩm tặng có hợp lệ
                foreach (var spTang in ketQuaGiamGia.SanPhamTang)
                {
                    if (spTang.SoLuongTon == 0 || spTang.TrangThaiText == "Ngừng bán")
                    {
                        MessageBox.Show($"❌ Sản phẩm tặng '{spTang.TenSP}' đã hết hàng hoặc ngừng bán.\nKhông thể áp dụng mã giảm giá này.", "Lỗi sản phẩm tặng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Thêm sản phẩm tặng vào giao diện
                foreach (var spTang in ketQuaGiamGia.SanPhamTang)
                {
                    var dto = new DanhSachSanPhamDTO
                    {
                        MaSP = spTang.MaSP,
                        TenSP = spTang.TenSP,
                        // no size
                        GiaBan = 0, 
                        GiaGoc = 0,
                        SoLuong = 1,
                        Maloai = spTang.Maloai,
                        MaSanPhamGoc = danhSachMua.FirstOrDefault()?.MaSP,
                        TenLoai = spTang.TenLoai,
                        DuongDanAnh = spTang.DuongDanAnh,
                        TrangThaiText = spTang.TrangThaiText,
                        SoLuongTon = spTang.SoLuongTon,
                        LaSanPhamTang = true,
                        TienGiam = 0
                    };
                    danhSachDaChon.Add(dto);
                    ThemSanPhamTangVaoFlow(dto);
                }

                txtMaGiamGia.Text = code;

                // Gán TienGiam cho từng sản phẩm mua — match by MaSP
                foreach (var sp in danhSachMua)
                {
                    var giam = ketQuaGiamGia.SanPhamDuocGiam.FirstOrDefault(x => x.MaSP == sp.MaSP);
                    sp.TienGiam = giam?.TienGiam ?? 0;
                    sp.GiaBan = sp.GiaGoc; // giữ nguyên giá gốc
                }

                // Tính tổng tiền sau giảm: Tổng gốc - Tổng giảm
                decimal tongTienSauGiam = danhSachMua
                    .Where(sp => !sp.LaSanPhamTang)
                    .Sum(sp => sp.GiaGoc * sp.SoLuong) - ketQuaGiamGia.TienGiam;

                txtTongTien.Text = tongTienSauGiam.ToString("N0") + " đ";
            }
        }
        private void XoaSanPhamTang()
        {
            var controlsToRemove = new List<Control>();

            foreach (Control ctrl in fLPSanPhamDaChon.Controls)
            {
                if (ctrl.Tag is DanhSachSanPhamDTO dto && dto.LaSanPhamTang)
                {
                    controlsToRemove.Add(ctrl);
                }
            }

            foreach (var ctrl in controlsToRemove)
            {
                fLPSanPhamDaChon.Controls.Remove(ctrl);
                ctrl.Dispose(); // Giải phóng bộ nhớ
            }
        }
        public void CapNhatGiaoDienSauThanhToan()
        {

            // ✅ Gán lại danh sách sản phẩm
            LoadSanPham();

            // ✅ Reset giao diện khác
            fLPSanPhamDaChon.Controls.Clear();
            fLPSanPhamDaChon.Refresh();
            txtTongTien.Text = "0 đ";
            ketQuaGiamGia = new KetQuaGiamGiaDTO();
            maVoucherCode = "";
            maVoucherId = null;
        }
        public class PlaceholderItem
        {
            public override string ToString() => "— Không có kết quả —";
        }
        private void txtTimKhachHang_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKhachHang.Text.Trim();
            cbbTimKhachHang.Items.Clear();

            if (string.IsNullOrEmpty(keyword))
            {
                // Luôn có placeholder để dropdown không rỗng
                cbbTimKhachHang.Items.Add(new PlaceholderItem());
                cbbTimKhachHang.SelectedIndex = -1;
                return;
            }

            var danhSach = khachHangBUS.TimKiemTheoSDT(keyword);

            if (danhSach != null && danhSach.Count > 0)
            {
                cbbTimKhachHang.Items.AddRange(danhSach.ToArray());
                cbbTimKhachHang.SelectedIndex = -1;
                cbbTimKhachHang.DroppedDown = true;
            }
            else
            {
                cbbTimKhachHang.Items.Add(new PlaceholderItem());
                cbbTimKhachHang.SelectedIndex = -1;
                cbbTimKhachHang.DroppedDown = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTimKhachHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbTimKhachHang.SelectedIndex < 0) return;

            // Bỏ qua nếu chọn placeholder
            if (cbbTimKhachHang.SelectedItem is PlaceholderItem)
            {
                cbbTimKhachHang.DroppedDown = false;
                return;
            }

            if (cbbTimKhachHang.SelectedItem is KhachHangDTO kh)
            {
                txtTimKhachHang.Text = kh.Sdt;
                maKH = kh.Makh;
            }

            cbbTimKhachHang.DroppedDown = false;
        }

        private void cbbTimKhachHang_DropDown(object sender, EventArgs e)
        {
        }
    }
}
