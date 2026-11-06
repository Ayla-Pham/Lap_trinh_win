using DTO;

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
            db.CHAMCONGs.InsertOnSubmit(new CHAMCONG
            {
                Manv = manv,
                Ngay = (gioBatDau).Date,
                GioBatDau = gioBatDau
            });
            return db.Save() > 0;
        }

        // Kết thúc ca
        public bool UpdateChamCong(string manv, DateTime ngay, DateTime gioKetThuc, int tongPhut)
        {
            using var db = Db.Create();
            var d = (ngay).Date;
            var cc = db.CHAMCONGs.FirstOrDefault(c => c.Manv == manv && c.Ngay == d && c.GioKetThuc == null);
            if (cc == null)
                return false;

            cc.GioKetThuc = gioKetThuc;
            cc.TongThoiGian = tongPhut;
            return db.Save() > 0;
        }

        // Lấy giờ bắt đầu chưa chấm công
        public DateTime? GetGioBatDauChuaChamCong(string manv, DateTime ngay)
        {
            using var db = Db.Create();
            var d = (ngay).Date;
            return db.CHAMCONGs
                .Where(c => c.Manv == manv && c.Ngay == d && c.GioKetThuc == null)
                .Select(c => (DateTime?)c.GioBatDau)
                .FirstOrDefault();
        }

        // Tổng phút trong ngày
        public int GetTongPhutTrongNgay(string manv, DateTime ngay)
        {
            using var db = Db.Create();
            var d = (ngay).Date;
            return db.CHAMCONGs
                .Where(c => c.Manv == manv && c.Ngay == d)
                .Sum(c => (int?)c.TongThoiGian) ?? 0;
        }

        // Lịch sử chấm công
        public List<ChamCongDTO> GetLichSuChamCongChiTiet(string keyword, DateTime tuNgay, DateTime denNgay)
        {
            using var db = Db.Create();
            var tu = (tuNgay).Date;
            var den = (denNgay).Date;

            var q = db.CHAMCONGs
                .Where(c => c.Ngay >= tu && c.Ngay <= den);

            if (!string.IsNullOrEmpty(keyword))
                q = q.Where(c => c.NHANVIEN.Hoten.Contains(keyword) || c.Manv.Contains(keyword));

            var rows = q.OrderByDescending(c => c.Ngay)
                .Select(c => new
                {
                    c.Idcc,
                    c.Manv,
                    c.NHANVIEN.Hoten,
                    Luong = c.NHANVIEN.Luong ?? 0m,
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
                Ngay = r.Ngay,
                GioBatDau = r.GioBatDau,
                GioKetThuc = r.GioKetThuc,
                TongThoiGian = r.TongThoiGian,
                TongLuong = (r.TongThoiGian ?? 0) / 60m * r.Luong
            }).ToList();
        }

        public decimal GetLuongTheoGio(string manv)
        {
            using var db = Db.Create();
            return db.NHANVIENs
                .Where(n => n.Manv == manv)
                .Select(n => n.Luong ?? 0m)
                .FirstOrDefault();
        }
    }
}
