using Microsoft.EntityFrameworkCore;
using QuanLy.src.Abstractions.Data;
using QuanLy.src.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.SqlServer.Store
{
    public class QuanLyKhachHangStore : IKhachHangStore
    {
        private readonly DbQuanLyContext _dbContext;

        public QuanLyKhachHangStore(DbQuanLyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IQueryable<KhachHang>> GetAllAsync()
        {
            return _dbContext.KhachHangs.AsQueryable();
        }
        public IEnumerable<KhachHang> GetListCustomerAsync()
        {
            return _dbContext.KhachHangs.ToList();
        }

        public async Task<KhachHang> GetByIdAsync(string id)
        {
            var khachHang = _dbContext.KhachHangs
                            .Where(e => e.MaKH == id)
                            .Include(e => e.HoaDons)
                            .FirstOrDefault();
            return khachHang;
        }

        public async Task<KhachHang> GetByNameAsync(string name)
        {
            return _dbContext.KhachHangs.Where(e => e.HoTenKH.Contains(name)).FirstOrDefault();
        }

        public async Task<KhachHang> AddListAsync(KhachHang khachHang)
        {
            _dbContext.Add(khachHang);
            await _dbContext.SaveChangesAsync();
            return _dbContext.KhachHangs.FirstOrDefault();
        }
        public async Task<KhachHang> UpdateListAsync(KhachHang khachHang)
        {
            _dbContext.Update(khachHang);
            await _dbContext.SaveChangesAsync();
            return _dbContext.KhachHangs.FirstOrDefault();
        }
        public async Task<KhachHang> DeleteAsync(string id)
        {
            var khachHang = await _dbContext.KhachHangs.FindAsync(id);
            _dbContext.KhachHangs.Remove(khachHang);
            await _dbContext.SaveChangesAsync();
            return _dbContext.KhachHangs.FirstOrDefault();
        }
    }
}
