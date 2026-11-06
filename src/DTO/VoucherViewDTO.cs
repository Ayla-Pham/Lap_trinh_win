using System;

namespace DTO
{
    // Loại voucher (bảng KIEUVC) dùng cho ComboBox
    public class LoaiVoucherDTO
    {
        public int Maloaivc { get; set; }
        public string Tenloai { get; set; }
    }

    // Dòng hiển thị trên lưới quản lý voucher (tên thuộc tính trùng tên cột lưới)
    public class VoucherHienThiDTO
    {
        public int Mavc { get; set; }
        public string Code { get; set; }
        public string TenMaGiamGia { get; set; }
        public decimal Giatri { get; set; }
        public DateTime Ngaybd { get; set; }
        public DateTime Ngaykt { get; set; }
        public decimal? DieuKien { get; set; }
        public int Maloaivc { get; set; }
        public int? Maloai { get; set; }
        public string TenLoaiVouCher { get; set; }
        public string TenLoaiSanPhamApDung { get; set; }
        public string TenLoaiSanPhamTang { get; set; }
        public string SanPhamApDung { get; set; }
        public string SanPhamTang { get; set; }
    }

    // Sản phẩm (dùng cho lưới chọn sản phẩm tặng)
    public class SanPhamTangDTO
    {
        public int Masp { get; set; }
        public string Tensp { get; set; }
        public int Maloai { get; set; }
    }
}
