using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ClosedXML.Excel;

namespace BUS
{
    public static class KhoBUS
    {
        public static List<SanPhamTonKhoDTO> LayTatCaSanPham()
        {
            try { return KhoDAO.LayDanhSachTonKho(); }
            catch { return new List<SanPhamTonKhoDTO>(); }
        }

        public static List<SanPhamTonKhoDTO> TimKiemSanPham(string kw)
        {
            if (string.IsNullOrWhiteSpace(kw)) return LayTatCaSanPham();
            try { return KhoDAO.TimKiemTonKho(kw); }
            catch { return new List<SanPhamTonKhoDTO>(); }
        }

        public static List<NhaCungCapDTO> LayNhaCungCap()
        {
            try { return KhoDAO.LayNhaCungCap(); }
            catch { return new List<NhaCungCapDTO>(); }
        }

        public static (bool success, string message) XuLyNhapKho(int? maNCC, string maNV, List<CartItemDTO> listnhapkho)
        {
            // Validate dữ liệu
            if (maNCC == null) return (false, "Chưa chọn nhà cung cấp.");
            if (string.IsNullOrEmpty(maNV)) return (false, "Không xác định được nhân viên.");
            if (listnhapkho == null || !listnhapkho.Any()) return (false, "Danh sách nhập trống.");

            var invalidItems = listnhapkho.Where(x => x.SoLuong <= 0 || x.DonGia <= 0).ToList();
            if (invalidItems.Any())
                return (false, "Có sản phẩm số lượng hoặc giá nhập không hợp lệ.");

            try
            {
                bool result = KhoDAO.NhapKho(maNCC.Value, maNV, listnhapkho);
                if (result) return (true, "Nhập kho thành công!");
                return (false, "Lỗi khi lưu phiếu nhập.");
            }
            catch (Exception ex)
            {
                return (false, "Lỗi hệ thống: " + ex.Message);
            }
        }

        // --- XỬ LÝ XUẤT KHO ---
        public static (bool success, string message) XuLyXuatKho(string maNV, string lyDo, List<CartItemDTO> listxuatkho)
        {
            if (string.IsNullOrEmpty(maNV)) return (false, "Không xác định được nhân viên.");
            if (listxuatkho == null || !listxuatkho.Any()) return (false, "Danh sách xuất trống.");

            if (listxuatkho.Any(x => x.SoLuong <= 0))
                return (false, "Số lượng xuất phải lớn hơn 0.");

            try
            {
                bool result = KhoDAO.XuatKho(maNV, lyDo, listxuatkho);
                if (result) return (true, "Xuất kho thành công!");
                return (false, "Lỗi khi lưu phiếu xuất.");
            }
            catch (Exception ex)
            {
                // Thông báo lỗi cụ thể (ví dụ: không đủ tồn kho) từ SQL ném ra
                return (false, "Lỗi: " + ex.Message);
            }
        }

        // --- LỊCH SỬ ---
        public static List<PhieuNhapDTO> LayLichSuNhap(DateTime? tu, DateTime? den, string tuKhoa = null)
        {
            try { return KhoDAO.LayLichSuNhap(tu, den, tuKhoa); }
            catch { return new List<PhieuNhapDTO>(); }
        }

        public static List<ChiTietKhoDTO> LayChiTietPhieu(int maNK)
        {
            try { return KhoDAO.LayChiTietPhieuNhap(maNK); }
            catch { return new List<ChiTietKhoDTO>(); }
        }

