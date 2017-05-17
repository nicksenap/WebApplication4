namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class redo_dat_shit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserInfoDatas", "gender");
            DropColumn("dbo.UserInfoDatas", "CivilStatus");
            DropColumn("dbo.UserInfoDatas", "Cars");
            DropColumn("dbo.UserInfoDatas", "Child");
            DropColumn("dbo.UserInfoDatas", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserInfoDatas", "Title", c => c.String());
            AddColumn("dbo.UserInfoDatas", "Child", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoDatas", "Cars", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoDatas", "CivilStatus", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoDatas", "gender", c => c.Int(nullable: false));
        }
    }
}
