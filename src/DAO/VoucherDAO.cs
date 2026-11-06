using DTO;

namespace DAO
{
    public class VoucherDAO
    {
        private static VoucherDAO? instance;
        public static VoucherDAO Instance => instance ??= new VoucherDAO();

        private static VOUCHER ToEntity(VoucherDTO v) => new VOUCHER
        {
            Code = v.Code,
            TenMaGiamGia = v.TenMaGiamGia,
            Giatri = v.Giatri,
            Ngaybd = v.Ngaybd.Date,
            Ngaykt = v.Ngaykt.Date,
            DieuKien = v.DieuKien,
            Maloaivc = v.Maloaivc,
            Maloai = v.Maloai
        };

        private static void CopyTo(VoucherDTO v, VOUCHER e)
        {
            e.Code = v.Code;
            e.TenMaGiamGia = v.TenMaGiamGia;
            e.Giatri = v.Giatri;
            e.Ngaybd = v.Ngaybd.Date;
            e.Ngaykt = v.Ngaykt.Date;
            e.DieuKien = v.DieuKien;
            e.Maloaivc = v.Maloaivc;
            e.Maloai = v.Maloai;
        }

        private static IQueryable<VoucherDTO> ToDTO(IQueryable<VOUCHER> q) =>
            q.Select(v => new VoucherDTO
            {
                Mavc = v.Mavc,
                Code = v.Code,
                TenMaGiamGia = v.TenMaGiamGia,
                Giatri = v.Giatri,
                Ngaybd = v.Ngaybd,
                Ngaykt = v.Ngaykt,
                DieuKien = v.DieuKien,
                Maloaivc = v.Maloaivc,
                Maloai = v.Maloai
            });

        public static string GetCode(int mavc)
        {
            using var db = Db.Create();
            return db.VOUCHERs.Where(v => v.Mavc == mavc).Select(v => v.Code).FirstOrDefault() ?? "";
        }

        public static int? GetIdFromCode(string code)
        {
            using var db = Db.Create();
            string c = code ?? string.Empty;
            return db.VOUCHERs.Where(v => v.Code == c).Select(v => (int?)v.Mavc).FirstOrDefault();
        }

        public bool AddVoucher(VoucherDTO voucher)
        {
            return AddVoucherAndReturnID(voucher) > 0;
        }

        // Gán một sản phẩm cho voucher (bảng VOUCHER_SANPHAM)
        public bool AddVoucherChiTiet(int mavc, int masp)
        {
            using var db = Db.Create();
            if (!db.VOUCHERs.Any(v => v.Mavc == mavc) || !db.SANPHAMs.Any(s => s.Masp == masp))
                return false;
            if (db.VOUCHER_SANPHAMs.Any(x => x.Mavc == mavc && x.Masp == masp))
                return false;

            db.VOUCHER_SANPHAMs.InsertOnSubmit(new VOUCHER_SANPHAM { Mavc = mavc, Masp = masp });
            return db.Save() > 0;
        }

        public bool CheckChiTietVoucher(int mavc, int masp)
        {
            using var db = Db.Create();
            return db.VOUCHER_SANPHAMs.Any(x => x.Mavc == mavc && x.Masp == masp);
        }

        public VoucherDTO? GetVoucherByID(int mavc)
        {
            using var db = Db.Create();
            return ToDTO(db.VOUCHERs.Where(v => v.Mavc == mavc)).FirstOrDefault();
        }

        public bool UpdateVoucher(VoucherDTO voucher)
        {
            return UpdateVoucherAndReturnAffectedRows(voucher) > 0;
        }

        // Xóa voucher cùng các liên kết sản phẩm và lịch sử áp dụng
        public bool DeleteVoucher(int mavc)
        {
            using var db = Db.Create();
            var v = db.VOUCHERs.FirstOrDefault(x => x.Mavc == mavc);
            if (v == null) return false;

            db.VOUCHER_SANPHAMs.DeleteAllOnSubmit(db.VOUCHER_SANPHAMs.Where(x => x.Mavc == mavc));
            db.APMAVCs.DeleteAllOnSubmit(db.APMAVCs.Where(x => x.Mavc == mavc));
            db.VOUCHERs.DeleteOnSubmit(v);
            return db.Save() > 0;
        }

        public List<VoucherDTO> GetAllVouchers()
        {
            using var db = Db.Create();
            return ToDTO(db.VOUCHERs.OrderBy(v => v.Mavc)).ToList();
        }

        public List<VoucherDTO> GetVouchersByType(int maloaivc)
        {
            using var db = Db.Create();
            return ToDTO(db.VOUCHERs.Where(v => v.Maloaivc == maloaivc).OrderBy(v => v.Mavc)).ToList();
        }

