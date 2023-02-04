using ApiBurger_Domain.Entities;
using ApiBurger_Infraestructure.Data;
using ApiBurger_Repository.InterfaceRepositories;

namespace ApiBurger_Repository.Repositories
{
    public class BurgerRepository : IBurgerRepository
    {
        private readonly SqlContext _sqlContext;

        public BurgerRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public async Task<int> SaveBurger(Burger burger)
        {
            try
            {
                await _sqlContext.Burger.AddAsync(burger);
                await _sqlContext.SaveChangesAsync();
                return burger.Id_Burger;
            }
            catch
            {
                return 0;
            }
        }
    }
}