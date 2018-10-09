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

            Category c1 = new Category();
            c1.Id = 1;
            c1.Type = "Retro_Vintage";

            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "Bowling kegels";
            p1.Price = 12.99M;
            p1.Categories.Add(c1);

            Product p2 = new Product();
            p2.Id = 2;
            p2.Name = "Coca Cola Cooler";
            p2.Price = 19.99M;
            p2.Categories.Add(c1);

            User u1 = new User()
            {
                Id = 1,
                Password = "admin",
                UserName = "admin"
            };

            Category[] categorySeed = new Category[] { c1 };
            foreach (Category c in categorySeed)
            {
                context.Categories.AddOrUpdate(c);
            }

            Product[] productsSeed = new Product[] { p1, p2 };
            foreach (Product p in productsSeed)
            {
                context.Products.AddOrUpdate(p);
            }

            context.Users.AddOrUpdate(u1);
        }
    }
}