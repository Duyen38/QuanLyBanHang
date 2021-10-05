using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Store;
using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Services
{
    public class QuanLyKhachHang : IQuanLyKhachHang
    {
        public IKhachHangStore _khachHangStore;

        public QuanLyKhachHang(IKhachHangStore khachHangStore)
        {
            _khachHangStore = khachHangStore;
        }
        public async Task<IQueryable<KhachHang>> GetAllAsync()
        {
            return await _khachHangStore.GetAllAsync();
        }
        public IEnumerable<KhachHang> GetListCustomerAsync()
        {
            return _khachHangStore.GetListCustomerAsync();
        }
        public async Task<KhachHang> GetByIdAsync(string name)
        {
            return await _khachHangStore.GetByIdAsync(name);
        }
        public async Task<KhachHang> GetByNameAsync(string name)
        {
            return await _khachHangStore.GetByNameAsync(name);
        }
        public async Task<KhachHang> AddListAsync(KhachHang khachHang)
        {
            return await _khachHangStore.AddListAsync(khachHang);
        }
        public async Task<KhachHang> UpdateListAsync(KhachHang khachHang)
        {
            return await _khachHangStore.UpdateListAsync(khachHang);
        }
        public async Task<KhachHang> DeleteAsync(string id)
        {
            return await _khachHangStore.DeleteAsync(id);
        }
    }
}
