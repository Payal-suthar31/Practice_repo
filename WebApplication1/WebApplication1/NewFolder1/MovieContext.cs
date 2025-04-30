using Microsoft.EntityFrameworkCore;
using WebApplication1.entity;

namespace WebApplication1.NewFolder1
{
    public class MovieContext(DbContextOptions<MovieContext> options) : DbContext(options)
    {
        public DbSet<movie> Movies { get; set; }
        public DbSet<general> general { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<general>().HasData(
               new general { Id = 1, Name = "action" },
               new general { Id = 2, Name = "Sci-fi" },
               new general { Id = 3, Name = "fantasy" },
               new general { Id = 4, Name = "horror" },
               new general { Id = 5, Name = "romance" }
                );

            modelBuilder.Entity<movie>().HasData(
                new movie { Id = 1, Name = "inception", generalid = 1, Price = 12, ReleaseDa = new DateOnly(2003, 2, 3) },
                new movie { Id = 2, Name = "dark host", generalid = 2, Price = 15, ReleaseDa = new DateOnly(2006, 3, 7) },
                new movie { Id = 3, Name = "the matrix", generalid = 3, Price = 16, ReleaseDa = new DateOnly(2008, 8, 5) },
                new movie { Id = 4, Name = "the lord", generalid = 4, Price = 18, ReleaseDa = new DateOnly(2009, 3, 8) },
                new movie { Id= 5, Name = "god", generalid = 5, Price = 20, ReleaseDa = new DateOnly(2004, 6, 9) }
                );
        }

    }
}
