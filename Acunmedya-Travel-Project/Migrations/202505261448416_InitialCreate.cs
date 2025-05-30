namespace Acunmedya_Travel_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        destination_id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                        image_url = c.String(),
                        days_trip = c.String(),
                        total_tickets = c.Int(nullable: false),
                        sold_ticket = c.Int(nullable: false),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        category_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.destination_id)
                .ForeignKey("dbo.Categories", t => t.category_id, cascadeDelete: true)
                .Index(t => t.category_id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        service_id = c.Int(nullable: false, identity: true),
                        title = c.String(maxLength: 150),
                        description = c.String(unicode: false, storeType: "text"),
                        image_url = c.String(),
                        total_tickets = c.Int(),
                        sold_ticket = c.Int(),
                        price = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.service_id);
            
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
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SponsorID);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        ImageUrl = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TestimonialID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Destinations", "category_id", "dbo.Categories");
            DropIndex("dbo.Destinations", new[] { "category_id" });
            DropTable("dbo.Testimonials");
            DropTable("dbo.Sponsors");
            DropTable("dbo.Sliders");
            DropTable("dbo.Services");
            DropTable("dbo.Destinations");
            DropTable("dbo.Categories");
            DropTable("dbo.Admins");
        }
    }
}
