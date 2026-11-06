using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAO.Models;

public partial class QLCHContext : DbContext
{
    public QLCHContext(DbContextOptions<QLCHContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chamcong> Chamcongs { get; set; }

    public virtual DbSet<Chitiethd> Chitiethds { get; set; }

    public virtual DbSet<Chitietnhapkho> Chitietnhapkhos { get; set; }

    public virtual DbSet<Chitietxuatkho> Chitietxuatkhos { get; set; }

    public virtual DbSet<Cttrahang> Cttrahangs { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Kieuvc> Kieuvcs { get; set; }

    public virtual DbSet<Loaisp> Loaisps { get; set; }

    public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Nhapkho> Nhapkhos { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Trahang> Trahangs { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<Xuatkho> Xuatkhos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Chamcong>(entity =>
        {
            entity.HasKey(e => e.Idcc).HasName("pk_chamcong");

            entity.ToTable("CHAMCONG");

            entity.Property(e => e.GioBatDau).HasColumnType("datetime");
            entity.Property(e => e.GioKetThuc).HasColumnType("datetime");
            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Chamcongs)
                .HasForeignKey(d => d.Manv)
                .HasConstraintName("fk_chamcong_Manv");
        });

        modelBuilder.Entity<Chitiethd>(entity =>
        {
            entity.HasKey(e => new { e.Mahd, e.Masp, e.IsTang }).HasName("pk_chitiethd");

            entity.ToTable("CHITIETHD");

            entity.Property(e => e.Dongia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Thanhtien)
                .HasComputedColumnSql("([Soluong]*[Dongia])", true)
                .HasColumnType("decimal(29, 2)");

            entity.HasOne(d => d.MahdNavigation).WithMany(p => p.Chitiethds)
                .HasForeignKey(d => d.Mahd)
                .HasConstraintName("fk_mahdct");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Chitiethds)
                .HasForeignKey(d => d.Masp)
                .HasConstraintName("fk_masp");
        });

        modelBuilder.Entity<Chitietnhapkho>(entity =>
        {
            entity.HasKey(e => new { e.Mank, e.Masp }).HasName("pk_ctnk");

            entity.ToTable("CHITIETNHAPKHO");

            entity.Property(e => e.Gianhap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Thanhtien)
                .HasComputedColumnSql("([Soluongnhap]*[Gianhap])", true)
                .HasColumnType("decimal(29, 2)");

            entity.HasOne(d => d.MankNavigation).WithMany(p => p.Chitietnhapkhos)
                .HasForeignKey(d => d.Mank)
                .HasConstraintName("fk_mank");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Chitietnhapkhos)
                .HasForeignKey(d => d.Masp)
                .HasConstraintName("fk_maspnk");
        });

        modelBuilder.Entity<Chitietxuatkho>(entity =>
        {
            entity.HasKey(e => new { e.MaXk, e.Masp }).HasName("pk_mactxk");

            entity.ToTable("CHITIETXUATKHO");

            entity.Property(e => e.MaXk).HasColumnName("MaXK");

            entity.HasOne(d => d.MaXkNavigation).WithMany(p => p.Chitietxuatkhos)
                .HasForeignKey(d => d.MaXk)
                .HasConstraintName("fk_maxk");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Chitietxuatkhos)
                .HasForeignKey(d => d.Masp)
                .HasConstraintName("fk_maspxk");
        });

