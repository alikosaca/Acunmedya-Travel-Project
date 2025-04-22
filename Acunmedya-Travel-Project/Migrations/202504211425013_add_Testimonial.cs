namespace Acunmedya_Travel_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Testimonial : DbMigration
    {
        public override void Up()
        {
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
            DropTable("dbo.Testimonials");
        }
    }
}
