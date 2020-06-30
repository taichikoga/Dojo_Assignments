using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bank_Account.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Bank_Account.Controllers
{
    public class HomeController : Controller
    {
        private Context db;
        public HomeController(Context context)
        {
            db = context;
        }

        private int? currentid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return currentid != null;
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                }
            }

            if (ModelState.IsValid == false)
            {
                return View("Index");
            }

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("FullName", newUser.FullName());
            return RedirectToAction("Account", "Account");
        }

        [HttpGet("loginpage")]
        public IActionResult LoginPage()
        {
            return View("Login");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser newLoginUser)
        {
            if (ModelState.IsValid == false)
            {
                System.Console.WriteLine("MODEL STATE IS INVALID RETURNING TO LOGIN PAGE");
                return View("Login");
            }

            User dbUser = db.Users.FirstOrDefault(user => user.Email == newLoginUser.LoginEmail);

            if (dbUser == null)
            {
                ModelState.AddModelError("LoginEmail", "Invalid Email or Password");
                return View("Index");
            }

            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult pwComparisonResult = hasher.VerifyHashedPassword(newLoginUser, dbUser.Password, newLoginUser.LoginPassword);

            // verification failed
            if (pwComparisonResult == 0)
            {
                ModelState.AddModelError("LoginEmail", "Invalid Email or Password");
                return View("Index");
            }

            //vertication successful
            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            HttpContext.Session.SetString("FullName", dbUser.FullName());
            return RedirectToAction("Account", "Account");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            // int? LoggedinUserId = HttpContext.Session.GetInt32("UserId");
            // int CastedLoggedinUserId = (int)LoggedinUserId;
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index");
            }
            return View("Success");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
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
}
