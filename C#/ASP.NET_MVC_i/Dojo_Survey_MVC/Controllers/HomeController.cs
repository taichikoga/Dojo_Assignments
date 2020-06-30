using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_MVC.Models;

namespace Dojo_Survey_MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost("survey")]
        public IActionResult Survey(Survey new_survey)
        {
            System.Console.WriteLine("I AM INSIDE THE SURVEY METHOD");
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("TRYING TO VIEW RESULTS");
                return View("results", new_survey);
            }
            else
            {
                System.Console.WriteLine("TRYING TO DISPLAY INDEX W/ERRORS");
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
