using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Abstractions
{
    public interface IQuanLyKhachHang
    {
        Task<KhachHang> AddListAsync(KhachHang khachHang);
        Task<KhachHang> DeleteAsync(string id);
        Task<IQueryable<KhachHang>> GetAllAsync();
        Task<KhachHang> GetByIdAsync(string name);
        Task<KhachHang> GetByNameAsync(string name);
        Task<KhachHang> UpdateListAsync(KhachHang khachHang);
        IEnumerable<KhachHang> GetListCustomerAsync();
    }
}
