namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zXy : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CreationDate", c => c.DateTime(defaultValueSql: "GETDATE()"));
        }
        
        public override void Down()
        {
        }
    }
}
