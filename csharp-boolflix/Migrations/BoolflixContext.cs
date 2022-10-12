using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Migrations
{
    public class BoolflixContext : DbContext 
    {
        public DbSet<Film>Films { get; set; }
        public DbSet<TvSerie> TvSerie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=boolflix-db;Integrated Security=True");
        }
    }
}
