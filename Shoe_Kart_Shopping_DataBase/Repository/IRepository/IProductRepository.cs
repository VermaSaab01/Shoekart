using Shoe_Kart_Shopping_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_DataAccess.Repository.IRepository
{
   public interface IProductRepository:IRepository<Product>
    {
        void Update(Product product);
        //object FirstOrDefault(Func<object, bool> p, string includeProperties);
    }
}
