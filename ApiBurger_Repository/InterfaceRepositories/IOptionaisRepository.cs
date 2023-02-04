using ApiBurger_Domain.Entities;

namespace ApiBurger_Repository.InterfaceRepositories
{
    public interface IOptionaisRepository
    {
        Task<int> SaveOptionais(Optionais optionais);
    }
}