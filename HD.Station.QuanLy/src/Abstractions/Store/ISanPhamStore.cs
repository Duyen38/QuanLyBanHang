using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Store
{
    public interface ISanPhamStore
    {
        Task<IQueryable<SanPham>> GetAllAsync();
        Task<SanPham> GetByIdAsync(string id);
        Task<SanPham> AddListAsync(SanPham sanPham);
        Task<IQueryable<ThongKeSanPhamViewModel>> GetPurchaseStatisticsAsync();
        Task<SanPham> UpdateListAsync(SanPham sanPham);
        Task<SanPham> DeleteFromLIstAsync(SanPham sanPham);
        IEnumerable<SanPham> GetListProduct();
    }
}
