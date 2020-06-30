using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bank_Account.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Bank_Account.Controllers
{
    public class AccountController : Controller
    {
        private Context db;
        public AccountController(Context context)
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

        [HttpGet("account")]
        public IActionResult Account()
        {
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Transaction> allTransactions = db.Transactions
                .Include(transaction => transaction.Creator)
                .Where(transaction => transaction.Creator.UserId == (int)currentid)
                .ToList();

            decimal rawCurrentBalance = db.Transactions
                .Sum(sum => sum.Amount);
            int currentBalance = (int)rawCurrentBalance;
            HttpContext.Session.SetInt32("CurrentBalance", currentBalance);

            System.Console.WriteLine(HttpContext.Session.GetInt32("CurrentBalance"));

            return View("Account", allTransactions);
        }

        [HttpPost("depositwithdraw")]
        public IActionResult DepositWithdraw(Transaction newTransaction)
        {
            if (ModelState.IsValid == false)
            {
                System.Console.WriteLine("=====Validation Error======");
                // send back to the page with the form so error messages are displayed
                return View("Account");
            }

            newTransaction.UserId = (int)currentid;
            db.Transactions.Add(newTransaction);
            db.SaveChanges();

            return RedirectToAction("Account");
        }
    }
}