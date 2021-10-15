using QuanLy.src.Abstractions.Data;
using QuanLy.src.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.SqlServer.Store
{
    public class GioiTinhStore : IGioiTinhStore
    {
        private readonly DbQuanLyContext _dbContext;
        public GioiTinhStore(DbQuanLyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IQueryable<GioiTinh>> GetAllAsync()
        {
            return _dbContext.GioiTinhs.AsQueryable();
        }

        public IEnumerable<GioiTinh> GetList()
        {
            return _dbContext.GioiTinhs.ToList();
        }
    }
}
