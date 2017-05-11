namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sexy : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.LoanRates", newName: "Rates");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Rates", newName: "LoanRates");
        }
    }
}
