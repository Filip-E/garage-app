namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsUniqueConstraintOnProductName : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Products", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "Name" });
        }
    }
}
