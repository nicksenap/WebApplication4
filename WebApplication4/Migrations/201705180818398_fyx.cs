namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fyx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoTypes", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.UserInfoTypes", "Properties", c => c.String());
            AlterColumn("dbo.UserInfoTypes", "CreationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserInfoTypes", "CreationDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.UserInfoTypes", "Properties");
            DropColumn("dbo.UserInfoTypes", "Type");
        }
    }
}
