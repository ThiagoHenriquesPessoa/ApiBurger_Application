using ApiBurger_Business.InterfaceBusiness;
using ApiBurger_Domain.Entities;
using ApiBurger_Repository.InterfaceRepositories;
using Microsoft.Extensions.Options;

namespace ApiBurger_Business.Business
{
    public class BurgerBusiness : IBurgerBusiness
    {
        private readonly IBurgerRepository _burgerRepository;
        private readonly IOptionaisRepository _optionaisRepository;

        public BurgerBusiness(IBurgerRepository burgerRepository, IOptionaisRepository optionaisRepository)
        {
            _burgerRepository = burgerRepository;
            _optionaisRepository = optionaisRepository;
        }

        public void SaveBurger(Burger burger)
        {
            int id = _burgerRepository.SaveBurger(burger);
            if (id > 0)
            {
                foreach(var optional in  burger.Optional) 
                {
                    var optionais = new Optionais
                    {
                        Id_Burger = burger.Id_Burger,
                        Id_Optional = optional.Id_Optional
                    };
                _optionaisRepository.SaveOptionais(optionais);
                }
            }
        }
    }
}