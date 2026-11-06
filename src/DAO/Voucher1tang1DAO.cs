using DAO.Models;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class Voucher1tang1DAO
    {
        private static Voucher1tang1DAO? instance;
        public static Voucher1tang1DAO Instance => instance ??= new Voucher1tang1DAO();

        private Voucher1tang1DAO() { }

        public static string GetCode(int mavc)
        {
            return VoucherDAO.GetCode(mavc);
        }

        public bool CheckCodeExists(string code, int? excludeMavc = null)
        {
            using var db = Db.Create();
            return db.Vouchers.Any(v => v.Code == code && (excludeMavc == null || v.Mavc != excludeMavc));
        }

        // Thêm voucher, trả về mã voucher vừa tạo
        public int InsertVoucher(string code, string tenMa, int loaiVC, int? maloai, decimal? dieuKien, DateTime ngaybd, DateTime ngaykt, decimal giaTri = 0m)
        {
            using var db = Db.Create();
            var e = new Voucher
            {
                Code = code,
                TenMaGiamGia = tenMa,
                Giatri = giaTri,
                Ngaybd = DateOnly.FromDateTime(ngaybd),
                Ngaykt = DateOnly.FromDateTime(ngaykt),
                DieuKien = dieuKien,
                Maloaivc = loaiVC,
                Maloai = maloai
            };
            db.Vouchers.Add(e);
            db.SaveChanges();
            return e.Mavc;
        }

        public int GetVoucherId(string code)
        {
            using var db = Db.Create();
            return db.Vouchers.Where(v => v.Code == code).Select(v => (int?)v.Mavc).FirstOrDefault() ?? -1;
        }

        public int InsertChiTietVC(int mavc, int masp)
        {
            return VoucherDAO.Instance.AddVoucherChiTiet(mavc, masp) ? 1 : -1;
        }

        public int GetMasp(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP)) return -1;
            if (!int.TryParse(maSP, out int masp)) return -1;

            using var db = Db.Create();
            return db.Sanphams.Any(s => s.Masp == masp) ? masp : -1;
        }

        public VoucherDTO? GetVoucherByID(int mavc)
        {
            return VoucherDAO.Instance.GetVoucherByID(mavc);
        }

        public List<SanPhamTangDTO> GetSanPhamTangByVoucher(int mavc)
        {
            using var db = Db.Create();
            return db.Vouchers
                .AsNoTracking()
                .Where(v => v.Mavc == mavc)
                .SelectMany(v => v.Masps)
                .Select(s => new SanPhamTangDTO { Masp = s.Masp, Tensp = s.Tensp, Maloai = s.Maloai })
                .ToList();
        }

        public List<SanPhamTangDTO> SearchSanPhamTang(string keyword)
        {
            using var db = Db.Create();
            string kw = keyword ?? string.Empty;
            return db.Sanphams
                .AsNoTracking()
                .Where(s => s.Trangthaisp && (s.Tensp.Contains(kw) || s.Masp.ToString().Contains(kw)))
                .OrderBy(s => s.Masp)
                .Select(s => new SanPhamTangDTO { Masp = s.Masp, Tensp = s.Tensp, Maloai = s.Maloai })
                .ToList();
        }

        public bool UpdateVoucher(int mavc, string code, string tenMaGiamGia, int loaiVC, int? maloai, decimal? dieuKien, decimal giaTri = 0m, DateTime? ngaybd = null, DateTime? ngaykt = null)
        {
            using var db = Db.Create();
            var e = db.Vouchers.FirstOrDefault(v => v.Mavc == mavc);
            if (e == null) return false;

            e.Code = code;
            e.TenMaGiamGia = tenMaGiamGia;
            e.Giatri = giaTri;
            e.Ngaybd = DateOnly.FromDateTime(ngaybd ?? DateTime.Today);
            e.Ngaykt = DateOnly.FromDateTime(ngaykt ?? DateTime.Today);
            e.DieuKien = dieuKien;
            e.Maloaivc = loaiVC;
            e.Maloai = maloai;
            return db.SaveChanges() > 0;
        }

        public bool DeleteChiTietVC(int mavc)
        {
            using var db = Db.Create();
            var v = db.Vouchers.Include(x => x.Masps).FirstOrDefault(x => x.Mavc == mavc);
            if (v == null) return true;
            v.Masps.Clear();
            db.SaveChanges();
            return true;
        }

        public List<SanPhamTangDTO> TimSanPhamTangTheoLoai(int maloai)
        {
            using var db = Db.Create();
            return db.Sanphams
                .AsNoTracking()
                .Where(s => s.Trangthaisp && s.Maloai == maloai)
                .OrderBy(s => s.Masp)
                .Select(s => new SanPhamTangDTO { Masp = s.Masp, Tensp = s.Tensp, Maloai = s.Maloai })
                .ToList();
        }
    }
}
