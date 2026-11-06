using DTO;

namespace DAO
{
    public class BanHangDAO
    {
        private static BanHangDAO? instance;
        public static BanHangDAO Instance => instance ??= new BanHangDAO();

        public bool KiemTraSanPhamPhuHopTheoLoai(List<DanhSachSanPhamDTO> danhSach, int maloai)
        {
            return danhSach.Any(sp => !sp.LaSanPhamTang && sp.Maloai == maloai);
        }

        // Sản phẩm tặng của voucher (mua 1 tặng 1): loại 2 chỉ tặng sản phẩm cùng loại với sản phẩm mua
        public List<DanhSachSanPhamDTO> GetSanPhamTangByVoucher(int mavc, int? maloaiGoc = null, int? loaiVC = null)
        {
            using var db = Db.Create();
            var q = db.VOUCHER_SANPHAMs
                .Where(vs => vs.Mavc == mavc && vs.SANPHAM.Trangthaisp)
                .Select(vs => vs.SANPHAM);

            if (loaiVC == 2 && maloaiGoc.HasValue)
                q = q.Where(s => s.Maloai == maloaiGoc.Value);

            return q.OrderBy(s => s.Masp)
                .Select(s => new
                {
                    s.Masp,
                    s.Tensp,
                    s.Duongdananh,
                    s.Giaban,
                    s.Maloai,
                    TenLoai = s.LOAISP.Tenloai,
                    s.Soluongton,
                    s.Trangthaisp
                })
                .ToList()
                .Select(s => new DanhSachSanPhamDTO
                {
                    Masp = s.Masp,
                    MaSP = s.Masp.ToString(),
                    TenSP = s.Tensp,
                    DuongDanAnh = s.Duongdananh,
                    GiaBan = s.Giaban,
                    Maloai = s.Maloai,
                    TenLoai = s.TenLoai,
                    SoLuongTon = s.Soluongton,
                    TrangThaiText = s.Trangthaisp ? "Đang bán" : "Ngừng bán"
                })
                .ToList();
        }

        // Trừ tồn kho theo mã sản phẩm
        public void TruTonKho(int masp, int soLuong)
        {
            using var db = Db.Create();
            var sp = db.SANPHAMs.FirstOrDefault(s => s.Masp == masp)
                     ?? throw new InvalidOperationException("Không tìm thấy sản phẩm.");
            if (sp.Soluongton < soLuong)
                throw new InvalidOperationException("Số lượng tồn không đủ.");

            sp.Soluongton -= soLuong;
            db.SubmitChanges();
        }

        // Lập hóa đơn trong một giao dịch: hóa đơn, chi tiết, áp mã giảm giá, trừ tồn kho
        public int XuatHoaDon(int? makh, string manv, List<BanHangDTO> danhSachBanHang, int? mavc,
                              decimal tongTienGoc, decimal tienGiam, decimal tongTienSauGiam)
        {
            using var db = Db.Create();
            int mahd = 0;

            db.RunInTransaction(() =>
            {
                // 1) Hóa đơn
                var hoaDon = new HOADON
                {
                    Makh = makh,
                    Manv = manv,
                    Ngaylap = DateTime.Now,
                    TongTienGoc = tongTienGoc,
                    TienGiam = tienGiam,
                    TongTien = tongTienSauGiam
                };
                db.HOADONs.InsertOnSubmit(hoaDon);
                db.SubmitChanges();

                // 2) Chi tiết: gộp theo Masp + IsTang để không vi phạm khóa chính (Mahd, Masp, IsTang)
                var dong = danhSachBanHang
                    .GroupBy(s => new { s.Masp, s.LaSanPhamTang })
                    .Select(g => new
                    {
                        g.Key.Masp,
                        IsTang = g.Key.LaSanPhamTang,
                        Soluong = g.Sum(x => x.SoLuong),
                        Dongia = g.First().GiaBan
                    })
                    .ToList();

                foreach (var d in dong)
                {
                    if (d.Masp <= 0 || d.Soluong <= 0 || d.Dongia < 0)
                        throw new ArgumentException("Dữ liệu sản phẩm không hợp lệ.");

                    db.CHITIETHDs.InsertOnSubmit(new CHITIETHD
                    {
                        Mahd = hoaDon.Mahd,
                        Masp = d.Masp,
                        Soluong = d.Soluong,
                        Dongia = d.Dongia,
                        IsTang = d.IsTang
                    });
                }

                // 3) Áp dụng voucher (bảng APMAVC)
                if (mavc.HasValue)
                {
                    if (!db.VOUCHERs.Any(v => v.Mavc == mavc.Value))
                        throw new InvalidOperationException("Voucher không tồn tại.");
                    db.APMAVCs.InsertOnSubmit(new APMAVC { Mahd = hoaDon.Mahd, Mavc = mavc.Value });
                }

                // 4) Trừ tồn kho cho sản phẩm không phải hàng tặng
                var dsMasp = dong.Where(d => !d.IsTang).Select(d => d.Masp).ToList();
                var sanPhams = db.SANPHAMs.Where(s => dsMasp.Contains(s.Masp)).ToDictionary(s => s.Masp);
                foreach (var d in dong.Where(d => !d.IsTang))
                {
                    var sp = sanPhams[d.Masp];
                    if (sp.Soluongton < d.Soluong)
                        throw new InvalidOperationException($"Sản phẩm \"{sp.Tensp}\" không đủ tồn kho.");
                    sp.Soluongton -= d.Soluong;
                }

                db.SubmitChanges();
                mahd = hoaDon.Mahd;
            });

            return mahd;
        }

        private static BanHangDTO ToBanHang(int masp, string tensp, string tenLoai, decimal giaBan,
                                            string? duongDanAnh, int maloai, int soLuongTon, bool dangBan) => new BanHangDTO
        {
            Masp = masp,
            MaSP = masp.ToString(),
            TenSP = tensp,
            TenLoai = tenLoai,
            GiaBan = giaBan,
            DuongDanAnh = duongDanAnh ?? string.Empty,
            Maloai = maloai,
            SoLuongTon = soLuongTon,
            TrangThaiText = dangBan ? "Đang bán" : "Ngừng bán"
        };

        private static List<BanHangDTO> Lay(IQueryable<SANPHAM> q)
        {
            return q.OrderBy(s => s.Masp)
                .Select(s => new
                {
                    s.Masp,
                    s.Tensp,
                    TenLoai = s.LOAISP.Tenloai,
                    s.Giaban,
                    s.Duongdananh,
                    s.Maloai,
                    s.Soluongton,
                    s.Trangthaisp
                })
                .ToList()
                .Select(s => ToBanHang(s.Masp, s.Tensp, s.TenLoai, s.Giaban, s.Duongdananh, s.Maloai, s.Soluongton, s.Trangthaisp))
                .ToList();
        }

        // Tất cả sản phẩm
        public List<BanHangDTO> LayTatCaSanPham()
        {
            using var db = Db.Create();
            return Lay(db.SANPHAMs);
        }

        // Tìm kiếm theo tên hoặc mã
        public List<BanHangDTO> TimKiemSanPham(string searchType, string keyword)
        {
            using var db = Db.Create();
            var q = db.SANPHAMs.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
                q = q.Where(s => s.Tensp.Contains(keyword) || s.Masp.ToString().Contains(keyword));

            return Lay(q);
        }
    }
}
