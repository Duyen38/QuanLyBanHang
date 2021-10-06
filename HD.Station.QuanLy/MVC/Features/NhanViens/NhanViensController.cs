using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Features.NhanViens
{
    [Area("QuanLy")]
    public class NhanViensController : Controller
    {
        private readonly IQuanLyNhanVien _quanLyNhanVien;
        public NhanViensController(IQuanLyNhanVien quanLyNhanVien)
        {
            _quanLyNhanVien = quanLyNhanVien;
        }

        // GET: NhanVienController
        public async Task<IActionResult> Index(string searchString)
        {
            var nhanVien = await _quanLyNhanVien.GetAllAsync();

            // searching by name
            if (!String.IsNullOrEmpty(searchString))
            {
                //nhanVien = (IQueryable<NhanVien>)_quanLyNhanVien.GetByNameAsync(searchString);
                nhanVien = nhanVien.Where(e => e.HoNV.Contains(searchString) || e.TenNV.Contains(searchString));
            }
            return View(nhanVien);
        }

        //GET: NhanViens/getdata
        public ActionResult GetData()
        {
            var nhanVien = _quanLyNhanVien.GetListEmployeeAsync();
            return Json(new { Data = nhanVien, TotalItem = nhanVien.Count() });
        }

        // GET: NhanViens/GetDataById/id
        public ActionResult GetDataById(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = _quanLyNhanVien.GetByIdAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }

            return Json(new { data = nhanVien, success = true });
        }
        // GET: NhanVien/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanVien = await _quanLyNhanVien.GetByIdAsync(id);

            if (nhanVien == null)
            {
                return NotFound();
            }

            return View(nhanVien);
        }

        // GET: NhanVien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(NhanVien nhanVien)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _quanLyNhanVien.AddListAsync(nhanVien);
                }
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Json(new { success = false });
            }
        }

        // GET: NhanViens/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var nhanVien = await _context.NhanViens.FindAsync(id);
            var nhanVien = await _quanLyNhanVien.GetByIdAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(NhanVien nhanVien)
        {
            var nv = await _quanLyNhanVien.GetByIdAsync(nhanVien.MaNV);
            nv.HoNV = nhanVien.HoNV;
            nv.TenNV = nhanVien.TenNV;
            nv.GioiTinh = nhanVien.GioiTinh;
            nv.NgaySinh = nhanVien.NgaySinh;
            nv.DiaChi = nhanVien.DiaChi;
            nv.DienThoai = nhanVien.DienThoai;
            if (ModelState.IsValid)
            {
                try
                {
                    await _quanLyNhanVien.UpdateListAsync(nv);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhanVienExists(nhanVien.MaNV))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                var nhanVien = await _quanLyNhanVien.GetByIdAsync(id);
                await _quanLyNhanVien.DeleteAsync(nhanVien);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Json(new { success = false });
            }
        }

        private bool NhanVienExists(string id)
        {
            return _quanLyNhanVien.GetByIdAsync(id) != null;
        }
        //public async Task<IActionResult> Create([Bind("MaNV,HoNV,TenNV,GioiTinh,NgaySinh,DiaChi,DienThoai")] NhanVien nhanVien)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            await _quanLyNhanVien.AddListAsync(nhanVien);
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            ViewBag.Message = string.Format("Lỗi! ID Nhân viên đã tồn tại.");
        //        }
        //    }
        //    return View(nhanVien);
        //}
        //public async Task<IActionResult> Edit(string id, [Bind("MaNV,HoNV,TenNV,GioiTinh,NgaySinh,DiaChi,DienThoai")] NhanVien nhanVien)
        //{
        //    if (id != nhanVien.MaNV)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            await _quanLyNhanVien.UpdateListAsync(nhanVien);
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!NhanVienExists(nhanVien.MaNV))
        //            {
        //                ViewBag.Message = string.Format("Không tìm thấy Mã Nhân Viên!");
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(nhanVien);
        //}
        // GET: NhanVienController/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var nhanVien = await _quanLyNhanVien.GetByIdAsync(id);

        //    if (nhanVien == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(nhanVien);
        //}
    }
}
