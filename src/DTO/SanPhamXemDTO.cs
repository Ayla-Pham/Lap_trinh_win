namespace DTO
{
    // Dòng hiển thị trên lưới xem sản phẩm của nhân viên (tên thuộc tính trùng tên cột lưới)
    public class SanPhamXemDTO
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string TenLoai { get; set; }
        public int Maloai { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string DuongDanAnh { get; set; }
        public int CanhBaoTon { get; set; }
        public bool TrangThai { get; set; }
    }
}
