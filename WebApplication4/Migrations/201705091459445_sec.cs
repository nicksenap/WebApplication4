namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sec : DbMigration
    {
        public override void Up()
        {
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
            
            //CreateTable(
            //    "dbo.InvestApplications",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            CreationDate = c.DateTime(nullable: false),
            //            Amount = c.Int(nullable: false),
            //            Months = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.LoanAccounts",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            CreationDate = c.DateTime(nullable: false),
            //            Months = c.Int(nullable: false),
            //            LimitAmount = c.Double(nullable: false),
            //            TotalPayedAmountIn = c.Double(nullable: false),
            //            TotalPayedAmountOut = c.Double(nullable: false),
            //            Type = c.Int(nullable: false),
            //            Status = c.Int(nullable: false),
            //            Apr = c.Double(nullable: false),
            //            Risk = c.Int(nullable: false),
            //            User_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
            //    .Index(t => t.User_Id);
            
            //CreateTable(
            //    "dbo.Loans",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            CreationDate = c.DateTime(nullable: false),
            //            PayoutDate = c.DateTime(nullable: false),
            //            FirstDuoDate = c.DateTime(nullable: false),
            //            BaseCurrency = c.Int(nullable: false),
            //            Amount = c.Double(nullable: false),
            //            Month = c.Int(nullable: false),
            //            LoanAccount_Id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.LoanAccounts", t => t.LoanAccount_Id)
            //    .Index(t => t.LoanAccount_Id);
            
            //CreateTable(
            //    "dbo.LoanPayments",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Amount = c.Double(nullable: false),
            //            CreationDate = c.DateTime(nullable: false),
            //            Loan_Id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Loans", t => t.Loan_Id)
            //    .Index(t => t.Loan_Id);
            
            //CreateTable(
            //    "dbo.AspNetUsers",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            PersoNunmber = c.String(),
            //            CreationDate = c.DateTime(nullable: false),
            //            FirstName = c.String(),
            //            LastName = c.String(),
            //            Email = c.String(maxLength: 256),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            PhoneNumber = c.String(),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            //CreateTable(
            //    "dbo.AspNetUserClaims",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            ClaimType = c.String(),
            //            ClaimValue = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId);
            
            //CreateTable(
            //    "dbo.AspNetUserLogins",
            //    c => new
            //        {
            //            LoginProvider = c.String(nullable: false, maxLength: 128),
            //            ProviderKey = c.String(nullable: false, maxLength: 128),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId);
            
            //CreateTable(
            //    "dbo.AspNetUserRoles",
            //    c => new
            //        {
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            RoleId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.UserId, t.RoleId })
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
            //    .Index(t => t.UserId)
            //    .Index(t => t.RoleId);
            
            //CreateTable(
            //    "dbo.LoanApplications",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            CreationDate = c.DateTime(nullable: false),
            //            Amount = c.Double(nullable: false),
            //            Months = c.Int(nullable: false),
            //            UCScore = c.Double(nullable: false),
            //            UCData = c.String(),
            //            UCViews = c.Int(nullable: false),
            //            UCQueries = c.Int(nullable: false),
            //            APR = c.Double(nullable: false),
            //            DataScore = c.String(),
            //            Flag = c.Int(nullable: false),
            //            AMLData = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.AspNetRoles",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Name = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            //CreateTable(
            //    "dbo.UserChangeLogs",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            CreationDate = c.DateTime(nullable: false),
            //            TableName = c.String(),
            //            ColumnName = c.String(),
            //            RowID = c.Int(nullable: false),
            //            OriginalValue = c.String(),
            //            ChangeValue = c.String(),
            //            Editor = c.String(),
            //            IPNumber = c.String(),
            //            User_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
            //    .Index(t => t.User_Id);
            
            //CreateTable(
            //    "dbo.UserInfoDatas",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            CreationDate = c.DateTime(nullable: false),
            //            Status = c.Int(nullable: false),
            //            Data = c.String(),
            //            P2PUser_Id = c.String(maxLength: 128),
            //            UserInfoType_Id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.P2PUser_Id)
            //    .ForeignKey("dbo.UserInfoTypes", t => t.UserInfoType_Id)
            //    .Index(t => t.P2PUser_Id)
            //    .Index(t => t.UserInfoType_Id);
            
            //CreateTable(
            //    "dbo.UserInfoTypes",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            CreationDate = c.DateTime(nullable: false),
            //            Status = c.Int(nullable: false),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoDatas", "UserInfoType_Id", "dbo.UserInfoTypes");
            DropForeignKey("dbo.UserInfoDatas", "P2PUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserChangeLogs", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.LoanAccounts", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Loans", "LoanAccount_Id", "dbo.LoanAccounts");
            DropForeignKey("dbo.LoanPayments", "Loan_Id", "dbo.Loans");
            DropIndex("dbo.UserInfoDatas", new[] { "UserInfoType_Id" });
            DropIndex("dbo.UserInfoDatas", new[] { "P2PUser_Id" });
            DropIndex("dbo.UserChangeLogs", new[] { "User_Id" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.LoanPayments", new[] { "Loan_Id" });
            DropIndex("dbo.Loans", new[] { "LoanAccount_Id" });
            DropIndex("dbo.LoanAccounts", new[] { "User_Id" });
            DropTable("dbo.UserInfoTypes");
            DropTable("dbo.UserInfoDatas");
            DropTable("dbo.UserChangeLogs");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.LoanApplications");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.LoanPayments");
            DropTable("dbo.Loans");
            DropTable("dbo.LoanAccounts");
            DropTable("dbo.InvestApplications");
            DropTable("dbo.InvestAccounts");
        }
    }
}
