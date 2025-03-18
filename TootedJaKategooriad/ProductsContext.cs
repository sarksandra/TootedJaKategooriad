using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TootedJaKategooriad
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=product.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Dog"},
                new Category { CategoryID = 2, CategoryName = "Cat"},
                new Category { CategoryID = 3, CategoryName = "Bunny"},
                new Category { CategoryID = 4, CategoryName = "Nothing"}
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, CategoryID = 1, ProductName = "Affenpinscher " },
                new Product { ProductID = 2, CategoryID = 1, ProductName = "Afghan Hound " },
                new Product { ProductID = 3, CategoryID = 1, ProductName = "Airedale Terrier " },
                new Product { ProductID = 4, CategoryID = 1, ProductName = "Alaskan Malamute " },
                new Product { ProductID = 5, CategoryID = 1, ProductName = "American Bulldog " },
                new Product { ProductID = 6, CategoryID = 1, ProductName = "American Cocker Spaniel " },
                new Product { ProductID = 7, CategoryID = 1, ProductName = "Anatolian Shepherd Dog " },
                new Product { ProductID = 8, CategoryID = 1, ProductName = "Australian Cattle Dog " },
                new Product { ProductID = 9, CategoryID = 1, ProductName = "Australian Shepherd Dog " },
                new Product { ProductID = 10, CategoryID = 1, ProductName = "Australian Silky Terrier " },
                new Product { ProductID = 11, CategoryID = 1, ProductName = "Australian Terrier " },
                new Product { ProductID = 12, CategoryID = 1, ProductName = "Azawakh " },
                new Product { ProductID = 13, CategoryID = 1, ProductName = "Barbet " },
                new Product { ProductID = 14, CategoryID = 1, ProductName = "Basenji " },
                new Product { ProductID = 15, CategoryID = 1, ProductName = "Bloodhound " },

                new Product { ProductID = 16, CategoryID = 2, ProductName = "Abyssinian " },
                new Product { ProductID = 17, CategoryID = 2, ProductName = "American Bobtail " },
                new Product { ProductID = 18, CategoryID = 2, ProductName = "Aegean " },
                new Product { ProductID = 19, CategoryID = 2, ProductName = "American Curl " },
                new Product { ProductID = 20, CategoryID = 2, ProductName = "American Longhair " },
                new Product { ProductID = 21, CategoryID = 2, ProductName = "Balinese " },
                new Product { ProductID = 22, CategoryID = 2, ProductName = "Asian Semi-Longhair " },
                new Product { ProductID = 23, CategoryID = 2, ProductName = "Bengal"},
                new Product { ProductID = 24, CategoryID = 2, ProductName = "Bombay"},
                new Product { ProductID = 25, CategoryID = 2, ProductName = "Brazilian Shorthair"},
                new Product { ProductID = 26, CategoryID = 2, ProductName = "British Longhair"},
                new Product { ProductID = 27, CategoryID = 2, ProductName = "salmiak cats"},

                new Product { ProductID = 28, CategoryID = 3, ProductName = "Alaskan" },
                new Product { ProductID = 29, CategoryID = 3, ProductName = "Checkered Giant"},
                new Product { ProductID = 30, CategoryID = 3, ProductName = "American Sable"},

                new Product { ProductID = 31, CategoryID = 4, ProductName ="Nothing"},
                new Product { ProductID = 32, CategoryID = 4, ProductName ="0"},
                new Product { ProductID = 33, CategoryID = 4, ProductName ="..."},
                new Product { ProductID = 34, CategoryID = 4, ProductName ="Pool krõpsupakki"}
                );
        }
    }
}
