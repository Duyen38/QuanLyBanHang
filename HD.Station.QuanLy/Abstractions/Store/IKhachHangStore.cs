using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Store
{
    public interface IKhachHangStore
    {
        Task<IQueryable<KhachHang>> GetAllAsync();
        Task<KhachHang> GetByIdAsync(string id);
        Task<KhachHang> GetByNameAsync(string name);
        Task<KhachHang> AddListAsync(KhachHang khachHang);
        Task<KhachHang> UpdateListAsync(KhachHang khachHang);
        Task<KhachHang> DeleteAsync(string id);
        IEnumerable<KhachHang> GetListCustomerAsync();
    }
}
