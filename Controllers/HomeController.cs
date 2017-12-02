using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstAsp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGetAttribute]
        [Route("projects")]
        public IActionResult Projects()
        {
            return View();
        }

        [HttpGetAttribute]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}