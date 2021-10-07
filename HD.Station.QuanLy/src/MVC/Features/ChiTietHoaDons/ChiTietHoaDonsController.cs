using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Features.ChiTietHoaDons
{
    [Area("QuanLy")]
    public class ChiTietHoaDonsController : Controller
    {
        private readonly IQuanLyChiTietHoaDon _quanLyChiTietHoaDon;
        private readonly IQuanLySanPham _quanLySanPham;

        public ChiTietHoaDonsController(IQuanLyChiTietHoaDon quanLyChiTietHoaDon, IQuanLySanPham quanLySanPham)
        {
            _quanLyChiTietHoaDon = quanLyChiTietHoaDon;
            _quanLySanPham = quanLySanPham;
        }

        // GET: ChiTietHoaDonsController
        public async Task<IActionResult> Index()
        {
            return View(await _quanLyChiTietHoaDon.GetAllAsync());
        }

        // GET: ChiTietHoaDons/GetData
        public ActionResult GetData(decimal id)
        {
            var cthoaDon = _quanLyChiTietHoaDon.GetByBillIdAsync(id);
            return Json(new { Data = cthoaDon, TotalItem = cthoaDon.Count() });
        }

        // GET: ChiTietHoaDons/GetDataById
        public ActionResult GetDataById(decimal id, string maSP)
        {
            if (maSP == null)
            {
                return NotFound();
            }
            var cthoaDon = _quanLyChiTietHoaDon.GetByAllIdAsync(id, maSP); 
            if (cthoaDon == null)
            {
                return NotFound();
            }
            return Json(new { data = cthoaDon, success = true });
        }

        // GET: ChiTietHoaDonsController/Details/5
        public async Task<IActionResult> Details(decimal id, string maSP)
        {
            var chiTietHoaDon = await _quanLyChiTietHoaDon.GetByAllIdAsync(id, maSP);

            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // GET: ChiTietHoaDons/Create
        public IActionResult Create(decimal id)
        {
            ViewData["MaHD"] = id;
            ViewData["MaSP"] = new SelectList(_quanLySanPham.GetListProduct(), "MaSP", "MaSP");
            return View();
        }

        // POST: ChiTietHoaDons/Create
        [HttpPost]
        public ActionResult Create(ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _quanLyChiTietHoaDon.AddListAsync(chiTietHoaDon);
                    //    ViewData["MaSP"] = new SelectList(_quanLySanPham.GetListProduct(), "MaSP", "MaSP", chiTietHoaDon.MaSP);
                }
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Json(new { success = false });
            }
        }

        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("MaHD,MaSP,SoLuong")] ChiTietHoaDon chiTietHoaDon)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _quanLyChiTietHoaDon.AddListAsync(chiTietHoaDon);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["MaSP"] = new SelectList(_quanLySanPham.GetListProduct(), "MaSP", "MaSP", chiTietHoaDon.MaSP);
        //    return View(chiTietHoaDon);
        //}

        // GET: ChiTietHoaDons/Edit/5
        public async Task<IActionResult> Edit(decimal id, string maSP)
        {
            var chiTietHoaDon = await _quanLyChiTietHoaDon.GetByAllIdAsync(id, maSP);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }
            ViewData["MaHD"] = id;
            ViewData["MaSP"] = chiTietHoaDon.MaSP;
            return View(chiTietHoaDon);
        }

        // POST: ChiTietHoaDons/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ChiTietHoaDon chiTietHoaDon)
        {
            var hd = await _quanLyChiTietHoaDon.GetByAllIdAsync(chiTietHoaDon.MaHD, chiTietHoaDon.MaSP);
            hd.SoLuong = chiTietHoaDon.SoLuong;
            if (ModelState.IsValid)
            {
                try
                {
                    await _quanLyChiTietHoaDon.UpdateListAsync(hd);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHoaDonExists(chiTietHoaDon.MaHD, chiTietHoaDon.MaSP))
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
            ViewData["MaSP"] = new SelectList(_quanLySanPham.GetListProduct(), "MaSP", "MaSP", chiTietHoaDon.MaSP);
            return Json(new { success = false });
        }

        // GET: ChiTietHoaDons/Delete/5
        //public async Task<IActionResult> Delete(decimal id, string maSP)
        //{
        //    var chiTietHoaDon = await _quanLyChiTietHoaDon.GetByAllIdAsync(id, maSP);
        //    if (chiTietHoaDon == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(chiTietHoaDon);
        //}

        // POST: ChiTietHoaDons/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(decimal id, string maSP)
        {
            try
            {
                var chiTietHoaDon = await _quanLyChiTietHoaDon.GetByAllIdAsync(id, maSP);
                await _quanLyChiTietHoaDon.DeleteFromListAsync(chiTietHoaDon);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Json(new { success = false });
            }
        }

        private bool ChiTietHoaDonExists(decimal id, string maSP)
        {
            return _quanLyChiTietHoaDon.GetByAllIdAsync(id, maSP) == null;
        }
    }
}
