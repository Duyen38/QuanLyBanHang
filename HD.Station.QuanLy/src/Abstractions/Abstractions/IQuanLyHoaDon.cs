using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Abstractions
{
    public interface IQuanLyHoaDon
    {
        Task<IQueryable<HoaDon>> GetAllAsync();
        Task<HoaDon> GetByIdAsync(decimal id);
        Task<HoaDon> AddListAsync(HoaDon hoaDon);
        Task<HoaDon> UpdateListAsync(HoaDon hoaDon);
        Task<HoaDon> DeleteFromListAsync(HoaDon hoaDon);
        IEnumerable<HoaDon> GetListBill();
    }
}
