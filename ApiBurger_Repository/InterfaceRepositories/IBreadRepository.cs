using ApiBurger_Domain.Entities;

namespace ApiBurger_Repository.InterfaceRepositories
{
    public interface IBreadRepository
    {
        List<Bread> GetAllBread();
        Bread GetBread(int id);
        Task<int> SaveBread(Bread bread);
        Task<int> UpdateBread(Bread bread);
        Task<int> DeleteBread(int id);
    }
}