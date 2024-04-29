using Shoe_Kart_Shopping_DataAccess.Repository.IRepository;
using Shoe_Kart_Shopping_Model;
using Shoe_Kart_Shopping_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        //public object FirstOrDefault(Func<object, bool> p, string includeProperties)
        //{
        //    throw new NotImplementedException();
        //}

        public void Update(Product product)
        {
            var productInDb = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if(productInDb!=null)
            {
                if (product.ImageURL != "")
                    productInDb.ImageURL = product.ImageURL;
                productInDb.SerialNo = product.SerialNo;
                productInDb.Description = product.Description;
                productInDb.ListPrice = product.ListPrice;
                productInDb.Price50 = product.Price50;
                productInDb.Price = product.Price;
                productInDb.Gender = product.Gender;
                productInDb.BrandId = product.BrandId;
                productInDb.CategoryId = product.CategoryId;
                productInDb.ShoeSizeId = product.ShoeSizeId;
            }
        }
    }
}
