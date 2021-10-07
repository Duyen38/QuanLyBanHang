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
        // GET: SanPhams
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

        // GET: SanPhams/Details/5
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

        // GET: SanPhams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SanPhams/Create
        [HttpPost]
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
        // GET: SanPhams/GetDataById/id
        public ActionResult GetDataById(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sp = _quanLySanPham.GetByIdAsync(id);
            if (sp == null)
            {
                return NotFound();
            }
            //var k = JsonSerializer.Serialize(khachHang);
            return Json(new { data = sp, success = true });
        }

        // GET: SanPhams/Edit/5
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

        // POST: SanPhams/Edit
        [HttpPost]
        public async Task<ActionResult> Edit(SanPham sanPham)
        {
            var sp = await _quanLySanPham.GetByIdAsync(sanPham.MaSP);
            sp.TenSp = sanPham.TenSp;
            sp.DonGia = sanPham.DonGia;
            sp.DonViTinh = sanPham.DonViTinh;
            if (ModelState.IsValid)
            {
                try
                {
                    await _quanLySanPham.UpdateListAsync(sp);
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
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        // POST: SanPhams/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                var sp = await _quanLySanPham.GetByIdAsync(id);
                await _quanLySanPham.DeleteFromLIstAsync(sp);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return Json(new { success = false });
            }
        }

        private bool SanPhamExists(string id)
        {
            return _quanLySanPham.GetByIdAsync(id) != null;
        }
    }
}