        public static bool XuatExcel(List<PhieuNhapDTO> data, string filePath, DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            if (data == null || data.Count == 0) return false;

            try
            {
                using (var workbook = new XLWorkbook())
                {
                    // SHEET 1: TỔNG QUÁT
                    var ws = workbook.Worksheets.Add("Lịch sử nhập kho");

                    // Header báo cáo
                    string title = "BÁO CÁO LỊCH SỬ NHẬP KHO";
                    if (tuNgay.HasValue && denNgay.HasValue)
                        title += $" ({tuNgay:dd/MM/yyyy} - {denNgay:dd/MM/yyyy})";

                    ws.Cell(1, 1).Value = title;
                    ws.Range("A1:E1").Merge().Style.Font.FontSize = 20;
                    ws.Range("A1:E1").Style.Font.Bold = true;
                    ws.Range("A1:E1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    ws.Cell(2, 1).Value = $"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm}";
                    ws.Range("A2:D2").Merge().Style.Font.Italic = true;

                    // Header bảng
                    ws.Cell(4, 1).Value = "Mã phiếu";
                    ws.Cell(4, 2).Value = "Ngày nhập";
                    ws.Cell(4, 3).Value = "Nhà cung cấp";
                    ws.Cell(4, 4).Value = "Người nhập";
                    ws.Cell(4, 5).Value = "Tổng tiền";

                    var headerRange = ws.Range("A4:E4");
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Data Sheet 1
                    int row = 5;
                    foreach (var item in data)
                    {
                        ws.Cell(row, 1).Value = item.MaNK;
                        ws.Cell(row, 2).Value = item.NgayNhap;
                        ws.Cell(row, 2).Style.DateFormat.Format = "dd/MM/yyyy HH:mm";
                        ws.Cell(row, 3).Value = item.TenNCC;
                        ws.Cell(row, 4).Value = item.TenNhanVien;
                        ws.Cell(row, 5).Value = item.TongTien;
                        ws.Cell(row, 5).Style.NumberFormat.Format = "#,##0";
                        row++;
                    }
                    ws.Columns().AdjustToContents();

                    // SHEET 2: CHI TIẾT
                    var wsDetail = workbook.Worksheets.Add("Chi tiết nhập kho");

                    wsDetail.Cell(1, 1).Value = "Mã phiếu";
                    wsDetail.Cell(1, 2).Value = "Mã SP";
                    wsDetail.Cell(1, 3).Value = "Tên SP";
                    wsDetail.Cell(1, 4).Value = "Số lượng";
                    wsDetail.Cell(1, 5).Value = "Giá nhập";
                    wsDetail.Cell(1, 6).Value = "Thành tiền";

                    var headerDetail = wsDetail.Range("A1:F1");
                    headerDetail.Style.Font.Bold = true;
                    headerDetail.Style.Fill.BackgroundColor = XLColor.LightGray;

                    int r = 2;
                    // Lấy chi tiết cho từng phiếu trong danh sách
                    foreach (var phieu in data)
                    {
                        var chiTietList = LayChiTietPhieu(phieu.MaNK); // Gọi hàm có sẵn trong BUS
                        foreach (var ct in chiTietList)
                        {
                            wsDetail.Cell(r, 1).Value = ct.MaPhieu;
                            wsDetail.Cell(r, 2).Value = ct.MaSP;
                            wsDetail.Cell(r, 3).Value = ct.TenSP;
                            wsDetail.Cell(r, 4).Value = ct.SoLuong;
                            wsDetail.Cell(r, 5).Value = ct.DonGia;
                            wsDetail.Cell(r, 6).Value = ct.ThanhTien;
                            r++;
                        }
                    }
                    wsDetail.Columns().AdjustToContents();

                    workbook.SaveAs(filePath);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<PhieuXuatDTO> LayLichSuXuat(DateTime? tu, DateTime? den, string tuKhoa = null)
        {
            try { return KhoDAO.LayLichSuXuat(tu, den, tuKhoa); }
            catch { return new List<PhieuXuatDTO>(); }
        }

        public static List<ChiTietKhoDTO> LayChiTietPhieuXuat(int maXK)
        {
            try { return KhoDAO.LayChiTietPhieuXuat(maXK); }
            catch { return new List<ChiTietKhoDTO>(); }
        }

        public static bool XuatExcelXuatKho(List<PhieuXuatDTO> data, string filePath, DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            if (data == null || data.Count == 0) return false;

            try
            {
                using (var workbook = new XLWorkbook())
                {
                    // SHEET 1
                    var ws = workbook.Worksheets.Add("Lịch sử xuất kho");
                    string title = "BÁO CÁO LỊCH SỬ XUẤT KHO";
                    if (tuNgay.HasValue && denNgay.HasValue) title += $" ({tuNgay:dd/MM/yyyy} - {denNgay:dd/MM/yyyy})";

                    ws.Cell(1, 1).Value = title;
                    ws.Range("A1:D1").Merge().Style.Font.FontSize = 20;
                    ws.Range("A1:D1").Style.Font.Bold = true;
                    ws.Range("A1:D1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    ws.Cell(4, 1).Value = "Mã phiếu";
                    ws.Cell(4, 2).Value = "Ngày xuất";
                    ws.Cell(4, 3).Value = "Người xuất";
                    ws.Cell(4, 4).Value = "Lý do";
                    ws.Range("A4:D4").Style.Font.Bold = true;
                    ws.Range("A4:D4").Style.Fill.BackgroundColor = XLColor.LightGray;

                    int row = 5;
                    foreach (var item in data)
                    {
                        ws.Cell(row, 1).Value = item.MaXK;
                        ws.Cell(row, 2).Value = item.NgayXuat;
                        ws.Cell(row, 2).Style.DateFormat.Format = "dd/MM/yyyy HH:mm";
                        ws.Cell(row, 3).Value = item.TenNhanVien;
                        ws.Cell(row, 4).Value = item.LyDo;
                        row++;
                    }
                    ws.Columns().AdjustToContents();

                    // SHEET 2: CHI TIẾT
                    var wsDetail = workbook.Worksheets.Add("Chi tiết xuất kho");
                    wsDetail.Cell(1, 1).Value = "Mã phiếu";
                    wsDetail.Cell(1, 2).Value = "Mã SP";
                    wsDetail.Cell(1, 3).Value = "Tên SP";
                    wsDetail.Cell(1, 4).Value = "Số lượng xuất";
                    wsDetail.Range("A1:D1").Style.Font.Bold = true;
                    wsDetail.Range("A1:D1").Style.Fill.BackgroundColor = XLColor.LightGray;

                    int r = 2;
                    foreach (var phieu in data)
                    {
                        var chiTietList = LayChiTietPhieuXuat(phieu.MaXK);
                        foreach (var ct in chiTietList)
                        {
                            wsDetail.Cell(r, 1).Value = ct.MaPhieu;
                            wsDetail.Cell(r, 2).Value = ct.MaSP;
                            wsDetail.Cell(r, 3).Value = ct.TenSP;
                            wsDetail.Cell(r, 4).Value = ct.SoLuong;
                            r++;
                        }
                    }
                    wsDetail.Columns().AdjustToContents();

                    workbook.SaveAs(filePath);
                }
                return true;
            }
            catch { return false; }
        }
    }
}
