namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zXz : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CreationDate", c => c.DateTime(precision: 7, storeType: "datetime2", defaultValueSql: "GETDATE()"));
        }
        
        public override void Down()
        {
        }
    }
}
