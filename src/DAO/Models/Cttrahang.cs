using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Cttrahang
{
    public int Matra { get; set; }

    public int Masp { get; set; }

    public int Soluong { get; set; }

    public decimal Dongia { get; set; }

    public virtual Sanpham MaspNavigation { get; set; } = null!;

    public virtual Trahang MatraNavigation { get; set; } = null!;
}
