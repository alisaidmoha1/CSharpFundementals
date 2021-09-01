﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeneralStoreApi.Models
{
    public class GeneralStoreDbContext : DbContext
    {
        public GeneralStoreDbContext () : base("DefaultConnection") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}