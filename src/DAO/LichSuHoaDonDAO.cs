using DTO;

namespace DAO
{
    public class LichSuHoaDonDAO
    {
        // 1. Tìm kiếm / lọc hóa đơn
        public List<LichSuHoaDonDTO> SearchHoaDon(string? timKiem, string? maNV, DateTime? tuNgay, DateTime? denNgay)
        {
            using var db = Db.Create();
            var q = db.HOADONs.AsQueryable();

            if (timKiem != null)
                q = q.Where(h => (h.KHACHHANG != null
                                  && (h.KHACHHANG.Tenkh.Contains(timKiem) || h.KHACHHANG.Sdt.Contains(timKiem)))
                                 || h.Mahd.ToString() == timKiem);

            if (maNV != null)
                q = q.Where(h => h.Manv == maNV);

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

            return q.OrderByDescending(h => h.Ngaylap)
                .Select(h => new LichSuHoaDonDTO
                {
                    MaHD = h.Mahd,
                    NgayLap = h.Ngaylap,
                    TenNhanVien = h.NHANVIEN.Hoten,
                    TenKhachHang = h.KHACHHANG != null ? h.KHACHHANG.Tenkh : "Khách vãng lai",
                    TongTien = h.TongTien
                })
                .ToList();
        }

        // 2. Danh sách nhân viên
        public List<NhanVienDTO> GetNhanVienList()
        {
            using var db = Db.Create();
            return db.NHANVIENs
                
                .Select(nv => new NhanVienDTO
                {
                    Mand = nv.Manv,
                    Hoten = nv.Hoten,
                    Vitri = nv.Vitri
                })
                .ToList();
        }

        // 3. Chi tiết hóa đơn
        public List<ChiTietLichSuDTO> GetChiTietHoaDon(int maHD)
        {
            using var db = Db.Create();
            return db.CHITIETHDs
                
                .Where(ct => ct.Mahd == maHD)
                .Select(ct => new ChiTietLichSuDTO
                {
                    TenSP = ct.SANPHAM.Tensp,
                    SoLuong = ct.Soluong,
                    DonGia = ct.Dongia,
                    ThanhTien = ct.Soluong * ct.Dongia
                })
                .ToList();
        }

        // 4. Thông tin cơ bản hóa đơn
        public HoaDonDayDuDTO? GetThongTinCoBanHD(int maHD)
        {
            using var db = Db.Create();
            return db.HOADONs
                
                .Where(h => h.Mahd == maHD)
                .Select(h => new HoaDonDayDuDTO
                {
                    MaHD = h.Mahd,
                    NgayLap = h.Ngaylap,
                    TenNhanVien = h.NHANVIEN.Hoten,
                    TenKhachHang = h.KHACHHANG != null ? h.KHACHHANG.Tenkh : "Khách vãng lai",
                    SdtKhachHang = h.KHACHHANG != null ? h.KHACHHANG.Sdt : null,
                    TichDiem = h.KHACHHANG != null ? h.KHACHHANG.Tichdiem : 0,
                    TongTienCuoiCung = h.TongTien
                })
                .FirstOrDefault();
        }

        // 5. Voucher đã dùng
        public List<string> GetVouchersSuDung(int maHD)
        {
            using var db = Db.Create();
            return db.APMAVCs
                .Where(a => a.Mahd == maHD)
                .Select(a => a.VOUCHER.Code)
                .ToList();
        }

        // 6. Lấy danh sách khách hàng theo nhân viên
        public List<KhachHangCuaNVDTO> GetKhachHangCuaNhanVien(string maNV)
        {
            using var db = Db.Create();
            return db.HOADONs
                
                .Where(h => h.Manv == maNV && h.Makh != null)
                .GroupBy(h => new { h.KHACHHANG!.Tenkh, h.KHACHHANG.Sdt })
                .Select(g => new KhachHangCuaNVDTO
                {
                    TenKH = g.Key.Tenkh,
                    Sdt = g.Key.Sdt,
                    TongChiTieu = g.Sum(h => h.TongTien)
                })
                .OrderByDescending(x => x.TongChiTieu)
                .ToList();
        }
    }
}
