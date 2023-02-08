using ApiBurger_Domain.Entities;
using ApiBurger_Infraestructure.Data;
using ApiBurger_Repository.InterfaceRepositories;

namespace ApiBurger_Repository.Repositories
{
    public class MeatRepository : IMeatRepository
    {
        private readonly SqlContext _sqlContext;

        public MeatRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public List<Meat> GetAllMeat()
        {
            return _sqlContext.Set<Meat>().ToList();
        }

        public Meat GetMeat(int id)
        {
            return _sqlContext.Meat.First(x => x.Id_Meat == id);
        }
        public async Task<int> SaveMeat(Meat meat)
        {
            try
            {
                await _sqlContext.AddAsync(meat);
                await _sqlContext.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public async Task<int> UpdateMeat(Meat meat)
        {
            try
            {
                _sqlContext.Update(meat);
                await _sqlContext.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> DeleteMeat(int id)
        {
            try
            {
                var meat = GetMeat(id);
                _sqlContext.Remove(meat);
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