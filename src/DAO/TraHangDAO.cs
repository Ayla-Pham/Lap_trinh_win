using DAO.Models;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class TraHangDAO
    {
        // Danh sách hóa đơn (mới nhất trước), có thể lọc theo mã hóa đơn
        public List<HoaDonTraHangDTO> GetDanhSachHoaDon(string tuKhoa = "")
        {
            using var db = Db.Create();
            var q = db.Hoadons.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(tuKhoa))
                q = q.Where(h => h.Mahd.ToString().Contains(tuKhoa));

            return q.OrderByDescending(h => h.Ngaylap)
                    .Select(h => new HoaDonTraHangDTO
                    {
                        Mahd = h.Mahd,
                        Ngaylap = h.Ngaylap,
                        Makh = h.Makh,
                        Manv = h.Manv,
                        TongTien = h.TongTien
                    })
                    .ToList();
        }

        // Chi tiết các sản phẩm của hóa đơn
        public List<ChiTietTraHangDTO> GetChiTietHoaDon(int maHD)
        {
            using var db = Db.Create();
            return db.Chitiethds
                .AsNoTracking()
                .Where(ct => ct.Mahd == maHD)
                .Select(ct => new ChiTietTraHangDTO
                {
                    Masp = ct.Masp,
                    TenSP = ct.MaspNavigation.Tensp,
                    SoLuong = ct.Soluong,
                    DonGia = ct.Dongia
                })
                .ToList();
        }

        // Danh sách phiếu trả hàng (lọc theo mã phiếu / tên nhân viên / tên khách)
        public List<PhieuTraHangDongDTO> GetDanhSachPhieuTra(string tuKhoa = "")
        {
            using var db = Db.Create();
            var q = db.Trahangs.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(tuKhoa))
                q = q.Where(th => th.Matra.ToString().Contains(tuKhoa)
                               || th.ManvNavigation.Hoten.Contains(tuKhoa)
                               || (th.MahdNavigation.MakhNavigation != null
                                   && th.MahdNavigation.MakhNavigation.Tenkh.Contains(tuKhoa)));

            return q.OrderByDescending(th => th.Ngaytra)
                    .Select(th => new PhieuTraHangDongDTO
                    {
                        Matra = th.Matra,
                        Ngaytra = th.Ngaytra,
                        TenNhanVien = th.ManvNavigation.Hoten,
                        Makh = th.MahdNavigation.Makh,
                        Tenkh = th.MahdNavigation.MakhNavigation != null
                                    ? th.MahdNavigation.MakhNavigation.Tenkh : null,
                        Lydotra = th.Lydotra,
                        TongTien = th.MahdNavigation.TongTien
                    })
                    .ToList();
        }

        // Chi tiết của một phiếu trả hàng
        public List<ChiTietPhieuTraDongDTO> GetChiTietPhieuTra(int matra)
        {
            using var db = Db.Create();
            return db.Cttrahangs
                .AsNoTracking()
                .Where(c => c.Matra == matra)
                .Select(c => new ChiTietPhieuTraDongDTO
                {
                    Masp = c.Masp,
                    Tensp = c.MaspNavigation.Tensp,
                    Soluong = c.Soluong,
                    Dongia = c.Dongia,
                    ThanhTien = c.Soluong * c.Dongia
                })
                .ToList();
        }

        // Thêm phiếu trả hàng, trả về mã phiếu
        public int ThemTraHang(int maHD, string manv, string lyDo)
        {
            using var db = Db.Create();
            var th = new Trahang { Mahd = maHD, Manv = manv, Lydotra = lyDo, Ngaytra = DateTime.Now };
            db.Trahangs.Add(th);
            db.SaveChanges();
            return th.Matra;
        }

        // Thêm chi tiết trả hàng và cộng lại tồn kho
        public void ThemChiTietTraHang(int maTra, int masp, int soluong, decimal dongia)
        {
            using var db = Db.Create();
            using var tran = db.Database.BeginTransaction();
            db.Cttrahangs.Add(new Cttrahang { Matra = maTra, Masp = masp, Soluong = soluong, Dongia = dongia });
            var sp = db.Sanphams.First(s => s.Masp == masp);
            sp.Soluongton += soluong;
            db.SaveChanges();
            tran.Commit();
        }

        // Trả toàn bộ hóa đơn trong một giao dịch: tạo phiếu, chi tiết, cộng tồn kho
        public int TraToanBoHoaDon(int maHD, string manv, string lyDo)
        {
            using var db = Db.Create();
            using var tran = db.Database.BeginTransaction();

            var th = new Trahang { Mahd = maHD, Manv = manv, Lydotra = lyDo, Ngaytra = DateTime.Now };
            db.Trahangs.Add(th);
            db.SaveChanges();

            var chiTiet = db.Chitiethds.Where(ct => ct.Mahd == maHD).ToList();
            var dsMasp = chiTiet.Select(ct => ct.Masp).Distinct().ToList();
            var sanPhams = db.Sanphams.Where(s => dsMasp.Contains(s.Masp)).ToDictionary(s => s.Masp);

            foreach (var ct in chiTiet)
            {
                db.Cttrahangs.Add(new Cttrahang
                {
                    Matra = th.Matra,
                    Masp = ct.Masp,
                    Soluong = ct.Soluong,
                    Dongia = ct.Dongia
                });
                sanPhams[ct.Masp].Soluongton += ct.Soluong;
            }
            db.SaveChanges();
            tran.Commit();
            return th.Matra;
        }
    }
}
