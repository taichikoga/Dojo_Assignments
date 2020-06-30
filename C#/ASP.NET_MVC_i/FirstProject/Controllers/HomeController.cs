using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        // [Route("")]
        [HttpGet("")]
        public ViewResult Index()
        {
            // looks in Views/Home/Index.cshtml
            // then Views/Shared/Index.cshtml
            return View();
        }

        // localhost:5000/hello
        // [Route("hello")]
        [HttpGet("hello")]
        public string Hello()
        {
            return "Hi Again!";
        }

        //localhost:5000/user/???
        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            return $"Hello {username} from {location}";
        }

        // [HttpPost]
        // [Route("submission")]
        // // POST requests to "localhost:5000/submission" go here
        // // (Don't worry about form submissions for now, we will get to those later!)
        // public string FormSubmission(string formInput)
        // {
        //     // Method body
        // }
    }
}