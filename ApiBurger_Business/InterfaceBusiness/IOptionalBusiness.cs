using ApiBurger_Domain.Entities;

namespace ApiBurger_Business.InterfaceBusiness
{
    public interface IOptionalBusiness
    {
        List<Optional> GetAllOptional();
        Optional GetOptional(int id);
        Task<int> SaveOptional(Optional optional);
        Task<int> UpdateOptional(Optional optional);
        Task<int> DeleteOptional(int id);
    }
}