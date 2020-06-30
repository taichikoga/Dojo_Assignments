using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_ii
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("index");
        }

        [HttpGet]
        [Route("/projects")]
        public ViewResult Projects()
        {
            return View("projects");
        }

        [HttpGet]
        [Route("/contact")]
        public ViewResult Contact()
        {
            return View("contact");
        }
    }
}