using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyOrders.Models;

namespace MyOrders.DTO
{
    public class FullOrderDTO
    {
        
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductGrouping> ProductGroup { get; set; }
        public IEnumerable<OrderProduct> OrderProduct { get; set; }
        
    }
}