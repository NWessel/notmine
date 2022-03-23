using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyOrders.Data;
using MyOrders.Models;
using MyOrders.Services.Interfaces;
using System;
using System.Linq;

namespace MyOrders.Services
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = serviceProvider.GetRequiredService<OrderContext>();
            IGetDataService getDataService = serviceProvider.GetRequiredService<IGetDataService>();

            var orders = getDataService.ImportData();

            context.Orders.AddRange(orders);

            context.SaveChanges();

            //if (context.Orders.Any())
            //{
            //    return; // seeded
            //}

            //context.Orders.AddRange(
            //    new Order
            //    {
            //        Id = 1,
            //        OrderNumber = 555123,
            //        OrderDate = DateTime.Parse("03-22-2022"),
            //        CustomerId = 1
            //    }
            //);

            //context.Customers.AddRange(
            //    new Customer
            //    {
            //        Id = 1,
            //        CustomerNumber = 555123,
            //        CustomerName = "Rabbity Babbity"
            //    }
            //);

            //context.Products.AddRange(
            //    new Product
            //    {
            //        Id = 1,
            //        ProductNumber = "50BB",
            //        Name = "Buttons",
            //        Description = "A bunch of buttons",
            //        Price = 3.99M
            //    }
            //);

            //context.ProductGroups.AddRange(
            //    new ProductGrouping
            //    {
            //        Id = 1,
            //        ProductGroup = "Sewing"
            //    }
            //);

            //context.OrderProduct.AddRange(
            //    new OrderProduct
            //    {
            //        Id = 1,
            //        OrderId = 1,
            //        ProductId = 1,
            //        OrderLineNumber = 1,
            //        Quantity = 3
            //    }
            //);




        }
    }
}