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
    public class DishController : Controller
    {
        private Chefs_n_DishesContext db;

        public DishController(Chefs_n_DishesContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            List<Dish> allDishesList = db.Dishes
            .Include(dish => dish.Chef)
            .OrderByDescending(date => date.CreatedAt)
            .ToList();
            return View("All", allDishesList);
        }

        [HttpGet("newdishpage")]
        public IActionResult NewDishPage()
        {
            ViewBag.currentChefs = db.Users;
            return View("NewDish");
        }

        [HttpPost("AddNewDish")]
        public IActionResult AddNewDish(Dish newDish)
        {
            System.Console.WriteLine("TESTING CODE INSIDE PART 1 !!!!!!!!!!!!");
            if (ModelState.IsValid == false)
            {
                System.Console.WriteLine("TESTING CODE INSIDE PART 2 !!!!!!!!!!!!");
                return View("NewDish");
            }

            db.Dishes.Add(newDish);
            db.SaveChanges();

            System.Console.WriteLine("TESTING CODE INSIDE PART 3 !!!!!!!!!!!!");
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View("All");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("All", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}