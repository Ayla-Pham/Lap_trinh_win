using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Sanpham
{
    public int Masp { get; set; }

    public string Tensp { get; set; } = null!;

    public int Maloai { get; set; }

    public string? Duongdananh { get; set; }

    public decimal Giaban { get; set; }

    public int Soluongton { get; set; }

    public int Canhbaotonkho { get; set; }

    public bool Trangthaisp { get; set; }

    public virtual ICollection<Chitiethd> Chitiethds { get; set; } = new List<Chitiethd>();

    public virtual ICollection<Chitietnhapkho> Chitietnhapkhos { get; set; } = new List<Chitietnhapkho>();

    public virtual ICollection<Chitietxuatkho> Chitietxuatkhos { get; set; } = new List<Chitietxuatkho>();

    public virtual ICollection<Cttrahang> Cttrahangs { get; set; } = new List<Cttrahang>();

    public virtual Loaisp MaloaiNavigation { get; set; } = null!;

    public virtual ICollection<Voucher> Mavcs { get; set; } = new List<Voucher>();
}
