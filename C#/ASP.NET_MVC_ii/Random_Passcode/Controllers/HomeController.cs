using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Random_Passcode.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace Random_Passcode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // *Inside controller methods*
            // // To store a string in session we use ".SetString"
            // // The first string passed is the key and the second is the value we want to retrieve later
            // HttpContext.Session.SetString("Passcode", "1234ABCD");
            // // To retrieve a string from session we use ".GetString"copy
            // string Passcode = HttpContext.Session.GetString("Passcode");
            // To store an int in session we use ".SetInt32"
            if(HttpContext.Session.GetInt32("Count") == null)
            {
                System.Console.WriteLine("Count is set as 0");
                int counter = 0;
                HttpContext.Session.SetInt32("Count", counter);
                // To retrieve an int from session we use ".GetInt32"
                int? CountSession = HttpContext.Session.GetInt32("Count");
                ViewBag.Count = CountSession;
                return View("index");
            }
            else
            {
                System.Console.WriteLine("Method processing after generating new passcode");
                int? CountSession = HttpContext.Session.GetInt32("Count");
                ViewBag.Count = CountSession;
                return View("index");
            }
        }

        [HttpGet("generate")]
        public RedirectToActionResult Generate()
        {
            System.Console.WriteLine("Redirecting to Index through Generate button");

            const string alphanumeric = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string new_passcord = "";
            // Random rand = new Random();
            for (int i = 0; i < 14; i++)
            {
                Random rand = new Random();
                char val = alphanumeric[rand.Next(36)];
                System.Console.WriteLine(val);
            }
            System.Console.WriteLine("TEST 1");

            int? counter = HttpContext.Session.GetInt32("Count");
            int castedcounter = (int)counter;
            castedcounter += 1;
            HttpContext.Session.SetInt32("Count", castedcounter);
            int? CountSession = HttpContext.Session.GetInt32("Count");
            ViewBag.Count = CountSession;
            return RedirectToAction("index");
        }

        // [HttpGet("generate")]
        // public IActionResult Generate()
        // {
        //     int? OldCountSession = HttpContext.Session.GetInt32("Count");
        //     OldCountSession += 1;
        //     // NewCountSession = int OldCountSession;
        //     int? NewCountSession = HttpContext.Session.SetInt32("Count", NewCountSession);
        //     ViewBag.Count = NewCountSession;
        //     return View("index");
        // }

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
    public static class SessionExtensions
    {
        // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            // This helper function simply serializes theobject to JSON and stores it as a string in session
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        // generic type T is a stand-in indicating that we need to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // Upon retrieval the object is deserialized based on the type we specified
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
