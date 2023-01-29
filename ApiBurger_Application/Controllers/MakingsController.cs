using ApiBurger_Business.Business;
using ApiBurger_Business.InterfaceBusiness;
using ApiBurger_Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiBurger_Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MakingsController : Controller
    {
        private readonly IBreadBusiness _breadBusiness;

        public MakingsController(IBreadBusiness breadBusiness)
        {
            _breadBusiness = breadBusiness;
        }

        [HttpGet("json/List/Bread/")]
        public List<Bread> GetAllBread()
        {
            return _breadBusiness.GetAllBread();
        }

        [HttpPost("json/Save/Bread/")]
        public async Task<int> SaveBread([FromBody] Bread bread)
        {
            return await _breadBusiness.SaveBread(bread);
        }

        [HttpPost("json/Update/Bread/")]
        public async Task<int> UpdateBread(Bread bread)
        {
            return await _breadBusiness.UpdateBread(bread);
        }
    }
}
