using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi_Assignment.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Dojodachi_Assignment.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Happiness") == null)
            {
                System.Console.WriteLine("Creating initial numbers for dojodachi");
                int Happiness = 20;
                int Fullness = 20;
                int Energy = 50;
                int Meals = 3;
                string Message = "Waiting on your action";
                HttpContext.Session.SetInt32("Happiness", Happiness);
                HttpContext.Session.SetInt32("Fullness", Fullness);
                HttpContext.Session.SetInt32("Energy", Energy);
                HttpContext.Session.SetInt32("Meals", Meals);
                HttpContext.Session.SetString("Message", Message);
                int? HappinessSession = HttpContext.Session.GetInt32("Happiness");
                int? FullnessSession = HttpContext.Session.GetInt32("Fullness");
                int? EnergySession = HttpContext.Session.GetInt32("Energy");
                int? MealsSession = HttpContext.Session.GetInt32("Meals");
                string MessageSession = HttpContext.Session.GetString("Message");
                ViewBag.Happiness = HappinessSession;
                ViewBag.Fullness = FullnessSession;
                ViewBag.Energy = EnergySession;
                ViewBag.Meals = MealsSession;
                ViewBag.Message = MessageSession;
                return View("index");
            }
            else if(HttpContext.Session.GetInt32("Happiness") != null)
            {
                int? HappinessSession = HttpContext.Session.GetInt32("Happiness");
                int? FullnessSession = HttpContext.Session.GetInt32("Fullness");
                int? EnergySession = HttpContext.Session.GetInt32("Energy");
                int? MealsSession = HttpContext.Session.GetInt32("Meals");
                string MessageSession = HttpContext.Session.GetString("Message");
                ViewBag.Happiness = HappinessSession;
                ViewBag.Fullness = FullnessSession;
                ViewBag.Energy = EnergySession;
                ViewBag.Meals = MealsSession;
                if (HappinessSession <= 0 || FullnessSession <= 0)
                {
                    string NewMessage = "Your Dojodachi passed away :(((";
                    HttpContext.Session.SetString("Message", NewMessage);
                    ViewBag.Message = MessageSession;
                    return View ("index");
                }
                else if (EnergySession >= 100 && FullnessSession >= 100 && HappinessSession >= 100)
                {
                    string NewMessage = "Congratulations! You won!";
                    HttpContext.Session.SetString("Message", NewMessage);
                    ViewBag.Message = MessageSession;
                    return View ("index");
                }
                else
                {
                    ViewBag.Message = MessageSession;
                    return View ("index");
                }
            }
            return View();
        }

        [HttpGet("feed")]
        public RedirectToActionResult Feed()
        {
            if(HttpContext.Session.GetInt32("Meals") > 0)
            {
                Random rand = new Random();
                int rejectionChance = rand.Next(4);
                System.Console.WriteLine(rejectionChance);
                if (rejectionChance == 0)
                {
                    int? MealsSession = HttpContext.Session.GetInt32("Meals");
                    int CastedMealSession = (int)MealsSession;
                    CastedMealSession -= 1;
                    HttpContext.Session.SetInt32("Meals", CastedMealSession);
                    ViewBag.Meals = CastedMealSession;

                    string NewMessage = $"Your Dojodachi didn't like that :( Meals -1";
                    HttpContext.Session.SetString("Message", NewMessage);
                    ViewBag.Message = NewMessage;
                    return RedirectToAction("Index");
                }
                else
                {
                    System.Console.WriteLine("Feeding Dojodachi!");

                    int? MealsSession = HttpContext.Session.GetInt32("Meals");
                    int CastedMealSession = (int)MealsSession;
                    CastedMealSession -= 1;
                    HttpContext.Session.SetInt32("Meals", CastedMealSession);
                    ViewBag.Meals = CastedMealSession;

                    int? FullnessSession = HttpContext.Session.GetInt32("Fullness");
                    int CastedFullnessSession = (int)FullnessSession;
                    Random random = new Random();
                    int randomNumber = random.Next(5,11);
                    CastedFullnessSession += randomNumber;
                    HttpContext.Session.SetInt32("Fullness", CastedFullnessSession);
                    ViewBag.Fullness = CastedFullnessSession;

                    string NewMessage = $"You fed your Dojodachi! Fullness +{randomNumber}, Meals -1";
                    HttpContext.Session.SetString("Message", NewMessage);
                    ViewBag.Message = NewMessage;

                    return RedirectToAction("Index");
                }
            }
            else
            {
                System.Console.WriteLine("Not enough meals!");

                string NewMessage = "Not enough meals to feed your Dojodachi!";
                HttpContext.Session.SetString("Message", NewMessage);
                ViewBag.Message = NewMessage;

                return RedirectToAction("Index");
            }
        }

        [HttpGet("play")]
        public RedirectToActionResult Play()
        {
            if(HttpContext.Session.GetInt32("Energy") >= 5)
            {
                Random rand = new Random();
                int rejectionChance = rand.Next(4);
                System.Console.WriteLine(rejectionChance);
                if (rejectionChance == 0)
                {
                    int? EnergySession = HttpContext.Session.GetInt32("Energy");
                    int CastedEnergySession = (int)EnergySession;
                    CastedEnergySession -= 5;
                    HttpContext.Session.SetInt32("Energy", CastedEnergySession);
                    ViewBag.Energy = CastedEnergySession;

                    string NewMessage = $"Your Dojodachi didn't like that :( Energy -5";
                    HttpContext.Session.SetString("Message", NewMessage);
                    ViewBag.Message = NewMessage;
                    return RedirectToAction("Index");
                }
                else
                {
                    System.Console.WriteLine("Playing with Dojodachi!");

                    int? EnergySession = HttpContext.Session.GetInt32("Energy");
                    int CastedEnergySession = (int)EnergySession;
                    CastedEnergySession -= 5;
                    HttpContext.Session.SetInt32("Energy", CastedEnergySession);
                    ViewBag.Energy = CastedEnergySession;

                    int? HappinessSession = HttpContext.Session.GetInt32("Happiness");
                    int CastedHappinessSession = (int)HappinessSession;
                    Random random = new Random();
                    int randomNumber = random.Next(5,11);
                    CastedHappinessSession += randomNumber;
                    HttpContext.Session.SetInt32("Happiness", CastedHappinessSession);
                    ViewBag.Happiness = CastedHappinessSession;

                    string NewMessage = $"You played with your Dojodachi! Happiness +{randomNumber}, Energy -5";
                    HttpContext.Session.SetString("Message", NewMessage);
                    ViewBag.Message = NewMessage;

                    return RedirectToAction("Index");
                }
            }
            else
            {
                System.Console.WriteLine("Not enough energy!");

                string NewMessage = "Not enough energy to play with your Dojodachi!";
                HttpContext.Session.SetString("Message", NewMessage);
                ViewBag.Message = NewMessage;

                return RedirectToAction("Index");
            }
        }

        [HttpGet("work")]
        public RedirectToActionResult Work()
        {
            if(HttpContext.Session.GetInt32("Energy") >= 5)
            {
                System.Console.WriteLine("Your Dojodachi is working hard!");

                int? EnergySession = HttpContext.Session.GetInt32("Energy");
                int CastedEnergySession = (int)EnergySession;
                CastedEnergySession -= 5;
                HttpContext.Session.SetInt32("Energy", CastedEnergySession);
                ViewBag.Energy = CastedEnergySession;

                int? MealsSession = HttpContext.Session.GetInt32("Meals");
                int CastedMealsSession = (int)MealsSession;
                Random random = new Random();
                int randomNumber = random.Next(5,11);
                CastedMealsSession += randomNumber;
                HttpContext.Session.SetInt32("Meals", CastedMealsSession);
                ViewBag.Meals = CastedMealsSession;

                string NewMessage = $"Your Dojodachi worked hard! +{randomNumber}, Energy -5";
                HttpContext.Session.SetString("Message", NewMessage);
                ViewBag.Message = NewMessage;

                return RedirectToAction("Index");
            }
            else
            {
                System.Console.WriteLine("Not enough energy!");

                string NewMessage = "Not enough energy to play with your Dojodachi!";
                HttpContext.Session.SetString("Message", NewMessage);
                ViewBag.Message = NewMessage;

                return RedirectToAction("Index");
            }
        }

        [HttpGet("sleep")]
        public RedirectToActionResult Sleep()
        {
            System.Console.WriteLine("Your Dojodachi is sleeping soundly!");

            int? EnergySession = HttpContext.Session.GetInt32("Energy");
            int CastedEnergySession = (int)EnergySession;
            CastedEnergySession += 15;
            HttpContext.Session.SetInt32("Energy", CastedEnergySession);
            ViewBag.Energy = CastedEnergySession;

            int? FullnessSession = HttpContext.Session.GetInt32("Fullness");
            int CastedFullnessSession = (int)FullnessSession;
            CastedFullnessSession -= 5;
            HttpContext.Session.SetInt32("Fullness", CastedFullnessSession);
            ViewBag.Meals = CastedFullnessSession;

            int? HappinessSession = HttpContext.Session.GetInt32("Happiness");
            int CastedHappinessSession = (int)HappinessSession;
            CastedHappinessSession -= 5;
            HttpContext.Session.SetInt32("Happiness", CastedHappinessSession);
            ViewBag.Meals = CastedHappinessSession;

            string NewMessage = $"Your Dojodachi slept well! +15 Energy, Fullness -5, Happiness -5";
            HttpContext.Session.SetString("Message", NewMessage);
            ViewBag.Message = NewMessage;

            return RedirectToAction("Index");
        }

        [HttpGet("restart")]
        public RedirectToActionResult Restart()
        {
            System.Console.WriteLine("Restarting Game!");
            HttpContext.Session.Clear();
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
