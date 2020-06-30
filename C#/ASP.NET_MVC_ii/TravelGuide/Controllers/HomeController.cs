using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TravelGuide.Models;

namespace TravelGuide.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] // attribute
        [Route("")] // attribute: the url which when visited will trigger the method immediately below it
        public ViewResult Index()
        {
            ViewBag.Introduction = "My name is Falconhoof and I will be your guide on your quest.";
            ViewBag.YearCreated = 2020;
            ViewBag.ImgUrl = "https://ih1.redbubble.net/image.230236822.2041/raf,750x1000,075,t,101010:01c5ca27c6.u3.jpg";
            return View("Index");

            // if the method name is the same as the .cshtml file, no argument needs to be passed to View
            // return View();
        }

        [HttpPost("/guide")]
        public ViewResult Guide(Traveler newTraveler)
        {
            /* 
                One approach to pass both a traveler as the 
                ViewModel and a list of travel destinations
                in the ViewBag.

                This way the Giude.cshtml page needs
                @model Traveler
            */
            // ViewBag.travelDestinations = new List<string>()
            // {
            //     "Longyearbyen", "Solovetsky Islands", "Socotra", "Bhutan", "Hell"
            // };
            // return View("Guide1", newTraveler);

            /* 
                Second approach (more robust) is to create a new model that contains all the info you need it to contain
            */
            Guide GuideViewModel = new Guide()
            {
                Traveler = newTraveler
            };

            return View("Guide2", GuideViewModel);
        }

        [HttpGet("/test")]
        public ViewResult Test()
        {
            return View("Test");
        }

        //                {routeParamName}
        [HttpGet("/travel/{destination}")]
        public ViewResult Destination(string destination)
        {
            Destination chosenDestination = TravelDestinations.GetDestination(destination);
            return View("Destination", chosenDestination);
        }

        [HttpGet("{path}")]
        public RedirectToActionResult Unknown(string path)
        {
            // redirect to Index method, methods in controllers are aka "Action"
            return RedirectToAction("Index");
        }

    }
}