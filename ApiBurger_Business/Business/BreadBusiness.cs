using ApiBurger_Business.InterfaceBusiness;
using ApiBurger_Domain.Entities;
using ApiBurger_Repository.InterfaceRepositories;

namespace ApiBurger_Business.Business
{
    public class BreadBusiness : IBreadBusiness
    {
        private readonly IBreadRepository _breadRepository;

        public BreadBusiness(IBreadRepository breadRepository)
        {
            _breadRepository = breadRepository;
        }

        public List<Bread> GetAllBread()
        {
            return _breadRepository.GetAllBread();
        }

        public Bread GetBread(int id)
        {
            return _breadRepository.GetBread(id);
        }

        public async Task<int> SaveBread(Bread bread)
        {
            return await _breadRepository.SaveBread(bread);
        }

        public async Task<int> UpdateBread(Bread bread)
        {
            return await _breadRepository.UpdateBread(bread);
        }

        public async Task<int> DeleteBread(int id)
        {
            return await _breadRepository.DeleteBread(id);
        }
    }
}