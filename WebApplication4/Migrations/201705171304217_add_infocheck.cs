namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_infocheck : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "HasInfo", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "Nationality");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Nationality", c => c.String());
            DropColumn("dbo.AspNetUsers", "HasInfo");
        }
    }
}
