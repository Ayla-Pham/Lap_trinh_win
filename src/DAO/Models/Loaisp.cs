using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Loaisp
{
    public int Maloai { get; set; }

    public string Tenloai { get; set; } = null!;

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();

    public virtual ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
}
