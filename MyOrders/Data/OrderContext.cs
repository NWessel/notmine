using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyOrders.Models;
using MyOrders.ViewModels;

namespace MyOrders.Data
{
    public class OrderContext : DbContext 
    {
        public OrderContext (DbContextOptions<OrderContext> options)
            : base(options)
        {
        }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductGrouping> ProductGroups { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }

        

        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        // {
        //     var builder = new ConfigurationBuilder()
        //         .SetBasePath(Directory.GetCurrentDirectory())
        //         .AddJsonFile("appsettings.json");

        //     var config = builder.Build();
            
        //     options.UseSqlite(config.GetConnectionString("Default"));
        // }
    }
}