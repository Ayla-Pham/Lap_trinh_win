using System.Collections.Generic;
using DAO;
using DTO;

namespace BUS
{
    public class TraHangBUS
    {
        private TraHangDAO dao = new TraHangDAO();

        public List<HoaDonTraHangDTO> GetDanhSachHoaDon(string tuKhoa = "")
        {
            return dao.GetDanhSachHoaDon(tuKhoa);
        }

        public List<ChiTietTraHangDTO> GetChiTietHoaDon(int maHD)
        {
            return dao.GetChiTietHoaDon(maHD);
        }

        public List<PhieuTraHangDongDTO> GetDanhSachPhieuTra(string tuKhoa = "")
        {
            return dao.GetDanhSachPhieuTra(tuKhoa);
        }

        public List<ChiTietPhieuTraDongDTO> GetChiTietPhieuTra(int matra)
        {
            return dao.GetChiTietPhieuTra(matra);
        }

        public int TaoTraHang(int maHD, string manv, string lyDo, List<ChiTietTraHangDTO> chiTiet)
        {
            int maTra = dao.ThemTraHang(maHD, manv, lyDo);
            foreach (var item in chiTiet)
            {
                dao.ThemChiTietTraHang(maTra, item.Masp, item.SoLuong, item.DonGia);
            }
            return maTra;
        }

        // Trả toàn bộ hóa đơn (một giao dịch)
        public int TraToanBoHoaDon(int maHD, string manv, string lyDo)
        {
            return dao.TraToanBoHoaDon(maHD, manv, lyDo);
        }
    }
}