        // Danh sách voucher kèm tên loại, loại sản phẩm, sản phẩm áp dụng / tặng
        private static List<VoucherHienThiDTO> HienThi(QLCHDataContext db, IQueryable<VOUCHER> q)
        {
            var rows = q.OrderBy(v => v.Mavc)
                .Select(v => new
                {
                    v.Mavc,
                    v.Code,
                    v.TenMaGiamGia,
                    v.Giatri,
                    v.Ngaybd,
                    v.Ngaykt,
                    v.DieuKien,
                    v.Maloaivc,
                    v.Maloai,
                    TenLoaiVouCher = v.KIEUVC.Tenloai,
                    TenLoaiSP = v.LOAISP != null ? v.LOAISP.Tenloai : null
                })
                .ToList();

            // Sản phẩm gắn với từng voucher (truy vấn riêng rồi gom nhóm)
            var dsMavc = rows.Select(r => r.Mavc).ToList();
            var sanPhams = (from vs in db.VOUCHER_SANPHAMs
                            where dsMavc.Contains(vs.Mavc)
                            select new { vs.Mavc, vs.SANPHAM.Tensp, TenLoai = vs.SANPHAM.LOAISP.Tenloai })
                           .ToList()
                           .ToLookup(x => x.Mavc);

            return rows.Select(r =>
            {
                bool laMua1Tang1 = r.Maloaivc == 2 || r.Maloaivc == 4;
                var sp = sanPhams[r.Mavc].ToList();
                string tenSP = string.Join(", ", sp.Select(x => x.Tensp));
                string tenLoaiSP = string.Join(", ", sp.Select(x => x.TenLoai).Distinct());
                return new VoucherHienThiDTO
                {
                    Mavc = r.Mavc,
                    Code = r.Code,
                    TenMaGiamGia = r.TenMaGiamGia,
                    Giatri = r.Giatri,
                    Ngaybd = r.Ngaybd,
                    Ngaykt = r.Ngaykt,
                    DieuKien = r.DieuKien,
                    Maloaivc = r.Maloaivc,
                    Maloai = r.Maloai,
                    TenLoaiVouCher = r.TenLoaiVouCher,
                    TenLoaiSanPhamApDung = r.TenLoaiSP,
                    TenLoaiSanPhamTang = laMua1Tang1 ? tenLoaiSP : null,
                    SanPhamApDung = laMua1Tang1 ? null : tenSP,
                    SanPhamTang = laMua1Tang1 ? tenSP : null
                };
            }).ToList();
        }

        public List<VoucherHienThiDTO> GetAllVouchersWithJoin()
        {
            using var db = Db.Create();
            return HienThi(db, db.VOUCHERs);
        }

        public List<VoucherHienThiDTO> GetVouchersByTypeWithJoin(int maloaivc)
        {
            using var db = Db.Create();
            return HienThi(db, db.VOUCHERs.Where(v => v.Maloaivc == maloaivc));
        }

        public List<VoucherDTO> GetVouchersByDateRange(DateTime from, DateTime to)
        {
            using var db = Db.Create();
            var f = from.Date;
            var t = to.Date;
            // voucher có thời gian hiệu lực giao với khoảng [from, to]
            return ToDTO(db.VOUCHERs
                    .Where(v => v.Ngaybd <= t && v.Ngaykt >= f)
                    .OrderBy(v => v.Mavc))
                .ToList();
        }

        public List<LoaiVoucherDTO> GetVoucherTypes()
        {
            using var db = Db.Create();
            return db.KIEUVCs
                .OrderBy(k => k.Maloaivc)
                .Select(k => new LoaiVoucherDTO { Maloaivc = k.Maloaivc, Tenloai = k.Tenloai })
                .ToList();
        }

        public int AddVoucherAndReturnID(VoucherDTO voucher)
        {
            using var db = Db.Create();
            var e = ToEntity(voucher);
            db.VOUCHERs.InsertOnSubmit(e);
            db.Save();
            return e.Mavc;
        }

        public int UpdateVoucherAndReturnAffectedRows(VoucherDTO voucher)
        {
            using var db = Db.Create();
            var e = db.VOUCHERs.FirstOrDefault(v => v.Mavc == voucher.Mavc);
            if (e == null) return 0;
            CopyTo(voucher, e);
            return db.Save();
        }

        // Thay toàn bộ sản phẩm của voucher bằng danh sách mới
        public bool UpdateVoucherChiTiet(int mavc, List<int> maspList)
        {
            using var db = Db.Create();
            if (!db.VOUCHERs.Any(x => x.Mavc == mavc)) return false;

            db.VOUCHER_SANPHAMs.DeleteAllOnSubmit(db.VOUCHER_SANPHAMs.Where(x => x.Mavc == mavc));
            db.SubmitChanges();

            var tonTai = db.SANPHAMs.Where(s => maspList.Contains(s.Masp)).Select(s => s.Masp).ToList();
            db.VOUCHER_SANPHAMs.InsertAllOnSubmit(tonTai.Select(m => new VOUCHER_SANPHAM { Mavc = mavc, Masp = m }));
            db.SubmitChanges();
            return true;
        }
    }
}
