namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class monyyyy : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.AspNetUsers", "IMEI", c => c.String());
            //CreateIndex("dbo.AspNetUsers", "IMEI", unique: true, name: "IMEIIndex");
        }
        
        public override void Down()
        {
            //DropIndex("dbo.AspNetUsers", "IMEIIndex");
            //DropColumn("dbo.AspNetUsers", "IMEI");
        }
    }
}
