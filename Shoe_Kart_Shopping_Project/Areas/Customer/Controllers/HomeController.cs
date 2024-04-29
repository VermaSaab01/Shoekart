using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Shoe_Kart_Shopping_DataAccess.Repository.IRepository;
using Shoe_Kart_Shopping_Model;
using Shoe_Kart_Shopping_Model.ViewModels;
using Shoe_Kart_Shopping_Project.Data;
using Shoe_Kart_Shopping_Project_Model.ViewModels;
using Shoe_Kart_Shopping_Utility;
using System;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_Project.Area.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _iunitofwork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            _logger = logger;
            _iunitofwork = unitOfWork;
            _context = context;
        }
        public async Task<IActionResult> Index(string Search)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var product = from p in _context.Products.Include("Brand")
                          select p;
            if (!String.IsNullOrEmpty(Search))
            {
                product = product.Where(s => s.Brand.Name!.Contains(Search));
            }

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                var count = _iunitofwork.ShoppingCart.GetAll(c => c.ApplicationUserId == claim.Value).ToList().Count;
                HttpContext.Session.SetInt32(SD.ssShoppingCartSession, count);
            }

            return View(await product.ToListAsync());

            //var laptopList = _unitOfWork.Laptop.GetAll(includePropties: "LaptopCompany,Processor,GraphicsCard");
            //return View(laptopList);
        }



        /* public IActionResult Index()
         {
             var claimIdentity = (ClaimsIdentity)(User.Identity);
             var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
             if (claim != null)
             {
                 var count = _iunitofwork.ShoppingCart.GetAll(s => s.ApplicationUserId == claim.Value).ToList().Count;
                 HttpContext.Session.SetInt32(SD.ssShoppingCartSession, count);
             }
             var productList = _iunitofwork.Product.GetAll(includeProperties: "Brand,Category,ShoeSize");
             return View(productList);
         }*/

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Details(int id)
        {
            var productInDb = _iunitofwork.Product.FirstOrdefault(p => p.Id == id, includeProperties: "Brand,Category,ShoeSize");
            //var shoppingcart = new ShoppingCart()
            //{
            //    Product = productInDb,
            //    ProductId = productInDb.Id
            //};
            ShoeVM shoeVM = new ShoeVM()
            {
                ShoppingCart = new ShoppingCart()
                {
                    Product = productInDb,
                    ProductId = productInDb.Id
                },
                ShoeSizeList = _iunitofwork.ShoeSizeSelector.GetAll().Select(s => new SelectListItem
                {
                    Text = s.Name,
                    Value = s.Id.ToString()
                })
            };
            return View(shoeVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Details(ShoeVM shoppingCartObj)
        {
            shoppingCartObj.ShoppingCart.Id = 0;
            if (ModelState.IsValid)
            {
                var claimIdentity = (ClaimsIdentity)(User.Identity);
                var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
                shoppingCartObj.ShoppingCart.ApplicationUserId = claim.Value;
                var shoppingCartFromDb = _iunitofwork.ShoppingCart.FirstOrdefault(s => s.ApplicationUserId == claim.Value && s.ProductId == shoppingCartObj.ShoppingCart.ProductId, includeProperties: "Product");
                if (shoppingCartFromDb == null)
                    _iunitofwork.ShoppingCart.Add(shoppingCartObj.ShoppingCart);
                else
                    shoppingCartFromDb.Count += shoppingCartObj.ShoppingCart.Count;
                _iunitofwork.Save();
                //Sessions
                var count = _iunitofwork.ShoppingCart.GetAll(u => u.ApplicationUserId == claim.Value).ToList().Count;
                HttpContext.Session.SetInt32(SD.ssShoppingCartSession, count);
                return RedirectToAction(nameof(Index));

            }
            else
            {
                var productInDb = _iunitofwork.Product.FirstOrdefault(p => p.Id == shoppingCartObj.ShoppingCart.ProductId, includeProperties: "Category,CoverType");
                var shoppingCart = new ShoppingCart()
                {
                    Product = productInDb,
                    ProductId = productInDb.Id
                };
                return View(shoppingCart);
            }
        }
    }
}
