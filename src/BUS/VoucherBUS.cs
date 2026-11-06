using System;
using System.Collections.Generic;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class VoucherBUS
    {
        private static VoucherBUS instance;
        public static VoucherBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new VoucherBUS();
                return instance;
            }
            private set { instance = value; }
        }

        private VoucherBUS() { }

        public List<VoucherDTO> GetAllVouchers()
        {
            return VoucherDAO.Instance.GetAllVouchers();
        }

        public List<VoucherDTO> GetVouchersByType(int maloaivc)
        {
            return VoucherDAO.Instance.GetVouchersByType(maloaivc);
        }

        public VoucherDTO GetVoucherByID(int mavc)
        {
            return VoucherDAO.Instance.GetVoucherByID(mavc);
        }

        public bool AddVoucher(VoucherDTO voucher)
        {
            if (voucher == null) return false;

            // Duplicate code check
            if (VoucherDAO.GetIdFromCode(voucher.Code) != null)
                return false;

            // Date validation
            if (voucher.Ngaykt < voucher.Ngaybd)
                return false;

            // Business rule for Giatri depending on Maloaivc
            if (voucher.Maloaivc == 1 || voucher.Maloaivc == 3)
            {
                if (voucher.Giatri <= 0) return false;
            }
            else if (voucher.Maloaivc == 2 || voucher.Maloaivc == 4)
            {
                if (voucher.Giatri != 0) return false;
            }

            try
            {
                return VoucherDAO.Instance.AddVoucher(voucher);
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateVoucher(VoucherDTO voucher)
        {
            if (voucher == null) return false;

            // Check code uniqueness excluding current voucher
            if (Voucher1tang1DAO.Instance.CheckCodeExists(voucher.Code, voucher.Mavc))
                return false;

            // Date validation
            if (voucher.Ngaykt < voucher.Ngaybd)
                return false;

            // Business rule for Giatri depending on Maloaivc
            if (voucher.Maloaivc == 1 || voucher.Maloaivc == 3)
            {
                if (voucher.Giatri <= 0) return false;
            }
            else if (voucher.Maloaivc == 2 || voucher.Maloaivc == 4)
            {
                if (voucher.Giatri != 0) return false;
            }

            try
            {
                return VoucherDAO.Instance.UpdateVoucher(voucher);
            }
            catch
            {
                return false;
            }
        }

        public int UpdateVoucherAndReturnAffectedRows(VoucherDTO voucher)
        {
            if (voucher == null) return 0;

            // basic validation kept in UpdateVoucher; here we delegate to DAO
            try
            {
                return VoucherDAO.Instance.UpdateVoucherAndReturnAffectedRows(voucher);
            }
            catch
            {
                return 0;
            }
        }

        public bool UpdateVoucherChiTiet(int mavc, List<int> maspList)
        {
            try
            {
                return VoucherDAO.Instance.UpdateVoucherChiTiet(mavc, maspList);
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteVoucher(int mavc)
        {
            try
            {
                return VoucherDAO.Instance.DeleteVoucher(mavc);
            }
            catch
            {
                return false;
            }
        }

        public bool CheckCodeExists(string code, int? excludeMavc = null)
        {
            if (string.IsNullOrWhiteSpace(code)) return false;

            if (excludeMavc.HasValue)
            {
                return Voucher1tang1DAO.Instance.CheckCodeExists(code, excludeMavc);
            }

            return VoucherDAO.GetIdFromCode(code) != null;
        }

        public List<VoucherDTO> GetVouchersByDateRange(DateTime from, DateTime to)
        {
            return VoucherDAO.Instance.GetVouchersByDateRange(from, to);
        }

        public static string GetCode(int mavc)
        {
            return VoucherDAO.GetCode(mavc);
        }

        public List<LoaiVoucherDTO> GetVoucherTypes()
        {
            return VoucherDAO.Instance.GetVoucherTypes();
        }

        public bool AddVoucherChiTiet(int mavc, int masp)
        {
            try
            {
                return VoucherDAO.Instance.AddVoucherChiTiet(mavc, masp);
            }
            catch
            {
                return false;
            }
        }

        public bool CheckChiTietVoucher(int mavc, int masp)
        {
            try
            {
                return VoucherDAO.Instance.CheckChiTietVoucher(mavc, masp);
            }
            catch
            {
                return false;
            }
        }

        public int AddVoucherAndGetID(VoucherDTO voucher)
        {
            if (voucher == null) return -1;

            // reuse AddVoucher validations but return inserted id
            if (VoucherDAO.GetIdFromCode(voucher.Code) != null) return -1;
            if (voucher.Ngaykt < voucher.Ngaybd) return -1;
            if ((voucher.Maloaivc == 1 || voucher.Maloaivc == 3) && voucher.Giatri <= 0) return -1;
            if ((voucher.Maloaivc == 2 || voucher.Maloaivc == 4) && voucher.Giatri != 0) return -1;

            try
            {
                return VoucherDAO.Instance.AddVoucherAndReturnID(voucher);
            }
            catch
            {
                return -1;
            }
        }

        public List<VoucherHienThiDTO> GetAllVouchersWithJoin()
        {
            return VoucherDAO.Instance.GetAllVouchersWithJoin();
        }

        public List<VoucherHienThiDTO> GetVouchersByTypeWithJoin(int maloaivc)
        {
            return VoucherDAO.Instance.GetVouchersByTypeWithJoin(maloaivc);
        }

        public static int? GetIdFromCode(string code)
        {
            return VoucherDAO.GetIdFromCode(code);
        }
    }
}