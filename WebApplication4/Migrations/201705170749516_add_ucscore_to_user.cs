namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_ucscore_to_user : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UCScore", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UCScore");
        }
    }
}
