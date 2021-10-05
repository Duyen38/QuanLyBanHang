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
    public class QuanLyNhanVienStore : INhanVienStore
    {
        private readonly DbQuanLyContext _dbContext;

        public QuanLyNhanVienStore(DbQuanLyContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IQueryable<NhanVien>> GetAllAsync()
        {
            return _dbContext.NhanViens.AsQueryable();
        }

        public IEnumerable<NhanVien> GetListEmployeeAsync()
        {
            return _dbContext.NhanViens.ToList();
        }

        public async Task<NhanVien> GetByIdAsync(string id)
        {
            var nhanVien = _dbContext.NhanViens
                            .Where(e => e.MaNV == id)
                            .Include(e => e.HoaDons)
                            .FirstOrDefault();
            return nhanVien;
        }

        public async Task<NhanVien> GetByNameAsync(string name)
        {
            return _dbContext.NhanViens
                    .Where(e => e.HoNV.Contains(name) || e.TenNV.Contains(name))
                    .FirstOrDefault();
        }

        public async Task<NhanVien> AddListAsync(NhanVien nhanVien)
        {
            _dbContext.Add(nhanVien);
            await _dbContext.SaveChangesAsync();
            return _dbContext.NhanViens.FirstOrDefault();
        }
        public async Task<NhanVien> UpdateListAsync(NhanVien nhanVien)
        {
            _dbContext.Update(nhanVien);
            await _dbContext.SaveChangesAsync();
            return _dbContext.NhanViens.FirstOrDefault();
        }
        public async Task<NhanVien> DeleteAsync(string id)
        {
            var nhanVien = await _dbContext.NhanViens.FindAsync(id);
            _dbContext.NhanViens.Remove(nhanVien);
            await _dbContext.SaveChangesAsync();
            return _dbContext.NhanViens.FirstOrDefault();
        }
    }
}
