namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zxxx : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.AspNetUsers", "CreationDate", c => c.DateTime(nullable: false, storeType: "datetime", defaultValueSql:"GETDATE()"));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.AspNetUsers", "CreationDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
    }
}
