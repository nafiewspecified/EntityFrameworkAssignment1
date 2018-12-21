namespace EF.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactNoAndAddressAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ContactNo", c => c.String());
            AddColumn("dbo.Customers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Customers", "ContactNo");
        }
    }
}
