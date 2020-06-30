using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wedding_Planner.Models;

namespace Wedding_Planner.Controllers
{
    public class WeddingController : Controller
    {
        private Context db;
        public WeddingController(Context context)
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

        public IActionResult Dashboard()
        {
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Wedding> listOfWeddings = db.Weddings
                .Include(wedding => wedding.Creator)
                .Include(user => user.Attendees)
                .OrderBy(wedding => wedding.Date)
                .ToList();

            // Wedding selectedWedding = db.Weddings
            //     .Include(wedding => wedding.Creator)
            //     .Include(wedding => wedding.Attendees)
            //         .ThenInclude(attend => attend.User)
            //     .FirstOrDefault(wedding => wedding.WeddingId == weddingId)

            return View("Dashboard", listOfWeddings);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index");
            }
            return View("New");
        }

        [HttpPost("create")]
        public IActionResult Create(Wedding newWedding)
        {
            if(ModelState.IsValid == false)
            {
                return View("New");
            }

            if (DateTime.Today > newWedding.Date)
            {
                ModelState.AddModelError("Date", "must be future date");
                return View("New");
            }

            newWedding.UserId = (int)currentid;
            db.Weddings.Add(newWedding);
            db.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpPost("/rsvp/{IsRSVPed}/{weddingId}/{userId}")]
        public IActionResult RSVP(bool IsRSVPed, int weddingId, int userId, Attend newAttend)
        {
            Attend existingRSVP = db.Attends
                .FirstOrDefault(attend => attend.WeddingId == weddingId
                && attend.UserId == userId);

            if (existingRSVP == null)
            {
                db.Attends.Add(newAttend);
                db.SaveChanges();
            }

            else if (existingRSVP != null)
            {
                existingRSVP.IsRSVPed = IsRSVPed;
                existingRSVP.UpdatedAt = DateTime.Now;
                db.Attends.Update(existingRSVP);
                db.SaveChanges();
            }
            return RedirectToAction ("Dashboard");
        }

        [HttpPost("/delete/{weddingId}")]
        public IActionResult Delete(int weddingId)
        {
            Wedding selectedWedding = db.Weddings
                .FirstOrDefault(wedding => wedding.WeddingId == weddingId);

            if (selectedWedding != null)
            {
                db.Weddings.Remove(selectedWedding);
                db.SaveChanges();
            }

            return RedirectToAction("Dashboard");
        }

        [HttpGet("/details/{weddingId}")]
        public IActionResult Details(int weddingId)
        {
            Wedding selectedWedding = db.Weddings
                .Include(wedding => wedding.Creator)
                .Include(wedding => wedding.Attendees)
                    .ThenInclude(attend => attend.User)
                .FirstOrDefault(wedding => wedding.WeddingId == weddingId);

            if (selectedWedding == null)
            {
                return RedirectToAction("Dashboard");
            }
            return View("Details", selectedWedding);
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
