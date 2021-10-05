using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Store
{
    public interface IHoaDonStore
    {
        Task<IQueryable<HoaDon>> GetAllAsync();
        Task<HoaDon> GetByIdAsync(decimal? id);
        Task<HoaDon> UpdateListAsync(HoaDon hoaDon);
        Task<HoaDon> AddListAsync(HoaDon hoaDon);
        Task<HoaDon> DeleteFromListAsync(HoaDon hoaDon);
    }
}
