using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Voucher
{
    public int Mavc { get; set; }

    public string? TenMaGiamGia { get; set; }

    public string Code { get; set; } = null!;

    public decimal Giatri { get; set; }

    public DateOnly Ngaybd { get; set; }

    public DateOnly Ngaykt { get; set; }

    public decimal? DieuKien { get; set; }

    public int Maloaivc { get; set; }

    public int? Maloai { get; set; }

    public virtual Loaisp? MaloaiNavigation { get; set; }

    public virtual Kieuvc MaloaivcNavigation { get; set; } = null!;

    public virtual ICollection<Hoadon> Mahds { get; set; } = new List<Hoadon>();

    public virtual ICollection<Sanpham> Masps { get; set; } = new List<Sanpham>();
}
