using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shoe_Kart_Shopping_DataAccess.Repository;
using Shoe_Kart_Shopping_DataAccess.Repository.IRepository;
using Shoe_Kart_Shopping_Model;
using Shoe_Kart_Shopping_Model.ViewModels;
using Shoe_Kart_Shopping_Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_User_Admin)]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _iunitofwork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IUnitOfWork unitOfWork,IWebHostEnvironment webHostEnvironment)
        {
            _iunitofwork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
           // ProductVM productVM = new ProductVM()
            //{
            //    Product = new Product(),
            //    BrandList = _iunitofwork.Brand.GetAll().Select(br => new SelectListItem()
            //    {
            //        Text = br.Name,
            //        Value = br.id.ToString()
            //    }),
            //    CategoryList = _iunitofwork.Category.GetAll().Select(cl => new SelectListItem()
            //    {
            //        Text = cl.Name,
            //        Value = cl.id.ToString()
            //    }),
            //    ShoeSizeList = _iunitofwork.ShoeSize.GetAll().Select(ss => new SelectListItem()
            //    {
            //        Text = ss.Name,
            //        Value = ss.Id.ToString()
            //    })
            //};
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                BrandList = _iunitofwork.Brand.GetAll().Select(br => new SelectListItem()
                {
                    Text = br.Name,
                    Value = br.id.ToString()
                }),
                CategoryList = _iunitofwork.Category.GetAll().Select(cl => new SelectListItem()
                {
                    Text = cl.Name,
                    Value = cl.id.ToString()
                }),
                ShoeSizeList = _iunitofwork.ShoeSize.GetAll().Select(ss => new SelectListItem()
                {
                    Text = ss.Name,
                    Value = ss.Id.ToString()
                })
            };
            if (id == null)
                return View(productVM);
            productVM.Product = _iunitofwork.Product.Get(id.GetValueOrDefault());
            return View(productVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ProductVM productVM)
            {
            if(ModelState.IsValid)
            {
               
                var webrootPath = _webHostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if(files.Count()>0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webrootPath, @"images\products");
                    var extension = Path.GetExtension(files[0].FileName);
                    if(productVM.Product.Id!=0)
                    {
                        var imageExist = _iunitofwork.Product.Get(productVM.Product.Id).ImageURL;
                        productVM.Product.ImageURL = imageExist;
                    }
                    if(productVM.Product.ImageURL!=null)
                    {
                        var imagePath = Path.Combine(webrootPath, productVM.Product.ImageURL.TrimStart('\\'));
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }
                    productVM.Product.ImageURL = @"\images\products\" + fileName + extension;
                }
                else
                {
                    if (productVM.Product.Id != 0)
                    {
                        var productInDb = _iunitofwork.Product.Get(productVM.Product.Id);
                        productVM.Product.ImageURL = productInDb.ImageURL;
                    }
                }
              
                if (productVM.Product.Id == 0)
                    _iunitofwork.Product.Add(productVM.Product);
                else
                    _iunitofwork.Product.Update(productVM.Product);
                    _iunitofwork.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                productVM = new ProductVM()
                {
                    BrandList = _iunitofwork.Brand.GetAll().Select(br => new SelectListItem()
                    {
                        Text = br.Name,
                        Value = br.id.ToString()
                    }),
                    CategoryList = _iunitofwork.Category.GetAll().Select(ct => new SelectListItem()
                    {
                        Text = ct.Name,
                        Value = ct.id.ToString()
                    }),
                    ShoeSizeList = _iunitofwork.ShoeSize.GetAll().Select(ss => new SelectListItem()
                    {
                        Text = ss.Name,
                        Value = ss.Id.ToString()
                    })
                };
                if(productVM.Product.Id!=0)
                {
                    productVM.Product = _iunitofwork.Product.Get(productVM.Product.Id);
                }
                return View(productVM);
            }
        }

        #region APIs
        [HttpGet]
        //public IActionResult GetAll()
        //{
        //    //return Json(new { data = _unitOfWork.CoverType.GetAll() });
        //    var coverTypeList = _iunitofwork.SP_CALL.List<Product>(SD.Proc_product);
        //    return Json(new { data = coverTypeList });
            //public IActionResult GetAll()
            //{
            //    ProductVM productVM = new ProductVM()
            //    {
            //        Product = new Product(),
            //        Category = new Category(),
            //        ShoeSize = new ShoeSize()

            //    };
            //    return Json(new { data = _iunitofwork.Product.GetAll(includeProperties: "Category,ShoeSize") });
            //}
            
        public IActionResult GetAll()
        {
            return Json(new { data = _iunitofwork.Product.GetAll() });
        }
        
            [HttpDelete]
        public IActionResult Delete(int id)
        {
           
            var productIndb = _iunitofwork.Product.Get(id);
            if (productIndb == null)
                return Json(new { success = false, message = "Error While Delete Data!!!" });
            var webRootPath = _webHostEnvironment.WebRootPath;
            var imagepath = Path.Combine(webRootPath, productIndb.ImageURL.TrimStart('\\'));
            if(System.IO.File.Exists(imagepath))
            {
                System.IO.File.Delete(imagepath);
            }
            _iunitofwork.Product.Remove(productIndb);
            _iunitofwork.Save();
            return Json(new { success = true, message = "Data Deleted Successfully!!!" });

        }
        #endregion
    }
}
