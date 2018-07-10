using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Vidly.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

    public class CustomerDBContext : DbContext
    {
        public DbSet<Customer> Movies { get; set; }
    }


}