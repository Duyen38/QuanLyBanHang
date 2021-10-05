using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Store
{
    public interface INhanVienStore
    {
        Task<NhanVien> AddListAsync(NhanVien nhanVien);
        Task<NhanVien> DeleteAsync(string id);
        Task<IQueryable<NhanVien>> GetAllAsync();
        Task<NhanVien> GetByIdAsync(string id);
        Task<NhanVien> GetByNameAsync(string name);
        IEnumerable<NhanVien> GetListEmployeeAsync();
        Task<NhanVien> UpdateListAsync(NhanVien nhanVien);
    }
}
