namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_more : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nationality", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Nationality");
        }
    }
}
