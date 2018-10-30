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
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("connectionString") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<SpecificationType> SpecificationTypes { get; set; }

        public void DetachAllEntities()
        {
            var changedEntriesCopy = this.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted ||
                            e.State == EntityState.Unchanged)
                .ToList();

            foreach (var entry in changedEntriesCopy)
                entry.State = EntityState.Detached;
        }

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
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Name)
                .IsUnique();

            modelBuilder.Entity<Category>()
                .Property(category => category.Type)
                .HasMaxLength(32)
                .IsRequired();

            modelBuilder.Entity<Specification>()
                .Property(specification => specification.Value)
                .HasMaxLength(64);

            modelBuilder.Entity<SpecificationType>()
                .Property(specificationType => specificationType.Type)
                .HasMaxLength(64)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(user => user.UserName)
                .HasMaxLength(32)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(user => user.Password)
                .HasMaxLength(32)
                .IsRequired();
        }
    }
}
