using Microsoft.AspNetCore.Mvc;

namespace GamingSlot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
