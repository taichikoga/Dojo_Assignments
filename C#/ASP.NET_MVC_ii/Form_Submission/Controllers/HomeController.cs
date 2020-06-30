using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Form_Submission.Models;

namespace Form_Submission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost("register")]
        public IActionResult Register(User new_user)
        {
            // System.Console.WriteLine(ModelState.IsValid);
            if(ModelState.IsValid)
            {
                return View("success");
            }
            else
            {
                return View("index");
            }
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
