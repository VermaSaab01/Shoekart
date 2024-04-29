
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
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        private readonly ApplicationDbContext _context;
        public BrandRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public void Update(Brand brand)
        {
           _context.Update(brand);

        }
    }
}
