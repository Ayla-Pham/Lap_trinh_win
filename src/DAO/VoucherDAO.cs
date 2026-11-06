using DAO.Models;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class VoucherDAO
    {
        private static VoucherDAO? instance;
        public static VoucherDAO Instance => instance ??= new VoucherDAO();

        private static DateOnly ToDateOnly(DateTime d) => DateOnly.FromDateTime(d);

        private static Voucher ToEntity(VoucherDTO v) => new Voucher
        {
            Code = v.Code,
            TenMaGiamGia = v.TenMaGiamGia,
            Giatri = v.Giatri,
            Ngaybd = ToDateOnly(v.Ngaybd),
            Ngaykt = ToDateOnly(v.Ngaykt),
            DieuKien = v.DieuKien,
            Maloaivc = v.Maloaivc,
            Maloai = v.Maloai
        };

        private static void CopyTo(VoucherDTO v, Voucher e)
        {
            e.Code = v.Code;
            e.TenMaGiamGia = v.TenMaGiamGia;
            e.Giatri = v.Giatri;
            e.Ngaybd = ToDateOnly(v.Ngaybd);
            e.Ngaykt = ToDateOnly(v.Ngaykt);
            e.DieuKien = v.DieuKien;
            e.Maloaivc = v.Maloaivc;
            e.Maloai = v.Maloai;
        }

        private static IQueryable<VoucherDTO> ToDTO(IQueryable<Voucher> q) =>
            q.Select(v => new VoucherDTO
            {
                Mavc = v.Mavc,
                Code = v.Code,
                TenMaGiamGia = v.TenMaGiamGia,
                Giatri = v.Giatri,
                Ngaybd = v.Ngaybd.ToDateTime(TimeOnly.MinValue),
                Ngaykt = v.Ngaykt.ToDateTime(TimeOnly.MinValue),
                DieuKien = v.DieuKien,
                Maloaivc = v.Maloaivc,
                Maloai = v.Maloai
            });

        public static string GetCode(int mavc)
        {
            using var db = Db.Create();
            return db.Vouchers.Where(v => v.Mavc == mavc).Select(v => v.Code).FirstOrDefault() ?? "";
        }

        public static int? GetIdFromCode(string code)
        {
            using var db = Db.Create();
            string c = code ?? string.Empty;
            return db.Vouchers.Where(v => v.Code == c).Select(v => (int?)v.Mavc).FirstOrDefault();
        }

        public bool AddVoucher(VoucherDTO voucher)
        {
            return AddVoucherAndReturnID(voucher) > 0;
        }

        public bool AddVoucherChiTiet(int mavc, int masp)
        {
            using var db = Db.Create();
            var v = db.Vouchers.Include(x => x.Masps).FirstOrDefault(x => x.Mavc == mavc);
            var sp = db.Sanphams.FirstOrDefault(s => s.Masp == masp);
            if (v == null || sp == null) return false;
            if (v.Masps.Any(s => s.Masp == masp)) return false;

            v.Masps.Add(sp);
            return db.SaveChanges() > 0;
        }

        public bool CheckChiTietVoucher(int mavc, int masp)
        {
            using var db = Db.Create();
            return db.Vouchers.Any(v => v.Mavc == mavc && v.Masps.Any(s => s.Masp == masp));
        }

        public VoucherDTO? GetVoucherByID(int mavc)
        {
            using var db = Db.Create();
            return ToDTO(db.Vouchers.AsNoTracking().Where(v => v.Mavc == mavc)).FirstOrDefault();
        }

        public bool UpdateVoucher(VoucherDTO voucher)
        {
            return UpdateVoucherAndReturnAffectedRows(voucher) > 0;
        }

        public bool DeleteVoucher(int mavc)
        {
            using var db = Db.Create();
            var v = db.Vouchers.Include(x => x.Masps).Include(x => x.Mahds).FirstOrDefault(x => x.Mavc == mavc);
            if (v == null) return false;
            db.Vouchers.Remove(v);
            return db.SaveChanges() > 0;
        }

        public List<VoucherDTO> GetAllVouchers()
        {
            using var db = Db.Create();
            return ToDTO(db.Vouchers.AsNoTracking().OrderBy(v => v.Mavc)).ToList();
        }

        public List<VoucherDTO> GetVouchersByType(int maloaivc)
        {
            using var db = Db.Create();
            return ToDTO(db.Vouchers.AsNoTracking().Where(v => v.Maloaivc == maloaivc).OrderBy(v => v.Mavc)).ToList();
        }

        // Danh sách voucher kèm tên loại, loại sản phẩm, sản phẩm áp dụng / tặng
        private static List<VoucherHienThiDTO> HienThi(IQueryable<Voucher> q)
        {
            var rows = q.AsNoTracking()
                .OrderBy(v => v.Mavc)
                .Select(v => new
                {
                    v.Mavc,
                    v.Code,
                    v.TenMaGiamGia,
                    v.Giatri,
                    v.Ngaybd,
                    v.Ngaykt,
                    v.DieuKien,
                    v.Maloaivc,
                    v.Maloai,
                    TenLoaiVouCher = v.MaloaivcNavigation.Tenloai,
                    TenLoaiSP = v.MaloaiNavigation != null ? v.MaloaiNavigation.Tenloai : null,
                    SanPham = v.Masps.Select(s => s.Tensp).ToList(),
                    LoaiSPCuaSanPham = v.Masps.Select(s => s.MaloaiNavigation.Tenloai).Distinct().ToList()
                })
                .ToList();

            return rows.Select(r =>
            {
                bool laMua1Tang1 = r.Maloaivc == 2 || r.Maloaivc == 4;
                return new VoucherHienThiDTO
                {
                    Mavc = r.Mavc,
                    Code = r.Code,
                    TenMaGiamGia = r.TenMaGiamGia,
                    Giatri = r.Giatri,
                    Ngaybd = r.Ngaybd.ToDateTime(TimeOnly.MinValue),
                    Ngaykt = r.Ngaykt.ToDateTime(TimeOnly.MinValue),
                    DieuKien = r.DieuKien,
                    Maloaivc = r.Maloaivc,
                    Maloai = r.Maloai,
                    TenLoaiVouCher = r.TenLoaiVouCher,
                    TenLoaiSanPhamApDung = r.TenLoaiSP,
                    TenLoaiSanPhamTang = laMua1Tang1 ? string.Join(", ", r.LoaiSPCuaSanPham) : null,
                    SanPhamApDung = laMua1Tang1 ? null : string.Join(", ", r.SanPham),
                    SanPhamTang = laMua1Tang1 ? string.Join(", ", r.SanPham) : null
                };
            }).ToList();
        }

        public List<VoucherHienThiDTO> GetAllVouchersWithJoin()
        {
            using var db = Db.Create();
            return HienThi(db.Vouchers);
        }

        public List<VoucherHienThiDTO> GetVouchersByTypeWithJoin(int maloaivc)
        {
            using var db = Db.Create();
            return HienThi(db.Vouchers.Where(v => v.Maloaivc == maloaivc));
        }

        public List<VoucherDTO> GetVouchersByDateRange(DateTime from, DateTime to)
        {
            using var db = Db.Create();
            var f = ToDateOnly(from);
            var t = ToDateOnly(to);
            // voucher có thời gian hiệu lực giao với khoảng [from, to]
            return ToDTO(db.Vouchers.AsNoTracking()
                    .Where(v => v.Ngaybd <= t && v.Ngaykt >= f)
                    .OrderBy(v => v.Mavc))
                .ToList();
        }

        public List<LoaiVoucherDTO> GetVoucherTypes()
        {
            using var db = Db.Create();
            return db.Kieuvcs
                .AsNoTracking()
                .OrderBy(k => k.Maloaivc)
                .Select(k => new LoaiVoucherDTO { Maloaivc = k.Maloaivc, Tenloai = k.Tenloai })
                .ToList();
        }

        public int AddVoucherAndReturnID(VoucherDTO voucher)
        {
            using var db = Db.Create();
            var e = ToEntity(voucher);
            db.Vouchers.Add(e);
            db.SaveChanges();
            return e.Mavc;
        }

        public int UpdateVoucherAndReturnAffectedRows(VoucherDTO voucher)
        {
            using var db = Db.Create();
            var e = db.Vouchers.FirstOrDefault(v => v.Mavc == voucher.Mavc);
            if (e == null) return 0;
            CopyTo(voucher, e);
            return db.SaveChanges();
        }

        // Thay toàn bộ sản phẩm của voucher bằng danh sách mới
        public bool UpdateVoucherChiTiet(int mavc, List<int> maspList)
        {
            using var db = Db.Create();
            var v = db.Vouchers.Include(x => x.Masps).FirstOrDefault(x => x.Mavc == mavc);
            if (v == null) return false;

            v.Masps.Clear();
            var sanPhams = db.Sanphams.Where(s => maspList.Contains(s.Masp)).ToList();
            foreach (var sp in sanPhams)
                v.Masps.Add(sp);

            db.SaveChanges();
            return true;
        }
    }
}
