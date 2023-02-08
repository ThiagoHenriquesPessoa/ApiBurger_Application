using ApiBurger_Domain.Entities;
using ApiBurger_Infraestructure.Data;
using ApiBurger_Repository.InterfaceRepositories;

namespace ApiBurger_Repository.Repositories
{
    public class BreadRepository : IBreadRepository
    {
        private readonly SqlContext _sqlContext;

        public BreadRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public List<Bread> GetAllBread()
        {
            return _sqlContext.Set<Bread>().ToList();
        }
        public Bread GetBread(int id)
        {
            return _sqlContext.Bread.First(x => x.Id_Bread == id);
        }

        public async Task<int> SaveBread(Bread bread)
        {
            try
            {
                await _sqlContext.AddAsync(bread);
                await _sqlContext.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> UpdateBread(Bread bread)
        {
            try
            {
                _sqlContext.Update(bread);
                await _sqlContext.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> DeleteBread(int id)
        {
            try
            {
                var bread = GetBread(id);
                _sqlContext.Remove(bread);
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