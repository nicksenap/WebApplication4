namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sezz : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoanRates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        VaildFromDate = c.DateTime(nullable: false),
                        VaildUntilDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        P2PScoreMax = c.Int(nullable: false),
                        P2PScoreMin = c.Int(nullable: false),
                        AmountMin = c.Int(nullable: false),
                        AmountMax = c.Int(nullable: false),
                        MonthMin = c.Int(nullable: false),
                        MonthMax = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Loans", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Loans", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Loans", "EffectiveInterestRatePA", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "EffectiveInterestRatePM", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "FlatInterestRatePM", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "FlatInterestRatePA", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "EMIInterestAmount", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "PaybackAmountPA", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "PaybackAmountPM", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "PaybackAmountTotal", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "InterestPaybackAmountTotal", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "EMI", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "APR", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "RateAPR_Id", c => c.Int());
            AddColumn("dbo.Loans", "RateEIR_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.LoanApplications", "isSigned", c => c.Boolean(nullable: false));
            AddColumn("dbo.LoanApplications", "isVerified", c => c.Boolean(nullable: false));
            AddColumn("dbo.LoanApplications", "P2PScore", c => c.Int(nullable: false));
            AddColumn("dbo.LoanApplications", "P2PUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Loans", "RateAPR_Id");
            CreateIndex("dbo.Loans", "RateEIR_Id");
            CreateIndex("dbo.LoanApplications", "P2PUser_Id");
            AddForeignKey("dbo.Loans", "RateAPR_Id", "dbo.LoanRates", "Id");
            AddForeignKey("dbo.Loans", "RateEIR_Id", "dbo.LoanRates", "Id");
            AddForeignKey("dbo.LoanApplications", "P2PUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoanApplications", "P2PUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Loans", "RateEIR_Id", "dbo.LoanRates");
            DropForeignKey("dbo.Loans", "RateAPR_Id", "dbo.LoanRates");
            DropIndex("dbo.LoanApplications", new[] { "P2PUser_Id" });
            DropIndex("dbo.Loans", new[] { "RateEIR_Id" });
            DropIndex("dbo.Loans", new[] { "RateAPR_Id" });
            DropColumn("dbo.LoanApplications", "P2PUser_Id");
            DropColumn("dbo.LoanApplications", "P2PScore");
            DropColumn("dbo.LoanApplications", "isVerified");
            DropColumn("dbo.LoanApplications", "isSigned");
            DropColumn("dbo.AspNetUsers", "Status");
            DropColumn("dbo.Loans", "RateEIR_Id");
            DropColumn("dbo.Loans", "RateAPR_Id");
            DropColumn("dbo.Loans", "APR");
            DropColumn("dbo.Loans", "EMI");
            DropColumn("dbo.Loans", "InterestPaybackAmountTotal");
            DropColumn("dbo.Loans", "PaybackAmountTotal");
            DropColumn("dbo.Loans", "PaybackAmountPM");
            DropColumn("dbo.Loans", "PaybackAmountPA");
            DropColumn("dbo.Loans", "EMIInterestAmount");
            DropColumn("dbo.Loans", "FlatInterestRatePA");
            DropColumn("dbo.Loans", "FlatInterestRatePM");
            DropColumn("dbo.Loans", "EffectiveInterestRatePM");
            DropColumn("dbo.Loans", "EffectiveInterestRatePA");
            DropColumn("dbo.Loans", "Status");
            DropColumn("dbo.Loans", "Type");
            DropTable("dbo.LoanRates");
        }
    }
}
