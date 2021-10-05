using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using QuanLy.src.Abstractions.Data;

namespace QuanLy.SqlServer
{
    public class DbQuanLyContext : DbContext
    {
        public DbQuanLyContext()
        {
        }
        public DbQuanLyContext(DbContextOptions<DbQuanLyContext> options) : base(options)
        {
        }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        //public object CHiTietHoaDons { get; internal set; }
        public DbSet<ThongKeSanPhamViewModel> ThongKeSanPhamViewModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ThongKeSanPhamViewModel>()
                        .HasKey(t => t.MaSP);

            modelBuilder.Entity<KhachHang>()
                        .HasMany<HoaDon>(kh => kh.HoaDons)
                        .WithOne(hd => hd.KhachHang)
                        .HasForeignKey(hd => hd.MaKH)
                        .IsRequired()
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NhanVien>()
                        .HasMany<HoaDon>(nv => nv.HoaDons)
                        .WithOne(hd => hd.NhanVien)
                        .HasForeignKey(hd => hd.MaNV)
                        .IsRequired()
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SanPham>()
                        .HasMany<ChiTietHoaDon>(ct => ct.ChiTietHoaDons)
                        .WithOne(s => s.SanPham)
                        .HasForeignKey(s => s.MaSP)
                        .IsRequired()
                        .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<HoaDon>()
                        .HasMany<ChiTietHoaDon>(ct => ct.ChiTietHoaDons)
                        .WithOne(s => s.HoaDon)
                        .HasForeignKey(s => s.MaHD)
                        .IsRequired()
                        .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<ChiTietHoaDon>()
                        .HasKey(ct => new { ct.MaHD, ct.MaSP });

            //modelBuilder.Entity<HoaDon>()
            //            .Property(e => e.MaHD)
            //            .HasColumnName("Id")
            //            .HasPrecision(18, 0)
            //            .IsRequired();

            //modelBuilder.Entity<HoaDon>()
            //            .Property(e => e.MaKH)
            //            .HasMaxLength(6)
            //            .IsRequired();

            //modelBuilder.Entity<HoaDon>()
            //            .Property(e => e.MaNV)
            //            .HasMaxLength(6);

            //modelBuilder.Entity<HoaDon>()
            //            .HasMany(e => e.ChiTietHoaDons)
            //            .WithOne(s => s.HoaDon)
            //            .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<KhachHang>()
            //            .Property(e => e.MaKH)
            //            .HasMaxLength(6);

            //modelBuilder.Entity<KhachHang>()
            //            .Property(e => e.DienThoai)
            //            .HasMaxLength(10);

            //modelBuilder.Entity<NhanVien>()
            //            .Property(e => e.MaNV)
            //            .HasMaxLength(6)
            //            .IsRequired();

            //modelBuilder.Entity<NhanVien>()
            //            .Property(e => e.HoNV)
            //            .HasMaxLength(30)
            //            .IsRequired();

            //modelBuilder.Entity<NhanVien>()
            //            .Property(e => e.TenNV)
            //            .HasMaxLength(12).IsRequired();

            //modelBuilder.Entity<NhanVien>()
            //            .Property(e => e.DienThoai)
            //            .HasMaxLength(10);

            //modelBuilder.Entity<SanPham>()
            //            .Property(e => e.MaSP)
            //            .HasMaxLength(6).IsRequired();

            //modelBuilder.Entity<SanPham>()
            //            .Property(e => e.DonViTinh)
            //            .HasMaxLength(10)

            //    modelBuilder.Entity<ChiTietHoaDon>()
            //                .Property(e => e.MaHD)
            //                .HasPrecision(18, 0);

            //modelBuilder.Entity<ChiTietHoaDon>()
            //            .Property(e => e.MaSP)
            //            .HasMaxLength(6).IsRequired();

            //    modelBuilder.Entity<ChiTietHoaDon>()
            //                .Property(e => e.SoLuong)
            //                .HasPrecision(18, 0);
        }
    }
}
