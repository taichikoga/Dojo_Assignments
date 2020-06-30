using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using The_Wall.Models;

namespace The_Wall.Controllers
{
    public class WallController : Controller
    {
        private Context db;
        public WallController(Context context)
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

            List<Message> listOfMessages = db.Messages
                .Include(user => user.Creator)
                .Include(comment => comment.CommentsOnMessage)
                .OrderByDescending(message => message.CreatedAt)
                .ToList();

            return View("Dashboard", listOfMessages);
        }

        [HttpPost("create_post")]
        public IActionResult Create_Post(Message newMessage)
        {
            if(ModelState.IsValid == false)
            {
                return View("Dashboard");
            }

            newMessage.UserId = (int)currentid;
            db.Messages.Add(newMessage);
            db.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpPost("create_comment")]
        public IActionResult Create_Comment(Comment newComment)
        {
            if(ModelState.IsValid == false)
            {
                return View("Dashboard");
            }

            newComment.UserId = (int)currentid;
            db.Comments.Add(newComment);
            db.SaveChanges();

            return RedirectToAction("Dashboard");
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
