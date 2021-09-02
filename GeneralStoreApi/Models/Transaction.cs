using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStoreApi.Models
{
    public class Transaction
    {
        // assumber by Entity Frame Work[Key]
        public int Id { get; set; }
        [Required]
        // Asuumed by EF[ForeignKey(nameof (Product))]
        public int ProductId { get; set; }
        [Required]
        public int CustomerId { get; set; }

        // this is not storing in the database
        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime DateOfTransaction { get; set; }
        public int Quantity { get; set; }
    }
}