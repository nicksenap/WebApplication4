namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_userinfodata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoDatas", "gender", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoDatas", "CivilStatus", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoDatas", "Cars", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoDatas", "Child", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoDatas", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInfoDatas", "Title");
            DropColumn("dbo.UserInfoDatas", "Child");
            DropColumn("dbo.UserInfoDatas", "Cars");
            DropColumn("dbo.UserInfoDatas", "CivilStatus");
            DropColumn("dbo.UserInfoDatas", "gender");
        }
    }
}
