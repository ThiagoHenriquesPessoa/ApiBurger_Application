using ApiBurger_Domain.Entities;
using ApiBurger_Infraestructure.Data;
using ApiBurger_Repository.InterfaceRepositories;

namespace ApiBurger_Repository.Repositories
{
    public class OptionalRepository : IOptionalRepository
    {
        private readonly SqlContext _sqlContext;

        public OptionalRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public async Task<int> DeleteOptional(int id)
        {
            try
            {
                var optional = GetOptional(id);
                _sqlContext.Optional.Remove(optional);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public List<Optional> GetAllOptional()
        {
            return _sqlContext.Set<Optional>().ToList();
        }

        public Optional GetOptional(int id)
        {
            return _sqlContext.Optional.First(x => x.Id == id);
        }

        public async Task<int> SaveOptional(Optional optional)
        {
            try
            {
                await _sqlContext.Optional.AddAsync(optional);
                await _sqlContext.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> UpdateOptional(Optional optional)
        {
            try
            {
                _sqlContext.Optional.Update(optional);
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