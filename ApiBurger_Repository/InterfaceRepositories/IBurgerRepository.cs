using ApiBurger_Domain.Entities;

namespace ApiBurger_Repository.InterfaceRepositories
{
    public interface IBurgerRepository
    {
        Burger GetBurger(int id);
        List<Burger> GetAllBurger();        
        int SaveBurger(Burger burger);
        Task<int> DeleteBurger(int id);
        Task<int> UpdateBurger(Burger burger);
    }
}