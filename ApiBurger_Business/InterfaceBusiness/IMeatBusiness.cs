using ApiBurger_Domain.Entities;

namespace ApiBurger_Business.InterfaceBusiness
{
    public interface IMeatBusiness
    {
        List<Meat> GetAllMeat();
        Meat GetMeat(int id);
        Task<int> SaveMeat(Meat meat);
        Task<int> UpdateMeat(Meat meat);
        Task<int> DeleteMeat(int id);
    }
}