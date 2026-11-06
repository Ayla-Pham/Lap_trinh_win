using System;

namespace DTO
{
    // Dòng hiển thị trên lưới danh sách nhân viên (tên thuộc tính trùng tên cột)
    public class NhanVienGridDTO
    {
        public string Manv { get; set; }
        public string Tk { get; set; }
        public string Mk { get; set; }
        public string Vitri { get; set; }
        public string Hoten { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public DateTime? Ngsinh { get; set; }
        public string Diachi { get; set; }
        public decimal Luong { get; set; }
        public string Bank { get; set; }
        public string Stk { get; set; }
    }
}
