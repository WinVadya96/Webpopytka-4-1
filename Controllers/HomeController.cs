using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webpopytka_4_1.Models;
using Webpopytka_4_1.Models.ViewModels;

namespace Webpopytka_4_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult ViewUsers()
        {
            var users = dbContext.Set<ApplicationUser>()
                .ToList()
                .Select(u => new UserViewModel
                {
                    Id = u.Id,
                    Name = u.UserName,
                    Email = u.Email,
                    CreatedOn = u.CreatedOn,
                    LastLoginTime = u.LastLoginTime,
                    IsLoggedIn = u.IsLoggedIn
                });

            return View(users);
        }
    }
}