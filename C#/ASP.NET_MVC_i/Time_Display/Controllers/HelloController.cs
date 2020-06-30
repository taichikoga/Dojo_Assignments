using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Time_Display
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            System.Console.WriteLine(CurrentTime);
            ViewBag.sample = CurrentTime;
            return View("index");
        }
    }
}