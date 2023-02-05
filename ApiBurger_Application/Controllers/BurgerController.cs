using ApiBurger_Business.InterfaceBusiness;
using ApiBurger_Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiBurger_Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BurgerController : Controller
    {
        private readonly IBurgerBusiness _burgerBusiness;

        public BurgerController(IBurgerBusiness burgerBusiness)
        {
            _burgerBusiness = burgerBusiness;
        }

        [HttpGet("json/Save/Burger/")]
        public void SaveBurger(Burger burger)
        {
            _burgerBusiness.SaveBurger(burger);
        }
    }
}
