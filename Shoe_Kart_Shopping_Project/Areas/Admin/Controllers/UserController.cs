using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
     [Authorize(Roles = SD.Role_User_Admin + "," + SD.Role_User_Employee)]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region APIs
        [HttpGet]
        public IActionResult GetAll()
        {
            var userList = _context.ApplicationUsers.Include(u => u.Company).ToList();
            var roles = _context.Roles.ToList();
            var userRoles = _context.UserRoles.ToList();
            foreach (var user in userList)
            {
                var roleId = userRoles.FirstOrDefault(u => u.UserId == user.Id).RoleId;
                user.Role = roles.FirstOrDefault(r => r.Id == roleId).Name;
                if(user.Company==null)
                {
                    user.Company = new Company()
                    {
                        Name = ""
                    };
                }
            }
            //Admin user (not to display admin user in browser)
            if (!User.IsInRole(SD.Role_User_Admin))
            {
                var userAdmin = userList.FirstOrDefault(u => u.Role == SD.Role_User_Admin);
                userList.Remove(userAdmin);
            }
            return Json(new { data = userList });
        }
        [HttpPost]
        public IActionResult LockUnLock([FromBody] string id)
        {
            bool isLocked = false;
            var userInDb = _context.ApplicationUsers.FirstOrDefault(u => u.Id == id);
            if (userInDb == null)
                return Json(new { success = false, message = "Error while Locking And UnLocking!!!" });
            if (userInDb != null && userInDb.LockoutEnd > DateTime.Now)
            {
                userInDb.LockoutEnd = DateTime.Now;
                isLocked = false;
            }
            else
            {
                userInDb.LockoutEnd = DateTime.Now.AddYears(50);
                isLocked = true;
            }
            _context.SaveChanges();
            return Json(new { success = true, message = isLocked == true ? "User Successfully Locked" : "User Successfully Unlocked" });
        }
        #endregion
    }
}
