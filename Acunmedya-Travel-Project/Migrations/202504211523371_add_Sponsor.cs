namespace Acunmedya_Travel_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Sponsor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SponsorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sponsors");
        }
    }
}
