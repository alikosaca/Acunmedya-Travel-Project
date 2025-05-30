namespace Acunmedya_Travel_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixServiceRelation : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Services", "total_tickets");
            DropColumn("dbo.Services", "sold_ticket");
            DropColumn("dbo.Services", "price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "price", c => c.Decimal(nullable: false, storeType: "money"));
            AddColumn("dbo.Services", "sold_ticket", c => c.Int());
            AddColumn("dbo.Services", "total_tickets", c => c.Int());
        }
    }
}
