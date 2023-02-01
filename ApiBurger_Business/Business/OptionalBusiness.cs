using ApiBurger_Business.InterfaceBusiness;
using ApiBurger_Domain.Entities;
using ApiBurger_Repository.InterfaceRepositories;

namespace ApiBurger_Business.Business
{
    public class OptionalBusiness : IOptionalBusiness
    {
        private readonly IOptionalRepository _optionalRepository;

        public OptionalBusiness(IOptionalRepository optionalRepository)
        {
            _optionalRepository = optionalRepository;
        }

        public Task<int> DeleteOptional(int id)
        {
            return _optionalRepository.DeleteOptional(id);
        }

        public List<Optional> GetAllOptional()
        {
           return _optionalRepository.GetAllOptional();
        }

        public Optional GetOptional(int id)
        {
            return _optionalRepository.GetOptional(id);
        }

        public Task<int> SaveOptional(Optional optional)
        {
            return _optionalRepository.SaveOptional(optional);
        }

        public Task<int> UpdateOptional(Optional optional)
        {
            return _optionalRepository.UpdateOptional(optional);
        }
    }
}