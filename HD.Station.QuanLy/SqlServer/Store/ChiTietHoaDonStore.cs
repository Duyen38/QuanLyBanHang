using Microsoft.EntityFrameworkCore;
using QuanLy.SqlServer;
using QuanLy.src.Abstractions.Data;
using QuanLy.src.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.SqlServer.Store
{
    public class ChiTietHoaDonStore : IChiTietHoaDonStore
    {
        private readonly DbQuanLyContext _dbContext;
        public ChiTietHoaDonStore(DbQuanLyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IQueryable<ChiTietHoaDon>> GetAllAsync()
        {
            //throw new NotImplementedException();
            return _dbContext.ChiTietHoaDons.AsQueryable();
        }
        public async Task<ChiTietHoaDon> GetByIdAsync(decimal? id, string maSP)
        {
            var chiTietHoaDon = await _dbContext.ChiTietHoaDons
                            .Where(h => h.MaHD == id && h.MaSP == maSP)
                            .Include(ct => ct.HoaDon)
                            .Include(ct => ct.SanPham)
                            .FirstOrDefaultAsync();
            return chiTietHoaDon;
        }
        public async Task<ChiTietHoaDon> UpdateListAsync(ChiTietHoaDon chiTietHoaDon)
        {
            _dbContext.Update(chiTietHoaDon);
            await _dbContext.SaveChangesAsync();
            return _dbContext.ChiTietHoaDons.FirstOrDefault();
        }
        public async Task<ChiTietHoaDon> AddListAsync(ChiTietHoaDon chiTietHoaDon)
        {
            _dbContext.Add(chiTietHoaDon);
            await _dbContext.SaveChangesAsync();
            return _dbContext.ChiTietHoaDons.FirstOrDefault();
        }
        public async Task<ChiTietHoaDon> DeleteFromListAsync(ChiTietHoaDon chiTietHoaDon)
        {
            _dbContext.ChiTietHoaDons.Remove(chiTietHoaDon);
            await _dbContext.SaveChangesAsync();
            return _dbContext.ChiTietHoaDons.FirstOrDefault();
        }

    }
}
