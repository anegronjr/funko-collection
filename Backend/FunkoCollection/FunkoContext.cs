using FunkoCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunkoCollection
{
    public class FunkoContext : DbContext
    {
        public DbSet<Funko> Funkos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=funkocollection;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funko>().HasData(
                new Funko()
                {
                    FunkoId = 1,
                    Name = "",
                    CategoryId = 1,
                    Image = "", 
                },
                new Funko()
                {
                    FunkoId = 2,
                    Name = "",
                    CategoryId = 1,
                    Image = "",
                },
                new Funko()
                {
                    FunkoId = 3,
                    Name = "",
                    CategoryId = 1,
                    Image = "",
                },
                new Funko()
                {
                    FunkoId = 4,
                    Name = "",
                    CategoryId = 1,
                    Image = "",

                },

                new Funko()
                {
                    FunkoId = 5,
                    Name = "",
                    CategoryId = 2,
                    Image = "",
                },

                new Funko()
                {
                    FunkoId = 6,
                    Name = "",
                    CategoryId = 2,
                    Image = "",
                },
                new Funko()
                {
                    FunkoId = 7,
                    Name = "",
                    CategoryId = 2,
                    Image = "",

                },

                new Funko()
                {
                    FunkoId = 8,
                    Name = "",
                    CategoryId = 2,
                    Image = "",
                },

                new Funko()
                {
                    FunkoId = 9,
                    Name = "",
                    CategoryId = 3,
                    Image = "",
                },
                new Funko()
                {
                    FunkoId = 10,
                    Name = "",
                    CategoryId = 3,
                    Image = "",

                },

                new Funko()
                {
                    FunkoId = 11,
                    Name = "",
                    CategoryId = 3,
                    Image = "",
                },

                new Funko()
                {
                    FunkoId = 12,
                    Name = "",
                    CategoryId = 3,
                    Image = "",
                });
        }
    }
}
