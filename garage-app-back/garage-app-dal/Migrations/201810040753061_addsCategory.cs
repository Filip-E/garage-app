namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategoryProducts",
                c => new
                    {
                        Category_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_Id, t.Product_Id })
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoryProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.CategoryProducts", "Category_Id", "dbo.Categories");
            DropIndex("dbo.CategoryProducts", new[] { "Product_Id" });
            DropIndex("dbo.CategoryProducts", new[] { "Category_Id" });
            DropTable("dbo.CategoryProducts");
            DropTable("dbo.Categories");
        }
    }
}
