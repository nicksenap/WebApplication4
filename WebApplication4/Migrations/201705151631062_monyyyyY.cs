namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class monyyyyY : DbMigration
    {
        public override void Up()
        {
            //DropIndex("dbo.AspNetUsers", "IMEIIndex");
            //DropColumn("dbo.AspNetUsers", "IMEI");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.AspNetUsers", "IMEI", c => c.String());
            //CreateIndex("dbo.AspNetUsers", "IMEI", unique: true, name: "IMEIIndex");
        }
    }
}
