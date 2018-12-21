namespace EF.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryIdRemoveFromCustomer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CategoryId", c => c.Long(nullable: false));
        }
    }
}
