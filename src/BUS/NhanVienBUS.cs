using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Text.RegularExpressions;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BUS
{
    public class NhanVienBUS
    {
        public static bool IsValidUsername(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z0-9]+$");
        }
        public static bool IsValidMaNhanVien(string maNhanVien)
        {
            return Regex.IsMatch(maNhanVien, @"^(NV|AD)\d{2}$", RegexOptions.IgnoreCase);
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            string basicRegex = @"^[a-zA-Z0-9!@#$%^&*()_+\-=\[\]{};':\\|,.?\/`~]+$";

            if (!Regex.IsMatch(password, basicRegex))
            {
                return false;
            }
            return true;
        }
        public static bool themNV(NhanVienDTO nv)
        {
            // mã nhân viên
            if (NhanVienDAO.KiemTraTonTaiMaNV(nv.Manv))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng chọn mã khác.", "Lỗi Kiểm tra Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // tên tk
            if (NhanVienDAO.KiemTraTonTaiTenTaiKhoan(nv.Tk))
            {
                MessageBox.Show("Tên tài khoản '" + nv.Tk + "' đã được sử dụng. Vui lòng chọn tên khác.", "Lỗi Kiểm tra Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // mật khẩu
            if (!IsValidPassword(nv.Mk))
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Vui lòng đảm bảo mật khẩu chỉ chứa chữ cái, số, ký tự đặc biệt và không có khoảng trắng.", "Lỗi Kiểm tra Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(nv.Hoten) || string.IsNullOrWhiteSpace(nv.Tk) || string.IsNullOrWhiteSpace(nv.Mk))
            {
                MessageBox.Show("Họ tên, Tên tài khoản và Mật khẩu không được để trống.", "Lỗi Kiểm tra Dữ liệu");
                return false;
            }
            //sdt
            if (NhanVienDAO.KiemTraTonTaiSdt(nv.Sdt))
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng cho nhân viên khác.", "Lỗi Kiểm tra Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //email
            if (NhanVienDAO.KiemTraTonTaiEmail(nv.Email))
            {
                MessageBox.Show("Địa chỉ Email này đã được sử dụng cho nhân viên khác.", "Lỗi Kiểm tra Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string originalPassword = nv.Mk;
            nv.Mk = HashPassword(originalPassword);
            // lương
            if (nv.Luong < 0)
            {
                MessageBox.Show("Lương (tiền lương theo giờ hoặc lương cố định) không được là số âm.", "Lỗi Kiểm tra Dữ liệu");
                return false;
            }
            // số dt
            if (!Regex.IsMatch(nv.Sdt, @"^\d{10,11}$"))
            {
                MessageBox.Show("Số điện thoại phải từ 10 đến 11 số và chỉ chứa số.", "Lỗi Kiểm tra Dữ liệu");
                return false;
            }
            // email
            if (!Regex.IsMatch(nv.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không đúng định dạng.", "Lỗi Kiểm tra Dữ liệu");
                return false;
            }

            if (string.IsNullOrWhiteSpace(nv.Hoten) || string.IsNullOrWhiteSpace(nv.Tk) || string.IsNullOrWhiteSpace(nv.Mk))
            {
                MessageBox.Show("Họ tên, Tên tài khoản và Mật khẩu không được để trống.", "Lỗi Kiểm tra Dữ liệu");
                return false;
            }

            try
            {
                NhanVienDAO.themNV(nv);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi DAO khi thêm nhân viên: " + ex.Message, "Lỗi Database");
                return false;
            }
        }

        public static bool SuaNV(NhanVienDTO nv)
        {
            if (NhanVienDAO.KiemTraTonTaiTenTaiKhoanKhac(nv.Tk, nv.Manv))
            {
                MessageBox.Show("Tên tài khoản '" + nv.Tk + "' đã được sử dụng bởi nhân viên khác.", "Lỗi Kiểm tra Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // mật khẩu
            if (!IsValidPassword(nv.Mk))
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Vui lòng đảm bảo mật khẩu chỉ chứa chữ cái, số, ký tự đặc biệt và không có khoảng trắng.", "Lỗi Kiểm tra Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string originalPassword = nv.Mk;
            nv.Mk = HashPassword(originalPassword);

            if (NhanVienDAO.KiemTraTonTaiSdtKhac(nv.Sdt, nv.Manv))
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng cho nhân viên khác.", "Lỗi Kiểm tra Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (NhanVienDAO.KiemTraTonTaiEmailKhac(nv.Email, nv.Manv))
            {
                MessageBox.Show("Địa chỉ Email này đã được sử dụng cho nhân viên khác.", "Lỗi Kiểm tra Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nv.Luong < 0)
            {
                MessageBox.Show("Lương không được là số âm.", "Lỗi Kiểm tra Dữ liệu");
                return false;
            }

            if (!Regex.IsMatch(nv.Sdt, @"^\d{10,11}$"))
            {
                MessageBox.Show("Số điện thoại phải từ 10 đến 11 số và chỉ chứa số.", "Lỗi Kiểm tra Dữ liệu");
                return false;
            }

            if (!Regex.IsMatch(nv.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không đúng định dạng.", "Lỗi Kiểm tra Dữ liệu");
                return false;
            }

            if (string.IsNullOrWhiteSpace(nv.Hoten) || string.IsNullOrWhiteSpace(nv.Tk) || string.IsNullOrWhiteSpace(nv.Mk))
            {
                MessageBox.Show("Họ tên, Tên tài khoản và Mật khẩu không được để trống.", "Lỗi Kiểm tra Dữ liệu");
                return false;
            }

            if (string.IsNullOrWhiteSpace(nv.Manv))
            {
                MessageBox.Show("Không tìm thấy Mã nhân viên để sửa.", "Lỗi Nghiệp vụ");
                return false;
            }

            try
            {
                NhanVienDAO.SuaNV(nv);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi DAO khi sửa nhân viên: " + ex.Message, "Lỗi Database");
                return false;
            }
        }

        public static bool XoaNV(string maNV)
        {
            try
            {
                NhanVienDAO.XoaNV(maNV);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi DAO khi xóa nhân viên: " + ex.Message, "Lỗi Database");
                return false;
            }
        }

        public static NhanVienDTO LayNhanVienTheoID(string id)
        {
            return NhanVienDAO.LayNhanVienTheoID(id);
        }
        public static string GetTenNguoiDung(string mand)
        {
            return NhanVienDAO.LayTenNhanVien(mand);
        }
        public static List<NhanVienGridDTO> LayDanhSachNhanVien()
        {
            return NhanVienDAO.LayDanhSachNhanVien();
        }

        public static List<NhanVienGridDTO> TimKiemNhanVien(string keyword)
        {
            return NhanVienDAO.TimKiemNhanVien(keyword);
        }

        public static List<NhanVienDTO> LayNhanVienTheoGio()
        {
            return NhanVienDAO.LayNhanVienTheoGio();
        }
    }
}
