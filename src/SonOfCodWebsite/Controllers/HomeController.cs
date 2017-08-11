using Microsoft.AspNetCore.Mvc;

namespace SonOfCodWebsite.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
