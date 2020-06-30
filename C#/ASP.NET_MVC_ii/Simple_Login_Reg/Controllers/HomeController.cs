using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simple_Login_Reg.Models;
using Microsoft.AspNetCore.Http;

namespace Simple_Login_Reg.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost("register")]
        public IActionResult ProcessRegistration(Register NewRegistration)
        {
            if(ModelState.IsValid)
            {
                return View("success");
            }
            else
            {
                return View("index");
            }
        }

        [HttpPost("login")]
        public IActionResult ProcessLogin(Login NewLogin)
        {
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
