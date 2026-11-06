using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Hoadon
{
    public int Mahd { get; set; }

    public DateTime Ngaylap { get; set; }

    public int? Makh { get; set; }

    public string Manv { get; set; } = null!;

    public decimal TongTienGoc { get; set; }

    public decimal TienGiam { get; set; }

    public decimal TongTien { get; set; }

    public virtual ICollection<Chitiethd> Chitiethds { get; set; } = new List<Chitiethd>();

    public virtual Khachhang? MakhNavigation { get; set; }

    public virtual Nhanvien ManvNavigation { get; set; } = null!;

    public virtual ICollection<Trahang> Trahangs { get; set; } = new List<Trahang>();

    public virtual ICollection<Voucher> Mavcs { get; set; } = new List<Voucher>();
}
