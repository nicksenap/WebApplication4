namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zxxxxxxx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoanApplications", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LoanApplications", "Status");
        }
    }
}
