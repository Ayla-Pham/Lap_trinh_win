using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO? instance;
        public static KhachHangDAO Instance => instance ??= new KhachHangDAO();

        public KhachHangDAO() { }

        public static List<KhachHangDTO> layDSKH()
        {
            using var db = Db.Create();
            return db.KHACHHANGs
                
                .Select(k => new KhachHangDTO(k.Makh, k.Tenkh, k.Sdt, k.Tichdiem))
                .ToList();
        }

        public static string GetTenKhachHang(int maKH)
        {
            using var db = Db.Create();
            return db.KHACHHANGs
                .Where(k => k.Makh == maKH)
                .Select(k => k.Tenkh)
                .FirstOrDefault() ?? "Khách lẻ";
        }

        public static string GetSDTKhachHang(int maKH)
        {
            using var db = Db.Create();
            return db.KHACHHANGs
                .Where(k => k.Makh == maKH)
                .Select(k => k.Sdt)
                .FirstOrDefault() ?? "";
        }

        public static string LayTenKhachHangTheoSDT(string sdt)
        {
            using var db = Db.Create();
            return db.KHACHHANGs
                .Where(k => k.Sdt == sdt)
                .Select(k => k.Tenkh)
                .FirstOrDefault() ?? "Khách lẻ";
        }

        public static void themKH(KhachHangDTO kh)
        {
            using var db = Db.Create();
            db.KHACHHANGs.InsertOnSubmit(new KHACHHANG
            {
                Tenkh = kh.Tenkh,
                Sdt = kh.Sdt,
                Tichdiem = kh.Tichdiem
            });
            db.Save();
        }

        public static void xoaKH(int makh)
        {
            using var db = Db.Create();
            var entity = db.KHACHHANGs.FirstOrDefault(k => k.Makh == makh);
            if (entity == null) return;
            db.KHACHHANGs.DeleteOnSubmit(entity);
            db.Save();
        }

        public static void suaKH(KhachHangDTO kh)
        {
            using var db = Db.Create();
            var entity = db.KHACHHANGs.FirstOrDefault(k => k.Makh == kh.Makh);
            if (entity == null) return;
            entity.Tenkh = kh.Tenkh;
            entity.Sdt = kh.Sdt;
            entity.Tichdiem = kh.Tichdiem;
            db.Save();
        }

        public static List<KhachHangDTO> timTheoTenHoacSDT(string keyword)
        {
            using var db = Db.Create();
            return db.KHACHHANGs
                
                .Where(k => k.Tenkh.Contains(keyword) || k.Sdt.Contains(keyword))
                .Select(k => new KhachHangDTO(k.Makh, k.Tenkh, k.Sdt, k.Tichdiem))
                .ToList();
        }

        public List<KhachHangDTO> TimKiemTheoSDT(string sdt)
        {
            using var db = Db.Create();
            return db.KHACHHANGs
                
                .Where(k => k.Sdt.Contains(sdt))
                .Select(k => new KhachHangDTO { Makh = k.Makh, Tenkh = k.Tenkh, Sdt = k.Sdt })
                .ToList();
        }
    }
}
