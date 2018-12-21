namespace EF.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryIdAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CategoryId", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CategoryId");
        }
    }
}
