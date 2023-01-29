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
    }
}