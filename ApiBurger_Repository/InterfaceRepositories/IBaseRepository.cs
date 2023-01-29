using ApiBurger_Domain.Entities;

namespace ApiBurger_Repository.InterfaceRepositories
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        Task<int> Save(T generico);
        Task<int> Update(T generico);
    }
}