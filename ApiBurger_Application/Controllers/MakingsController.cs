using Microsoft.AspNetCore.Mvc;

namespace ApiBurger_Application.Controllers
{
    public class MakingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
