using ApiBurger_Domain.Entities;

namespace ApiBurger_Repository.InterfaceRepositories
{
    public interface IBurgerRepository
    {
        int SaveBurger(Burger burger);
    }
}