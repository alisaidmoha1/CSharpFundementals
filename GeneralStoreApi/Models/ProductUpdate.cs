using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStoreApi.Models
{
    public class ProductUpdate
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int UPC { get; set; }

        [Required]
        [Range(0, 10000)]
        public decimal Price { get; set; }
    }
}