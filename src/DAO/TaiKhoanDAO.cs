using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        // Kiểm tra mật khẩu cũ có đúng không (so sánh hash, không phân biệt hoa thường)
        public bool KiemTraMatKhauCu(string username, string hashedPassword)
        {
            using var db = Db.Create();
            string? storedHash = db.Nhanviens
                .Where(nv => nv.Tk == username)
                .Select(nv => nv.Mk)
                .FirstOrDefault();

            if (storedHash == null)
                return false; // Không tìm thấy tài khoản

            return string.Equals(storedHash, hashedPassword, StringComparison.OrdinalIgnoreCase);
        }

        // Cập nhật mật khẩu mới
        public bool CapNhatMatKhau(string username, string newHashedPassword)
        {
            using var db = Db.Create();
            var nv = db.Nhanviens.FirstOrDefault(n => n.Tk == username);
            if (nv == null)
                return false;

            nv.Mk = newHashedPassword;
            return db.SaveChanges() > 0;
        }

        // Xác thực đăng nhập (thay cho sp_CheckDangNhap)
        public NhanVienDTO? DangNhap(string tk, string hashedPassword)
        {
            using var db = Db.Create();
            var nv = db.Nhanviens
                .Where(n => n.Tk == tk && n.Mk == hashedPassword)
                .FirstOrDefault();

            if (nv == null)
                return null;

            return new NhanVienDTO
            {
                Manv = nv.Manv,
                Tk = nv.Tk,
                Hoten = nv.Hoten,
                Vitri = nv.Vitri,
                Sdt = nv.Sdt,
                Email = nv.Email,
                Bank = nv.Bank,
                Stk = nv.Stk,
                Luong = nv.Luong ?? 0m,
                NgaySinh = nv.Ngsinh.HasValue ? nv.Ngsinh.Value.ToDateTime(TimeOnly.MinValue) : default
            };
        }
    }
}
