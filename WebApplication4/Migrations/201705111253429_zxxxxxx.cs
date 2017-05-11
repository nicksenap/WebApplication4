namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zxxxxxx : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InvestmentAccounts", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.InvestmentAccountPayments", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.InvestmentAssets", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.Investments", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.Loans", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.LoanAccounts", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.LoanApplications", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.UserChangeLogs", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.UserInfoDatas", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.UserInfoTypes", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.LoanPayments", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.LoanPaymentParts", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.Rates", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
            AlterColumn("dbo.InvestmentApplications", "CreationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InvestmentApplications", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rates", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.LoanPaymentParts", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.LoanPayments", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserInfoTypes", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserInfoDatas", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserChangeLogs", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.LoanApplications", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.LoanAccounts", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Loans", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Investments", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.InvestmentAssets", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.InvestmentAccountPayments", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.InvestmentAccounts", "CreationDate", c => c.DateTime(nullable: false));
        }
    }
}
