using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Data;
using QuanLy.src.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace QuanLy.src.Abstractions.Services
{
    public class QuanLyNhanVien : IQuanLyNhanVien
    {
        public INhanVienStore _nhanVienStore;

        public QuanLyNhanVien(INhanVienStore nhanVienStore)
        {
            _nhanVienStore = nhanVienStore;
        }
        public async Task<IQueryable<NhanVien>> GetAllAsync()
        {
            return await _nhanVienStore.GetAllAsync();
        }
        public IEnumerable<NhanVien> GetListEmployeeAsync()
        {
            return _nhanVienStore.GetListEmployeeAsync();
        }
        public async Task<NhanVien> GetByIdAsync(string id)
        {
            return await _nhanVienStore.GetByIdAsync(id);
        }
        public async Task<NhanVien> GetByNameAsync(string name)
        {
            return await _nhanVienStore.GetByNameAsync(name);
        }
        public async Task<NhanVien> AddListAsync(NhanVien nhanVien)
        {
            //_nhanVienStore.AddNhanVien(nhanVien);
            return await _nhanVienStore.AddListAsync(nhanVien);
        }
        public async Task<NhanVien> UpdateListAsync(NhanVien nhanVien)
        {
            return await _nhanVienStore.UpdateListAsync(nhanVien);
        }
        public async Task<NhanVien> DeleteAsync(NhanVien nhanVien)
        {
            return await _nhanVienStore.DeleteAsync(nhanVien);
        }
    }
}
