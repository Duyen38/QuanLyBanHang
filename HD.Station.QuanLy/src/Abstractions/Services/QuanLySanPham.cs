using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Store;
using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Services
{
    public class QuanLySanPham : IQuanLySanPham
    {
        public ISanPhamStore _sanPhamStore;

        public QuanLySanPham(ISanPhamStore sanPhamStore)
        {
            _sanPhamStore = sanPhamStore;
        }
        public async Task<IQueryable<SanPham>> GetAllAsync()
        {
            return await _sanPhamStore.GetAllAsync();
        }
        public IEnumerable<SanPham> GetListProduct()
        {
            return _sanPhamStore.GetListProduct();
        }
        public async Task<SanPham> GetByIdAsync(string id)
        {
            return await _sanPhamStore.GetByIdAsync(id);
        }

        public async Task<SanPham> AddListAsync(SanPham sanPham)
        {
            return await _sanPhamStore.AddListAsync(sanPham);
        }
        public async Task<SanPham> UpdateListAsync(SanPham sanPham)
        {
            return await _sanPhamStore.UpdateListAsync(sanPham);
        }
        public async Task<SanPham> DeleteFromLIstAsync(SanPham sanPham)
        {
            return await _sanPhamStore.DeleteFromLIstAsync(sanPham);
        }
        public async Task<IQueryable<ThongKeSanPhamViewModel>> GetPurchaseStatisticsAsync()
        {
            return await _sanPhamStore.GetPurchaseStatisticsAsync();
        }
    }
}
