﻿using System.Data.Entity;

namespace Products.Domain
{
    public class DataContext : DbContext
    {
        protected DataContext() : base("DefaultConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
