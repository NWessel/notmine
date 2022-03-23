using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyOrders.Models
{
    public class ProductGrouping
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Group")]
        public string ProductGroup { get; set; }

        // One to Many 
        public virtual ICollection<Product> Products { get; set; }
    }
}