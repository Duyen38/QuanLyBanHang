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

namespace MVC.Features.HoaDons
{
    [Area("QuanLy")]
    public class HoaDonsController : Controller
    {
        private readonly IQuanLyHoaDon _quanLyHoaDon;
        private readonly IQuanLyKhachHang _quanLyKhachHang;
        private readonly IQuanLyNhanVien _quanLyNhanVien;

        public HoaDonsController(IQuanLyHoaDon quanLyHoaDon, IQuanLyNhanVien quanLyNhanVien, IQuanLyKhachHang quanLyKhachHang)
        {
            _quanLyHoaDon = quanLyHoaDon;
            _quanLyKhachHang = quanLyKhachHang;
            _quanLyNhanVien = quanLyNhanVien;
        }
        // GET: HoaDons
        public async Task<IActionResult> Index()
        {
            return View(await _quanLyHoaDon.GetAllAsync());
        }

        // GET: HoaDons/GetData
        public ActionResult GetData()
        {
            var hoaDon = _quanLyHoaDon.GetListBill();
            return Json(new { Data = hoaDon, TotalItem = hoaDon.Count() });
        }

        // GET: SanPhams/GetDataById/id
        public ActionResult GetDataById(decimal id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = _quanLyHoaDon.GetByIdAsync(id);
            if (hoaDon == null)
            {
                return NotFound();
            }
            //var k = JsonSerializer.Serialize(khachHang);
            return Json(new { data = hoaDon, success = true });
        }


        // GET: HoaDons/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var hoaDon = await _quanLyHoaDon.GetByIdAsync(id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // GET: HoaDons/Create
        public IActionResult Create()
        {
            ViewData["MaKH"] = new SelectList(_quanLyKhachHang.GetListCustomerAsync(), "MaKH", "MaKH");
            ViewData["MaNV"] = new SelectList(_quanLyNhanVien.GetListEmployeeAsync(), "MaNV", "MaNV");
            return View();
        }

        // POST: HoaDons/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHD,MaKH,MaNV,NgayLapHD,NgayNhanHang")] HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                await _quanLyHoaDon.AddListAsync(hoaDon);
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKH"] = new SelectList(_quanLyKhachHang.GetListCustomerAsync(), "MaKH", "MaKH", hoaDon.MaKH);
            ViewData["MaNV"] = new SelectList(_quanLyNhanVien.GetListEmployeeAsync(), "MaNV", "MaNV", hoaDon.MaNV);
            return View(hoaDon);
        }

        // GET: HoaDonsController/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _quanLyHoaDon.GetByIdAsync(id);
            if (hoaDon == null)
            {
                return NotFound();
            }
            ViewData["MaKH"] = new SelectList(_quanLyKhachHang.GetListCustomerAsync(), "MaKH", "MaKH", hoaDon.MaKH);
            ViewData["MaNV"] = new SelectList(_quanLyNhanVien.GetListEmployeeAsync(), "MaNV", "MaNV", hoaDon.MaNV);

            return View(hoaDon);
        }

        // POST: HoaDonsController/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(HoaDon hoaDon)
        {
            var hd = await _quanLyHoaDon.GetByIdAsync(hoaDon.MaHD);
            hd.MaKH = hoaDon.MaKH;
            hd.MaNV = hoaDon.MaNV;
            hd.NgayLapHD = hoaDon.NgayLapHD;
            hd.NgayNhanHang = hoaDon.NgayNhanHang;
            if (ModelState.IsValid)
            {
                try
                {
                    await _quanLyHoaDon.UpdateListAsync(hd);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonExists(hoaDon.MaHD))
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

        // POST: HoaDons/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var hoaDon = await _quanLyHoaDon.GetByIdAsync(id);
            await _quanLyHoaDon.DeleteFromListAsync(hoaDon);
            return RedirectToAction(nameof(Index));
        }
        public async Task<ActionResult> Delete(decimal id)
        {
            try
            {
                var hoaDon = await _quanLyHoaDon.GetByIdAsync(id);
                await _quanLyHoaDon.DeleteFromListAsync(hoaDon);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Json(new { success = false });
            }
        }

        private bool HoaDonExists(decimal id)
        {
            return _quanLyHoaDon.GetByIdAsync(id) != null;
        }
    }
}
