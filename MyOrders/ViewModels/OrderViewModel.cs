using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyOrders.Models;

namespace MyOrders.ViewModels
{
    public class OrderViewModel
    {
        /*
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductGrouping> ProductGroup { get; set; }
        public IEnumerable<OrderProduct> OrderProduct { get; set; }
        */
        
        
        public int OrderId { get; set; }

        [Display(Name = "Order Number")]
        public int OrderNumber { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]

        public DateTime OrderDate { get; set; }

        [Display(Name = "Customer Number")]
        public int CustomerNumber { get; set; }
        
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
    }
}