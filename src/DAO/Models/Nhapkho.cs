using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Nhapkho
{
    public int Mank { get; set; }

    public int Manhacc { get; set; }

    public string Manv { get; set; } = null!;

    public DateTime Ngaynhap { get; set; }

    public virtual ICollection<Chitietnhapkho> Chitietnhapkhos { get; set; } = new List<Chitietnhapkho>();

    public virtual Nhacungcap ManhaccNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
