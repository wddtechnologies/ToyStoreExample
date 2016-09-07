using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToyStoreExample.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ToyStoreExample")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products {get; set;}
    }
}