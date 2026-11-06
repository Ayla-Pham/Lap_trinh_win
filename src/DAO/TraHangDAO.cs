using DTO;

namespace DAO
{
    public class TraHangDAO
    {
        // Danh sách hóa đơn (mới nhất trước), có thể lọc theo mã hóa đơn
        public List<HoaDonTraHangDTO> GetDanhSachHoaDon(string tuKhoa = "")
        {
            using var db = Db.Create();
            var q = db.HOADONs.AsQueryable();
            if (!string.IsNullOrEmpty(tuKhoa))
                q = q.Where(h => h.Mahd.ToString().Contains(tuKhoa));

            return q.OrderByDescending(h => h.Ngaylap)
                    .Select(h => new HoaDonTraHangDTO
                    {
                        Mahd = h.Mahd,
                        Ngaylap = h.Ngaylap,
                        Makh = h.Makh,
                        Manv = h.Manv,
                        TongTien = h.TongTien
                    })
                    .ToList();
        }

        // Chi tiết các sản phẩm của hóa đơn
        public List<ChiTietTraHangDTO> GetChiTietHoaDon(int maHD)
        {
            using var db = Db.Create();
            return db.CHITIETHDs
                .Where(ct => ct.Mahd == maHD)
                .Select(ct => new ChiTietTraHangDTO
                {
                    Masp = ct.Masp,
                    TenSP = ct.SANPHAM.Tensp,
                    SoLuong = ct.Soluong,
                    DonGia = ct.Dongia
                })
                .ToList();
        }

        // Danh sách phiếu trả hàng (lọc theo mã phiếu / tên nhân viên / tên khách)
        public List<PhieuTraHangDongDTO> GetDanhSachPhieuTra(string tuKhoa = "")
        {
            using var db = Db.Create();
            var q = db.TRAHANGs.AsQueryable();
            if (!string.IsNullOrEmpty(tuKhoa))
                q = q.Where(th => th.Matra.ToString().Contains(tuKhoa)
                               || th.NHANVIEN.Hoten.Contains(tuKhoa)
                               || (th.HOADON.KHACHHANG != null
                                   && th.HOADON.KHACHHANG.Tenkh.Contains(tuKhoa)));

            return q.OrderByDescending(th => th.Ngaytra)
                    .Select(th => new PhieuTraHangDongDTO
                    {
                        Matra = th.Matra,
                        Ngaytra = th.Ngaytra,
                        TenNhanVien = th.NHANVIEN.Hoten,
                        Makh = th.HOADON.Makh,
                        Tenkh = th.HOADON.KHACHHANG != null
                                    ? th.HOADON.KHACHHANG.Tenkh : null,
                        Lydotra = th.Lydotra,
                        TongTien = th.HOADON.TongTien
                    })
                    .ToList();
        }

        // Chi tiết của một phiếu trả hàng
        public List<ChiTietPhieuTraDongDTO> GetChiTietPhieuTra(int matra)
        {
            using var db = Db.Create();
            return db.CTTRAHANGs
                .Where(c => c.Matra == matra)
                .Select(c => new ChiTietPhieuTraDongDTO
                {
                    Masp = c.Masp,
                    Tensp = c.SANPHAM.Tensp,
                    Soluong = c.Soluong,
                    Dongia = c.Dongia,
                    ThanhTien = c.Soluong * c.Dongia
                })
                .ToList();
        }

        // Thêm phiếu trả hàng, trả về mã phiếu
        public int ThemTraHang(int maHD, string manv, string lyDo)
        {
            using var db = Db.Create();
            var th = new TRAHANG { Mahd = maHD, Manv = manv, Lydotra = lyDo, Ngaytra = DateTime.Now };
            db.TRAHANGs.InsertOnSubmit(th);
            db.SubmitChanges();
            return th.Matra;
        }

        // Thêm chi tiết trả hàng và cộng lại tồn kho
        public void ThemChiTietTraHang(int maTra, int masp, int soluong, decimal dongia)
        {
            using var db = Db.Create();
            db.CTTRAHANGs.InsertOnSubmit(new CTTRAHANG { Matra = maTra, Masp = masp, Soluong = soluong, Dongia = dongia });
            var sp = db.SANPHAMs.First(s => s.Masp == masp);
            sp.Soluongton += soluong;
            db.SubmitChanges();   // SubmitChanges tự chạy trong một giao dịch
        }

        // Trả toàn bộ hóa đơn trong một giao dịch: tạo phiếu, chi tiết, cộng tồn kho
        public int TraToanBoHoaDon(int maHD, string manv, string lyDo)
        {
            using var db = Db.Create();
            int maTra = 0;

            db.RunInTransaction(() =>
            {
                var th = new TRAHANG { Mahd = maHD, Manv = manv, Lydotra = lyDo, Ngaytra = DateTime.Now };
                db.TRAHANGs.InsertOnSubmit(th);
                db.SubmitChanges();

                var chiTiet = db.CHITIETHDs.Where(ct => ct.Mahd == maHD).ToList();
                var dsMasp = chiTiet.Select(ct => ct.Masp).Distinct().ToList();
                var sanPhams = db.SANPHAMs.Where(s => dsMasp.Contains(s.Masp)).ToDictionary(s => s.Masp);

                foreach (var ct in chiTiet)
                {
                    db.CTTRAHANGs.InsertOnSubmit(new CTTRAHANG
                    {
                        Matra = th.Matra,
                        Masp = ct.Masp,
                        Soluong = ct.Soluong,
                        Dongia = ct.Dongia
                    });
                    sanPhams[ct.Masp].Soluongton += ct.Soluong;
                }
                db.SubmitChanges();
                maTra = th.Matra;
            });

            return maTra;
        }
    }
}
