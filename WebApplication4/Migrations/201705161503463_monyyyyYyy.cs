namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class monyyyyYyy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoanApplications", "BaseCurrency", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LoanApplications", "BaseCurrency");
        }
    }
}
