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
                _sqlContext.Optional.Remove(id);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public List<Optional> GetAllOptional()
        {
            throw new NotImplementedException();
        }

        public Optional GetOptional(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveOptional(Optional optional)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateOptional(Optional optional)
        {
            throw new NotImplementedException();
        }
    }
}