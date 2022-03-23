using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyOrders.Models
{
    public class Order
    {
        [Key]        
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Order Number")]
        public int OrderNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        

        // One to Many
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

        // One to Many
        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}