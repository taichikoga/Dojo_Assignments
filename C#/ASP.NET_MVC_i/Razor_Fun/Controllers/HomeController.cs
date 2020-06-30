using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Razor_Fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        // [Route("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}