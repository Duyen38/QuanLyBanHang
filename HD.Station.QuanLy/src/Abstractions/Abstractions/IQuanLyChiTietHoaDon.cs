using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Abstractions
{
    public interface IQuanLyChiTietHoaDon
    {
        Task<ChiTietHoaDon> AddListAsync(ChiTietHoaDon chiTietHoaDonStore);
        Task<ChiTietHoaDon> DeleteFromListAsync(ChiTietHoaDon chiTietHoaDonStore);
        Task<IQueryable<ChiTietHoaDon>> GetAllAsync();
        Task<ChiTietHoaDon> GetByAllIdAsync(decimal id, string maSP);
        IEnumerable<ChiTietHoaDon> GetByBillIdAsync(decimal id);
        Task<ChiTietHoaDon> UpdateListAsync(ChiTietHoaDon chiTietHoaDonStore);
    }
}
