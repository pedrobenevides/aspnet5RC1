using Microsoft.AspNet.Mvc;

namespace CarWash.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
