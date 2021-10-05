using Microsoft.EntityFrameworkCore;
using QuanLy.src.Abstractions.Data;
using QuanLy.src.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.SqlServer.Store
{
    public class QuanLyHoaDonStore : IHoaDonStore
    {
        private readonly DbQuanLyContext _dbContext;
        public QuanLyHoaDonStore(DbQuanLyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IQueryable<HoaDon>> GetAllAsync()
        {
            //throw new NotImplementedException();
            return _dbContext.HoaDons.AsQueryable();
        }
        public async Task<HoaDon> GetByIdAsync(decimal? id)
        {
            var hoaDon = await _dbContext.HoaDons
                        .Where(h => h.MaHD == id)
                        .Include(h => h.KhachHang)
                        .Include(h => h.NhanVien)
                        .Include(h => h.ChiTietHoaDons)
                        .FirstOrDefaultAsync();
            return hoaDon;
        }

        public async Task<HoaDon> AddListAsync(HoaDon hoaDon)
        {
            _dbContext.Add(hoaDon);
            await _dbContext.SaveChangesAsync();
            return _dbContext.HoaDons.FirstOrDefault();
        }
        public async Task<HoaDon> UpdateListAsync(HoaDon hoaDon)
        {
            _dbContext.Update(hoaDon);
            await _dbContext.SaveChangesAsync();
            return _dbContext.HoaDons.FirstOrDefault();
        }

        public async Task<HoaDon> DeleteFromListAsync(HoaDon hoaDon)
        {
            _dbContext.HoaDons.Remove(hoaDon);
            await _dbContext.SaveChangesAsync();
            return _dbContext.HoaDons.FirstOrDefault();
        }
    }
}
