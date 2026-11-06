using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Khachhang
{
    public int Makh { get; set; }

    public string Tenkh { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public int Tichdiem { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
