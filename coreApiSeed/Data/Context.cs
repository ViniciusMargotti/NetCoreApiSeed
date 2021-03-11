using Microsoft.EntityFrameworkCore;

namespace coreApiSeed.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
        }

        public DbSet<Models.Cliente> Cliente { get; set; }
    }
}