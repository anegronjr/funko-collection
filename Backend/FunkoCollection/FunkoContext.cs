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
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=funkocollection;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    Name = "Naruto"
                },
                new Category()
                {
                    CategoryId = 2,
                    Name = "Game of Thrones"
                },
                new Category()
                {
                    CategoryId = 3,
                    Name = "Star Wars"
                });

            modelBuilder.Entity<Funko>().HasData(
                new Funko()
                {
                    FunkoId = 1,
                    Name = "Naruto",
                    CategoryId = 1,
                    Image = "/images/naruto.jpg" 
                },
                new Funko()
                {
                    FunkoId = 2,
                    Name = "Sasuke",
                    CategoryId = 1,
                    Image = "/images/sasuke.jpg"
                },
                new Funko()
                {
                    FunkoId = 3,
                    Name = "Sakura",
                    CategoryId = 1,
                    Image = "/images/sakura.jpg"
                },
                new Funko()
                {
                    FunkoId = 4,
                    Name = "Kakashi",
                    CategoryId = 1,
                    Image = "/images/kakashi.jpg"

                },

                new Funko()
                {
                    FunkoId = 5,
                    Name = "Jon Snow",
                    CategoryId = 2,
                    Image = "/images/jonsnow.jpeg"
                },

                new Funko()
                {
                    FunkoId = 6,
                    Name = "Daenerys",
                    CategoryId = 2,
                    Image = "/images/daenerys.jpeg"
                },
                new Funko()
                {
                    FunkoId = 7,
                    Name = "Cersei",
                    CategoryId = 2,
                    Image = "/images/cersei.jpeg"

                },

                new Funko()
                {
                    FunkoId = 8,
                    Name = "The Night King",
                    CategoryId = 2,
                    Image = "/images/nightking.jpeg"
                },

                new Funko()
                {
                    FunkoId = 9,
                    Name = "Darth Vader",
                    CategoryId = 3,
                    Image = "/images/darthvader.jpg"
                },
                new Funko()
                {
                    FunkoId = 10,
                    Name = "Storm Trooper",
                    CategoryId = 3,
                    Image = "/images/stormtrooper.jpg"

                },

                new Funko()
                {
                    FunkoId = 11,
                    Name = "Chewbacca",
                    CategoryId = 3,
                    Image = "/images/chewbacca.jpg"
                },

                new Funko()
                {
                    FunkoId = 12,
                    Name = "Yoda",
                    CategoryId = 3,
                    Image = "/images/yoda.jpg"
                });
        }
    }
}
