using ApiBurger_Business.InterfaceBusiness;
using ApiBurger_Domain.Entities;
using ApiBurger_Repository.Repositories;
using System.Threading;

namespace ApiBurger_Business.Business
{
    public class BreadBusiness : IBreadBusiness
    {
        private readonly BaseRepository<Bread> _breadRepository;

        public BreadBusiness(BaseRepository<Bread> breadRepository)
        {
            _breadRepository = breadRepository;
        }

        public List<Bread> GetAllBread()
        {
            return _breadRepository.GetAll();
        }

        public async Task<int> SaveBread(Bread bread)
        {
            return await _breadRepository.Save(bread);
        }

        public async Task<int> UpdateBread(Bread bread)
        {
            return await _breadRepository.Update(bread);
        }
    }
}