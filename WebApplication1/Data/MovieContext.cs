
using Microsoft.EntityFrameworkCore;
using WebApplication1.entity;
using WebApplication1.Entity;

namespace WebApplication1.Data;



public class MovieContext(DbContextOptions<MovieContext> options) : DbContext(options)
{

    public DbSet<Movie> Movies { get; set; }

    public DbSet<Genre> Genre { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)

    {

        modelBuilder.Entity<Genre>().HasData(

           new Genre { Id = 1, Name = "action" },

           new Genre { Id = 2, Name = "Sci-fi" },

           new Genre { Id = 3, Name = "fantasy" },

           new Genre { Id = 4, Name = "horror" },

           new Genre { Id = 5, Name = "romance" }
        );
        modelBuilder.Entity<Movie>().HasData(

            new Movie { Id = 1, Name = "inception", General_Id = 1, Price = 12, ReleaseDate = new DateOnly(2003, 2, 3) },

            new Movie { Id = 2, Name = "dark host", General_Id = 2, Price = 15, ReleaseDate = new DateOnly(2006, 3, 7) },

            new Movie { Id = 3, Name = "the matrix", General_Id = 3, Price = 16, ReleaseDate = new DateOnly(2008, 8, 5) },

            new Movie { Id = 4, Name = "the lord", General_Id = 4, Price = 18, ReleaseDate = new DateOnly(2009, 3, 8) },

            new Movie { Id = 5, Name = "god", General_Id = 5, Price = 20, ReleaseDate = new DateOnly(2004, 6, 9) }

            );

    }

}

