using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Features.KhachHangs
{
    [Area("QuanLy")]
    public class KhachHangsController : Controller
    {
        private readonly IQuanLyKhachHang _quanLyKhachHang;
        public KhachHangsController(IQuanLyKhachHang quanLyKhachHang)
        {
            _quanLyKhachHang = quanLyKhachHang;
        }

        //public ActionResult Index()
        //{
        //    return View();
        //}

        //GET: KhachHangsController
        public async Task<IActionResult> Index(string searchString)
        {
            var khachHang = await _quanLyKhachHang.GetAllAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                khachHang = khachHang.Where(k => k.HoTenKH.Contains(searchString));
            }
            return View(khachHang);
        }
        //GET: KhachHangs/getdata
        public ActionResult GetData()
        {
            var khachHang = _quanLyKhachHang.GetListCustomerAsync();
            return Json(new { Data = khachHang, TotalItem = khachHang.Count() });
        }


        // GET: KhachHangsController/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _quanLyKhachHang.GetByIdAsync(id);

            if (khachHang == null)
            {
                return NotFound();
            }

            return View(khachHang);
        }

        // GET: KhachHangsController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KhachHangsController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(KhachHang khachHang)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _quanLyKhachHang.AddListAsync(khachHang);
                }
                return Json(new { success = true });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return Json(new { success = false });
            }
           
        }
        //public async Task<IActionResult> Create([Bind("MaKH,HoTenKH,DiaChi,DienThoai")] KhachHang khachHang)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _quanLyKhachHang.AddListAsync(khachHang);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(khachHang);
        //}

        // GET: KhachHangsController/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _quanLyKhachHang.GetByIdAsync(id);
            if (khachHang == null)
            {
                return NotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHangsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaKH,HoTenKH,DiaChi,DienThoai")] KhachHang khachHang)
        {
            if (id != khachHang.MaKH)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _quanLyKhachHang.UpdateListAsync(khachHang);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachHangExists(khachHang.MaKH))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(khachHang);
        }

        // GET: KhachHangsController/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _quanLyKhachHang.GetByIdAsync(id);
            if (khachHang == null)
            {
                return NotFound();
            }

            return View(khachHang);
        }

        // POST: KhachHangsController/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                var khachHang = _quanLyKhachHang.DeleteAsync(id);
                return Json(new { success = true });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return Json(new { success = false });
            }
        }

        private bool KhachHangExists(string id)
        {
            return _quanLyKhachHang.GetByIdAsync(id) != null;
        }
    }
}
