namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class monyyy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InvestmentApplications", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InvestmentApplications", "Status");
        }
    }
}
