using DAO.Models;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class ChamCongDAO
    {
        private static ChamCongDAO? instance;
        public static ChamCongDAO Instance => instance ??= new ChamCongDAO();

        // Bắt đầu làm việc
        public bool InsertBatDauLam(string manv, DateTime gioBatDau)
        {
            using var db = Db.Create();
            db.Chamcongs.Add(new Chamcong
            {
                Manv = manv,
                Ngay = DateOnly.FromDateTime(gioBatDau),
                GioBatDau = gioBatDau
            });
            return db.SaveChanges() > 0;
        }

        // Kết thúc ca
        public bool UpdateChamCong(string manv, DateTime ngay, DateTime gioKetThuc, int tongPhut)
        {
            using var db = Db.Create();
            var d = DateOnly.FromDateTime(ngay);
            var cc = db.Chamcongs.FirstOrDefault(c => c.Manv == manv && c.Ngay == d && c.GioKetThuc == null);
            if (cc == null)
                return false;

            cc.GioKetThuc = gioKetThuc;
            cc.TongThoiGian = tongPhut;
            return db.SaveChanges() > 0;
        }

        // Lấy giờ bắt đầu chưa chấm công
        public DateTime? GetGioBatDauChuaChamCong(string manv, DateTime ngay)
        {
            using var db = Db.Create();
            var d = DateOnly.FromDateTime(ngay);
            return db.Chamcongs
                .Where(c => c.Manv == manv && c.Ngay == d && c.GioKetThuc == null)
                .Select(c => (DateTime?)c.GioBatDau)
                .FirstOrDefault();
        }

        // Tổng phút trong ngày
        public int GetTongPhutTrongNgay(string manv, DateTime ngay)
        {
            using var db = Db.Create();
            var d = DateOnly.FromDateTime(ngay);
            return db.Chamcongs
                .Where(c => c.Manv == manv && c.Ngay == d)
                .Sum(c => c.TongThoiGian ?? 0);
        }

        // Lịch sử chấm công
        public List<ChamCongDTO> GetLichSuChamCongChiTiet(string keyword, DateTime tuNgay, DateTime denNgay)
        {
            using var db = Db.Create();
            var tu = DateOnly.FromDateTime(tuNgay);
            var den = DateOnly.FromDateTime(denNgay);

            var q = db.Chamcongs.AsNoTracking()
                .Where(c => c.Ngay >= tu && c.Ngay <= den);

            if (!string.IsNullOrEmpty(keyword))
                q = q.Where(c => c.ManvNavigation.Hoten.Contains(keyword) || c.Manv.Contains(keyword));

            var rows = q.OrderByDescending(c => c.Ngay)
                .Select(c => new
                {
                    c.Idcc,
                    c.Manv,
                    c.ManvNavigation.Hoten,
                    Luong = c.ManvNavigation.Luong ?? 0m,
                    c.Ngay,
                    c.GioBatDau,
                    c.GioKetThuc,
                    c.TongThoiGian
                })
                .ToList();

            return rows.Select(r => new ChamCongDTO
            {
                Id = r.Idcc,
                Manv = r.Manv,
                TenNhanVien = r.Hoten,
                Luong = r.Luong,
                Ngay = r.Ngay.ToDateTime(TimeOnly.MinValue),
                GioBatDau = r.GioBatDau,
                GioKetThuc = r.GioKetThuc,
                TongThoiGian = r.TongThoiGian,
                TongLuong = (r.TongThoiGian ?? 0) / 60m * r.Luong
            }).ToList();
        }

        public decimal GetLuongTheoGio(string manv)
        {
            using var db = Db.Create();
            return db.Nhanviens
                .Where(n => n.Manv == manv)
                .Select(n => n.Luong ?? 0m)
                .FirstOrDefault();
        }
    }
}
