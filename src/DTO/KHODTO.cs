using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamTonKhoDTO
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public int CanhBaoTon { get; set; }
        public bool IsLowStock => SoLuongTon <= CanhBaoTon; // Logic cảnh báo
    }

    public class PhieuNhapDTO
    {
        public int MaNK { get; set; }
        public DateTime NgayNhap { get; set; }
        public string TenNCC { get; set; }
        public string TenNhanVien { get; set; }
        public decimal TongTien { get; set; }
    }
    public class PhieuXuatDTO
    {
        public int MaXK { get; set; }
        public DateTime NgayXuat { get; set; }
        public string TenNhanVien { get; set; }
        public string LyDo { get; set; }
    }
    public class ChiTietKhoDTO
    {
        public int MaPhieu { get; set; }
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; } 
        public decimal ThanhTien => SoLuong * DonGia;
        public string TenNhanVien { get; set; }
    }

    public class CartItemDTO
    {
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; } 
    }
}