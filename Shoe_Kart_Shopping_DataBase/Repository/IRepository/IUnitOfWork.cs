using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_DataAccess.Repository.IRepository
{
   public interface IUnitOfWork
    {
        ICategoryRepository Category { get;  }
        ISP_CALL SP_CALL { get; }
        IBrandRepository Brand { get; }
        IShoeSizeRepository ShoeSize { get; }
        IProductRepository Product { get; }
        IApplicationUserRepository ApplicationUser { get; }
        ICompanyRepository Company { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailRepository OrderDetail { get; }
      IShoeSizeSelectorRepository ShoeSizeSelector { get; }

        void Save();
    }
}
