using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace momin.Models
{
    public class customer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string CustomerTYpe { get; set; }

    }
    
    public class CustomerDbContext : DbContext
    {
        public DbSet<customer> customers { get; set; }
      //  public CustomerDbContext db = new CustomerDbContext();
    }
 
}