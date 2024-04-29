using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Shoe_Kart_Shopping_DataAccess.Repository.IRepository;
using Shoe_Kart_Shopping_Model;
using Shoe_Kart_Shopping_Model.ViewModels;
using Shoe_Kart_Shopping_Utility;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender _emailSender;
        public CartController(IUnitOfWork unitOfWork, UserManager<IdentityUser> userManager, IEmailSender emailSender)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _emailSender = emailSender;
        }
        [BindProperty]
        public ShoppingCartVM ShoppingCartVM { get; set; }
        public IActionResult Index()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim == null)
            {
                ShoppingCartVM = new ShoppingCartVM()
                {
                    ListCart = new List<ShoppingCart>()
                };
            }
            ShoppingCartVM = new ShoppingCartVM()
            {
                OrderHeader = new OrderHeader(),
                ListCart = _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == claim.Value, includeProperties: "Product")
            };
            ShoppingCartVM.OrderHeader.OrderTotal = 0;
            ShoppingCartVM.OrderHeader.ApplicationUser = _unitOfWork.ApplicationUser.FirstOrdefault(u => u.Id == claim.Value, includeProperties: "Company");
            foreach (var list in ShoppingCartVM.ListCart)
            {
                list.Price = SD.GetPriceBasedOnQuantity(list.Count, list.Product.Price, list.Product.Price50);
                ShoppingCartVM.OrderHeader.OrderTotal += (list.Price * list.Count);
                list.Product.Description = SD.ConvertToRawHtml(list.Product.Description);
                if (list.Product.Description.Length > 100)
                {
                    list.Product.Description = list.Product.Description.Substring(0, 99) + ".....";
                }
            }
            return View(ShoppingCartVM);
        }
        public IActionResult plus(int cartId)
        {
            var cart = _unitOfWork.ShoppingCart.FirstOrdefault(sc => sc.Id == cartId);
            cart.Count += 1;
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult minus(int cartId)
        {
            var cart = _unitOfWork.ShoppingCart.FirstOrdefault(sc => sc.Id == cartId);
            cart.Count -= 1;
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult delete(int cartId)
        {
            var cart = _unitOfWork.ShoppingCart.FirstOrdefault(sc => sc.Id == cartId);
            _unitOfWork.ShoppingCart.Remove(cart);
            _unitOfWork.Save();
            //Session Update(means in basket sign if there are 3 products after delete it shows 2 products)
            var count = _unitOfWork.ShoppingCart.GetAll(sc => sc.ApplicationUserId == cart.ApplicationUserId).ToList().Count;
            HttpContext.Session.SetInt32(SD.ssShoppingCartSession, count);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Summary()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            ShoppingCartVM = new ShoppingCartVM()
            {
                OrderHeader = new OrderHeader(),
                ListCart = _unitOfWork.ShoppingCart.GetAll(sc => sc.ApplicationUserId == claim.Value, includeProperties: "Product")
            };
            ShoppingCartVM.OrderHeader.ApplicationUser = _unitOfWork.ApplicationUser.FirstOrdefault(u => u.Id == claim.Value, includeProperties: "Company");
            foreach (var list in ShoppingCartVM.ListCart)
            {
                list.Price = SD.GetPriceBasedOnQuantity(list.Count, list.Product.Price, list.Product.Price50);
                ShoppingCartVM.OrderHeader.OrderTotal += (list.Price * list.Count);
                list.Product.Description = SD.ConvertToRawHtml(list.Product.Description);
            }
            ShoppingCartVM.OrderHeader.Name = ShoppingCartVM.OrderHeader.ApplicationUser.Name;
            ShoppingCartVM.OrderHeader.PhoneNumber = ShoppingCartVM.OrderHeader.ApplicationUser.PhoneNumber;
            ShoppingCartVM.OrderHeader.PostalCode = ShoppingCartVM.OrderHeader.ApplicationUser.PostalCode;
            ShoppingCartVM.OrderHeader.StreetAddress = ShoppingCartVM.OrderHeader.ApplicationUser.StreetAddress;
            ShoppingCartVM.OrderHeader.City = ShoppingCartVM.OrderHeader.ApplicationUser.City;
            ShoppingCartVM.OrderHeader.State = ShoppingCartVM.OrderHeader.ApplicationUser.State;
            return View(ShoppingCartVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Summary")]
        public IActionResult SummaryPost(string stripeToken)
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            // to fetch the details of the application user
            ShoppingCartVM.OrderHeader.ApplicationUser = _unitOfWork.ApplicationUser.FirstOrdefault(u => u.Id == claim.Value, includeProperties: "Company");
            ShoppingCartVM.ListCart = _unitOfWork.ShoppingCart.GetAll(sc => sc.ApplicationUserId == claim.Value, includeProperties: "Product");
            ShoppingCartVM.OrderHeader.PaymentStatus = SD.PaymentStatusPending;
            ShoppingCartVM.OrderHeader.OrderStatus = SD.StatusPending;
            ShoppingCartVM.OrderHeader.OrderDate = DateTime.Now;
            ShoppingCartVM.OrderHeader.ApplicationUserId = claim.Value;
            _unitOfWork.OrderHeader.Add(ShoppingCartVM.OrderHeader);
            _unitOfWork.Save();

            foreach (var item in ShoppingCartVM.ListCart)
            {
                item.Price = SD.GetPriceBasedOnQuantity(item.Count, item.Product.Price, item.Product.Price50);
                // loop in order details
                OrderDetails orderDetail = new OrderDetails()
                {
                    ProductId = item.ProductId,
                    OrderId = ShoppingCartVM.OrderHeader.id,
                    Price = item.Price,
                    Count = item.Count
                };
                ShoppingCartVM.OrderHeader.OrderTotal += orderDetail.Price * orderDetail.Count;
                _unitOfWork.OrderDetail.Add(orderDetail);
            }
            _unitOfWork.ShoppingCart.RemoveRange(ShoppingCartVM.ListCart);
            #region Stripe Payment
            if (stripeToken == null)
            {
                ShoppingCartVM.OrderHeader.PaymentDueDate = DateTime.Now.AddDays(30);
                ShoppingCartVM.OrderHeader.PaymentStatus = SD.PaymentStatusDelayPayment;
                ShoppingCartVM.OrderHeader.OrderStatus = SD.StatusApproved;
            }
            else
            {
                //Payment Process
                var options = new ChargeCreateOptions
                {
                    Amount = Convert.ToInt32(ShoppingCartVM.OrderHeader.OrderTotal),
                    Currency = "inr",
                    Description = "Order Id:" + ShoppingCartVM.OrderHeader.id,
                    Source = stripeToken
                };
                //Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                if (charge.BalanceTransactionId == null)
                    ShoppingCartVM.OrderHeader.PaymentStatus = SD.PaymentStatusRejected;
                else
                    ShoppingCartVM.OrderHeader.TransactionId = charge.BalanceTransactionId;
                if (charge.Status.ToLower() == "succeeded")
                {
                    ShoppingCartVM.OrderHeader.PaymentStatus = SD.PaymentStatusApproved;
                    ShoppingCartVM.OrderHeader.OrderStatus = SD.StatusApproved;
                    ShoppingCartVM.OrderHeader.PaymentDate = DateTime.Now;
                }
            }
            _unitOfWork.Save();
            #endregion

            //session
            HttpContext.Session.SetInt32(SD.ssShoppingCartSession, 0);
            return RedirectToAction("OrderConfirmation", "Cart", new { Id = ShoppingCartVM.OrderHeader.id });
            
        }
        public IActionResult OrderConfirmation(int Id)
        {
            return View(Id);
        }
    }
}
