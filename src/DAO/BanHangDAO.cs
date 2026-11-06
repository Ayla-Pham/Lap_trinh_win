using DAO.Models;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class BanHangDAO
    {
        private static BanHangDAO? instance;
        public static BanHangDAO Instance => instance ??= new BanHangDAO();

        public bool KiemTraSanPhamPhuHopTheoLoai(List<DanhSachSanPhamDTO> danhSach, int maloai)
        {
            return danhSach.Any(sp => !sp.LaSanPhamTang && sp.Maloai == maloai);
        }

        // Sản phẩm tặng của voucher (mua 1 tặng 1): loại 2 chỉ tặng sản phẩm cùng loại với sản phẩm mua
        public List<DanhSachSanPhamDTO> GetSanPhamTangByVoucher(int mavc, int? maloaiGoc = null, int? loaiVC = null)
        {
            using var db = Db.Create();
            var q = db.Vouchers
                .AsNoTracking()
                .Where(v => v.Mavc == mavc)
                .SelectMany(v => v.Masps)
                .Where(s => s.Trangthaisp);

            if (loaiVC == 2 && maloaiGoc.HasValue)
                q = q.Where(s => s.Maloai == maloaiGoc.Value);

            return q.OrderBy(s => s.Masp)
                .Select(s => new
                {
                    s.Masp,
                    s.Tensp,
                    s.Duongdananh,
                    s.Giaban,
                    s.Maloai,
                    TenLoai = s.MaloaiNavigation.Tenloai,
                    s.Soluongton,
                    s.Trangthaisp
                })
                .ToList()
                .Select(s => new DanhSachSanPhamDTO
                {
                    Masp = s.Masp,
                    MaSP = s.Masp.ToString(),
                    TenSP = s.Tensp,
                    DuongDanAnh = s.Duongdananh,
                    GiaBan = s.Giaban,
                    Maloai = s.Maloai,
                    TenLoai = s.TenLoai,
                    SoLuongTon = s.Soluongton,
                    TrangThaiText = s.Trangthaisp ? "Đang bán" : "Ngừng bán"
                })
                .ToList();
        }

        // Trừ tồn kho theo mã sản phẩm
        public void TruTonKho(int masp, int soLuong)
        {
            using var db = Db.Create();
            var sp = db.Sanphams.FirstOrDefault(s => s.Masp == masp)
                     ?? throw new InvalidOperationException("Không tìm thấy sản phẩm.");
            if (sp.Soluongton < soLuong)
                throw new InvalidOperationException("Số lượng tồn không đủ.");

            sp.Soluongton -= soLuong;
            db.SaveChanges();
        }

        // Lập hóa đơn trong một giao dịch: hóa đơn, chi tiết, áp mã giảm giá, trừ tồn kho
        public int XuatHoaDon(int? makh, string manv, List<BanHangDTO> danhSachBanHang, int? mavc,
                              decimal tongTienGoc, decimal tienGiam, decimal tongTienSauGiam)
        {
            using var db = Db.Create();
            using var tran = db.Database.BeginTransaction();
            try
            {
                // 1) Hóa đơn
                var hoaDon = new Hoadon
                {
                    Makh = makh,
                    Manv = manv,
                    Ngaylap = DateTime.Now,
                    TongTienGoc = tongTienGoc,
                    TienGiam = tienGiam,
                    TongTien = tongTienSauGiam
                };
                db.Hoadons.Add(hoaDon);
                db.SaveChanges();

                // 2) Chi tiết: gộp theo Masp + IsTang để không vi phạm khóa chính (Mahd, Masp, IsTang)
                var dong = danhSachBanHang
                    .GroupBy(s => new { s.Masp, s.LaSanPhamTang })
                    .Select(g => new
                    {
                        g.Key.Masp,
                        IsTang = g.Key.LaSanPhamTang,
                        Soluong = g.Sum(x => x.SoLuong),
                        Dongia = g.First().GiaBan
                    })
                    .ToList();

                foreach (var d in dong)
                {
                    if (d.Masp <= 0 || d.Soluong <= 0 || d.Dongia < 0)
                        throw new ArgumentException("Dữ liệu sản phẩm không hợp lệ.");

                    db.Chitiethds.Add(new Chitiethd
                    {
                        Mahd = hoaDon.Mahd,
                        Masp = d.Masp,
                        Soluong = d.Soluong,
                        Dongia = d.Dongia,
                        IsTang = d.IsTang
                    });
                }

                // 3) Áp dụng voucher (bảng APMAVC)
                if (mavc.HasValue)
                {
                    var voucher = db.Vouchers.FirstOrDefault(v => v.Mavc == mavc.Value)
                                  ?? throw new InvalidOperationException("Voucher không tồn tại.");
                    hoaDon.Mavcs.Add(voucher);
                }

                // 4) Trừ tồn kho cho sản phẩm không phải hàng tặng
                var dsMasp = dong.Where(d => !d.IsTang).Select(d => d.Masp).ToList();
                var sanPhams = db.Sanphams.Where(s => dsMasp.Contains(s.Masp)).ToDictionary(s => s.Masp);
                foreach (var d in dong.Where(d => !d.IsTang))
                {
                    var sp = sanPhams[d.Masp];
                    if (sp.Soluongton < d.Soluong)
                        throw new InvalidOperationException($"Sản phẩm \"{sp.Tensp}\" không đủ tồn kho.");
                    sp.Soluongton -= d.Soluong;
                }

                db.SaveChanges();
                tran.Commit();
                return hoaDon.Mahd;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        private static BanHangDTO ToBanHang(Sanpham s) => new BanHangDTO
        {
            Masp = s.Masp,
            MaSP = s.Masp.ToString(),
            TenSP = s.Tensp,
            TenLoai = s.MaloaiNavigation.Tenloai,
            GiaBan = s.Giaban,
            DuongDanAnh = s.Duongdananh ?? string.Empty,
            Maloai = s.Maloai,
            SoLuongTon = s.Soluongton,
            TrangThaiText = s.Trangthaisp ? "Đang bán" : "Ngừng bán"
        };

        // Tất cả sản phẩm
        public List<BanHangDTO> LayTatCaSanPham()
        {
            using var db = Db.Create();
            return db.Sanphams
                .AsNoTracking()
                .Include(s => s.MaloaiNavigation)
                .OrderBy(s => s.Masp)
                .ToList()
                .Select(ToBanHang)
                .ToList();
        }

        // Tìm kiếm theo tên hoặc mã
        public List<BanHangDTO> TimKiemSanPham(string searchType, string keyword)
        {
            using var db = Db.Create();
            var q = db.Sanphams.AsNoTracking().Include(s => s.MaloaiNavigation).AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
                q = q.Where(s => s.Tensp.Contains(keyword) || s.Masp.ToString().Contains(keyword));

            return q.OrderBy(s => s.Masp).ToList().Select(ToBanHang).ToList();
        }
    }
}
