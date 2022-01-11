using Microsoft.EntityFrameworkCore;

namespace Abar.Models
{
    public class Context_Pessoa : DbContext
    {
        public Context_Pessoa(DbContextOptions<Context_Pessoa> options) : base(options)
        {
        }
       public DbSet<Pessoa> ? Pessoa { get; set; }
       public DbSet<Login>? Login { get; set; }
    }
}
