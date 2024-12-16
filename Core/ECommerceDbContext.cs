using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class ECommerceDbContext:DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options): base(options){}

        public DbSet<Product> Products { get;set;}
        public DbSet<Review> Reviews { get; set;}
        public DbSet<Supplier> Suppliers{ get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .HasOne(p=>p.Supplier)
            .WithMany(s=>s.Products)
            .HasForeignKey(p=>p.SupplierId);

            modelBuilder.Entity<Review>()
            .HasOne(r=>r.Product)
            .WithMany(p=>p.Reviews)
            .HasForeignKey(r=>r.ProductId);

           modelBuilder.Entity<Supplier>().HasData(
            new Supplier { Id = 1, Name = "Tech Supplies", ContactEmail = "tech@supplies.com" },
            new Supplier { Id = 2, Name = "Home Essentials", ContactEmail = "essentials@home.com" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 1200, SupplierId = 1 },
                new Product { Id = 2, Name = "Vacuum Cleaner", Price = 300, SupplierId = 2 }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, ProductId = 1, ReviewerName = "John", Comment = "Great product!", Rating = 5 },
                new Review { Id = 2, ProductId = 2, ReviewerName = "Jane", Comment = "Works well!", Rating = 4 }
            );

            
            base.OnModelCreating(modelBuilder);
        }
    }
}