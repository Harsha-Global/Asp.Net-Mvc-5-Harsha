using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace EFDbFirstApproachExample.Models
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("MyConnectionString")
        {
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}


