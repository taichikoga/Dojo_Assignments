using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Message message = new Message ()
            {
                NewMessage = "Bojack Horseman is the greatest show on Netflix. Convince me otherwise."
            };
            return View(message);
        }

        Users Person1 = new Users()
        {
            Name = "Billy Bob"
        };
        Users Person2 = new Users()
        {
            Name = "Sally May"
        };

        [HttpGet("user")]
        public IActionResult User()
        {
            Users Person1 = new Users()
            {
                Name = "Billy Bob"
            };
            return View(Person1);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<Users> users_list = new List<Users>()
            {
                Person1, Person2
            };
            return View(users_list);
        }

        Numbers one = new Numbers()
        {
            Num = 1
        };
        Numbers two = new Numbers()
        {
            Num = 2
        };

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            List<Numbers> numbers_list = new List<Numbers>
            {
                one, two
            };
            return View(numbers_list);
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
