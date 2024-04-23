using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Incubator> Incubatoare { get;set;}
        public DbSet<LogIncubator> LogIncubatoare { get;set;}
    }
}