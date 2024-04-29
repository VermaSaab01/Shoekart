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
    [Authorize(Roles =SD.Role_User_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                return View(category);
            }
            else
            {
                var categoryInDb = _unitOfWork.Category.Get(id.GetValueOrDefault());
                return View(categoryInDb);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (category == null)
                return NotFound();
            if (ModelState.IsValid)
            {
                if (category.id == 0)
                    _unitOfWork.Category.Add(category);
                else
                    _unitOfWork.Category.update(category);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        #region APIs
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Category.GetAll() });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var categoryInDb = _unitOfWork.Category.Get(id);
            if (categoryInDb == null)
                return Json(new { success = false, message = "Error While Delete data!!!" });
            _unitOfWork.Category.Remove(categoryInDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Data Deleted Successfully" });
        }
        #endregion
    }
}
