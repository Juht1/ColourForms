using ColourPeopleForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourPeopleForms
{
    public class PeoplesContext : DbContext
    {
        public DbSet<People> Peoples { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=Peoples.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "White" },
                new Category { CategoryId = 2, Name = "Mixed" },
                new Category { CategoryId = 3, Name = "Asian" },
                new Category { CategoryId = 4, Name = "Black" });

            modelBuilder.Entity<People>().HasData(
            new People { PeopleId = 1, CategoryId = 1, Name = "Peter", Height = 180 },
            new People { PeopleId = 2, CategoryId = 1, Name = "John", Height = 180 },
            new People { PeopleId = 3, CategoryId = 1, Name = "Michael", Height = 175 },
            new People { PeopleId = 4, CategoryId = 1, Name = "David", Height = 178 },
            new People { PeopleId = 5, CategoryId = 1, Name = "Karl", Height = 180 },
            new People { PeopleId = 6, CategoryId = 1, Name = "James", Height = 172 },
            new People { PeopleId = 7, CategoryId = 1, Name = "Carl", Height = 182 },
            new People { PeopleId = 8, CategoryId = 1, Name = "Alex", Height = 170 },
            new People { PeopleId = 9, CategoryId = 1, Name = "Leeroy", Height = 176 },
            new People { PeopleId = 10, CategoryId = 1, Name = "Maria", Height = 165 },
            new People { PeopleId = 11, CategoryId = 2, Name = "Thomas", Height = 180 },
            new People { PeopleId = 12, CategoryId = 2, Name = "Richard", Height = 185 },
            new People { PeopleId = 13, CategoryId = 2, Name = "Charles", Height = 170 },
            new People { PeopleId = 14, CategoryId = 2, Name = "Henry", Height = 175 },
            new People { PeopleId = 15, CategoryId = 2, Name = "James", Height = 182 },
            new People { PeopleId = 16, CategoryId = 2, Name = "Robert", Height = 180 },
            new People { PeopleId = 17, CategoryId = 2, Name = "George", Height = 178 },
            new People { PeopleId = 18, CategoryId = 2, Name = "Edward", Height = 172 },
            new People { PeopleId = 19, CategoryId = 2, Name = "Andrew", Height = 176 },
            new People { PeopleId = 20, CategoryId = 2, Name = "William", Height = 170 },
            new People { PeopleId = 21, CategoryId = 3, Name = "Philip", Height = 180 },
            new People { PeopleId = 22, CategoryId = 3, Name = "Patrick", Height = 185 },
            new People { PeopleId = 23, CategoryId = 3, Name = "Simon", Height = 178 },
            new People { PeopleId = 24, CategoryId = 4, Name = "Rye", Height = 170 },
            new People { PeopleId = 25, CategoryId = 4, Name = "Wheat", Height = 172 },
            new People { PeopleId = 26, CategoryId = 4, Name = "Brioche", Height = 168 },
            new People { PeopleId = 27, CategoryId = 4, Name = "Naan", Height = 175 },
            new People { PeopleId = 28, CategoryId = 4, Name = "Focaccia", Height = 180 },
            new People { PeopleId = 29, CategoryId = 4, Name = "Malted", Height = 182 },
            new People { PeopleId = 30, CategoryId = 4, Name = "Sourdough", Height = 170 },
            new People { PeopleId = 31, CategoryId = 4, Name = "Corn", Height = 165 },
            new People { PeopleId = 32, CategoryId = 4, Name = "White", Height = 178 },
            new People { PeopleId = 33, CategoryId = 4, Name = "Soda", Height = 180 });
        }
    }
}