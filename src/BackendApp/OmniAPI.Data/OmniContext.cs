using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OmniAPI.Domain.Models;

namespace OmniAPI.Data
{
    public class OmniContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
        public DbSet<UserMovie> UserMovies { get; set; }
        public DbSet<UserGame> UserGames { get; set; }

        public OmniContext(DbContextOptions<OmniContext> options)
        : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var movieList = new Movie[]{
                new Movie {Id = 1, Name = "Władca Pierścieni", EpisodesOverall = 1, Rating = 9.9m, ExternalLink = @"https://fmovies.to/movie/the-lord-of-the-rings-the-fellowship-of-the-ring-extended-80ln/1-1", Photo = @"https://static.posters.cz/image/750webp/11723.webp"},
                new Movie {Id = 2, Name = "The Northman", EpisodesOverall = 1, Rating = 8m, ExternalLink = @"https://fmovies.to/movie/the-northman-qz8kn/1-1", Photo = @"https://static.bunnycdn.ru/i/cache/images/9/9f/9f3cd9f37c5ee354e2151109a89d2278.jpg"},
                new Movie {Id = 3, Name = "Valhalla Rising", EpisodesOverall = 1, Rating = 7m, ExternalLink = @"https://fmovies.to/movie/valhalla-rising-z903/1-1", Photo = @"https://static.bunnycdn.ru/i/cache/images/5/5d/5d8a4e3ce83a18d1642db937ff600710.jpg"},
            };
            modelBuilder.Entity<Movie>().HasData(movieList);
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });
        }
    }
}