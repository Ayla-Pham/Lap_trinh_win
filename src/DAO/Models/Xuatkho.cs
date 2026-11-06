using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Xuatkho
{
    public int MaXk { get; set; }

    public DateTime NgayXuat { get; set; }

    public string Manv { get; set; } = null!;

    public string? LyDoxuat { get; set; }

    public virtual ICollection<Chitietxuatkho> Chitietxuatkhos { get; set; } = new List<Chitietxuatkho>();

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
