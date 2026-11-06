using DAO.Models;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class KhoDAO
    {
        // --- PHẦN 1: TỒN KHO ---
        private static IQueryable<SanPhamTonKhoDTO> ToTonKho(IQueryable<Sanpham> q) =>
            q.OrderBy(s => s.Masp).Select(s => new SanPhamTonKhoDTO
            {
                MaSP = s.Masp,
                TenSP = s.Tensp,
                SoLuongTon = s.Soluongton,
                CanhBaoTon = s.Canhbaotonkho,
                GiaBan = s.Giaban
            });

        public static List<SanPhamTonKhoDTO> LayDanhSachTonKho()
        {
            using var db = Db.Create();
            return ToTonKho(db.Sanphams.AsNoTracking().Where(s => s.Trangthaisp)).ToList();
        }

        public static List<SanPhamTonKhoDTO> TimKiemTonKho(string keyword)
        {
            using var db = Db.Create();
            return ToTonKho(db.Sanphams.AsNoTracking()
                    .Where(s => s.Trangthaisp
                                && (s.Tensp.Contains(keyword) || s.Masp.ToString().Contains(keyword))))
                .ToList();
        }

        public static List<NhaCungCapDTO> LayNhaCungCap()
        {
            using var db = Db.Create();
            return db.Nhacungcaps
                .AsNoTracking()
                .Select(n => new NhaCungCapDTO { Manhacc = n.Manhacc, Tennhacc = n.Tennhacc })
                .ToList();
        }

        // --- PHẦN 2: NHẬP KHO (TRANSACTION) ---
        public static bool NhapKho(int maNCC, string maNV, List<CartItemDTO> listnhapkho)
        {
            using var db = Db.Create();
            using var trans = db.Database.BeginTransaction();
            try
            {
                // 1. Tạo phiếu nhập
                var phieu = new Nhapkho { Manhacc = maNCC, Manv = maNV, Ngaynhap = DateTime.Now };
                db.Nhapkhos.Add(phieu);
                db.SaveChanges();

                // 2. Thêm chi tiết và cộng tồn kho
                foreach (var item in listnhapkho)
                {
                    db.Chitietnhapkhos.Add(new Chitietnhapkho
                    {
                        Mank = phieu.Mank,
                        Masp = item.MaSP,
                        Soluongnhap = item.SoLuong,
                        Gianhap = item.DonGia
                    });

                    var sp = db.Sanphams.First(s => s.Masp == item.MaSP);
                    sp.Soluongton += item.SoLuong;
                }
                db.SaveChanges();

                trans.Commit();
                return true;
            }
            catch (Exception)
            {
                trans.Rollback();
                throw; // Ném lỗi về BUS xử lý
            }
        }

        // --- PHẦN 3: XUẤT KHO (TRANSACTION) ---
        public static bool XuatKho(string maNV, string lyDo, List<CartItemDTO> listxuatkho)
        {
            using var db = Db.Create();
            using var trans = db.Database.BeginTransaction();
            try
            {
                // 1. Tạo phiếu xuất
                var phieu = new Xuatkho { Manv = maNV, LyDoxuat = lyDo, NgayXuat = DateTime.Now };
                db.Xuatkhos.Add(phieu);
                db.SaveChanges();

                // 2. Thêm chi tiết xuất và trừ tồn kho (kiểm tra tồn trước)
                foreach (var item in listxuatkho)
                {
                    var sp = db.Sanphams.First(s => s.Masp == item.MaSP);
                    if (sp.Soluongton < item.SoLuong)
                        throw new InvalidOperationException("Số lượng tồn không đủ để xuất");

                    db.Chitietxuatkhos.Add(new Chitietxuatkho
                    {
                        MaXk = phieu.MaXk,
                        Masp = item.MaSP,
                        SoLuongXuat = item.SoLuong
                    });
                    sp.Soluongton -= item.SoLuong;
                }
                db.SaveChanges();

                trans.Commit();
                return true;
            }
            catch (Exception)
            {
                trans.Rollback();
                throw;
            }
        }

        // --- PHẦN 4: LỊCH SỬ ---
        public static List<PhieuNhapDTO> LayLichSuNhap(DateTime? tuNgay, DateTime? denNgay, string tuKhoa)
        {
            using var db = Db.Create();
            var q = db.Nhapkhos.AsNoTracking().AsQueryable();

            if (tuNgay.HasValue)
            {
                var tu = tuNgay.Value.Date;
                q = q.Where(n => n.Ngaynhap >= tu);
            }
            if (denNgay.HasValue)
            {
                var den = denNgay.Value.Date.AddDays(1);
                q = q.Where(n => n.Ngaynhap < den);
            }
            if (!string.IsNullOrEmpty(tuKhoa))
                q = q.Where(n => n.ManhaccNavigation.Tennhacc.Contains(tuKhoa)
                              || n.ManvNavigation.Hoten.Contains(tuKhoa)
                              || n.Mank.ToString().Contains(tuKhoa));

            return q.OrderByDescending(n => n.Ngaynhap)
                .Select(n => new PhieuNhapDTO
                {
                    MaNK = n.Mank,
                    NgayNhap = n.Ngaynhap,
                    TenNCC = n.ManhaccNavigation.Tennhacc,
                    TenNhanVien = n.ManvNavigation.Hoten,
                    TongTien = n.Chitietnhapkhos.Sum(ct => (decimal?)(ct.Soluongnhap * ct.Gianhap)) ?? 0m
                })
                .ToList();
        }

        public static List<ChiTietKhoDTO> LayChiTietPhieuNhap(int maNK)
        {
            using var db = Db.Create();
            return db.Chitietnhapkhos
                .AsNoTracking()
                .Where(ct => ct.Mank == maNK)
                .Select(ct => new ChiTietKhoDTO
                {
                    MaPhieu = ct.Mank,
                    MaSP = ct.Masp,
                    TenSP = ct.MaspNavigation.Tensp,
                    SoLuong = ct.Soluongnhap,
                    DonGia = ct.Gianhap,
                    TenNhanVien = ct.MankNavigation.ManvNavigation.Hoten
                })
                .ToList();
        }

        public static List<PhieuXuatDTO> LayLichSuXuat(DateTime? tuNgay, DateTime? denNgay, string tuKhoa)
        {
            using var db = Db.Create();
            var q = db.Xuatkhos.AsNoTracking().AsQueryable();

            if (tuNgay.HasValue)
            {
                var tu = tuNgay.Value.Date;
                q = q.Where(x => x.NgayXuat >= tu);
            }
            if (denNgay.HasValue)
            {
                var den = denNgay.Value.Date.AddDays(1);
                q = q.Where(x => x.NgayXuat < den);
            }
            if (!string.IsNullOrEmpty(tuKhoa))
                q = q.Where(x => x.ManvNavigation.Hoten.Contains(tuKhoa)
                              || (x.LyDoxuat != null && x.LyDoxuat.Contains(tuKhoa))
                              || x.MaXk.ToString().Contains(tuKhoa));

            return q.OrderByDescending(x => x.NgayXuat)
                .Select(x => new PhieuXuatDTO
                {
                    MaXK = x.MaXk,
                    NgayXuat = x.NgayXuat,
                    TenNhanVien = x.ManvNavigation.Hoten,
                    LyDo = x.LyDoxuat ?? string.Empty
                })
                .ToList();
        }

        public static List<ChiTietKhoDTO> LayChiTietPhieuXuat(int maXK)
        {
            using var db = Db.Create();
            return db.Chitietxuatkhos
                .AsNoTracking()
                .Where(ct => ct.MaXk == maXK)
                .Select(ct => new ChiTietKhoDTO
                {
                    MaPhieu = ct.MaXk,
                    MaSP = ct.Masp,
                    TenSP = ct.MaspNavigation.Tensp,
                    SoLuong = ct.SoLuongXuat,
                    DonGia = 0,          // Xuất kho không lưu giá trong chi tiết
                    TenNhanVien = ""     // Không dùng
                })
                .ToList();
        }
    }
}
