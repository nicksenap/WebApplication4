namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wired : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.AspNetUsers", "UCScore", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
           // AlterColumn("dbo.AspNetUsers", "UCScore", c => c.Double(nullable: false));
        }
    }
}
