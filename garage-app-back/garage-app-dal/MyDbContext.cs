using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using garage_app_entities;

namespace DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("connectionString") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(product => product.Name)
                .HasMaxLength(32)
                .IsRequired();
           modelBuilder.Entity<Product>()
                .Property(product => product.Price)
                .IsRequired();
           modelBuilder.Entity<Product>()
                .Property(product => product.Stock)
                .IsRequired();

            modelBuilder.Entity<Category>()
                .Property(category => category.Type)
                .HasMaxLength(32)
                .IsRequired();
        }
    }
}
