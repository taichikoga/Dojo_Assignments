using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products_and_Categories.Models;

namespace Products_and_Categories.Controllers
{
    public class HomeController : Controller
    {
        private Context db;
        public HomeController(Context context)
        {
            db = context;
        }

        [HttpGet("products")]
        public IActionResult Products()
        {
            List<Product> allProducts = db.Products
            // .Where(product => product.)
                .ToList();
            return View("Products", allProducts);
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            List<Category> allCategories = db.Categories
                .ToList();
            return View("Categories", allCategories);
        }

        [HttpGet("products/{productId}")]
        public IActionResult ProductDetail(int productId)
        {
            var selectedProduct = db.Products
                .Include(product => product.CategoryOfProduct)
                .ThenInclude(cp => cp.Category)
                .FirstOrDefault(product => product.ProductId == productId);

            ViewBag.unassignedCategory = db.Categories
                .Include(a => a.ProductInCategory)
                .ThenInclude(p => p.Product)
                .Where(c => 
                    c.ProductInCategory.FirstOrDefault(
                        f => f.ProductId == productId) == null
                );

            return View("OneProduct", selectedProduct);
        }

        [HttpGet("categories/{categoryId}")]
        public IActionResult CategoryDetail(int categoryId)
        {
            var selectedCategory = db.Categories
                .Include(category => category.ProductInCategory)
                .ThenInclude(cp => cp.Product)
                .FirstOrDefault(category => category.CategoryId == categoryId);

            ViewBag.unassignedProduct = db.Products
                .Include(a => a.CategoryOfProduct)
                .ThenInclude(p => p.Category)
                .Where(c => 
                    c.CategoryOfProduct.FirstOrDefault(
                        f => f.CategoryId == categoryId) == null
                );

            return View("OneCategory", selectedCategory);
        }


        [HttpPost("newproduct")]
        public IActionResult NewProduct(Product newProduct)
        {
            if (ModelState.IsValid == false)
            {
                return View("Products");
            }

            db.Products.Add(newProduct);
            db.SaveChanges();

            return RedirectToAction("Products");
        }

        [HttpPost("newcategory")]
        public IActionResult NewCategory(Category NewCategory)
        {
            if (ModelState.IsValid == false)
            {
                return View("Categories");
            }

            db.Categories.Add(NewCategory);
            db.SaveChanges();

            return RedirectToAction("Categories");
        }

        [HttpPost("addcategorytoproduct")]
        public IActionResult AddCategoryToProduct(Association newAssociation)
        {
            db.Associations.Add(newAssociation);
            db.SaveChanges();
            return RedirectToAction("Products");
        }

        [HttpPost("addproducttocategory")]
        public IActionResult AddProductToCategory(Association newAssociation)
        {
            db.Associations.Add(newAssociation);
            db.SaveChanges();
            return RedirectToAction("Categories");
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
