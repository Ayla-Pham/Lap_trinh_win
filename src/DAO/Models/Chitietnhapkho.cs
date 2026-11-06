using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Chitietnhapkho
{
    public int Mank { get; set; }

    public int Masp { get; set; }

    public int Soluongnhap { get; set; }

    public decimal Gianhap { get; set; }

    public decimal? Thanhtien { get; set; }

    public virtual Nhapkho MankNavigation { get; set; } = null!;

    public virtual Sanpham MaspNavigation { get; set; } = null!;
}
