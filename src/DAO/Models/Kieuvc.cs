using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Kieuvc
{
    public int Maloaivc { get; set; }

    public string Tenloai { get; set; } = null!;

    public virtual ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
}
