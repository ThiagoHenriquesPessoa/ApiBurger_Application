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

        public Burger GetBurger(int id)
        {
            return _sqlContext.Burger.First(x => x.Id_Burger == id);
        }

        public List<Burger> GetAllBurger()
        {
            return _sqlContext.Set<Burger>().ToList();
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

        public async Task<int> DeleteBurger(int id)
        {
            try
            {
                var burger = GetBurger(id);
                _sqlContext.Burger.Remove(burger);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> UpdateOptional(Burger burger)
        {
            try
            {
                _sqlContext.Burger.Update(burger);
                await _sqlContext.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}