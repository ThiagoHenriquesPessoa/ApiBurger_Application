using ApiBurger_Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiBurger_Infraestructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Bread> Cliente { get; set; }
    }
}