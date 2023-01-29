using ApiBurger_Business.Business;
using ApiBurger_Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiBurger_Application.Controllers
{
    [ApiController]
    [Route("Making")]
    public class MakingsController : Controller
    {
        private readonly BreadBusiness _breadBusiness;

        public MakingsController(BreadBusiness breadBusiness)
        {
            _breadBusiness = breadBusiness;
        }

        [HttpGet("json/List/Bread/")]
        public List<Bread> GetAllBread()
        {
            return _breadBusiness.GetAllBread();
        }
    }
}
