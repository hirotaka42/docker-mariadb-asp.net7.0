using System;
using Bff.Models;
using Microsoft.EntityFrameworkCore;

namespace Bff.Contexts
{
	public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Product> Products { get; set; }
    }
}

