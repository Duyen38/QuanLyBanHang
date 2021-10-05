using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Abstractions
{
    public interface IQuanLyNhanVien
    {
        Task<IQueryable<NhanVien>> GetAllAsync();
        Task<NhanVien> GetByIdAsync(string id);
        Task<NhanVien> GetByNameAsync(string name);
        Task<NhanVien> AddListAsync(NhanVien nhanVien);
        Task<NhanVien> UpdateListAsync(NhanVien nhanVien);
        Task<NhanVien> DeleteAsync(string id);
        IEnumerable<NhanVien> GetListEmployeeAsync();
    }
}
