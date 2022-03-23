using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyOrders.Models
{
    public class OrderProduct
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Display(Name = "Order Line Number")]
        // TODO: left pad to 4 with leading zeroes
        public int OrderLineNumber { get; set; }
        public int Quantity { get; set; }

        
        // Many to Many
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

    }
}