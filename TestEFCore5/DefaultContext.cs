using Microsoft.EntityFrameworkCore;

namespace TestEFCore5
{
    public class DefaultContext: DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        public DbSet<Droid> Droids { get; set; }
    }
}
