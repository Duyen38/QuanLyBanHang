using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Store;
using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Services
{
    public class QuanLyHoaDon : IQuanLyHoaDon
    {
        public IHoaDonStore _hoaDonStore;
        public QuanLyHoaDon(IHoaDonStore hoaDonStore)
        {
            _hoaDonStore = hoaDonStore;
        }
        public async Task<IQueryable<HoaDon>> GetAllAsync()
        {
            return await _hoaDonStore.GetAllAsync();
        }

        public async Task<HoaDon> GetByIdAsync(decimal? id)
        {
            return await _hoaDonStore.GetByIdAsync(id);
        }
        public async Task<HoaDon> AddListAsync(HoaDon hoaDon)
        {
            return await _hoaDonStore.AddListAsync(hoaDon);
        }

        public async Task<HoaDon> UpdateListAsync(HoaDon hoaDon)
        {
            return await _hoaDonStore.UpdateListAsync(hoaDon);
        }
        public async Task<HoaDon> DeleteFromListAsync(HoaDon hoaDon)
        {
            return await _hoaDonStore.DeleteFromListAsync(hoaDon);
        }
    }
}
