using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Trahang
{
    public int Matra { get; set; }

    public int Mahd { get; set; }

    public DateTime Ngaytra { get; set; }

    public string Manv { get; set; } = null!;

    public string? Lydotra { get; set; }

    public virtual ICollection<Cttrahang> Cttrahangs { get; set; } = new List<Cttrahang>();

    public virtual Hoadon MahdNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
