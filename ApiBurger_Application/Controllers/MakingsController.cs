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
        private readonly IMeatBusiness _meatBusiness;

        public MakingsController(IBreadBusiness breadBusiness, IMeatBusiness meatBusiness)
        {
            _breadBusiness = breadBusiness;
            _meatBusiness = meatBusiness;
        }

        [HttpGet("json/List/Bread/")]
        public List<Bread> GetAllBread()
        {
            return _breadBusiness.GetAllBread();
        }

        [HttpGet("json/List/Meat/")]
        public List<Meat> GetAllMeat()
        {
            return _meatBusiness.GetAllMeat();
        }

        [HttpGet("json/Bread/{id:int}")]
        public Bread GetBread(int id)
        {
            return _breadBusiness.GetBread(id);
        }

        [HttpGet("json/Meat/{id:int}")]
        public Meat GetMeat(int id)
        {
            return _meatBusiness.GetMeat(id);
        }

        [HttpPost("json/Save/Bread/")]
        public async Task<int> SaveBread([FromBody] Bread bread)
        {
            return await _breadBusiness.SaveBread(bread);
        }

        [HttpPost("json/Save/Meat/")]
        public async Task<int> SaveMeat([FromBody] Meat meat)
        {
            return await _meatBusiness.SaveMeat(meat);
        }

        [HttpPost("json/Update/Bread/")]
        public async Task<int> UpdateBread([FromBody] Bread bread)
        {
            return await _breadBusiness.UpdateBread(bread);
        }

        [HttpPost("json/Update/Meat/")]
        public async Task<int> UpdateMeat([FromBody] Meat meat)
        {
            return await _meatBusiness.UpdateMeat(meat);
        }

        [HttpPost("json/Delete/Bread/")]
        public async Task<int> DeleteBread(int id)
        {
            return await _breadBusiness.DeleteBread(id);
        }

        [HttpPost("json/Delete/Meat/")]
        public async Task<int> DeleteMeat(int id)
        {
            return await _meatBusiness.DeleteMeat(id);
        }
    }
}