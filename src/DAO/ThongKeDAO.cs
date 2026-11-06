using DTO;

namespace DAO
{
    public class ThongKeDAO
    {
        // ================= LOẠI SẢN PHẨM =================
        public List<LoaiSPDTO> GetLoaiSP()
        {
            using var db = Db.Create();
            return db.LOAISPs
                
                .Select(l => new LoaiSPDTO { MaLoai = l.Maloai, TenLoai = l.Tenloai })
                .ToList();
        }

        // Lọc hóa đơn theo khoảng ngày (bao gồm cả ngày cuối)
        private static IQueryable<HOADON> LocTheoNgay(IQueryable<HOADON> q, DateTime? tuNgay, DateTime? denNgay)
        {
            if (tuNgay.HasValue)
            {
                var tu = tuNgay.Value.Date;
                q = q.Where(h => h.Ngaylap >= tu);
            }
            if (denNgay.HasValue)
            {
                var den = denNgay.Value.Date.AddDays(1);
                q = q.Where(h => h.Ngaylap < den);
            }
            return q;
        }

        // ================= HÓA ĐƠN =================
        public List<HoaDonDTO> GetHoaDonList(DateTime? tuNgay, DateTime? denNgay, int? maLoai)
        {
            using var db = Db.Create();

            // Mỗi hóa đơn nối trái với các voucher đã áp dụng (như LEFT JOIN APMAVC / VOUCHER)
            var rows = (from h in LocTheoNgay(db.HOADONs, tuNgay, denNgay)
                        from ap in h.APMAVCs.DefaultIfEmpty()
                        orderby h.Ngaylap descending
                        select new
                        {
                            h.Mahd,
                            h.Ngaylap,
                            h.TongTienGoc,
                            h.TienGiam,
                            h.TongTien,
                            TenKH = h.KHACHHANG != null ? h.KHACHHANG.Tenkh : "Khách vãng lai",
                            SDTKH = h.KHACHHANG != null ? h.KHACHHANG.Sdt : "",
                            TenNhanVien = h.NHANVIEN.Hoten,
                            MaVoucher = ap != null ? ap.VOUCHER.Code : null,
                            Giatri = ap != null ? (decimal?)ap.VOUCHER.Giatri : null,
                            Maloaivc = ap != null ? (int?)ap.VOUCHER.Maloaivc : null
                        }).ToList();

            return rows.Select(r => new HoaDonDTO
            {
                MaHD = r.Mahd,
                NgayLap = r.Ngaylap,
                TenNhanVien = r.TenNhanVien,
                TenKH = r.TenKH,
                SDTKH = r.SDTKH,
                TongTienGoc = r.TongTienGoc,
                TienGiam = r.TienGiam,
                TongTien = r.TongTien,
                MaVoucher = r.MaVoucher,
                PhanTramGiam = r.Maloaivc == 1 ? Convert.ToInt32(r.Giatri) : null,
                LoaiVoucher = r.Maloaivc,
                SanPhamMua = GetSanPham(db, r.Mahd, false),
                SanPhamTang = GetSanPham(db, r.Mahd, true),
                SanPhamDuocGiam = GetSanPhamDuocGiam(db, r.Mahd)
            }).ToList();
        }

        // ================= SẢN PHẨM TRONG HÓA ĐƠN =================
        private static List<DanhSachSanPhamDTO> GetSanPham(QLCHDataContext db, int mahd, bool isTang)
        {
            return db.CHITIETHDs
                
                .Where(ct => ct.Mahd == mahd && ct.IsTang == isTang)
                .Select(ct => new
                {
                    ct.Masp,
                    ct.SANPHAM.Tensp,
                    ct.SANPHAM.Maloai,
                    ct.SANPHAM.Duongdananh,
                    ct.Soluong
                })
                .ToList()
                .Select(x => new DanhSachSanPhamDTO
                {
                    MaSP = x.Masp.ToString(),
                    TenSP = x.Tensp,
                    Maloai = x.Maloai,
                    DuongDanAnh = x.Duongdananh,
                    SoLuong = x.Soluong,
                    LaSanPhamTang = isTang
                })
                .ToList();
        }

        // ================= SẢN PHẨM ĐƯỢC GIẢM =================
        private static List<DanhSachSanPhamDTO> GetSanPhamDuocGiam(QLCHDataContext db, int mahd)
        {
            // voucher % (loại 1) áp dụng cho cả hóa đơn, hoặc voucher áp dụng cho đúng loại sản phẩm
            var rows = (from ct in db.CHITIETHDs
                        where ct.Mahd == mahd && !ct.IsTang
                        from ap in ct.HOADON.APMAVCs where ap.VOUCHER.Maloaivc == 1 || ap.VOUCHER.Maloai == ct.SANPHAM.Maloai
                        select new
                        {
                            ct.Masp,
                            ct.SANPHAM.Tensp,
                            ct.SANPHAM.Maloai,
                            ct.SANPHAM.Duongdananh,
                            ct.Soluong,
                            ap.VOUCHER.Giatri, ap.VOUCHER.Maloaivc }).ToList();

            return rows.Select(x => new DanhSachSanPhamDTO
            {
                MaSP = x.Masp.ToString(),
                TenSP = x.Tensp,
                Maloai = x.Maloai,
                DuongDanAnh = x.Duongdananh,
                SoLuong = x.Soluong,
                LaSanPhamTang = false,
                PhanTramGiam = x.Maloaivc == 1 ? x.Giatri : null,
                LoaiVoucher = x.Maloaivc
            }).ToList();
        }

        // ================= DOANH THU =================
        public List<DoanhThuChartDTO> GetDoanhThuData(DateTime? tuNgay, DateTime? denNgay, int? maLoai)
        {
            using var db = Db.Create();

            var q = from h in LocTheoNgay(db.HOADONs, tuNgay, denNgay)
                    from ct in h.CHITIETHDs
                    where !ct.IsTang
                    select new { h.Ngaylap, ct.Soluong, ct.Dongia, ct.SANPHAM.Maloai };

            if (maLoai.HasValue)
                q = q.Where(x => x.Maloai == maLoai.Value);

            return q.GroupBy(x => x.Ngaylap.Date)
                .Select(g => new DoanhThuChartDTO
                {
                    Ngay = g.Key,
                    TongDoanhThu = g.Sum(x => x.Soluong * x.Dongia)
                })
                .OrderBy(x => x.Ngay)
                .ToList();
        }

        // ================= SẢN PHẨM BÁN CHẠY =================
        public List<SanPhamBanChayDTO> GetSanPhamBanChay(DateTime? tuNgay, DateTime? denNgay, int? maLoai)
        {
            using var db = Db.Create();

            var q = from h in LocTheoNgay(db.HOADONs, tuNgay, denNgay)
                    from ct in h.CHITIETHDs
                    where !ct.IsTang
                    select new
                    {
                        ct.Masp,
                        ct.SANPHAM.Tensp,
                        ct.SANPHAM.Maloai,
                        ct.Soluong,
                        ct.Dongia
                    };

            if (maLoai.HasValue)
                q = q.Where(x => x.Maloai == maLoai.Value);

            return q.GroupBy(x => new { x.Masp, x.Tensp })
                .Select(g => new SanPhamBanChayDTO
                {
                    TenSP = g.Key.Tensp,
                    SoLuongBan = g.Sum(x => x.Soluong),
                    TongDoanhThu = g.Sum(x => x.Soluong * x.Dongia)
                })
                .OrderByDescending(x => x.SoLuongBan)
                .Take(10)
                .ToList();
        }
    }
}
