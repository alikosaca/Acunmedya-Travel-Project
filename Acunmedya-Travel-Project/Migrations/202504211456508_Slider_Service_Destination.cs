namespace Acunmedya_Travel_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Slider_Service_Destination : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Price = c.Int(nullable: false),
                        DaysTrip = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.DestinationID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Descreption = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ServiceID);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sliders");
            DropTable("dbo.Services");
            DropTable("dbo.Destinations");
        }
    }
}
