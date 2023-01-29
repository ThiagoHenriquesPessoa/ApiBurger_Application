using ApiBurger_Domain.Entities;

namespace ApiBurger_Business.InterfaceBusiness
{
    public interface IBreadBusiness
    {
        List<Bread> GetAllBread();
        Task<int> SaveBread(Bread bread);

        Task<int> UpdateBread(Bread bread);
    }
}