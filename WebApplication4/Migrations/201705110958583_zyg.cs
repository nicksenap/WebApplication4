namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class zyg : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Investments", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
            AlterColumn("dbo.Investments", "IsSigned", c => c.Boolean(nullable: false, defaultValue: false));
            AlterColumn("dbo.Investments", "IsVerified", c => c.Boolean(nullable: false, defaultValue: false));
            AlterColumn("dbo.LoanAccounts", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
            AlterColumn("dbo.LoanApplications", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
            AlterColumn("dbo.LoanPayments", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
            AlterColumn("dbo.LoanPaymentParts", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
            AlterColumn("dbo.Loans", "CreationDate", c => c.DateTime(nullable: false, defaultValueSql: "CAST(GETDATE() AS DATE)"));
            AlterColumn("dbo.AspNetUsers", "CreationDate", c => c.DateTime(nullable: false, defaultValueSql: "GETDATE()"));
            AlterColumn("dbo.UserChangeLogs", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
            AlterColumn("dbo.UserInfoDatas", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
            AlterColumn("dbo.UserInfoTypes", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
            // AlterColumn("dbo.UserInfoTypes", "CreationDate", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));



        }

        public override void Down()
        {
        }
    }
}
