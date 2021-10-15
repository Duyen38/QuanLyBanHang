using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Data;
using QuanLy.src.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Services
{
    public class QuanLyGioiTinh : IQuanLyGioiTinh
    {
        public IGioiTinhStore _gioiTinhStore;
        public QuanLyGioiTinh(IGioiTinhStore gioiTinhStore)
        {
            _gioiTinhStore = gioiTinhStore;
        }
        public async Task<IQueryable<GioiTinh>> GetAllAsync()
        {
            return await _gioiTinhStore.GetAllAsync();
        }
        public IEnumerable<GioiTinh> GetList()
        {
            return _gioiTinhStore.GetList();
        }
    }
}
