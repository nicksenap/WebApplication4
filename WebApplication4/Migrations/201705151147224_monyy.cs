namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class monyy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InvestmentApplications", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.InvestmentApplications", "User_Id");
            AddForeignKey("dbo.InvestmentApplications", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvestmentApplications", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.InvestmentApplications", new[] { "User_Id" });
            DropColumn("dbo.InvestmentApplications", "User_Id");
        }
    }
}
