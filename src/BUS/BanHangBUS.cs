using DAO;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using DAO;
using DTO;
using DAO;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextRectangle = iTextSharp.text.Rectangle;
namespace BUS
{
    public class BanHangBUS
    {
        private BanHangDAO dao = new BanHangDAO();

        // Kiểm tra sản phẩm có phù hợp với loại voucher
        public bool KiemTraSanPhamPhuHopTheoLoai(List<DanhSachSanPhamDTO> danhSach, int maloai)
        {
            return danhSach.Any(sp => !sp.LaSanPhamTang && sp.Maloai == maloai);
        }

        // Tính tổng tiền đơn hàng (không tính sản phẩm tặng)
        public decimal TinhTongTien(List<DanhSachSanPhamDTO> danhSach)
        {
            return danhSach
                .Where(sp => !sp.LaSanPhamTang)
                .Sum(sp => (sp.GiaGoc * sp.SoLuong) - sp.TienGiam);
        }
        // Tính tiền sau khi giảm
        public decimal TinhTienSauGiam(decimal tongTien, decimal giamGia)
        {
            return Math.Max(0, tongTien - giamGia);
        }

        // Lấy danh sách sản phẩm tặng từ proc (DB hiện tại trả Masp-level rows)
        public List<DanhSachSanPhamDTO> LaySanPhamTang(int mavc, int maloaiGoc, string maSanPhamGoc, int soLuongMua, int loaiVC)
        {
            var ds = new List<DanhSachSanPhamDTO>();
            if (loaiVC != 2 && loaiVC != 4)
                return ds;

            // Truy vấn sản phẩm tặng theo loại voucher
            List<DanhSachSanPhamDTO> dsTang = (loaiVC == 2)
                ? dao.GetSanPhamTangByVoucher(mavc)
                : dao.GetSanPhamTangByVoucher(mavc, maloaiGoc, loaiVC);

            var sp = dsTang.FirstOrDefault();
            if (sp != null)
            {
                sp.SoLuong = 1;
                sp.LaSanPhamTang = true;
                sp.MaSanPhamGoc = maSanPhamGoc;
                ds.Add(sp);
            }

            return ds;
        }


        // Chuyển đổi từ DanhSachSanPhamDTO sang BanHangDTO
        public List<BanHangDTO> ChuyenDoiDanhSachBanHang(List<DanhSachSanPhamDTO> danhSach, KetQuaGiamGiaDTO ketQua)
        {
            var danhSachChuyenDoi = new List<BanHangDTO>();

            foreach (var sp in danhSach)
            {
                int resolvedMasp = sp.Masp;
                if (resolvedMasp <= 0)
                {
                    resolvedMasp = int.TryParse(sp.MaSP, out int m) ? m : DanhSachSanPhamBUS.Instance.GetMasp(sp.MaSP);
                }

                var dto = new BanHangDTO
                {
                    Masp = resolvedMasp,
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    SoLuong = sp.LaSanPhamTang ? 1 : sp.SoLuong,
                    GiaGoc = sp.GiaGoc,
                    GiaBan = sp.GiaBan,
                    TienGiam = sp.TienGiam,
                    LaSanPhamTang = sp.LaSanPhamTang,
                    Maloai = sp.Maloai,
                    MaSanPhamGoc = sp.MaSanPhamGoc,
                    SoLuongTon = sp.SoLuongTon,
                    DuongDanAnh = sp.DuongDanAnh,
                    TenLoai = sp.TenLoai,
                    TrangThaiText = sp.TrangThaiText
                };

                danhSachChuyenDoi.Add(dto);
            }

            return danhSachChuyenDoi;
        }

