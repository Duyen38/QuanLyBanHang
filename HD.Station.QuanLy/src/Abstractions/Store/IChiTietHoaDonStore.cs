using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Store
{
    public interface IChiTietHoaDonStore
    {
        Task<IQueryable<ChiTietHoaDon>> GetAllAsync();
        Task<ChiTietHoaDon> GetByAllIdAsync(decimal id, string maSP);
        IEnumerable<ChiTietHoaDon> GetByBillIdAsync(decimal id);
        Task<ChiTietHoaDon> UpdateListAsync(ChiTietHoaDon chiTietHoaDon);
        Task<ChiTietHoaDon> AddListAsync(ChiTietHoaDon chiTietHoaDon);
        Task<ChiTietHoaDon> DeleteFromListAsync(ChiTietHoaDon chiTietHoaDon);
    }
}
