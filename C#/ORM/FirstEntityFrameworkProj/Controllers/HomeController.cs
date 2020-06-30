using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstEntityFrameworkProj.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstEntityFrameworkProj.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<User> AllUsers = dbContext.Users.ToList();
            return View();
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
