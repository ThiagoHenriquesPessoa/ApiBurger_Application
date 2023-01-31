using ApiBurger_Business.InterfaceBusiness;
using ApiBurger_Domain.Entities;
using ApiBurger_Repository.InterfaceRepositories;

namespace ApiBurger_Business.Business
{
    public class MeatBusiness : IMeatBusiness
    {
        private readonly IMeatRepository _meatRepository;

        public MeatBusiness(IMeatRepository meatRepository)
        {
            _meatRepository = meatRepository;
        }

        public Task<int> DeleteMeat(int id)
        {
            return _meatRepository.DeleteMeat(id);
        }

        public List<Meat> GetAllMeat()
        {
            return _meatRepository.GetAllMeat();
        }

        public Meat GetMeat(int id)
        {
            return _meatRepository.GetMeat(id);
        }

        public Task<int> SaveMeat(Meat meat)
        {
            return _meatRepository.SaveMeat(meat);
        }

        public Task<int> UpdateMeat(Meat meat)
        {
            return _meatRepository.UpdateMeat(meat);
        }
    }
}