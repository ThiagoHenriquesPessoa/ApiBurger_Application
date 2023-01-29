using ApiBurger_Domain.Entities;

namespace ApiBurger_Repository.InterfaceRepositories
{
    public interface IBreadRepository
    {
        List<Bread> GetAllBread();
    }
}