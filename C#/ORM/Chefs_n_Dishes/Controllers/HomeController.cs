using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chefs_n_Dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace Chefs_n_Dishes.Controllers
{
    public class HomeController : Controller
    {
        private Chefs_n_DishesContext db;

        public HomeController(Chefs_n_DishesContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            List<User> allUsersList = db.Users
            .Include(user => user.Dishes)
            .OrderByDescending(date => date.CreatedAt)
            .ToList();
            return View(allUsersList);
        }

        [HttpGet("newuserpage")]
        public IActionResult NewUserPage()
        {
            return View("NewUser");
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid == false)
            {
                return View("NewUser");
            }

            var age = DateTime.Today.Year - newUser.Birthday.Year;
            if (age < 18)
            {
                ModelState.AddModelError("Birthday", "must 18 years or older");
                return View("Newuser");
            }

            db.Users.Add(newUser);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
