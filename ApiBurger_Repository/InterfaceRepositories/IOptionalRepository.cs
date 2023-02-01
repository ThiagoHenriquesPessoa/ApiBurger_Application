using ApiBurger_Domain.Entities;

namespace ApiBurger_Repository.InterfaceRepositories
{
    public interface IOptionalRepository
    {
        List<Optional> GetAllOptional();
        Optional GetOptional(int id);
        Task<int> SaveOptional(Optional optional);
        Task<int> UpdateOptional(Optional optional);
        Task<int> DeleteOptional(int id);
    }
}