        modelBuilder.Entity<Cttrahang>(entity =>
        {
            entity.HasKey(e => new { e.Matra, e.Masp }).HasName("pk_chitiet_trahang");

            entity.ToTable("CTTRAHANG");

            entity.Property(e => e.Dongia).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Cttrahangs)
                .HasForeignKey(d => d.Masp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_maspth");

            entity.HasOne(d => d.MatraNavigation).WithMany(p => p.Cttrahangs)
                .HasForeignKey(d => d.Matra)
                .HasConstraintName("fk_matra");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Mahd).HasName("pk_mahd");

            entity.ToTable("HOADON");

            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ngaylap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TienGiam).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TongTienGoc).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MakhNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Makh)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_khachhanghd");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Manv)
                .HasConstraintName("fk_Manvhd");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makh).HasName("pk_makh");

            entity.ToTable("KHACHHANG");

            entity.HasIndex(e => e.Sdt, "unq_sdt").IsUnique();

            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tenkh).HasMaxLength(50);
        });

        modelBuilder.Entity<Kieuvc>(entity =>
        {
            entity.HasKey(e => e.Maloaivc).HasName("pk_malvc");

            entity.ToTable("KIEUVC");

            entity.Property(e => e.Tenloai).HasMaxLength(50);
        });

        modelBuilder.Entity<Loaisp>(entity =>
        {
            entity.HasKey(e => e.Maloai).HasName("pk_loai_sanpham");

            entity.ToTable("LOAISP");

            entity.Property(e => e.Tenloai).HasMaxLength(50);
        });

        modelBuilder.Entity<Nhacungcap>(entity =>
        {
            entity.HasKey(e => e.Manhacc).HasName("pk_nhacc");

            entity.ToTable("NHACUNGCAP");

            entity.Property(e => e.Tennhacc).HasMaxLength(50);
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("pk_Manv");

            entity.ToTable("NHANVIEN");

            entity.HasIndex(e => e.Tk, "unq_tk").IsUnique();

            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Bank)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Diachi).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Hoten).HasMaxLength(100);
            entity.Property(e => e.Luong).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Mk)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Stk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stk");
            entity.Property(e => e.Tk)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vitri).HasMaxLength(20);
        });

        modelBuilder.Entity<Nhapkho>(entity =>
        {
            entity.HasKey(e => e.Mank).HasName("pk_mank");

            entity.ToTable("NHAPKHO");

            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ngaynhap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ManhaccNavigation).WithMany(p => p.Nhapkhos)
                .HasForeignKey(d => d.Manhacc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_manhacc");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Nhapkhos)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_manvnk");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Masp).HasName("pk_sanpham");

            entity.ToTable("SANPHAM");

            entity.Property(e => e.Canhbaotonkho).HasColumnName("canhbaotonkho");
            entity.Property(e => e.Duongdananh)
                .HasMaxLength(255)
                .HasColumnName("duongdananh");
            entity.Property(e => e.Giaban)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("giaban");
            entity.Property(e => e.Soluongton).HasColumnName("soluongton");
            entity.Property(e => e.Tensp)
                .HasMaxLength(50)
                .HasColumnName("tensp");
            entity.Property(e => e.Trangthaisp)
                .HasDefaultValue(true)
                .HasColumnName("trangthaisp");

            entity.HasOne(d => d.MaloaiNavigation).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.Maloai)
                .HasConstraintName("fk_sanpham_maloai");
        });

        modelBuilder.Entity<Trahang>(entity =>
        {
            entity.HasKey(e => e.Matra).HasName("pk_math");

            entity.ToTable("TRAHANG");

            entity.Property(e => e.Lydotra).HasMaxLength(200);
            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ngaytra)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.MahdNavigation).WithMany(p => p.Trahangs)
                .HasForeignKey(d => d.Mahd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mahdth");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Trahangs)
                .HasForeignKey(d => d.Manv)
                .HasConstraintName("fk_manvth");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Mavc).HasName("pk_mavc");

            entity.ToTable("VOUCHER");

            entity.HasIndex(e => e.Code, "unq_code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.DieuKien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Giatri).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Maloai).HasColumnName("maloai");
            entity.Property(e => e.TenMaGiamGia).HasMaxLength(100);

            entity.HasOne(d => d.MaloaiNavigation).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.Maloai)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_maloaisp");

            entity.HasOne(d => d.MaloaivcNavigation).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.Maloaivc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_malvc");

            entity.HasMany(d => d.Mahds).WithMany(p => p.Mavcs)
                .UsingEntity<Dictionary<string, object>>(
                    "Apmavc",
                    r => r.HasOne<Hoadon>().WithMany()
                        .HasForeignKey("Mahd")
                        .HasConstraintName("fk_mahd"),
                    l => l.HasOne<Voucher>().WithMany()
                        .HasForeignKey("Mavc")
                        .HasConstraintName("fk_mavc"),
                    j =>
                    {
                        j.HasKey("Mavc", "Mahd").HasName("pk_apma");
                        j.ToTable("APMAVC");
                        j.HasIndex(new[] { "Mavc", "Mahd" }, "unq_voucher_invoice").IsUnique();
                    });

            entity.HasMany(d => d.Masps).WithMany(p => p.Mavcs)
                .UsingEntity<Dictionary<string, object>>(
                    "VoucherSanpham",
                    r => r.HasOne<Sanpham>().WithMany()
                        .HasForeignKey("Masp")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_maspvc"),
                    l => l.HasOne<Voucher>().WithMany()
                        .HasForeignKey("Mavc")
                        .HasConstraintName("fk_mavcsp"),
                    j =>
                    {
                        j.HasKey("Mavc", "Masp").HasName("pk_vcsp");
                        j.ToTable("VOUCHER_SANPHAM");
                    });
        });

        modelBuilder.Entity<Xuatkho>(entity =>
        {
            entity.HasKey(e => e.MaXk).HasName("pk_maxk");

            entity.ToTable("XUATKHO");

            entity.Property(e => e.MaXk).HasColumnName("MaXK");
            entity.Property(e => e.LyDoxuat).HasMaxLength(200);
            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NgayXuat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Xuatkhos)
                .HasForeignKey(d => d.Manv)
                .HasConstraintName("fk_manvXK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
