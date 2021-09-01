using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStoreApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int UPC { get; set; }

        [Required]
        [Range(0, 10000)]
        public decimal Price { get; set; }

        [Range (0, 999999)]
        [Required]
        public int Quantity { get; set; }
    }
}