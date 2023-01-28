using Microsoft.AspNetCore.Mvc;

namespace ApiBurger_Application.Controllers
{
    public class IngredientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
