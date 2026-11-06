using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class LichSuHoaDonDAO
    {
        // 1. Tìm kiếm / lọc hóa đơn
        public List<LichSuHoaDonDTO> SearchHoaDon(string? timKiem, string? maNV, DateTime? tuNgay, DateTime? denNgay)
        {
            using var db = Db.Create();
            var q = db.Hoadons.AsNoTracking().AsQueryable();

            if (timKiem != null)
                q = q.Where(h => (h.MakhNavigation != null
                                  && (h.MakhNavigation.Tenkh.Contains(timKiem) || h.MakhNavigation.Sdt.Contains(timKiem)))
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
                    TenNhanVien = h.ManvNavigation.Hoten,
                    TenKhachHang = h.MakhNavigation != null ? h.MakhNavigation.Tenkh : "Khách vãng lai",
                    TongTien = h.TongTien
                })
                .ToList();
        }

        // 2. Danh sách nhân viên
        public List<NhanVienDTO> GetNhanVienList()
        {
            using var db = Db.Create();
            return db.Nhanviens
                .AsNoTracking()
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
            return db.Chitiethds
                .AsNoTracking()
                .Where(ct => ct.Mahd == maHD)
                .Select(ct => new ChiTietLichSuDTO
                {
                    TenSP = ct.MaspNavigation.Tensp,
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
            return db.Hoadons
                .AsNoTracking()
                .Where(h => h.Mahd == maHD)
                .Select(h => new HoaDonDayDuDTO
                {
                    MaHD = h.Mahd,
                    NgayLap = h.Ngaylap,
                    TenNhanVien = h.ManvNavigation.Hoten,
                    TenKhachHang = h.MakhNavigation != null ? h.MakhNavigation.Tenkh : "Khách vãng lai",
                    SdtKhachHang = h.MakhNavigation != null ? h.MakhNavigation.Sdt : null,
                    TichDiem = h.MakhNavigation != null ? h.MakhNavigation.Tichdiem : 0,
                    TongTienCuoiCung = h.TongTien
                })
                .FirstOrDefault();
        }

        // 5. Voucher đã dùng
        public List<string> GetVouchersSuDung(int maHD)
        {
            using var db = Db.Create();
            return db.Hoadons
                .AsNoTracking()
                .Where(h => h.Mahd == maHD)
                .SelectMany(h => h.Mavcs)
                .Select(v => v.Code)
                .ToList();
        }

        // 6. Lấy danh sách khách hàng theo nhân viên
        public List<KhachHangCuaNVDTO> GetKhachHangCuaNhanVien(string maNV)
        {
            using var db = Db.Create();
            return db.Hoadons
                .AsNoTracking()
                .Where(h => h.Manv == maNV && h.Makh != null)
                .GroupBy(h => new { h.MakhNavigation!.Tenkh, h.MakhNavigation.Sdt })
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
