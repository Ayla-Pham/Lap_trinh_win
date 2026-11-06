using DAO.Models;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDTO ToDTO(Nhanvien nv) => new NhanVienDTO
        {
            Manv = nv.Manv,
            Tk = nv.Tk,
            Mk = nv.Mk,
            Vitri = nv.Vitri,
            Hoten = nv.Hoten,
            Sdt = nv.Sdt ?? string.Empty,
            Email = nv.Email ?? string.Empty,
            NgaySinh = nv.Ngsinh.HasValue ? nv.Ngsinh.Value.ToDateTime(TimeOnly.MinValue) : DateTime.MinValue,
            Diachi = nv.Diachi ?? string.Empty,
            Luong = nv.Luong ?? 0m,
            Bank = nv.Bank ?? string.Empty,
            Stk = nv.Stk ?? string.Empty
        };

        private static DateOnly? ToDateOnly(DateTime d) =>
            d == DateTime.MinValue ? null : DateOnly.FromDateTime(d);

        public static List<NhanVienDTO> layDSNhanVien()
        {
            using var db = Db.Create();
            return db.Nhanviens.AsNoTracking().ToList().Select(ToDTO).ToList();
        }

        public static void XoaNV(string maNV)
        {
            using var db = Db.Create();
            var nv = db.Nhanviens.FirstOrDefault(n => n.Manv == maNV);
            if (nv == null) return;
            db.Nhanviens.Remove(nv);
            db.SaveChanges();
        }

        public static void SuaNV(NhanVienDTO nv)
        {
            using var db = Db.Create();
            var e = db.Nhanviens.FirstOrDefault(n => n.Manv == nv.Mand);
            if (e == null) return;

            e.Hoten = nv.Hoten;
            e.Sdt = nv.Sdt;
            e.Email = nv.Email;
            if (nv.Pos != null) e.Vitri = nv.Pos;
            e.Luong = nv.Luong;
            if (nv.Tk != null) e.Tk = nv.Tk;
            if (nv.Mk != null) e.Mk = nv.Mk;
            e.Bank = nv.Bank;
            e.Stk = nv.Stk;
            e.Ngsinh = ToDateOnly(nv.NgaySinh);
            db.SaveChanges();
        }

        private static IQueryable<NhanVienGridDTO> ToGrid(IQueryable<Nhanvien> q) =>
            q.OrderBy(n => n.Manv).Select(n => new NhanVienGridDTO
            {
                Manv = n.Manv,
                Tk = n.Tk,
                Mk = n.Mk,
                Vitri = n.Vitri,
                Hoten = n.Hoten,
                Sdt = n.Sdt ?? string.Empty,
                Email = n.Email ?? string.Empty,
                Ngsinh = n.Ngsinh.HasValue ? n.Ngsinh.Value.ToDateTime(TimeOnly.MinValue) : (DateTime?)null,
                Diachi = n.Diachi ?? string.Empty,
                Luong = n.Luong ?? 0m,
                Bank = n.Bank ?? string.Empty,
                Stk = n.Stk ?? string.Empty
            });

        public static List<NhanVienGridDTO> LayDanhSachNhanVien()
        {
            using var db = Db.Create();
            return ToGrid(db.Nhanviens.AsNoTracking()).ToList();
        }

        public static List<NhanVienGridDTO> TimKiemNhanVien(string keyword)
        {
            using var db = Db.Create();
            var q = db.Nhanviens.AsNoTracking().Where(n =>
                n.Manv.Contains(keyword) ||
                n.Hoten.Contains(keyword) ||
                n.Tk.Contains(keyword) ||
                (n.Sdt != null && n.Sdt.Contains(keyword)) ||
                (n.Email != null && n.Email.Contains(keyword)));
            return ToGrid(q).ToList();
        }

        public static List<NhanVienDTO> LayNhanVienTheoGio()
        {
            using var db = Db.Create();
            return db.Nhanviens.AsNoTracking()
                .Where(n => n.Luong != null)
                .ToList()
                .Select(ToDTO)
                .ToList();
        }

        public static void themNV(NhanVienDTO hs)
        {
            using var db = Db.Create();
            db.Nhanviens.Add(new Nhanvien
            {
                Manv = hs.Mand,
                Hoten = hs.Hoten,
                Sdt = hs.Sdt,
                Email = hs.Email,
                Vitri = hs.Pos ?? string.Empty,
                Luong = hs.Luong,
                Tk = hs.Tk ?? string.Empty,
                Mk = hs.Mk ?? string.Empty,
                Bank = hs.Bank,
                Stk = hs.Stk,
                Ngsinh = ToDateOnly(hs.NgaySinh)
            });
            db.SaveChanges();
        }

        public static NhanVienDTO? LayNhanVienTheoID(string id)
        {
            using var db = Db.Create();
            var nv = db.Nhanviens.AsNoTracking().FirstOrDefault(n => n.Manv == id);
            return nv == null ? null : ToDTO(nv);
        }

        public static string LayTenNhanVien(string mand)
        {
            using var db = Db.Create();
            return db.Nhanviens
                .Where(n => n.Manv == mand)
                .Select(n => n.Hoten)
                .FirstOrDefault() ?? "Không xác định";
        }

        // ===== Kiểm tra tồn tại (thêm nhân viên) =====
        public static bool KiemTraTonTaiMaNV(string maNV)
        {
            using var db = Db.Create();
            return db.Nhanviens.Any(n => n.Manv == maNV);
        }

        public static bool KiemTraTonTaiTenTaiKhoan(string tenTaiKhoan)
        {
            using var db = Db.Create();
            return db.Nhanviens.Any(n => n.Tk == tenTaiKhoan);
        }

        public static bool KiemTraTonTaiSdt(string sdt)
        {
            using var db = Db.Create();
            return db.Nhanviens.Any(n => n.Sdt == sdt);
        }

        public static bool KiemTraTonTaiEmail(string email)
        {
            using var db = Db.Create();
            return db.Nhanviens.Any(n => n.Email == email);
        }

        // ===== Kiểm tra tồn tại trừ chính nhân viên đang sửa =====
        public static bool KiemTraTonTaiTenTaiKhoanKhac(string tenTaiKhoan, string mandCanLoaiTru)
        {
            using var db = Db.Create();
            return db.Nhanviens.Any(n => n.Tk == tenTaiKhoan && n.Manv != mandCanLoaiTru);
        }

        public static bool KiemTraTonTaiSdtKhac(string sdt, string mandCanLoaiTru)
        {
            using var db = Db.Create();
            return db.Nhanviens.Any(n => n.Sdt == sdt && n.Manv != mandCanLoaiTru);
        }

        public static bool KiemTraTonTaiEmailKhac(string email, string mandCanLoaiTru)
        {
            using var db = Db.Create();
            return db.Nhanviens.Any(n => n.Email == email && n.Manv != mandCanLoaiTru);
        }
    }
}
