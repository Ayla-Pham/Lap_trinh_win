using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Chitietxuatkho
{
    public int MaXk { get; set; }

    public int Masp { get; set; }

    public int SoLuongXuat { get; set; }

    public virtual Xuatkho MaXkNavigation { get; set; } = null!;

    public virtual Sanpham MaspNavigation { get; set; } = null!;
}
