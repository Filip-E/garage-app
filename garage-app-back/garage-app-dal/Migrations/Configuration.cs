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
            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "Tomato Soup";
            p1.Category = "Groceries";
            p1.Price = 1;

            Product p2 = new Product();
            p2.Id = 2;
            p2.Name = "Hammer";
            p2.Category = "Hardware";
            p2.Price = 19.99M;

            //Product[] productsSeed = new Product[] { p1, p2 };
            context.Products.AddOrUpdate(p1);
            context.Products.AddOrUpdate(p2);
        }
    }
}
