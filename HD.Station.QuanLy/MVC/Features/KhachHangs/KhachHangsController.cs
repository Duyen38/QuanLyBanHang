using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
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

        //GET: KhachHangs
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


        // GET: KhachHangs/Details/5
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

        // GET: KhachHangs/Create
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

        // GET: KhachHangs/GetDataById/id
        public ActionResult GetDataById(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = _quanLyKhachHang.GetByIdAsync(id);
            if (khachHang == null)
            {
                return NotFound();
            }
            //var k = JsonSerializer.Serialize(khachHang);
            return Json(new { data = khachHang, success = true });
        }

        // POST: KhachHangs/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(KhachHang khachHang)
        {
            var kh = await _quanLyKhachHang.GetByIdAsync(khachHang.MaKH);
            kh.HoTenKH = khachHang.HoTenKH;
            kh.DiaChi = khachHang.DiaChi;
            kh.DienThoai = khachHang.DienThoai;
            if (ModelState.IsValid)
            {
                try
                {                    
                    await _quanLyKhachHang.UpdateListAsync(kh);
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
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        // POST: KhachHangsController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                var khachHang = await _quanLyKhachHang.GetByIdAsync(id);
                await _quanLyKhachHang.DeleteAsync(khachHang);
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
// GET: KhachHangsController/Edit/5
//public async Task<IActionResult> Edit(string id)
//{
//    if (id == null)
//    {
//        return NotFound();
//    }

//    var khachHang = await _quanLyKhachHang.GetByIdAsync(id);
//    if (khachHang == null)
//    {
//        return NotFound();
//    }
//    return View(khachHang);
//}
//public async Task<IActionResult> Edit(string id, [Bind("MaKH,HoTenKH,DiaChi,DienThoai")] KhachHang khachHang)
//{
//    if (id != khachHang.MaKH)
//    {
//        return NotFound();
//    }

//    if (ModelState.IsValid)
//    {
//        try
//        {
//            await _quanLyKhachHang.UpdateListAsync(khachHang);
//        }
//        catch (DbUpdateConcurrencyException)
//        {
//            if (!KhachHangExists(khachHang.MaKH))
//            {
//                return NotFound();
//            }
//            else
//            {
//                throw;
//            }
//        }
//        return RedirectToAction(nameof(Index));
//    }
//    return View(khachHang);
//}