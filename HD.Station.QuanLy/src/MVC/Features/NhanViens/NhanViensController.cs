using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
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
        private readonly IQuanLyGioiTinh _quanLyGioiTinh;
        public NhanViensController(IQuanLyNhanVien quanLyNhanVien, IQuanLyGioiTinh quanLyGioiTinh)
        {
            _quanLyNhanVien = quanLyNhanVien;
            _quanLyGioiTinh = quanLyGioiTinh;
        }

        // GET: NhanViens
        public async Task<IActionResult> Index(string searchString)
        {
            var nhanVien = await _quanLyNhanVien.GetAllAsync();
            var gt = _quanLyGioiTinh.GetList();

            ViewData["GioiTinh"] = new SelectList(_quanLyGioiTinh.GetList(), nameof(GioiTinh.Value), nameof(GioiTinh.Name));
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
            var nhanVien = _quanLyNhanVien.GetByIdAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            ViewData["GioiTinh"] = new SelectList(_quanLyGioiTinh.GetList(), nameof(GioiTinh.Value), nameof(GioiTinh.Name));
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
            ViewData["GioiTinh"] = new SelectList(_quanLyGioiTinh.GetList(), nameof(GioiTinh.Value), nameof(GioiTinh.Name));
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
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
            var nhanVien = await _quanLyNhanVien.GetByIdAsync(id);
            if (nhanVien == null)
            {
                return NotFound();
            }
            ViewData["GioiTinh"] = new SelectList(_quanLyGioiTinh.GetList(), nameof(GioiTinh.Value), nameof(GioiTinh.Name), nhanVien.GioiTinhNV);
            return View(nhanVien);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(NhanVien nhanVien)
        {
            var nv = await _quanLyNhanVien.GetByIdAsync(nhanVien.MaNV);
            nv.HoNV = nhanVien.HoNV;
            nv.TenNV = nhanVien.TenNV;
            nv.GioiTinhNV = nhanVien.GioiTinhNV;
            nv.NgaySinh = nhanVien.NgaySinh;
            nv.DiaChi = nhanVien.DiaChi;
            nv.DienThoai = nhanVien.DienThoai;
            try
            {
                await _quanLyNhanVien.UpdateListAsync(nv);
                return Json(new { success = true });
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
                return Json(new { success = false });
            }
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
    }
}
