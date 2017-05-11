namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Investments", "CreationDate", c => c.DateTime(nullable: false, defaultValue:DateTime.Today));
            AlterColumn("dbo.Investments", "IsSigned", c => c.Boolean(nullable:false, defaultValue:false));
            AlterColumn("dbo.Investments", "IsVerified", c => c.Boolean(nullable:false, defaultValue:false));
            AlterColumn("dbo.LoanAccounts", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Today));
            AlterColumn("dbo.LoanApplications", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Today));
            AlterColumn("dbo.LoanPayments", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Today));
            AlterColumn("dbo.LoanPaymentParts", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Today));
            AlterColumn("dbo.Loans", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Today));
            AlterColumn("dbo.AspNetUsers", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Today));
            AlterColumn("dbo.UserChangeLogs", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Today));
            AlterColumn("dbo.UserInfoDatas", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Today));
            AlterColumn("dbo.UserInfoTypes", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Today));
            


        }

        public override void Down()
        {
        }
    }
}
