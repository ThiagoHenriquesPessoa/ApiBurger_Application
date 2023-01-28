using Microsoft.AspNetCore.Mvc;

namespace ApiBurger_Application.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
