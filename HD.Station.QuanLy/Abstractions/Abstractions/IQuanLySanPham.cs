using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Abstractions
{
    public interface IQuanLySanPham
    {
        Task<IQueryable<SanPham>> GetAllAsync();
        IEnumerable<SanPham> GetListProduct();
        Task<SanPham> GetByIdAsync(string id);
        Task<SanPham> AddListAsync(SanPham sanPham);
        Task<IQueryable<ThongKeSanPhamViewModel>> GetPurchaseStatisticsAsync();
        Task<SanPham> UpdateListAsync(SanPham sanPham);
        Task<SanPham> DeleteFromLIstAsync(SanPham sanPham);
    }
}
