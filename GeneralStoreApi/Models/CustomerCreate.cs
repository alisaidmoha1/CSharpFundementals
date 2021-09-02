using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStoreApi.Models
{
    public class CustomerCreate
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}