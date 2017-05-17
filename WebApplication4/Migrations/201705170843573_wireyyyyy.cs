namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wireyyyyy : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LoanApplications", "UCScore", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LoanApplications", "UCScore", c => c.Int(nullable: false));
        }
    }
}
