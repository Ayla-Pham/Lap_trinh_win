using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Thông tin chi tiết từng sản phẩm trả hàng
    public class ChiTietTraHangDTO
    {
        public int Masp { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }

    // Thông tin phiếu trả hàng
    public class TraHangDTO
    {
        public int MaTra { get; set; }
        public int MaHD { get; set; }
        public DateTime NgayTra { get; set; }
        public string NhanVien { get; set; }
        public string LyDoTra { get; set; }
        public List<ChiTietTraHangDTO> ChiTiet { get; set; }

        public TraHangDTO()
        {
            ChiTiet = new List<ChiTietTraHangDTO>();
        }
    }

    // Dòng hóa đơn hiển thị ở màn hình trả hàng (tên thuộc tính trùng tên cột lưới)
    public class HoaDonTraHangDTO
    {
        public int Mahd { get; set; }
        public DateTime Ngaylap { get; set; }
        public int? Makh { get; set; }
        public string Manv { get; set; }
        public decimal TongTien { get; set; }
    }

    // Dòng danh sách phiếu trả hàng ở màn hình lịch sử
    public class PhieuTraHangDongDTO
    {
        public int Matra { get; set; }
        public DateTime Ngaytra { get; set; }
        public string TenNhanVien { get; set; }
        public int? Makh { get; set; }
        public string Tenkh { get; set; }
        public string Lydotra { get; set; }
        public decimal TongTien { get; set; }
    }

    // Dòng chi tiết phiếu trả hàng ở màn hình lịch sử
    public class ChiTietPhieuTraDongDTO
    {
        public int Masp { get; set; }
        public string Tensp { get; set; }
        public int Soluong { get; set; }
        public decimal Dongia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}