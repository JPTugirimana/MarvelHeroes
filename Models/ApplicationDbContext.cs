using Microsoft.EntityFrameworkCore;

namespace MarvelHeroes.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }

        public DbSet<Hero> Heroes { get; set; }
    }
}
