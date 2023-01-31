using ApiBurger_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace ApiBurger_Infraestructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Bread> Bread { get; set; }
        public DbSet<Meat> Meat { get; set; }
        public DbSet<Optional> Optional { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Burger> Burger { get; set; }
    }
}