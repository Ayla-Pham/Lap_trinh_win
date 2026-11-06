using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Nhacungcap
{
    public int Manhacc { get; set; }

    public string Tennhacc { get; set; } = null!;

    public virtual ICollection<Nhapkho> Nhapkhos { get; set; } = new List<Nhapkho>();
}
