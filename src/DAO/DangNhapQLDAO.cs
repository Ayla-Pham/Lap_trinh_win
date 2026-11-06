using DTO;

namespace DAO
{
    public class DangNhapQLDAO
    {
        public DangNhapQLDTO? Dangnhap(string username)
        {
            using var db = Db.Create();
            return db.Nhanviens
                .Where(nv => nv.Tk == username && nv.Manv.StartsWith("AD"))
                .Select(nv => new DangNhapQLDTO
                {
                    Manv = nv.Manv,
                    Tk = nv.Tk,
                    Mk = nv.Mk,
                    Hoten = nv.Hoten
                })
                .FirstOrDefault();
        }
    }
}
