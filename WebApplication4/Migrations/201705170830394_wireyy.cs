namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wireyy : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "P2PScore", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}