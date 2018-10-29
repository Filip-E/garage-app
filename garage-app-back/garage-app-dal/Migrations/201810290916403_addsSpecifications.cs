namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsSpecifications : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Specifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(maxLength: 64, storeType: "nvarchar"),
                        SpecificationTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecificationTypes", t => t.SpecificationTypeId, cascadeDelete: true)
                .Index(t => t.SpecificationTypeId);
            
            CreateTable(
                "dbo.SpecificationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 64, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SpecificationProducts",
                c => new
                    {
                        Specification_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Specification_Id, t.Product_Id })
                .ForeignKey("dbo.Specifications", t => t.Specification_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Specification_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Specifications", "SpecificationTypeId", "dbo.SpecificationTypes");
            DropForeignKey("dbo.SpecificationProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.SpecificationProducts", "Specification_Id", "dbo.Specifications");
            DropIndex("dbo.SpecificationProducts", new[] { "Product_Id" });
            DropIndex("dbo.SpecificationProducts", new[] { "Specification_Id" });
            DropIndex("dbo.Specifications", new[] { "SpecificationTypeId" });
            DropTable("dbo.SpecificationProducts");
            DropTable("dbo.SpecificationTypes");
            DropTable("dbo.Specifications");
        }
    }
}
