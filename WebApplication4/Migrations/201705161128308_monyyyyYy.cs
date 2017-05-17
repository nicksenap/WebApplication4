namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class monyyyyYy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "pictureUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "pictureUrl");
        }
    }
}
