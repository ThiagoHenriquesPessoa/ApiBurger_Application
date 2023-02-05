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

        public int SaveBurger(Burger burger)
        {
            try
            {
                _sqlContext.Burger.Add(burger);
                _sqlContext.SaveChanges();
                return burger.Id_Burger;
            }
            catch
            {
                return 0;
            }
        }
    }
}