using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVillas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
        //villas est le nom du table dans db

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
               new Villa()
               {
                   Id = 1,
                   Name = "Royal villa",
                   Description = "This is the royal villa",
                   Rate = 4.5,
                   Sqft = 400,
                   ImageUrl = "http://via.placeholder.com/400x300.png?text=Royal+Villa",
                   Price = 100000,
                   CreatedDate = DateTime.Now
               },
               new Villa()
               {
                   Id = 2,
                   Name = "Ocean View Villa",
                   Description = "A beautiful villa with an ocean view",
                   Rate = 4.8,
                   Sqft = 550,
                   ImageUrl = "http://via.placeholder.com/400x300.png?text=Ocean+View+Villa",
                   Price = 150000,
                   CreatedDate = DateTime.Now

               },
               new Villa()
               {
                   Id = 3,
                   Name = "Mountain Retreat Villa",
                   Description = "A serene villa in the mountains",
                   Rate = 4.7,
                   Sqft = 600,
                   ImageUrl = "http://via.placeholder.com/400x300.png?text=Mountain+Retreat+Villa",
                   Price = 200000,
                   CreatedDate = DateTime.Now

               },
               new Villa()
               {
                   Id = 4,
                   Name = "City Lights Villa",
                   Description = "A modern villa in the city center",
                   Rate = 4.6,
                   Sqft = 450,
                   ImageUrl = "http://via.placeholder.com/400x300.png?text=City+Lights+Villa",
                   Price = 120000,
                   CreatedDate = DateTime.Now

               },
               new Villa()
               {
                   Id = 5,
                   Name = "Countryside Villa",
                   Description = "A charming villa in the countryside",
                   Rate = 4.9,
                   Sqft = 500,
                   ImageUrl = "http://via.placeholder.com/400x300.png?text=Countryside+Villa",
                   Price = 110000,
                   CreatedDate = DateTime.Now

               });
        }
    }
}
