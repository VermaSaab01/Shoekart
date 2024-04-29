using Shoe_Kart_Shopping_DataAccess.Repository.IRepository;
using Shoe_Kart_Shopping_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
            Brand = new BrandRepository(_context);
            SP_CALL = new SP_CALL(_context);
            ShoeSize = new ShoeSizeRepository(_context);
            Product = new ProductRepository(_context);
            ApplicationUser = new ApplicationUserRepository(_context);
            Company = new CompanyRepository(context);
            ShoppingCart = new ShoppingCartRepository(_context);
            OrderHeader = new OrderHeaderRepository(_context);
            OrderDetail = new OrderDetailRepository(_context);
            ShoeSizeSelector = new ShoeSizeSelectorRepository(_context);
        }
        public ICategoryRepository Category { get; private set; }

        public IBrandRepository Brand { get; private set; }
        public ISP_CALL SP_CALL { get; private set; }

        public IShoeSizeRepository ShoeSize { get; private set; }

        public IProductRepository Product { get; private set; }

        public IApplicationUserRepository ApplicationUser { get; private set; }

        public ICompanyRepository Company { get; private set; }

        public IShoppingCartRepository ShoppingCart { get; private set; }

        public IOrderHeaderRepository OrderHeader { get; private set; }

        public IOrderDetailRepository OrderDetail { get; private set; }

        public IShoeSizeSelectorRepository ShoeSizeSelector { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
