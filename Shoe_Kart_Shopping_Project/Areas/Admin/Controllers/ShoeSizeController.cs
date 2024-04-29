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
    public class ShoeSizeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShoeSizeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            ShoeSize shoeSize = new ShoeSize();
            if (id == null)
            {
                return View(shoeSize);
            }
            else
            {
                var shoesizeInDb = _unitOfWork.ShoeSize.Get(id.GetValueOrDefault());
                return View(shoesizeInDb);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ShoeSize shoeSize)
        {
            if (shoeSize == null)
                return NotFound();
            if (ModelState.IsValid)
            {
                if (shoeSize.Id == 0)
                    _unitOfWork.ShoeSize.Add(shoeSize);
                else
                    _unitOfWork.ShoeSize.Update(shoeSize);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(shoeSize);
        }


        #region APIs
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.ShoeSize.GetAll() });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var shoesizeInDb = _unitOfWork.ShoeSize.Get(id);
            if (shoesizeInDb == null)
                return Json(new { success = false, message = "Error While Delete data!!!" });
            _unitOfWork.ShoeSize.Remove(shoesizeInDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Data Deleted Successfully" });
        }
        #endregion
    }
}
