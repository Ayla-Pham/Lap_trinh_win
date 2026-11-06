using DTO;

namespace DAO
{
    public class DangNhapNVDAO
    {
        public DangNhapNVDTO? DangNhap(string username)
        {
            using var db = Db.Create();
            return db.NHANVIENs
                .Where(nv => nv.Tk == username)
                .Select(nv => new DangNhapNVDTO
                {
                    Manv = nv.Manv,
                    Tk = nv.Tk,
                    Mk = nv.Mk,
                    Hoten = nv.Hoten,
                    Vitri = nv.Vitri
                })
                .FirstOrDefault();
        }
    }
}
