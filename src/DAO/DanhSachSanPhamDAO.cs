using DTO;

namespace DAO
{
    public class DanhSachSanPhamDAO
    {
        private static DanhSachSanPhamDAO? instance;
        public static DanhSachSanPhamDAO Instance => instance ??= new DanhSachSanPhamDAO();

        private static string TrangThaiText(bool dangBan) => dangBan ? "Đang bán" : "Ngừng bán";

        // Danh sách loại sản phẩm (dùng cho ComboBox)
        public List<LoaiSPDTO> GetLoaiSanPham()
        {
            using var db = Db.Create();
            return db.LOAISPs
                
                .Select(l => new LoaiSPDTO { MaLoai = l.Maloai, TenLoai = l.Tenloai })
                .ToList();
        }

        private static List<DanhSachSanPhamDTO> Lay(string? tuKhoa, int maLoai)
        {
            using var db = Db.Create();
            var q = db.SANPHAMs.AsQueryable();

            if (!string.IsNullOrWhiteSpace(tuKhoa))
                q = q.Where(sp => sp.Tensp.Contains(tuKhoa) || sp.Masp.ToString().Contains(tuKhoa));

            if (maLoai != 0)
                q = q.Where(sp => sp.Maloai == maLoai);

            return q.OrderBy(sp => sp.Masp)
                .Select(sp => new
                {
                    sp.Masp,
                    sp.Tensp,
                    TenLoai = sp.LOAISP.Tenloai,
                    sp.Maloai,
                    sp.Giaban,
                    sp.Soluongton,
                    sp.Duongdananh,
                    sp.Trangthaisp
                })
                .ToList()
                .Select(x => new DanhSachSanPhamDTO
                {
                    Masp = x.Masp,
                    MaSP = x.Masp.ToString(),
                    TenSP = x.Tensp,
                    TenLoai = x.TenLoai,
                    Maloai = x.Maloai,
                    GiaBan = x.Giaban,
                    SoLuongTon = x.Soluongton,
                    TrangThaiText = TrangThaiText(x.Trangthaisp),
                    DuongDanAnh = x.Duongdananh
                })
                .ToList();
        }

        public List<DanhSachSanPhamDTO> GetAllSanPham()
        {
            return Lay(null, 0);
        }

        public List<DanhSachSanPhamDTO> SearchSanPham(string searchType, string searchTerm)
        {
            return Lay(searchTerm, 0);
        }

        // Danh sách sản phẩm đầy đủ cột cho nhân viên xem (tên thuộc tính trùng tên cột lưới)
        public List<SanPhamXemDTO> GetSanPhamWithVoucher()
        {
            using var db = Db.Create();
            return db.SANPHAMs
                
                .OrderBy(sp => sp.Masp)
                .Select(sp => new SanPhamXemDTO
                {
                    MaSP = sp.Masp,
                    TenSP = sp.Tensp,
                    TenLoai = sp.LOAISP.Tenloai,
                    Maloai = sp.Maloai,
                    GiaBan = sp.Giaban,
                    SoLuongTon = sp.Soluongton,
                    DuongDanAnh = sp.Duongdananh,
                    CanhBaoTon = sp.Canhbaotonkho,
                    TrangThai = sp.Trangthaisp
                })
                .ToList();
        }

        // Đổi trạng thái đang bán / ngừng bán
        public bool ToggleTrangThaiSanPham(int masp)
        {
            using var db = Db.Create();
            var sp = db.SANPHAMs.FirstOrDefault(s => s.Masp == masp);
            if (sp == null) return false;
            sp.Trangthaisp = !sp.Trangthaisp;
            return db.Save() > 0;
        }

        // Các sản phẩm gắn với voucher
        public List<int> GetChiTietVoucher(int mavc)
        {
            using var db = Db.Create();
            return db.VOUCHER_SANPHAMs
                .Where(vs => vs.Mavc == mavc)
                .Select(vs => vs.Masp)
                .ToList();
        }

        // Xóa cứng sản phẩm
        public bool DeleteSanPham(int masp)
        {
            using var db = Db.Create();
            var sp = db.SANPHAMs.FirstOrDefault(s => s.Masp == masp);
            if (sp == null) return false;
            db.SANPHAMs.DeleteOnSubmit(sp);
            return db.Save() > 0;
        }

        // Legacy/compat: sizes removed — return 0
        public int CountKichCoSP(string maSP)
        {
            return 0;
        }

        public bool DeleteSanPhamGoc(string maSP)
        {
            int masp = GetMasp(maSP);
            if (masp == 0) return false;
            return DeleteSanPham(masp);
        }

        // Thông tin một sản phẩm
        public SanPhamDTO? GetSanPhamTheoMaVaKichCo(string maSP, string kichco)
        {
            if (string.IsNullOrWhiteSpace(maSP)) return null;

            int masp = GetMasp(maSP);
            if (masp == 0) return null;

            using var db = Db.Create();
            var x = db.SANPHAMs.FirstOrDefault(s => s.Masp == masp);
            if (x == null) return null;

            return new SanPhamDTO
            {
                Masp = x.Masp,
                MaSP = x.Masp.ToString(),
                TenSP = x.Tensp,
                MaLoai = x.Maloai,
                SoLuongTon = x.Soluongton,
                TrangThaiText = TrangThaiText(x.Trangthaisp),
                DuongDanAnh = x.Duongdananh,
                GiaBan = x.Giaban,
                CanhBaoTonKho = x.Canhbaotonkho
            };
        }

        // Xác định mã sản phẩm số từ chuỗi mã (0 nếu không có)
        public int GetMasp(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP)) return 0;
            if (!int.TryParse(maSP, out int masp)) return 0;

            using var db = Db.Create();
            return db.SANPHAMs.Any(s => s.Masp == masp) ? masp : 0;
        }

        public bool InsertSanPham(SanPhamDTO sp)
        {
            if (sp == null) return false;

            using var db = Db.Create();
            db.SANPHAMs.InsertOnSubmit(new SANPHAM
            {
                Tensp = sp.TenSP ?? string.Empty,
                Maloai = sp.MaLoai,
                Giaban = sp.GiaBan,
                Canhbaotonkho = sp.CanhBaoTonKho,
                Duongdananh = sp.DuongDanAnh ?? string.Empty,
                Soluongton = 0,
                Trangthaisp = true
            });
            return db.Save() > 0;
        }

        public bool UpdateSanPham(SanPhamDTO sp)
        {
            if (sp == null) return false;

            using var db = Db.Create();
            var e = db.SANPHAMs.FirstOrDefault(s => s.Masp == sp.Masp);
            if (e == null) return false;

            e.Tensp = sp.TenSP ?? string.Empty;
            e.Maloai = sp.MaLoai;
            e.Giaban = sp.GiaBan;
            e.Canhbaotonkho = sp.CanhBaoTonKho;
            if (!string.IsNullOrWhiteSpace(sp.DuongDanAnh))
                e.Duongdananh = sp.DuongDanAnh;   // giữ ảnh cũ nếu không chọn ảnh mới
            return db.Save() > 0;
        }
    }
}
