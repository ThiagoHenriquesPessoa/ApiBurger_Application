using Microsoft.AspNetCore.Mvc;

namespace ApiBurger_Application.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
