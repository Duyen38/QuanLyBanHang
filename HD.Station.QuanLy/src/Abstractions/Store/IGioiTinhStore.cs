using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.src.Abstractions.Store
{
    public interface IGioiTinhStore
    {
        Task<IQueryable<GioiTinh>> GetAllAsync();
        IEnumerable<GioiTinh> GetList();
    }
}
