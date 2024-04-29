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
   public class ApplicationUserRepository:Repository<ApplicationUser>,IApplicationUserRepository
    {
        private readonly ApplicationDbContext _context;
        public ApplicationUserRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
    }
}
