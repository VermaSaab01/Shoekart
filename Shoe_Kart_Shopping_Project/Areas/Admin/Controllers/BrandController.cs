using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shoe_Kart_Shopping_DataAccess.Repository.IRepository;
using Shoe_Kart_Shopping_Model;
using Shoe_Kart_Shopping_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_User_Admin)]
    public class BrandController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BrandController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            Brand brand = new Brand();
            if (id == null)
            {
                return View(brand);
            }
            else
            {
                var brandInDb = _unitOfWork.Brand.Get(id.GetValueOrDefault());
                return View(brandInDb);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Brand brand)
        {
            if (brand == null)
                return NotFound();
            if (ModelState.IsValid)
            {
                if (brand.id == 0)
                    _unitOfWork.Brand.Add(brand);
                else
                    _unitOfWork.Brand.Update(brand);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(brand);
        }
        #region APIs
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Brand.GetAll() });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var brandInDb = _unitOfWork.Brand.Get(id);
            if (brandInDb == null)
                return Json(new { success = false, message = "Error While Delete data!!!" });
            _unitOfWork.Brand.Remove(brandInDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Data Deleted Successfully" });
            #endregion
        }
    }
}
