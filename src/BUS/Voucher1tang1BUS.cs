using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace BUS
{
    public class Voucher1tang1BUS
    {
        private static Voucher1tang1BUS instance;
        public static Voucher1tang1BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new Voucher1tang1BUS();
                return instance;
            }
        }

        private Voucher1tang1BUS() { }

        // Thêm mã giảm giá mua 1 tặng 1
        public bool ThemVoucher(string code, string tenMa, int loaiVC, int maloai, decimal dieuKien, DateTime ngaybd, DateTime ngaykt, List<int> dsTang)
        {
            int result = Voucher1tang1DAO.Instance.InsertVoucher(code, tenMa, loaiVC, maloai, dieuKien, ngaybd, ngaykt);
            if (result <= 0) return false;

            int mavc = Voucher1tang1DAO.Instance.GetVoucherId(code);
            if (mavc <= 0) return false;

            foreach (int idkcsp in dsTang)
            {
                int inserted = Voucher1tang1DAO.Instance.InsertChiTietVC(mavc, idkcsp);
                if (inserted <= 0)
                {
                    return false;
                }
            }

            return true;
        }
        // Tìm kiếm sản phẩm tặng theo từ khóa
        public List<SanPhamTangDTO> TimSanPhamTang(string keyword)
        {
            return Voucher1tang1DAO.Instance.SearchSanPhamTang(keyword);
        }
        public bool CapNhatVoucher(int mavc, string code, string tenMaGiamGia, int loaiVC, int maloai, decimal dieuKien, List<int> dsTang)
        {
            bool ok = Voucher1tang1DAO.Instance.UpdateVoucher(mavc, code, tenMaGiamGia, loaiVC, maloai, dieuKien);
            if (!ok) return false;

            Voucher1tang1DAO.Instance.DeleteChiTietVC(mavc);

            foreach (int idkcsp in dsTang)
            {
                int inserted = Voucher1tang1DAO.Instance.InsertChiTietVC(mavc, idkcsp);
                if (inserted <= 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static string GetCode(int mavc)
        {
            return Voucher1tang1DAO.GetCode(mavc);
        }

        public VoucherDTO GetVoucherByID(int mavc)
        {
            return Voucher1tang1DAO.Instance.GetVoucherByID(mavc);
        }

        public List<SanPhamTangDTO> GetSanPhamTangByVoucher(int mavc)
        {
            return Voucher1tang1DAO.Instance.GetSanPhamTangByVoucher(mavc);
        }
        public List<SanPhamTangDTO> TimSanPhamTangTheoLoai(int maloai)
        {
            return Voucher1tang1DAO.Instance.TimSanPhamTangTheoLoai(maloai);
        }
        public bool CheckCodeExists(string code, int? excludeMavc = null)
        {
            return Voucher1tang1DAO.Instance.CheckCodeExists(code, excludeMavc);
        }
    }
}
