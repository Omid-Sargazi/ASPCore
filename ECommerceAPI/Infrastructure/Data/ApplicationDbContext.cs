using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Order> Orders{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>()
            .HasMany(c=>c.Products)
            .WithOne(p=>p.Category)
            .HasForeignKey(p=>p.CategoryId);

            modelBuilder.Entity<Order>()
            .HasMany(o=>o.Products)
            .WithMany(p=>p.Orders)
            .UsingEntity(j=>j.ToTable("OrderProducts"));

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category {Id=1, Name="Electronics"},
                new Category {Id=2, Name="Home App"}
            );
        }
    }
}