namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class force : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoanPaymentParts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        PaidAmount = c.Double(nullable: false),
                        ExpectAmount = c.Double(nullable: false),
                        Loan_Id = c.Int(),
                        LoanPayment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Loans", t => t.Loan_Id)
                .ForeignKey("dbo.LoanPayments", t => t.LoanPayment_Id)
                .Index(t => t.Loan_Id)
                .Index(t => t.LoanPayment_Id);
            
            AddColumn("dbo.Loans", "EAI", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "BTI", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "BTI_Expected", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "BTI_Owed", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "BTI_Paid", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "BTP", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "BTP_Expected", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "BTP_Owed", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "BTP_Paid", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "BT", c => c.Double(nullable: false));
            AddColumn("dbo.LoanPayments", "DueDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.LoanPayments", "NotificationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.LoanPayments", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.LoanPayments", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.LoanPayments", "PaidAmount", c => c.Double(nullable: false));
            AddColumn("dbo.LoanPayments", "ExpectAmount", c => c.Double(nullable: false));
            AddColumn("dbo.LoanPayments", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.LoanPayments", "Balance", c => c.Double(nullable: false));
            AddColumn("dbo.LoanPayments", "OutStandingBalance", c => c.Double(nullable: false));
            DropColumn("dbo.Loans", "PaybackAmountPA");
            DropColumn("dbo.Loans", "PaybackAmountPM");
            DropColumn("dbo.LoanPayments", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LoanPayments", "Amount", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "PaybackAmountPM", c => c.Double(nullable: false));
            AddColumn("dbo.Loans", "PaybackAmountPA", c => c.Double(nullable: false));
            DropForeignKey("dbo.LoanPaymentParts", "LoanPayment_Id", "dbo.LoanPayments");
            DropForeignKey("dbo.LoanPaymentParts", "Loan_Id", "dbo.Loans");
            DropIndex("dbo.LoanPaymentParts", new[] { "LoanPayment_Id" });
            DropIndex("dbo.LoanPaymentParts", new[] { "Loan_Id" });
            DropColumn("dbo.LoanPayments", "OutStandingBalance");
            DropColumn("dbo.LoanPayments", "Balance");
            DropColumn("dbo.LoanPayments", "Number");
            DropColumn("dbo.LoanPayments", "ExpectAmount");
            DropColumn("dbo.LoanPayments", "PaidAmount");
            DropColumn("dbo.LoanPayments", "Type");
            DropColumn("dbo.LoanPayments", "Status");
            DropColumn("dbo.LoanPayments", "NotificationDate");
            DropColumn("dbo.LoanPayments", "DueDate");
            DropColumn("dbo.Loans", "BT");
            DropColumn("dbo.Loans", "BTP_Paid");
            DropColumn("dbo.Loans", "BTP_Owed");
            DropColumn("dbo.Loans", "BTP_Expected");
            DropColumn("dbo.Loans", "BTP");
            DropColumn("dbo.Loans", "BTI_Paid");
            DropColumn("dbo.Loans", "BTI_Owed");
            DropColumn("dbo.Loans", "BTI_Expected");
            DropColumn("dbo.Loans", "BTI");
            DropColumn("dbo.Loans", "EAI");
            DropTable("dbo.LoanPaymentParts");
        }
    }
}
