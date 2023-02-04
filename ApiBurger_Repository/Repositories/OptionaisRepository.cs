using ApiBurger_Domain.Entities;
using ApiBurger_Infraestructure.Data;
using ApiBurger_Repository.InterfaceRepositories;

namespace ApiBurger_Repository.Repositories
{
    public class OptionaisRepository : IOptionaisRepository
    {
        private readonly SqlContext _sqlContext;

        public OptionaisRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }
        public async Task<int> SaveOptionais(Optionais optionais)
        {
            try
            {
                await _sqlContext.Optionais.AddAsync(optionais);
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