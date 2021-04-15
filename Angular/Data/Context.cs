using Angular.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Angular.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }
        public DbSet<Computer> computer { get; set; }
    }
}
