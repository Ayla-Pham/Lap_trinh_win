using System;
using System.Collections.Generic;

namespace DAO.Models;

public partial class Nhanvien
{
    public string Manv { get; set; } = null!;

    public string Tk { get; set; } = null!;

    public string Mk { get; set; } = null!;

    public decimal? Luong { get; set; }

    public string Hoten { get; set; } = null!;

    public string Vitri { get; set; } = null!;

    public string? Sdt { get; set; }

    public string? Diachi { get; set; }

    public string? Email { get; set; }

    public string? Bank { get; set; }

    public string? Stk { get; set; }

    public DateOnly? Ngsinh { get; set; }

    public virtual ICollection<Chamcong> Chamcongs { get; set; } = new List<Chamcong>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Nhapkho> Nhapkhos { get; set; } = new List<Nhapkho>();

    public virtual ICollection<Trahang> Trahangs { get; set; } = new List<Trahang>();

    public virtual ICollection<Xuatkho> Xuatkhos { get; set; } = new List<Xuatkho>();
}
