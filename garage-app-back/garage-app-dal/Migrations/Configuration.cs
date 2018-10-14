using garage_app_entities;

namespace DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(DAL.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Category c1 = new Category {Id = 1, Type = "Retro_Vintage"};

            Category c2 = new Category {Id = 2, Type = "Parts"};

            Product p1 = new Product {Id = 1, Name = "Bowling kegels", Price = 12.99M, Stock = 10};
            p1.Categories.Add(c1);

            Product p2 = new Product {Id = 2, Name = "Coca Cola Cooler", Price = 19.99M, Stock = 0};
            p2.Categories.Add(c1);

            Product p3 = new Product {Id = 3, Name = "Zoeklicht chroom", Price = 19.99M, Stock = 2};
            p3.Categories.Add(c2);

            Product p4 = new Product {Id = 4, Name = "Retro mic", Price = 14.99M, Stock = 1};
            p4.Categories.Add(c1);

            User u1 = new User()
            {
                Id = 1,
                Password = "admin",
                UserName = "admin"
            };

            Category[] categorySeed = new Category[] { c1, c2 };
            foreach (Category c in categorySeed)
            {
                context.Categories.AddOrUpdate(c);
            }

            Product[] productsSeed = new Product[] { p1, p2, p3, p4 };
            foreach (Product p in productsSeed)
            {
                context.Products.AddOrUpdate(p);
            }

            context.Users.AddOrUpdate(u1);
        }
    }
}