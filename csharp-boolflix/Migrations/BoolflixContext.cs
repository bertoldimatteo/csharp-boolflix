using csharp_boolflix.Migrations;
using csharp_boolflix.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Migrations
{
    public class BoolflixContext : DbContext 
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<TvSerie> TvSeries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=boolflix-db;Integrated Security=True");
        }
    }
}

