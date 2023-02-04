using ApiBurger_Domain.Entities;

namespace ApiBurger_Repository.InterfaceRepositories
{
    public interface IBurgerRepository
    {
        Task<int> SaveBurger(Burger burger);
    }
}