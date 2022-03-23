using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyOrders.Models
{
    public class Customer
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Customer Number")]
        public int CustomerNumber { get; set; }
        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }


        // One to Many 
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}