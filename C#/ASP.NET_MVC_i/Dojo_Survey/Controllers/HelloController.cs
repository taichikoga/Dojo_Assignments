using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dojo_Survey
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            // DateTime CurrentTime = DateTime.Now;
            // System.Console.WriteLine(CurrentTime);
            // ViewBag.sample = CurrentTime;
            return View("index");
        }
    }
}