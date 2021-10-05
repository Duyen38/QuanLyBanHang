using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Data;
using QuanLy.src.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Services
{
    public class QuanLyChiTietHoaDon : IQuanLyChiTietHoaDon
    {
        public IChiTietHoaDonStore _chiTietHoaDonStore;

        public QuanLyChiTietHoaDon(IChiTietHoaDonStore chiTietHoaDonStore)
        {
            _chiTietHoaDonStore = chiTietHoaDonStore;
        }
        public async Task<IQueryable<ChiTietHoaDon>> GetAllAsync()
        {
            return await _chiTietHoaDonStore.GetAllAsync();
        }
        public async Task<ChiTietHoaDon> GetByIdAsync(decimal? id, string maSP)
        {
            return await _chiTietHoaDonStore.GetByIdAsync(id, maSP);
        }
        public async Task<ChiTietHoaDon> AddListAsync(ChiTietHoaDon chiTietHoaDonStore)
        {
            return await _chiTietHoaDonStore.AddListAsync(chiTietHoaDonStore);
        }

        public async Task<ChiTietHoaDon> UpdateListAsync(ChiTietHoaDon chiTietHoaDonStore)
        {
            return await _chiTietHoaDonStore.UpdateListAsync(chiTietHoaDonStore);
        }
        public async Task<ChiTietHoaDon> DeleteFromListAsync(ChiTietHoaDon chiTietHoaDonStore)
        {
            return await _chiTietHoaDonStore.DeleteFromListAsync(chiTietHoaDonStore);
        }
    }
}
