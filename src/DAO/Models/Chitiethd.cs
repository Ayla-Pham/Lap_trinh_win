using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Chitiethd
{
    public int Mahd { get; set; }

    public int Masp { get; set; }

    public int Soluong { get; set; }

    public decimal Dongia { get; set; }

    public bool IsTang { get; set; }

    public decimal? Thanhtien { get; set; }

    public virtual Hoadon MahdNavigation { get; set; } = null!;

    public virtual Sanpham MaspNavigation { get; set; } = null!;
}
