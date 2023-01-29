using ApiBurger_Domain.Entities;
using ApiBurger_Infraestructure.Data;
using ApiBurger_Repository.InterfaceRepositories;
using static System.Net.WebRequestMethods;

namespace ApiBurger_Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly SqlContext _sqlContext;

        public BaseRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public List<T> GetAll()
        {
            return _sqlContext.Set<T>().ToList();
        }

        public async Task<int> Save(T generico)
        {
            try
            {
                await _sqlContext.AddAsync(generico);
                await _sqlContext.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> Update(T generico)
        {
            try
            {
                _sqlContext.Update(generico);
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