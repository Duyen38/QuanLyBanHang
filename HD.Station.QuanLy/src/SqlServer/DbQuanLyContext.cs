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
        public virtual DbSet<GioiTinh> GioiTinhs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
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

            modelBuilder.Entity<GioiTinh>()
                        .HasMany<NhanVien>(e => e.NhanViens)
                        .WithOne(s => s.GioiTinh)
                        .HasForeignKey(s => s.GioiTinhNV)
                        .IsRequired()
                        .OnDelete(DeleteBehavior.ClientCascade);

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

            modelBuilder.Entity<GioiTinh>().HasKey(s => s.Value);

            modelBuilder.Entity<ChiTietHoaDon>()
                        .HasKey(ct => new { ct.MaHD, ct.MaSP });
        }
    }
}
