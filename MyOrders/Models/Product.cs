using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyOrders.Models
{
    public class Product
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Number")]
        public string ProductNumber { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }


        // Many to Many
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        
        // One To Many
        [Required]
        public int ProductGroupingId { get; set; }
        [ForeignKey("ProductGroupingId")]
        public virtual ProductGrouping ProductGroup { get; set; }

    }
}