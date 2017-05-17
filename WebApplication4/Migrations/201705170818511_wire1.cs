namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wire1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LoanApplications", "P2PScore", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LoanApplications", "P2PScore", c => c.Double(nullable: false));
        }
    }
}
