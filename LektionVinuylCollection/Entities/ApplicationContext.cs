using System;
using Microsoft.EntityFrameworkCore;

//dotnet ef migrations add XXXX
//dotnet ef database update

namespace LektionVinuylCollection.Entities
{
    public class ApplicationContext : DbContext
    {
        //private string _connectionString;

        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //var _connectionString = "server=localhost;database=VinylCollection;user Id=Ghana;password=ghana1985";
            var _connectionString = "server=localhost;database=VinylCollection2;user Id=Ghana;password=ghana1985";
            options.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }

        //Add some data to DB
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Artist>().HasData(

                new Artist
                {
                    Id=1,
                    Name="Artist 1",
                    Created = DateTime.Now,
                    FavoriteCar = "Benz",
                },

                 new Artist
                 {
                     Id = 2,
                     Name = "Artist 2",
                     Created = DateTime.Now,
                     FavoriteCar = "Volvo",
                 },

                  new Artist
                  {
                      Id = 3,
                      Name = "Artist 3",
                      Created = DateTime.Now,
                      FavoriteCar = "Volkswagen",
                  });

            //Seed data for Vinyl
            builder.Entity<Vinyl>().HasData(
                new Vinyl
                {
                    Id = 1,
                    Created = DateTime.Now,
                    Title = "Title 1",
                    ArtistID = 1
                },

                 new Vinyl
                 {
                     Id = 2,
                     Created = DateTime.Now,
                     Title = "Title 2",
                     ArtistID = 2
                 },

                  new Vinyl
                  {
                      Id = 3,
                      Created = DateTime.Now,
                      Title = "Title 3",
                      ArtistID = 3
                  },

                   new Vinyl
                   {
                       Id = 4,
                       Created = DateTime.Now,
                       Title = "Title 4",
                       ArtistID = 3
                   },

                    new Vinyl
                    {
                        Id = 5,
                        Created = DateTime.Now,
                        Title = "Title 5",
                        ArtistID = 3
                    },

                     new Vinyl
                     {
                         Id = 6,
                         Created = DateTime.Now,
                         Title = "Title 6",
                         ArtistID = 3
                     }
                );
        }
    }
}
