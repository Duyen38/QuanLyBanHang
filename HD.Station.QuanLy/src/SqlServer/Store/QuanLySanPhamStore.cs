using Microsoft.EntityFrameworkCore;
using QuanLy.SqlServer;
using QuanLy.src.Abstractions.Data;
using QuanLy.src.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.SqlServer.Store
{
    public class QuanLySanPhamStore : ISanPhamStore
    {
        private readonly DbQuanLyContext _dbContext;
        public QuanLySanPhamStore(DbQuanLyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IQueryable<SanPham>> GetAllAsync()
        {
            //throw new NotImplementedException();
            return _dbContext.SanPhams.AsQueryable();
        }
        public IEnumerable<SanPham> GetListProduct()
        {
            return _dbContext.SanPhams.ToList();
        }
        public async Task<SanPham> GetByIdAsync(string id)
        {
            var sanPham = _dbContext.SanPhams
                    .Where(s => s.MaSP == id)
                    .Include(s => s.ChiTietHoaDons)
                    .FirstOrDefault();
            return sanPham;
        }

        public async Task<SanPham> AddListAsync(SanPham sanPham)
        {
            _dbContext.Add(sanPham);
            await _dbContext.SaveChangesAsync();
            return _dbContext.SanPhams.FirstOrDefault();
        }

        public async Task<SanPham> UpdateListAsync(SanPham sanPham)
        {
            _dbContext.Update(sanPham);
            await _dbContext.SaveChangesAsync();
            return _dbContext.SanPhams.FirstOrDefault();
        }

        public async Task<SanPham> DeleteFromLIstAsync(SanPham sanPham)
        {
            _dbContext.SanPhams.Remove(sanPham);
            await _dbContext.SaveChangesAsync();
            return _dbContext.SanPhams.FirstOrDefault();
        }
        public async Task<IQueryable<ThongKeSanPhamViewModel>> GetPurchaseStatisticsAsync()
        {
            var listProduct = (from h in _dbContext.HoaDons
                               from c in _dbContext.ChiTietHoaDons
                               from s in _dbContext.SanPhams
                               where h.MaHD == c.MaHD && c.MaSP == s.MaSP
                               select new ThongKeSanPhamViewModel
                               {
                                   MaSP = s.MaSP,
                                   TenSp = s.TenSp,
                                   NgayLapHD = h.NgayLapHD,
                                   DonGia = s.DonGia,
                                   DonViTinh = s.DonViTinh,
                                   SoLuong = ((int)c.SoLuong),
                                   ThanhTien = ((decimal)(s.DonGia * c.SoLuong))
                               }).AsQueryable();

            return listProduct;
        }

    }
}
