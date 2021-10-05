using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Features.SanPhams
{
    [Area("QuanLy")]
    public class SanPhamsController : Controller
    {
        private readonly IQuanLySanPham _quanLySanPham;

        public SanPhamsController(IQuanLySanPham quanLySanPham)
        {
            _quanLySanPham = quanLySanPham;
        }
        // GET: SanPhamsController
        public async Task<IActionResult> Index(string searchString)
        {
            var sanPham = await _quanLySanPham.GetAllAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                sanPham = sanPham.Where(s => s.TenSp.Contains(searchString));
            }

            return View(await sanPham.ToListAsync());
        }

        //GET: SanPhams/getdata
        public ActionResult GetData()
        {
            var sanPham = _quanLySanPham.GetListProduct();
            return Json(new { Data = sanPham, TotalItem = sanPham.Count() });
        }

        // GET: ThongKeDSSP
        public async Task<IActionResult> ThongKeDSSP(string searchString)
        {
            var listProduct = await _quanLySanPham.GetPurchaseStatisticsAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                listProduct = listProduct.Where(s => s.TenSp.Contains(searchString));
            }
            return View(listProduct.ToList());
        }

        // GET: SanPhamsController/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _quanLySanPham.GetByIdAsync(id);

            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // GET: SanPhamsController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SanPhamsController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(SanPham sanPham)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _quanLySanPham.AddListAsync(sanPham);
                }
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Json(new { success = false });
            }
        }
        //public async Task<IActionResult> Create([Bind("MaSP,TenSp,DonViTinh,DonGia")] SanPham sanPham)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _quanLySanPham.AddListAsync(sanPham);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(sanPham);
        //}


        // GET: SanPhamsController/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _quanLySanPham.GetByIdAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }
            return View(sanPham);
        }

        // POST: SanPhamsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaSP,TenSp,DonViTinh,DonGia")] SanPham sanPham)
        {
            if (id != sanPham.MaSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _quanLySanPham.UpdateListAsync(sanPham);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamExists(sanPham.MaSP))
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
            return View(sanPham);
        }

        // GET: SanPhamsController/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _quanLySanPham.GetByIdAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // POST: SanPhamsController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sanPham = await _quanLySanPham.GetByIdAsync(id);
            await _quanLySanPham.DeleteFromLIstAsync(sanPham);
            return RedirectToAction(nameof(Index));
        }

        private bool SanPhamExists(string id)
        {
            return _quanLySanPham.GetByIdAsync(id) != null;
        }
    }
}