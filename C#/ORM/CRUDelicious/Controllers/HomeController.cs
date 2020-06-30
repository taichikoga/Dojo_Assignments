using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
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
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            return View("Index", AllDishes);
        }

        [HttpGet("new")]
        public ViewResult New()
        {
            return View("New");
        }

        [HttpPost("add")]
        public IActionResult Add(Dish newDish)
        {
            if (ModelState.IsValid == false)
            {
                return View("New");
            }
            else
            {
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
                // , new { id = newDish.DishId });
            }
        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            Dish selectedDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == id);

            if (selectedDish == null)
            {
                return RedirectToAction("Index");
            }

            return View("Details", selectedDish);
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            Dish selectedDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == id);

            if (selectedDish == null)
            {
                return RedirectToAction("Index");
            }

            return View("Edit", selectedDish);
        }

        [HttpPost("update/{id}")]
        public IActionResult Update(Dish selectedDish, int id)
        {
            if (ModelState.IsValid == false)
            {
                selectedDish.DishId = id;
                return View("Edit", selectedDish);
            }

            Dish EditedDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == id);
            if (EditedDish == null)
            {
                return RedirectToAction("Index");
            }

            EditedDish.Name = selectedDish.Name;
            EditedDish.Chef = selectedDish.Chef;
            EditedDish.Tastiness = selectedDish.Tastiness;
            EditedDish.Calories = selectedDish.Calories;
            EditedDish.Description = selectedDish.Description;

            dbContext.Dishes.Update(EditedDish);
            dbContext.SaveChanges();

            return RedirectToAction("Details", new { id = EditedDish.DishId });
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Dish selectedDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == id);

            if(selectedDish != null)
            {
                dbContext.Dishes.Remove(selectedDish);
                dbContext.SaveChanges();
            }

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
}
