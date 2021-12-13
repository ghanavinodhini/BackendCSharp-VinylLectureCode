using System;
using Microsoft.EntityFrameworkCore;

namespace LektionVinuylCollection.Entities
{
    public class ApplicationContext : DbContext
    {
        //private string _connectionString;

        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var _connectionString = "server=localhost;database=VinylCollection;user Id=Ghana;password=ghana1985";

            options.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }


    }
}
