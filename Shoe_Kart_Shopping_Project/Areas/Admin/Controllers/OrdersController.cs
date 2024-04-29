using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shoe_Kart_Shopping_Model;
using Shoe_Kart_Shopping_Project.Data;
using Shoe_Kart_Shopping_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_User_Admin)]
    public class OrdersController : Controller
    {
        private readonly Shoe_Kart_Shopping_DataAccess.Repository.IRepository.IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        public OrdersController(Shoe_Kart_Shopping_DataAccess.Repository.IRepository.IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ByDateTime(DateTime? datetime1, DateTime? datetime2)
        {
            if (datetime1==null&&datetime2==null)
            {
                return RedirectToAction("Index");
            }
            if (datetime2 == null)
            {
                var date = _unitOfWork.OrderHeader.GetAll(u => u.OrderDate.Date == datetime1);
                return View(date);
            }
            if (datetime1 == null)
            {
                var date = _unitOfWork.OrderHeader.GetAll(u => u.OrderDate.Date == datetime2);
                return View(date);
            }
            IQueryable<OrderHeader> query = from o in _context.OrderHeaders select o;
            if (datetime1!=null&&datetime2!=null)
            {
                query = from o in _context.OrderHeaders where o.OrderDate.Date > datetime1 && o.OrderDate.Date <= datetime2 select o;
            }
            return View(query);
        }
        public IActionResult Details(int id)
        {
            var allDetails = _unitOfWork.OrderDetail.FirstOrdefault
                (u => u.Id == id, includeProperties: "Product,OrderHeader,Product.Brand,Product.Category,OrderHeader.ApplicationUser");
            return View(allDetails);
        }
        public IActionResult StatusApproved()
        {
            var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Approved");
            return View(approved);
        }
        public IActionResult StatusPending()
        {
            var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Pending");
            return View(approved);
        }
        public IActionResult StatusCancelled()
        {
            var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Cancelled");
            return View(approved);
        }
        public IActionResult StatusRefunded()
        {
            var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Refunded");
            return View(approved);
        }
        public IActionResult StatusProcessing()
        {
            var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Processing");
            return View(approved);
        }
        public IActionResult StatusShipped()
        {
            var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Shipped");
            return View(approved);
        }
        #region APIs
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.OrderHeader.GetAll() });
        }
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    return Json(new { data = _unitOfWork.OrderHeader.GetAll() });
        //}
        //[HttpGet]
        //public IActionResult StatusApproved()
        //{
        //    var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Approved");
        //    return View(approved);
        //}
        //[HttpGet]

        //public IActionResult StatusPending()
        //{
        //    var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Pending");
        //    return View(approved);
        //}
        //[HttpGet]

        //public IActionResult StatusCancelled()
        //{
        //    var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Cancelled");
        //    return View(approved);
        //}
        //[HttpGet]

        //public IActionResult StatusRefunded()
        //{
        //    var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Refunded");
        //    return View(approved);
        //}
        //[HttpGet]

        //public IActionResult StatusProcessing()
        //{
        //    var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Processing");
        //    return View(approved);
        //}
        //[HttpGet]

        //public IActionResult StatusShipped()
        //{
        //    var approved = _unitOfWork.OrderHeader.GetAll().Where(os => os.OrderStatus == "Shipped");
        //    return View(approved);
        //}
        //[HttpGet]
        //public IActionResult AllDetails()
        //{
        //    var allDetails = _unitOfWork.OrderDetails.GetAll();
        //    return Json(new { data = allDetails });
        //}
        #endregion
    }
}