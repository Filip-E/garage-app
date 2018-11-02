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
            SetSqlGenerator("MySql.Data.MySqlClient", new MyMigrationSqlGenerator());
        }

        protected override void Seed(DAL.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // init seed objects
            Category retro = new Category {Id = 1, Type = "Retro_Vintage"};
            Category part = new Category {Id = 2, Type = "Parts"};
            Category car = new Category {Id = 2, Type = "Cars"};
            Category lamp = new Category {Id = 4, Type = "Lamps"};

            SpecificationType merk = new SpecificationType {Id = 1, Type = "Merk",IsRequiredForCar = true};
            SpecificationType model = new SpecificationType {Id = 2, Type = "Model", IsRequiredForCar = true };
            SpecificationType bouwjaar = new SpecificationType {Id = 3, Type = "Bouwjaar", IsRequiredForCar = true };
            SpecificationType cilinderhoud = new SpecificationType {Id = 4, Type = "Cilinderhoud", IsRequiredForCar = true };
            SpecificationType brandstoftype = new SpecificationType {Id = 5, Type = "Brandstoftype", IsRequiredForCar = true };
            SpecificationType kleur = new SpecificationType {Id = 6, Type = "Kleur", IsRequiredForCar = true};
            SpecificationType oldTimer = new SpecificationType {Id = 7, Type = "old timer", IsRequiredForCar = false};


            Product p1 = new Product {Id = 1, Name = "Bowling kegels", Price = 12.99M, Stock = 10};
            p1.Categories.Add(retro);

            Product p2 = new Product {Id = 2, Name = "Coca Cola Cooler", Price = 19.99M, Stock = 0};
            p2.Categories.Add(retro);

            Product p3 = new Product {Id = 3, Name = "Zoeklicht chroom", Price = 19.99M, Stock = 2};
            p3.Categories.Add(part);
            p3.Categories.Add(lamp);

            Product p4 = new Product {Id = 4, Name = "Retro mic", Price = 14.99M, Stock = 1};
            p4.Categories.Add(retro);

            Product p5 = new Product() {Id = 5, Name = "VW T1", Price = 2000M, Stock = 1};
            Specification volkswagen = new Specification() {Id = 1, SpecificationTypeId = 1, Value = "VolksWagen"};
            Specification t1 = new Specification() {Id = 2, SpecificationTypeId = 2, Value = "T1"};
            Specification jaar1964 = new Specification() {Id = 3, SpecificationTypeId = 3, Value = "1964"};
            Specification cilinder1600 = new Specification() {Id = 4, SpecificationTypeId = 4, Value = "1600"};
            Specification benzine = new Specification() {Id = 5, SpecificationTypeId = 5, Value = "Benzine"};
            Specification kleurGroen = new Specification() {Id = 6, SpecificationTypeId = 6, Value = "Groen"};
            Specification kleurWit = new Specification() {Id = 7, SpecificationTypeId = 6, Value = "Wit"};
            List<Specification> specsList = new List<Specification>() {volkswagen,t1,jaar1964,cilinder1600,benzine,kleurWit,kleurGroen};
            p5.Categories.Add(car);
            p5.Specifications.AddRange(specsList);

            
            User u1 = new User()
            {
                Id = 1,
                Password = "admin",
                UserName = "admin"
            };

            // add seed objects to context
            Category[] categorySeed = new Category[] {retro, part, car, lamp};
            foreach (Category c in categorySeed)
            {
                context.Categories.AddOrUpdate(c);
            }

            SpecificationType[] specificationTypeSeed = new SpecificationType[]
                {merk, model, bouwjaar, cilinderhoud, brandstoftype, kleur, oldTimer};
            foreach (SpecificationType s in specificationTypeSeed)
            {
                context.SpecificationTypes.AddOrUpdate(s);
            }

            foreach (Specification spec in specsList)
            {
                context.Specifications.AddOrUpdate(spec);
            }

            Product[] productsSeed = new Product[] {p1, p2, p3, p4, p5};
            foreach (Product p in productsSeed)
            {
                context.Products.AddOrUpdate(p);
            }

            context.Users.AddOrUpdate(u1);

            // save
            context.SaveChanges();
        }
    }
}