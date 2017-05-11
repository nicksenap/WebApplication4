namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Taichi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InvestmentAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        BaseCurrency = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        InvestCount = c.Int(nullable: false),
                        TotalAmount = c.Int(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        LeftAmount = c.Double(nullable: false),
                        SpecialsAmount = c.Double(nullable: false),
                        ReturnAmount = c.Double(nullable: false),
                        TRInterestAmount = c.Double(nullable: false),
                        TRPrincipleAmount = c.Double(nullable: false),
                        TReservedAmount = c.Double(nullable: false),
                        TInvestedAmount = c.Double(nullable: false),
                        TTransferedAmountIn = c.Double(nullable: false),
                        TTransferedAmountOut = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InvestmentAccountPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                        Reference = c.String(),
                        Status = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Direction = c.Int(nullable: false),
                        FromAsset_Id = c.Int(),
                        InvestAccount_Id = c.Int(),
                        ToAsset_Id = c.Int(),
                        InvestmentApplication_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InvestmentAssets", t => t.FromAsset_Id)
                .ForeignKey("dbo.InvestmentAccounts", t => t.InvestAccount_Id)
                .ForeignKey("dbo.InvestmentAssets", t => t.ToAsset_Id)
                .ForeignKey("dbo.InvestmentApplications", t => t.InvestmentApplication_Id)
                .Index(t => t.FromAsset_Id)
                .Index(t => t.InvestAccount_Id)
                .Index(t => t.ToAsset_Id)
                .Index(t => t.InvestmentApplication_Id);
            
            CreateTable(
                "dbo.InvestmentAssets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        InvestCount = c.Int(nullable: false),
                        TotalAmount = c.Int(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        isDeleted = c.Boolean(nullable: false),
                        LeftAmount = c.Double(nullable: false),
                        SpecialsAmount = c.Double(nullable: false),
                        ReturnAmount = c.Double(nullable: false),
                        TRInterestAmount = c.Double(nullable: false),
                        TRPrincipleAmount = c.Double(nullable: false),
                        TReservedAmount = c.Double(nullable: false),
                        TInvestedAmount = c.Double(nullable: false),
                        TTransferedAmountIn = c.Double(nullable: false),
                        TTransferedAmountOut = c.Double(nullable: false),
                        Production_Id = c.Int(),
                        InvestmentAccount_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rates", t => t.Production_Id)
                .ForeignKey("dbo.InvestmentAccounts", t => t.InvestmentAccount_Id)
                .Index(t => t.Production_Id)
                .Index(t => t.InvestmentAccount_Id);
            
            CreateTable(
                "dbo.Investments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        BaseCurrency = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        IsSigned = c.Boolean(nullable: false),
                        IsVerified = c.Boolean(nullable: false),
                        APR = c.Double(nullable: false),
                        LoanPercentage = c.Double(nullable: false),
                        InvestedAmount = c.Double(nullable: false),
                        InvestedAmountReturn = c.Double(nullable: false),
                        InterestAmountReturn = c.Double(nullable: false),
                        InterestAmountReturnExpect = c.Double(nullable: false),
                        TotalMonthlyReturns = c.Double(nullable: false),
                        TotalMonthlyReturnsExpected = c.Double(nullable: false),
                        MonthlyPrincipalReturn = c.Double(nullable: false),
                        MonthlyPrincipalReturnExpected = c.Double(nullable: false),
                        InvestAccount_Id = c.Int(),
                        InvestmentAsset_Id = c.Int(),
                        Loan_Id = c.Int(),
                        InvestmentApplication_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InvestmentAccounts", t => t.InvestAccount_Id)
                .ForeignKey("dbo.InvestmentAssets", t => t.InvestmentAsset_Id)
                .ForeignKey("dbo.Loans", t => t.Loan_Id)
                .ForeignKey("dbo.InvestmentApplications", t => t.InvestmentApplication_Id)
                .Index(t => t.InvestAccount_Id)
                .Index(t => t.InvestmentAsset_Id)
                .Index(t => t.Loan_Id)
                .Index(t => t.InvestmentApplication_Id);
            
            CreateTable(
                "dbo.InvestmentApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                        Months = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.InvestAccounts");
            DropTable("dbo.InvestApplications");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.InvestApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                        Months = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InvestAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        InvestCount = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Investments", "InvestmentApplication_Id", "dbo.InvestmentApplications");
            DropForeignKey("dbo.InvestmentAccountPayments", "InvestmentApplication_Id", "dbo.InvestmentApplications");
            DropForeignKey("dbo.InvestmentAssets", "InvestmentAccount_Id", "dbo.InvestmentAccounts");
            DropForeignKey("dbo.InvestmentAccountPayments", "ToAsset_Id", "dbo.InvestmentAssets");
            DropForeignKey("dbo.InvestmentAccountPayments", "InvestAccount_Id", "dbo.InvestmentAccounts");
            DropForeignKey("dbo.InvestmentAccountPayments", "FromAsset_Id", "dbo.InvestmentAssets");
            DropForeignKey("dbo.InvestmentAssets", "Production_Id", "dbo.Rates");
            DropForeignKey("dbo.Investments", "Loan_Id", "dbo.Loans");
            DropForeignKey("dbo.Investments", "InvestmentAsset_Id", "dbo.InvestmentAssets");
            DropForeignKey("dbo.Investments", "InvestAccount_Id", "dbo.InvestmentAccounts");
            DropIndex("dbo.Investments", new[] { "InvestmentApplication_Id" });
            DropIndex("dbo.Investments", new[] { "Loan_Id" });
            DropIndex("dbo.Investments", new[] { "InvestmentAsset_Id" });
            DropIndex("dbo.Investments", new[] { "InvestAccount_Id" });
            DropIndex("dbo.InvestmentAssets", new[] { "InvestmentAccount_Id" });
            DropIndex("dbo.InvestmentAssets", new[] { "Production_Id" });
            DropIndex("dbo.InvestmentAccountPayments", new[] { "InvestmentApplication_Id" });
            DropIndex("dbo.InvestmentAccountPayments", new[] { "ToAsset_Id" });
            DropIndex("dbo.InvestmentAccountPayments", new[] { "InvestAccount_Id" });
            DropIndex("dbo.InvestmentAccountPayments", new[] { "FromAsset_Id" });
            DropTable("dbo.InvestmentApplications");
            DropTable("dbo.Investments");
            DropTable("dbo.InvestmentAssets");
            DropTable("dbo.InvestmentAccountPayments");
            DropTable("dbo.InvestmentAccounts");
        }
    }
}
