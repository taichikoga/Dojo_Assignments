using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSharp_Exam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CSharp_Exam.Controllers
{
    public class CenterController : Controller
    {
        private Context db;
        public CenterController(Context context)
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

            List<Exercise> listOfExercises = db.Exercises
                .Include(exercise => exercise.Coordinator)
                .Include(user => user.Participants)
                .OrderBy(exercise => exercise.DateTime)
                .ToList();

            return View("Dashboard", listOfExercises);
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
        public IActionResult Create(Exercise newExercise)
        {
            if(ModelState.IsValid == false)
            {
                return View("New");
            }

            if (DateTime.Today > newExercise.DateTime)
            {
                ModelState.AddModelError("DateTime", "must be future date");
                return View("New");
            }

            newExercise.UserId = (int)currentid;
            db.Exercises.Add(newExercise);
            db.SaveChanges();

            return RedirectToAction("Details", new { exerciseId = newExercise.ExerciseId } );
        }

        [HttpPost("/rsvp/{IsParticipating}/{exerciseId}/{userId}")]
        public IActionResult RSVP(bool IsParticipating, int exerciseId, int userId, Participate newParticipate)
        {
            Participate existingRSVP = db.Participates
                .FirstOrDefault(participate => participate.ExerciseId == exerciseId
                && participate.UserId == userId);

            // List of activities that the current user is currently rsvp'ed to
            // List<Exercise> listofParticipatingExercises = db.Exercises
            //     .Include(exercise => exercise.Participants)
            //         .ThenInclude(user => user.User)
            //     .Where(u => u.Participants.
            //     );

            if (existingRSVP == null)
            {
                db.Participates.Add(newParticipate);
                db.SaveChanges();
            }

            else if (existingRSVP != null)
            {
                existingRSVP.IsParticipating = IsParticipating;
                existingRSVP.UpdatedAt = DateTime.Now;
                db.Participates.Update(existingRSVP);
                db.SaveChanges();
            }
            return RedirectToAction ("Dashboard");
        }

        [HttpPost("/delete/{exerciseId}")]
        public IActionResult Delete(int exerciseId)
        {
            Exercise selectedExercise = db.Exercises
                .FirstOrDefault(exercise => exercise.ExerciseId == exerciseId);

            if (selectedExercise != null)
            {
                db.Exercises.Remove(selectedExercise);
                db.SaveChanges();
            }

            return RedirectToAction("Dashboard");
        }

        [HttpGet("/details/{exerciseId}")]
        public IActionResult Details(int exerciseId)
        {
            Exercise selectedExercise = db.Exercises
                .Include(exercise => exercise.Coordinator)
                .Include(exercise => exercise.Participants)
                    .ThenInclude(participate => participate.User)
                .FirstOrDefault(exercise => exercise.ExerciseId == exerciseId);

            if (selectedExercise == null)
            {
                return RedirectToAction("Dashboard");
            }
            return View("Details", selectedExercise);
        }
    }
}