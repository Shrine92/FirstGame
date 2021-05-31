using Microsoft.EntityFrameworkCore;

namespace FirstGame.Core.Data.Models
{
    public class DefaultContext: DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        public DbSet<Adventure> Adventures { get; set; }
    }
}
