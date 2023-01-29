using ApiBurger_Business.InterfaceBusiness;
using ApiBurger_Domain.Entities;
using ApiBurger_Repository.Repositories;

namespace ApiBurger_Business.Business
{
    public class BreadBusiness : IBreadBusiness
    {
        private readonly BreadRepository _breadRepository;

        public BreadBusiness(BreadRepository breadRepository)
        {
            _breadRepository = breadRepository;
        }

        public List<Bread> GetAllBread()
        {
            return _breadRepository.GetAllBread();
        }
    }
}