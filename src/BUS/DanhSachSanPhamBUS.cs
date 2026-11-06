using DAO;
using DTO;
using System.Transactions;
using DAO;
using DTO;
using System.Transactions;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class DanhSachSanPhamBUS
    {
        private DanhSachSanPhamDAO sanPhamDAO = DanhSachSanPhamDAO.Instance;
        private static DanhSachSanPhamBUS instance;
        public static DanhSachSanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachSanPhamBUS();
                return instance;
            }
            private set { instance = value; }
        }

        // Search / read operations (unchanged behavior)
        public List<DanhSachSanPhamDTO> SearchSanPham(string searchType, string searchTerm)
        {
            return DanhSachSanPhamDAO.Instance.SearchSanPham(searchType, searchTerm);
        }

        public List<LoaiSPDTO> GetLoaiSanPham()
        {
            return DanhSachSanPhamDAO.Instance.GetLoaiSanPham();
        }

        public List<DanhSachSanPhamDTO> GetAllSanPham()
        {
            return DanhSachSanPhamDAO.Instance.GetAllSanPham();
        }

        public List<int> GetChiTietVoucher(int mavc)
        {
            return DanhSachSanPhamDAO.Instance.GetChiTietVoucher(mavc);
        }

        public List<SanPhamXemDTO> GetSanPhamWithVoucher()
        {
            return DanhSachSanPhamDAO.Instance.GetSanPhamWithVoucher();
        }

        public SanPhamDTO GetSanPhamTheoMaVaKichCo(string maSP, string kichCo)
        {
            // 'kichCo' parameter kept for compatibility but ignored by DAO since sizes removed.
            return DanhSachSanPhamDAO.Instance.GetSanPhamTheoMaVaKichCo(maSP, kichCo);
        }

        public List<SanPhamTangDTO> GetSanPhamTangByVoucher(int mavc)
        {
            return Voucher1tang1DAO.Instance.GetSanPhamTangByVoucher(mavc);
        }

        // Toggle product status by Masp
        public bool ToggleTrangThaiSanPham(int masp)
        {
            return DanhSachSanPhamDAO.Instance.ToggleTrangThaiSanPham(masp);
        }

        // Delete product (backward-compatible signature)
        public bool DeleteSanPham(int idKichCoSP, string maSP)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    // In current schema we delete SANPHAM by masp (idKichCoSP parameter historically mapped to masp).
                    bool deleteSuccess = sanPhamDAO.DeleteSanPham(idKichCoSP);

                    if (!deleteSuccess) return false;

                    // Count legacy KICHCOSP rows (may be zero)
                    int remainingSizes = sanPhamDAO.CountKichCoSP(maSP);

                    if (remainingSizes == 0)
                    {
                        sanPhamDAO.DeleteSanPhamGoc(maSP);
                    }

                    scope.Complete();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Resolve numeric Masp from MaSP string
        public int GetMasp(string maSP)
        {
            return sanPhamDAO.GetMasp(maSP);
        }

        // -----------------------
        // Merged "Them/Sua" functionality (use stored procedures via DAO)
        // -----------------------

        public bool AddSanPham(SanPhamDTO sp)
        {
            if (sp == null) throw new ArgumentNullException(nameof(sp));
            if (string.IsNullOrWhiteSpace(sp.TenSP)) throw new ArgumentException("Tên sản phẩm không được để trống.", nameof(sp));
            if (sp.MaLoai <= 0) throw new ArgumentException("Vui lòng chọn loại sản phẩm hợp lệ.", nameof(sp));
            if (sp.GiaBan <= 0) throw new ArgumentException("Giá bán phải lớn hơn 0.", nameof(sp));

            // Call DAO which uses stored procedure sp_ThemSanPham_Moi
            return sanPhamDAO.InsertSanPham(sp);
        }

        public bool UpdateSanPham(SanPhamDTO sp)
        {
            if (sp == null) throw new ArgumentNullException(nameof(sp));
            if (sp.Masp <= 0) throw new ArgumentException("MaSP (Masp) không hợp lệ.", nameof(sp));
            if (string.IsNullOrWhiteSpace(sp.TenSP)) throw new ArgumentException("Tên sản phẩm không được để trống.", nameof(sp));
            if (sp.MaLoai <= 0) throw new ArgumentException("Vui lòng chọn loại sản phẩm hợp lệ.", nameof(sp));
            if (sp.GiaBan < 0) throw new ArgumentException("Giá bán không hợp lệ.", nameof(sp));

            // Call DAO which uses stored procedure sp_SuaSanPham_Moi
            return sanPhamDAO.UpdateSanPham(sp);
        }
    }
}