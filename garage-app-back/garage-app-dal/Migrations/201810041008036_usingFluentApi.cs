namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usingFluentApi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 32, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 64, storeType: "nvarchar"));
        }
    }
}
