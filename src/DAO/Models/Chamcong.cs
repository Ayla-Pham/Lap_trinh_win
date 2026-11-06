using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Chamcong
{
    public int Idcc { get; set; }

    public string Manv { get; set; } = null!;

    public DateOnly Ngay { get; set; }

    public DateTime GioBatDau { get; set; }

    public DateTime? GioKetThuc { get; set; }

    public int? TongThoiGian { get; set; }

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
