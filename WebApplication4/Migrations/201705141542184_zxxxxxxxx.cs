namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zxxxxxxxx : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.LoanApplications", name: "P2PUser_Id", newName: "User_Id");
            RenameIndex(table: "dbo.LoanApplications", name: "IX_P2PUser_Id", newName: "IX_User_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.LoanApplications", name: "IX_User_Id", newName: "IX_P2PUser_Id");
            RenameColumn(table: "dbo.LoanApplications", name: "User_Id", newName: "P2PUser_Id");
        }
    }
}
