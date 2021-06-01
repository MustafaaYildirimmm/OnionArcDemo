using Microsoft.EntityFrameworkCore;
using OnionArcDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcDemo.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product() { Id=1,Amount=1254.2m,Quantity=2,Name="Phone"},
               new Product() { Id=1,Amount=12254.2m,Quantity=1,Name="Laptop"},
               new Product() { Id=1,Amount=154.2m,Quantity=6,Name="HeadPhones"},
               new Product() { Id=1,Amount=22222,Quantity=4,Name="Tv"}
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
