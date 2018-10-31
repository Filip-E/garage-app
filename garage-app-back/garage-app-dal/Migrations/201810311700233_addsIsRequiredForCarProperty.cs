namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsIsRequiredForCarProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SpecificationTypes", "IsRequiredForCar", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SpecificationTypes", "IsRequiredForCar");
        }
    }
}