        // Create invoice, invoice lines, apply voucher and decrement stock
        // Giao dịch được thực hiện trong BanHangDAO để đảm bảo toàn vẹn dữ liệu
        public int XuatHoaDon(int? makh, string manv, List<BanHangDTO> danhSachBanHang, int? mavc)
        {
            if (string.IsNullOrWhiteSpace(manv)) throw new ArgumentException("manv is required.", nameof(manv));
            if (danhSachBanHang == null || danhSachBanHang.Count == 0) throw new ArgumentException("No products.", nameof(danhSachBanHang));

            // Calculate totals
            decimal tongTienGoc = danhSachBanHang.Where(s => !s.LaSanPhamTang).Sum(s => s.GiaGoc * s.SoLuong);
            decimal tienGiam = danhSachBanHang.Where(s => !s.LaSanPhamTang).Sum(s => s.TienGiam);
            decimal tongTienSauGiam = Math.Max(0, tongTienGoc - tienGiam);

            return dao.XuatHoaDon(makh, manv, danhSachBanHang, mavc, tongTienGoc, tienGiam, tongTienSauGiam);
        }

        // Export invoice to PDF. Uses same font path convention as forms.
        public void XuatHoaDonPDF(HoaDonDTO hoaDon, List<DanhSachSanPhamDTO> danhSach, string filePath)
        {
            if (hoaDon == null) throw new ArgumentNullException(nameof(hoaDon));
            if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentException("Invalid file path.", nameof(filePath));

            string FONT_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts", "times.ttf");
            BaseFont vietnameseFont = null;
            if (!File.Exists(FONT_PATH))
            {
                // Fallback to built-in font (may not render Vietnamese accents)
                vietnameseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            }
            else
            {
                vietnameseFont = BaseFont.CreateFont(FONT_PATH, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            }

            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(vietnameseFont, 16f, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(vietnameseFont, 12f, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font normalFont = new iTextSharp.text.Font(vietnameseFont, 10f, iTextSharp.text.Font.NORMAL);

            Document document = new Document(PageSize.A4, 25f, 25f, 30f, 30f);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Header
            var title = new Paragraph("HÓA ĐƠN BÁN HÀNG", titleFont) { Alignment = Element.ALIGN_CENTER, SpacingAfter = 10f };
            document.Add(title);

            var infoTable = new PdfPTable(2) { WidthPercentage = 100 };
            infoTable.SetWidths(new float[] { 1f, 2f });

            infoTable.AddCell(new PdfPCell(new Phrase("Mã HĐ", headerFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });
            infoTable.AddCell(new PdfPCell(new Phrase(hoaDon.MaHD.ToString(), normalFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });

            infoTable.AddCell(new PdfPCell(new Phrase("Ngày lập", headerFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });
            infoTable.AddCell(new PdfPCell(new Phrase(hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm"), normalFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });

            infoTable.AddCell(new PdfPCell(new Phrase("Nhân viên", headerFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });
            infoTable.AddCell(new PdfPCell(new Phrase(hoaDon.TenNhanVien ?? "", normalFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });

            infoTable.AddCell(new PdfPCell(new Phrase("Khách hàng", headerFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });
            infoTable.AddCell(new PdfPCell(new Phrase(hoaDon.TenKH ?? "(Khách lẻ)", normalFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });

            infoTable.SpacingAfter = 10f;
            document.Add(infoTable);

            // Items table
            document.Add(new Paragraph("SẢN PHẨM:", headerFont) { SpacingAfter = 5f });
            PdfPTable itemTable = new PdfPTable(4) { WidthPercentage = 100 };
            itemTable.SetWidths(new float[] { 5f, 1f, 2f, 2f });

            itemTable.AddCell(new PdfPCell(new Phrase("Tên sản phẩm", headerFont)) { Padding = 5 });
            itemTable.AddCell(new PdfPCell(new Phrase("SL", headerFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
            itemTable.AddCell(new PdfPCell(new Phrase("Đơn giá", headerFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
            itemTable.AddCell(new PdfPCell(new Phrase("Thành tiền", headerFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });

            foreach (var sp in danhSach.Where(s => !s.LaSanPhamTang))
            {
                itemTable.AddCell(new PdfPCell(new Phrase(sp.TenSP ?? "", normalFont)) { Padding = 5 });
                itemTable.AddCell(new PdfPCell(new Phrase(sp.SoLuong.ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
                itemTable.AddCell(new PdfPCell(new Phrase(sp.GiaBan.ToString("N0") + " đ", normalFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
                decimal thanhTien = sp.GiaBan * sp.SoLuong - sp.TienGiam;
                itemTable.AddCell(new PdfPCell(new Phrase(thanhTien.ToString("N0") + " đ", normalFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
            }

            // Gift items
            var gifts = danhSach.Where(s => s.LaSanPhamTang).ToList();
            if (gifts.Any())
            {
                itemTable.AddCell(new PdfPCell(new Phrase("---- Sản phẩm tặng ----", headerFont)) { Colspan = 4, HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5 });
                foreach (var g in gifts)
                {
                    itemTable.AddCell(new PdfPCell(new Phrase(g.TenSP ?? "", normalFont)) { Padding = 5 });
                    itemTable.AddCell(new PdfPCell(new Phrase(g.SoLuong.ToString(), normalFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
                    itemTable.AddCell(new PdfPCell(new Phrase("0 đ", normalFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
                    itemTable.AddCell(new PdfPCell(new Phrase("0 đ", normalFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
                }
            }

            itemTable.SpacingAfter = 10f;
            document.Add(itemTable);

            // Totals
            PdfPTable totTable = new PdfPTable(2) { WidthPercentage = 40, HorizontalAlignment = Element.ALIGN_RIGHT };
            totTable.AddCell(new PdfPCell(new Phrase("Tổng tiền gốc", headerFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });
            totTable.AddCell(new PdfPCell(new Phrase(hoaDon.TongTienGoc.ToString("N0") + " đ", normalFont)) { Border = iTextRectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });

            totTable.AddCell(new PdfPCell(new Phrase("Tiền giảm", headerFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });
            totTable.AddCell(new PdfPCell(new Phrase(hoaDon.TienGiam.ToString("N0") + " đ", normalFont)) { Border = iTextRectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });

            totTable.AddCell(new PdfPCell(new Phrase("Tổng phải trả", headerFont)) { Border = iTextRectangle.NO_BORDER, Padding = 5 });
            totTable.AddCell(new PdfPCell(new Phrase(hoaDon.TongTien.ToString("N0") + " đ", normalFont)) { Border = iTextRectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });

            document.Add(totTable);

            document.Close();
            writer.Close();
        }

        // Update stock after payment (static so callers can call without instance)
        public static bool CapNhatTonKhoSauThanhToan(List<DanhSachSanPhamDTO> danhSach)
        {
            if (danhSach == null || danhSach.Count == 0) return true;

            try
            {
                foreach (var sp in danhSach.Where(s => !s.LaSanPhamTang))
                {
                    // Use DAO.Instance to call stored procedure sp_TruTonKho
                    BanHangDAO.Instance.TruTonKho(sp.Masp, sp.SoLuong);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public KetQuaGiamGiaDTO ApDungMaGiamGia(string code, List<DanhSachSanPhamDTO> danhSachMua)
        {
            var result = new KetQuaGiamGiaDTO
            {
                SanPhamTang = new List<BanHangDTO>(),
                SanPhamDuocGiam = new List<DanhSachSanPhamDTO>(),
                Loi = ""
            };

            if (string.IsNullOrWhiteSpace(code))
            {
                result.Loi = "Mã giảm giá rỗng.";
                return result;
            }

            var mua = (danhSachMua ?? new List<DanhSachSanPhamDTO>()).Where(s => !s.LaSanPhamTang).ToList();
            if (!mua.Any())
            {
                result.Loi = "Vui lòng chọn sản phẩm trước khi áp dụng mã giảm giá.";
                return result;
            }

            int? mavc = VoucherBUS.GetIdFromCode(code);
            if (!mavc.HasValue || mavc.Value <= 0)
            {
                result.Loi = "Mã giảm giá không tồn tại.";
                return result;
            }

            var voucher = VoucherBUS.Instance.GetVoucherByID(mavc.Value);
            if (voucher == null)
            {
                result.Loi = "Không lấy được thông tin mã giảm giá.";
                return result;
            }

            DateTime today = DateTime.Today;
            if (voucher.Ngaybd.Date > today || voucher.Ngaykt.Date < today)
            {
                result.Loi = "Mã giảm giá chưa đến hạn hoặc đã hết hạn.";
                return result;
            }

            decimal tongTien = TinhTongTien(danhSachMua);
            result.TongTien = tongTien;

            if (voucher.DieuKien.HasValue && voucher.DieuKien.Value > 0 && tongTien < voucher.DieuKien.Value)
            {
                result.Loi = $"Yêu cầu đơn hàng tối thiểu {voucher.DieuKien.Value:N0} đ để áp mã.";
                return result;
            }

            if (voucher.Maloai.HasValue && voucher.Maloai.Value > 0)
            {
                if (!KiemTraSanPhamPhuHopTheoLoai(danhSachMua, voucher.Maloai.Value))
                {
                    result.Loi = "Mã giảm giá không áp dụng cho sản phẩm đã chọn.";
                    return result;
                }
            }

            // Buy-1-get-1
            if (voucher.Maloaivc == 2 || voucher.Maloaivc == 4)
            {
                var sanPhamMua = mua.First();
                var dsTang = LaySanPhamTang(mavc.Value, sanPhamMua.Maloai, sanPhamMua.MaSP, sanPhamMua.SoLuong, voucher.Maloaivc);
                foreach (var t in dsTang)
                {
                    result.SanPhamTang.Add(new BanHangDTO
                    {
                        Masp = t.Masp,
                        MaSP = t.MaSP,
                        TenSP = t.TenSP,
                        GiaBan = 0,
                        GiaGoc = 0,
                        SoLuong = t.SoLuong,
                        Maloai = t.Maloai,
                        DuongDanAnh = t.DuongDanAnh,
                        TenLoai = t.TenLoai,
                        TrangThaiText = t.TrangThaiText,
                        LaSanPhamTang = true,
                        MaSanPhamGoc = t.MaSanPhamGoc,
                        SoLuongTon = t.SoLuongTon
                    });
                }

                result.LoaiVC = voucher.Maloaivc;
                result.GiaTri = voucher.Giatri;
                result.TienGiam = 0;
                return result;
            }

            // Value / percent discounts
            decimal tienGiam = 0m;
            if (voucher.Maloaivc == 1) // 1 = percent
            {
                decimal percentFactor = voucher.Giatri <= 1m ? voucher.Giatri : voucher.Giatri / 100m;
                tienGiam = Math.Round(tongTien * percentFactor, 0, MidpointRounding.AwayFromZero);
            }
            else if (voucher.Maloaivc == 3) // 3 = fixed amount
            {
                tienGiam = voucher.Giatri;
            }
            else
            {
                // fallback: treat as fixed
                tienGiam = voucher.Giatri;
            }

            if (tienGiam <= 0)
            {
                result.Loi = "Mã giảm giá không có giá trị giảm.";
                return result;
            }

            var eligibles = danhSachMua.Where(s => !s.LaSanPhamTang &&
                                                   (!voucher.Maloai.HasValue || voucher.Maloai.Value == 0 || s.Maloai == voucher.Maloai.Value))
                                       .ToList();

            if (!eligibles.Any())
            {
                result.Loi = "Không có sản phẩm hợp lệ để áp mã giảm giá.";
                return result;
            }

            decimal sumEligible = eligibles.Sum(s => s.GiaGoc * s.SoLuong);
            if (sumEligible <= 0)
            {
                result.Loi = "Dữ liệu giá sản phẩm không hợp lệ.";
                return result;
            }

            decimal assignedSum = 0m;
            foreach (var sp in eligibles)
            {
                decimal portion = (sp.GiaGoc * sp.SoLuong) / sumEligible;
                decimal share = Math.Round(tienGiam * portion, 0, MidpointRounding.AwayFromZero);
                sp.TienGiam = share;
                assignedSum += share;
                result.SanPhamDuocGiam.Add(sp);
            }

            decimal diff = tienGiam - assignedSum;
            if (diff != 0 && result.SanPhamDuocGiam.Count > 0)
            {
                result.SanPhamDuocGiam[0].TienGiam += diff;
            }

            result.TienGiam = tienGiam;
            result.GiaTri = voucher.Giatri;
            result.LoaiVC = voucher.Maloaivc;
            result.Loi = "";

            return result;
        }
    }
}