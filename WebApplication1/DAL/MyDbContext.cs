using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("connectionString") { }
        public DbSet<Product> Products { get; set; }
    }
}
