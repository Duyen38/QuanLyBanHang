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

        // GET: ChiTietHoaDonsController/Details/5
        public async Task<IActionResult> Details(decimal? id, string maSP)
        {
            if (id == null)
            {
                return NotFound();
            }
            var chiTietHoaDon = await _quanLyChiTietHoaDon.GetByIdAsync(id, maSP);

            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // GET: ChiTietHoaDonsController/Create
        public IActionResult Create(decimal id)
        {
            ViewData["MaHD"] = id;
            ViewData["MaSP"] = new SelectList(_quanLySanPham.GetListProduct(), "MaSP", "MaSP");
            return View();
        }

        // POST: ChiTietHoaDonsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHD,MaSP,SoLuong")] ChiTietHoaDon chiTietHoaDon)
        {
            if (ModelState.IsValid)
            {
                await _quanLyChiTietHoaDon.AddListAsync(chiTietHoaDon);
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaSP"] = new SelectList(_quanLySanPham.GetListProduct(), "MaSP", "MaSP", chiTietHoaDon.MaSP);
            return View(chiTietHoaDon);
        }

        // GET: ChiTietHoaDonsController/Edit/5
        public async Task<IActionResult> Edit(decimal? id, string maSP)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _quanLyChiTietHoaDon.GetByIdAsync(id, maSP);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }
            ViewData["MaHD"] = id;
            ViewData["MaSP"] = chiTietHoaDon.MaSP;
            return View(chiTietHoaDon);
        }

        // POST: ChiTietHoaDonsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("MaHD,MaSP,SoLuong")] ChiTietHoaDon chiTietHoaDon)
        {
            if (id != chiTietHoaDon.MaHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _quanLyChiTietHoaDon.UpdateListAsync(chiTietHoaDon);
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaSP"] = new SelectList(_quanLySanPham.GetListProduct(), "MaSP", "MaSP", chiTietHoaDon.MaSP);
            return View(chiTietHoaDon);
        }

        // GET: ChiTietHoaDonsController/Delete/5
        public async Task<IActionResult> Delete(decimal? id, string maSP)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDon = await _quanLyChiTietHoaDon.GetByIdAsync(id, maSP);
            if (chiTietHoaDon == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDon);
        }

        // POST: ChiTietHoaDonsController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id, string maSP)
        {
            var chiTietHoaDon = await _quanLyChiTietHoaDon.GetByIdAsync(id, maSP);
            await _quanLyChiTietHoaDon.DeleteFromListAsync(chiTietHoaDon);
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHoaDonExists(decimal id, string maSP)
        {
            return _quanLyChiTietHoaDon.GetByIdAsync(id, maSP) == null;
        }
    }
}
